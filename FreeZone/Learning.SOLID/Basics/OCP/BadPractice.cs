namespace Learning.SOLID.Basics.OCP;

/*
    Tipe göre indirim oranını hesaplayan aşağıdaki sınıfa yeni bir tip dahil etmek istersek
    kodunu değiştirmemiz gerekir. 
 */
public class DiscountManager
{
    public double Calculate(double amount, string type)
    {
        if (type == "Employee")
        {
            return amount * 0.3;
        }
        if (type == "Student")
        {
            return amount * 0.7;
        }
        return amount;
    }
}
