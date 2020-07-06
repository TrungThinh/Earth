using System;
using System.Collections.Generic;
using System.Linq;
using Earth.Core.ActionUtils.Models;
using Earth.Core.LinqUtils;
using Earth.Core.ObjUtils;

namespace Earth.Core.ActionUtils
{
    public class ActionCollection : EarthDisposableModel
    {
        protected List<ActionModel> Actions { get; set; } = new List<ActionModel>();

        public virtual List<ActionModel> Get()
        {
            return Actions;
        }

        public virtual string Add(Action action)
        {
            var actionModel = new ActionModel(action);

            Actions.Add(actionModel);

            return actionModel.Id;
        }

        public virtual void Remove(string actionId)
        {
            Actions = Actions.RemoveWhere(x => x.Id == actionId).ToList();
        }

        public virtual void Empty()
        {
            if (Actions?.Any() != true)
            {
                return;
            }

            Actions = Actions.RemoveWhere(x => x.Action != null).ToList();
        }

        protected override void DisposeUnmanagedResources()
        {
            if (Actions?.Any() != true)
            {
                return;
            }

            foreach (var actionModel in Actions)
            {
                actionModel.Dispose();
            }
        }
    }
}
