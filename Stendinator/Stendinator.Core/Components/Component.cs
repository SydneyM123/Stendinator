using Stendinator.Core.CreatureStats;

namespace Stendinator.Core.Components
{
    public abstract class Component
    {
        public InfluentialStats Passives { get; init; }
        public bool Malicious { get; }
        
        protected Component(InfluentialStats passives, bool malicious)
        {
            Passives = passives;
            Malicious = malicious;
        }

        /// <summary>
        /// Never call the object itself, always call it via this method!!!!
        /// </summary>
        /// <returns>The actual core component with correct data</returns>
        public virtual Component Instance()
        {
            return this;
        }
    }
}