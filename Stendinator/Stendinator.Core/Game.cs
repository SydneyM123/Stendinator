using Stendinator.Core.Creatures;
using Stendinator.Core.Levels;
using Stendinator.Core.Levels.Factories;
using System;

namespace Stendinator.Core
{
    internal class Game
    {
        private Planet _currentPlanet;
        private IRandomPlanetFactory _randomPlanetFactory;
        private Creature _player;

        private int[] Stages { get; set; }


        public Game(IRandomPlanetFactory levelFactory)
        {
            _currentPlanet = null;
            _randomPlanetFactory = levelFactory;
        }

        public void PlanetIsBeaten(object sender, EventArgs args)
        {
            //Remove current level
            if (_currentPlanet != null)
                _currentPlanet.PlanetIsBeaten -= PlanetIsBeaten;
            CreateNewLevel();
        }

        public void CreateNewLevel()
        {
            //Generate new level
            _currentPlanet = _randomPlanetFactory.Create(0);
            _currentPlanet.PlanetIsBeaten += PlanetIsBeaten;
        }
    }
}