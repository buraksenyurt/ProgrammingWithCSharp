# Vize Sınavı Soruları

Toplam 10 sorudan oluşan 60 dakikalık vizenin içeriği aşadağıki gibidir.

## Soru 1 (Model Nesnesi Tanımlama Hakkında)

Çalışmakta olduğunuz projede aşağıda örnek bir parçası verilen JSON içeriğine sahip veri dosyanın parse edilmesi işlemi gerçekleştiriliyor.

```json
{
  "id": "d5e8b21d-4ec3-4723-aabe-cbb2dcd9d7f2",
  "title": "Inventory Tracking System",
  "summary": "Bu projede amaç basit bir envanter takip sistemi geliştirilmesidir.",
  "level": 70
}
```

Her bir JSON setinin bir model nesnesi ile ifade edilmesi gerekiyor. Aşağıdaki sınıf tasarımlarından hangisini kullanırsınız?

A.

```csharp
class HomeWork
{
   public Guid Id { get; set; }
   public string Title { get; set; }
   public string Summary { get; set; }
   public short Level { get; set; }
}
```

B.

```csharp
pub struct Homework {
   id:Guid,
   title:String,
   summary:String,
   level:short
}
```

C.

```csharp
class HomeWork
{
   public Id;
   public Title;
   public Summary;
   public Level;
}
```

D.

```csharp
class Homework(id:Guid, title:String, summary:String, level:Short)
```

_Doğru Cevap A Şıkkı_

## Soru 2: (Class vs Struct Bellek Yönetimi Hakkında)

.Net platformu managed bir kodlama ortamı sağlar. Buna göre çalışma zamanı atıl nesneleri toplamak için Garbage Collector mekanizmasını kullanır. Bellek yönetiminde izlenen bu yol nesne ömürlerinin yönetmek için programcının yükünü hafifletir. Nesneler değer türü(value type) ve referans type(reference) olmak üzere iki ana kategoriye ayrılır. Buna göre class ve struct veri tiplerinin bellekte tutulma şekilleri ile alakalı aşağıdakilerden hangisi doğrudur.

A. Class türündeki nesneler referans tipidir ve heap üzerinde tutulur.

B. Struct türündeki nesneler referans tipidir ve stack üzerinde tutulur.

C. Class türündeki nesneler stack üzerinde tutulur, referans adresleri heap'te tutulur.

D. Struct türündeki nesneler heap üzerinde tutulurken veri geçici olarak stack bellek bölgesinden konumlanır.

_Doğru Cevap A Şıkkı_

## Soru 3: (Keyword Bilgisi Ölçümü Hakkında)

Bir oto galeri firması için tasarlanan web uygulamasında araç bilgilerini taşımak için bir model nesnesi tasarlanıyor. Aşağıda bu model nesnesinin bazı kısımlarını görmektesiniz. Boşluk bırakılan yerlere yukarıdan aşağıya kodlama sırasına göre hangi kelimeler gelmelidir, şıklardan işaretleyiniz.

```csharp
_____ Car(string name, ProductColor color, string model, short year)
{
   public _____ Name { get; _____ set; } = name;
   public ProductColor Color { get; private set; } = color;
   public string Model { get; private set; } = model;
   public short Year { get; private set; } = year;
}

_____ ProductColor
{
   Black,
   White,
   Green,
   Blue,
   Yellow
}
```

A. enum, string, private, class

B. class, string , string, enum

C. class, string, private, enum

D. class, private, string, enum

_Doğru cevap C şıkkı_

## Soru 4 (Kod Okuma ve Anlama Hakkında)

Aşağıdaki kod parçasında yer alan GetSmartText fonksiyonun işleyişi şıklardan hangisi ile doğru şekilde ifade edilir.

```csharp
static string GetSmartText(char c, int count)
{
    string result = string.Empty;
    for (int i = 0; i < count; i++)
    {
        result += c;
    }
    result += "\n";
    return result;
}
```

A. Verilen char değeri, count kadar tekrar edilip ters çevrilir ve sonuna boşluk eklenir.

B. Verilen char değeri, her döngüde bir önceki değeri silerek sadece son değeri tutar.

C. Verilen char değeri her defasında küçük harfe dönüştürülerek string'e eklenir.

D. Verilen char değeri, count kadar tekrar edilip bir string oluşturur ve sonuna yeni satır karakteri eklenir.

_Doğru Cevap D şıkkı_

## Soru 5 (Nesne Yönelimli Dil Prensipleri Hakkında)

Aşağıda verilen örnek kod parçası nesne yönelimli dil prensiplerinden hangi ilkeyi uygulamaktadır.

```csharp
public class UserProfile
{
    private string _username;
    private string _email;

    public string Username
    {
        get
        {
            return _username;
        }
        set
        {
            if (!string.IsNullOrEmpty(value))
                _username = value;
        }
    }
    public string Email
    {
        get
        {
            return _email;
        }
        set
        {
            if (value.Contains("@"))
                _email = value;
        }
    }
}
```

A. Inheritance

B. Polymorphism

C. Encapsulation

D. Abstraction

_Doğru cevap C Şıkkı_

## Soru 6 (Exception Yönetimi Hakkında)

.Net ve Java gibi programlama ortamları çalışma zamanında oluşabilecek bazı hata durumları için Exception mekanizması kullanır. Exception mekanizması ile ilgili olarak aşağıdakilerden hangisi veya hangileri doğrudur.

- **I.**   Çalışma zamanında ortama fırlatılan Exception nesneleri try..catch bloklarında ele alınır.
- **II.**  finally bloğu, try bloğunda exception olsa da olmasa da çalışan bloktur ve ağırlıklı olarak kaynakların temizlenmesi ya da program durumunun bir önceki konuma alınması için kullanılır.
- **III.** Bir Exception nesne örneğini çalışma zamanına manuel fırlatmak için throw anahtar kelimesinden yararlanılır.
- **IV.**  Kendi Exception türlerimizi yazabiliriz ve bunun için ilgili sınıfın Exception sınıfından türemesi yeterlidir.

A. Sadece III

B. I ve II

C. I, II ve IV

D. Hepsi doğrudur

_Doğru cevap D şıkkı_

## Soru 7 (En İdeal Kodun Tespiti Hakkında)

Elimizde aşağıdaki gibi bir dizi var.

```csharp
static readonly string[] books = {
  "Dune", "Neuromancer", "Snow Crash", "Hyperion", "The Left Hand of Darkness",
  "Foundation", "Brave New World", "The Stars My Destination", "The Dispossessed"
};
```

Bu dizide bazı kitapların adları tutuluyor. Sizden herhangi bir harf ile başlayan kitap adlarını listeleyen bir metot yazmanız isteniyor. Aşağıdaki metotlardan hangisi söz konusu işlevi karşılar.

A.

```csharp
public static List<string> GetBooksStartingWith(char letter)
{
    List<string> result = new List<string>();
    foreach (var book in books)
    {
        if (book.Contains(letter.ToString()))
        {
            result.Add(book);
        }
    }
    return result;
}
```

B.

```csharp
public static List<string> GetBooksStartingWith(char letter)
{
    List<string> result = new List<string>();
    foreach (var book in books)
    {
        if (book.StartsWith(letter.ToString()))
        {
            result.Add(book);
        }
    }
    return result;
}
```

C.

```csharp
public static List<string> GetBooksStartingWith(char letter)
{
    List<string> result = new List<string>();
    foreach (var book in books)
    {
        if (book.EndsWith(letter.ToString()))
        {
            result.Add(book);
        }
    }
    return result;
}
```

D.

```csharp
public static List<string> GetBooksStartingWith(char letter)
{
    List<string> result = new List<string>();
    for (int i = 0; i < books.Length; i++)
    {
        if (books[i].StartsWith(letter.ToString().ToLower()))
        {
            result.Add(books[i]);
        }
    }
    return result;
}
```

_Doğru cevap C şıkkı_

## Soru 8 (Gerçek Hayat Senaryosundan Yola Çıkarak Fikir Yürütme Hakkında)

2D platform üzerinde çalışan bir oyunun geliştirilmesinde görev alıyorsunuz. Nesne modellerini tasarlarken oyun sahasındaki her bir aktör için pozisyon ve hareket yönü bilgilerine ihtiyacınız var. Bu iki enstrümanı birçok şekilde tasarlayabilirsiniz. Sizce en ideal yol aşağıdakilerden hangisidir?

A. Pozisyon bilgisi için x ve y koordinatlarını ayrı birer float değişken olarak tutabilir ve hareket yönünü bir Direction sınıfı(class) ile ifade edebiliriz.

B. Pozisyon bilgisi için Vector2D gibi bir struct tasarlayabiliriz ve hareket yönünü tayin etmek için bir enum türü ele alabiliriz.

C. Her aktörün x, y koordinatlarını float olarak tutabilir, hareket yönü içinse 1 veya -1 gibi integer değerler kullanabiliriz.

D. Pozisyon ve yön bilgilerini string türden bir alan olarak JSON gibi bir formatta saklayabiliriz.

_Doğru cevap B şıkkı_

## Soru 9 (Kalıtım Prensiplerinin Bilinirliği Hakkında)

Aşağıdaki kod parçasında nesne yönelimli dil ilkelerinden kalıtım(Inheritance) prensibinin basit bir kullanımı ifade edilmektedir.

```csharp
public class GameEntity
{
    public int Health { get; set; }
    public int Speed { get; set; }

    public virtual void Move()
    {
        Console.WriteLine("Game entity is moving.");
    }
}

public class Player : GameEntity
{
    public string Name { get; set; }

    public override void Move()
    {
        Console.WriteLine($"{Name} is running at speed {Speed}.");
    }
}
```

Buna göre aşağıdaki şıklardan hangisi bu kod parçası ile ilgili doğru bir yorumdur.

A. Player sınıfı GameEntity sınıfından Move metodunu kalıtım yoluyla devralır ve bu metodu değiştirmeden olduğu gibi kullanır.

B. Player sınıfı Health ve Speed gibi GameEntity özelliklerini devralamaz zira bu özellikler yalnızca GameEntity sınıfı içinde tanımlıdır.

C. Player sınıfı, GameEntity sınıfındaki Move metodunu override edip kendi özel davranışını tanımlar. Player sınıfına ait tüm nesne örnekleri bu yeni davranışı sergiler.

D. Kalıtım sebebiyle Player sınıfındaki her Move çağrısı önce GameEntity içindeki Move metodunu çalıştırır ve sonrasında Player sınıfındaki Move operasyonu işletilir.

_Doğru cevap C şıkkıdır_

## Soru 10 (Kod Okuma ve Yorumlama Hakkında)

Bir e-ticaret platformu için proje geliştiriyoruz. Platformda kullanıcı sipariş durumlarının yönetmemiz gerekiyor. Bu durumlar New, Shipped, Delivered gibi üç farklı değerde olabilir. Bu sipariş durumlarını oluşturmak için aşağıdaki kod parçasında görülen static factory method tekniği kullanılmaktadır. Kodu incelediğinizde şıklardan hangisi doğrudur?

```csharp
public class OrderStatus
{
    public string Status { get; private set; }

    private OrderStatus(string status)
    {
        Status = status;
    }

    public static OrderStatus NewOrder()
    {
        return new OrderStatus("New");
    }

    public static OrderStatus ShippedOrder()
    {
        return new OrderStatus("Shipped");
    }

    public static OrderStatus DeliveredOrder()
    {
        return new OrderStatus("Delivered");
    }
}
```

A. OrderStatus sınıfında new anahtar kelimesiyle doğrudan nesne oluşturulması engellenmiş, bunun yerine NewOrder, ShippedOrder ve DeliveredOrder gibi static factory metotları kullanılarak nesnenin örneklenmesi sağlanmıştır.

B. OrderStatus sınıfı, sadece bir kez nesne oluşturulmasına izin verir ve bu yüzden factory metotları static olarak tanımlanmıştır.

C. Factory metotlar, OrderStatus sınıfında dinamik bir şekilde farklı sipariş durumlarını oluşturmak için kullanılır ancak bu metotlar static olduğu için farklı statülerde birden fazla nesne oluşturulamaz.

D. OrderStatus sınıfı, kendisinden miras olarak türetilecek alt sınıfları oluşturmak için tasarlanmış soyut(abstract) bir sınıftır.

_Doğru cevap A şıkkıdır_
