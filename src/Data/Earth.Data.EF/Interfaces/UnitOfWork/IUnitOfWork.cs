using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;
using Earth.Core.ActionUtils;
using Earth.Data.EF.Models;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace Earth.Data.EF.Interfaces.UnitOfWork
{
    public interface IUnitOfWork
    {
        FuncCollection<IEnumerable<EntityEntry>, bool> FunctionsBeforeSaveChanges { get; }

        ActionCollection<EntityStateCollection> ActionsAfterSaveChanges { get; }

        ActionCollection ActionsBeforeCommit { get; }

        ActionCollection ActionsAfterCommit { get; }

        ActionCollection ActionsBeforeRollback { get; }

        ActionCollection ActionsAfterRollback { get; }

        #region Transaction

        IUnitOfWorkTransaction BeginTransaction(IsolationLevel isolationLevel);

        IUnitOfWorkTransaction BeginTransaction();

        Task<IUnitOfWorkTransaction> BeginTransactionAsync(CancellationToken cancellationToken = default);

        Task<IUnitOfWorkTransaction> BeginTransactionAsync(IsolationLevel isolationLevel,
            CancellationToken cancellationToken = default);

        #endregion

        #region Save

        [DebuggerStepThrough]
        int SaveChanges();

        [DebuggerStepThrough]
        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);

        [DebuggerStepThrough]
        int SaveChanges(bool acceptAllChangesOnSuccess);

        [DebuggerStepThrough]
        Task<int> SaveChangesAsync(bool acceptAllChangesOnSuccess, CancellationToken cancellationToken = default);

        #endregion

        #region SQL Command

        DbCommand CreateCommand(string text, CommandType type, params SqlParameter[] parameters);

        void ExecuteCommand(string text, CommandType type, params SqlParameter[] parameters);

        List<T> ExecuteQuery<T>(string text, CommandType type, params SqlParameter[] parameters)
            where T : class, new();

        #endregion
    }
}
