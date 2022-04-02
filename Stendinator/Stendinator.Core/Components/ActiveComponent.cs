using Stendinator.Core.Components.Targets;

namespace Stendinator.Core.Components
{
    public abstract class ActiveComponent : Component
    {
        public event Activated ComponentActivated;
        public delegate void Activated(ActiveComponent c, CreatureTarget e);
        
        /// <summary>
        /// Actives the component and decides what the influential stats are
        /// </summary>
        public abstract void Activate();

        /// <summary>
        /// This method will only be called by implementation of Activate
        /// </summary>
        /// <param name="e">The influential stats for the Target Creature</param>
        protected void RaiseActivatedEvent(CreatureTarget e)
        {
            ComponentActivated?.Invoke(this, e);
        }
    }
}