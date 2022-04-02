using Stendinator.Core.Components;
using Stendinator.Core.Components.Arms;
using Stendinator.Core.Components.Targets;

namespace Stendinator.Core.Creatures
{
    public abstract class Creature
    {
        private int _health;
        public int Health
        {
            get => _health;
            set
            {
                _health += value;
                if (_health <= 0) CreatureBeaten?.Invoke(this, EventArgs.Empty);
            }
        }

        private int _defense;
        public int Defense
        {
            get => _defense;
            set => _defense += value;
        }

        public event EventHandler? CreatureBeaten;
        
        public Component[] Components { get; private set; }

        /// <summary>
        /// The entity this entity will be focused on.
        /// </summary>
        public Creature? Target { get; set; }

        public void ResetStats()
        {
            _health = 0;
            _defense = 0;
            foreach (var component in Components)
            {
                Health = component.PassiveStats.Health;
                Defense = component.PassiveStats.Defense;
            }
        }

        protected Creature()
        {
            Components = Array.Empty<Component>();
        }

        /// <summary>
        /// Adds a component to the entity and if a usable component is added it will be linked to the HandleComponentActivatedComponent method.
        /// </summary>
        /// <param name="component">The component to be added</param>
        protected virtual void AddComponent(Component component)
        {
            if (component.PassiveStats == null) throw new Exception($"{nameof(component.PassiveStats)} is null");
            var componentList = Components.ToList();
            componentList.Add(component);
            Components = componentList.ToArray();
            if (component is ActiveComponent activeComponent) activeComponent.ComponentActivated += HandleActivatedComponent;
            Health = component.PassiveStats.Health;
            Defense = component.PassiveStats.Defense;
        }

        /// <summary>
        /// Removes the specified component
        /// </summary>
        /// <param name="component">The component to be removed</param>
        protected virtual void RemoveComponent(Component component)
        {
            if (component.PassiveStats == null) throw new Exception($"{nameof(component.PassiveStats)} is null");
            var componentList = Components.ToList();
            if (componentList.Remove(component))
            {
                if (component is ActiveComponent activeComponent)
                    activeComponent.ComponentActivated -= HandleActivatedComponent;
            };
            Health = component.PassiveStats.Health < 0 ? component.PassiveStats.Health : -component.PassiveStats.Health;
            Defense = component.PassiveStats.Defense < 0 ? component.PassiveStats.Defense : -component.PassiveStats.Defense;
            Components = componentList.ToArray();
        }

        /// <summary>
        /// The consequences the focused entity will be dealing with.
        /// </summary>
        /// <param name="ac">The component that has been used</param>
        /// <param name="e">Specific values the component influences</param>
        public void HandleActivatedComponent(ActiveComponent ac, CreatureTarget e)
        {
            if (ac is HealingArm or ShieldArm) InfluenceOnSelf(e);
            else InfluenceOnTarget(e);
        }

        private void InfluenceOnTarget(CreatureTarget e)
        {
            if (Target == null) return;
            Target.Health = e.Consequences.Health;
            Target.Defense = e.Consequences.Defense;
        }

        private void InfluenceOnSelf(CreatureTarget e)
        {
            if (Target == null) return;
            Health = e.Consequences.Health;
            Defense = e.Consequences.Defense;
        }
    }
}