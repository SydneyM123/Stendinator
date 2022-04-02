using Stendinator.Core.Creatures;

namespace Stendinator.Core.CreatureControllers
{
    public interface ICreatureController
    {
        void SetCreatureToControl(Creature e);
        void Act();
    }
}