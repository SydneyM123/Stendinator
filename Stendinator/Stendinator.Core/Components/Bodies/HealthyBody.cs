using Stendinator.Core.CreatureStats;

namespace Stendinator.Core.Components.Bodies
{
    public class HealthyBody : Component
    {
        public HealthyBody(bool malicious) : base(new InfluentialStats
        {
            Health = 40 * GameState.Instance.CurrentStage,
            Defense = 20 * GameState.Instance.CurrentStage
        }, malicious)
        {
            if (malicious)
            {
                PassiveStats.Health = (int)Math.Ceiling(PassiveStats.Health * 0.8);
            }
        }
    }
}