using Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data.Maps
{
    public class ContentColumnMap : IEntityTypeConfiguration<ContentColumn>
    {
        public void Configure(EntityTypeBuilder<ContentColumn> modelBuilder)
        {
            var contentColumn = modelBuilder;
            contentColumn.HasKey(x => x.ContentColumnId);
            contentColumn.ToTable("ContentColumns");

            contentColumn
                .HasOne(x => x.Page)
                .WithMany(z => z.ContentColumns)
                .HasForeignKey(z => z.PageId);
        }
    }
}