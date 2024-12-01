namespace Learning.SOLID.Basics.LSP;

public interface IPayment
{
    void ProcessPayment(decimal amount);
}

public class CreditCardPaymentProvider : IPayment
{
    public void ValidateCardDetails(string cardNumber, string expiryDate, string cvv)
    {
    }

    public void ProcessPayment(decimal amount)
    {
    }
}

public class CashPaymentProvider : IPayment
{
    public void ProcessPayment(decimal amount)
    {
    }
}

public class PaymentProcessor
{
    public void Process(IPayment payment, decimal amount)
    {
        payment.ProcessPayment(amount);
    }
}

public class Application
{
    public static void Run()
    {
        IPayment creditCardPayment = new CreditCardPaymentProvider();
        IPayment cashPayment = new CashPaymentProvider();

        PaymentProcessor processor = new();

        processor.Process(creditCardPayment, 1000);
        processor.Process(cashPayment, 1500);
    }
}
