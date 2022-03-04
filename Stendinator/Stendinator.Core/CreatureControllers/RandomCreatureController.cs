using System;
using Stendinator.Core.Creatures;

namespace Stendinator.Core.CreatureControllers
{
    internal class RandomCreatureController : ICreatureController
    {
        private Creature _creature;

        public RandomCreatureController(Creature e)
        {
            _creature = e;
        }

        public void Act()
        {
            if (_creature == null) throw new EntityNotSet();

            throw new NotImplementedException();
        }

        public void SetCreatureToControl(Creature e)
        {
            _creature = e;
        }

        internal class EntityNotSet : Exception
        {
        }
    }
}