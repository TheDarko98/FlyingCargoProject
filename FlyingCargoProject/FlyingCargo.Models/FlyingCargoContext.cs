using Microsoft.EntityFrameworkCore;

namespace FlyingCargoProject.Models
{
    public class FlyingCargoContext : DbContext
    {
        public FlyingCargoContext(DbContextOptions<FlyingCargoContext> options)
            : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }
    }
}
