namespace Azon.Business;

public class BlueCustomerDiscountStrategy
    : IDiscountStrategy
{
    public decimal Apply(decimal amount)
    {
        return amount * 0.95M;
    }
}

