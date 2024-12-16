namespace Azon.Business.Test;

public class CatalogServiceTests
{   
    [Fact]
    public void GetTotalPrice_Should_Return_Sum_Of_Product_Prices()
    {
        /*
            CatalogService bileşeninin kullandığı ProductRepository bileşeni normal şartlarda
            veritabanına gidiyor olsun? 
            
            Unit Test projelerinin çalıştığı ortamlar genellikle veritabanı, dış servisler, fiziki
            diskler veya ftp gibi alanlara erişmez/erişilmezi istenmez. Bu gibi durumlarda şu soru
            ortaya çıkar;

            Veritabanına erişemeyen bir test projesinde veritabanı bağımlılığı olan bir component'in
            dahil olduğu business fonksiyon nasıl test edilir?
         */
        // Arange
        // var productRepository=new ProductRepository();
        var mockProductRepository=new MockProductRepository();
        var catalogService = new CatalogService(mockProductRepository);

        // Act
        var actual = catalogService.GetTotalPrice();

        // Assert
        Assert.Equal(1014.49M, actual);
    }
}
