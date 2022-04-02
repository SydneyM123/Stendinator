using Stendinator.Core.Components.AbstractFactories;

namespace Stendinator.Core.Components.Factories
{
    public class RandomComponentFactory : IRandomComponentFactory
    {
        private readonly IActiveComponentFactory _componentFactory;
        private readonly IAbstractComponentFactory[] _abstractComponentFactories;

        protected readonly Random Random = new();

        public RandomComponentFactory()
        {
            _componentFactory = new ActiveComponentFactory();

            _abstractComponentFactories = new IAbstractComponentFactory[]
            {
                new SturdyComponentFactory(),
                new HealthyComponentFactory(),
                new BalancedComponentFactory()
            };
        }

        public Component GetRandomComponent(bool malicious)
        {
            return Random.Next(0, 4) switch
            {
                0 => GetRandomArm(malicious),
                1 => GetRandomHead(malicious),
                2 => GetRandomTorso(malicious),
                3 => GetRandomLeg(malicious),
                _ => throw new Exception("Random number is out of range")
            };
        }

        public Component GetRandomArm(bool malicious)
        {
            var index = Random.Next(0, _componentFactory.GetNames().Length);
            return _componentFactory.Create(_componentFactory.GetNames()[index], malicious);
        }


        public Component GetRandomLeg(bool malicious)
        {
            var index = Random.Next(0, _abstractComponentFactories.Length);
            return _abstractComponentFactories[index].CreateLeg(malicious);
        }

        public Component GetRandomHead(bool malicious)
        {
            var index = Random.Next(0, _abstractComponentFactories.Length);
            return _abstractComponentFactories[index].CreateHead(malicious);
        }

        public Component GetRandomTorso(bool malicious)
        {
            var index = Random.Next(0, _abstractComponentFactories.Length);
            return _abstractComponentFactories[index].CreateBody(malicious);
        }
    }
}