using Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data.Maps
{
    public class ImageMap : IEntityTypeConfiguration<Image>
    {
        public void Configure(EntityTypeBuilder<Image> modelBuilder)
        {
            var image = modelBuilder;

            image.HasKey(x => x.ImageId);
            image.ToTable("Images");

            image.HasOne(x => x.Work)
                .WithMany(z => z.Images)
                .HasForeignKey(z => z.PageId);

        }
    }
}