namespace Stendinator.Core.Components.Buffs;

public class SmallHealthBuff : DecoratedActiveComponent
{
    public SmallHealthBuff(ActiveComponent activeComponent) : base(activeComponent)
    {
        ActiveComponent.Actives.Health = (int)Math.Ceiling(Actives.Health * 1.2);
    }

    public override void Activate()
    {
        ActiveComponent.Activate();
    }
}