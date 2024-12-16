using Moq;

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
        var mockProductRepository = new MockProductRepository();
        var catalogService = new CatalogService(mockProductRepository);

        // Act
        var actual = catalogService.GetTotalPrice();

        // Assert
        Assert.Equal(1014.49M, actual);
    }
    [Fact]
    public void GetTotalPrice_Should_Return_Valid_Total()
    {
        /*
            Bu örnekte Mock Framework olarak Moq isimli Nuget paketini kullanıyoruz.
            Manage Nuget Pacakges ile eklenebilir.
            dotnet komut satırı aracı ile de yüklenebilir.
            Proje dosyasına elle eklenerek de yüklenebilir.
        */

        // Arange

        // IProductRepository için bir Mock nesne kullanmak istediğimizi aşağıdaki ifade eile belirtiyoruz
        var mockRepository = new Mock<IProductRepository>();
        var products = new List<Product>()
        {
            new() {Id=1,Name="Ultravide geniş mi geniş LCD ekran",ListPrice=1000M},
            new() {Id=2,Name="Programming With C#",ListPrice=15M}
        };
        /*
            Setup ile hangi metodu çağıracağımızı ve Returns ile de bu metot çağrıldığında
            geriye ne döneceğini belirtiyoruz
        */
        mockRepository
            .Setup(f => f.GetProducts())
            .Returns(products);

        // Act
        var service = new CatalogService(mockRepository.Object);
        var actual = service.GetTotalPrice();

        // Assert
        Assert.Equal(1015, actual);
    }
}