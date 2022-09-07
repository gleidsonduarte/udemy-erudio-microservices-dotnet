using Microsoft.EntityFrameworkCore;

namespace GeekShopping.ProductAPI.Models.Context
{
    public class MySQLContext : DbContext
    {
        public MySQLContext() { }
        public MySQLContext(DbContextOptions<MySQLContext> options) : base(options) { }

        public DbSet<Product> Products { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 1,
                Name = "iPhone",
                Price = new decimal(5999.99),
                Description = "Celular caro",
                ImageUrl = "http://imagem.iphone",
                CategoryName = "Mobile"
            });

            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 2,
                Name = "S7",
                Price = new decimal(2999.99),
                Description = "Celular mediano",
                ImageUrl = "http://imagem.s7",
                CategoryName = "Mobile"
            });

            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 3,
                Name = "Mi A3",
                Price = new decimal(1499.99),
                Description = "Celular Barato",
                ImageUrl = "http://imagem.mia3",
                CategoryName = "Mobile"
            });
        }
    }
}
