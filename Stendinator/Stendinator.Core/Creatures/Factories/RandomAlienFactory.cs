using System;
using System.Collections.Generic;
using System.Linq;
using Stendinator.Core.Components;
using Stendinator.Core.Components.Factories;
using Stendinator.Core.Components.Factories.AbstractComponentFactories;
using Stendinator.Core.Components.Factories.ConcreteFactories;
using Stendinator.Core.Components.Heads;
using Stendinator.Core.Creatures.Aliens;

namespace Stendinator.Core.Creatures.Factories
{
    public class RandomAlienFactory : IRandomCreatureFactory
    {
        // Perhaps Make Abstract Factory for Balanced, Healthy, and Sturdy
        private readonly ComponentFactory[] _componentFactories;
        private readonly IAbstractComponentFactory[] _abstractComponentFactories;
        
        public RandomAlienFactory()
        {
            _componentFactories = new ComponentFactory[]
            {
                new ConcreteChainSawArm(),
                new ConcreteFlameThrowerArm(),
                new ConcreteHealingArm(),
                new ConcreteShieldArm(),
                new ConcreteStunGunArm(),
            };

            _abstractComponentFactories = new IAbstractComponentFactory[]
            {
                new SturdyComponentFactory(),
                new HealthyComponentFactory(),
                new BalancedComponentFactory()
            };
        }

        public Creature Create()
        {

            var alien = new Alien();
            alien.AddComponent(GetRandomBody());
            alien.AddComponent(GetRandomLeg());
            alien.AddComponent(GetRandomHead());
            
            //Make 5 random components
            for (var i = 0; i < 5; i++)
            {
                
            }

            return alien;
        }

        private Component GetRandomArm()
        {
            Random random = new Random();
            int index = random.Next(0, _componentFactories.Length);
            return _componentFactories[index].Create();
        }


        private Component GetRandomLeg()
        {
            Random random = new Random();
            int index = random.Next(0, _componentFactories.Length);
            return _abstractComponentFactories[index].CreateLeg();
        }

        private Component GetRandomHead()
        {
            Random random = new Random();
            int index = random.Next(0, _componentFactories.Length);
            return _abstractComponentFactories[index].CreateHead();
        }

        private Component GetRandomBody()
        {
            Random random = new Random();
            int index = random.Next(0, _componentFactories.Length);
            return _abstractComponentFactories[index].CreateBody();
        }
    }
}