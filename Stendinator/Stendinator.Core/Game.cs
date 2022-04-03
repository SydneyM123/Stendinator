using Stendinator.Core.Components.Factories;
using Stendinator.Core.Creatures;
using Stendinator.Core.Planets;
using Stendinator.Core.Planets.Factories;

namespace Stendinator.Core
{
    public class Game
    {
        private readonly Creature _player;
        private readonly Random _random;
        private readonly IRandomPlanetFactory _randomPlanetFactory;
        private readonly IRandomComponentFactory _randomComponentFactory;

        public Planet CurrentPlanet = null!;

        public event EventHandler? PlanetIsBeaten;
        public event EventHandler? EnemyIsBeaten;
        
        public Game(IRandomComponentFactory randomComponentFactory, IRandomPlanetFactory levelFactory, Creature player)
        {
            _random = new Random();
            _randomComponentFactory = randomComponentFactory;
            _randomPlanetFactory = levelFactory;
            _player = player.Instance();

            CreateNewLevel();
        }

        /// <summary>
        /// Removes the current level when planet is beaten
        /// </summary>
        public void HandlePlanetIsBeaten(object? sender, EventArgs args)
        {
            GameState.Instance.CurrentStage++;
            CreateNewLevel();
            PlanetIsBeaten?.Invoke(this, EventArgs.Empty);
        }
        
        public void CreateNewLevel()
        {
            var levelTypes = new[] { nameof(AlienPlanet), nameof(CyborgPlanet) };
            CurrentPlanet = _randomPlanetFactory.Create(levelTypes[_random.Next(levelTypes.Length)], _player);
            CurrentPlanet.EnemyIsBeaten += (_, _) =>
            {
                _player.ResetStats();
                DropComponents(_random.Next(1, 3));
                EnemyIsBeaten?.Invoke(this, EventArgs.Empty);
            };
            CurrentPlanet.PlanetIsBeaten += HandlePlanetIsBeaten;
        }

        private void DropComponents(int amount)
        {
            for (var i = 0; i < amount; i++)
                GameState.Instance.Components.Add(_randomComponentFactory.GetRandomComponent(false));
        }
    }
}