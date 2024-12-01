namespace Learning.SOLID.Basics.DIP;

public interface INotifier
{
    void Notify(string message);
}

public class SmsNotifier : INotifier
{
    public void Notify(string message)
    {
    }
}

public class EmailNotifier : INotifier
{
    public void Notify(string message)
    {
    }
}

public class VoiceCallNotifier : INotifier
{
    public void Notify(string message)
    {
    }
}

public class NotificationService
{
    private readonly INotifier _notifier;

    public NotificationService(INotifier notifier)
    {
        _notifier = notifier;
    }

    public void Notify(string message)
    {
        _notifier.Notify(message);
    }
}

public class Application
{
    public static void Run()
    {
        INotifier notifier = new VoiceCallNotifier();
        NotificationService service = new NotificationService(notifier);
        service.Notify("Bir sonraki ödemeniz için hatırlatma");
    }
}

