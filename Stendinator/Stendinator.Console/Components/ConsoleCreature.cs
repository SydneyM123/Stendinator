using Stendinator.Core.Components;
using Stendinator.Core.Creatures;

namespace Stendinator.Console.Components
{
    internal class ConsoleCreature : Creature
    {
        private readonly Creature _creature;

        public ConsoleCreature(Creature creature)
        {
            _creature = creature.Instance();
        }

        public override int Health
        {
            get => _creature.Health;
            set => _creature.Health = value;
        }

        public override int Defense
        {
            get => _creature.Defense;
            set => _creature.Defense = value;
        }

        public override Component[] Components
        {
            get => _creature.Components;
            set => _creature.Components = value;
        }

        public override Creature? Target
        {
            get => _creature.Target;
            set => _creature.Target = value;
        }

        public override Creature Instance()
        {
            return _creature;
        }

        public void Print()
        {
            System.Console.WriteLine
            (
                $"{_creature.GetType().Name} (Health: {_creature.Health}, Defense: {_creature.Defense}):\n" +
                $"Target: {_creature.Target?.GetType().Name ?? "---"}\n"
            );
        }
    }
}