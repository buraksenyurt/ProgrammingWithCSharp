namespace Azon.Business;

public interface IProductRepository
{
    IEnumerable<Product> GetProducts();
}
