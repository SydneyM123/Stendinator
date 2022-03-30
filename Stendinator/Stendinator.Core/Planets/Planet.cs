using System;
using Stendinator.Core.Creatures;
using Stendinator.Core.Creatures.Factories;

namespace Stendinator.Core.Planets
{
    internal abstract class Planet
    {
        public event EventHandler PlanetIsBeaten;

        protected IRandomCreatureFactory _creatureFactory;
        protected int _numberOfEnemies;
        protected Creature _currentEnemy;

        protected Planet(IRandomCreatureFactory creatureFactory, int numberOfEnemies)
        {
            _creatureFactory = creatureFactory;
            _numberOfEnemies = numberOfEnemies;

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
            _currentEnemy = _creatureFactory.Create();
        }
    }
}