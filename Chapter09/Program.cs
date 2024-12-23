namespace Chapter09;

internal class Program
{
    static void Main()
    {
        /*
            StockService nesne örneğine(stockService), StockLevelChanged isimli event yüklenir.
            Bu += operatörü ile yapılabilir.
            Bu event gerçekleştiğinde StockService_StockLevelChanged isimli metot çağrılacaktır.            
        */
        var stockServiceLondon = new StockService
        {
            Owner = "London"
        };
        var stockServiceNewYork = new StockService
        {
            Owner = "New York"
        };
        /*
            İstersek birden fazla nesneyi aynı event method'a yönlendirebiliriz.
            Aşağıdaki örnekte stockServiceLondon ve stockServiceNewyork nesne örneklerinin
            aynı StockLevelChanged event metoduna bağlandığını görebiliriz.
            Event method'un ilk parametresi (object sender) ile de olayın sahibi olan nesneyi anlayabiliriz?
         */
        stockServiceLondon.StockLevelChanged += StockService_StockLevelChanged;
        stockServiceNewYork.StockLevelChanged += StockService_StockLevelChanged;
        stockServiceLondon.Level = 90; // Burada event tetiklenir.
        stockServiceLondon.Level -= 5;
        stockServiceNewYork.Level = 45;


        Console.WriteLine("Program sonu");
    }

    // Event Method
    private static void StockService_StockLevelChanged(object? sender, StockLevelChangedEventArgs args)
    {
        /*
            Bu event metoda stok seviyesi değişmeden önceki stok seviyesi ile değiştikten sonraki stok seviyesi
            bilgilerini taşımak istiyorum. Nasıl taşırsınız? 
        
            Bunun için StockLevelChangedEventArgs isimli sınıfı kullanıyoruz.

            Aşağıdaki gibi event'i tetikleyen nesne örneğinin cast ederek yakalayabiliriz.
        */
        if (sender is StockService eventOwner)
        {
            Console.WriteLine($"{eventOwner.Owner}. Stok seviyesinin eski değeri {args.OldLevel}. Değişim {args.Change}");
        }
        else
        {
            Console.WriteLine($"Stok seviyesinin eski değeri {args.OldLevel}. Değişim {args.Change}");
        }
    }
}


