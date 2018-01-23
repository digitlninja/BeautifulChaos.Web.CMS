using Data.Entities.Common;

namespace Data.Entities
{
    public class ContentColumn : EntityBase
    {
        public int ContentColumnId { get; set; }
        
        // Belongs To Only One
        public Page Page { get; set; }
        public int PageId { get; set; }

        public string Title { get; set; }
        public string Paragraph { get; set; }
        public string Image { get; set; }
        public string PageName { get; set; }
    }
}