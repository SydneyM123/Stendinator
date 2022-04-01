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


        [TestMethod]
        public void TestCyborgIsNotBuild()
        {
            Cyborg cyborg = new Cyborg();
            Assert.IsNull(cyborg.GetLeftArm());
        }


        [TestMethod]
        public void TestCyborgIsBuild()
        {
            var cyborg = new Cyborg();
            cyborg = (Cyborg)_randomCyborgFactory.Create();
            foreach (var component in cyborg.Components)
            {
                Assert.IsInstanceOfType(component, typeof(Component));
            }
        }

        [TestMethod]
        public void TestCyborgAttack()
        {
            var cyborg = new Cyborg();
            cyborg.AddTorso(new SturdyBody());

            Assert.AreEqual(20, cyborg.Health);

            var creature = new Alien();

            creature.AddComponent(new FlameThrowerArm());
            var target = new Entity();
            target.SetTarget(cyborg);
            creature.HandleActivatedComponent((ActiveComponent)creature.Components[0], target);

            Assert.AreEqual(5, cyborg.Health);
        }
    }
}