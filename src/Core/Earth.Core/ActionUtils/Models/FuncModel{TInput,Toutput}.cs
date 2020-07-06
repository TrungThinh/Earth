using System;
using Earth.Core.ObjUtils;

namespace Earth.Core.ActionUtils.Models
{
    public class FuncModel<TInput, TOutput> : EarthDisposableModel
    {
        public string Id { get; set; } = Guid.NewGuid().ToString("N");

        public Func<TInput, TOutput> Func { get; set; }

        public FuncModel(Func<TInput, TOutput> func)
        {
            Func = func;
        }
    }
}
