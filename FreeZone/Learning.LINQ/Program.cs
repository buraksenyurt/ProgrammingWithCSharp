using Azon.Games;

namespace Learning.LINQ;

internal class Program
{
    static void Main()
    {
        var catalog = new Catalog();
        var games = catalog.LoadGames();

        #region Extension Methods ile

        var strategyGames = GameQueries.GetGamesByCategory(games, "Strategy");
        var recentGames = GameQueries.GetGamesByReleaseYear(games, 2000);
        var highRatedGames = GameQueries.GetGamesByUserRate(games, 9.0);
        var saleGames = GameQueries.GetGamesOnSale(games);
        var midRangeGames = GameQueries.GetGamesByPriceRange(games, 20, 50);
        var topRatedGames = GameQueries.GetTopRatedGames(games);
        var groupedByYear = GameQueries.GetGamesGroupedByYear(games);
        var sortedGames = GameQueries.GetGamesSortedByName(games);
        var cheapestGames = GameQueries.GetTop5CheapestGames(games);
        var averageRatings = GameQueries.GetAverageRatingByCategory(games);

        #endregion

        #region LINQ Query Syntax ile

        var rpgGames = GameQueriesV2.GetGamesByCategory(games, "RPG");
        var recentGames2 = GameQueriesV2.GetGamesByReleaseYear(games, 2010);
        var highRatedGames2 = GameQueriesV2.GetGamesByUserRate(games, 9.5);
        var salesGames2 = GameQueriesV2.GetGamesOnSale(games);
        var midRangeGames2 = GameQueriesV2.GetGamesByPriceRange(games, 10, 50);
        var topRatedGames2 = GameQueriesV2.GetTopRatedGames(games);
        var groupedByYear2 = GameQueriesV2.GetGamesGroupedByYear(games);
        var sortedGames2 = GameQueriesV2.GetGamesSortedByName(games);
        var cheapestGames2 = GameQueriesV2.GetTop5CheapestGames(games);
        var averageRatings2 = GameQueriesV2.GetAverageRatingByCategory(games);


        #endregion

    }
}
