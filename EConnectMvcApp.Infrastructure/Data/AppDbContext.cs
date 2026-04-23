using Microsoft.EntityFrameworkCore;
using EConnectMvcApp.Domain.Entities;
using System.Collections.Generic;

namespace EConnectMvcApp.Infrastructure.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options) { }

    public DbSet<Product> Products => Set<Product>();
}