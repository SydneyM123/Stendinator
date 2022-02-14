using Windows.UI.Xaml.Shapes;

namespace Stendinator.Gui.Components
{
    internal interface IDrawableComponent
    {
        int X { get; set; }
        int Y { get; set; }
        DrawArea DrawArea { get; set; }
        Shape Draw();
    }

    public enum DrawArea
    {
        Player,
        Enemy
    }
}