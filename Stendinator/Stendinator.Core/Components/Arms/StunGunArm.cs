using Stendinator.Core.Components.Targets;
using Stendinator.Core.CreatureStats;

namespace Stendinator.Core.Components.Arms
{
    public sealed class StunGunArm : ActiveComponent
    {
        public StunGunArm()
        {
            PassiveStats = new InfluentialStats();
            PassiveStats.HealthIncrease += 10;
            PassiveStats.DefenseIncrease += 5;
        }

        public override void Activate()
        {
            RaiseActivatedEvent(new Entity
            {
                Consequences = new InfluentialStats
                {
                    HealthDecrease = 5,
                    DefenseDecrease = 15
                }
            });
        }
    }
}
