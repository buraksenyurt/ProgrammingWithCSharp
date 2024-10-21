namespace Azon.WeatherLib
{
    /*
        Class Library'ler execute edilebilen assembly'lar değildir. Console uygulamalarının aksine.
        Diğer projelerin referans ederek kullanabileceği fonksiyonellikler, türleri vs barındırırlar.

        Temperature sınıfındaki amaç hava sıcaklık değerini taşıyan bir veri yapısı sağlamaktır.
        Sahip olması gereken işlevler. Fahrenheit to Celcius vice versa.


        Öneri Senaryo : Belli sıcaklık değerlerine göre bir state bildirimi (Ilık, Serin, Sıcak, Nemli)
     */
    public struct Temperature
    {
        public double Value { get; set; }
        public TemperatureType Type { get; set; }
        public Temperature(double value, TemperatureType type)
        {
            Value = value;
            Type = type;
        }

        public void ConvertToCelcius()
        {
            // Early Return
            // Yani kod akışından erken dönülebilme olasılığı varsa uygulayalım.
            if (Type == TemperatureType.Celcius)
                return;

            Type = TemperatureType.Celcius;
            Value = (Value - 32) * 5.0 / 9.0;
        }
        public void ConvertToFahrenheit()
        {
            if (Type == TemperatureType.Celcius)
            {
                Type = TemperatureType.Fahrenheit;
                Value = (Value * 9.0 / 5.0) + 32;
            }
        }

        //public double ConvertToCelcius()
        //{
        //    // Early Return
        //    // Yani kod akışından erken dönülebilme olasılığı varsa uygulayalım.
        //    if (Type == TemperatureType.Celcius)
        //        return Value;

        //    Type = TemperatureType.Celcius;
        //    return (Value - 32) * 5.0 / 9.0;

        //    //if (Type == TemperatureType.Fahrenheit)
        //    //{
        //    //    Type = TemperatureType.Celcius;
        //    //    return (Value - 32) * 5.0 / 9.0;
        //    //}
        //    //return Value;
        //}

        //public double ConvertToFahrenheit()
        //{
        //    if (Type == TemperatureType.Celcius)
        //    {
        //        Type = TemperatureType.Fahrenheit;
        //        return (Value * 9.0 / 5.0) + 32;
        //    }
        //    return Value;
        //}
        public override string ToString()
        {
            return $"{Value} ({Type})";
        }
    }
    public enum TemperatureType
    {
        Celcius,
        Fahrenheit
    }
}
