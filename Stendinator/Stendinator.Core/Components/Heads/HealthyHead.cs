using Stendinator.Core.CreatureStats;

namespace Stendinator.Core.Components.Heads
{
    public class HealthyHead : Component
    {
        public HealthyHead()
        {
            PassiveStats = new InfluentialStats();
            PassiveStats.HealthIncrease += 20;
            PassiveStats.DefenseIncrease += 10;
        }
    }
}
