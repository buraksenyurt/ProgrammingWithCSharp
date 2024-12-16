using Azon.Games;

namespace Learning.LINQ;

public static class GameQueriesV2
{
    public static List<Game> GetGamesByCategory(List<Game> games, string categoryName)
    {
        var query = from game in games
                    where game.Category.Name.Contains(categoryName, StringComparison.OrdinalIgnoreCase)
                    select game;

        return query.ToList();
    }

    public static List<Game> GetGamesByReleaseYear(List<Game> games, int year)
    {
        var query = from game in games
                    where game.ReleaseYear >= year
                    select game;

        return query.ToList();
    }

    public static List<Game> GetGamesByUserRate(List<Game> games, double minRate)
    {
        var query = from game in games
                    where game.UserRate > minRate
                    select game;

        return query.ToList();
    }

    public static List<Game> GetGamesOnSale(List<Game> games)
    {
        var query = from game in games
                    where game.OnSale
                    select game;

        return query.ToList();
    }

    public static List<Game> GetGamesByPriceRange(List<Game> games, double minPrice, double maxPrice)
    {
        var query = from game in games
                    where game.ListPrice >= minPrice && game.ListPrice <= maxPrice
                    select game;

        return query.ToList();
    }

    public static List<Game> GetTopRatedGames(List<Game> games)
    {
        var maxRate = (from game in games
                       select game.UserRate).Max();

        var query = from game in games
                    where game.UserRate == maxRate
                    select game;

        return query.ToList();
    }

    public static Dictionary<short, List<Game>> GetGamesGroupedByYear(List<Game> games)
    {
        var query = from game in games
                    group game by game.ReleaseYear into yearGroup
                    select yearGroup;

        return query.ToDictionary(group => group.Key, group => group.ToList());
    }

    public static List<Game> GetGamesSortedByName(List<Game> games)
    {
        var query = from game in games
                    orderby game.Name
                    select game;

        return query.ToList();
    }

    public static List<Game> GetTop5CheapestGames(List<Game> games)
    {
        var query = (from game in games
                     orderby game.ListPrice
                     select game).Take(5);

        return query.ToList();
    }

    public static Dictionary<string, double> GetAverageRatingByCategory(List<Game> games)
    {
        var query = from game in games
                    group game by game.Category.Name into categoryGroup
                    select new
                    {
                        Category = categoryGroup.Key,
                        AverageRating = categoryGroup.Average(game => game.UserRate)
                    };

        return query.ToDictionary(result => result.Category, result => result.AverageRating);
    }
}
