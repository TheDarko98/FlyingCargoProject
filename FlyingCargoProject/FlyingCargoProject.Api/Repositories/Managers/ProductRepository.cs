using FlyingCargoProject.Api.Repositories.Interfaces;
using FlyingCargoProject.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace FlyingCargoProject.Api.Repositories.Managers
{
    public class ProductRepository : IProductRepository
    {
        private readonly FlyingCargoContext _context;

        public ProductRepository(FlyingCargoContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public async Task<IEnumerable<Product>> GetProductsAsync(Expression<Func<Product, bool>> filter = null)
        {
            if (filter != null)
            {
                return await _context.Products.Where(filter).ToListAsync();
            }

            return await _context.Products.ToListAsync();
        }

        public async Task<Product> GetProductByIdAsync(int productId)
        {
            return await _context.Products.FindAsync(productId);
        }

        public async Task AddProductAsync(Product product)
        {
            _context.Products.Add(product); 
        }

        public async Task UpdateProductAsync(Product product)
        {
            _context.Products.Update(product); 
        }

        public async Task DeleteProductAsync(int productId)
        {
            var product = await _context.Products.FindAsync(productId);
            if (product != null)
            {
                _context.Products.Remove(product); 
            }
        }
    }
}
