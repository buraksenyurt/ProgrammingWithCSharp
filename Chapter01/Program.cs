/*
    Uygulama sınıfımızın adı Program.
    Bir tipi başka bir tür içinde(Program sınıfı gibi) kullanırken dahil olduğu namespace bilgisini eklemek gerekebilir. 
*/
using Chapter01.Model;
// using System.Net;

internal class Program
{
    /*
        Executable binary'lerin (Console App, Windows App) ilk giriş noktası Main metodudur
        İsterse Main fonksiyonu terminalden ya da başka bir input kaynağında parametre alabilir (args değişkeni)
        args değişkeni n adet parametre alabilen bir string dizidir (Array)

        Main metodu genelde bir sonuç döndürmez(istisnai durumlar vardır. Eğer program çıktısı başka bir program veya OS için önemlisi)

        Bir metot geriye birşey döndürmeyecekse void olarak tanımlanır.

        Main metodu varsayılan olarak private erişim belirleyicisine sahiptir. Yani sadee Program sınıfı içinde kullanılabilir.
        ve aynı zamanda statik bir metoddur(statik metotlar tanımlandıkları nesnenin örneğine ihtiyaç olmadan kullanılabilirler)
        Örneğin Console sınıfının WriteLine metodu statik bir fonksiyondur.

        Sınıflar(Program sınıfı gibi) metotlar(static, constructor, destructor vs), alanlar(fields), özellikler(properties) veya başka türleri de içerebilir.
    */
    private static void Main(string[] args)
    {
        Console.Beep();
        Console.WriteLine("Hello, World!"); // WriteLine ve Beep, Console sınıfının statik metotlarıdır. Nesne örneğine ihtiyaç duymayan metotalar.

        string fullName = "Burak Selim Şenyurt";
        string repoAddress = "https://github.com/buraksenyurt/ProgrammingWithCSharp";
        // var keyword ile tanımlanan değişkenler, eşitliğin sağ tarafına bakıp uygun veri türünü alırlar.
        // var, eşitliğin sağ tarafı farklı türlere denk geliyorsa varsayılan olanı kullanır
        var blogAddress = "buraksenyurt.com";
        // Aynı scope içerisinde { } aynı isimde değişkenler tanımlanamaz.
        var age = 47;
        short level = 101;
        byte redValue = 210;
        bool isOnline = true;
        char flag = 'A';

        double pi = 3.14;
        decimal productPrice = 999.45M;
        float e = 2.22F;

        /*
            .Net platformunda CTS(Common Type System) üzerinden gelen built-in türler dışında,
            kendi türlerimizi de tasarlayabiliriz. Bunun için class, struct, enum gibi blokları kullanırız.
         */
        Car duldul = new Car();
        duldul.Name = "Dül Dülüm";
        duldul.Year = 1976;
        duldul.Model = "Murat 124 AC SLX";
        // duldul.Color = "Pamuk helva şekeri rengi";
        duldul.Color = ProductColor.Black;
        // #FFCC00 (Hexadecimal renk kodu)

        // Aşağıdaki IP adresini string olarak değil de daha kullanışlı olması için bir struct olarak tasarlayalım.
        // string localIpAddress = "127.0.0.1";

        // IPAddress (Built-In gelen bu sınıfın içeriğini inceleyelim)

        var printerAddress = new IpInfo
        {
            Part1 = 192,
            Part2 = 168,
            Part3 = 1,
            Part4 = 1
        };
        Console.WriteLine("{0}.{1}.{2}.{3}", printerAddress.Part1, printerAddress.Part2, printerAddress.Part3, printerAddress.Part4);
    }
}