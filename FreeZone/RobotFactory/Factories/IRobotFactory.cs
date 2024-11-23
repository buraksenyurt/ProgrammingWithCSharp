using RobotFactory.Models;

namespace RobotFactory.Factories;

public interface IRobotFactory
{
    Robot CreateRobot(string type, int productionCode, string name);
}
