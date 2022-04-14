using Stendinator.Core.CreatureStats;

namespace Stendinator.Core.Components.Heads
{
    public class SturdyHead : Component
    {
        public SturdyHead(bool malicious) : base(new InfluentialStats
        {
            Health = 10 * GameState.Instance.CurrentStage,
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