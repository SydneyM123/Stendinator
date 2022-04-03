using Stendinator.Core.CreatureStats;

namespace Stendinator.Core.Components.Legs
{
    public class BalancedLeg : Component
    {
        public BalancedLeg(bool malicious) : base(new InfluentialStats
        {
            Health = 13 * GameState.Instance.CurrentStage,
            Defense = 6 * GameState.Instance.CurrentStage
        }, malicious)
        {
            if (malicious)
            {
                PassiveStats.Health = (int)Math.Ceiling(PassiveStats.Health * 0.8);
            }
        }
    }
}