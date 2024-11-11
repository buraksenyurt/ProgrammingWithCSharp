using Y00;

internal class Program
{
    private static void Main()
    {
        var novelCategory = new Category
        {
            Id = 1,
            Name = "Novel"
        };
        var fermatsBook = new Book
        {
            Title = "Fermat'nın Son Teoremi",
            Summary = "Fermat'nın ünlü probleminin çözümüne tarihi bir bakış",
            Category = novelCategory,
            ListPrice = 9.99M,
            Topics = [
                new Topic{Name="Tarih"},
                new Topic{Name="Matematik"},
                new Topic{Name="Herkes Okuyabilir"},
                new Topic{Name="Gizem Uyandıran"}
            ]
        };

        Console.WriteLine("{0} - {1}({2})", fermatsBook.Id, fermatsBook.Title, fermatsBook.ListPrice);
        foreach (var topic in fermatsBook.Topics)
        {
            Console.Write("{0},", topic.Name);
        }
        Console.WriteLine();
    }
}