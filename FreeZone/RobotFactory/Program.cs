using RobotFactory.Managers;
using RobotFactory.Reports;

namespace RobotFactory;

internal class Program
{
    static void Main()
    {
        var factory = new Factories.RobotFactory();
        var reporter = new ReportGenerator();
        var taskManager = new TaskManager(factory, reporter);

        taskManager.AddRobot("assembly", 1, "Assembler-1");
        taskManager.AddRobot("transport", 2, "Transporter-1");
        taskManager.AddRobot("inspection", 3, "Inspector-1");

        taskManager.AssignTaskToRobot(1, "Assemble an another robot");
        taskManager.AssignTaskToRobot(2, "Transport neccessary materials");
        taskManager.AssignTaskToRobot(3, "Inspect robot quality");

        taskManager.ExecuteAllTasks();

        taskManager.GenerateReport();
    }
}
