using Core.Entities;

namespace Core.Interface;

public interface IProductRepository
{
    Task<IReadOnlyList<Product>> GetProductsAsync();
    Task<Product> GetProductByIdAsync(int id);
}