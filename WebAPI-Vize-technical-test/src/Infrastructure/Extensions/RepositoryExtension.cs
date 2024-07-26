using WebAPI_Vize_technical_test.src.Domain;

namespace WebAPI_Vize_technical_test.src.Infrastructure
{
    public static class RepositoryExtension
    {
        public static IServiceCollection AddRepositories(this IServiceCollection services)
        {
            services.AddScoped<IProductRepository, ProductRepository>();

            return services;
        }
    }
}