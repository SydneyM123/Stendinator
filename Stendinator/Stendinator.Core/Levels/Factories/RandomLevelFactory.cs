using Stendinator.Core.Enemies.Factories;

namespace Stendinator.Core.Levels.Factories
{
    public class RandomLevelFactory : ILevelFactory
    {
        public Level Create(ILevelFactoryModel model)
        {
            if (model is not RandomLevelFactoryModel randomModel)
                throw new Exception($"Model is not of type {nameof(RandomLevelFactoryModel)}");
            var num = new Random().Next(1, 3);
            if (num == 1)
                return new Level(new RandomRobotEnemyFactory(), randomModel.NumberOfEnemies, randomModel.FightState);
            else
                return new Level(new RandomAlienEnemyFactory(), randomModel.NumberOfEnemies, randomModel.FightState);
        }
    }

    public class RandomLevelFactoryModel : ILevelFactoryModel
    {
        public int NumberOfEnemies { get; set; }
        public IFightState FightState { get; set; }
    }
}