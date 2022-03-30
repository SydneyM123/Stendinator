using System;
using System.Linq;
using Stendinator.Core.Components;
using Stendinator.Core.Components.Arms;
using Stendinator.Core.Components.Heads;
using Stendinator.Core.Components.Legs;

namespace Stendinator.Core
{
    internal class GameState
    {
        public Turn Turn { get; set; }
        public int CurrentStage { get; set; }
        public Component[] EquipableComponents { get; set; }

        public GameState()
        {
            EquipableComponents = new Component[] { new ChainsawArm(), new ChainsawArm(), new BalancedBody(), new BalancedHead(), new BalancedLeg() };
            CurrentStage = 1;
            Turn = Turn.Player;
        }

        public Turn GetNextTurn()
        {
            if (Turn == Turn.Player)
            {
                Turn = Turn.Enemy;
                return Turn;
            }

            Turn = Turn.Player;
            return Turn;
        }
    }
}