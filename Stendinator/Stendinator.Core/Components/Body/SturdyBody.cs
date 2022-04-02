using Stendinator.Core.CreatureStats;

namespace Stendinator.Core.Components.Body
{
    public class SturdyBody : Component
    {
        public SturdyBody()
        {
            PassiveStats = new InfluentialStats();
            PassiveStats.Health += 20 * GameState.Instance.CurrentStage;
            PassiveStats.Defense += 40 * GameState.Instance.CurrentStage;
        }
    }
}