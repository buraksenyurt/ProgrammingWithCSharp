using Azon.Games;

namespace Chapter08;

// Burada Game türünden parametre alan ve geriye bool değer döndüren metotları işaret edebilen bir temsilci tanımı yapılmıştır
public delegate bool PredicateDelegate(Game game);

public static class Scenario01
{
    /*
        Aşağıdaki fonksiyonlar bir oyun nesnesini alıp belli bir kritere uyup uymadığını bulan metotlardır.
        Hep Game türünden bir parametre alırlar ve sadece bool değer dönerler(Tümün ortak özellikleri)

        .Net tarafında metotların bellek adresleri delegate tipi(type) ile işaret edilebilir(Method Pointer)
        Buna göre bir metodu değişken gibi kullanmak, başka bir metoda parametre olarak geçmek mümkün hale gelir.

        Delegate tipi herhangibir metodu işaret edebilir. Senaryoya göre dönüş türü veya parametre yapısı organize edilir.
    */
    public static List<Game> Search(List<Game> games,PredicateDelegate predicate)
    {
        var result = new List<Game>();

        foreach (var game in games)
        {
            /*
                Search metoduna gelen Predicate temsilcisinin işaret ettiği metot kimse
                o metot foreach döngüsünün o anki game nesne örneği ile çalıştırılır.
                Predicate temsilcisi geriye bool değer döndüğünde kriter sağlanmışsa result'a eklenir
            */
            if (predicate(game))
            {
                result.Add(game);
            }
        }

        return result;
    }
}
