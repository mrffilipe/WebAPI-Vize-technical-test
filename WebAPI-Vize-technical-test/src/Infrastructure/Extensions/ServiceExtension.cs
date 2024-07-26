using WebAPI_Vize_technical_test.src.Application;
using WebAPI_Vize_technical_test.src.Domain;

namespace WebAPI_Vize_technical_test.src.Infrastructure
{
    public static class ServiceExtension
    {
        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            services.AddScoped<IProductService, ProductService>();
            services.AddScoped<IDashboardService, DashboardService>();

            return services;
        }
    }
}