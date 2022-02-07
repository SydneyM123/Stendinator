using Stendinator.Core.Enemies;
using Stendinator.Core.Robots;

namespace Stendinator.Core
{
    public class FightState : IFightState
    {
        public event EventHandler? EnemyIsBeaten;

        public void Attack(IRobot p, IEnemy e)
        {
            //Attack logica

            if (e.Statistics.Health <= 0)
                EnemyIsBeaten?.Invoke(this, new EventArgs());
        }
    }
}