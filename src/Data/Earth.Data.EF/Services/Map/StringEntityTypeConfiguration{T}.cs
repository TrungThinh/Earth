using Earth.Data.EF.Interfaces.Map;
using Earth.Data.EF.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Earth.Data.EF.Services.Map
{
    public abstract class StringEntityTypeConfiguration<T> : ITypeConfiguration<T> where T : StringEntity
    {
        public virtual void Map(EntityTypeBuilder<T> builder)
        {
            // Key
            builder.HasKey(x => x.Id);

            // Index
            builder.HasIndex(x => x.DeletedTime);

            // Filter
            builder.HasQueryFilter(x => x.DeletedTime == null);
        }
    }
}
