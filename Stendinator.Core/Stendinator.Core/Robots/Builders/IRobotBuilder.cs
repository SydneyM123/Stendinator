using Stendinator.Core.Robots.Arms;

namespace Stendinator.Core.Robots.Builders
{
    public interface IRobotBuilder
    {
        IRobotBuilder AddLeftRobotArm(IRobotArm robotArm);
        IRobotBuilder AddRightRobotArm(IRobotArm robotArm);
    }
}