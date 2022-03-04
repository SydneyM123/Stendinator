using Stendinator.Core.Creatures;

namespace Stendinator.Core.CreatureControllers
{
    internal interface ICreatureController
    {
        void SetCreatureToControl(Creature e);
        void Act();
    }
}