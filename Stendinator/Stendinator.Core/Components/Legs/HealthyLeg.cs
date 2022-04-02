using Stendinator.Core.CreatureStats;

namespace Stendinator.Core.Components.Legs
{
    public class HealthyLeg : Component
    {
        public HealthyLeg()
        {
            PassiveStats = new InfluentialStats();
            PassiveStats.Health += 15 * GameState.Instance.CurrentStage;
            PassiveStats.Defense += 5 * GameState.Instance.CurrentStage;
        }
    }
}
