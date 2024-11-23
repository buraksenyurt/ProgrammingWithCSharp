using RobotFactory.Models;

namespace RobotFactory.Factories;

public class RobotFactory
    : IRobotFactory
{
    public Robot CreateRobot(string type, int productionCode, string name)
    {
        return type.ToLower() switch
        {
            "assembly" => new AssemblyRobot(productionCode, name),
            "transport" => new TransportRobot(productionCode, name),
            "inspection" => new InspectionRobot(productionCode, name),
            _ => throw new ArgumentException($"Unknown robot type: {type}")
        };
    }
}
