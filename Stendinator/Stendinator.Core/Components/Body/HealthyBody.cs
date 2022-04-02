using Stendinator.Core.CreatureStats;

namespace Stendinator.Core.Components.Heads
{
    public class HealthyBody : Component
    {
        public HealthyBody()
        {
            PassiveStats = new InfluentialStats();
            PassiveStats.Health += 40 * GameState.Instance.CurrentStage;
            PassiveStats.Defense += 20 * GameState.Instance.CurrentStage;
        }
    }
}
