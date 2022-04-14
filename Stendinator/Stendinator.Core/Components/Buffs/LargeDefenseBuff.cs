namespace Stendinator.Core.Components.Buffs;

public class LargeDefenseBuff : DecoratedActiveComponent
{
    public LargeDefenseBuff(ActiveComponent activeComponent) : base(activeComponent)
    {
        ActiveComponent.Actives.Defense = (int)Math.Ceiling(Actives.Defense * 1.8);
    }

    public override void Activate()
    {
        ActiveComponent.Activate();
    }
}