using Windows.UI.Xaml.Controls;
using Stendinator.Core.Components;
using Windows.UI.Xaml.Shapes;

namespace Stendinator.Gui.Components
{
    internal abstract class DrawableActiveComponent : ActiveComponent, IDrawableComponent
    {
        protected ActiveComponent ActiveComponent;

        protected DrawableActiveComponent(ActiveComponent activeComponent)
        {
            ActiveComponent = activeComponent;
        }

        public int X { get; set; }
        public int Y { get; set; }
        public DrawArea DrawArea { get; set; }

        public abstract Shape Draw(Canvas canvas);

        public override void Activate()
        {
            ActiveComponent?.Activate();
        }
    }
}