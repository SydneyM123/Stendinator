using Stendinator.Core.Components;
using Stendinator.Core.Components.Factories;
using System;
using Stendinator.Core.Components.Arms;

namespace Stendinator.Gui.Components.Factories
{
    internal class DrawableComponentFactory : IComponentFactory
    {
        protected IComponentFactory _componentFactory;

        public DrawableComponentFactory(IComponentFactory componentFactory)
        {
            _componentFactory = componentFactory;
        }

        public Component Create(string name)
        {
            switch (name)
            {
                case nameof(DrawableFlameThrowerArm):
                    return new DrawableFlameThrowerArm((FlameThrowerArm) _componentFactory.Create(nameof(FlameThrowerArm)));
                default:
                    throw new Exception("Component not found...");
            }
        }
    }
}