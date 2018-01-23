using System.Collections.Generic;
using Data.Entities.Common;

namespace Data.Entities
{
    public class TestimonialsPage : EntityBase
    {
        public int TestimonialsPageId { get; set; }

        // BelongsToOne
        public Page Page { get; set; }
        public int PageId { get; set; }

        // HasMany
        public virtual ICollection<Testimonial> Testimonials { get; set; }

        public string HeaderTitle { get; set; }

        public string ContentSectionHeader { get; set; }
        public string ContentSectionParagraph { get; set; }

        public string LeftContentTitle { get; set; }
        public string LeftContentParagraph { get; set; }

        public string MiddleContentTitle { get; set; }
        public string MiddleContentParagraph { get; set; }


        public string RightContentTitle { get; set; }
        public string RightContentParagraph { get; set; }
    }
}