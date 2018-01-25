using Data.Entities.Common;

namespace Data.Entities
{
    public class Testimonial :EntityBase
    {
        public int TestimonialId { get; set; }

        // BelongsToOne
        public TestimonialsPage TestimonialsPage { get; set; }
        public int TestimonialsPageId { get; set; }

        public string TestimonialContent { get; set; }
    }
}