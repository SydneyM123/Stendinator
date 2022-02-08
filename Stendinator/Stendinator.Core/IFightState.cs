using Stendinator.Core.Enemies;
using Stendinator.Core.Robots;

namespace Stendinator.Core
{
    public interface IFightState
    {
        event EventHandler? EnemyIsBeaten;
        void Attack(IRobot p, IEnemy e);
    }
}