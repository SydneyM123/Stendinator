using Stendinator.Core.Components.Targets;
using Stendinator.Core.CreatureStats;

namespace Stendinator.Core.Components.Arms
{
    public sealed class ShieldArm : ActiveComponent
    {
        public ShieldArm(bool malicious) : base
        (
            new InfluentialStats
            {
                Health = 0 * GameState.Instance.CurrentStage,
                Defense = 12 * GameState.Instance.CurrentStage
            },
            new InfluentialStats
            {
                Health = 15 * GameState.Instance.CurrentStage,
                Defense = 10 * GameState.Instance.CurrentStage
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