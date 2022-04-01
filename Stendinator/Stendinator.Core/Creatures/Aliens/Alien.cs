using Stendinator.Core.Components;
using System;
using Stendinator.Core.Components.Arms;
using Stendinator.Core.Components.Targets;

namespace Stendinator.Core.Creatures.Aliens
{
    public class Alien : Creature
    {
        public Alien()
        {
        }

        public override void HandleActivatedComponent(ActiveComponent ac, Target e)
        {
            if (!(e is Entity entityArgs)) return;
            if (ac is HealingArm || ac is ShieldArm)
            {
                this.Health += entityArgs.Consequences.HealthIncrease;
                this.Defense += entityArgs.Consequences.DefenseIncrease;
                return;
            }
            Target.Health -= entityArgs.Consequences.HealthDecrease;
            Target.Defense -= entityArgs.Consequences.DefenseDecrease;
        }
    }
}