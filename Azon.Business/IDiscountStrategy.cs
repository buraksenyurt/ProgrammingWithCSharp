namespace Azon.Business;

public interface IDiscountStrategy
{
    decimal Apply(decimal amount);
}
