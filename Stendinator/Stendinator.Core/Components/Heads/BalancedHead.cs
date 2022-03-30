using Stendinator.Core.CreatureStats;

namespace Stendinator.Core.Components.Heads
{
    public class BalancedHead : Component
    {
        public BalancedHead()
        {
            PassiveStats = new InfluentialStats();
            PassiveStats.HealthIncrease += 15;
            PassiveStats.DefenseIncrease += 15;
        }
    }
}
