namespace Stendinator.Core.Components.AbstractFactories
{
    public interface IAbstractComponentFactory
    {
        Component CreateLeg(bool malicious);
        Component CreateHead(bool malicious);
        Component CreateBody(bool malicious);
    }
}