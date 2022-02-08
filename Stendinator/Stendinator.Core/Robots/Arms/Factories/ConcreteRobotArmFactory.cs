namespace Stendinator.Core.Robots.Arms.Factories
{
    public class ConcreteRobotArmFactory
    {
        public IRobotArm Create(string robotArm)
        {
            switch (robotArm)
            {
                case nameof(FlameThrowerArm):
                    return new FlameThrowerArm();
                default:
                    throw new Exception("Robot arm not found!");
            }
        }
    }
}