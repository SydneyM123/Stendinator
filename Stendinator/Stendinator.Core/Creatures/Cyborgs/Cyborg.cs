using Stendinator.Core.Components;
using Stendinator.Core.Components.Arms;
using Stendinator.Core.Components.Targets;

namespace Stendinator.Core.Creatures.Cyborgs
{
    public class Cyborg : Creature
    {
        private Component _leftArm;
        private Component _rightArm;
        private Component _torso;
        private Component _head;
        private Component _leftLeg;
        private Component _rightLeg;

        public Cyborg()
        {
            _leftArm = null;
            _rightArm = null;
            _torso = null;
            _head = null;
            _leftLeg = null;
            _rightLeg = null;
            Target = new Cyborg();
        }

        public void AddLeftArm(Component component)
        {
            ChangeComponent(ref _leftArm, component);
        }

        public void AddRightArm(Component component)
        {
            ChangeComponent(ref _rightArm, component);
        }

        public void AddTorso(Component component)
        {
            ChangeComponent(ref _torso, component);
        }

        public void AddHead(Component component)
        {
            ChangeComponent(ref _head, component);
        }

        public void AddRightLeg(Component component)
        {
            ChangeComponent(ref _rightLeg, component);
        }

        public void AddLeftLeg(Component component)
        {
            ChangeComponent(ref _leftLeg, component);
        }

        private void ChangeComponent(ref Component oldComponent, Component newComponent)
        {
            if (oldComponent != null)
            {
                RemoveComponent(oldComponent);
            }
            oldComponent = newComponent;
            AddComponent(oldComponent);
        }

        public Component GetLeftArm()
        {
            return _leftArm;
        }

        public override void HandleActivatedComponent(ActiveComponent ac, Target e)
        {
            //Handle components used on Target entity

            if (!(e is Entity entityArgs)) return;
            Target = e.TargetCreature;

            if (ac is HealingArm || ac is ShieldArm)
            {
                this.Health += entityArgs.Consequences.HealthIncrease;
                this.Defense += entityArgs.Consequences.DefenseIncrease;
                return;
            }
            Target.Health -= entityArgs.Consequences.HealthDecrease;
            Target.Defense -= entityArgs.Consequences.DefenseDecrease;
        }
    }
}