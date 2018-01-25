using System;
using Data.Entities;

namespace CMS.Models
{
    public class TestimonialModel
    {
        public Guid UUId{ get; set; }

        // BelongsToOne
        public TestimonialsPageModel TestimonialsPage { get; set; }
        public int TestimonialsPageId { get; set; }

        public string TestimonialContent { get; set; }
    }
}
