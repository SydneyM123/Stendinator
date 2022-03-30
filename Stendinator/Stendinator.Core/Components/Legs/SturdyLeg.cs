using Stendinator.Core.CreatureStats;

namespace Stendinator.Core.Components.Legs
{
    public class SturdyLeg : Component
    {
        public SturdyLeg()
        {
            PassiveStats = new InfluentialStats();
            PassiveStats.HealthIncrease += 5;
            PassiveStats.DefenseIncrease += 15;
        }
    }
}
