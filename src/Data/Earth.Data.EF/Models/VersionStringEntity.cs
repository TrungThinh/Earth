using Earth.Data.EF.Interfaces.Entity;

namespace Earth.Data.EF.Models
{
    public class VersionStringEntity : StringEntity, IVersionEntity
    {
        public byte[] Version { get; set; }
    }
}
