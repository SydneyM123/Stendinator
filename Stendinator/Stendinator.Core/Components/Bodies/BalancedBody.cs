using Stendinator.Core.CreatureStats;

namespace Stendinator.Core.Components.Bodies
{
    public class BalancedBody : Component
    {
        public BalancedBody(bool malicious) : base(new InfluentialStats
        {
            Health = 30 * GameState.Instance.CurrentStage,
            Defense = 15 * GameState.Instance.CurrentStage
        }, malicious)
        {
            if (malicious)
            {
                PassiveStats.Health = (int)Math.Ceiling(PassiveStats.Health * 0.8);
            }
        }
    }
}