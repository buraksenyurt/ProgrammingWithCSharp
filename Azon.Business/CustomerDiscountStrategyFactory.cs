namespace Azon.Business;

/*
    OrderingService sınıfındaki CalculateTotal metodu, CustomerType değerine göre bir indirim uygular.
    Aslında bu indirim, IDiscountStrategy türeli nesneler tarafından yapılır.
    Zira OrderingService yeni indirim stratejileri kullanabilir veya var olanlar değişebilir.
    Open Closed ilkesine göre değişikliğe kapalı genişlemeye açık olması gerekir.

    Aşağıdaki Factory sınıfı ise, OrderingService'in ihtiyaç duyduğu noktada gereken IDiscountStrategy
    implementasyonunu almasını sağlar.
 */
public static class CustomerDiscountStrategyFactory
{
    public static IDiscountStrategy GetDiscountStrategy(CustomerType customerType)
    {
        //var strategies = new Dictionary<CustomerType, IDiscountStrategy>()
        //{
        //    {CustomerType.Gold ,new GoldCustomerDiscountStrategy()},
        //    {CustomerType.Gold ,new BlueCustomerDiscountStrategy()},
        //    {CustomerType.Blue ,new BlueCustomerDiscountStrategy()},
        //};

        return customerType switch
        {
            CustomerType.Gold => new GoldCustomerDiscountStrategy(),
            CustomerType.Blue => new BlueCustomerDiscountStrategy(),
            _ => new DefaultDiscountStrategy(),
        };
    }
}
