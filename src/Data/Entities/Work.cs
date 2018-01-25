using System.Collections.Generic;

namespace Data.Entities
{
    public class Work
    {
        public int WorkPageId { get; set; }
        public int PageId { get; set; }

        // HasMany
        public virtual ICollection<Image> Images { get; set; }

        public string HeaderTitle { get; set; }
        public string HeaderParagraph { get; set; }
    }
}
