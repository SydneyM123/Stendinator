using Stendinator.Core.Components;

namespace Stendinator.Core
{
    internal class GameState
    {
        public Turn Turn { get; set; }
        public int[] Stages { get; set; }
        public int CurrentStage { get; set; }
        public Component[] EquipableComponents { get; set; }
    }
}