using Stendinator.Core.CreatureStats;

namespace Stendinator.Core.Components.Heads
{
    public class HealthyBody : Component
    {
        public HealthyBody()
        {
            PassiveStats = new InfluentialStats();
            PassiveStats.HealthIncrease += 40;
            PassiveStats.DefenseIncrease += 20;
        }
    }
}
