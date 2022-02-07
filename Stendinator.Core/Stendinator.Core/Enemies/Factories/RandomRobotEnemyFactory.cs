using Stendinator.Core.Robots.Builders;

namespace Stendinator.Core.Enemies.Factories
{
    public class RandomRobotEnemyFactory : IEnemyFactory
    {
        private IRobotBuilder _robotBuilder;

        public RandomRobotEnemyFactory()
        {
            _robotBuilder = new RobotBuilder();
        }

        public IStrongEnemy CreateStrongEnemy()
        {
            throw new NotImplementedException();
        }

        public IStrongerEnemy CreateStrongerEnemy()
        {
            throw new NotImplementedException();
        }

        public IStrongestEnemy CreateStrongestEnemy()
        {
            throw new NotImplementedException();
        }
    }
}