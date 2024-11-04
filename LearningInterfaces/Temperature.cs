namespace LearningInterfaces
{
    public class Temperature 
        : IFormattable
    {
        public double Celsius { get; set; }

        public string ToString(string format, IFormatProvider formatProvider)
        {
            return format switch
            {
                "F" => $"{Celsius * 9 / 5 + 32} °F",
                "C" => $"{Celsius} °C",
                _ => Celsius.ToString()
            };
        }
    }
}
