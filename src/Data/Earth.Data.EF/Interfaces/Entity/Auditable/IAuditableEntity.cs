using System;
using System.Collections.Generic;
using System.Text;

namespace Earth.Data.EF.Interfaces.Entity.Auditable
{
    public interface IAuditableEntity
    {
        DateTimeOffset CreatedTime { get; set; }

        DateTimeOffset LastUpdatedTime { get; set; }
    }
}
