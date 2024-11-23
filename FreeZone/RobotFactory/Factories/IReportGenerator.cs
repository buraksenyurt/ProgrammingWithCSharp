using RobotFactory.Models;

namespace RobotFactory.Factories;

public interface IReportGenerator
{
    void Generate(List<Robot> robots);
}
