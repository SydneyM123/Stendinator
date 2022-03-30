using System;
using Stendinator.Core.Creatures;
using Stendinator.Core.Creatures.Factories;

namespace Stendinator.Core.Planets
{
    public abstract class Planet
    {
        public event EventHandler PlanetIsBeaten;

        private protected IRandomCreatureFactory _creatureFactory;
        private protected int _numberOfEnemies;
        private Creature _currentEnemy;

        protected Planet(IRandomCreatureFactory creatureFactory, int numberOfEnemies)
        {
            _creatureFactory = creatureFactory;
            _numberOfEnemies = numberOfEnemies;
            CreateCurrentCreature();
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