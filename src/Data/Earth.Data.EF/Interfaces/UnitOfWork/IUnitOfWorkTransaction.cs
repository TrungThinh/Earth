using System;
using Earth.Core.ActionUtils;

namespace Earth.Data.EF.Interfaces.UnitOfWork
{
    public interface IUnitOfWorkTransaction : IDisposable
    {
        ActionCollection ActionsBeforeCommit { get; set; }

        ActionCollection ActionsAfterCommit { get; set; }

        ActionCollection ActionsBeforeRollback { get; set; }

        ActionCollection ActionsAfterRollback { get; set; }

        void Commit();

        void Rollback();
    }
}
