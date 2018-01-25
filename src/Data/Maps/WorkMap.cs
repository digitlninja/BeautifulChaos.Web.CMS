using Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data.Maps
{
    public class WorkMap : IEntityTypeConfiguration<Work>
    {
        public void Configure(EntityTypeBuilder<Work> modelBuilder)
        {
            var work = modelBuilder;

            work.HasKey(x => x.PageId);

            work.HasMany(x => x.Images)
                .WithOne(z => z.Work);

        }
    }
}