using Stendinator.Core.Components.Factories;
using Stendinator.Core.Creatures.Aliens;

namespace Stendinator.Core.Creatures.Factories
{
    public class RandomAlienFactory : IRandomCreatureFactory
    {
        private readonly int _maxComponent;

        protected IRandomComponentFactory RandomComponentFactory;

        public RandomAlienFactory(IRandomComponentFactory randomComponentFactory)
        {
            RandomComponentFactory = randomComponentFactory;
            _maxComponent = new Random().Next(1, 7);
        }

        public virtual Creature Create()
        {
            var creature = new Alien();
            for (var i = 0; i < _maxComponent; i++) creature.AddComponent(RandomComponentFactory.GetRandomComponent(true));
            return creature;
        }
    }
}