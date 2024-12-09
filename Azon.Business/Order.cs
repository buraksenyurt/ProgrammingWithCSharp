namespace Azon.Business;

/*
    Order nesnesinin üretilmesinde Creational Design Pattern'lardan hangilerini kullanabiliriz.
    TODO@buraksenyurt Order sınıfı için bir örnek yapalım.
 */
public class Order
{
    public int Id { get; set; }
    public decimal Amount { get; set; }
    public CustomerType CustomerType { get; set; }
}