using Stendinator.Core.CreatureStats;

namespace Stendinator.Core.Components.Legs
{
    public class BalancedLeg : Component
    {
        public BalancedLeg()
        {
            PassiveStats = new InfluentialStats();
            PassiveStats.HealthIncrease += 13;
            PassiveStats.DefenseIncrease += 12;
        }
    }
}