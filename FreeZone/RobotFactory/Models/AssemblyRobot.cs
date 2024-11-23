namespace RobotFactory.Models;

public class AssemblyRobot(int productionCode, string name)
    : Robot(productionCode, name)
{
    public override void PerformTask()
    {
        Console.WriteLine($"{Name} is assembling parts for task: {Task}");
    }
}
