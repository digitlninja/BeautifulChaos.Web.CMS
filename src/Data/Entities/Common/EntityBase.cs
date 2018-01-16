using System;

namespace Data.Entities.Common
{
    public class EntityBase
    {
        public Guid UUId { get; set; }

        public DateTimeOffset CreatedAt { get; set; }
        public DateTimeOffset UpdatedAt { get; set; }

        public DateTimeOffset DeletedAt { get; set; }

        public EntityBase()
        {
            if(this.CreatedAt == null)
                this.CreatedAt = DateTimeOffset.Now;

            this.UpdatedAt = DateTimeOffset.Now;

            
        }

        public EntityBase(string tableName)
        {
            if (this.CreatedAt == null)
                this.CreatedAt = DateTimeOffset.Now;

            this.UpdatedAt = DateTimeOffset.Now;

        }
    }
}
