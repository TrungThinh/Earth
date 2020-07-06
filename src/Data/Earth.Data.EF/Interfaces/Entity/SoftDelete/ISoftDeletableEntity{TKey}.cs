using System;
using System.Collections.Generic;
using System.Text;

namespace Earth.Data.EF.Interfaces.Entity.SoftDelete
{
    public interface ISoftDeletableEntity<TKey> : ISoftDeletableEntity where TKey : struct
    {
    }
}
