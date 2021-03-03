using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using MS.WebApp.MVC.Extensions;
using MS.WebApp.MVC.Services;
using MS.WebApp.MVC.Services.Handlers;
using Polly;
using Polly.Extensions.Http;
using Polly.Retry;
using System;
using System.Net.Http;

namespace MS.WebApp.MVC.Configuration
{
	public static class DependencyInjectionConfig
	{
		public static void RegisterServices(this IServiceCollection services, IConfiguration configuration)
		{
			services.AddTransient<HttpClientAuthorizationDelegatingHandler>();

			services.AddHttpClient<IAutenticacaoService, AutenticacaoService>();

			services.AddHttpClient<ICatalogoService, CatalogoService>()
				  .AddHttpMessageHandler<HttpClientAuthorizationDelegatingHandler>().AddPolicyHandler(PollyExtensions.EsperarTentar())
					 .AddTransientHttpErrorPolicy(
						  p => p.CircuitBreakerAsync(5, TimeSpan.FromSeconds(30)));

			//Singleton pois vai servir como suporte para toda a aplicação
			services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
			//Limitado ao escopo da requisição
			services.AddScoped<IUser, AspNetUser>();

         #region Refit

         //services.AddHttpClient("Refit",
         //        options =>
         //        {
         //            options.BaseAddress = new Uri(configuration.GetSection("CatalogoUrl").Value);
         //        })
         //    .AddHttpMessageHandler<HttpClientAuthorizationDelegatingHandler>()
         //    .AddTypedClient(Refit.RestService.For<ICatalogoServiceRefit>);

         #endregion
      }
   }

   public class PollyExtensions
   {
      public static AsyncRetryPolicy<HttpResponseMessage> EsperarTentar()
      {
         var retry = HttpPolicyExtensions
             .HandleTransientHttpError()
             .WaitAndRetryAsync(new[]
             {
                    TimeSpan.FromSeconds(1),
                    TimeSpan.FromSeconds(5),
                    TimeSpan.FromSeconds(10),
             }, (outcome, timespan, retryCount, context) =>
             {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine($"Tentando pela {retryCount} vez!");
                Console.ForegroundColor = ConsoleColor.White;
             });

         return retry;
      }
   }
}
