﻿using WebAPI_Vize_technical_test.src.Domain;

namespace WebAPI_Vize_technical_test.src.Application
{
    public class ProductAdapter : IProductAdapter
    {
        private readonly IProductService _productService;

        public ProductAdapter(IProductService productService)
        {
            _productService = productService;
        }

        public async Task<ProductResponseDTO> GetByIdAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<ProductResponseDTO>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public async Task AddAsync(ProductCreateDTO product)
        {
            throw new NotImplementedException();
        }

        public async Task UpdateAsync(ProductUpdateDTO product)
        {
            throw new NotImplementedException();
        }

        public async Task DeleteAsync(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}