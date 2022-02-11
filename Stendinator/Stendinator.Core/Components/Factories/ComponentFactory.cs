using Stendinator.Core.Robots.Arms;
using System;

namespace Stendinator.Core.Components.Factories
{
    internal class ComponentFactory : IComponentFactory
    {
        public Component Create(string name)
        {
            switch (name)
            {
                case nameof(FlameThrowerArm):
                    return new FlameThrowerArm();
                default:
                    throw new Exception("Component not found...");
            }
        }
    }
}