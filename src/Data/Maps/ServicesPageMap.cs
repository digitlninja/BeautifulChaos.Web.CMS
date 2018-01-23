using Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data.Maps
{
    public class ServicesPageMap : IEntityTypeConfiguration<ServicesPage>
    {
        public void Configure(EntityTypeBuilder<ServicesPage> modelBuilder)
        {
            var servicesPage = modelBuilder;

            servicesPage
                .HasKey(x => x.ServicesPageId);

            servicesPage
                .HasMany(x => x.Services)
                .WithOne(z => z.ServicesPage);

            servicesPage
                .HasOne(x => x.Page) // ServicesPage Side
                .WithOne(c => c.ServicesPage)
                .HasForeignKey<ServicesPage>(c => c.PageId); // Defines the Page side
        }
    }
}