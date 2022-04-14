namespace Stendinator.Core.Components.Buffs;

public class SmallDefenseBuff : DecoratedActiveComponent
{
    public SmallDefenseBuff(ActiveComponent activeComponent) : base(activeComponent)
    {
        ActiveComponent.Actives.Defense = (int)Math.Ceiling(Actives.Defense * 1.1);
    }

    public override void Activate()
    {
        ActiveComponent.Activate();
    }
}