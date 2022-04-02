using Stendinator.Core.CreatureStats;

namespace Stendinator.Core.Components.Heads
{
    public class BalancedBody : Component
    {
        public BalancedBody()
        {
            PassiveStats = new InfluentialStats();
            PassiveStats.Health += 30 * GameState.Instance.CurrentStage;
            PassiveStats.Defense += 30 * GameState.Instance.CurrentStage;
        }
    }
}
