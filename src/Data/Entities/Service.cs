using Data.Entities.Common;

namespace Data.Entities
{
    public class Service : EntityBase
    {
        public int ServiceId { get; set; }

        // HasOne
        public ServicesPage ServicesPage { get; set; }
        public int ServicePageId { get; set; }

        public string Name { get; set; }
        public double Price { get; set; }
    }
}
