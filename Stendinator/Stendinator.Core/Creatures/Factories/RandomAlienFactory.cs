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
        private readonly ComponentFactory[] _componentFactories;
        private readonly IAbstractComponentFactory[] _abstractComponentFactories;
        private int MaxComponents;
        
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

            MaxComponents = new Random().Next(3, 8);
        }

        public Creature Create()
        {

            var alien = new Alien();
            alien.AddComponent(GetRandomBody());
            alien.AddComponent(GetRandomLeg());
            alien.AddComponent(GetRandomHead());
            
            for (var i = 0; i < MaxComponents; i++)
            {
                alien.AddComponent(GetRandomComponent());
            }

            return alien;
        }

        private Component GetRandomComponent()
        {
            int randomNumber = new Random().Next(0, 4);

            switch(randomNumber)
            {
                case 1:
                    return GetRandomArm();
                case 2:
                    return GetRandomHead();
                case 3:
                    return GetRandomBody();
                case 4:
                    return GetRandomLeg();
                default:
                    return null;
            }
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