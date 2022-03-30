using System;
using Stendinator.Core.Creatures.Factories;

namespace Stendinator.Core.Planets.Factories
{
    internal class RandomPlanetFactory : IRandomPlanetFactory
    {
        public Planet Create(int difficulty, string name)
        {
            Planet planet;
            switch (name)
            {
            case nameof(AlienPlanet):
                    planet = new AlienPlanet(new RandomAlienFactory(), difficulty);
                    break;
                case nameof(CyborgPlanet):
                    planet = new AlienPlanet(new RandomCyborgFactory(), difficulty);
                    break;
                default:
                    throw new Exception("Planet not found...");
            }

            return planet;
        }

    }
}