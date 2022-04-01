using Stendinator.Core.Creatures;
using System;
using System.Linq;
using Stendinator.Core.Components;
using Stendinator.Core.Creatures.Builders;
using Stendinator.Core.Creatures.Cyborgs;
using Stendinator.Core.Planets;
using Stendinator.Core.Planets.Factories;

namespace Stendinator.Core
{
    public class Game
    {
        public Planet CurrentPlanet;
        private Cyborg _player;
        private CyborgBuilder _cyborgBuilder;
        private GameState _state;
        private readonly IRandomPlanetFactory _randomPlanetFactory;

        public Game(IRandomPlanetFactory levelFactory)
        {
            _randomPlanetFactory = levelFactory;
            _cyborgBuilder = new CyborgBuilder();
            _state = new GameState();
            _cyborgBuilder.CreatePlayer(_state.EquipableComponents);
            _player = new Cyborg();
            _player = _cyborgBuilder.CreatePlayer(_state.EquipableComponents);
        }

        public void PlanetIsBeaten(object sender, EventArgs args)
        {
            //Remove current level
            if (CurrentPlanet == null) return;
            CurrentPlanet.PlanetIsBeaten -= PlanetIsBeaten;
            _state.CurrentStage++;
            CreateNewLevel();
        }

        public void CreateNewLevel()
        {
            var random = new Random();
            var levelTypes = new[] { nameof(AlienPlanet), nameof(CyborgPlanet) };
            //Generate new level
            CurrentPlanet = _randomPlanetFactory.Create(_state.CurrentStage, levelTypes[random.Next(levelTypes.Length)]);
            CurrentPlanet.PlanetIsBeaten += PlanetIsBeaten;
        }
    }

}