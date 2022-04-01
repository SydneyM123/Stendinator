
using Stendinator.Core.Components.Heads;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stendinator.Core.Components.Factories.ConcreteFactories
{
    internal class ConcreteHealthyHead : ComponentFactory
    {
        public override Component Create()
        {
           return new HealthyHead();
        }
    }
}
