using Microsoft.EntityFrameworkCore;

namespace EShop.Models
{
    public class EShopContext : DbContext
    {
        public DbSet<Client> Clients { get; set; } = null!;
        public DbSet<Order> Orders { get; set; } = null!;

        public EShopContext(DbContextOptions<EShopContext> options)
             : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder ob)
        {
            ob.UseInMemoryDatabase("EShopDb");
        }

        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<Client>().HasKey(key => key.ClientIdentity);
            mb.Entity<Order>().HasOne<Client>().WithMany().HasForeignKey("ClientIdentity");
        }
    }
}
