using WebAPI_Vize_technical_test.src.Application;

namespace WebAPI_Vize_technical_test.src.Infrastructure
{
    public static class AdapterExtension
    {
        public static IServiceCollection AddAdapters(this IServiceCollection services)
        {
            services.AddScoped<IProductAdapter, ProductAdapter>();
            services.AddScoped<IDashboardAdapter, DashboardAdapter>();

            return services;
        }
    }
}