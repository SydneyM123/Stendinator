using Stendinator.Core.Components;

namespace Stendinator.Gui.Components
{
    internal abstract class DrawableComponent : Component, IDrawableComponent
    {
        protected Component _component;

        public DrawableComponent(Component Component)
        {
            _component = Component;
        }

        public int X { get; set; }
        public int Y { get; set; }

        public abstract void Draw();
    }
}