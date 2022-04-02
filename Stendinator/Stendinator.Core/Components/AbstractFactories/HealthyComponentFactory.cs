using Stendinator.Core.Components.Bodies;
using Stendinator.Core.Components.Heads;
using Stendinator.Core.Components.Legs;

namespace Stendinator.Core.Components.AbstractFactories
{
    public class HealthyComponentFactory : IAbstractComponentFactory
    {
        public Component CreateLeg(bool malicious)
        {
            return new HealthyLeg(malicious);
        }

        public Component CreateHead(bool malicious)
        {
            return new HealthyHead(malicious);
        }

        public Component CreateBody(bool malicious)
        {
            return new HealthyBody(malicious);
        }
    }
}