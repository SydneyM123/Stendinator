using Stendinator.Core.Components;
using Stendinator.Core.Components.AbstractFactories;
using Stendinator.Core.Components.Bodies;
using Stendinator.Core.Components.Heads;
using Stendinator.Core.Components.Legs;

namespace Stendinator.Console.Components.AbstractFactories
{
    internal class AbstractComponentFactory
    {
        private readonly BalancedComponentFactory _balancedComponentFactory;
        private readonly HealthyComponentFactory _healthyComponentFactory;
        private readonly SturdyComponentFactory _sturdyComponentFactory;

        public AbstractComponentFactory()
        {
            _balancedComponentFactory = new BalancedComponentFactory();
            _healthyComponentFactory = new HealthyComponentFactory();
            _sturdyComponentFactory = new SturdyComponentFactory();
        }

        public Component CreateHead(string name, bool malicious)
        {
            return name switch
            {
                nameof(BalancedHead) => _balancedComponentFactory.CreateHead(malicious),
                nameof(HealthyHead) => _healthyComponentFactory.CreateHead(malicious),
                nameof(SturdyHead) => _sturdyComponentFactory.CreateHead(malicious),
                _ => throw new Exception($"Head not found {name}")
            };
        }

        public Component CreateLeg(string name, bool malicious)
        {
            return name switch
            {
                nameof(BalancedLeg) => _balancedComponentFactory.CreateLeg(malicious),
                nameof(HealthyLeg) =>  _healthyComponentFactory.CreateLeg(malicious),
                nameof(SturdyLeg) => _sturdyComponentFactory.CreateLeg(malicious),
                _ => throw new Exception($"Leg not found {name}")
            };
        }

        public Component CreateBody(string name, bool malicious)
        {
            return name switch
            {
                nameof(BalancedBody) => _balancedComponentFactory.CreateBody(malicious),
                nameof(HealthyBody) => _healthyComponentFactory.CreateBody(malicious),
                nameof(SturdyBody) => _sturdyComponentFactory.CreateBody(malicious),
                _ => throw new Exception($"Body not found {name}")
            };
        }

        public static string[] GetHeadNames()
        {
            return new[]
            {
                nameof(BalancedHead),
                nameof(HealthyHead),
                nameof(SturdyHead),
            };
        }

        public static string[] GetLegNames()
        {
            return new[]
            {
                nameof(BalancedLeg),
                nameof(HealthyLeg),
                nameof(SturdyLeg),
            };
        }

        public static string[] GetBodyNames()
        {
            return new[]
            {
                nameof(BalancedBody),
                nameof(HealthyBody),
                nameof(SturdyBody),
            };
        }
    }
}