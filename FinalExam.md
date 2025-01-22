# C# ile Nesne Yönelimli Programlamanın Temelleri, Final Sınavı Soruları

Süre 90 Dakika, Toplam Soru Sayısı 10

**Önemli Not : Aday sorulardan oluşmaktadır. Nihai halinde sıralamalar, şık yerleri ve hatta sorular değişebilir.**

---

## Soru 1: Yüksek kalitede kod çıktısı üretmek için kullanılan yöntemlerden birisi de birim test(Unit Test) yazmaktır. Aşağıda birim testler ile ilgili bazı kavramlara yer verilmiştir. Bu kavramlardan hangisi/hangileri doğrudur?

Birim testlerin önemli amaçlarından birisi de bir fonksiyonun doğru çalışıp çalışmadığını kontrol etmektir. 
Birim testler, bağımsız olarak çalıştırılabilir ve ana iş akışına bağlı olmayan bileşenlerden(component) bağımsız testler yapılmasını sağlar.
Birim testler performans optimizasyonu için de kullanılır.
Birim testler, beklenen ve elde edilen değerleri kontrol ederek istenen sonuçların alındığını doğrulamak için kullanılır.

- I ve II
- I, II ve IV
- II ve IV
- Hepsi

**Devam Eden Sorular :** Sıklıkla karşılaşılan problemlerin standartlaşmış çözümleri için bazı yazılım prensipleri uygulanmaktadır. Bu prensiplerden birisi de Robert C. Martin(Uncle Bob) tarafından ortaya konan SOLID ilkeleridir.

- **Single-responsibility Principle:** Bir sınıf yalnızca bir işlevi yerine getirmeli ve bu işlevin tek bir sorumluluğu olmalıdır. Değişiklikler sadece o sorumlulukla ilgili olduğunda sınıfın güncellenmesi gerekir.
- **Open-closed Principle:** Bir sınıf genişletilmeye açık değiştirmeye kapalı olmalıdır. Yani yeni işlevler eklemek için mevcut kod değiştirilmemeli bunun yerine genişletilebilmelidir.
- **Liskov Substitution Principle:** Bir alt sınıf, türetildiği üst sınıfın yerine kullanılabilir olmalıdır. Bu, davranışsal(behavioral) olarak bozulmaya yol açacak değişikliklerin yapılmaması gerektiği anlamına da gelir.
- **Interface Segregation Principle:** Bir sınıf yalnızca ihtiyaç duyduğu yöntemleri içeren bir arayüze(Interface) sahip olmalıdır. Büyük ve kapsamlı arayüzler yerine daha küçük ve spesifik arayüzler kullanılmalıdır.
- **Dependency Inversion Principle:** Yüksek seviyeli modüller (iş kurallarını barındıran kodlar) düşük seviyeli modüllere(detay içeren bileşenlere) bağımlı olmamalıdır. Her ikisi de soyutlamalara(abstraction) bağımlı olmalıdır.

Devam eden sorulara cevaplanırken bu ilkelerle göz önüne alınmalıdır.

## Soru 2 : Aşağıda yer alan ReportGanerator sınıfında hangi SOLID ilkesi ihlal edilmektedir?

```csharp
public class ReportGenerator
{
    public void GenerateExcelReport() { /* Implementation */ }
    public void GeneratePDFReport() { /* Implementation */ }
}
```

- A. Single Responsibility Principle
- B. Open-Closed Principle
- C. Interface Segregation Principle
- D. Dependency Inversion Principle

## Soru 3: IEmployee arayüzünü uyarlayan Intern sınıfı da göz önüne alındığında bu kod parçasında hangi SOLID ilkesi ihlal edilmektedir?

```csharp
public interface IEmployee
{
    void Work();
    void GetSalary();
    void Manage();
}

public class Intern : IEmployee
{
    public void Work() { /* Implementation */ }
    public void GetSalary() { /* Implementation */ }
    public void Manage() { throw new NotImplementedException(); }
}
```

- A. Interface Segregation Principle
- B. Liskov Substitution Principle
- C. Single Responsibility Principle
- D. Open-Closed Principle

## Soru 4: OrderService sınıfı veri tabanı operasyonları için Database sınıfını kullanmaktadır. Sizce hangi SOLID ilkesi ihlal edilmektedir?

```csharp
public class OrderService
{
    private Database _database = new Database();
    
    public void SaveOrder() 
    {
        _database.Save(this);
    }
}

public class Database
{
    public void Save(OrderService orderService) { /* Implementation */ }
}
```

- A. Single Responsibility Principle
- B. Interface Segregation Principle
- C. Open-Closed Principle
- D. Dependency Inversion Principle

## Soru 5 : Yazılım geliştirme metotlarından birisi de Test Driven Development’ dır. Kısaca TDD olarak da isimlendirilir. Bu teknik Red Green Blue olarak adlandırılan bir geliştirme sürecini de benimser. Buna göre aşağıda belirtilen ifadelerden hangisi/hangileri doğrdur?

Red aşaması Fail statüsü olarak bilinir. Bu safhada test kabul kriterleri hata verir. Green aşaması test geliştirme sürecinin ikinci safhasıdır. Birinci aşamada hata alan testin çalışır hale getirilmesi için gerekli kod değişiklikleri yapılır.
Blue aşamasında kabul kriterlerini geçmiş olan testin işlettiği kodlar gözden geçirilir. Refactoring aşaması olarak da bilinir. Birim Test, Test Driven Development yönteminin önemli bir aracıdır.

- A. I ve III
- B. I, II, III
- C. IV
- D. Hepsi

## Soru 6 : Nesne yönelimli programlamanın dört temel prensibi vardır. Encapsulation, Inheritance, Polymorphism, Abstraction. Bu dört prensip farklı yazılım prensipleri ve tasarım kalıplarında(Design Patterns) ön plana çıkan unsurlardır. SOLID ilkelerinin büyük bir kısmı soyutlamaları(abstraction) baz alır ve bu yüzden Interface kullanımları da ön plana çıkar. Aşağıdaki kod parçasında birbirlerine sıkı sıkıya bağlı(tightly coupled) bileşenler söz konusudur. Üst modül ile alt modül arasındaki bu bağımlılığı gevşetmek(loosely coupled) yani bağımlılığı tersine çevirmemiz gerekmektedir. Şıklardan hangisi en doğru yaklaşımdır?

```csharp
public class Notification
{
    private EmailSender _emailSender = new EmailSender();
    
    public void Send(string message)
    {
        _emailSender.SendEmail(message);
    }
}

public class EmailSender
{
    public void SendEmail(string message) { /* Implementation */ }
}
```

- A. Notification bağımsız hale gelmeli ve EmailSender'dan soyutlanmalıdır.
- B. EmailSender yerine Notification sınıfı doğrudan SMTP protokolüne bağlanmalıdır.
- C. Notification sınıfı bir interface üzerinden EmailSender sınıfına erişmelidir.
- D. Notification ve EmailSender tek bir sınıfta birleştirilmelidir.

## Soru 7: Geliştirilmekte olan e-ticaret sisteminde programcı olarak görev aldığımızı düşünelim. Kullanıcıların farklı ödeme yöntemleriyle (kredi kartı, PayPal, banka havalesi) işlem yapmasını sağlayan PaymentProcessor isimli bir sınıf kodu için Review yapmamız isteniyor.

```csharp
public class PaymentProcessor
{
    public void ProcessPayment(string paymentType, decimal amount)
    {
        if (paymentType == "CreditCard")
        {
            // Kredi kartı işlemleri
        }
        else if (paymentType == "PayPal")
        {
            // PayPal işlemleri
        }
        else if (paymentType == "BankTransfer")
        {
            // Banka havalesi işlemleri
        }
    }
}
```

Bu sınıfın mevcut haliyle bazı prensipleri ihlal ettiğini fark ediyorsunuz. Hangi prensiplerin ihlal edildiğini analiz ediniz ve kodu iyileştirmek için olası en doğru yaklaşımı seçiniz.

- A. Single-responsibility Principle(SRP) ve Open-closed Principle(OCP) ihlal ediliyor. Yeni bir ödeme yöntemi eklendiğinde PaymentProcessor sınıfı değiştirilmek zorunda kalıyor. Bu yüzden her ödeme yöntemi için ayrı bir sınıf oluşturulmalı ve bunlar IPayment gibi bir arayüz üzerinden yönetilmelidir.
- B. Interface Segregation Principle(ISP) ihlal ediliyor. Her ödeme türü için farklı arayüzler oluşturulmalıdır.
- C. Dependency Inversion Principle(DIP) ihlal ediliyor. Ödeme işlemleri için bağımsız bir interface tanımlanmalı ve PaymentProcessor bu interface’e bağımlı olmalıdır.
- D. Liskov Substitution Principle(LSP) ihlal ediliyor. ProcessPayment metodu yerine, her ödeme türü kendi türüne göre farklı davranmalıdır.

## Soru 8: Bir kargo takip sistemi geliştirdiğimizi düşünelim. Sistem farklı kargo firmaları için gönderi durumunu gösteren aşağıdaki fonksiyonelliği içeriyor.

```csharp
public class CargoTracker
{
    public string TrackPackage(string courier, string trackingNumber)
    {
        if (courier == "DiEycEL")
        {
            return "DiEycEL package status: Delivered.";
        }
        else if (courier == "OUPS")
        {
            return "OUPS package status: In transit.";
        }
        else if (courier == "FEDEEEx")
        {
            return "FEDEEEx package status: Pending.";
        }
        return "Unknown courier.";
    }
}
```

Ancak ilerleyen zamanlarda sisteme yeni kargo firmalarının eklenmesi gündemde. Kodun yönetilebilirliğini güçlendirmek ve SOLID ilkelerine uyumluluğunu sağlamak için aşağıdaki şıklarda belirtilen yöntemlerden hangisini ele almak daha doğrudur?

- A. Open-closed Principle(OCP) ihlal ediliyor. Yeni bir kargo firması eklendiğinde mevcut metot değiştirilmek zorunda kalıyor. Bu sorunu çözmek için bir soyutlama (ICourier) tanımlanmalı ve her firma bu soyutlamayı implemente etmelidir.
- B. Liskov Substitution Principle(LSP) ihlal ediliyor. Kargo firmaları arasında yanlış tür dönüşümleri yapıldığında sistem çöker. Bu nedenle tüm kargo firmaları aynı türe dönüştürülmelidir.
- C. Interface Segregation Principle(ISP) ihlal ediliyor. Kargo firmalarının takip işlemleri için ayrı ayrı arayüzler oluşturulmalıdır.
- D. Single-responsibility Principle(SRP) ihlal ediliyor. CargoTracker sınıfı kargo firmalarının işletim detaylarını içeriyor, bu yüzden kargo firması detaylarıyla ilgilenmesi için ayrı bir sınıf oluşturulmalıdır.

## Soru 9: Bir kütüphane yönetim sistemi geliştirdiğinizi düşünün. Sistemde kitap bilgilerini veritabanına kaydeden BookManager isimli bir sınıf var. Mevcut tasarımda hem kitapların veritabanına kayıt edilmesi ile ilgileniyor hem de veritabanı erişimi doğrudan sınıfa bağımlı bir şekilde gerçekleştiriliyor. Bu, Single Responsibility Principle(SRP) ve Dependency Inversion Principle(DIP) ihlallerine neden oluyor. Bu durumu düzeltmek için aşağıdaki çözüm önerilerinden hangisini tercih edersiniz?

- A.
```csharp
public interface IDataAccess
{
    void Save(string title, string author);
}

public class BookManager : IDataAccess
{
    public void Save(string title, string author)
    {
        Console.WriteLine($"Book '{title}' by {author} saved to database.");
    }
}
```

- B.
```csharp
public class Book
{
    public string Title { get; set; }
    public string Author { get; set; }
}

public class BookManager
{
    private DatabaseAccess _databaseAccess = new DatabaseAccess();

    public void AddBook(Book book)
    {
        _databaseAccess.Save(book);
    }
}

public class DatabaseAccess
{
    public void Save(Book book)
    {
        Console.WriteLine($"Book '{book.Title}' by {book.Author} saved to database.");
    }
}
```

- C.
```csharp
public class Book
{
    public string Title { get; set; }
    public string Author { get; set; }
}

public interface IDataAccess
{
    void Save(Book book);
}

public class DatabaseAccess : IDataAccess
{
    public void Save(Book book)
    {
        Console.WriteLine($"Book '{book.Title}' by {book.Author} saved to database.");
    }
}

public class BookManager
{
    private readonly IDataAccess _dataAccess;

    public BookManager(IDataAccess dataAccess)
    {
        _dataAccess = dataAccess;
    }

    public void AddBook(Book book)
    {
        _dataAccess.Save(book);
    }
}
```

- D.
```csharp
public class BookManager
{
    public void SaveToDatabase(string title, string author)
    {
        Console.WriteLine($"Book '{title}' by {author} saved to database.");
    }
}
```

## Soru 10: Bir oyun geliştirdiğimizi düşünelim. Oyunda farklı türden karakterler yer alıyor(savaşçı, büyücü, okçu vb) ve her karakterin kendine özgü bir saldırı yöntemi bulunuyor. Şu anda saldırı işlemi her karakter türü için ayrı ayrı yönetiliyor. Bu, yeni karakter türleri eklemek istediğimizde kodda değişiklik yapma ihtiyacı doğuruyor ve genişletilebilirliği sınırlıyor. Bu durumu çözmek için Polymorphism ve Inheritance prensiplerini kullanacağınız bir yöntemle ilerlemek istiyorsunuz. Aşağıdaki çözüm önerilerinden hangisini tercih edersiniz?

- A.
```csharp
public class Game
{
    public void PerformAttack(string characterType)
    {
        switch (characterType)
        {
            case "Warrior":
                WarriorAttack();
                break;
            case "Mage":
                MageAttack();
                break;
            case "Archer":
                ArcherAttack();
                break;
            default:
                Console.WriteLine("Unknown character type.");
                break;
        }
    }

    private void WarriorAttack()
    {
        Console.WriteLine("Warrior swings a sword!");
    }

    private void MageAttack()
    {
        Console.WriteLine("Mage casts a fireball!");
    }

    private void ArcherAttack()
    {
        Console.WriteLine("Archer shoots an arrow!");
    }
}
```

- B.
```csharp
public abstract class Character
{
    public abstract void Attack();
}

public class Warrior : Character
{
    public override void Attack()
    {
        Console.WriteLine("Warrior swings a sword!");
    }
}

public class Mage : Character
{
    public override void Attack()
    {
        Console.WriteLine("Mage casts a fireball!");
    }
}

public class Archer : Character
{
    public override void Attack()
    {
        Console.WriteLine("Archer shoots an arrow!");
    }
}

public class Game
{
    public void PerformAttack(Character character)
    {
        character.Attack();
    }
}
```

- C.
```csharp
public class Warrior
{
    public void SwingSword()
    {
        Console.WriteLine("Warrior swings a sword!");
    }
}

public class Mage
{
    public void CastFireball()
    {
        Console.WriteLine("Mage casts a fireball!");
    }
}

public class Archer
{
    public void ShootArrow()
    {
        Console.WriteLine("Archer shoots an arrow!");
    }
}

public class Game
{
    public void PerformAttack()
    {
        Warrior warrior = new Warrior();
        Mage mage = new Mage();
        Archer archer = new Archer();

        warrior.SwingSword();
        mage.CastFireball();
        archer.ShootArrow();
    }
}
```

- D.
```csharp
public class Game
{
    public void PerformAttack(string characterType)
    {
        if (characterType == "Warrior")
        {
            Console.WriteLine("Warrior swings a sword!");
        }
        else if (characterType == "Mage")
        {
            Console.WriteLine("Mage casts a fireball!");
        }
        else if (characterType == "Archer")
        {
            Console.WriteLine("Archer shoots an arrow!");
        }
    }
}
```

## Cevap Anahtarı

1. B (10 Puan)
2. A (5 Puan)
3. A (10 Puan)
4. D (10 Puan)
5. D (10 Puan)
6. C (10 Puan)
7. A (10 Puan)
8. A (10 Puan)
9. C (15 Puan)
10. B (10 Puan)
