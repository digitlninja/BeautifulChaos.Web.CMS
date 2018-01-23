using Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data.Maps
{
    public class TestimonialMap : IEntityTypeConfiguration<Testimonial>
    {
        public void Configure(EntityTypeBuilder<Testimonial> modelBuilder)
        {
            var testimonials = modelBuilder;
            testimonials.ToTable("Testimonials");

            testimonials
                .HasOne(x => x.TestimonialsPage)
                .WithMany(z => z.Testimonials)
                .HasForeignKey(z => z.TestimonialsPageId);

        }
    }
}