namespace Stendinator.Core.Entities
{
    public abstract class Entity
    {
        public int Health { get; set; }

        public abstract void Interact(Interaction i);
    }

    public abstract class Interaction
    {
        public Entity Entity { get; set; } = null;
    }
}