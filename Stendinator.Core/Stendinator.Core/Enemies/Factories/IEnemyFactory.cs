namespace Stendinator.Core.Enemies.Factories
{
    public interface IEnemyFactory
    {
        public IStrongEnemy CreateStrongEnemy();
        public IStrongerEnemy CreateStrongerEnemy();
        public IStrongestEnemy CreateStrongestEnemy();
    }
}