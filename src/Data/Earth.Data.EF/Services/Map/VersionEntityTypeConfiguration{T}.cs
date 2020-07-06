using Earth.Data.EF.Interfaces.Entity;
using Earth.Data.EF.Models;

namespace Earth.Data.EF.Services.Map
{
    public abstract class VersionEntityTypeConfiguration<T> : VersionEntityTypeConfiguration<T, int> where T : Entity, IVersionEntity
    {
    }
}
