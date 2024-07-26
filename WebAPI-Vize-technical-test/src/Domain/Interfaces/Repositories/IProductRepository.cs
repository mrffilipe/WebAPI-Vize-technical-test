namespace WebAPI_Vize_technical_test.src.Domain
{
    public interface IProductRepository
    {
        Task<Product> GetByIdAsync(Guid id);
        Task<IEnumerable<Product>> GetAllAsync();
        Task<Product> AddAsync(Product product);
        Task<Product> UpdateAsync(Product existing, Product updated);
        Task DeleteAsync(Guid id);
    }
}