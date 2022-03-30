using Stendinator.Core.Creatures;
using System;
using Stendinator.Core.Planets;
using Stendinator.Core.Planets.Factories;

namespace Stendinator.Core
{
    internal class Game
    {
        private Planet _currentPlanet;
        private Creature _player;
        private GameState _state;
        private readonly IRandomPlanetFactory _randomPlanetFactory;
        
        public Game(IRandomPlanetFactory levelFactory)
        {
            _randomPlanetFactory = levelFactory;
        }

        public void PlanetIsBeaten(object sender, EventArgs args)
        {
            //Remove current level
            if (_currentPlanet == null) return;
            _currentPlanet.PlanetIsBeaten -= PlanetIsBeaten;
            _state.CurrentStage++;
            CreateNewLevel();
        }

        public void CreateNewLevel()
        {
            var random = new Random();
            var levelTypes = new []{ nameof(AlienPlanet), nameof(CyborgPlanet)};
            //Generate new level
            _currentPlanet = _randomPlanetFactory.Create(_state.CurrentStage, levelTypes[random.Next(levelTypes.Length)]);
            _currentPlanet.PlanetIsBeaten += PlanetIsBeaten;
        }
    }
}