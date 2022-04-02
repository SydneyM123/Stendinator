using Stendinator.Core.Components;

namespace Stendinator.Core
{
    public class GameState
    {
        /// <summary>
        /// Singleton pattern (doesn't count but is still useful in our implementation)
        /// </summary>
        public static GameState Instance { get; set; } = new();

        public Turn Turn { get; set; }
        public int CurrentStage { get; set; }
        public List<Component> Components { get; set; }

        public GameState()
        {
            Components = new List<Component>();
            CurrentStage = 1;
            Turn = Turn.Player;
        }

        public void NextTurn()
        {
            Turn = Turn == Turn.Player ? Turn.Enemy : Turn.Player;
        }
    }
}