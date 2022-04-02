using Stendinator.Core.Components.Factories;

namespace Stendinator.Core.Creatures.Factories
{
    public abstract class RandomCreatureFactory
    {
        protected IRandomComponentFactory RandomComponentFactory;

        protected RandomCreatureFactory(IRandomComponentFactory randomComponentFactory)
        {
            RandomComponentFactory = randomComponentFactory;
        }

        public abstract Creature Create();
    }
}