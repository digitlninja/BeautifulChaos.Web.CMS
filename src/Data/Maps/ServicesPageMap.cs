using Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data.Maps
{
    public class ServicesPageMap : IEntityTypeConfiguration<ServicesPage>
    {
        public void Configure(EntityTypeBuilder<ServicesPage> modelBuilder)
        {
            // Keys
            modelBuilder
                .HasKey(x => x.ServicesPageId);

            // Relationships
            modelBuilder
                .HasMany(a => a.Services)
                .WithOne(b => b.ServicesPage)
                .HasForeignKey(b => b.ServiceId);

            // Properties
            modelBuilder
                .Property(x => x.HeaderTitle)
                .IsRequired();

            modelBuilder
                .Property(x => x.HeaderParagraph)
                .IsRequired();

            modelBuilder
                .Property(x => x.Content1Header)
                .IsRequired().IsRequired();

            modelBuilder
                .Property(x => x.Content1Paragraph)
                .IsRequired();

            modelBuilder
                .Property(x => x.FeatureLeftIcon)
                .IsRequired();

            modelBuilder
                .Property(x => x.FeatureLeftParagraph)
                .IsRequired();

            modelBuilder
                .Property(x => x.FeatureLeftTitle)
                .IsRequired();

            modelBuilder
                .Property(x => x.FeatureMidIcon)
                .IsRequired();

            modelBuilder
                .Property(x => x.FeatureMidParagraph)
                .IsRequired();

            modelBuilder
                .Property(x => x.FeatureMidtTitle)
                .IsRequired();

            modelBuilder
                .Property(x => x.FeatureRightIcon)
                .IsRequired();

            modelBuilder
                .Property(x => x.FeatureRightParagraph)
                .IsRequired();

            modelBuilder
                .Property(x => x.FeatureRightTitle)
                .IsRequired();
        }
    }
}