namespace Learning.Delegates;

/*
    Delegate tipi ile metotları işaret edebiliriz. Bu metotları parametre olarak başla metotlara
    taşıyabilmebizi, zincir metot dizilimleri oluşturabilmemizi, belli durumlarda çalışma zamanında
    event tetiklenmesini sağlar. LINQ sorgularında kullanılan birçok genişletme metodu(extension method)
    Func, Predicate vb delegate türlerini kullanır.

    Bu projede örnek delegate kullanımlarına yer verilmiştir.
 */
internal class Program
{
    static void Main(string[] args)
    {
        BasicSample.Run();
        MulticastSample.Run();
        EventSample.Run();
    }
}
