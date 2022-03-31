using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Stendinator.Core.Creatures.Factories;

namespace Stendinator.Core.Planets
{
    public class AlienPlanet : Planet
    {
        public AlienPlanet(IRandomCreatureFactory creatureFactory, int numberOfEnemies) : base(creatureFactory, numberOfEnemies)
        {
            CreatureFactory = creatureFactory;
            NumberOfEnemies = numberOfEnemies;
        }
    }
}
