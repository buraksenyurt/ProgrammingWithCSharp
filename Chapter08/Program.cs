using Azon.Games;

namespace Chapter08;

internal class Program
{
    static void Main()
    {
        var catalog = new Catalog();
        var games = catalog.LoadGames();

        Console.WriteLine("10 yaşında büyük oyunlar");

        // Aşağıdaki Search kullanımlarında dikkat edileceği üzere ikinci parametre bir fonksiyondur
        var resultSet = Scenario01.Search(games, IsOldThen10Age);
        resultSet = Scenario01.Search(games, IsStrategyGame);
        resultSet = Scenario01.Search(games, IsUnderrated);

        /*
            Aşağıdaki gibi, isimsiz metotlar(Anonymous Method) veya farklı dillerde Closure olarak da geçen
            kod bloklarını da parametre olarak geçebiliriz.
        */
        resultSet = Scenario01.Search(games, g => !g.OnSale);

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
