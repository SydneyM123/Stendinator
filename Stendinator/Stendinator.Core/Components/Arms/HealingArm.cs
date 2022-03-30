using Stendinator.Core.Components.Targets;
using Stendinator.Core.CreatureStats;

namespace Stendinator.Core.Components.Arms
{
    public sealed class HealingArm : ActiveComponent
    {
        public HealingArm()
        {
            PassiveStats = new InfluentialStats();
            PassiveStats.HealthIncrease += 25;
            PassiveStats.DefenseIncrease += 5;
        }

        public override void Activate()
        {
            RaiseActivatedEvent(new Entity
            {
                Consequences = new InfluentialStats
                {
                    HealthIncrease = 15
                }
            });
        }
    }
}
