using Stendinator.Core.Components.Targets;
using Stendinator.Core.CreatureStats;

namespace Stendinator.Core.Components.Arms
{
    public sealed class ShieldArm : ActiveComponent
    {
        public ShieldArm()
        {
            PassiveStats = new InfluentialStats();
            PassiveStats.HealthIncrease += 15;
            PassiveStats.DefenseIncrease += 15;
        }
        public override void Activate()
        {
            RaiseActivatedEvent(new Entity
            {
                Consequences = new InfluentialStats
                {
                    DefenseIncrease = 15
                }
            });
        }
    }
}
