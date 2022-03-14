using Stendinator.Core.Components.Targets;
using Stendinator.Core.CreatureStats;

namespace Stendinator.Core.Components.Arms
{
    public sealed class ChainsawArm : ActiveComponent
    {
        public ChainsawArm()
        {
            PassiveStats = new InfluentialStats();
            PassiveStats.HealthIncrease += 5;
            PassiveStats.DefenseIncrease += 10;
        }
        public override void Activate()
        {
            RaiseActivatedEvent(new Entity
            {
                Consequences = new InfluentialStats
                {
                    HealthDecrease = 17
                }
            });
        }
    }
}
