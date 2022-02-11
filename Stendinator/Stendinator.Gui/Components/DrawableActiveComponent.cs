using Stendinator.Core.Components;

namespace Stendinator.Gui.Components.Arms
{
    internal abstract class DrawableActiveComponent : ActiveComponent, IDrawableComponent
    {
        protected ActiveComponent _useableComponent;

        public DrawableActiveComponent(ActiveComponent useableComponent)
        {
            _useableComponent = useableComponent;
        }

        public int X { get; set; }
        public int Y { get; set; }

        public abstract void Draw();

        public override void Use()
        {
            if (_useableComponent != null)
            {
                _useableComponent.Use();
            }
        }
    }
}