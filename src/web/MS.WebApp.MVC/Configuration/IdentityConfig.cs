using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace MS.WebApp.MVC.Configuration
{
	public static class IdentityConfig
	{
		public static void AddIdentityConfiguration(this IServiceCollection services)
		{
			services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
				.AddCookie(Options=> {
					Options.LoginPath = "/login";
					Options.AccessDeniedPath = "/acesso-negado";
				});
		}

		public static void UseIdentityConfiguration(this IApplicationBuilder app)
		{
			app.UseAuthentication();
			app.UseAuthorization();
		}
	}
}
