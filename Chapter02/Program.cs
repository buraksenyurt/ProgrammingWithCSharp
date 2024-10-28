using Azon.WeatherLib;
using Chapter02.UI.View;

namespace Chapter02
{
    internal class Program
    {
        static void Main()
        {
            /*
                Temperature veri yapısı Azon.WeatherLib kütüphanesi içinde yer almaktadır.
                Temperature sınıfı object instance formasyonunda kullanılır. Yani önce new ile bir örnek oluşturulur.
                Sonra bu örneğin erişilebilir olan üyeleri(metotlar gibi) kullanılır.
             */
            //var currentWeatherValue = new Temperature(21, TemperatureType.Celcius);
            //Console.WriteLine(currentWeatherValue);
            //currentWeatherValue.ConvertToFahrenheit();
            //Console.WriteLine(currentWeatherValue);

            //Terminal.SplashScreen("Super Mario");
            //Terminal.ShowMenu();
            //Terminal.GetUserInput();

            var reporter = new Reporter();
            var ankara = new City("Ankara", new Temperature(14, TemperatureType.Celcius));
            reporter.AddCity(ankara);
            var tokyo = new City("Tokyo", new Temperature(24, TemperatureType.Celcius));
            reporter.AddCity(tokyo);
            reporter.AddCity(new City("İstanbul", new Temperature(16, TemperatureType.Celcius)));

            var cities = reporter.GetCityList();
            foreach (var city in cities)
            {
                Console.WriteLine($"City: {city}");
            }

            var ankaraTemprature = reporter.GetTemperature("ankara");
            Console.WriteLine("{0}", ankaraTemprature);
        }
    }
}
