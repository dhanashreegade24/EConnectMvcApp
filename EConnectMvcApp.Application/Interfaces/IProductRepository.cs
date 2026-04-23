using System.Collections.Generic;
using System.Threading.Tasks;
using EConnectMvcApp.Domain.Entities;

namespace EConnectMvcApp.Application.Interfaces;

public interface IProductRepository
{
    Task<IEnumerable<Product>> GetAllAsync();
    Task<Product> GetByIdAsync(int id);
    Task AddAsync(Product product);
}