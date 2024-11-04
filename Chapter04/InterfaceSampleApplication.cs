namespace Chapter04
{
    /*
        Türeyen türlerin mutlaka uyması gereken kuralları söylemenin bir diğer yolu da Interface tipinden yararlanmaktır.
        Interface türü ile de çok biçimlilik sağlanabilir yani bir interface kendisini uygulayan nesneleri taşıyabilir,
        onlara tanımladığı davranışları işletebilir.
     */
    public abstract class GameObject
    {
        protected Guid Id { get; private set; }
        public Vector2D Position { get; private set; }
        protected GameObject(Vector2D position)
        {
            Id = Guid.NewGuid();
            Position = position;
        }
        void GetSummary()
        {
        }
    }

    /*
        abstract türlerden farklı olarak interface tipi sadece davranış tanımlar(Contract)
        yani hiçbir şekilde iş yapan kodlar içermez.
        IPlayable interface tipi Draw ve Update isimli iki metot tanımlar. 
        Bu interface türünü uygulayan her tür bu metotları yazmak zorundadır.
        Interface türü, SOLID prensiplerinden Depdency Inversion içerisinde de sıklıkla geçer. 
        Bağımlılıkları tersine çevirmek için kullanılır.
     */
    interface IPlayable
    {
        void Draw(); // public, protected, private vb erişim belirleyicileri de(access modifiers) içermez çünkü doğal olarak herkese açıktır
        void Update();
    }

    /*
        Wall sınıf hem bir GameObject türüdür hem de IPlayable davranışlarına sahiptir.
        Bir sınıfa birden fazla interface uyarlanabilir ama birden fazla sınıftan türetilemez.        
     */
    public class Player
        : GameObject, IPlayable
    {
        public string Name { get; set; }
        public Player(Vector2D position)
            : base(position)
        {
        }
        public void Draw()
        {
            Console.WriteLine($"{Id} player - is drawing...");
        }

        public void Update()
        {
            Console.WriteLine($"{Id} player - is updating...");
        }
    }

    public class Tower
        : GameObject, IPlayable
    {
        public int Health { get; set; }
        public Tower(Vector2D position)
            : base(position)
        {
        }
        public void Draw()
        {
            Console.WriteLine($"{Id} tower - is drawing...");
        }

        public void Update()
        {
            Console.WriteLine($"{Id} tower - is updating...");
        }
    }

    public class Wall
        : IPlayable
    {
        public string Color { get; set; }
        public void Draw()
        {
            Console.WriteLine($"Wall is drawing...");
        }

        public void Update()
        {
            Console.WriteLine($"Wall is updating...");
        }
    }

    public class Engine
    {
        private readonly List<IPlayable> playables = [];
        
        // Bu fonksiyon aslında oyun motorunda olmaz(Eğitimde sadece simülasyon için kullandık)
        public void LoadLevel(string level)
        {
            Console.WriteLine($"{level} içeriği yükleniyor");

            playables.Add(new Tower(new Vector2D { X = 10, Y = 4 }) { Health = 100 });
            playables.Add(new Player(new Vector2D { X = 5, Y = 5 }) { Name = "Prince of Persia" });
            playables.Add(new Wall() { Color = "Black" });
            playables.Add(new Wall() { Color = "Red" });
        }
        public void Run()
        {
            /*
                Abstract sınıflarda olduğu interface tipleri de new operatörü örneklenemez
                Hatta interface tamamen polimorfik(bukalemun) bir türdür. Kendisinde tanımlanan davranışları yazmış nesneler gibi hareket eder
                
                Aşağıdaki döngüde GameEngine nesnesindeki playables isimli List<IPlayable> koleksiyonu dönülürken,
                playable değişkenine hangi türeyen nesne gelirse onun Update ve Draw metotları çağrılır.
            */

            foreach (IPlayable playable in playables)
            {
                playable.Update();
                playable.Draw();
            }
        }
    }

    public static class InterfaceSampleApplication
    {
        public static void Run()
        {
            var gameEngine = new Engine();
            gameEngine.LoadLevel("Beginner");
            gameEngine.Run();
        }
    }
}