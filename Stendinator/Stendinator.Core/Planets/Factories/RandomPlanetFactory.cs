using System;
using System.ComponentModel.Design;
using Stendinator.Core.Creatures.Factories;

namespace Stendinator.Core.Planets.Factories
{
    public class RandomPlanetFactory : IRandomPlanetFactory
    {
        public Planet Create(int difficulty, string name)
        {
            int amountOfEnemies;

            if (difficulty < 10)
            {
                amountOfEnemies = 1;
            }
            else if (difficulty < 25)
            {
                amountOfEnemies = 2;
            }
            else if (difficulty < 50)
            {
                amountOfEnemies = 3;
            }
            else
            {
                amountOfEnemies = 4;
            }

            Planet planet;
            switch (name)
            {
            case nameof(AlienPlanet):
                    planet = new AlienPlanet(new RandomAlienFactory(), amountOfEnemies);
                    break;
                case nameof(CyborgPlanet):
                    planet = new AlienPlanet(new RandomCyborgFactory(), amountOfEnemies);
                    break;
                default:
                    throw new Exception("Planet not found...");
            }
            return planet;
        }
    }
}