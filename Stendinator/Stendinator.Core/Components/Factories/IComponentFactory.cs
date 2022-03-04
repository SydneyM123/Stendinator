namespace Stendinator.Core.Components.Factories
{
    public interface IComponentFactory
    {
        Component Create(string name);
    }
}