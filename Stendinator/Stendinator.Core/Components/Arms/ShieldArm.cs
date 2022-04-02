using Stendinator.Core.Components.Targets;
using Stendinator.Core.CreatureStats;

namespace Stendinator.Core.Components.Arms
{
    public sealed class ShieldArm : ActiveComponent
    {
        public ShieldArm()
        {
            PassiveStats = new InfluentialStats();
            PassiveStats.Health += 15 * GameState.Instance.CurrentStage;
            PassiveStats.Defense += 15 * GameState.Instance.CurrentStage;
        }
        public override void Activate()
        {
            RaiseActivatedEvent(new CreatureTarget
            {
                Consequences = new InfluentialStats
                {
                    Defense = 15 * GameState.Instance.CurrentStage
                }
            });
        }
    }
}
