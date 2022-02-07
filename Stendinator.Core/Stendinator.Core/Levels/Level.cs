using Stendinator.Core.Enemies;
using Stendinator.Core.Enemies.Factories;

namespace Stendinator.Core.Levels
{
    public class Level : ILevel
    {
        public event EventHandler? LevelIsBeaten;

        private IEnemyFactory _enemyFactory;
        private IFightState _fightState;
        private int _numberOfEnemies;
        private IEnemy? _currentEnemy;

        public Level(IEnemyFactory enemyFactory, int numberOfEnemies, IFightState fightState)
        {
            _enemyFactory = enemyFactory;
            _fightState = fightState;
            _numberOfEnemies = numberOfEnemies;
            _currentEnemy = null;

            //events
            _fightState.EnemyIsBeaten += EnemyIsBeaten;
        }

        public void EnemyIsBeaten(object? s, EventArgs e)
        {
            //Remove current enemy
            _numberOfEnemies--;
            if (_numberOfEnemies <= 0)
            {
                LevelIsBeaten?.Invoke(this, new EventArgs());
            }
            else
            {
                //Generate new current enemy
                CreateCurrentEnemy();
            }
        }

        public void CreateCurrentEnemy()
        {
            var num = new Random().Next(1, 11);
            if (num > 0 && num < 6)
                _currentEnemy = _enemyFactory.CreateStrongEnemy();
            else if (num > 5 && num < 10)
                _currentEnemy = _enemyFactory.CreateStrongerEnemy();
            else
                _currentEnemy = _enemyFactory.CreateStrongestEnemy();
        }
    }
}