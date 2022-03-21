using Stendinator.Core.CreatureStats;

namespace Stendinator.Core.Components.Heads
{
    public class SturdyHead : Component
    {
        public SturdyHead()
        {
            PassiveStats = new InfluentialStats();
            PassiveStats.HealthIncrease += 10;
            PassiveStats.DefenseIncrease += 20;
        }
    }
}
