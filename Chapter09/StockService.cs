namespace Chapter09;

/*
    StockService nesnesini kullanan object user'lara stok seviyesi değiştiğinde
    işleyebilecekleri bir metot sunmak istiyoruz. (Event Method)

    Event : Stok seviyesinin değişmesi

    Event kavramı, delegate tipi ile doğrudan ilişkilidir. Bir event'in tetiklenmesi (trigger)
    o event ile ilişkilendirilmiş bir metodun çalışma zamanında işletilmesidir. Çalışma zamanında bir metodu
    işaret etmek içinse delegate tipinden yararlanılır.

    Event temsilcileri genellikle geriye değer döndürmeyen, iki parametre alan metotları tanımlar.
    İlk parametre event'in sahibi olan nesnedir. İkinci parametre ise event ile ilgili ekstra bilgiler taşımak için kullanılır.
    Event temsilcileri isimlendirme standardı gereği EventHandler kelimeleri ile biter.
*/

internal delegate void StockLevelChangedEventHandler(object sender, StockLevelChangedEventArgs args);

// Olaylara ekstra bilgi taşımak istediğimizde isimlendirme standardı gereği sonu EventArgs ile biten bir sınıf kullanılır
internal class StockLevelChangedEventArgs
{
    public int OldLevel { get; set; }
    public int Change { get; set; }
}

internal class StockService
{
    /*
        StockLevelChanged isimli event, StockService için tanımlanmış bir olaydır. 
        Bu olay gerçekleştiğinde(ya da tetiklendiğinde), StockLevelChangedEventHandler delegate türü
        tarafından işaret edilebilen bir metod çağrılır.
    */
    // public event StockLevelChangedEventHandler StockLevelChanged;

    /*
        Genellikle EventArgs yapısı değişen event'ler söz konusu ise,
        .Net ile built-in gelen generic EventHandler<T> temsilcisi de kullanılabilir.
        Buna göre kendi delegate türlerimizi yazmaya gerek kalmadan da event'ler oluşturabiliriz.
     */
    public event EventHandler<StockLevelChangedEventArgs> StockLevelChanged;

    public string Owner { get; set; }

    private int _level;
    public int Level
    {
        get
        {
            return _level;
        }
        set
        {
            /*
                Aşağıdaki kullanımı ele alalım.
                Eğer StockService nesne örneğinin (object instance) kullanıldığı yerde,
                bu nesneye StockLevelChanged event'i bağlanmışsa (event binding)
                o event'in işaret ettiği fonksiyonu çağır.

                this keyword'ü, StockService sınıfının çalışma zamanındaki nesne örneğini işaret eder.
            */
            //if (StockLevelChanged != null)
            //{
            //    StockLevelChanged(this);
            //}
            var eventArgs = new StockLevelChangedEventArgs
            {
                OldLevel = value,
                Change = _level - value
            };

            _level = value;

            StockLevelChanged?.Invoke(this, eventArgs);
        }
    }
}
