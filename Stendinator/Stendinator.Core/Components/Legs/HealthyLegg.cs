using Stendinator.Core.CreatureStats;

namespace Stendinator.Core.Components.Legs
{
    public class HealthyLegg : Component
    {
        public HealthyLegg()
        {
            PassiveStats = new InfluentialStats();
            PassiveStats.HealthIncrease += 15;
            PassiveStats.DefenseIncrease += 5;
        }
    }
}
