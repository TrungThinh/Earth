using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Earth.Data.EF.Interfaces.Map
{
    public interface ITypeConfiguration<T> where T : class
    {
        void Map(EntityTypeBuilder<T> builder);
    }
}
