using Stendinator.Core.CreatureStats;

namespace Stendinator.Core.Components.Heads
{
    public class SturdyBody : Component
    {
        public SturdyBody()
        {
            PassiveStats = new InfluentialStats();
            PassiveStats.HealthIncrease += 20;
            PassiveStats.DefenseIncrease += 40;
        }
    }
}