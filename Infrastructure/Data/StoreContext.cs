using Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data;

public class StoreContext(DbContextOptions<StoreContext> options) : DbContext(options)
{
    public DbSet<Product> Products { get; set; }
    public DbSet<ProductType> ProductTypes { get; set; }
    public DbSet<ProductBrand> ProductBrands { get; set; }

    // protected override void OnModelCreating(ModelBuilder modelBuilder)
    // {
    //     modelBuilder.Entity<Product>().HasData(
    //         new Product {Id = 1, Name = "Product 1"},
    //         new Product {Id = 2, Name = "Product 2"},
    //         new Product {Id = 3, Name = "Product 3"}
    //     );
    // }
}