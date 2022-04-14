namespace Stendinator.Core.Components.Buffs;

public class LargeHealthBuff : DecoratedActiveComponent
{
    public LargeHealthBuff(ActiveComponent activeComponent) : base(activeComponent)
    {
        ActiveComponent.Actives.Health = (int)Math.Ceiling(Actives.Health * 2.0);
    }

    public override void Activate()
    {
        ActiveComponent.Activate();
    }
}