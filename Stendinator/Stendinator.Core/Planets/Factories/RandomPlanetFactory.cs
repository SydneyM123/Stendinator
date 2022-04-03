using Stendinator.Core.Creatures;
using Stendinator.Core.Creatures.Factories;

namespace Stendinator.Core.Planets.Factories
{
    public class RandomPlanetFactory : IRandomPlanetFactory
    {
        private readonly IRandomCreatureFactory _randomAlienFactory;
        private readonly IRandomCreatureFactory _randomCyborgFactory;
        
        public RandomPlanetFactory(
            IRandomCreatureFactory randomAlienFactory,
            IRandomCreatureFactory randomCyborgFactory)
        {
            _randomAlienFactory = randomAlienFactory;
            _randomCyborgFactory = randomCyborgFactory;
        }

        public Planet Create(string name, Creature player)
        {
            return name switch
            {
                nameof(AlienPlanet) => new AlienPlanet(_randomAlienFactory, GameState.Instance.CurrentStage, player),
                nameof(CyborgPlanet) => new CyborgPlanet(_randomCyborgFactory, GameState.Instance.CurrentStage, player),
                _ => throw new Exception("Planet not found...")
            };
        }
    }
}