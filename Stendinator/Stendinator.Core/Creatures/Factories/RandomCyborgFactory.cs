using System;
using Stendinator.Core.Components.Factories;
using Stendinator.Core.Creatures.Cyborgs;

namespace Stendinator.Core.Creatures.Factories
{
    public class RandomCyborgFactory : IRandomCreatureFactory
    {
        private readonly ComponentFactory _componentFactory = new ComponentFactory();

        /// <summary>
        /// 
        /// </summary>
        /// <param name="name">Type of creature to create</param>
        /// <returns>Cyborg with all Components</returns>
        public Creature Create()
        {
            var cyborg = new Cyborg();
            var random = new Random();

            //Make 5 random components
           
                var getRandomName = _componentFactory.GetNames();
                var range = getRandomName.Length - 1;
                cyborg.AddLeftArm(_componentFactory.Create(getRandomName[random.Next(range)]));
                cyborg.AddRightArm(_componentFactory.Create(getRandomName[random.Next(range)]));
                cyborg.AddHead(_componentFactory.Create(getRandomName[random.Next(range)]));
                cyborg.AddTorso(_componentFactory.Create(getRandomName[random.Next(range)]));
                cyborg.AddLeftLeg(_componentFactory.Create(getRandomName[random.Next(range)]));
                cyborg.AddRightLeg(_componentFactory.Create(getRandomName[random.Next(range)]));

            return cyborg;
        }
    }
}