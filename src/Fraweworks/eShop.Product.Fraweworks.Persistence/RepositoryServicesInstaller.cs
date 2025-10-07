using Microsoft.Extensions.DependencyInjection;
using eShop.Product.Frameworks.Types;

namespace eShop.Product.Frameworks.Persistence;

public static class RepositoryServicesInstaller
{
    public static IServiceCollection AddRepositoryServices(this IServiceCollection services)
    {
        services.AddScoped<IProductRepository, ProductRepository>()
            ;
        return services;
    }
}
