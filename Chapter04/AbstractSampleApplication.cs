namespace Chapter04
{
    public struct Vector2D
    {
        public int X { get; set; }
        public int Y { get; set; }
    }
    /*
        abstract üyeler(members) diğer üyeler gibi iş yapan kod blokları içermezler
        abstract üyeler, abstract sınıf içerisinde olabilirler
        abstract sınıflar new operatörü ile örneklenemez (normal bir sınıftan en büyük farkı budur)
     */
    public abstract class GameEntity
    {
        protected Guid Id { get; private set; } // Read-only ve sadece türeyen tipler erişebilir
        public Vector2D Position { get; private set; } // Read-only
        /*
            GameEntity construct metodu protected erişim belirleyicisi ile tanımlanmıştır.
            Buna göre sadece türeyen sınıflardan erişilebilir.
         */
        protected GameEntity(Vector2D position)
        {
            Id = Guid.NewGuid();
            Position = position;
        }
        /*
            Draw ve Update metotlarının virtual versiyondan önemli bir ayrımları var.
            virtual kullanımında türeyen türler isterlerse bu davranışını override edebiliyorlar.
            Burada ise türeyen türlerin mutlaka bu davranışı yazması isteniyor
         */
        public abstract void Draw(); // Dikkat! Method Body yok
        public abstract void Update();
    }

    public class Vehicle
        : GameEntity
    {
        public Vehicle(Vector2D position)
            : base(position)
        {
        }
        public override void Update()
        {
            Console.WriteLine($"{base.Id} - Vehicle update operasyonu");
        }
        public override void Draw()
        {
            Console.WriteLine($"{base.Id} - Vehicle draw operasyonu");
        }
    }

    public class Invader
        : GameEntity
    {
        public Invader(Vector2D position)
            : base(position)
        {
        }
        public override void Update()
        {
            Console.WriteLine($"{base.Id} - Invader update operasyonu");
        }
        public override void Draw()
        {
            Console.WriteLine($"{base.Id} - Invader draw operasyonu");
        }
    }

    /*
        Örnekteki türetmeye dahil olan türlerin yönetileceği bir sınıfa ihtiyacımız olabilir.
        Mesela oyun sahasındaki tüm nesneler için draw ve update operasyonlarını çağıran fonksiyonellikler içerebilir
     */
    public class World
    {
        public string Title { get; set; }
        // entities özelliği, GameEntity türünden n sayıda nesne içerebilecek bir koleksiyondur.
        private readonly List<GameEntity> entities = [];

        // Bu metot sembolik olarak levelName isimli seviyeyi biryerden alıyor ve buna göre oyun nesnelerini sahaya yerleştiriyor
        // Saha dediğimiz yer aslında entitites isimli Liste.
        public void LoadLevel(string levelName)
        {
            /*
                Beginner
                
                + + + + + + + + + + + + + + + 
                + + +         + + +   + + + +
                +     + + +   + + +   + + + +
                +                 V         +
                +     S       S         P   +
                +                           +
                + + + +     +     +         +
                + + + + + + + + + + + + + + +

                Pro
                
                + + + + + + + + + + + + + + + 
                + + +   V     + S     + + + +
                +     + + +   + + +   + + S +
                +     S           V         +
                +     S       S             +
                + P                       S +
                + + + +     + S   +   S     +
                + + + + + + + + + + + + + + +
              
            */
            Console.WriteLine($"{levelName} is loading...");

            var blueCar = new Vehicle(new Vector2D { X = 10, Y = 20 });
            var greenPlane = new Vehicle(new Vector2D { X = 100, Y = 200 });
            entities.AddRange([blueCar, greenPlane]);

            var invaders = new Invader[10];
            for (int i = 0; i < 10; i++)
            {
                invaders[i] = new Invader(new Vector2D { X = i * 2, Y = 0 });
            }
            entities.AddRange(invaders);
        }

        //TODO@Everyone Yeni bir level'a nasıl geçeceğiz?
        public void ChangeLevel(string levelName)
        {
        }

        /*
            GameEntity kendisinden türeyen Vehicle ve Invader gibi nesneler için ortak davranışlar tanımlamıştır(Draw ve Update)
            Dolayısıla bu davranışlar üzerinen polimorfik hareket edebilir. 
            Yani, T anında kendisine atanan nesne gibi davranış gösterebilir.
         */
        public void DrawAll()
        {
            foreach (var entity in entities)
            {
                entity.Draw();
            }
        }
        public void UpdateAll()
        {
            foreach(var entity in entities)
            {
                entity.Update();
            }
        }

        public void SaveGame()
        {
            //TODO@everyone Oyunun son durum bilgisi nereye kaydedilecek?
            // Dosya sistemine kayıt edilebilir.
            // Ama bu mobil uygulama olsun bu durumda Cloud'a da kayıt edebilirim
            // Veya text tabanlı dosya değil de bir veritabanına kayıt edebilirim
            // Ya da farklı bir kayıt sistemi olabilir(henüz icat edilmemiş)
        }
    }

    public static class AbstractSampleApplication // statik sınıflar tanımlandıkları nesnenin örneğine ihtiyaç duymadan kullanılabilirler (Console.WriteLine gelsin aklınıza)
    {
        public static void Run()
        {
            var gameWorld = new World { Title = "Space Invaders Beginner Level" };
            gameWorld.LoadLevel("Beginner");
            for (; ; ) 
            {
                Thread.Sleep(5000); // Sembolik olarak 5 saniye duraklatma. Sanki bir oyun motoru döngüsündeymişçesine
                gameWorld.UpdateAll();
                gameWorld.DrawAll();
                // t+n zamanında oyunun o anki tüm içeriğini kaydedeceğiz
            }

            //// GameEntity gameEntity = new GameEntity(); // GameEntity abstract sınıf olduğundan new operatörü ile örneklenemez
            //var blueCar = new Vehicle(new Vector2D { X = 10, Y = 20 });
            //var greenPlane = new Vehicle(new Vector2D { X = 100, Y = 200 });
            //var invaders = new Invader[10];
            //for (int i = 0; i < 10; i++)
            //{
            //    invaders[i] = new Invader(new Vector2D { X = i * 2, Y = 0 });
            //}
            //// var car = new Vehicle(); // Vehicle ve Invader türleri base constructor'ı kullanmak zorunda olduklarından default constructor ile örneklenemezler
        }
    }
}
