using Stendinator.Core.CreatureStats;

namespace Stendinator.Core.Components.Heads
{
    public class BalancedHead : Component
    {
        public BalancedHead()
        {
            PassiveStats = new InfluentialStats();
            PassiveStats.Health += 15 * GameState.Instance.CurrentStage;
            PassiveStats.Defense += 15 * GameState.Instance.CurrentStage;
        }
    }
}
