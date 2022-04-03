using Stendinator.Core.Creatures;
using Stendinator.Core.Creatures.Factories;

namespace Stendinator.Core.Planets
{
    public abstract class Planet
    {
        private readonly Creature _player;

        protected IRandomCreatureFactory CreatureFactory;
        protected int NumberOfEnemies;

        public event EventHandler? PlanetIsBeaten;
        public event EventHandler? EnemyIsBeaten;
        
        public Creature CurrentEnemy;

        protected Planet(IRandomCreatureFactory creatureFactory, int numberOfEnemies, Creature player)
        {
            if (numberOfEnemies <= 0) PlanetIsBeaten?.Invoke(this, EventArgs.Empty);
            CreatureFactory = creatureFactory;
            NumberOfEnemies = numberOfEnemies;
            _player = player.Instance();
            CurrentEnemy = CreatureFactory.Create();
            CurrentEnemy.Target = _player.Instance();
            _player.Target = CurrentEnemy.Instance();
            CurrentEnemy.CreatureBeaten += HandleCreatureBeaten;
        }

        /// <summary>
        /// Remove current enemy and generate new enemy if NumberOfEnemies is greater than zero
        /// </summary>
        public void HandleCreatureBeaten(object? sender, EventArgs args)
        {
            NumberOfEnemies--;
            EnemyIsBeaten?.Invoke(this, EventArgs.Empty);
            if (NumberOfEnemies <= 0)
            {
                PlanetIsBeaten?.Invoke(this, EventArgs.Empty);
                return;
            }
            CurrentEnemy = CreatureFactory.Create();
            CurrentEnemy.Target = _player.Instance();
            CurrentEnemy.CreatureBeaten += HandleCreatureBeaten;
            _player.Target = CurrentEnemy.Instance();
        }
    }
}