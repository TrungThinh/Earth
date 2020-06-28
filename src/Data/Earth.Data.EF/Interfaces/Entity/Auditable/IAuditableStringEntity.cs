using System;
using System.Collections.Generic;
using System.Text;

namespace Earth.Data.EF.Interfaces.Entity.Auditable
{
    public interface IAuditableStringEntity : IAuditableEntity
    {
        string CreatedBy { get; set; }

        string LastUpdatedBy { get; set; }
    }
}
