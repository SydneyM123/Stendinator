using System;
using System.Collections.Generic;
using Stendinator.Core.Components.Arms;
using Stendinator.Core.Components.Heads;
using Stendinator.Core.Components.Legs;

namespace Stendinator.Core.Components.Factories
{
    internal abstract class ComponentFactory
    {
        public abstract Component Create();
    }
}