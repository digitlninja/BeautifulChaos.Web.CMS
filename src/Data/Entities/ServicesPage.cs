using System.Collections.Generic;
using Data.Entities.Common;

namespace Data.Entities
{
    public class ServicesPage : EntityBase
    {
        public int ServicesPageId { get; set; }

        // HasMany
        public virtual ICollection<Service> Services { get; set; }
        public int ServiceId { get; set; }

        public string HeaderTitle { get; set; }
        public string HeaderParagraph { get; set; }

        public string ServiceSection1Title { get; set; }
        public string ServiceSection2Title { get; set; }
        public string ServiceSection3Title { get; set; }

        public string Content1Header { get; set; }
        public string Content1Paragraph { get; set; }

        public ContentRow FeatureLeft { get; set; }
        public ContentRow FeatureMiddle { get; set; }
        public ContentRow FeatureRight { get; set; }

        public ServicesPage()
        {
            this.FeatureLeft = new ContentRow();
        }

        }
    }
