using Data.Entities;
using Data.Maps;
using Microsoft.EntityFrameworkCore;

namespace Data.Contexts
{
    public class BeautifulChaosContext : DbContext
    {
        public BeautifulChaosContext(DbContextOptions<BeautifulChaosContext> options) : base (options)
        {
            
        }

        public DbSet<ServicesPage> ServicesPage { get; set; }
        public DbSet<Service> Services { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ServicesPageMap());
            modelBuilder.ApplyConfiguration(new ServiceMap());
        }
    }
}
 