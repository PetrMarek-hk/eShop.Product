using Microsoft.EntityFrameworkCore;

namespace eShop.Product.Frameworks.Types
{
    public class ProductContext : DbContext
    {
        public ProductContext(DbContextOptions<ProductContext> options)
            : base(options) { }

        public DbSet<eShop.Product.Frameworks.Types.Product> Products { get; set; } = null!;
    }
}
