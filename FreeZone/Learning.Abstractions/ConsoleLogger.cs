namespace Learning.Abstractions;

public class ConsoleLogger
    : ILogger
{
    public void Error(string message)
    {
        Console.WriteLine($"ERROR:{DateTime.Now}|{message}");
    }

    public void Info(string message)
    {
        Console.WriteLine($"INFO:{DateTime.Now}|{message}");
    }

    public void Warn(string message)
    {
        Console.WriteLine($"WARN:{DateTime.Now}|{message}");
    }
}
