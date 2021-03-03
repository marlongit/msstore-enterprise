using Microsoft.Extensions.DependencyInjection;
using MS.Catalogo.API.Data;
using MS.Catalogo.API.Data.Repository;
using MS.Catalogo.API.Models;

namespace MS.Catalogo.API.Configuration
{
    public static class DependencyInjectionConfig
    {
        public static void RegisterServices(this IServiceCollection services)
        {
            services.AddScoped<IProdutoRepository, ProdutoRepository>();
            services.AddScoped<CatalogoContext>();
        }
    }
}