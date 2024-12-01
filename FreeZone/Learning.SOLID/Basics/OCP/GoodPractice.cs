namespace Learning.SOLID.Basics.OCP;

/*
    İndirim hesaplaması yapan davranış bir arayüz ile soyutlanmıştır
    Buna göre Çalışan ve Öğrenci için bu stratejiler istenildiği gibi yazılabilir ve DiscountProvider tarafından kullanılabilir.
    Söz gelimi Student ve Employee dışında farklı bir koşula göre indirim alabilecek Veteran'ların da sisteme dahil edildiğini düşünelim.
    Normalde DiscountManager sınıfında yeni bir if bloğu açmamız ve kodu değiştirmemiz gerekecekti.

 */
public interface IDiscountStrategy
{
    decimal Apply(double amount);
}

public class EmployeeDiscount : IDiscountStrategy
{
    public decimal Apply(double amount)
    {
        return (decimal)(amount * 0.3);
    }
}

public class StudentDiscount : IDiscountStrategy
{
    public decimal Apply(double amount)
    {
        return (decimal)(amount * 0.7);
    }
}

public class VeteranDiscount : IDiscountStrategy
{
    public decimal Apply(double amount)
    {
        return (decimal)(amount * 0.9);
    }
}

public class DiscountProvider
{
    public static decimal Calculate(double amount, IDiscountStrategy strategy)
    {
        return strategy.Apply(amount);
    }
}

public class Application
{
    public static void Run()
    {
        IDiscountStrategy discountStrategy = new VeteranDiscount();
        DiscountProvider.Calculate(1000, discountStrategy);
    }
}
