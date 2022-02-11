using Stendinator.Core.Components;
using System.Linq;

namespace Stendinator.Core.Creatures
{
    internal abstract class Creature
    {
        public int Health { get; set; }
        public int Defense { get; set; }

        public Component[] Components { get; private set; }

        /// <summary>
        /// The entity this entity will be focused on.
        /// </summary>
        public Creature Focused { get; set; }

        public Creature()
        {
            Components = new Component[0];
        }

        /// <summary>
        /// Adds a component to the entity and if a usable component is added it will be linked to the HandleUsedComponent method.
        /// </summary>
        /// <param name="component">The component to be added</param>
        public void AddComponent(Component component)
        {
            var componentList = Components.ToList();
            componentList.Add(component);
            Components = componentList.ToArray();
            if (component is ActiveComponent uc) uc.Used += HandleUsedComponent;
        }

        /// <summary>
        /// The consequences the focused entity will be dealing with.
        /// </summary>
        /// <param name="uc">The component that has been used</param>
        /// <param name="e">Specific values the component has influence on</param>
        protected abstract void HandleUsedComponent(ActiveComponent uc, ComponentUsedArgs e);
    }
}