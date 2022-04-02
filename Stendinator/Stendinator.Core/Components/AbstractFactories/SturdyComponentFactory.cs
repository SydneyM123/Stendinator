using Stendinator.Core.Components.Bodies;
using Stendinator.Core.Components.Heads;
using Stendinator.Core.Components.Legs;

namespace Stendinator.Core.Components.AbstractFactories
{
    public class SturdyComponentFactory : IAbstractComponentFactory
    {
        public Component CreateBody(bool malicious)
        {
            return new SturdyBody(malicious);
        }

        public Component CreateHead(bool malicious)
        {
            return new SturdyHead(malicious);
        }

        public Component CreateLeg(bool malicious)
        {
            return new SturdyLeg(malicious);
        }
    }
}