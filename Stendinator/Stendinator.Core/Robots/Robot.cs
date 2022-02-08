namespace Stendinator.Core.Entities
{
    public class Robot : Entity
    {
        public override void Interact(Interaction i)
        {
            if (i is RobotOffensiveInteraction)
            {
                //Offensieve logica
            }
            else if (i is RobotDefensiveInteraction)
            {
                //Defensieve logica
            }
        }
    }

    public class RobotOffensiveInteraction : Interaction
    {
    }

    public class RobotDefensiveInteraction : Interaction
    {
    }
}