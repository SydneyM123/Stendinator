using Stendinator.Core.Components;

namespace Stendinator.Core.Creatures.Builders
{
    internal interface ICreatureBuilder
    {
        void AddHead(Component c);
        void AddTorso(Component c);
        void AddRightArm(Component c);
        void AddLeftArm(Component c);
        void AddRightLeg(Component c);
        void AddLeftLeg(Component c);
        Creature GetCreature();
    }
}