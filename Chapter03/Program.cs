using System.Data;

namespace Chapter03
{
    /*
        Kalıtım konusuna geçmeden önce bununu .Net içerisinde uygulandığı Exception sistemini ele alıyoruz.
        
        Exception'lar çalışma zamanında ortaya çıkan hata nesneleridir. Herhangibi sebeple ortama fırlatılabilirler (throw)
        Exception'lar çalışma zamanı tarafından kontrol altına alınabilirler. Bunun için try...catch...finally blokları kullanılır.

        Kalıtım ile olan ilişkisi:
        Tüm istisna türleri Exception süper sınıfından türer(devralınır) Buna göre kendi istisna sınıflarımızı da yazabiliriz.

        try..catch blokları olası çalışma zamanı istisnalarını kontrol altına almak için ideal yapılardır ama bu bütün işleyişi
        try blokları ile yönetmek anlamına gelmemelidir zira bu mekanizmanın bir çalışma zamanı maliyeti var.

        Bütün Exception türleri Exception kelimesi ile biter(Bu bir isimlendirme standartı)

     */
    internal class Program
    {
        static void Main(string[] args)
        {
            // try bloğunda olabilecek hatalar(exception) catch bloklarınca yakalanabilir ve program akışı kontrollü bir hale getirilebilir
            try
            {
                // double result = Div(10, 0); // Eğer DivideByZeroException hatası kontrol altına alınmazsa burada program crash olur.
                // Eğer bir exception oluşursa, try bloğu içerisinde geri kalan kod satırları işletilmez, doğrudan catch bloğuna gidilir

                // FileNotFoundException oluşur. Çünkü sistem böyle bir dosyamız yok
                // Built-in gelen metotlarda ne tür exception'lar fırlatılabileceğine bir bakmakta yarar var.
                // var f = File.OpenRead("C:\\unknown_file.data"); // Sistemden bir dosya okumak üzere açılmak istenir 

                // throw new ArgumentException("Argüman hatası");

                //var silo = new HttpManager();
                //var result = silo.Send("http://movies.api/action/12", "");
                //Console.WriteLine(result);

                /*
                    Plane is a GameObject.
                    
                    vecihi değişkeni üzerinden GameObject'teki X,Y özelliklerine erişebilir
                    Draw metodunu çağırabiliriz ve ayrıca kendi metotlarını da kullanabiliriz.
                 */
                Plane vecihi = new Plane { X = 10, Y = 20 };
                vecihi.Draw(); //base class metodu
                vecihi.Fire(); // kendi metodu

                Player mario = new Player { X = 11, Y = 12 };
                mario.Draw(); // base class metodu
                mario.Jump(); //Kendi metodu

                GameObject go1 = vecihi; // Bu atama mümkündür çünkü vecihi bir Plane nesnesidir ve Plane nesnesi de bir GameObject' tir.
                /*
                    Plane nesnesinde, GameObject'ten devralınan Draw metodu ezildiği için(override),
                    go1 değişkeni(GameObject) üstünden yapılan Draw çağrısı, alt sınıfın ezilmiş olan Draw metodunu işletilir.
                    Yani GameObject, Plane nesnesi gibi davranış sergiler ve bunun adı da Çok Biçimliliktir(Polymorphism)

                    Ancak tam aksine go2 yine GameObject'ten türeyen Player nesnesi olarak taşınsada Draw operasyonu Player nesnesinde yeniden 
                    yazılmadığından, go2 tam anlamıyla Player gibi davranış sergilemez.

                    Bir nesnenin çok biçimli olması neden önemli olabilir?
                 */
                go1.Draw();
                GameObject go2 = mario; // Doğal olarak bu da mümkündür.
                go2.Draw();

            }
            catch (DivideByZeroException ex) // Sıfıra bölme hatası oluşursa bu blok çalışacak
            {
                Console.WriteLine(ex.Message);
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (InvalidUrlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex) // try bloğunda ele alınmamış bir Exception söz konusu ise bu blok çalıştırılır
            {
                // Exception, diğer tüm Exception nesnelerini çevreler
                Console.WriteLine(ex.Message);
            }
            finally
            {
                /*
                    Genellikle kaynakların(resource) geri iadesi(database bağlantısı açılmış olabilir, ağ bağlantıları vardır,
                    bellekten toplanması gereken nesneler olabilir) gibi durumlarda kullanışlıdır

                    ya da programın bir önceki state'e döndürülmesi için de ele alınır.
                */
                Console.WriteLine("try bloğundaki kod parçasında hata olsa olmasa da çalışır");
            }
            Console.WriteLine("Program sonu");
        }

        /*
            Bir sonraki derste tekrar ele alalım.
        */
        static void DrawLevel(string level,List<GameObject> gameObjects)
        {
            foreach (var go in gameObjects)
            {
                go.Draw();
            }
        }

        /*
            Soru: Div fonksiyonundaki olası sıfıra bölme hatası Exception mekanizmasına bırakılmadan giderilebilir mi?
            
         */
        //static int Div(int x, int y)
        //{
        //    return x / y; // Muhtemele DivideByZeroException
        //}

        /*
            Aşağıdaki metotda çok bariz olarak bilinen sıfıra bölme hatası daha kontrollü bir şekilde ele alınmış
            ve Exception kullanımından kaçınılmıştır.

            ! Mümkün mertebe Exception kullanımından kaçınmak lazım. Yani bir kontrolü Exception 
         */
        static Response Div(int x, int y)
        {
            if (y == 0)
            {
                return new Response
                {
                    Value = 0,
                    IsSuccess = false,
                    ErrorMessage = "Sıfıra bölme hatası"
                };
            }
            return new Response
            {
                Value = x / y,
                IsSuccess = true,
                ErrorMessage = string.Empty
            };
        }
        static Response GetAccountInfo(int accountNumber)
        {
            return new Response
            {
                Value = new Account(),
                IsSuccess = true,
                ErrorMessage = string.Empty
            };
        }

        /*
            SaveInvoice fonksiyonu bir business domain metodu olabilir. Örneğin finansal işlemlerin yapıldığı ya da bir muhasebe paketinin parçası olabilir.
            Fatura kaydetme adımının içerisinde oluşabilecek birçok sorun vardır. 
            Faturalanacak tutar geçersiz olabilir, müşteri numarası hatalı olabilir, müşterinin limiti geçersiz olabilir vb
            Bu gibi iş kuralları söz konusu olduğunda geriye sadece işlemin başarılı olup olmadığına dair true veya false döndürmek yerine,
            nesne kullanıcısının (object user) durumla ilişkili detay bilgi almasını sağlayacak(işlem sonucu ile ilgili asıl dönecek veriyi de içerecek şekilde)
            bir dönüş türü kullanmak daha mantıklıdır.
            Response sınıfının buradaki geliştirilme sebebi de budur.
         */
        static Response SaveInvoice(double amount, int customerId)
        {
            // Aşağıdaki durumlar business case'ler.
            // customerId geçersizse false dön
            // amount geçersizse false dön
            // amount, müşterinin limiti dışında ise false dön

            return new Response
            {
                IsSuccess = false,
                Value = amount,
                ErrorMessage = "Müşteri limiti yetersiz olduğu için işlem yapılamıyor"
            };
        }
    }
}
/*
    Response gibi bir sınıfa neden ihtiyacımız olsun?    

    Araştırma konusu olarak Response ve Output pattern'ler incelenebilir.
*/
class Response
{
    /*
        Bütün nesneler bir şekilde Object sınıfından türediğinden, Value özelliğine herhangibir nesne atanabilir.
        Div metodundaki int sonucu veya GetAccountInfo'daki Account nesnesi vb...
        Ancak bu tehlikelidir(Neden?) Çünkü bu, Value özelliğine alakalı olmayan nesneleri de verebileceğimiz anlamına gelir.
        Yani Account döndürmesi gerektiği yerde float dönebilir...

        Value özelliğinin daha kısıtlı bir kümede değer döndürmesini sağlamak istersek generic mimariden ve generic contstraint'lerden yararlanabiliriz.
        Generic konusunu sonraki derste işleyeceğiz.        
     */
    public object Value { get; set; }
    public bool IsSuccess { get; set; }
    public string ErrorMessage { get; set; }
}
class Account // Sembolik bir sınıf olarak tasarlandı
{
}
