using System;
using Earth.Core.ObjUtils;
using Earth.Data.EF.Interfaces.Entity.Auditable;
using Earth.Data.EF.Interfaces.Entity.SoftDelete;

namespace Earth.Data.EF.Models
{
    public abstract class BaseEntity : EarthDisposableModel, ISoftDeletableEntity, IAuditableEntity
    {
        protected BaseEntity()
        {
            CreatedTime = LastUpdatedTime = DateTimeOffset.UtcNow;
        }

        public DateTimeOffset CreatedTime { get; set; }

        public DateTimeOffset LastUpdatedTime { get; set; }

        public DateTimeOffset? DeletedTime { get; set; }
    }
}
