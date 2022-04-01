using System;
using Stendinator.Core.Components;
using System.Linq;
using Windows.ApplicationModel.DataTransfer;
using Stendinator.Core.Components.Targets;

namespace Stendinator.Core.Creatures
{
    public abstract class Creature
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
            Components = new Component[0];
        }

        /// <summary>
        /// Adds a component to the entity and if a usable component is added it will be linked to the HandleComponentActivatedComponent method.
        /// </summary>
        /// <param name="component">The component to be added</param>
        public void AddComponent(Component component)
        {
            var componentList = Components.ToList();
            componentList.Add(component);
            Components = componentList.ToArray();
            if (component is ActiveComponent activeComponent) activeComponent.ComponentActivated += HandleActivatedComponent;
            Health += component.PassiveStats.HealthIncrease;
            Defense += component.PassiveStats.DefenseIncrease;
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
                    activeComponent.ComponentActivated -= HandleActivatedComponent;
            };
            Health -= component.PassiveStats.HealthIncrease;
            Defense -= component.PassiveStats.DefenseIncrease;
            Components = componentList.ToArray();
        }

        /// <summary>
        /// The consequences the focused entity will be dealing with.
        /// </summary>
        /// <param name="activeComponent">The component that has been used</param>
        /// <param name="e">Specific values the component influences</param>
        public abstract void HandleActivatedComponent(ActiveComponent activeComponent, Target e);
    }
}