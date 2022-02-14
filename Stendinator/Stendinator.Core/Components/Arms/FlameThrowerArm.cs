using Stendinator.Core.Components;
using Stendinator.Core.CreatureStats;

namespace Stendinator.Core.Robots.Arms
{
    public sealed class FlameThrowerArm : ActiveComponent
    {
        public override void Use()
        {
            RaiseUsedEvent(new ComponentUsedOnEntityArgs
            {
                Consequences = new InfluentialStats
                {
                    HealthDecrease = 10
                }
            });
        }
    }
}