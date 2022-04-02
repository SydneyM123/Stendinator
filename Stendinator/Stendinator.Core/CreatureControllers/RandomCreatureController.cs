using System;
using System.Collections.Generic;
using System.Linq;
using Stendinator.Core.Components;
using Stendinator.Core.Components.Targets;
using Stendinator.Core.Creatures;

namespace Stendinator.Core.CreatureControllers
{
    internal class RandomCreatureController : ICreatureController
    {
        private Creature _creature;

        public RandomCreatureController()
        {
        }

        public void Act(CreatureTarget creatureTarget)
        {
            var random = new Random();
            if (_creature == null) throw new EntityNotSet();
            var componentArray = (ActiveComponent[]) _creature.Components.Where(component => component.GetType() == typeof(ActiveComponent)).ToArray();
            _creature.HandleActivatedComponent(componentArray[random.Next(componentArray.Length - 1)], creatureTarget);
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