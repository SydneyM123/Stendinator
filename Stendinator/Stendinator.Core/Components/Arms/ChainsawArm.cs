using Stendinator.Core.Components.Targets;
using Stendinator.Core.CreatureStats;

namespace Stendinator.Core.Components.Arms
{
    public sealed class ChainsawArm : ActiveComponent
    {
        public ChainsawArm(bool malicious) : base(new InfluentialStats
        {
            Health = 5 * GameState.Instance.CurrentStage,
            Defense = 5 * GameState.Instance.CurrentStage
        }, malicious)
        {
            if (malicious)
            {
                PassiveStats.Health = (int)Math.Ceiling(PassiveStats.Health * 0.8);
            }
        }

        public override void Activate()
        {
            var defense = 0 * GameState.Instance.CurrentStage;
            var health = (-30) * GameState.Instance.CurrentStage;

            if (Malicious)
            {
                health = (int)Math.Ceiling(health * 0.5);
                defense = (int)Math.Ceiling(defense * 0.5);
            }

            RaiseActivatedEvent(new CreatureTarget(new InfluentialStats
            {
                Health = health,
                Defense = defense
            }));
        }
    }
}