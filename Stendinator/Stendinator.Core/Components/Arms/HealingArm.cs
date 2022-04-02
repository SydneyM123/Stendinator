using Stendinator.Core.Components.Targets;
using Stendinator.Core.CreatureStats;

namespace Stendinator.Core.Components.Arms
{
    public sealed class HealingArm : ActiveComponent
    {
        public HealingArm()
        {
            PassiveStats = new InfluentialStats();
            PassiveStats.Health += 25 * GameState.Instance.CurrentStage;
            PassiveStats.Defense += 5 * GameState.Instance.CurrentStage;
        }

        public override void Activate()
        {
            RaiseActivatedEvent(new CreatureTarget
            {
                Consequences = new InfluentialStats
                {
                    Health = 15 * GameState.Instance.CurrentStage
                }
            });
        }
    }
}