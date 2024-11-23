namespace RobotFactory.Models;

public class TransportRobot(int productionCode, string name) 
    : Robot(productionCode, name)
{
    public override void PerformTask()
    {
        Console.WriteLine($"{Name} is transporting items for task: {Task}");
    }
}
