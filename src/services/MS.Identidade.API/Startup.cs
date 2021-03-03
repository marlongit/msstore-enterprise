using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using MS.Identidade.API.Configuration;

namespace MS.Identidade.API
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

		// This method gets called by the runtime. Use this method to add services to the container.
		public void ConfigureServices(IServiceCollection services)
		{
			services.AddIdentityApiConfiguration(Configuration);

			services.AddApiConfiguration();

			services.AddSwaggerApiConfiguration();
		}

		// This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
		public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
		{

			app.UseSwaggerApiConfiguration();
			app.UseApiConfiguration(env);
		}
	}
}
