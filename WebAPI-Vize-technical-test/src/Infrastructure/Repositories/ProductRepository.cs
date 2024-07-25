using Microsoft.EntityFrameworkCore;
using WebAPI_Vize_technical_test.src.Domain;

namespace WebAPI_Vize_technical_test.src.Infrastructure
{
    public class ProductRepository : IProductRepository
    {
        private readonly ApplicationDbContext _context;

        public ProductRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Product> GetByIdAsync(Guid id)
        {
            var result = await _context.Products.FirstOrDefaultAsync(x => x.Id.Equals(id));

            return result;
        }

        public async Task<IEnumerable<Product>> GetAllAsync()
        {
            var result = await _context.Products.ToListAsync();

            return result;
        }

        public async Task<Product> AddAsync(Product product)
        {
            await _context.Products.AddAsync(product);

            await _context.SaveChangesAsync();

            return product;
        }

        public async Task<Product> UpdateAsync(Product product)
        {
            var result = await GetByIdAsync(product.Id);

            result = product;

            _context.Entry(result).State = EntityState.Modified;

            await _context.SaveChangesAsync();

            return result;
        }

        public async Task DeleteAsync(Guid id)
        {
            var result = await _context.Products.FirstOrDefaultAsync(x => x.Id.Equals(id));

            _context.Remove(result);

            await _context.SaveChangesAsync();
        }
    }
}