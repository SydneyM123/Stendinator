using Stendinator.Core.Components.Factories;
using Stendinator.Core.Creatures;
using Stendinator.Core.Creatures.Factories;

namespace Stendinator.Core.Planets.Factories
{
    public class RandomPlanetFactory : IRandomPlanetFactory
    {
        private readonly IRandomComponentFactory _randomComponentFactory;
        
        public RandomPlanetFactory(IRandomComponentFactory randomComponentFactory)
        {
            _randomComponentFactory = randomComponentFactory;
        }

        public Planet Create(string name, Creature player)
        {
            return name switch
            {
                nameof(AlienPlanet) => new AlienPlanet(new RandomAlienFactory(_randomComponentFactory), GameState.Instance.CurrentStage, player),
                nameof(CyborgPlanet) => new CyborgPlanet(new RandomCyborgFactory(_randomComponentFactory), GameState.Instance.CurrentStage, player),
                _ => throw new Exception("Planet not found...")
            };
        }
    }
}