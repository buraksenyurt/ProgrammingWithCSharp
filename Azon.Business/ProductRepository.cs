namespace Azon.Business;

public class ProductRepository
    : IProductRepository
{
    public IEnumerable<Product> GetProducts()
    {
        // Burada gerçekten bir veritabanına gidip Product listesinin çekildiğini var sayıyoruz
        return [];
    }
}
