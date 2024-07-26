using Microsoft.EntityFrameworkCore;
using WebAPI_Vize_technical_test.src.Domain;

namespace WebAPI_Vize_technical_test.src.Infrastructure
{
    public class ProductRepository : IProductRepository
    {
        private readonly ApplicationDbContext _context;

        public ProductRepository(ApplicationDbContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public async Task<Product> GetByIdAsync(Guid id)
        {
            if (id == Guid.Empty)
                throw new ArgumentException("Id cannot be empty", nameof(id));

            var product = await _context.Products.FirstOrDefaultAsync(x => x.Id == id);

            if (product == null)
                throw new KeyNotFoundException("Product not found");

            return product;
        }

        public async Task<IEnumerable<Product>> GetAllAsync()
        {
            return await _context.Products.ToListAsync();
        }

        public async Task<Product> AddAsync(Product product)
        {
            if (product == null)
                throw new ArgumentNullException(nameof(product));

            await _context.Products.AddAsync(product);
            await _context.SaveChangesAsync();

            return product;
        }

        public async Task<Product> UpdateAsync(Product existing, Product updated)
        {
            if (existing == null)
                throw new ArgumentNullException(nameof(existing));

            if (updated == null)
                throw new ArgumentNullException(nameof(updated));

            _context.Entry(existing).CurrentValues.SetValues(updated);
            existing.UpdateUnitPrice(updated.UnitPrice);
            _context.Entry(existing).State = EntityState.Modified;

            await _context.SaveChangesAsync();
            return existing;
        }

        public async Task DeleteAsync(Guid id)
        {
            if (id == Guid.Empty)
                throw new ArgumentException("Id cannot be empty", nameof(id));

            var product = await _context.Products.FirstOrDefaultAsync(x => x.Id == id);

            if (product == null)
                throw new KeyNotFoundException("Product not found");

            _context.Products.Remove(product);
            await _context.SaveChangesAsync();
        }
    }
}