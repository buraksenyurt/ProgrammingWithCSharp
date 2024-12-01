namespace Learning.SOLID.Basics.LSP;

/*
    LSP,türetilmiş sınıfların türediği taban sınıf yerine kullanılabilir olmasını savunur.
    Aşağıdaki senaryoda Payment isimli base class diğer ödeme yöntemleri için uygun olmayan davranışları içermekte.
    Örneğin, CreditCardPayment sınıfı kredi kartı ödemesi ile ilgili davranışları devralırken CashPayment 
    sınıfı da kredi kartı bilgilerinin doğrulanması gibi gereksiz metotları devralıyor. Yani türeyen sınıf esasında türediği base class yerine kullanılamıyor. 
    Öyle ki CashPayment sınıfı ile çalışan bir object user taban sınıftan gelen gereksiz metotlarla uğraşmak zorunda kalmakta.
 */
public class Payment
{
    public virtual void ValidateCardDetails(string cardNumber, string expiryDate, string cvv)
    {
    }

    public virtual void ProcessPayment(decimal amount)
    {
    }
}

public class CreditCardPayment : Payment
{
    public override void ValidateCardDetails(string cardNumber, string expiryDate, string cvv)
    {
    }

    public override void ProcessPayment(decimal amount)
    {
    }
}

public class CashPayment : Payment
{
    public override void ValidateCardDetails(string cardNumber, string expiryDate, string cvv)
    {
        // Bu ödeme türünde kart bilgilerini ele almak tamamen gereksiz
        throw new NotImplementedException();
    }

    public override void ProcessPayment(decimal amount)
    {
    }
}


