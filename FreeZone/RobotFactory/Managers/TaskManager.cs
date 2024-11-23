using RobotFactory.Factories;
using RobotFactory.Models;
using RobotFactory.Reports;

namespace RobotFactory.Managers;

public class TaskManager(IRobotFactory robotFactory, ReportGenerator reportGenerator)
{
    private readonly List<Robot> _robots = [];

    public void AddRobot(string type, int id, string name)
    {
        var robot = robotFactory.CreateRobot(type, id, name);
        _robots.Add(robot);
        Console.WriteLine($"{robot.Name} added to task manager.");
    }

    public void AssignTaskToRobot(int productionCode, string task)
    {
        var robot = _robots.FirstOrDefault(r => r.ProductionCode == productionCode);
        if (robot == null)
        {
            Console.WriteLine($"Robot with production code {productionCode} not found.");
            return;
        }

        robot.AssignTask(task);
    }

    public void ExecuteAllTasks()
    {
        foreach (var robot in _robots)
        {
            robot.PerformTask();
        }
    }

    public void GenerateReport()
    {
        reportGenerator.Generate(_robots);
    }
}
