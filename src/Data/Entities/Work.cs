using System.Collections.Generic;
using Data.Entities.Common;

namespace Data.Entities
{
    public class Work : EntityBase
    {
        public int WorkPageId { get; set; }
        public int PageId { get; set; }

        // HasMany
        public virtual ICollection<Image> Images { get; set; }

        public string HeaderTitle { get; set; }
        public string HeaderParagraph { get; set; }
    }
}
