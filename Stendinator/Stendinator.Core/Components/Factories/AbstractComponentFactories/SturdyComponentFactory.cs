using Stendinator.Core.Components.Heads;
using Stendinator.Core.Components.Legs;
using Stendinator.Core.Components.Body;

namespace Stendinator.Core.Components.Factories.AbstractComponentFactories
{
    internal class SturdyComponentFactory : IAbstractComponentFactory
    {
        public Component CreateBody()
        {
            return new SturdyBody();
        }

        public Component CreateHead()
        {
            return new SturdyHead();
        }

        public Component CreateLeg()
        {
            return new SturdyLeg();
        }
    }
}