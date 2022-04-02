using Stendinator.Core.Components;
using Stendinator.Core.Creatures;

namespace Stendinator.Core.CreatureControllers
{
    public class RandomCreatureController : ICreatureController
    {
        private readonly Random _random;

        private Creature _creature;

        public event EventHandler? NoActiveComponents;
        public event ComponentUsed? ComponentUsed;

        public RandomCreatureController(Creature creature)
        {
            _creature = creature;
            _random = new Random();
        }

        public void Act()
        {
            var activeComponents = _creature.Components.Where(c => c.GetType().IsSubclassOf(typeof(ActiveComponent))).Cast<ActiveComponent>().ToArray();
            if (activeComponents.Any())
            {
                var ac = activeComponents[_random.Next(activeComponents.Length - 1)];
                ac.Activate();
                ComponentUsed?.Invoke(ac);
            }
            else NoActiveComponents?.Invoke(this, EventArgs.Empty);
        }

        public void SetCreatureToControl(Creature e)
        {
            _creature = e;
        }
    }

    public delegate void ComponentUsed(ActiveComponent ac);
}