using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;
using MS.Identidade.API.Data;
using MS.Identidade.API.Extensions;
using System.Text;

namespace MS.Identidade.API.Configuration
{
	public static class IdentityConfig
	{
		public static IServiceCollection AddIdentityApiConfiguration(this IServiceCollection services, IConfiguration configuration)
		{
			services.AddDbContext<ApplicationDbContext>(optionsAction: options => options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));

			services.AddIdentity<IdentityUser, IdentityRole>()
				.AddErrorDescriber<IdentityMensagensPortugues>()
				.AddEntityFrameworkStores<ApplicationDbContext>()
				.AddDefaultTokenProviders();

			//JWT
			var appSettingsSection = configuration.GetSection("AppSettings");
			services.Configure<AppSettings>(appSettingsSection);
			var appSettings = appSettingsSection.Get<AppSettings>();
			var key = Encoding.ASCII.GetBytes(appSettings.Secret);

			//Configuração do JWT na aplicação
			services.AddAuthentication(options =>
			{
				options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
				options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
			}).AddJwtBearer(bearerOption =>
			{
				bearerOption.RequireHttpsMetadata = true;
				bearerOption.SaveToken = true;
				bearerOption.TokenValidationParameters = new Microsoft.IdentityModel.Tokens.TokenValidationParameters
				{
					ValidateIssuerSigningKey = true,
					IssuerSigningKey = new SymmetricSecurityKey(key),
					ValidateIssuer = true,
					ValidateAudience = true,// Informa que o dominio que será validado
													//ValidAudiences = new List<string>() { }, validando a lista de dominios
					ValidAudience = appSettings.ValidoEm,
					ValidIssuer = appSettings.Emissor
				};
			});

			return services;
		}

		public static IApplicationBuilder UseIdentityApiConfiguration(this IApplicationBuilder app)
		{
			app.UseAuthentication();
			app.UseAuthorization();

			return app;
		}
	}
}
