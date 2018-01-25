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
        public DbSet<ContentColumn> ContentColumn { get; set; }
        public DbSet<About> About { get; set; }
        public DbSet<TestimonialsPage> TestimonialsPage { get; set; }
        public DbSet<Testimonial> Testimonial { get; set; }
        public DbSet<Page> Page { get; set; }
        public DbSet<Work> Work { get; set; }
        public DbSet<Image> Images { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ContentColumnMap());
            modelBuilder.ApplyConfiguration(new PageMap());

            modelBuilder.ApplyConfiguration(new ServiceMap());
            modelBuilder.ApplyConfiguration(new ServicesPageMap());

            modelBuilder.ApplyConfiguration(new AboutMap());

            modelBuilder.ApplyConfiguration(new TestimonialsPageMap());
            modelBuilder.ApplyConfiguration(new TestimonialMap());

            modelBuilder.ApplyConfiguration(new WorkMap());
            modelBuilder.ApplyConfiguration(new ImageMap());
        }
    }
}
 