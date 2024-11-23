namespace RobotFactory.Models;

public class InspectionRobot(int productionCode, string name) : Robot(productionCode, name)
{
    public override void PerformTask()
    {
        Console.WriteLine($"{Name} is inspecting quality for task: {Task}");
    }
}
