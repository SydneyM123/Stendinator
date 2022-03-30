using Stendinator.Core.CreatureStats;

namespace Stendinator.Core.Components.Heads
{
    public class BalancedBody : Component
    {
        public BalancedBody()
        {
            PassiveStats = new InfluentialStats();
            PassiveStats.HealthIncrease += 30;
            PassiveStats.DefenseIncrease += 30;
        }
    }
}
