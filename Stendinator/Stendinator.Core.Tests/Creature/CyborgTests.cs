using Stendinator.Core.Creatures.Cyborgs;
using Stendinator.Core.Components;
using Stendinator.Core.Components.Arms;
using Stendinator.Core.Components.Heads;
using Stendinator.Core.Components.Targets;
using Stendinator.Core.Creatures.Factories;
using Stendinator.Core.Creatures.Aliens;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Stendinator.Core.Tests.Creature
{
    [TestClass]
    public class CyborgTests
    {
        private readonly RandomCyborgFactory _randomCyborgFactory = new RandomCyborgFactory();
        private Cyborg _cyborg = new Cyborg();

        [TestMethod]
        public void TestCyborgIsNotBuild()
        {
            Assert.IsNull(_cyborg.GetLeftArm());
        }

        [TestMethod]
        public void TestCyborgIsBuild()
        {
            _cyborg = (Cyborg)_randomCyborgFactory.Create();
            foreach (var component in _cyborg.Components)
            {
                Assert.IsInstanceOfType(component, typeof(Component));
            }
            _cyborg = new Cyborg();
        }

        [TestMethod]
        public void TestCyborgAttack()
        {
            _cyborg.AddTorso(new SturdyBody());

            Assert.AreEqual(20, _cyborg.Health);

            var creature = new Alien();

            creature.AddComponent( new FlameThrowerArm());
            var target = new Entity();
            target.SetTarget(_cyborg);
            creature.HandleActivatedComponent((ActiveComponent)creature.Components[0], target);

            // Assert.AreEqual(5, _cyborg.Health);
        }
    }
}