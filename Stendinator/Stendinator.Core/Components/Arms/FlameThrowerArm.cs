using Stendinator.Core.CreatureStats;

namespace Stendinator.Core.Components.Arms
{
    public sealed class FlameThrowerArm : ActiveComponent
    {
        public override void Activate()
        {
            RaiseActivatedEvent(new Entity
            {
                Consequences = new InfluentialStats
                {
                    HealthDecrease = 10
                }
            });
        }
    }
}