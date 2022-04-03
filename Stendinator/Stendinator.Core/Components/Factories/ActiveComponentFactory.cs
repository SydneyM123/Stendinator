using Stendinator.Core.Components.Arms;

namespace Stendinator.Core.Components.Factories
{
    public class ActiveComponentFactory : IActiveComponentFactory
    {
        public ActiveComponent Create(string name, bool malicious)
        {
            return name switch
            {
                nameof(ChainsawArm) => new ChainsawArm(malicious),
                nameof(FlameThrowerArm) => new FlameThrowerArm(malicious),
                nameof(HealingArm) => new HealingArm(malicious),
                nameof(ShieldArm) => new ShieldArm(malicious),
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