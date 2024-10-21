namespace Learning.Structs
{
    /*
        Aşağıdaki örnekte XML Comment kullanımları da örneklenmiştir.
        Vector2D sınıfını kullandığımız yerlerde bu comment'ler IDE tarafından kullanıcıya gösterilen tip box'larda görünür.
        Ayrıca XML dokümantasyonu üzerinden kütüphaneler için Help içerikleri de üretilebilir.
        
        Detaylar için https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/xmldoc/
     */

    /// <summary>
    /// İki boyutlu düzlemde bir vektör nesnesini ifade eder
    /// </summary>
    /// <param name="x">X değeri</param>
    /// <param name="y">Y değeri</param>
    public struct Vector2D(double x, double y)
    {
        /// <summary>
        /// Vektörün X ekseni değeri
        /// </summary>
        public double X { get; set; } = x;
        /// <summary>
        /// Vektörün y ekseni değeri
        /// </summary>
        public double Y { get; set; } = y;

        /// <summary>
        /// Vektör büyüklüğünü hesaplamak için kullanılan fonksiyondur
        /// </summary>
        /// <returns>Vektör büyüklüğü</returns>
        public double Magnitude()
        {
            // Math sınıfının statik Karekök alma fonksiyonundan yararlanılmıştır
            return Math.Sqrt(X * X + Y * Y);
        }

        //TODO@buraksenyurt Operator Overloading konusu ile Add metodunu toplama operasyonuna alalım.

        /// <summary>
        /// Bir vektöre yeni bir vektör eklemek için kullanılan fonksiyondur
        /// </summary>
        /// <param name="other">Eklenecek vektör</param>
        /// <returns>Toplama sonrası elde edilen yeni vektördür</returns>
        public Vector2D Add(Vector2D other)
        {
            return new Vector2D(this.X + other.X, this.Y + other.Y);
        }

        /// <summary>
        /// Vektörler arası nokta çarpım değerini hesaplar
        /// </summary>
        /// <param name="other">Referans vektör</param>
        /// <returns>Notka çarpım değeri</returns>
        public double DotProduct(Vector2D other)
        {
            return this.X * other.X + this.Y * other.Y;
        }

        /// <summary>
        /// Vektörler arasındaki yön ilişkisini bulmak için kullanılır.
        /// 
        /// Nokta çarpım değeri sıfırdan büyükse aynı yön
        /// Nokta çarpım değeri sıfırdan küçükse ters yön
        /// Diğer halde birbirlerine dik konumda
        /// 
        /// </summary>
        /// <param name="other">Referans vektör</param>
        /// <returns>Yön bilgisi</returns>
        public Direction GetDirection(Vector2D other)
        {
            double dotProduct = this.DotProduct(other);

            if (dotProduct > 0)
            {
                return Direction.SameDirection;
            }
            else if (dotProduct < 0)
            {
                return Direction.OppositeDirection;
            }
            else
            {
                return Direction.Perpendicular;
            }
        }
    }

    /// <summary>
    /// Vektörler ile ilgili yön bilgilendirilmesi için kullanılır
    /// </summary>
    public enum Direction
    {
        SameDirection,
        OppositeDirection,
        Perpendicular
    }
}
