namespace WebAPI_Vize_technical_test.src.Application
{
    public interface IProductAdapter
    {
        Task<ProductResponseDTO> GetByIdAsync(Guid id);
        Task<IEnumerable<ProductResponseDTO>> GetAllAsync();
        Task<ProductResponseDTO> AddAsync(ProductCreateDTO product);
        Task<ProductResponseDTO> UpdateAsync(ProductUpdateDTO product);
        Task DeleteAsync(Guid id);
    }
}