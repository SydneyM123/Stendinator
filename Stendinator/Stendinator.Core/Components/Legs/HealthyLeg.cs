using Stendinator.Core.CreatureStats;

namespace Stendinator.Core.Components.Legs
{
    public class HealthyLeg : Component
    {
        public HealthyLeg(bool malicious) : base(new InfluentialStats
        {
            Health = 15 * GameState.Instance.CurrentStage,
            Defense = 3 * GameState.Instance.CurrentStage
        }, malicious)
        {
            if (malicious)
            {
                Passives.Health = (int)Math.Ceiling(Passives.Health * 0.8);
            }
        }
    }
}