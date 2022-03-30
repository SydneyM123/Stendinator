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
        public int[] Stages { get; set; }
        public int CurrentStage { get; private set; }
        public Component[] EquipableComponents { get; set; }

        public GameState(int amountOfStages)
        {
            EquipableComponents = new Component[] { new ChainsawArm(), new ChainsawArm(), new BalancedBody(), new BalancedHead(), new BalancedLeg() };
            SetStages(amountOfStages);
            Turn = Turn.Player;
        }

        private void SetStages(int amount)
        {
            var stagesList = Stages.ToList();
            for (int i = 1; i <= amount; i++)
            {
                stagesList.Add(i);
            }
            Stages = stagesList.ToArray();
            CurrentStage = Stages[0];
        }

        public int SetCurrentStage(int stage)
        {
            if (stage < Stages.Length)
            {
                CurrentStage = stage;
                return CurrentStage;
            }

            throw new Exception("No Next Stage");
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