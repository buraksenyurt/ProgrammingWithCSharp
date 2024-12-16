namespace Azon.Business.Test;

/*
    Basit bir sipariş yönetim(OrderingService) bileşeni(servisi) düşünelim.
    Bu servis müşterinin tipine(CustomerType) göre sipariş üzerinde belli oradan indirim(Discount) uyguluyor.
    Bu fonksiyonellikle ilişkili birim testleri uygulamak istiyoruz.

    Müşteri türü Gold ise %10 indirim uygulanır.
    Müşteri türü Blue ise %5 indirim uygulanır.
    Diğer müşteri türlerinde bir indirim uygulanmaz.
    Sonradan sisteme başka müşteri türleri de eklenebilir.
    Sipariş tutarı belli bir değerin altında olanlar için hiçbir indirim uygulanmaz gibi.

    Aşağıdaki kodu TDD'nin, Red Green Blue prensibine göre yazıyoruz.

    Red (Fail), Önce fail etsin.
    Green (Success), Sonra çalışır ve doğru sonucu döndürür hale gelsin.
    Blue (Refactor), Kod iyileştirilsin
 */
public class OrderingTests
{
    /*
         Fact aslında bir Attribute tipidir. Attribute tipleri, runtime'a ekstra bilgi
         sağlamak için kullanılır(Metadata Programming kapsamında da düşünülebilir) 
         Örneğin aşağıdaki metotların VS IDE' sindeki Test Explorer çıkıyor olması
         Fact attribute ile işaretlenmelerine bağlıdır.     
    */
    [Fact]
    public void CalculateTotal_ShouldNotApplyDiscount_ForNullOrder()
    {
        // Arange
        Order order = null;
        var orderService = new OrderingService();

        // Act
        var result = orderService.CalculateTotal(order);

        // Assert
        Assert.False(result.IsSuccess);
        Assert.Equal("Invalid Order", result.ErrorMessage);
    }

    [Fact]
    public void CalculateTotal_ShouldApplyDiscount_ForGoldCustomer()
    {
        // Arange
        var order = new Order
        {
            Id = 1001,
            Amount = 99.99M,
            CustomerType = CustomerType.Gold
        };

        var orderService = new OrderingService();

        // Act
        var result = orderService.CalculateTotal(order);

        // Assert
        Assert.True(result.IsSuccess);
        Assert.Equal(89.991M, result.Value);
    }

    [Fact]
    public void CalculateTotal_ShouldApplyDiscount_ForBlueCustomer()
    {
        // Arange
        var order = new Order
        {
            Id = 1001,
            Amount = 99.99M,
            CustomerType = CustomerType.Blue
        };

        var orderService = new OrderingService();

        // Act
        var result = orderService.CalculateTotal(order);

        // Assert
        Assert.True(result.IsSuccess);
        Assert.Equal(94.9905M, result.Value);
    }

    [Fact]
    public void CalculateTotal_ShouldNotApply_ForStandardCustomerType()
    {
        // Arange
        var order = new Order
        {
            Id = 1002,
            Amount = 100M,
            CustomerType = CustomerType.Standard
        };

        var orderService = new OrderingService();

        // Act
        var result = orderService.CalculateTotal(order);

        // Assert
        Assert.Equal(order.Amount, result.Value);
    }

}