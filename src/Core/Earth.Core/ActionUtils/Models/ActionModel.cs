using System;
using Earth.Core.ObjUtils;

namespace Earth.Core.ActionUtils.Models
{
    public class ActionModel : EarthDisposableModel
    {
        public string Id { get; set; } = Guid.NewGuid().ToString("N");

        public Action Action { get; set; }

        public ActionModel(Action action)
        {
            Action = action;
        }
    }
}
