using Stendinator.Core.Components.Arms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stendinator.Core.Components.Factories.ConcreteFactories
{
    internal class ConcreteShieldArm : ComponentFactory
    {
        public override Component Create()
        {
            return new ShieldArm();
        }
    }
}
