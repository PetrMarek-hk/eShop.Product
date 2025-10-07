//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace eShop.Product.ApplicationLogic
//{
//    internal class AppLogicServicesInstaller
//    {
//    }
//}


namespace eShop.Product.ApplicationLogic;

using eShop.Product.ApplicationLogic.Interfaces;
using eShop.Product.Frameworks.Persistence;

using Microsoft.Extensions.DependencyInjection;

public static class AppLogicServicesInstaller
{
    /// <summary>
    /// Extension method for IServiceCollection to register application logic services/interactors.
    /// </summary> <param name="services"> The DI service instance. </param>
    /// <returns> Returns IServiceCollection. </returns>
    public static IServiceCollection AddApplicationLogicServices(this IServiceCollection services)
    {
        services.AddRepositoryServices();
        return services.AddInteractors()
                .AddSingleton<IRequestToInteractorMapper, RequestToInteractorMapper>()
                .AddScoped<IeShopApplicationLogic, eShopApplicationLogic>();
    }

    private static IServiceCollection AddInteractors(this IServiceCollection services)
    {
        var assembly = typeof(AppLogicServicesInstaller).Assembly;
        var interactorTypes = assembly.GetTypes()
            .Where(t => t.IsClass && !t.IsAbstract && t.GetCustomAttributes(typeof(RequestToInteractorMappingAttribute), false).Any());

        foreach (var interactorType in interactorTypes)
        {
            services.AddScoped(interactorType);
        }

        return services;
    }
}

