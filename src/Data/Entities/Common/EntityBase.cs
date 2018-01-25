using System;

namespace Data.Entities.Common
{
    public class EntityBase
    {
        public Guid UUId { get; set; }

        public DateTimeOffset? CreatedAt { get; set; }
        public DateTimeOffset? UpdatedAt { get; set; }

        public DateTimeOffset? DeletedAt { get; set; }

        public EntityBase()
        {
            this.UUId = Guid.NewGuid();
            this.CreatedAt = DateTimeOffset.Now;
            this.UpdatedAt = DateTimeOffset.Now; // set on save/update
        }
       
    }
}
