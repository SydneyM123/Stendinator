using Stendinator.Core.CreatureStats;

namespace Stendinator.Core.Components.Legs
{
    public class SturdyLegg : Component
    {
        public SturdyLegg()
        {
            PassiveStats = new InfluentialStats();
            PassiveStats.HealthIncrease += 5;
            PassiveStats.DefenseIncrease += 15;
        }
    }
}
