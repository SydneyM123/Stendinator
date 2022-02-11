namespace Stendinator.Core.Components.Factories
{
    internal interface IComponentFactory
    {
        Component Create(string name);
    }
}