using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using MS.WebApp.MVC.Configuration;

namespace MS.WebApp.MVC
{
	public class Startup
	{
		public IConfiguration Configuration { get; }

		public Startup(IHostEnvironment hostEnvironment)
		{
			var builder = new ConfigurationBuilder()
				.SetBasePath(hostEnvironment.ContentRootPath)
				.AddJsonFile("appsetting.json", true, true)
				.AddJsonFile($"appsetting.{hostEnvironment.EnvironmentName}.json", true, true)
				.AddEnvironmentVariables();
			if (hostEnvironment.IsDevelopment())
			{
				builder.AddUserSecrets<Startup>();
			}
			Configuration = builder.Build();
		}

		public void ConfigureServices(IServiceCollection services)
		{
			services.AddIdentityConfiguration();
			services.AddMvcConfiguration(Configuration);
			services.RegisterServices(Configuration);
		}

		public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
		{
			app.UseMvcConfiguration(env);
		}
	}
}
