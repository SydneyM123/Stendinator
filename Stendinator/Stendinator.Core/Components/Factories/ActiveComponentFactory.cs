using Stendinator.Core.Components.Arms;

namespace Stendinator.Core.Components.Factories
{
    public class ActiveComponentFactory : IActiveComponentFactory
    {
        public ActiveComponent Create(string name, bool malicious)
        {
            return name switch
            {
                nameof(ChainsawArm) => new StunGunArm(malicious),
                nameof(FlameThrowerArm) => new StunGunArm(malicious),
                nameof(HealingArm) => new StunGunArm(malicious),
                nameof(ShieldArm) => new StunGunArm(malicious),
                nameof(StunGunArm) => new StunGunArm(malicious),
                _ => throw new Exception($"Component not found {name}")
            };
        }

        public string[] GetNames()
        {
            return new[]
            {
                nameof(ChainsawArm),
                nameof(FlameThrowerArm),
                nameof(HealingArm),
                nameof(ShieldArm),
                nameof(StunGunArm)
            };
        }
    }
}