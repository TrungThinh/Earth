using Earth.Data.EF.Interfaces.Entity;
using Earth.Data.EF.Interfaces.Map;
using Earth.Data.EF.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Earth.Data.EF.Services.Map
{
    public abstract class VersionEntityTypeConfiguration<T, TKey> : ITypeConfiguration<T> where T : Entity<TKey>, IVersionEntity where TKey : struct
    {
        public virtual void Map(EntityTypeBuilder<T> builder)
        {
            // Key
            builder.HasKey(x => x.Id);

            // Index
            builder.HasIndex(x => x.DeletedTime);

            // Version
            builder.Property(x => x.Version).IsRowVersion();

            // Filter
            builder.HasQueryFilter(x => x.DeletedTime == null);
        }
    }
}
