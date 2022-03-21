using Stendinator.Core.CreatureStats;

namespace Stendinator.Core.Components.Heads
{
    public class SturyBody : Component
    {
        public SturyBody()
        {
            PassiveStats = new InfluentialStats();
            PassiveStats.HealthIncrease += 20;
            PassiveStats.DefenseIncrease += 40;
        }
    }
}
