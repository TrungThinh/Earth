using Earth.Data.EF.Interfaces.Map;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Earth.Data.EF.Services.Map
{
    public abstract class TypeConfiguration<T> : ITypeConfiguration<T> where T : class
    {
        public virtual void Map(EntityTypeBuilder<T> builder)
        {
        }
    }
}
