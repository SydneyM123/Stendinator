using Stendinator.Core.Robots.Arms;

namespace Stendinator.Core.Robots.Builders
{
    public class RobotBuilder : IRobotBuilder
    {
        private IRobotArm? _leftRobotArm;
        private IRobotArm? rightRobotArm;

        public IRobotBuilder AddRightRobotArm(IRobotArm robotArm)
        {
            _leftRobotArm = robotArm;
            return this;
        }

        public IRobotBuilder AddLeftRobotArm(IRobotArm robotArm)
        {
            rightRobotArm = robotArm;
            return this;
        }
    }
}