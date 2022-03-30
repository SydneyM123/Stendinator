using System;
using System.Collections.Generic;
using System.Linq;
using Stendinator.Core.Components;
using Stendinator.Core.Components.Factories;
using Stendinator.Core.Components.Heads;
using Stendinator.Core.Creatures.Aliens;

namespace Stendinator.Core.Creatures.Factories
{
    internal class RandomAlienFactory : IRandomCreatureFactory
    {
        private readonly ComponentFactory _componentFactory = new ComponentFactory();
        public Creature Create()
        {
            var alien = new Alien();
            var random = new Random();

            //Make 5 random components
            for (var i = 0; i < 5; i++)
            {
                var getRandomName = _componentFactory.GetNames();
                alien.AddComponent( _componentFactory.Create(getRandomName[random.Next(getRandomName.Length)]));
            }

            return alien;
        }
    }
}