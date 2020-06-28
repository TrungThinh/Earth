using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Earth.Data.EF.Interfaces.DbContext
{
    public interface IDbContext: IDisposable, IInfrastructure<IServiceProvider>
    {
        DatabaseFacade Database { get; }

        ChangeTracker ChangeTracker { get; }

        IModel Model { get; }

        DbSet<TEntity> Set<TEntity>() where TEntity : class;

        #region Save

        [DebuggerStepThrough]
        int SaveChanges();

        [DebuggerStepThrough]
        int SaveChanges(bool acceptAllChangesOnSuccess);

        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);

        Task<int> SaveChangesAsync(bool acceptAllChangesOnSuccess, CancellationToken cancellationToken = default);

        #endregion

        #region Entry

        EntityEntry<TEntity> Entry<TEntity>(TEntity entity) where TEntity : class;

        EntityEntry Entry(object entity);

        #endregion

        #region Add

        EntityEntry<TEntity> Add<TEntity>(TEntity entity) where TEntity : class;

        EntityEntry Add(object entity);

        ValueTask<EntityEntry<TEntity>> AddAsync<TEntity>(TEntity entity, CancellationToken cancellationToken = default(CancellationToken)) where TEntity : class;

        ValueTask<EntityEntry> AddAsync(object entity, CancellationToken cancellationToken = default);

        void AddRange(params object[] entities);

        void AddRange(IEnumerable<object> entities);

        Task AddRangeAsync(params object[] entities);

        Task AddRangeAsync(IEnumerable<object> entities, CancellationToken cancellationToken = new CancellationToken());

        #endregion

        #region Attach

        EntityEntry<TEntity> Attach<TEntity>(TEntity entity) where TEntity : class;

        EntityEntry Attach(object entity);

        void AttachRange(params object[] entities);

        void AttachRange(IEnumerable<object> entities);

        #endregion

        #region Update

        EntityEntry<TEntity> Update<TEntity>(TEntity entity) where TEntity : class;

        EntityEntry Update(object entity);

        void UpdateRange(params object[] entities);

        void UpdateRange(IEnumerable<object> entities);

        #endregion

        #region Remove

        EntityEntry<TEntity> Remove<TEntity>(TEntity entity) where TEntity : class;

        EntityEntry Remove(object entity);

        void RemoveRange(params object[] entities);

        void RemoveRange(IEnumerable<object> entities);

        #endregion

        #region SQL Command, Query

        DbCommand CreateCommand(string text, CommandType type = CommandType.Text, params SqlParameter[] parameters);

        void ExecuteCommand(string text, CommandType type = CommandType.Text, params SqlParameter[] parameters);

        List<T> ExecuteQuery<T>(string text, CommandType type = CommandType.Text, params SqlParameter[] parameters) where T : class, new();

        #endregion
    }
}
