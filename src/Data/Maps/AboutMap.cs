using Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data.Maps
{
    public class AboutMap : IEntityTypeConfiguration<About>
    {
        public void Configure(EntityTypeBuilder<About> modelBuilder)
        {
            var about = modelBuilder;

            about
                .HasOne(x => x.Page)
                .WithOne(z => z.About)
                .HasForeignKey<About>(z => z.PageId);

        }
    }
}