using EConnectMvcApp.Application.Interfaces;
using EConnectMvcApp.Domain.Entities;
//using EConnectMvcApp.Infrastructure.Repositories;

namespace EConnectMvcApp.Application.Services;

public class ProductService : IProductService
{
    private readonly IProductRepository _repo;

    public ProductService(IProductRepository repo)
    {
        _repo = repo;
    }

    public async Task<IEnumerable<Product>> GetAllAsync()
        => await _repo.GetAllAsync();

    public async Task<Product> GetByIdAsync(int id)
        => await _repo.GetByIdAsync(id);

    public async Task AddAsync(Product product)
        => await _repo.AddAsync(product);
}