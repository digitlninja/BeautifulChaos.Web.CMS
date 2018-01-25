using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CMS.Models
{
    public class TestimonialsPageModel
    {
        public Guid UUId{ get; set; }

        // BelongsToOne
        public PageModel Page { get; set; }
        public int PageId { get; set; }

        // HasMany
        public virtual ICollection<TestimonialModel> Testimonials { get; set; }

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
