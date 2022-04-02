using Stendinator.Core.CreatureStats;

namespace Stendinator.Core.Components.Heads
{
    public class HealthyHead : Component
    {
        public HealthyHead()
        {
            PassiveStats = new InfluentialStats();
            PassiveStats.Health += 20 * GameState.Instance.CurrentStage;
            PassiveStats.Defense += 10 * GameState.Instance.CurrentStage;
        }
    }
}