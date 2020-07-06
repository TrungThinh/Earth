using System;
using Earth.Core.ObjUtils;

namespace Earth.Core.ActionUtils.Models
{
    public class ActionModel<T> : EarthDisposableModel
    {
        public string Id { get; set; } = Guid.NewGuid().ToString("N");

        public Action<T> Action { get; set; }

        public ActionModel(Action<T> action)
        {
            Action = action;
        }
    }
}
