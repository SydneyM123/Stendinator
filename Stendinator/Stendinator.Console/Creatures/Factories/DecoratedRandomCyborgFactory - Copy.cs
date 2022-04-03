using Stendinator.Console.Components;
using Stendinator.Core.Components.Factories;
using Stendinator.Core.Creatures;
using Stendinator.Core.Creatures.Factories;

namespace Stendinator.Console.Creatures.Factories
{
    internal class DecoratedRandomCyborgFactory : RandomCyborgFactory
    {
        public DecoratedRandomCyborgFactory(IRandomComponentFactory randomComponentFactory) : base(randomComponentFactory)
        {
        }

        public override Creature Create()
        {
            return new DecoratedCreature(base.Create());
        }
    }
}