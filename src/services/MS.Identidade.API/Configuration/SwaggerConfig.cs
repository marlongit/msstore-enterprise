﻿using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MS.Identidade.API.Configuration
{
	public static class SwaggerConfig
	{
		public static IServiceCollection AddSwaggerApiConfiguration(this IServiceCollection services)
		{
			services.AddSwaggerGen(c => c.SwaggerDoc("v1", new OpenApiInfo
			{
				Title = "MS - Store Enterprise Identity API",
				Description = "API responsável por realizar a atutenticação de toda a MS - Store",
				Contact = new OpenApiContact()
				{
					Name = "Marlon Everson",
					Email = "marlon-marlon@hotmail.com",
					Url = new System.Uri("https://marlonoliveira.azurewebsites.net/")
				},
				License = new OpenApiLicense()
				{
					Name = "MIT",
					Url = new System.Uri("https://opensource.org/licenses/MIT")
				}
			}));

			return services;
		}

		public static IApplicationBuilder UseSwaggerApiConfiguration(this IApplicationBuilder app)
		{
			app.UseSwagger();
			app.UseSwaggerUI(c =>
			{
				c.SwaggerEndpoint("/swagger/v1/swagger.json", "v1");
			});

			return app;
		}
	}
}
