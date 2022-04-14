using Stendinator.Core.Components.Factories;
using Stendinator.Core.Creatures.Aliens;

namespace Stendinator.Core.Creatures.Factories
{
    public class RandomAlienFactory : IRandomCreatureFactory
    {
        private readonly Random _random = new();
        
        private readonly int _maxComponent;

        private readonly IRandomComponentFactory _randomComponentFactory;

        protected RandomAlienFactory(IRandomComponentFactory randomComponentFactory)
        {
            _randomComponentFactory = randomComponentFactory;
            _maxComponent = _random.Next(1, 7);
        }

        public virtual Creature Create()
        {
            var creature = new Alien();
            for (var i = 0; i < _maxComponent; i++) creature.AddComponent(_randomComponentFactory.GetRandomComponent(true));
            return creature;
        }
    }
}