using Microsoft.EntityFrameworkCore;
using EConnectMvcApp.Domain.Entities;
using EConnectMvcApp.Infrastructure.Data;
using EConnectMvcApp.Application.Interfaces;

namespace EConnectMvcApp.Infrastructure.Repositories;

public class ProductRepository : IProductRepository
{
    private readonly AppDbContext _context;

    public ProductRepository(AppDbContext context)
    {
        _context = context;
    }

    public async Task<IEnumerable<Product>> GetAllAsync()
        => await _context.Products.ToListAsync();

    public async Task<Product> GetByIdAsync(int id)
        => await _context.Products.FindAsync(id);

    public async Task AddAsync(Product product)
    {
        await _context.Products.AddAsync(product);
        await _context.SaveChangesAsync();
    }
}