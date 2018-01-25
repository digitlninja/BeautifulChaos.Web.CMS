using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Data.Entities;

namespace CMS.Models
{
    public class AboutModel
    {
        public Guid UUId { get; set; }

        // BelongsToOne
        public Page Page { get; set; }
        public int PageId { get; set; }

        public string HeaderTitle { get; set; }
        public string HeaderParagraph { get; set; }

        public string Content1Header { get; set; }
        public string Content1Paragraph { get; set; }

        public string TeamTitle { get; set; }
        public string TeamParagraph { get; set; }

        public string DescriptionBlock1Header { get; set; }
        public string DescriptionBlock1Image { get; set; }
        public string DescriptionBlock1Paragraph { get; set; }

        public string DescriptionBlock2Header { get; set; }
        public string DescriptionBlock2Image { get; set; }
        public string DescriptionBlock2Paragraph { get; set; }

        public string AboutImage1 { get; set; }
        public string AboutImage2 { get; set; }
        public string AboutImage3 { get; set; }
    }
}
