namespace Azon.WeatherLib
{
    /*
        Bir sınıf kütüphanesi içerisinde anlamsal bütünlüğü bozmadan istediğimiz kadar tip ve tip üyesi ekleyebiliriz.
        Aşağıdaki sınıfın şehir bazı sıcaklık değerlerini tutan bir yapıda olduğunu varsayalım.
        İçinde şehir ve sıcaklık değerlerini taşıyacak bir kaba sahip olabilir.
        Bu bir array olabilir ya da key:value gibi çalışacak bir Dictionary veri yapısı olabilir veya kolayca genişleyebilen bir koleksiyon.
        Bir başka deyişle List, Dictionary, Array gibi veri modelleri birden fazla şehir,sıcaklık bilgisi için tasarlanabilir.
     */
    public class Reporter
    {
        // private City[] cities = new City[10];
        // İçerisinde City türünden elemanlar barındıracak bir List koleksiyonu.
        private List<City> cityList = [];
        
        public void AddCity(City city)
        {
            cityList.Add(city);
        }
        public City GetCity(string cityName)
        {
            // GetCity metodu kullanılmak istendiğinde çalışma zamanın NotImplementedException fırlatılır(throw)
            // Exception nesneler try...catch blokları ile yakalanmazlarsa program crash olur
            // Biz burada "Henüz bu metot tamamlanmadı" manasında kullanmak istedik.
            throw new NotImplementedException();
        }
        public List<City> GetCityList()
        {
            return cityList;
        }
        public Temperature GetTemperature(string cityName)
        {
            /*
             Yeni eklenmeiş ama henüz içeriği yazılmamış metotlar söz konusu olduğunda,
            diğer programcıların veya object user'ların bu durumdan haberdar olması adına da
            NotImplementeException kullanılabilir.

            throw ile çalışma zamanına (runtime) bir Exception nesnesi fırlatılabilir.
            new ile başlayan kısım Exception nesne örneğidir.
            Bu exception nesneleri bir try...catch mekanizması ile yakalanarak kontrol altına alınabilir.
             */
            throw new NotImplementedException();
        }

        // Tüm kayıtlı şehirlerdeki anlık sıcaklık bilgilerini string formatta döndüren bir metot
        public string GetSummary()
        {
            throw new NotImplementedException();
        }
    }
}
