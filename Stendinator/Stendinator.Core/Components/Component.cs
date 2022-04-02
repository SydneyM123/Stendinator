using Stendinator.Core.CreatureStats;

namespace Stendinator.Core.Components
{
    public abstract class Component
    {
        public InfluentialStats PassiveStats { get; set; }
        public bool Malicious { get; set; }
        
        protected Component(InfluentialStats passiveStats, bool malicious)
        {
            PassiveStats = passiveStats;
            Malicious = malicious;
        }
    }
}