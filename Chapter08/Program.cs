using Azon.Games;

namespace Chapter08;

internal class Program
{
    static void Main()
    {
        var catalog = new Catalog();
        var games = catalog.LoadGames();

        Console.WriteLine("10 yaşından büyük oyunlar");

        // Aşağıdaki Search kullanımlarında dikkat edileceği üzere ikinci parametre bir fonksiyondur
        var resultSet = Scenario01.Search(games, IsOldThen10Age);
        resultSet = Scenario01.Search(games, IsStrategyGame);
        resultSet = Scenario01.Search(games, IsUnderrated);

        /*
            Aşağıdaki gibi, isimsiz metotlar(Anonymous Method) veya farklı dillerde Closure olarak da geçen
            kod bloklarını da parametre olarak geçebiliriz.
        */
        resultSet = Scenario01.Search(games, g => !g.OnSale);

        /*
            Koleksiyon türlerine eklenmiş farklı türden delegate tipleri kullanan metotlar vardır.
            Örneğin List<T> türünün FindAll metodu, Predicate temsilcisini kullanır.
            
            public delegate bool Predicate<in T>(T obj);

            Bu generic bir tanımlamadır dolayısıyla herhangibir nesne türünü parametre olarak alan
            ve geriye bool döndüren metotlar ifade edilebilir.
            Aşağıda lambda operatörü (=>) ile bool değer dönen bir ifade FindAll metoduna parametre olarak geçilir.
         */
        resultSet = games.FindAll(g => g.ListPrice > 30);

        /*
            Delegate tipinin yoğun olarak kullanıldığı bir diğer yerde LINQ ifadeleridir.
        
            LINQ = Language INtegrated Query

            Where, OrderBy, Select gibi genişletme metotları(Extension Methods) vardır. Bunlar genellikle Func<T,TResult> türünden
            temsilci(delegate) tipleri ile çalışır.
            Select metodunun kullanımında dikkat edilmesi gereken noktalardan birisi Id, Title ve UserRate dönen bir nesne tanımlandığıdır.
            Bu anonymous type(isimsiz tip) olarak geçer. Zira herhangi bir yerde bu tür için bir sınıf veya struct tanımı yapılmamıştır.
            Buradaki isimsiz tip kullanımı Projection olarak da geçer.
        */
        var queryResult = games
            .Where(g => g.Name.ToLower().StartsWith("w"))
            .OrderBy(g => g.UserRate)
            .Select(g => new
            {
                g.Id,
                Title = g.Name,
                g.UserRate
            })
            .ToList();
        foreach (var item in queryResult)
        {
            Console.WriteLine(item);
        }

        /*
            Yukarıdaki genişletme metotlarının yerine aşağıdaki gibi SQL sorgularına benzer 
            şekilde syntax' da mümkündür.

            Burada genel amaça programatik ortamda SQL tarzı sorguların yazılabilmesini sağlamaktır.
            LINQ, özellikle O/RM (Object Relational Mapping) konusu için getirilmiştir.
            Amaç database tarafındaki tablolar üzerinde yazılan sorguların karşılığı olan entity nesnelerine ait koleksiyonlarda da
            benzer şekilde yazılabilmesinin sağlanmasıdır.

            SELECT * FROM Games WHERE ReleaseYear > 1990 AND ReleaseYear < 2000 Order By UserRate DESC
         */
        var queryResult2 = from g in games
                           where g.ReleaseYear > 1990 && g.ReleaseYear < 2000
                           orderby g.UserRate descending
                           select g;
        foreach (var item in queryResult2)
        {
            Console.WriteLine($"{item.Name}, ({item.UserRate})");
        }

        // Category bazlı oyunların ortalama UserRate değeri ?

        /*
         Örnek Extension method kullanımı
        */
        string motto = "Ne kadar güzel bir gün değil mi?";
        Console.WriteLine(motto.WriteSmart('_'));
        Console.WriteLine(motto.WriteSmart('*'));

    }
    static bool IsOldThen10Age(Game game)
    {
        return DateTime.Now.Year - game.ReleaseYear > 10;
    }
    static bool IsStrategyGame(Game game)
    {
        return game.Category.Name.ToLower().Contains("strategy");
    }
    static bool IsUnderrated(Game game)
    {
        return game.UserRate < 6;
    }
}
