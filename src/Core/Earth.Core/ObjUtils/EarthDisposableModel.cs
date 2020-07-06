using System;
using System.Collections.Generic;
using System.Text;

namespace Earth.Core.ObjUtils
{
    public abstract class EarthDisposableModel: IDisposable
    {
        private bool IsDisposed { get; set; }

        public void Dispose()
        {
            Dispose(true);

            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool isDisposing)
        {
            if (IsDisposed)
            {
                return;
            }

            if (isDisposing)
            {
                DisposeUnmanagedResources();
            }

            IsDisposed = true;
        }


        protected virtual void DisposeUnmanagedResources() { }

        ~EarthDisposableModel()
        {
            Dispose(false);
        }
    }
}
