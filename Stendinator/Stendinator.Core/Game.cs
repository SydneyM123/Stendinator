using Stendinator.Core.Levels;
using Stendinator.Core.Levels.Factories;

namespace Stendinator.Core
{
    public class Game
    {
        private Level? _level;
        private ILevelFactory _levelFactory;
        private int[] Stages { get; set; }

        public Game(ILevelFactory levelFactory)
        {
            _level = null;
            _levelFactory = levelFactory;
        }

        public void LevelIsBeaten(object? sender, EventArgs args)
        {
            //Remove current level
            if (_level != null)
                _level.LevelIsBeaten -= LevelIsBeaten;
            CreateNewLevel();
        }

        public void CreateNewLevel()
        {
            //Generate new level
            _level = _levelFactory.Create(new RandomLevelFactoryModel
            {
                NumberOfEnemies = 0,
                FightState = new FightState()
            });
            _level.LevelIsBeaten += LevelIsBeaten;
        }
    }
}