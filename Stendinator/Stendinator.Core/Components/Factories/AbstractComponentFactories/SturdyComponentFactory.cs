using Stendinator.Core.Components.Heads;
using Stendinator.Core.Components.Legs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
