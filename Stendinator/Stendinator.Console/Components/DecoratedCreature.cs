using Stendinator.Core.Components;
using Stendinator.Core.Creatures;

namespace Stendinator.Console.Components
{
    internal class DecoratedCreature : Creature
    {
        protected Creature Creature { get; set; }

        public DecoratedCreature(Creature creature)
        {
            Creature = creature.Instance();
        }

        public override int Health
        {
            get => Creature.Health;
            set => Creature.Health = value;
        }

        public override int Defense
        {
            get => Creature.Defense;
            set => Creature.Defense = value;
        }

        public override Component[] Components
        {
            get => Creature.Components;
            set => Creature.Components = value;
        }

        public override Creature? Target
        {
            get => Creature.Target;
            set => Creature.Target = value;
        }

        public override Creature Instance()
        {
            return Creature;
        }

        public void Print()
        {
            System.Console.WriteLine
            (
                $"{Creature.GetType().Name} (Health: {Creature.Health}, Defense: {Creature.Defense}):\n" +
                $"Target: {Creature.Target?.GetType().Name ?? "---"}\n"
            );
        }
    }
}