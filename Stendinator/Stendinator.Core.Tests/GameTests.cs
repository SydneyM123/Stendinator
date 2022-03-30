using Stendinator.Core.Planets;
using Stendinator.Core.Creatures.Factories;
using Stendinator.Core.Planets.Factories;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Stendinator.Core.Tests
{
    [TestClass]
    public class GameTests
    {
        private readonly Game _game = new Game(new RandomPlanetFactory());
        
        [TestMethod]
        public void CreatePlanet()
        {
            _game.CreateNewLevel();
        
            Assert.IsNotNull(_game.CurrentPlanet);
        }
    }
}
