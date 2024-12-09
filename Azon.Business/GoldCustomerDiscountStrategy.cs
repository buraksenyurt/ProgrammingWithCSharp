namespace Azon.Business;

public class GoldCustomerDiscountStrategy
    : IDiscountStrategy
{
    public decimal Apply(decimal amount)
    {
        return amount * 0.9M;
    }

    //public decimal Apply(Order order)
    //{
    //    // OrderId için tabloya git bilgileri yükle
    //    // OrderId'ye ait Customer tipini yakala
    //    // CustomerTipi için tanımlı indirimleri almak üzere parametre tablosuna git
    //    // İndirimleri uygula

    //    return 0;
    //}
}
