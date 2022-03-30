using System;
using System.Collections.Generic;
using Stendinator.Core.Components.Arms;
using Stendinator.Core.Components.Heads;
using Stendinator.Core.Components.Legs;

namespace Stendinator.Core.Components.Factories
{
    internal class ComponentFactory : IComponentFactory
    {
        public Component Create(string name)
        {
            switch (name)
            {
                case nameof(FlameThrowerArm):
                    return new FlameThrowerArm();
                case nameof(ChainsawArm):
                    return new ChainsawArm();
                case nameof(HealingArm):
                    return new HealingArm();
                case nameof(ShieldArm):
                    return new ShieldArm();
                case nameof(StunGunArm):
                    return new StunGunArm();
                case nameof(BalancedBody):
                    return new BalancedBody();
                case nameof(HealthyBody):
                    return new HealthyBody();
                case nameof(SturdyBody):
                    return new SturdyBody();
                case nameof(BalancedHead):
                    return new BalancedHead();
                case nameof(HealthyHead):
                    return new HealthyHead();
                case nameof(SturdyHead):
                    return new SturdyHead();
                case nameof(HealthyLeg):
                    return new HealthyLeg();
                case nameof(BalancedLeg):
                    return new BalancedLeg();
                case nameof(SturdyLeg):
                    return new SturdyLeg();
                
                default:
                    throw new Exception("Component not found...");
            }
        }

        public string[] GetNames()
        {
            return new[] { nameof(FlameThrowerArm), nameof(ChainsawArm), nameof(HealingArm), nameof(ShieldArm), nameof(StunGunArm), nameof(BalancedBody), nameof(HealthyBody), nameof(SturdyBody), nameof(BalancedHead), nameof(HealthyHead), nameof(SturdyHead), nameof(HealthyLeg), nameof(BalancedLeg), nameof(SturdyLeg) };
        }
    }
}