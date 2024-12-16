namespace Azon.Business.Test;

/*
    CatalogService' in ihtiyaç duyduğu IProductRepository yerine geçen bir Mock nesne sınıfı.
    Veritabanına bağlanıp bir ürün listesi çekmemizi sağlayan davranışı taklit eder.
    Böylece gerçek anlamda veritabanına erişmeden asıl test etmek istediğimiz fonksiyonellik için
    gerekli bileşeni tesis edebiliriz.

    Elbette her durumda bu şekilde soyutlamalara ait implementasyonları yapmamız şart değildir.
    Mock Framework'ler bu işleri oldukça kolaylaştırır.
 */
public class MockProductRepository
    : IProductRepository
{
    public IEnumerable<Product> GetProducts()
    {
        return new List<Product>
        {
            new Product{Id=1,Name="Ultravide geniş mi geniş LCD ekran",ListPrice=999.99M},
            new Product{Id=2,Name="Programming With C#",ListPrice=14.50M}
        };
    }
}
