using EConnectMvcApp.Domain.Entities;

namespace EConnectMvcApp.Application.Interfaces;

public interface IProductService
{
    Task<IEnumerable<Product>> GetAllAsync();
    Task<Product> GetByIdAsync(int id);
    Task AddAsync(Product product);
}