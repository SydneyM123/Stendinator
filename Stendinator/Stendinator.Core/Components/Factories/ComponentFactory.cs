using System;
using System.Collections.Generic;
using Stendinator.Core.Components.Arms;
using Stendinator.Core.Components.Heads;
using Stendinator.Core.Components.Legs;

namespace Stendinator.Core.Components.Factories
{
    internal abstract class ComponentFactory : Component
    {
        public abstract Component Create();
           
        public string[] GetNames()
        {
            return new[] 
            { 
                nameof(FlameThrowerArm), 
                nameof(ChainsawArm), 
                nameof(HealingArm), 
                nameof(ShieldArm), 
                nameof(StunGunArm), 
                nameof(BalancedBody), 
                nameof(HealthyBody), 
                nameof(SturdyBody), 
                nameof(BalancedHead), 
                nameof(HealthyHead), 
                nameof(SturdyHead), 
                nameof(HealthyLeg), 
                nameof(BalancedLeg), 
                nameof(SturdyLeg) 
            };
        }
    }
}