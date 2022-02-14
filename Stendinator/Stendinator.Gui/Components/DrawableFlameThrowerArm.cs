using Stendinator.Core.Components;
using Stendinator.Core.Robots.Arms;
using System;
using Windows.UI.Xaml.Shapes;

namespace Stendinator.Gui.Components
{
    internal class DrawableFlameThrowerArm : DrawableActiveComponent
    {
        public DrawableFlameThrowerArm(FlameThrowerArm activeComponent) : base(activeComponent)
        {
        }

        public override Shape Draw()
        {
            throw new NotImplementedException();
        }
    }
}