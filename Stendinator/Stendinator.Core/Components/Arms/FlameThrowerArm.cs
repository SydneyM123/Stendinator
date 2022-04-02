using Stendinator.Core.Components.Targets;
using Stendinator.Core.CreatureStats;

namespace Stendinator.Core.Components.Arms
{
    public sealed class FlameThrowerArm : ActiveComponent
    {
        public FlameThrowerArm()
        {
            PassiveStats = new InfluentialStats();
            PassiveStats.Health += 8 * GameState.Instance.CurrentStage;
            PassiveStats.Defense += 7 * GameState.Instance.CurrentStage;
        }

        public override void Activate()
        {
            RaiseActivatedEvent(new CreatureTarget
            {
                Consequences = new InfluentialStats
                {
                    Health = -10 * GameState.Instance.CurrentStage,
                    Defense = -5 * GameState.Instance.CurrentStage
                }
            });
        }
    }
}