namespace Azon.Games;

public class Game
{
    public int Id { get; set; }
    public string Name { get; set; }
    public short ReleaseYear { get; set; }
    public bool OnSale { get; set; }
    public double UserRate { get; set; }
    public Category Category { get; set; }
    public double ListPrice { get; set; }
}

