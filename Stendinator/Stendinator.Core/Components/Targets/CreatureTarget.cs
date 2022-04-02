using Stendinator.Core.CreatureStats;

namespace Stendinator.Core.Components.Targets
{
    public class CreatureTarget
    {
        public InfluentialStats Consequences { get; set; }

        public CreatureTarget(InfluentialStats consequences)
        {
            Consequences = consequences;
        }
    }
}