using Stendinator.Core.CreatureStats;

namespace Stendinator.Core.Components.Legs
{
    public class HealthyLeg : Component
    {
        public HealthyLeg(bool malicious) : base(new InfluentialStats
        {
            Health = 15 * GameState.Instance.CurrentStage,
            Defense = 5 * GameState.Instance.CurrentStage
        }, malicious)
        {
            if (malicious)
            {
                PassiveStats.Health = (int)Math.Ceiling(PassiveStats.Health * 0.8);
            }
        }
    }
}