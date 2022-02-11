using Stendinator.Core.Components;
using System;

namespace Stendinator.Core.Creatures.Aliens
{
    internal class Alien : Creature
    {
        protected override void HandleUsedComponent(ActiveComponent uc, ComponentUsedArgs e)
        {
            if (e is ComponentUsedOnEntityArgs entityArgs)
            {
                Focused.Health -= entityArgs.Consequences.HealthDecrease;
            }

            throw new NotImplementedException();
        }
    }
}