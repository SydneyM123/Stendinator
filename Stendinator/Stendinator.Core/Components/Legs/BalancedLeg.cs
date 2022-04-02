using Stendinator.Core.CreatureStats;

namespace Stendinator.Core.Components.Legs
{
    public class BalancedLeg : Component
    {
        public BalancedLeg()
        {
            PassiveStats = new InfluentialStats();
            PassiveStats.Health += 13 * GameState.Instance.CurrentStage;
            PassiveStats.Defense += 12 * GameState.Instance.CurrentStage;
        }
    }
}