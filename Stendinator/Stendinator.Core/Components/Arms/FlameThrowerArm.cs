using Stendinator.Core.Components.Targets;
using Stendinator.Core.CreatureStats;

namespace Stendinator.Core.Components.Arms
{
    public sealed class FlameThrowerArm : ActiveComponent
    {
        public FlameThrowerArm()
        {
            PassiveStats = new InfluentialStats();
            PassiveStats.HealthIncrease += 8;
            PassiveStats.DefenseIncrease += 7;
        }
        public override void Activate()
        {
            RaiseActivatedEvent(new Entity
            {
                Consequences = new InfluentialStats
                {
                    HealthDecrease = 10,
                    DefenseDecrease = 5
                }
            }); 
        }

        public InfluentialStats getPassiveStats()
        {
            return PassiveStats;
        }
    }
}