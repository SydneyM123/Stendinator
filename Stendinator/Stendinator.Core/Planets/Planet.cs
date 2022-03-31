using System;
using Stendinator.Core.Creatures;
using Stendinator.Core.Creatures.Factories;

namespace Stendinator.Core.Planets
{
    public abstract class Planet
    {
        public event EventHandler PlanetIsBeaten;

        protected IRandomCreatureFactory CreatureFactory;
        protected int NumberOfEnemies;
        private Creature _currentEnemy;

        protected Planet(IRandomCreatureFactory creatureFactory, int numberOfEnemies)
        {
            CreatureFactory = creatureFactory;
            NumberOfEnemies = numberOfEnemies;
            CreateCurrentCreature();
            //events
            //_fightState.EnemyIsBeaten += EnemyIsBeaten;
        }

        public void EnemyIsBeaten(object s, EventArgs e)
        {
            //Remove current enemy
            NumberOfEnemies--;
            if (NumberOfEnemies <= 0)
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
            _currentEnemy = CreatureFactory.Create();
        }
    }
}