namespace Learning.SOLID.Basics.DIP;

public interface INotify
{
    void Notify(string message);
}

public class SmsNotify : INotify
{
    public void Notify(string message)
    {
    }
}

public class EmailNotify : INotify
{
    public void Notify(string message)
    {
    }
}

public class VoiceCallNotify : INotify
{
    public void Notify(string message)
    {
    }
}

public class NotifyService
{
    private readonly Queue<INotify> _notifiers;

    public NotifyService(Queue<INotify> notifiers)
    {
        _notifiers = notifiers;
    }

    public void Notify(string message)
    {
        //_notifier.Notify(message);
        foreach (INotifier notifier in _notifiers)
        {
            notifier.Notify(message);
        }
    }
}

public class ObjectUser
{
    public static void Run()
    {
        INotify voiceCallNotifier = new VoiceCallNotify();
        INotify smsNotifier = new SmsNotify();

        Queue<INotify> notifiers = new Queue<INotify>();
        notifiers.Enqueue(smsNotifier);
        notifiers.Enqueue(voiceCallNotifier);

        NotifyService service = new NotifyService(notifiers);
        service.Notify("Bir sonraki ödemeniz için hatırlatma");
    }
}

