using Fiorello_PB101.Data;
using Fiorello_PB101.Models;
using Fiorello_PB101.Services.Interfaces;
using Fiorello_PB101.ViewModels.Products;
using Microsoft.EntityFrameworkCore;

namespace Fiorello_PB101.Services
{
    public class ProductService : IProductService
    {
        private readonly AppDbContext _context;
        public ProductService(AppDbContext context)
        {
            _context = context;
        }

        public async Task CreateAsync(Product product)
        {
            await _context.Products.AddAsync(product);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(Product product)
        {
            _context.Products.Remove(product);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Product>> GetAllAsync()
        {
            return await _context.Products.Include(m => m.Category)
                                          .Include(m => m.ProductImages)
                                          .ToListAsync();
        }

        public async Task<IEnumerable<Product>> GetAllPaginateAsync(int page, int take)
        {
            return await _context.Products.Include(m => m.Category)
                                          .Include(m => m.ProductImages)
                                          .Skip((page - 1) * take)
                                          .Take(take)
                                          .ToListAsync();
        }

        public async Task<IEnumerable<Product>> GetAllWithImageAsync()
        {
            return await _context.Products.Include(m => m.ProductImages).ToListAsync();
        }

        public async Task<Product> GetByIdAsync(int id)
        {
            return await _context.Products.FindAsync(id);
        }

        public async Task<Product> GetByWithAllDatasAsync(int id)
        {
            return await _context.Products.Where(m => m.Id == id)
                                            .Include(m => m.Category)
                                            .Include(m => m.ProductImages)
                                            .FirstOrDefaultAsync();
        }

        public async Task<int> GetCountAsync()
        {
            return await _context.Products.CountAsync();
        }

        public IEnumerable<ProductVM> GetMappedDatas(IEnumerable<Product> products)
        {
            return products.Select(m => new ProductVM
            {
                Id = m.Id,
                Name = m.Name,
                CategoryName = m.Category.Name,
                Price = m.Price,
                Description = m.Description,
                MainImage = m.ProductImages.FirstOrDefault().Name
            });


        }

        public async Task UpdateAsync(Product product)
        {
            _context.Entry(product).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }
    }
}
