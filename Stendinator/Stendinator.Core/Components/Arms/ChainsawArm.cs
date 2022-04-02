using Stendinator.Core.Components.Targets;
using Stendinator.Core.CreatureStats;

namespace Stendinator.Core.Components.Arms
{
    public sealed class ChainsawArm : ActiveComponent
    {
        public ChainsawArm()
        {
            PassiveStats = new InfluentialStats();
            PassiveStats.Health += 5 * GameState.Instance.CurrentStage;
            PassiveStats.Defense += 10 * GameState.Instance.CurrentStage;
        }

        public override void Activate()
        {
            RaiseActivatedEvent(new CreatureTarget
            {
                Consequences = new InfluentialStats
                {
                    Health = -17 * GameState.Instance.CurrentStage
                }
            });
        }
    }
}