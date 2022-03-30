using Stendinator.Core.CreatureStats;

namespace Stendinator.Core.Components.Legs
{
    public class HealthyLeg : Component
    {
        public HealthyLeg()
        {
            PassiveStats = new InfluentialStats();
            PassiveStats.HealthIncrease += 15;
            PassiveStats.DefenseIncrease += 5;
        }
    }
}
