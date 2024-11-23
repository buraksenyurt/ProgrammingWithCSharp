using RobotFactory.Factories;
using RobotFactory.Models;
using RobotFactory.Reports;

namespace RobotFactory.Managers;

public class TaskManager
{
    private readonly IRobotFactory _robotFactory;
    private readonly ReportGenerator _reportGenerator;
    private readonly List<Robot> _robots = [];

    public TaskManager(IRobotFactory robotFactory, ReportGenerator reportGenerator)
    {
        _robotFactory = robotFactory;
        _reportGenerator = reportGenerator;
    }

    public void AddRobot(string type, int id, string name)
    {
        var robot = _robotFactory.CreateRobot(type, id, name);
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
        _reportGenerator.Generate(_robots);
    }
}
