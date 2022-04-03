using Stendinator.Core.CreatureStats;

namespace Stendinator.Core.Components.Legs
{
    public class SturdyLeg : Component
    {
        public SturdyLeg(bool malicious) : base(new InfluentialStats
        {
            Health = 5 * GameState.Instance.CurrentStage,
            Defense = 8 * GameState.Instance.CurrentStage
        }, malicious)
        {
            if (malicious)
            {
                PassiveStats.Health = (int)Math.Ceiling(PassiveStats.Health * 0.8);
            }
        }
    }
}