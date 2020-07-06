using Earth.Data.EF.Interfaces.Entity;

namespace Earth.Data.EF.Models
{
    public abstract class VersionEntity<TKey> : Entity<TKey>, IVersionEntity where TKey : struct
    {
        public byte[] Version { get; set; }
    }
}
