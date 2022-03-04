using Stendinator.Core.Components;
using System.Linq;
using Stendinator.Core.Components.Targets;

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
        public Creature Target { get; set; }

        protected Creature()
        {
        }

        /// <summary>
        /// Adds a component to the entity and if a usable component is added it will be linked to the HandleComponentActivatedComponent method.
        /// </summary>
        /// <param name="component">The component to be added</param>
        protected void AddComponent(Component component)
        {
            var componentList = Components.ToList();
            componentList.Add(component);
            Components = componentList.ToArray();
            if (component is ActiveComponent activeComponent) activeComponent.ComponentActivated += HandleComponentActivatedComponent;
        }

        /// <summary>
        /// Removes the specified component
        /// </summary>
        /// <param name="component">The component to be removed</param>
        protected void RemoveComponent(Component component)
        {
            var componentList = Components.ToList();
            if (componentList.Remove(component))
            {
                if (component is ActiveComponent activeComponent)
                    activeComponent.ComponentActivated -= HandleComponentActivatedComponent;
            };
            Components = componentList.ToArray();
        }

        /// <summary>
        /// The consequences the focused entity will be dealing with.
        /// </summary>
        /// <param name="activeComponent">The component that has been used</param>
        /// <param name="args">Specific values the component has influence on</param>
        protected abstract void HandleComponentActivatedComponent(ActiveComponent activeComponent, Target args);
    }
}