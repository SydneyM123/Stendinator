using Stendinator.Core.CreatureStats;

namespace Stendinator.Core.Components.Bodies
{
    public class SturdyBody : Component
    {
        public SturdyBody(bool malicious) : base(new InfluentialStats
        {
            Health = 20 * GameState.Instance.CurrentStage,
            Defense = 20 * GameState.Instance.CurrentStage
        }, malicious)
        {
            if (malicious)
            {
                Passives.Health = (int)Math.Ceiling(Passives.Health * 0.8);
            }
        }
    }
}