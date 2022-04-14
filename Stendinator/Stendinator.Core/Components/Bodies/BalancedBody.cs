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
                Passives.Health = (int)Math.Ceiling(Passives.Health * 0.8);
            }
        }
    }
}