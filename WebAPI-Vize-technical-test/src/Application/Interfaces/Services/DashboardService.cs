using WebAPI_Vize_technical_test.src.Domain;

namespace WebAPI_Vize_technical_test.src.Application
{
    public class DashboardService : IDashboardService
    {
        private readonly IProductRepository _productRepository;

        public DashboardService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public async Task<DashboardVO> GetDashboardAsync()
        {
            throw new NotImplementedException();
        }
    }
}