using Stendinator.Core.Components;

namespace Stendinator.Core.Creatures.Humans
{
    internal class Human : Creature
    {
        public void AddLeftArm(Component component)
        {
            AddComponent(component);
        }

        public void AddRightArm(Component component)
        {
            AddComponent(component);
        }

        public void AddTorso(Component component)
        {
            AddComponent(component);
        }

        public void AddHead(Component component)
        {
            AddComponent(component);
        }

        public void AddRightLeg(Component component)
        {
            AddComponent(component);
        }

        public void AddLeftLeg(Component component)
        {
            AddComponent(component);
        }

        protected override void HandleUsedComponent(ActiveComponent c, ComponentUsedArgs e)
        {
            //Handle components used on Focused entity
        }
    }
}