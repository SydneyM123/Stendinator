using Stendinator.Core.Creatures;

namespace Stendinator.Core.Components.Targets
{
    public abstract class Target
    {
        public Creature TargetCreature;
        public abstract void SetTarget(Creature t);
    }
}