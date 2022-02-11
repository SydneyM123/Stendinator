using Stendinator.Core.CreatureStats;
using System;

namespace Stendinator.Core.Components
{
    public abstract class ActiveComponent : Component
    {
        public delegate void ComponentUsed(ActiveComponent c, ComponentUsedArgs e);

        public event ComponentUsed Used;

        public abstract void Use();

        protected void RaiseUsedEvent(ComponentUsedArgs e)
        {
            Used.Invoke(this, e);
        }
    }

    public abstract class ComponentUsedArgs : EventArgs
    {
    }

    internal class ComponentUsedOnEntityArgs : ComponentUsedArgs
    {
        public InfluentialStats Consequences { get; set; }
    }
}