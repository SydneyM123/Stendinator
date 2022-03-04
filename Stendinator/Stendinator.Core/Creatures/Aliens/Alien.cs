using Stendinator.Core.Components;
using System;
using Stendinator.Core.Components.Targets;

namespace Stendinator.Core.Creatures.Aliens
{
    internal class Alien : Creature
    {
        protected override void HandleComponentActivatedComponent(ActiveComponent uc, Target e)
        {
            if (e is Entity entityArgs)
            {
                Target.Health -= entityArgs.Consequences.HealthDecrease;
            }

            throw new NotImplementedException();
        }
    }
}