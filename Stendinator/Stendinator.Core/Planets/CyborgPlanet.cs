using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Stendinator.Core.Creatures.Factories;

namespace Stendinator.Core.Planets
{
    public class CyborgPlanet : Planet
    {
        public CyborgPlanet(IRandomCreatureFactory creatureFactory, int numberOfEnemies) : base(creatureFactory, numberOfEnemies)
        {
            _creatureFactory = creatureFactory;
            _numberOfEnemies = numberOfEnemies;
        }
    }
}
