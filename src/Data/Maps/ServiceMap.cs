using Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data.Maps
{
    public class ServiceMap : IEntityTypeConfiguration<Service>
    {
        public void Configure(EntityTypeBuilder<Service> modelBuilder)
        {
            modelBuilder.HasKey(x => x.ServiceId);
            modelBuilder.ToTable("Services");
            modelBuilder
                .HasOne(x => x.ServicesPage)
                .WithMany(z => z.Services)
                .HasForeignKey(z => z.ServicePageId);

            modelBuilder.Property(x => x.Name).IsRequired();
            modelBuilder.Property(x => x.Price).IsRequired();
        }
    }
}