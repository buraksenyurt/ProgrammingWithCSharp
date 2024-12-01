namespace Learning.SOLID.Basics.DIP;

/*
    DIP prensibi şunu savunur; Yüksek seviyeli modüller, düşük seviyeli modüllere bağımlı olmamalıdır.
    Aşağıdaki örnekte Notification bileşeni, EmailNotification bileşenine bağımlıdır. Farklı türde bir bildirim
    yapılmak istendiğinde bu mümkün değildir. Örneğin email yerine sms gönderimi söz konusu olabilir.
 */
public class EmailNotification
{
    public void SendEmail(string message)
    {
    }
}

public class Notification
{
    private readonly EmailNotification _emailNotification = new();

    public void Notify(string message)
    {
        _emailNotification.SendEmail(message);
    }
}
