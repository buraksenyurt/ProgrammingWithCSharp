namespace Learning.Delegates;

delegate void OrderProcessedHandler(string orderId);

class OrderProcessor
{
    public event OrderProcessedHandler OrderProcessed;

    public void ProcessOrder(string orderId)
    {
        Console.WriteLine($"Order {orderId} is being processed...");
        System.Threading.Thread.Sleep(1000);
        Console.WriteLine($"Order {orderId} processed!");

        OrderProcessed?.Invoke(orderId);
    }
}

class EventSample
{
    public static void Run()
    {
        var processor = new OrderProcessor();

        processor.OrderProcessed += orderId => Console.WriteLine($"Email sent for order {orderId}");
        processor.OrderProcessed += orderId => Console.WriteLine($"Data Warehouse notified for order {orderId}");

        Console.WriteLine("Enter order ID:");
        string orderId = Console.ReadLine();

        processor.ProcessOrder(orderId);
    }
}
