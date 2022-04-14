namespace Stendinator.Core.Components;

public abstract class DecoratedActiveComponent : ActiveComponent
{
    protected readonly ActiveComponent ActiveComponent;

    protected DecoratedActiveComponent(ActiveComponent activeComponent) : base
    (
        activeComponent.Actives,
        activeComponent.Passives,
        activeComponent.Malicious
    )
    {
        ActiveComponent = activeComponent;
    }

    public override Component Instance()
    {
        return ActiveComponent.Instance();
    }
}