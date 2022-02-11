namespace Stendinator.Gui.Components
{
    internal interface IDrawableComponent
    {
        int X { get; set; }
        int Y { get; set; }

        void Draw();
    }
}