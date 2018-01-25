using System.Collections.Generic;
using Data.Entities.Common;

namespace Data.Entities
{
    public class Page : EntityBase
    {
        public int PageId { get; set; }
        public string PageName { get; set; }

        // HasMany
        public virtual ICollection<ContentColumn> ContentColumns { get; set; }

        // HasOne
        public About About { get; set; }
        public ServicesPage ServicesPage { get; set; }
        public TestimonialsPage TestimonialsPage { get; set; }
    }
}
