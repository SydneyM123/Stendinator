using Stendinator.Core.CreatureStats;

namespace Stendinator.Core.Components.Legs
{
    public class BallancedLegg : Component
    {
        public BallancedLegg()
        {
            PassiveStats = new InfluentialStats();
            PassiveStats.HealthIncrease += 13;
            PassiveStats.DefenseIncrease += 12;
        }
    }
}
