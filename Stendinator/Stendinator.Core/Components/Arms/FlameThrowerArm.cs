using Stendinator.Core.Components.Targets;
using Stendinator.Core.CreatureStats;

namespace Stendinator.Core.Components.Arms
{
    public sealed class FlameThrowerArm : ActiveComponent
    {
        public FlameThrowerArm(bool malicious) : base
        (
            new InfluentialStats
            {
                Health = -20 * GameState.Instance.CurrentStage,
                Defense = -10 * GameState.Instance.CurrentStage
            },
            new InfluentialStats
            {
                Health = 8 * GameState.Instance.CurrentStage,
                Defense = 4 * GameState.Instance.CurrentStage
            },
            malicious
        )
        {
            if (!Malicious) return;
            Actives.Health = (int)Math.Ceiling(Actives.Health * 0.5);
            Actives.Defense = (int)Math.Ceiling(Actives.Defense * 0.5);
        }

        public override void Activate()
        {
            RaiseActivatedEvent(new CreatureTarget(new InfluentialStats
            {
                Health = Actives.Health,
                Defense = Actives.Defense
            }));
        }
    }
}