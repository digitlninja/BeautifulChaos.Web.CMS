
using System;

namespace CMS.Models
{
    public class ImageModel
    {
        public Guid UUId { get; set; }

        // BelongsToOne
        public WorkModel Work { get; set; }
        public int PageId { get; set; }

        public string Title { get; set; }
        public string AltText { get; set; }
        public string Url { get; set; }
        public string Page { get; set; }
    }
}
