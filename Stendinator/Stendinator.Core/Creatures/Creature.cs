using Stendinator.Core.Components;
using Stendinator.Core.Components.Arms;
using Stendinator.Core.Components.Buffs;
using Stendinator.Core.Components.Targets;

namespace Stendinator.Core.Creatures
{
    public abstract class Creature
    {
        private int _health;
        public virtual int Health
        {
            get => _health;
            set
            {
                _health += value;
                if (_health <= 0) CreatureBeaten?.Invoke(this, EventArgs.Empty);
            }
        }

        private int _defense;
        public virtual int Defense
        {
            get => _defense;
            set
            {
                _defense += value;
                if (_defense < 0) _defense = 0;
            }
        }

        public event EventHandler? CreatureBeaten;
        
        public virtual Component[] Components { get; set; } = Array.Empty<Component>();

        /// <summary>
        /// The entity this entity will be focused on.
        /// </summary>
        public virtual Creature? Target { get; set; }

        /// <summary>
        /// In order to not set the target as a decorated creature,
        /// this method should be called instead of assigning the actual object
        /// </summary>
        public virtual Creature Instance()
        {
            return this;
        }

        public void ResetStats()
        {
            _health = 0;
            _defense = 0;
            foreach (var component in Components)
            {
                Health = component.Passives.Health;
                Defense = component.Passives.Defense;
            }
        }

        /// <summary>
        /// Adds a component to the entity and if a usable component is added it will be linked to the HandleComponentActivatedComponent method.
        /// </summary>
        /// <param name="component">The component to be added</param>
        protected void AddComponent(Component component)
        {
            if (component.Passives == null) throw new Exception($"{nameof(component.Passives)} is null");
            var componentList = Components.ToList();
            componentList.Add(component);
            Components = componentList.ToArray();
            if (component is ActiveComponent activeComponent) activeComponent.ComponentActivated += HandleActivatedComponent;
            Health = component.Passives.Health;
            Defense = component.Passives.Defense;
        }

        /// <summary>
        /// Removes the specified component
        /// </summary>
        /// <param name="component">The component to be removed</param>
        protected void RemoveComponent(Component component)
        {
            if (component.Passives == null) throw new Exception($"{nameof(component.Passives)} is null");
            var componentList = Components.ToList();
            if (componentList.Remove(component))
            {
                if (component is ActiveComponent activeComponent)
                    activeComponent.ComponentActivated -= HandleActivatedComponent;
            }
            Health = component.Passives.Health < 0 ? component.Passives.Health : -component.Passives.Health;
            Defense = component.Passives.Defense < 0 ? component.Passives.Defense : -component.Passives.Defense;
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

        /// <summary>
        /// The defense is like a shield mechanism, it will break when damage is done.
        /// </summary>
        /// <param name="e">The target creature</param>
        private void InfluenceOnTarget(CreatureTarget e)
        {
            if (Target == null) return;
            var impactOnDefense = e.Consequences.Defense + e.Consequences.Health;
            var impactOnHealth = Target.Defense + impactOnDefense;
            if (impactOnDefense < 0) Target.Defense = impactOnDefense;
            var vulnerable = impactOnHealth < 0;
            if (vulnerable) Target.Health = impactOnHealth;
        }

        private void InfluenceOnSelf(CreatureTarget e)
        {
            if (Target == null) return;
            Health = e.Consequences.Health;
            Defense = e.Consequences.Defense;
        }

        /// <summary>
        /// Adds a random buff to an active component (based on decorator pattern)!
        /// </summary>
        /// <param name="component">The component to buff</param>
        /// <param name="buffIndex">The index of the buff type to decorate a component with (range = 1..6)</param>
        public void BuffComponent(ActiveComponent component, int buffIndex)
        {
            DecoratedActiveComponent buffComponent = buffIndex switch
            {
                1 => new SmallHealthBuff(component),
                2 => new MediumHealthBuff(component),
                3 => new LargeHealthBuff(component),
                4 => new SmallDefenseBuff(component),
                5 => new MediumDefenseBuff(component),
                6 => new LargeDefenseBuff(component),
                _ => throw new Exception("Buff not found")
            };
            Components[Components.ToList().FindIndex(x => x == component)] = buffComponent;
        }
    }
}