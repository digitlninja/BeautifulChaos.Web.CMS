using Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data.Maps
{
    public class TestimonialsPageMap : IEntityTypeConfiguration<TestimonialsPage>
    {
        public void Configure(EntityTypeBuilder<TestimonialsPage> modelBuilder)
        {
            var testimonialsPage = modelBuilder;
            testimonialsPage.HasKey(x => x.TestimonialsPageId);

            testimonialsPage
                .HasOne(x => x.Page)
                .WithOne(z => z.TestimonialsPage)
                .HasForeignKey<TestimonialsPage>(z => z.PageId);

            testimonialsPage
                .HasMany(x => x.Testimonials)
                .WithOne(z => z.TestimonialsPage);

        }
    }
}