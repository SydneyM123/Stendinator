using Stendinator.Core.CreatureStats;

namespace Stendinator.Core.Components.Heads
{
    public class HealthyHead : Component
    {
        public HealthyHead(bool malicious) : base(new InfluentialStats
        {
            Health = 20 * GameState.Instance.CurrentStage,
            Defense = 5 * GameState.Instance.CurrentStage
        }, malicious)
        {
            if (malicious)
            {
                Passives.Health = (int)Math.Ceiling(Passives.Health * 0.8);
            }
        }
    }
}