using Stendinator.Core.CreatureStats;

namespace Stendinator.Core.Components.Heads
{
    public class SturdyHead : Component
    {
        public SturdyHead()
        {
            PassiveStats = new InfluentialStats();
            PassiveStats.Health += 10 * GameState.Instance.CurrentStage;
            PassiveStats.Defense += 20 * GameState.Instance.CurrentStage;
        }
    }
}
