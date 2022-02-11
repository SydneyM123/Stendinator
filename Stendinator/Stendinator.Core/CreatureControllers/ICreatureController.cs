using Stendinator.Core.Creatures;

namespace Stendinator.Core.EntityControllers
{
    internal interface ICreatureController
    {
        void SetCreatureToControl(Creature e);
        void Act();
    }
}