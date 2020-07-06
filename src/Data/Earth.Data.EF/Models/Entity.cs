using System;
using Earth.Data.EF.Interfaces.Entity;

namespace Earth.Data.EF.Models
{
    public abstract class Entity : Entity<int>, IGlobalIdentityEntity
    {
        public Guid GlobalId { get; set; }
    }
}
