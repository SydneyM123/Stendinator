namespace Stendinator.Core.Components.Factories
{
    public interface IAbstractComponentFactory
    {
        Component CreateLeg();
        Component CreateHead();
        Component CreateBody();
    }
}