using Stendinator.Core.Components.Bodies;
using Stendinator.Core.Components.Heads;
using Stendinator.Core.Components.Legs;

namespace Stendinator.Core.Components.AbstractFactories
{
    public class BalancedComponentFactory : IAbstractComponentFactory
    {
        public Component CreateLeg(bool malicious)
        {
            return new BalancedLeg(malicious);
        }

        public Component CreateHead(bool malicious)
        {
            return new BalancedHead(malicious);
        }

        public Component CreateBody(bool malicious)
        {
            return new BalancedBody(malicious);
        }
    }
}