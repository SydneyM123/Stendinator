using Stendinator.Core.Creatures;
using Stendinator.Core.Creatures.Aliens;
using Stendinator.Core.Creatures.Cyborgs;
using Stendinator.Core.CreatureStats;

namespace Stendinator.Core.Components.Targets
{
    public class Entity : Target
    {
        public Entity()
        {
        }
        public InfluentialStats Consequences { get; set; }

        public override void SetTarget(Creature t)
        {
            if (t is Cyborg)
            {
                TargetCreature = new Cyborg();
                TargetCreature = t;
            }
            else
            {
                TargetCreature = new Alien();
                TargetCreature = t;
            }
        }
    }
}