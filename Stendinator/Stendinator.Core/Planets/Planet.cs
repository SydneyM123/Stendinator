using Stendinator.Core.Creatures;
using Stendinator.Core.Creatures.Factories;
using System;

namespace Stendinator.Core.Levels
{
    internal abstract class Planet
    {
        public event EventHandler PlanetIsBeaten;

        private IRandomCreatureFactory _creatureFactory;
        private int _numberOfEnemies;
        private Creature _currentEnemy;

        public Planet(IRandomCreatureFactory enemyFactory, int numberOfEnemies)
        {
            _creatureFactory = enemyFactory;
            _numberOfEnemies = numberOfEnemies;
            _currentEnemy = null;

            //events
            //_fightState.EnemyIsBeaten += EnemyIsBeaten;
        }

        public void EnemyIsBeaten(object s, EventArgs e)
        {
            //Remove current enemy
            _numberOfEnemies--;
            if (_numberOfEnemies <= 0)
            {
                PlanetIsBeaten?.Invoke(this, new EventArgs());
            }
            else
            {
                CreateCurrentCreature();
            }
        }

        public void CreateCurrentCreature()
        {
        }
    }
}