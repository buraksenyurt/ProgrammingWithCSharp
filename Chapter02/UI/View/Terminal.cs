namespace Chapter02.UI.View
{
    /*
        Terminal aslında kullanıcı ile etkileşimde olunan bir ortam. Genel olarak View olarak ifade edilir.
        Bu uygulamanın UI(User Interface) ile ilgili işlerinin toplandığı, View alanı altında konuşlandırılmıştır.
        
        Burada en zoru hangi türü hangi isim alanı(namespace) altına alacağımıza karar vermektir. Bu anlamda genel yazılım
        prensipleri ve pratikleri var. Örneğin MVC (Model View Controller) veya MVVM (Model View View Model)

        Terminal sınıfının fonksiyonları sadece Console ile çalışır halde. Genel olarak Terminal ile Console sınıfı arasında sıkı bağlı
        bir ilişki olduğunu söyleyebiliriz (Thightly Coupled) OOP tarafında mümkün mertebe nesneler arası bağımlılıkları azaltmaya çalışırız.
        Buda Losely Coupled olarak geçer. Yani amaç Terminal sınıfının sadece Console ile çalışması değil örneğin bir IoT terminali ile de 
        çalışması olabilir.

        Arada gelen soru üzerine sonrası için bakmamız gereken ilkeler;
        SOLID 
            Single Responsibility
            Open Closed
            Liskov Substituation
            Interface Segregation
            Dependency Inversion

        Terminal sınıfının tüm üyeleri static olarak tanımlandığından kendisinin de static olması önerilir.
    */
    internal static class Terminal
    {
        /*
            SplashScreen herhangibir parametre almayan ve değer döndürmeyen (void) bir metottur.
            Main metodu static tanımlanmış bir metot olduğundan, Program sınıfı içindeki SplashScreen metodunun
            çağırlabilmesi için onun da static tanımlanması gerekir.

            Bir metodu, parametre yapısını farklılaştırarak çoğaltabilir ve aynı isimle kullanabiliriz(Overloading)
            Overloading işleminde kural parametre sayısı ve türleri ile alakalıdır(Method Signature)

            Eğer aksini belirtmezsek, sınıf üyeleri private erişim belirleyicisine sahiptir (Access Modifiers)
            private, public, internal, protected ve protected internal şeklinde 5 temel erişim belirleyicisi vardır.

            internal erişim belirleyici sadece tanımlı olduğu proje için kullanımı serbest bırakır.
            public ise her yerden erişilebilir anlamındadır.

            Aynı/benzer amaca hizmet eden tipleri (class, struct, enum, interface, delegate) aynı namespace çatısında toplamak
            veya aynı/benzer amaca hizmet eden üyeleri/members (field, property, method, event, constructor...) aynı tip altında 
            toplamak, domain anlamında bütünsellik sağlamak için önemlidir.
            Örneğin, terminal ekranı ile ilgili yapılacak işleri Terminal isimli bir sınıf altında topladığımız gibi.
         */
        internal static void SplashScreen()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("************************");
            Console.WriteLine("***Wellcome Stranger****");
            Console.WriteLine("************************");
            Console.ForegroundColor = ConsoleColor.White;
        }
        internal static void SplashScreen(string playerName)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            // Console.WriteLine(new String('*', 24));
            Console.Write(GetSmartText('+', 24));
            Console.WriteLine("Wellcome {0}", playerName);
            Console.WriteLine(new string('*', 24));
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.White;
            Console.ReadLine();
        }
        internal static void ShowMenu()
        {
            Console.Clear();
            Console.WriteLine("Başlat(B)");
            Console.WriteLine("Puan Tablosu(P)");
            Console.WriteLine("Ayarlar(A)");
            Console.WriteLine(GetSmartText('_', 24));
            Console.WriteLine("Çıkış(E)");
            Console.WriteLine("Bir seçim yapar mısın?");
        }

        internal static void GetUserInput()
        {
            /*
                Terminal ekranından girdi almanın bir yolu ReadLine metodunu kullanmaktır.

                B, A, E, P gibi harfler hiç bilmeyen için bu oyunda neyi ifade ediyor acaba?
                
            */
            var input = Console.ReadLine();
            var userInput = input.ToUpper();
            switch (userInput)
            {
                case "B":
                    Console.WriteLine("Oyun başlıyor...");
                    break;
                case "P":
                    // Score tablosu çizilen bir metot çağrılır örneğin
                    Console.WriteLine("Puan Tablosu");
                    break;
                case "A":
                    // Ayarlar menüsü gösterilir vs
                    Console.WriteLine("Ayarlar");
                    break;
                case "E":
                    Console.WriteLine("Oyun sonlandırılıyor");
                    break;
                default:
                    Console.WriteLine("Seçimini anlayamadım. Lütfen tekrar gel!");
                    break;
            }

            //if (userInput == "B")
            //{
            //    Console.WriteLine("Oyun başlıyor...");
            //}
            //else if (userInput == "P")
            //{
            //    Console.WriteLine("Puan Tablosu");
            //}
            //else if (userInput == "A")
            //{
            //    Console.WriteLine("Ayarlar");
            //}
            //else if (userInput == "E")
            //{
            //    Console.WriteLine("Oyun sonlandırılıyor");
            //}
            //else
            //{
            //    Console.WriteLine("Seçimini anlayamadım. Lütfen tekrar gel!");
            //}
        }

        /*
            GetSmartText metodu parametrelere göre bir string üretip döndürür.
         */
        static string GetSmartText(char c, int count)
        {
            string result = string.Empty; // Geriye bir string döneceği için başlangıçta tanımladık.
            // count sayısı kadar ileri hareket edecek bir döngü başlattık
            //TODO@everyone for döngüsü yerine while, do while döngüleri ile aynı işi yapar mısınız?
            for (int i = 0; i < count; i++)
            {
                result += c; // String'e += ile c argümanını ekledik
            }
            result += "\n"; // Newline karakteri de ekledik. new line, tab gibi karakterler Escape Character olarak ifade edilip \ ile yazılır.
            return result;
        }
    }
}
