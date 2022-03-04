using Windows.UI.Xaml.Controls;
using Stendinator.Core.Components;
using Windows.UI.Xaml.Shapes;

namespace Stendinator.Gui.Components
{
    internal abstract class DrawableComponent : Component, IDrawableComponent
    {
        protected Component Component;

        protected DrawableComponent(Component component)
        {
            Component = component;
        }

        public int X { get; set; }
        public int Y { get; set; }
        public DrawArea DrawArea { get; set; }

        public abstract Shape Draw(Canvas canvas);
    }
}