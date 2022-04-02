using Stendinator.Core.Creatures;
using Stendinator.Core.Creatures.Factories;

namespace Stendinator.Core.Planets
{
    public class AlienPlanet : Planet
    {
        public AlienPlanet(RandomCreatureFactory creatureFactory, int numberOfEnemies, Creature player) : base(creatureFactory, numberOfEnemies, player)
        {
            CreatureFactory = creatureFactory;
            NumberOfEnemies = numberOfEnemies;
        }
    }
}