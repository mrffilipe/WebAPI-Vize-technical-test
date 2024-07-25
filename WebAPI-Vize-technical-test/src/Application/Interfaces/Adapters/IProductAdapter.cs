namespace WebAPI_Vize_technical_test.src.Application
{
    public interface IProductAdapter
    {
        Task<ProductResponseDTO> GetByIdAsync(Guid id);
        Task<IEnumerable<ProductResponseDTO>> GetAllAsync();
        Task AddAsync(ProductCreateDTO product);
        Task UpdateAsync(ProductUpdateDTO product);
        Task DeleteAsync(Guid id);
    }
}