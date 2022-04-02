using Stendinator.Core.Components.Arms;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace Stendinator.Core.Tests.Components
{
    [TestClass]
    public class FlameThrowerArmTests
    {
        [TestMethod]
        public void GetHealthIncrease()
        {
            var arm = new FlameThrowerArm();
            Assert.AreEqual(8, arm.PassiveStats.Health);
        }
    }
}
