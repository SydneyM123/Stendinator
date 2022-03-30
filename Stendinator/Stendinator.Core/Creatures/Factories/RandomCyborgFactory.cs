using System;
using Stendinator.Core.Components.Factories;
using Stendinator.Core.Creatures.Cyborgs;

namespace Stendinator.Core.Creatures.Factories
{
    internal class RandomCyborgFactory : IRandomCreatureFactory
    {
        private readonly ComponentFactory _componentFactory = new ComponentFactory();

        /// <summary>
        /// 
        /// </summary>
        /// <param name="name">Type of creature to create</param>
        /// <returns></returns>
        /// <exception cref="System.NotImplementedException"></exception>
        public Creature Create()
        {
            var alien = new Cyborg();
            var random = new Random();

            //Make 5 random components
            for (var i = 0; i < 5; i++)
            {
                var getRandomName = _componentFactory.GetNames();
                alien.AddComponent(_componentFactory.Create(getRandomName[random.Next(getRandomName.Length)]));
            }

            return alien;
        }
    }
}