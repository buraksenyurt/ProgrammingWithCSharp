using Azon.Games;

namespace Chapter08;

public static class Scenario00
{
    /*
        games isimli Game türünden olan listede çeşitli aramalar yapmak istediğimizde
        ilk akla gelen yollardan birisi aşağıdaki gibi for döngülerini kullanmaktır.
        Ancak hemen hepsi sadece koşul dışında aynı şekilde yazılır.
        
        Tek bir for döngüsü ile herhangibir karşılaştırma kriterini ele alan bir metot yazılabilir mi?
    */
    public static void Run(List<Game> games)
    {
        // Şu anda satışa olmayan oyunların listesi
        Console.WriteLine("Satışta olmayan oyunlar");
        foreach (var game in games)
        {
            if (!game.OnSale)
            {
                Console.WriteLine($"{game.Name}");
            }
        }

        Console.WriteLine("\nStrateji Kategorisindeki Oyunlar");
        foreach (var game in games)
        {
            if (game.Category.Name.ToLower().Contains("strategy"))
            {
                Console.WriteLine($"{game.Name} ({game.UserRate})");
            }
        }

        // 10 yıldan yaşlı oyunlar
        Console.WriteLine("\nOn yıldan yaşlı olan oyunlar");
        foreach (var game in games)
        {
            if (DateTime.Now.Year - game.ReleaseYear > 10)
            {
                Console.WriteLine($"{game.Name} ({game.UserRate}), {game.ReleaseYear}");
            }
        }
    }
}
