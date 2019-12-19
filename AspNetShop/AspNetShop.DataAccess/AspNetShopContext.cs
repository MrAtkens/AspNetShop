using Microsoft.EntityFrameworkCore;
using AspNetShop.Domain;

namespace AspNetShop.DataAccess
{
    public class AspNetShopContext : DbContext
    {
        public AspNetShopContext(DbContextOptions options) : base(options)
        {
            Database.Migrate();
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<FavoriteProduct> FavoriteProducts { get; set; }
        public DbSet<ProductInOrder> ProductInOrders { get; set; }
        public DbSet<ProductInCart> ProductInCarts { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Cart> Carts { get; set; }
    }
}
