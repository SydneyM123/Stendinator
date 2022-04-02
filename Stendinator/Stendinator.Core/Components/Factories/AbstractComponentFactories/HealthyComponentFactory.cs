using Stendinator.Core.Components.Heads;
using Stendinator.Core.Components.Legs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stendinator.Core.Components.Factories.AbstractComponentFactories
{
    internal class HealthyComponentFactory : IAbstractComponentFactory
    {
        public Component CreateLeg()
        {
            return new HealthyLeg();
        }

        public Component CreateHead()
        {
            return new HealthyHead();
        }

        public Component CreateBody()
        {
            return new HealthyBody();
        }
    }
}
