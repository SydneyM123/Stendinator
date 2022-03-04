using Stendinator.Core.CreatureStats;

namespace Stendinator.Core.Components
{
    public abstract class ActiveComponent : Component
    {
        public delegate void Activated(ActiveComponent c, Target e);

        public event Activated ComponentActivated;

        public abstract void Activate();

        protected void RaiseActivatedEvent(Target e)
        {
            ComponentActivated?.Invoke(this, e);
        }
    }

    public abstract class Target
    {
    }

    internal class Entity : Target
    {
        public InfluentialStats Consequences { get; set; }
    }
}