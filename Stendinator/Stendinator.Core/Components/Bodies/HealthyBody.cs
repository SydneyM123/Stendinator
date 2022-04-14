using Stendinator.Core.CreatureStats;

namespace Stendinator.Core.Components.Bodies
{
    public class HealthyBody : Component
    {
        public HealthyBody(bool malicious) : base(new InfluentialStats
        {
            Health = 40 * GameState.Instance.CurrentStage,
            Defense = 10 * GameState.Instance.CurrentStage
        }, malicious)
        {
            if (malicious)
            {
                Passives.Health = (int)Math.Ceiling(Passives.Health * 0.8);
            }
        }
    }
}