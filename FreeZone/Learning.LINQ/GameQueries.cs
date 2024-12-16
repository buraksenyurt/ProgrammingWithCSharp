using Azon.Games;

namespace Learning.LINQ;

public static class GameQueries
{
    public static List<Game> GetGamesByCategory(List<Game> games, string categoryName)
    {
        return games.Where(game => game.Category.Name.Contains(categoryName, StringComparison.OrdinalIgnoreCase)).ToList();
    }

    public static List<Game> GetGamesByReleaseYear(List<Game> games, int year)
    {
        return games.Where(game => game.ReleaseYear >= year).ToList();
    }

    public static List<Game> GetGamesByUserRate(List<Game> games, double minRate)
    {
        return games.Where(game => game.UserRate > minRate).ToList();
    }

    public static List<Game> GetGamesOnSale(List<Game> games)
    {
        return games.Where(game => game.OnSale).ToList();
    }

    public static List<Game> GetGamesByPriceRange(List<Game> games, double minPrice, double maxPrice)
    {
        return games.Where(game => game.ListPrice >= minPrice && game.ListPrice <= maxPrice).ToList();
    }

    public static List<Game> GetTopRatedGames(List<Game> games)
    {
        double maxRate = games.Max(game => game.UserRate);
        return games.Where(game => game.UserRate == maxRate).ToList();
    }

    public static Dictionary<short, List<Game>> GetGamesGroupedByYear(List<Game> games)
    {
        return games.GroupBy(game => game.ReleaseYear)
                    .ToDictionary(group => group.Key, group => group.ToList());
    }

    public static List<Game> GetGamesSortedByName(List<Game> games)
    {
        return games.OrderBy(game => game.Name).ToList();
    }

    public static List<Game> GetTop5CheapestGames(List<Game> games)
    {
        return games.OrderBy(game => game.ListPrice).Take(5).ToList();
    }

    public static Dictionary<string, double> GetAverageRatingByCategory(List<Game> games)
    {
        return games.GroupBy(game => game.Category.Name)
                    .ToDictionary(group => group.Key, group => group.Average(game => game.UserRate));
    }
}
