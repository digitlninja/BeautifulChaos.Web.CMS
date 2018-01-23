namespace Data.Entities
{
    public class Testimonial
    {
        public int TestimonialId { get; set; }

        // BelongsToOne
        public TestimonialsPage TestimonialsPage { get; set; }
        public int TestimonialsPageId { get; set; }

        public string TestimonialContent { get; set; }
    }
}