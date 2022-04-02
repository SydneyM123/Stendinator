using Stendinator.Core.Components;
using Stendinator.Core.Creatures.Cyborgs;

namespace Stendinator.Core.Creatures.Builders
{
    public class CyborgBuilder : ICreatureBuilder
    {
        private readonly Cyborg _cyborg;

        public CyborgBuilder()
        {
            _cyborg = new Cyborg();
        }

        public void AddHead(Component c)
        {
            _cyborg.AddHead(c);
        }

        public void AddBody(Component c)
        {
            _cyborg.AddTorso(c);
        }

        public void AddRightArm(Component c)
        {
            _cyborg.AddRightArm(c);
        }

        public void AddLeftArm(Component c)
        {
            _cyborg.AddLeftArm(c);
        }

        public void AddRightLeg(Component c)
        {
            _cyborg.AddRightLeg(c);
        }

        public void AddLeftLeg(Component c)
        {
            _cyborg.AddLeftLeg(c);
        }

        public Creature GetCreature()
        {
            return _cyborg;
        }
    }
}