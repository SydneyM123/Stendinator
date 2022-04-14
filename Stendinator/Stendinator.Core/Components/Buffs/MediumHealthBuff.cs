namespace Stendinator.Core.Components.Buffs;

public class MediumHealthBuff : DecoratedActiveComponent
{
    public MediumHealthBuff(ActiveComponent activeComponent) : base(activeComponent)
    {
        ActiveComponent.Actives.Health = (int)Math.Ceiling(Actives.Health * 1.6);
    }

    public override void Activate()
    {
        ActiveComponent.Activate();
    }
}