using Stendinator.Core.Components;
using Windows.UI.Xaml.Shapes;

namespace Stendinator.Gui.Components
{
    internal abstract class DrawableActiveComponent : ActiveComponent, IDrawableComponent
    {
        protected ActiveComponent _activeComponent;

        public DrawableActiveComponent(ActiveComponent activeComponent)
        {
            _activeComponent = activeComponent;
        }

        public int X { get; set; }
        public int Y { get; set; }
        public DrawArea DrawArea { get; set; }

        public abstract Shape Draw();

        public override void Use()
        {
            if (_activeComponent != null)
            {
                _activeComponent.Use();
            }
        }
    }
}