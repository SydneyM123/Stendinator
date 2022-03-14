using Stendinator.Core.Components.Targets;
using Stendinator.Core.CreatureStats;

namespace Stendinator.Core.Components
{
    public abstract class ActiveComponent : Component
    {
        public delegate void Activated(ActiveComponent c, Target e);

        public event Activated ComponentActivated;
        public override InfluentialStats PassiveStats {get; set;}
        public abstract void Activate();

        protected void RaiseActivatedEvent(Target e)
        {
            ComponentActivated?.Invoke(this, e);
        }
    }
}