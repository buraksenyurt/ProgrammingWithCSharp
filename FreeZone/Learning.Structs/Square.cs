namespace Learning.Structs
{
    /// <summary>
    /// Dörtgenleri temsil eder
    /// </summary>
    public struct Square
    {
        /// <summary>
        /// Dörtgen uzunluğu
        /// </summary>
        public double Width { get; set; }
        /// <summary>
        /// Dörtgen yüksekliği
        /// </summary>
        public double Height { get; set; }

        /// <summary>
        /// Dörtgen nesnesi örnekler
        /// </summary>
        /// <param name="width">En</param>
        /// <param name="height">Boy</param>
        public Square(double width, double height)
        {
            Width = width;
            Height = height;
        }

        /// <summary>
        /// Dörtgenin alanını hesaplar
        /// </summary>
        /// <returns>Alan değeri</returns>
        public double GetArea()
        {
            return Width * Height;
        }

        /// <summary>
        /// Dörtgenin çevresini hesaplar
        /// </summary>
        /// <returns>Çevre değeri</returns>
        public double GetPerimeter()
        {
            return 2 * (Width + Height);
        }
    }

}
