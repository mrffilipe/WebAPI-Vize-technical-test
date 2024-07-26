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
            var products = await _productRepository.GetAllAsync();

            var materialCount = products.Count(p => p.Type == ProductType.Material);
            var materialAveragePrice = materialCount > 0 ?
                products.Where(p => p.Type == ProductType.Material).Average(p => p.UnitPrice.Value) : 0;

            var serviceCount = products.Count(p => p.Type == ProductType.Service);
            var serviceAveragePrice = serviceCount > 0 ?
                products.Where(p => p.Type == ProductType.Service).Average(p => p.UnitPrice.Value) : 0;

            var material = new DashboardItemVO(materialCount, materialAveragePrice);
            var service = new DashboardItemVO(serviceCount, serviceAveragePrice);

            return new DashboardVO(material, service);
        }
    }
}