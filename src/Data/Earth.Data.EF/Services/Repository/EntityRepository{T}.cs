using Earth.Data.EF.Interfaces.DbContext;
using Earth.Data.EF.Models;

namespace Earth.Data.EF.Services.Repository
{
    public abstract class EntityRepository<T> : EntityRepository<T, int> where T : Entity, new()
    {
        protected EntityRepository(IDbContext dbContext) : base(dbContext)
        {
        }
    }
}
