namespace Stendinator.Core.Components.Buffs;

public class MediumDefenseBuff : DecoratedActiveComponent
{
    public MediumDefenseBuff(ActiveComponent activeComponent) : base(activeComponent)
    {
        ActiveComponent.Actives.Defense = (int)Math.Ceiling(Actives.Defense * 1.05);
    }

    public override void Activate()
    {
        ActiveComponent.Activate();
    }
}