namespace Learning.Generics;

internal class Program
{
    static void Main()
    {
        var gameRepository = new InMemoryRepository<Game>();

        gameRepository.Add(new Game { Id = 1, Name = "Bulders Gate" });
        gameRepository.Add(new Game { Id = 2, Name = "Hades II" });
        gameRepository.Add(new Game { Id = 3, Name = "Super Mario" });

        foreach (var game in gameRepository.GetAll())
        {
            Console.WriteLine($"{game.Id} - {game.Name}");
        }

        var catalogRepository = new InMemoryRepository<Product>();

        catalogRepository.Add(new Product { Id = 1, Title = "Blue Ray Player", ListPrice = 10 });
        catalogRepository.Add(new Product { Id = 2, Title = "Wireless Kulaklık", ListPrice = 8 });

        foreach (var product in catalogRepository.GetAll())
        {
            Console.WriteLine($"{product.Title} ({product.ListPrice} Coin)");
        }
    }
}

class Game
{
    public int Id { get; set; }
    public string Name { get; set; }
}

class Product
{
    public int Id { get; set; }
    public string Title { get; set; }
    public decimal ListPrice { get; set; }
}