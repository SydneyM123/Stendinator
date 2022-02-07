using Stendinator.Core.Robots.Arms.Factories;
using Stendinator.Core.Robots.Builders;

namespace Stendinator.Core
{
    public static class MainApp
    {
        public static RobotBuilder builder = new RobotBuilder();
        public static ConcreteRobotArmFactory factory = new ConcreteRobotArmFactory();

        public static void OnAddRobotLeftArm(object s, EventArgs e)
        {
            builder.AddLeftRobotArm(factory.Create(nameof(e)));
        }
    }
}