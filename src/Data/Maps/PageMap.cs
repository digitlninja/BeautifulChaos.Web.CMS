using Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data.Maps
{
    public class PageMap : IEntityTypeConfiguration<Page>
    {
        public void Configure(EntityTypeBuilder<Page> modelBuilder)
        {
            var page = modelBuilder;

            page.HasKey(x => x.PageId);

            page
                .HasMany(x => x.ContentColumns)
                .WithOne(z => z.Page);

            page
                .HasOne(x => x.About)
                .WithOne(z => z.Page);

            page
                .HasOne(x => x.ServicesPage)
                .WithOne(z => z.Page);
        }
    }
}
