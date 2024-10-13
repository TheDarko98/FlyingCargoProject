using FlyingCargoProject.Models;
using System.Linq.Expressions;

namespace FlyingCargoProject.Api.Repositories.Interfaces
{
    public interface IProductRepository
    {
        Task<Product> GetProductByIdAsync(int productId);
        Task<IEnumerable<Product>> GetProductsAsync(Expression<Func<Product, bool>> filter = null);
        Task AddProductAsync(Product product);
        Task UpdateProductAsync(Product product);
        Task DeleteProductAsync(int productId);
    }
}
