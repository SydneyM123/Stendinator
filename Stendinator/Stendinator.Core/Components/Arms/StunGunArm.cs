using Stendinator.Core.Components.Targets;
using Stendinator.Core.CreatureStats;

namespace Stendinator.Core.Components.Arms
{
    public sealed class StunGunArm : ActiveComponent
    {
        public StunGunArm()
        {
            PassiveStats = new InfluentialStats();
            PassiveStats.Health += 10 * GameState.Instance.CurrentStage;
            PassiveStats.Defense += 5 * GameState.Instance.CurrentStage;
        }

        public override void Activate()
        {
            RaiseActivatedEvent(new CreatureTarget
            {
                Consequences = new InfluentialStats
                {
                    Health = -5 * GameState.Instance.CurrentStage,
                    Defense = -15 * GameState.Instance.CurrentStage
                }
            });
        }
    }
}