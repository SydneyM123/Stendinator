using Stendinator.Core.Creatures;
using Stendinator.Core.Creatures.Factories;

namespace Stendinator.Core.Planets
{
    public class CyborgPlanet : Planet
    {
        public CyborgPlanet(IRandomCreatureFactory creatureFactory, int numberOfEnemies, Creature player) : base(creatureFactory, numberOfEnemies, player)
        {
            CreatureFactory = creatureFactory;
            NumberOfEnemies = numberOfEnemies;
        }
    }
}