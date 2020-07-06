using System;
using System.Collections.Generic;
using System.Text;

namespace Earth.Data.EF.Interfaces.Entity
{
    public interface IGlobalIdentityEntity
    {
        Guid GlobalId { get; set; }
    }
}
