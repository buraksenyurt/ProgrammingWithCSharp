namespace Azon.Business;

public class DefaultDiscountStrategy
    : IDiscountStrategy
{
    public decimal Apply(decimal amount)
    {
        return amount;
    }
}
