using Stendinator.Core.Components;
using System;
using Stendinator.Core.Creatures.Cyborgs;

namespace Stendinator.Core.Creatures.Builders
{
    internal class CyborgBuilder : ICreatureBuilder
    {
        private Cyborg _cyborg;

        public CyborgBuilder()
        {
            Reset();
        }

        private void Reset()
        {
            _cyborg = new Cyborg();
        }
        public void AddHead(Component c)
        {
            _cyborg.AddHead(c);
        }

        public void AddTorso(Component c)
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

        //TODO Discus if Builder is properly used
        public void CreatePlayer(Component[] components)
        {
            var arm = 0;
            var leg = 0;
            foreach (var component in components)
            {
                if (nameof(component).Contains("Head"))
                {
                    AddHead(component);
                }
                if (nameof(component).Contains("Body"))
                {
                    AddTorso(component);
                }
                if (nameof(component).Contains("Arm"))
                {
                    if (arm == 0)
                    {
                        AddLeftArm(component);
                        arm++;
                    }
                    else
                    {
                        AddRightArm(component);
                        arm = 0;
                    }
                }
                if (nameof(component).Contains("Leg"))
                {
                    if (leg == 0)
                    {
                        AddLeftLeg(component);
                        leg++;
                    }
                    else
                    {
                        AddRightLeg(component);
                        leg = 0;
                    }
                }
            }
        }

        public Creature GetCreature()
        {
            return _cyborg;
        }
    }
}