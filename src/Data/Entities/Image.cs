using Data.Entities.Common;

namespace Data.Entities
{
    public class Image : EntityBase
    {
        public int ImageId { get; set; }

        // BelongsToOne
        public Work Work { get; set; }
        public int PageId { get; set; }

        public string Title { get; set; }
        public string AltText { get; set; }
        public string Url { get; set; }
        public string Page { get; set; }
    }
}
