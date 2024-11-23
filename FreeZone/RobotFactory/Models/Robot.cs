namespace RobotFactory.Models;

public abstract class Robot(int productionCode, string name)
{
    public int ProductionCode { get; } = productionCode;
    public string Name { get; } = name;
    public string Task { get; private set; } = "Idle";

    public virtual void AssignTask(string task)
    {
        Task = task;
        Console.WriteLine($"{Name} assigned task: {task}");
    }

    public abstract void PerformTask();

    public override string ToString()
    {
        return $"{ProductionCode}-> {Name}, Task: {Task})";
    }
}
