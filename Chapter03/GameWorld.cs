namespace Chapter03
{
    /*
        GameObject sınıfımız oyun sahasındaki nesnelerimizin ortak özellik ve fonksiyonlarını sağlayan bir 
        base tür olarak düşünebiliriz.

        Plane ve Player sınıfları GameObject tipinden türemişlerdir ve bu nedenle X,Y özelliklerine ve Draw metoduna sahiptirler.
        Ama aynı zamanda Plane nesnesinin ve Player nesnesinin kendisine has özellik ve metotları vardır.

        C#, sınıflar üzerinden çok kalıtımı(multi-inheritance) desteklemez ancak bu Interface kullanımları ile mümkün olabilir.
     */
    public class GameObject
    {
        public int X { get; set; }
        public int Y { get; set; }
        /*
            Draw metodu virtual tanımlanmıştır, varsayılan(default) bir davranışı vardır
            ama isterseniz türeyen sınıfta bu davranışı değiştirebilirsiniz(override)
         */
        public virtual void Draw()
        {
            Console.WriteLine("Nesne çizdirme operasyonu yapılıyor");
        }
    }
    public class Plane : GameObject
    {
        public int Alttitude { get; set; }
        public double Health { get; set; }
        public void Fire()
        {
            Console.WriteLine("Uçak ateş ediyor");
        }
        /*
            Plane nesnesi için GameObject'te tanımlı Draw metodu ezilmiş ve işleyişi değiştirilmiştir.
         */
        public override void Draw()
        {
            Console.WriteLine("Uçak çiziliyor");
        }
    }
    public class Player : GameObject
    {
        public string Name { get; set; }
        public double Power { get; set; }
        public void SayGreetings()
        {
            Console.WriteLine("Oyuncu sizi selamlıyor");
        }
        public void Jump()
        {
            Console.WriteLine("Oyuncu zıplıyor");
        }
    }
}
