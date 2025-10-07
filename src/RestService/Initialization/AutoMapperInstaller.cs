namespace eShop.Product.RestService.Initialization;

internal static class AutoMapperInstaller
{
    public static IServiceCollection AddAutoMapperConfiguration(this IServiceCollection services)
    {
        services.AddAutoMapper(typeof(AutoMapperInstaller).Assembly);
        return services;
    }
}
