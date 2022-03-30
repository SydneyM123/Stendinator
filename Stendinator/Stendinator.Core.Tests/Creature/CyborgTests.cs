using Stendinator.Core.Creatures.Cyborgs;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Stendinator.Core.Components;
using Stendinator.Core.Creatures.Factories;

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
    }
}