using System.Collections.Generic;

namespace CMS.Models
{
    public class WorkModel
    {
        public int UUId { get; set; }
        public int PageId { get; set; }

        // HasMany
        public virtual ICollection<ImageModel> Images { get; set; }

        public string HeaderTitle { get; set; }
        public string HeaderParagraph { get; set; }
    }
}
