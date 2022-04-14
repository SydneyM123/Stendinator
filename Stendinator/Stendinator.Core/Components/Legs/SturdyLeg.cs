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
                Passives.Health = (int)Math.Ceiling(Passives.Health * 0.8);
            }
        }
    }
}