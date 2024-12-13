namespace Azon.Games;

public class Catalog
{
    private readonly List<Game> _games = [];

    public List<Game> LoadGames()
    {
        var categories = new List<Category>
        {
            new() { Id = 1, Name = "Strategy Games" },
            new() { Id = 2, Name = "Simulation" },
            new() { Id = 3, Name = "Arcade" },
            new() { Id = 4, Name = "RPG" },
            new() { Id = 5, Name = "Shooter" }
        };

        var predefinedGames = new List<Game>
        {
            new() { Id = 1, Name = "Pac-Man", ReleaseYear = 1980, OnSale = false, UserRate = 9.5, Category = categories[2], ListPrice = 19.99 },
            new() { Id = 2, Name = "Tetris", ReleaseYear = 1984, OnSale = true, UserRate = 9.2, Category = categories[2], ListPrice = 14.99 },
            new() { Id = 3, Name = "The Legend of Zelda", ReleaseYear = 1986, OnSale = false, UserRate = 9.8, Category = categories[3], ListPrice = 39.99 },
            new() { Id = 4, Name = "SimCity", ReleaseYear = 1989, OnSale = true, UserRate = 8.7, Category = categories[1], ListPrice = 29.99 },
            new() { Id = 5, Name = "Street Fighter II", ReleaseYear = 1991, OnSale = true, UserRate = 9.3, Category = categories[4], ListPrice = 24.99 },
            new() { Id = 6, Name = "Doom", ReleaseYear = 1993, OnSale = false, UserRate = 9.6, Category = categories[4], ListPrice = 49.99 },
            new() { Id = 7, Name = "Warcraft: Orcs & Humans", ReleaseYear = 1994, OnSale = false, UserRate = 9.1, Category = categories[0], ListPrice = 34.99 },
            new() { Id = 8, Name = "Command & Conquer", ReleaseYear = 1995, OnSale = true, UserRate = 7.9, Category = categories[0], ListPrice = 39.99 },
            new() { Id = 9, Name = "Quake", ReleaseYear = 1996, OnSale = true, UserRate = 9.4, Category = categories[4], ListPrice = 44.99 },
            new() { Id = 10, Name = "The Sims", ReleaseYear = 2000, OnSale = false, UserRate = 8.8, Category = categories[1], ListPrice = 49.99 },
            new() { Id = 11, Name = "Grand Theft Auto III", ReleaseYear = 2001, OnSale = true, UserRate = 9.0, Category = categories[4], ListPrice = 39.99 },
            new() { Id = 12, Name = "Halo: Combat Evolved", ReleaseYear = 2001, OnSale = false, UserRate = 9.7, Category = categories[4], ListPrice = 59.99 },
            new() { Id = 13, Name = "World of Warcraft", ReleaseYear = 2004, OnSale = true, UserRate = 9.5, Category = categories[0], ListPrice = 49.99 },
            new() { Id = 14, Name = "Minecraft", ReleaseYear = 2011, OnSale = false, UserRate = 9.4, Category = categories[1], ListPrice = 26.95 },
            new() { Id = 15, Name = "Fortnite", ReleaseYear = 2017, OnSale = true, UserRate = 8.5, Category = categories[4], ListPrice = 0.00 },
            new() { Id = 16, Name = "Space Invaders", ReleaseYear = 1980, OnSale = false, UserRate = 9.1, Category = categories[2], ListPrice = 19.99 },
            new() { Id = 17, Name = "Prince of Persia", ReleaseYear = 1989, OnSale = true, UserRate = 8.9, Category = categories[3], ListPrice = 29.99 },
            new() { Id = 18, Name = "SimEarth", ReleaseYear = 1990, OnSale = true, UserRate = 8.4, Category = categories[1], ListPrice = 24.99 },
            new() { Id = 19, Name = "Diablo", ReleaseYear = 1996, OnSale = false, UserRate = 9.7, Category = categories[3], ListPrice = 39.99 },
            new() { Id = 20, Name = "Age of Empires", ReleaseYear = 1997, OnSale = true, UserRate = 9.0, Category = categories[0], ListPrice = 34.99 },
            new() { Id = 21, Name = "Half-Life", ReleaseYear = 1998, OnSale = false, UserRate = 9.6, Category = categories[4], ListPrice = 49.99 },
            new() { Id = 22, Name = "Starcraft", ReleaseYear = 1998, OnSale = true, UserRate = 9.5, Category = categories[0], ListPrice = 39.99 },
            new() { Id = 23, Name = "Baldur's Gate", ReleaseYear = 1998, OnSale = true, UserRate = 9.2, Category = categories[3], ListPrice = 39.99 },
            new() { Id = 24, Name = "System Shock 2", ReleaseYear = 1999, OnSale = false, UserRate = 9.3, Category = categories[4], ListPrice = 44.99 },
            new() { Id = 25, Name = "Counter-Strike", ReleaseYear = 2000, OnSale = true, UserRate = 9.4, Category = categories[4], ListPrice = 29.99 },
            new() { Id = 26, Name = "Max Payne", ReleaseYear = 2001, OnSale = false, UserRate = 9.0, Category = categories[4], ListPrice = 49.99 },
            new() { Id = 27, Name = "The Elder Scrolls III: Morrowind", ReleaseYear = 2002, OnSale = true, UserRate = 9.1, Category = categories[3], ListPrice = 34.99 },
            new() { Id = 28, Name = "The Sims 2", ReleaseYear = 2004, OnSale = true, UserRate = 9.0, Category = categories[1], ListPrice = 49.99 },
            new() { Id = 29, Name = "Guitar Hero", ReleaseYear = 2005, OnSale = true, UserRate = 8.9, Category = categories[2], ListPrice = 59.99 },
            new() { Id = 30, Name = "Call of Duty 4: Modern Warfare", ReleaseYear = 2007, OnSale = false, UserRate = 9.3, Category = categories[4], ListPrice = 59.99 },
            new() { Id = 31, Name = "Portal", ReleaseYear = 2007, OnSale = false, UserRate = 9.7, Category = categories[4], ListPrice = 29.99 },
            new() { Id = 32, Name = "Assassin's Creed", ReleaseYear = 2007, OnSale = true, UserRate = 8.8, Category = categories[4], ListPrice = 49.99 },
            new() { Id = 33, Name = "BioShock", ReleaseYear = 2007, OnSale = false, UserRate = 9.6, Category = categories[4], ListPrice = 39.99 },
            new() { Id = 34, Name = "Left 4 Dead", ReleaseYear = 2008, OnSale = true, UserRate = 9.0, Category = categories[4], ListPrice = 29.99 },
            new() { Id = 35, Name = "The Elder Scrolls V: Skyrim", ReleaseYear = 2011, OnSale = true, UserRate = 9.5, Category = categories[3], ListPrice = 59.99 },
            new() { Id = 36, Name = "Dark Souls", ReleaseYear = 2011, OnSale = false, UserRate = 9.4, Category = categories[3], ListPrice = 39.99 },
            new() { Id = 37, Name = "Diablo III", ReleaseYear = 2012, OnSale = true, UserRate = 8.9, Category = categories[3], ListPrice = 59.99 },
            new() { Id = 38, Name = "The Last of Us", ReleaseYear = 2013, OnSale = false, UserRate = 9.8, Category = categories[3], ListPrice = 49.99 },
            new() { Id = 39, Name = "Grand Theft Auto V", ReleaseYear = 2013, OnSale = true, UserRate = 9.7, Category = categories[4], ListPrice = 59.99 },
            new() { Id = 40, Name = "Overwatch", ReleaseYear = 2016, OnSale = true, UserRate = 9.3, Category = categories[4], ListPrice = 39.99 },
            new() { Id = 41, Name = "PlayerUnknown's Battlegrounds", ReleaseYear = 2017, OnSale = false, UserRate = 8.4, Category = categories[4], ListPrice = 29.99 },
            new() { Id = 42, Name = "Red Dead Redemption 2", ReleaseYear = 2018, OnSale = false, UserRate = 9.5, Category = categories[3], ListPrice = 59.99 },
            new() { Id = 43, Name = "The Witcher 3: Wild Hunt", ReleaseYear = 2015, OnSale = true, UserRate = 9.6, Category = categories[3], ListPrice = 49.99 },
            new() { Id = 44, Name = "Cyberpunk 2077", ReleaseYear = 2020, OnSale = true, UserRate = 7.8, Category = categories[3], ListPrice = 59.99 },
            new() { Id = 45, Name = "Among Us", ReleaseYear = 2018, OnSale = false, UserRate = 8.1, Category = categories[2], ListPrice = 4.99 },
            new() { Id = 46, Name = "Fall Guys", ReleaseYear = 2020, OnSale = true, UserRate = 8.2, Category = categories[2], ListPrice = 19.99 },
            new() { Id = 47, Name = "Hades", ReleaseYear = 2020, OnSale = false, UserRate = 7.5, Category = categories[3], ListPrice = 24.99 },
            new() { Id = 48, Name = "Valorant", ReleaseYear = 2020, OnSale = true, UserRate = 6.6, Category = categories[4], ListPrice = 0.00 },
            new() { Id = 49, Name = "Elden Ring", ReleaseYear = 2022, OnSale = false, UserRate = 9.7, Category = categories[3], ListPrice = 59.99 },
            new() { Id = 50, Name = "God of War Ragnarok", ReleaseYear = 2022, OnSale = true, UserRate = 9.8, Category = categories[3], ListPrice = 69.99 },
        };

        _games.AddRange(predefinedGames);

        return _games;
    }
}
