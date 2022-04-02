using Stendinator.Core.CreatureStats;

namespace Stendinator.Core.Components.Legs
{
    public class SturdyLeg : Component
    {
        public SturdyLeg()
        {
            PassiveStats = new InfluentialStats();
            PassiveStats.Health += 5 * GameState.Instance.CurrentStage;
            PassiveStats.Defense += 15 * GameState.Instance.CurrentStage;
        }
    }
}
