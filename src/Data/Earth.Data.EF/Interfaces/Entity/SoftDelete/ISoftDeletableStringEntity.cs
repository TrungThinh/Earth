using System;
using System.Collections.Generic;
using System.Text;

namespace Earth.Data.EF.Interfaces.Entity.SoftDelete
{
    public interface ISoftDeletableStringEntity: ISoftDeletableEntity
    {
        string DeletedBy { get; set; }
    }
}
