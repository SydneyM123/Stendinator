using Stendinator.Core.Components;
using System;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Shapes;
using Stendinator.Core.Components.Arms;

namespace Stendinator.Gui.Components
{
    internal class DrawableFlameThrowerArm : DrawableActiveComponent
    {
        public DrawableFlameThrowerArm(FlameThrowerArm activeComponent) : base(activeComponent)
        {
        }

        public override Shape Draw(Canvas canvas)
        {
            throw new NotImplementedException();
        }
    }
}