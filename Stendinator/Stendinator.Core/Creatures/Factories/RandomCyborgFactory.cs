using Stendinator.Core.Components.Factories;
using Stendinator.Core.Creatures.Cyborgs;

namespace Stendinator.Core.Creatures.Factories
{
    public class RandomCyborgFactory : IRandomCreatureFactory
    {
        protected IRandomComponentFactory RandomComponentFactory;

        public RandomCyborgFactory(IRandomComponentFactory randomComponentFactory)
        {
            RandomComponentFactory = randomComponentFactory;
        }

        public virtual Creature Create()
        {
            var creature = new Cyborg();
            creature.AddHead(RandomComponentFactory.GetRandomHead(true));
            creature.AddTorso(RandomComponentFactory.GetRandomTorso(true));
            creature.AddLeftArm(RandomComponentFactory.GetRandomArm(true));
            creature.AddRightArm(RandomComponentFactory.GetRandomArm(true));
            creature.AddLeftLeg(RandomComponentFactory.GetRandomLeg(true));
            creature.AddRightLeg(RandomComponentFactory.GetRandomLeg(true));
            return creature;
        }
    }
}