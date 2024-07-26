using AutoMapper;
using WebAPI_Vize_technical_test.src.Domain;

namespace WebAPI_Vize_technical_test.src.Application
{
    public class ProductAdapter : IProductAdapter
    {
        private readonly IMapper _mapper;
        private readonly IProductService _productService;

        public ProductAdapter(IMapper mapper, IProductService productService)
        {
            _mapper = mapper;
            _productService = productService;
        }

        public async Task<ProductResponseDTO> GetByIdAsync(Guid id)
        {
            var product = await _productService.GetByIdAsync(id);

            return _mapper.Map<ProductResponseDTO>(product);
        }

        public async Task<IEnumerable<ProductResponseDTO>> GetAllAsync()
        {
            var products = await _productService.GetAllAsync();

            return _mapper.Map<IEnumerable<ProductResponseDTO>>(products);
        }

        public async Task<ProductResponseDTO> AddAsync(ProductCreateDTO product)
        {
            var mapped = _mapper.Map<Product>(product);

            var addedProduct = await _productService.AddAsync(mapped);
            return _mapper.Map<ProductResponseDTO>(addedProduct);
        }

        public async Task<ProductResponseDTO> UpdateAsync(ProductUpdateDTO product)
        {
            var mapped = _mapper.Map<Product>(product);

            var updatedProduct = await _productService.UpdateAsync(mapped);
            return _mapper.Map<ProductResponseDTO>(updatedProduct);
        }

        public async Task DeleteAsync(Guid id)
        {
            await _productService.DeleteAsync(id);
        }
    }
}