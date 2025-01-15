# C# ile Nesne Yönelimli Programlamanın Temelleri

Sektör Kampüste projesi kapsamında 2024-2025 güz dönemi İTÜ Matematik Mühendisliği 4ncü Sınıf öğrencileri için açılmış derse ait notları içermektedir.

- [C# ile Nesne Yönelimli Programlamanın Temelleri](#programming-with-csharp)
  - [Ders 00: .Net Platformunun Tanıtımı, Ortam Gereksinimleri ve Hello World Uygulaması](#ders-00-net-platformunun-tanımıtı-ortam-gereksinimleri-ve-hello-world-uygulaması)
  - [Ders 01: Temel Veri Türleri, Class ve Struct Tanımlamaları](#ders-01-temel-veri-türleri-class-ve-struct-tanımlamaları)
  - [Ders 02: Metotlar, Karar Yapıları, Basit Döngüler ve Debug İşlemleri](#ders-02-metotlar-karar-yapıları-basit-döngüler-ve-debug-i̇şlemleri)
  - [Ders 03: Kalıtım Konusuna Giriş, Exception Hiyerarşisi ve Exception Handling](#ders-03-kalıtım-konusuna-giriş-exception-hiyerarşisi-ve-exception-handling)
  - [Ders 04: Abstract ve Interface Türleri, Çok Biçimlilik Kavramı](#ders-04-abstract-ve-interface-türleri-çok-biçimlilik-kavramı)
  - [Ders 05: Bileşenler Arası Bağımlılıkların Yönetimi](#ders-05-bileşenler-arası-bağımlılıkların-yönetimi)
  - [Ders 06: Library Geliştirme, Genişletilebilir Uygulamalar ve SOLID Prensiplerinin Temelleri](#ders-06-library-geliştirme-genişletilebilir-uygulamalar-ve-solid-prensiplerinin-temelleri)
    - [JSON Serileştirme ve DTO Senaryosu](#json-serileştirme-ve-dto-senaryosu)
  - [Ders 07: Yüksek Kalite Kodlama için Unit Test](#ders-07-unit-test)
  - [Ders 08: Birim Testlerde Soyutlamalar ve Mock Kütüphane Kullanımları](#ders-08-birim-testlerde-soyutlamalar-ve-mock-kütüphane-kullanımları)
  - [Ders 09: Delegate Tipi, Extension Methods ve LINQ](#ders-09-delegate-tipi-extension-methods-ve-linq)
  - [Ders 10: Delegate Tipi ile Event Kullanımları ve Attribute Kavramı](#ders-10-delegate-tipi-ile-event-kullanımları-ve-attribute-kavramı)
  - [Ders 11: Metadata Programlama, Attribute ve Reflection](#ders-11-metadata-programlama-attribute-ve-reflection)
  - [Ders 12: Dönem Projelerinin Kontrolü](#ders-12-dönem-projelerinin-kontrolü)
  - [Çerezlik Kod Pratikleri](#çerezlik-kod-pratikleri)
  - [Free Zone](#free-zone)
  - [Kaynak Önerileri](#kaynak-önerileri)
  - [Dönem Ödevleri](#dönem-ödevleri)
  - [Vize Sınavı Soruları](#vize-sınavı-soruları)
  - [Final Sınavı Soruları](#final-sınavı-soruları)

## Ders 00 _(.Net Platformunun Tanımıtı, Ortam Gereksinimleri ve Hello World Uygulaması)_

Bu ilk dersteki amacımız standart bir Hello World uygulamasından ziyade dersin ana konularından olan nesne kavramını anlamaya çalışmaktır. Nesne yönelimli dil konsepti _(Object Oriented Programming)_ gerçek hayat iş modellerinin kurgulanmasında büyük kolaylıklar sağlar. Bu açıdan bakıldığıda her hangibir şeyi nesnel olarak modellemek mümkündür. Bu felsefeyi kavramak soyut kavramları nedeniyle çoğu zaman zordur. Bu nedenle ders için verilen proje ödevlerinin tutulduğu JSON bazlı dosya üzerine basit bir iş modeli kurgusu tartışılmıştır. Data.json içerisinde yer alan her bir projeyi programatik ortamda başka object user'ların _(ya da diğer programcıların)_ da kullanabilmesi için nasıl bir yol izlenebilir? İşte burada kendi veri modelimizin tasarımını yapmamız gerektiği kararına varabiliriz.

Örnekte tasarlanmış olan Homework sınıfı bu işi üstlenir. Çok basit anlamda JSON dosyasındaki bir içeriğin nesnel izdüşümünü tanımlar. Ödevlerin benzersiz IDsi, başlığı, açıklaması ve seviye puanı sınıfın birer özelliği olur. Bu görsel olarak aşağıdaki çizelgede olduğu gibi ifade edilebilir.

![image](https://github.com/user-attachments/assets/79a783ae-777c-4f76-86f9-bc503a604fa0)

Burada kavramları gerçek hayat örneği ile örtüştürmek için ödevlerin başka hangi formatlarda saklanabileceğine değinilir. En nihayetinde saklanan veri için dosya sisteminde farklı standartlar kullanılabilir. İdeal senaryolarda bu bir veritabanı tablosu bile olabilir ama sonuçta programatik ortamdaki izdüşümü, ifade şekli ne olmalıdır?

![image](https://github.com/user-attachments/assets/eb4b4018-a7ea-477e-b825-ac1800e579cd)

JSON _(Javascript Object Notation)_ standartlaşmış bir veri tanımlama kavramıdır. Bir dosya içeriğinde, ağ üzerinde process'ler arası hareket eden paketlerde pekala mantıklıdır ancak programatik ortama gelindiğinde onun işe yarar bir nesne olarak kullanılabilmesi için bir kılavuz işlemi _(mapping)_ gerekir _(İlerleyen derslerde bu konu Serialization, Deserialization işlemleri açısından da değerlendirilir)_

Bu tartışmalarda özelliklere _(Properties)_ erişimi kasıtlı olarak kontrol altına almak ve ileride tartışabileceğimiz verinin doğrulanması ya da static factory metot ile nesnenin kendisinin üretimi için gerekli kavramlar için zemin hazırlanmaya çalışılır. Buna göre şu konular üzerinde durulması mühimdir;

- Private property kullanımı _(Encapsulation)_
- Object Instance kavramı
- Constructor ile nesne örnekleme ve primary constructor kavramı
- Herkesin bir Object olduğu teorisi ve varsayılan ToString davranışının değiştirilmesi

Başlangıçta zor gelen bu konular ilerleyen derslerde daha sık kullanılacağından panik yapmaya gerek yoktur ;)

## Ders 01 _(Temel Veri Türleri, Class ve Struct Tanımlamaları)_

İkinci dersin amacı temel değişkenleri ve **.Net Common Type System** içerisinde [built-in](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/built-in-types) olarak gelen bazı veri türlerini tanımaktır. Konu genellikle türlerin bellekte tutuluş şekli ile ilişkilendirilir. **Stack** ve **Heap** bellek bölgelerinin işleyişi üzerinde durulur. Basit sayısal değerler, metinsel veri türleri, mantıksal olan versiyonlar, karakter türleri ve benzerleri ele alınır.

.Net genel tip sistemi beş ana tür üzerine odaklanır.**Class, struct, enum, interface, delegate**. Duruma göre hangi türün kullanılacağına karar vermek gerekir. [CTS ile ilgili bu adresten genel bilgi alınabilir](https://learn.microsoft.com/en-us/dotnet/standard/base-types/common-type-system)

Odak noktası bir noktada var olan türleri kullanarak kendi komposit türlerimizi inşa etmenin gerekliliğini de ortaya koymaktır. Bir IP adresi basit bir string türü ile ifade edilebileceği gibi herbir parçası byte türü olarak ele alınan bir struct ile de ifade edilebilir. Ya da bir renk bilgisini kullanım amacına göre enum sabiti şeklinde tasarlayabiliriz. Eğer bir grafik uygulama söz konusu ise RGB ve Alpha değerlerini içeren başka bir veri modeli olarak _(struct)_ da tasarlayabiliriz. Tüm bunlar temel veri türlerini kullanarak kendi veri yapılarımızı kurgulayabileceğimiz, yeniden kullanılabilir _(Reusable)_ , güvenilir _(Reliable)_ ve mantıksak bütünlüğe sahip kurgular inşa edilebileceğini gösterir. IP demişken System.Net isimli alanındaki karşılığına da bir bakdın derim :smile:

Struct olarak inşa edilecek nesne modelleri için bazı örnekler verilebilir. Vektörler, kompleks sayılar, dikdörtgen, kare gibi geometrik şekiller, sıcaklık bilgisi, web sitesine giriş yapan kullanıcı vb Görüldüğü üzere herhangi bir kavram bir nesne olarak değer türü _(value type)_ ya da referans türü _(reference type)_ olarak ifade edilebilir.

**Sorular / Araştırma Konuları**

- Solution (sln) ne işe yarar?
- Main metodu hakkında neler söyleyebiliriz?
- Hangi durumlarda programcının kendi türlerini yazması gerekir? _(IP veya RGB mevzusu)_

Bu derste kullanılan bazı terminal satırı komutları aşağıdaki gibidir.

```shell
# Github reposundan proje klonlamak için
git clone https://github.com/buraksenyurt/ProgrammingWithCSharp.git

# Yeni bir solution açmak için
dotnet new sln --name ProgrammingWithCSharp

# dotnet aracı ile yeni bir proje oluşturmak için
dotnet new console -n HelloWorld

# Bu projeyi var olan bir solution içeriğine eklemek için
# Solution klasöründe iken yapmakta yarar var
dotnet sln add HelloWorld

# Git reposuna kodları göndermek için
git push

# Kodları çekmek için
git pull
```

## Ders 02 _(Metotlar, Karar Yapıları, Basit Döngüler ve Debug İşlemleri)_

Bu dersteki amaç nesnelerin işe yarar fonksiyonellikler ile güçlendirilmesi ve bazı temel karar yapıları ile döngüleri öğrenmektir. Bu senaryoları kavramsal bütünlüğü olan **namespace** siloları ve hatta ayrık sınıf kütüphanelerinde _(Class Library)_ inşa etmek de hedefler arasındadır.

Derste **Solution** kavramı ve içeriğinden de bahsedilmiştir. Bir solution içerisinde birden fazla proje barındıran, projeler arasında anlamsal bütünlüğün sağlandığını bir çalışma ortamı olarak düşünülebilir. Bazı platformlarda bu **workspace** olarak da ifade edilebilir.

![image](https://github.com/user-attachments/assets/aa0b10f1-59cc-4a87-ac70-4d377b582c78)

**Metotlar Hakkında**

- Metot Overloading; Aynı isimde olan ama farklı sayıda veya tipte parametre ile çalışan metotlara verilen isimlendirmedir. Örneğin Console.WriteLine buna güzel bir örnektir.
- statik metotlar tanımlandıkları veri yapısının nesne örneğine ihtiyaç duymadan kullanılabilirler.
- Geriye değer döndürmeyen metotlar void olarak tanımlanır. Constructor _(yapıcı metotlar)_ bir istisnadır. Bulunduğu türle aynı adı taşırlar, parametre alabilirler ancak void dahi olamazlar. Amaçları bulunduğu veri modeline ait nesne örneklerini oluşturmaktır.

Derste bonus bölüm olarak debug işlemlerine de değinilir. Kodun çalışma zamanında nasıl çalıştığını görmek açısından debug modda ilerlenir. Debug modda kodun belli uğrak noktaları _(Breakpoint)_ programcı tarafında belirlenebilir. Kod satırlarında ilerlerken **Step Into, Step Over** gibi teknikler kullanılır. Örneğin Step Into ile sıradaki metodun içerisine girilirken, Step Over ile metod çağrısı sonrasındaki satıra geçilir. **F5** ile **breakpoint** noktaları arasında daha hızlı hareket etme imkanı vardır. Debug işlemlerini genelde kodun nasıl çalıştığını gözlemlemek için ya da çalışma zamanındaki problemleri görmek için kullanırız. Programlama dilinin temellerini öğrenme ve çalışma zamanında nasıl hareket ettiğini gözlemlemek için debug önemli bir avktivitedir. Bazı durumlarda üretim ortamlarında meydana gelen sorunların tespiti için de kullanılabilir. Ancak tavsiye edilen çeşitli kabul kriterleri _(assertions)_ ile çalışırlığı test edilmiş kodlar yazmak ve gelişmiş log mekanizmaları ile olası problemleri gözlemlemeyip erken tedbirler almaktır. Günümüz ürünlerinin çoğu birden fazla process üzerine açılan dağıtık yapıdaki kurguları içeririr. Farkı teknolojilerin bir arada ele alındığı büyük sistemlerde hata yönetimi farklı yetkinlikler gerektirebilir.

## Ders 03 _(Kalıtım Konusuna Giriş, Exception Hiyerarşisi ve Exception Handling)_

Bu derse kadar öğrendiklerimizle bir sınıf veya struct modelini inşa edebilir, belli özellikler ekleyebilir, metotlar yardımıyla çeşitli davranışlar kazandırabiliriz. **Encapsulation** kavramını da gördüğümüz için nesne yönelimli dillerin bir diğer prensibi olan kalıtım konusuna değinebiliriz. **Kalıtım _(Inheritance)_** yine soyut bir kavram olduğundan teorik anlatımla öğrenilmesi zor olabilir. Ancak kullanılan platformun kendi dinamikleri içerisinde bu pratiğin sıklıkla uygulandığı gerçek hayat senaryolarına rastlarız. Konuyu .Net platformu açısından düşünelim ve örneğin çalışma zamanında hata yönetimi için kullanılan **Exception** türlerini ele alalım. Var olan Exception hiyerarşisi türetme sistemi üzerine kuruludur. Kendi istisna türlerimizi de Exception sınıfından türeterek oluşturabilir ve çalışma zamanı için ele alınmasını sağlayabiliriz. Aşağıdaki çizelgede bu geniş hiyerarşinin küçük bir parçası basitçe örneklenmiştir.

```text
System.Exception
  + Message : string
  + StackTrace : string
  + ToString() : string
      |
      +--> AccountNotFoundException (Kullanıcı tanımlı bir exception sınıfı)
               + ErrorCode : int
               + GetCustomMessage() : string
```

Bir başka örnek ise Windows Form kontrolleri ile ilgilidir. Arayüzde kullanılan kontrollerin _(Button, TextBox, Label, DataGrid vb)_ belli özellikleri ve davranışları ortaktır. Bu ortaklıklar her tür için yeniden yazılmak yereine üst sınıfta organize edilebilir ve devralınan sınıflarda kullanılabilir ve hatta istenirse davranış alt sınıflarca değiştirilebilir. Aşağıdaki çizelgede bu durum basitçe ele alınmıştır.

```text
System.Windows.Forms.Control
  + Width : int
  + Height : int
  + Render() : void
      |
      +--> ButtonBase
      |        + IsPressed : bool
      |        + OnPress() : void
      |        |
      |        +--> Button
      |        |        + Text : string
      |        |        + OnClick() : void
      |        |
      |        +--> CheckBox
      |                 + IsChecked : bool
      |                 + OnCheck() : void
      |
      +--> Label
               + Content : string
               + SetContent() : void
```

Bir başka güzel örnekse **abstract** tanımlanmış olan **Stream** sınıfıdır. Abstract sınıflar kısaca kendisinden nesne örneklenemeyen ama türetme amacıyla devralan sınıflara bir yol gösteren _(contract tanımlayan da diyebiliriz)_, türeyen sınıfları ortak özellik veya davranışları uygulamaya zorlayan tiplerdir. Stream sınıfı için aşağıdaki basit çizelgeyi göz önüne alabiliriz. Bir stream dosya tabanlı, bellek odaklı veya ağ üzerinde çalıştırılabilir. Temelde hepsi ilgili ortamdan veri okuma veya veri yazma üzerine kendilerine has özelleştirmeler içerir. Belleğe veri yazıp okumak ile ağ soketi üzerinden bunu yapmak ya da fiziki diskten aynı işleri gerçekleştirmek farklı davranışlar olsa de özünde birer Streaming operasyonudur.

```text
System.IO.Stream (abstract)
  + CanRead : bool
  + CanWrite : bool
  + Read() : int
  + Write() : void
      |
      +--> FileStream
      |        + FilePath : string
      |        + OpenFile() : void
      |        |
      |        +--> EncryptedFileStream
      |                 + EncryptionKey : string
      |                 + Decrypt() : void
      |
      +--> MemoryStream
      |        + Capacity : int
      |        + Resize() : void
      |
      +--> NetworkStream
               + NetworkAddress : string
               + Connect() : void
```

İlerleyen derslerde çalışma zamanı kodlarına metadata _(çalışma zamanında kullanılabilecek ek bilgiler)_ eklemek için **Attribute** yapılarından nasıl faydalanabileceğimizi de göreceğiz. Kendi **Attribute** türlerimizi de **Exception** kurgusundakine benzer bir şekilde yazabiliriz. Aşağıda bu türetmenin de basit bir hali vardır.

```text
System.Attribute
  + TypeId : object
  + IsDefaultAttribute() : bool
      |
      +--> MyCustomAttribute
               + Description : string
               + IsValid() : bool

```

Türetmelerde class ve sınıfların farklı bir türü olan **Abstract Class** tipi ile **Interface** türünden yararlanılır. Interface türleri blokları olan özellik veya metotlar içermez. Sadece kendisini implemente eden türlerin uygulaması gereken kuralları tanımlayan bir sözleşme _(contract)_ sağlarlar. **SOLID** prensiplerinin bir çok ilkesinde interface kullanımları tercih edilir. Örneğin Asp.Net Middleware hiyerarşisinde **IMiddleware** isimli interface için basitçe aşağıdakine benzer bir kullanım söz konusudur.

```text
Microsoft.AspNetCore.Http.IMiddleware
  + InvokeAsync(HttpContext) : Task
      |
      +--> AuthenticationMiddleware
      |        + Authenticate() : Task
      |        |
      |        +--> JwtAuthenticationMiddleware
      |                 + ValidateToken() : bool
      |
      +--> LoggingMiddleware
               + LogRequest() : void
               + LogResponse() : void
```

IMiddleware çalışma zamanında web motorunun kullanabileceği middleware olarak isimlendirilen ara katmanların işletim kuralını tanımlar. Buna göre kendi Middleware bileşenimizi sisteme entegre etmek istersek tek yapmamız gereken IMiddleware implementasyonunu yazmak ve uygulama nesnesine bunu bildirmektir. Web motoru bu implementasyonu gördüğünde bizim yazdığımız middleware'in **InvokeAsync** metodunu tetikler. Aşağıdaki çizelgede bu durum gösterilmektedir.

```text
Microsoft.AspNetCore.Http.IMiddleware
  + InvokeAsync(HttpContext, RequestDelegate) : Task
      |
      +--> AuthenticationMiddleware
      |        + InvokeAsync(HttpContext, RequestDelegate) : Task (override)
      |        + AuthenticateUser(HttpContext) : bool
      |        |
      |        +--> JwtAuthenticationMiddleware
      |                 + InvokeAsync(HttpContext, RequestDelegate) : Task (override)
      |                 + ValidateToken(string) : bool
      |
      +--> LoggingMiddleware
      |        + InvokeAsync(HttpContext, RequestDelegate) : Task (override)
      |        + LogRequest(HttpContext) : void
      |        + LogResponse(HttpContext) : void
      |
      +--> PerformanceMiddleware (Custom)
               + InvokeAsync(HttpContext, RequestDelegate) : Task (override)
               + MeasurePerformance(HttpContext) : void
               + LogPerformance(HttpContext, TimeSpan) : void
```

Kalıtım konusunu anlamak önemlidir. Sonraki derste işleyeceğimiz çok biçimli türler oluşturmak için zemin hazırlar. Çok biçimli olmak kısaca ata türün kendisine atanan alt tür nesne örneklerinin davranışlarını icra edebilmesi olarak özetlenebilir.

_Not: Kalıtım(Inheritance) kullanışlı bir yetenek olmakla birlikte bazı durumlarda dez avantajlara sahip olabilir. Örneğin sınıflar arası katı bir yapı olması bir sınıfın her özelliğinin miras alınması demektir ve bu bazen istenen esnekliği engeller. Bu nedenle günümüz modern oyun motorlarında kullanılan ECS(Entity Component System) mekanizmaları kalıtım yerine **Composition over Inheritance** yaklaşımını tercih eder._

Bu derste kendi Exception sınıfımızı türetip basit bir türetme deneyiminden sonra aşağdaki görseli ele alıp GameObject, Plane ve Player ilişkilerini irdeledik.

![image](https://github.com/user-attachments/assets/598c9478-8279-4df0-b782-3dec3720fb66)

GameObject sınıfı kendisinden türeyen oyun sahası aktörleri için ortak özellikler ve metotlar barındırabilir. Bu, türetme kabiliyetinin bir sonucudur. Plane ve Player nesneleri aynı zamanda birer GameObject nesnesidir. Base türde tanımlı özelliklere erişebilirler, metotları kullanabilir, değiştirebilirler ve ayrıca kendilerine has özellik ve metotları da barındırabilirler. Ayrıca Draw operasyonunu bu derste **virtual** olarak tanımladık. Buna göre Draw metodu default bir davranışa sahip olmakla birlikte türeyen sınıflarda istenirse yeniden yazılabilir. Plane için Draw **yeniden yazılmıştır _(override)_** Geldiğimiz noktada GameObject nesnesinin Draw operasyonu üzerinden çok biçimli davranış sergileyebilmesi mümkündür. Örneğin, Plane türünden bir değişken bir GameObject nesnesine atandıktan sonra GameObject nesnesi Plane sınıfında ezilmiş olan Draw operasyonunu işletebilir. Bu, belli davranışları uygulayan alt türleri karşılayan veri listesinde anlam kazanan bir kabiliyettir. Örneğin Level 1'deki oyun nesnenelerinden Draw davranışını sergileyenlerin tamamı için ortak bir fonksiyonda **List< GameObject >** veri türü kullanılabilir. Bu noktada üst tür koleksiyonlarını kullanan sistemlerin alt türlerin mutlaka sahip olması ya da yapması gerekenleri nasıl tanımlayabileceğimiz sorusu ortaya çıkart. Abstract tür ve üye kullanımı ile interface tipi bu noktada önemli rollere sahiptir. Her ikisini önümüzdeki ders inceleyeceğiz.

## Ders 04 _(Abstract ve Interface Türleri, Çok Biçimlilik Kavramı)_

Bu derste ağırlıklı olarak kalıtım _(Inheritance)_ ve çok biçimlilik _(polymorphism)_ üzerinde duruldu. Bunun için abstract sınıf, abstract üyeler ve interface kavramlarına değinildi. Ç**ok biçimlilik _(polymorphism)_** genel olarak çalışma zamanı olan veya genişletilebilir olması istenen kütüphanelerde daha çok anlam kazanan bir kavramdır. Sistemin hangi davranışları işletebileceğini dışarıya bir sözleşme olarak açması olarak da düşünülebilir.

Abstract sınıflar normal sınıflara benzer bir başka deyişle metotlar, özellikler, alanlar vs içerebilir. new operatörü ile örneklenip kullanılamazlar ancak yapıcı metot _(constructor)_ içerbilirler zira bu yapıcı metotlar türeyen tipler tarafından kullanılabilir. Örneklerimizde bu tip bir kullanım da yer alıyor. Abstract tanımlanmış üyeler türeyen sınıflarda ezilmek _(override)_ zorundadır. Bu, bir üyenin üst türde virtual tanımlanmasından farklı bir durumdur. **Virtual** tanımlanmış olan bir fonksiyonellik _istenirse_ alt sınıflarda override edilir ve eğer edilmezse kendi varsayılan davranışını sergiler.

Interface türü iş yapan kod blokları içermez. Sadece kendisini uygulayan türler için yazmaları gereken kuralları belirten bir sözleşme _(contract)_ sunarlar. Hem interface hem de abstract türler kendilerinden türeyen nesneleri taşıyabildiğinden farklı türetme örneklerinin yer aldığı toplu veri kümelerini işlemek kolaylaşır. Bu da uygulamaların kod değişikliğine gerek kalmadan genişletilebilirliğinin yolunu açar. Plug-In'ler geliştirmek, çalışma zamanlarına yeni davranış biçimleri kazandırmak bu ilkenin uygulanmasının bir sonucudur. .Net sistemi içerisinde kullanılan birçok interface türü vardır. Bunların bazıları ile ilgili örnekler **Learning.Interfaces** projesinde yer almaktadır.

## Ders 05 _(Bileşenler Arası Bağımlılıkların Yönetimi)_

Bir önceki dersimizde kalıtım ve polimorfik yapıları incelemiş ve son olarak interface türünün nasıl kullanılabileceğine bakmıştık. Bu dersteki amacımız bileşenler arası bağımlılıkları konuşmak ve özellikle **Dependency Inversion** prensibini öğrenmek olacak.**Bileşenler _(Component)_** kendi işleri ile uğraşan ve bu anlamda belli fonksiyonellikleri icra eden yapıtaşları olarak düşünülebilirler. Çoğu senaryoda bir bileşen bazı işlevleri için farklı bileşenlere ihtiyaç duyar. Hatta bu bileşenler modül bazlı farklı katmanlarda olabilirler. Bileşenler arası bağımlılıkların yönetimi önemli bir konudur. Kodun değişime uğramadan genişletilebilmesi gibi önemli problemlerin çözümünde **sıkı bağlı _(tightly coupled)_** ilişkiler yerine **gevşek bağlı _(loosely coupled)_** bir yaklaşım tercih edilir. Bu soyut konuları daha iyi irdelemek ve kalıtım konusunu da bu çerçevede tekrar etmek için aşağıdaki örnek senaryoyu ele alabiliriz.

![image](https://github.com/user-attachments/assets/a5f4cc08-2865-4f1f-83a7-ba1f228392d0)

Masaüstü uygulamalar için bir form geliştirme ürünü tasarladığımızı düşünelim. Form tasarlayan diğer programcılar için bir framework sunuyoruz. Buna göre kullanabilecekleri bileşenleri hazır olarak vermekteyiz. Örneğin çeşitli türden butonlar, resim içerebilen kutular, metinsel bilgiler barındıran alanları birer bileşen olarak sağlıyoruz. Bunların hemen hepsinde ortak özellikler ve davranışlar yer alıyor. Söz gelimi her kontrolün ekran üzerindeki konumu, benzersiz kimlik tanımlayıcısı _(ID gibi)_ ya da geliştiricinin onu kolayca anlayabileceği bir adı var. Fakat bunlara ek kendilerine has özellikleri de olabilir. Örneğin RadioButton bir Button kontrolüdür ama ekstradan opsiyonların listesini ve hangisinin seçili olduğunu da barındırır. Ya da PictureBox bileşeni de bir kontroldür ama örneğin resmin adresini ya da byte array içeriğini taşıyan bir özelliği de vardır. Dolayısıyla kontroller arasındaki ilişkiyi tesis ederken her şeyin bir Control nesnesi olduğunu ama butonlar, liste kutuları, metin kontrolleri gibi alt nesne gruplarının da olabileceği göz önüne alınmalıdır.

Bileşenler arasındaki ilişkileri çok basit seviyede aşağıdaki gibi tasarladığımızı ifade edebiliriz. Editör tarafından sunulan bütün bileşeneler esasında bir Control nesnesidir. Ortak özellikler Control sınıfında toplanmıştır ve bu sınıf abstract olarak tanımlanmıştır. Bir alt seviyeye inilebileceğini göstermek için Button türevli bileşenler BaseButton sınıfından türetilmiştir. Örneğin Button, RadioButton, LinkButton sınıfları ButtonBase türünden birer Control nesnesidir diyebiliriz. Button'lar ile ortak özellikler içermeyen kontroller ise farklı sınıflarda toplanmıştır. Label, GridBox veya CheckBox gibi. Tüm kontrollerin ekrana çizilmesi gibi ortak bir davranış söz konusudur. Lakin bu davranış örneğin DbConnector için geçerli değildir zira bu nesne ekrana çizdirilmesi gereken bir bileşen değildir. Çizdirme davranışı IDrawable arayüzü üzerinde tanımlanmıştır. Programdaki Form sınıfı basit bir Container görevini icra eder. Kendi içinde n adet Control nesnesi barındırabilir ve bunlardan sadece IDrawable olanları çizer.

![image](https://github.com/user-attachments/assets/727b9072-8171-47bb-80d6-756288072915)

Senaryoda bizi bileşenler arası bağımlılıkları çözmeye itecek nokta kaydetme operasyonudur. Herhangibir t anında designer uygulamasının ekranın o anki halini kaydetmesi beklenir. Buna göre form üzerinde hangi kontrollerin olduğu, nerede konumlandıkları, adları, id bilgileri varsa ekstra değerleri kayıt altına alınmalıdır. Framework sunan taraf bu davranışı bir Interface üzerinde sağlar. Kendi için varsayılan olarak dosyaya kaydetme bileşenini de verir ancak framework'ü kullanan geliştiriciler isterlerse kendi kaydetme davranışlarını içeren bileşenleri çalışma zamanında kullanabilirler. Bu, framework içerisinde Form yönetimini sağlayan çalışma zamanının kendisine enjekte edilen kaydetme bileşeni ile birlikte çalışabilmesi demektir. İşte bu noktada SOLID' in Dependency Inversion ilkesi devreye girerek ilgili bağımlılığın tersine çevrilmesine ve dolayısıyla kapalı sistem kodunu değiştirmeden dışarıdan çalışacağı bileşenin entegre edilebilmesi olanağına kavuşulur. Interface türünün kendisini implemente eden türleri taşıyabilmesi ve bu sebeple polimorfik _(çok biçimli)_ hareket edebilmesi işin çözüldüğü noktadır. Örneğimizde Form bileşeninin bağımlı olduğu kaydetme operasyonu **IPersistence** arayüzü üzerinden **CsvPersistence** ve **DbPersistence** bileşenlerine uygulanmıştır. Bunun için Form sınıfında **Constructor Injection** tekniği ele alınmıştır. Dikkat edileceği üzere kaydetme işinin nasıl yapıldığına dair Form sınıfının herhangi bir fikri yoktur. Kendisine enjekte edilen bileşen ne ise onun Save operasyonunu çağırmaktadır. Dolayısıyla Form sınıfının kaydetme davranışı bileşen bazında kolayca değiştirilebilir.

```csharp
public class Form
    {
        private readonly List<Control> _controls = [];
        private readonly IPersistence _persistence;

        public Form(IPersistence persistence)
        {
            _persistence = persistence;
        }

        public void AddControls(params Control[] controls)
        {
            _controls.AddRange(controls);
        }
        public void LocateAll()
        {
            foreach (Control control in _controls)
            {
                Console.WriteLine($"{control.Id} location set");
            }
        }
        public void DrawAll()
        {
            foreach (Control control in _controls)
            {
                if (control is IDrawable drawable)
                {
                    drawable.Draw();
                }
            }
        }

        public void Save()
        {
            _persistence.Save(_controls);
        }
    }
```

Dikkat edileceği üzere Form sınıfının yapıcı metodu IPersistence arayüzü tarafından taşınabilecek bir nesne alır. Sınıfın gerekli olan noktasında ki bu örnekte Save metodudur, IPersistence'ın çalışma zamanında bağlanmış olan bileşendeki asıl Save metodu işletilir. Bunu Program.cs içerisinde aşağıdaki gibi kullandığımızı ifade edebiliriz.

```csharp
internal class Program
{
    static void Main()
    {
        var csvSaver = new CsvPersistence();

        // var dbSaver = new DbPersistence();
        Form mainForm = new(csvSaver); 

        Button btnSave = new(101, "btnSave", (0, 100))
        {
            Text = "Save"
        };
        Button btnClose = new(102, "btnClose", (0, 500))
        {
            Text = "Close"
        };
        CheckBox chkIsActiveProfile = new(104, "chkIsActive", (0, 10))
        {
            Text = "Is Active Profile",
            IsChecked = true
        };
        Label lblTitle = new(106, "lblTitle", (50, 50))
        {
            Text = "Title"
        };
        LinkButton lnkAbout = new(204, "lnkAbout", (400, 50))
        {
            Url = new Uri("https://www.azon.com.tr/about")
        };
        DbConnector dbConnector = new(90, "dbConnector", (0, 0))
        {
            ConnectionString = "data source=localhost:database=Northwind;integrated security=sspi"
        };

        mainForm.AddControls(btnSave, btnClose, lblTitle, lnkAbout, chkIsActiveProfile, dbConnector);
        mainForm.DrawAll();
        mainForm.Save();
    }
}
```

Bu yaklaşımın bir sonraki seviyesi bu tip bileşen bağımlılıklarını bir **Dependency Injection Container** aracı üzerinden yürütmek olabilir. Bu amaçla DI Container araçları incelenebilir. Microsoft .Net platformunun güncel versiyonları core sürümlerinden bu yana dahili bir DI mekanizması sağlar ancak büyük projelerde yetersiz kaldığı noktalar olabilir. [Autofac](https://www.nuget.org/profiles/Autofac), [Castle Windsor](https://www.nuget.org/packages/castle.windsor/), [Ninject](https://www.nuget.org/packages/ninject/), [SimpleInjector](https://www.nuget.org/packages/simpleinjector/) vb alternatifler düşünülebilir.

**Alternatif Senaryolar**

Yukarıdaki senaryoya alternatif olabilecek farklı konular da ele alınabilir. Bunları aşağıdaki gibi listeleyebiliriz. Tüm bu örnekler kalıtım, polimorfizm, dependency inversion, single responsibility gibi kavramlardan birkaçını ön plana çıkarmak üzere ele alınabilir.

- **Robot Otomasyon Fabrikası:** Robotlar için ortak özellikler ve metotlar Robot isimli bir sınıfta toplanırken AssemblyRobot, TransportRobot, InspectionRobot gibi alt türler tasarlanabilir. Fabrika üretim hattını kontrol eden bir manager sınıf DI prensibi ile değerlendirilir. Robot üretimi ve araştırma için Single Responsbility'yi baz alan RobotBuilder, RobotInspector gibi türler yazılabilir. Sistemde robotlara görev atanır ve icra etmeleri sağlanır. Kendi robotlarımızı sisteme kolayca dahil edebiliriz _(Bu konu ile ilgili olarak FreeZone bölgesindeki RobotFactory isimli projeye bakılabilir)_
- **Elektronik Ticaret Sistemi:** Günlük hayatta sık kullanılan bir senaryo olarak düşünülebilir. Ürünler Product sınıfı ile temsil edilir ve çeşitli kategorilerden olabilir. Kullanıcıları User ve siparişleri de Order isimli sınıflarda ele alabiliriz. Sipariş işlemlerini ele alan PaymentFlow isimli sınıf farklı ödeme yöntemlerini kullanırken DI prensibinden yararlanır. Ödeme şekli örneğin IPayment isimli bir arayüz ile tanımlanır ve PaymentFlow bu arayüz üstünden gelen asıl nesneyi kullanır. Sistemde bir ürün kataloğu oluşturulabilir ve buradan alışveriş yapılması simüle edilebilir. Kullanıcıların puanlarına göre farklı rollere alınmaları sağlanabilir. Rollerin farklılaştırılmasında polimorfizm prensibinden yararlanılabilir.
- **Roll Playing Game Türevi:** Bir oyun dünyasındaki nesneler ve arasındaki etkileşimler ele alınabilir. Örneğin Warrior, Mage, Rogue gibi karakterler Actor isimli bir base sınıftan türeyebilir. Her oyun karakterinin bazı ortak özellikleri Actor sınfından devralınır _(Mana, AttackPower, Health, Defend vb)_ Lakin her oyun karakterinin kendine has Attack ve SpecialSkill uygulaması olur ki burada da polimorfizm devreye girer. Oyundaki bazı sistemler karakterlere bağımlı olmadan çalışmalıdır. Örneğin BattleSystem, boss karaktere bağımlı olmadan çalışabilir. Burada Inventory, BattleSystem, QuestSystem gibi sınıflar single responsibility prensibini uygular ve kendi sorumlulukları ile ilgili işleri yaparlar.
- **Restoran Yönetim Sistemi:** Farklı menülerin ortak özellikleri MenuItem isimli bir sınıfta tutulur. Buradan Drink, Dessert, MainCourse gibi alt türler oluşturulabilir. Siparişleri Order isimli bir sınıf takip ederken bunları mutfağa ileten de Waiter isimli başka bir sınıftır. Menülerdeki farklı türlerin fiyatlandırmasında polimorfizmden yararlanılabilir ve ödeme yöntemleri de dependency inversion prensibi kullanılarak ele alınabilir.

## Ders 06 _(Library Geliştirme, Genişletilebilir Uygulamalar ve SOLID Prensiplerinin Temelleri)_

Bu derste Chapter06 isimli terminal uygulamasında Azon.Web.Persistence ve Azon.Web.Sdk projelerini referans ederek bileşen bazında nasıl genişletme yapabileceğimizi inceledik. Azon.Sdk kendi içerisinde hazır form kontrolleri ve bazı interface tanımlamaları içermekte. Özellikle Form isimli Container sınıfı, Control sınıfından türeyen nesneleri kullanıyor ve t anında kendi verisini kaydetmek için IPersistence arayüzü ile uygulanan Save metodunu çağırıyor. Form sınıfının kontrolleri ve kaydetme işlevleri Sdk üzerinden dışarıya da açık. Dolayısıyla başka bir proje isterse kendi Control türevlerini ya da IPersistence davranışlarını kullanabilir. Chapter06'daki PictureBox, Sdk dışında yazılmış bir nesnedir. Benzer şekilde **JsonPersistence** sınıfı da **IFilePersistence** türevli olup yine Chapter06 projesinde tanımlanmış bir kaydedici bileşendir.

Önceki derslerde nesne yönelimli dil özelliklerinin temellerini değinilmiştir. Son derslerde ise özellikle Single Responsibility ve Depedency Inversion gibi kavramlara hafif geçişler yapılmıştır. Her iki prensip **Robert C. Martin** tarafından ortaya konan ve **SOLID** olarak kısaltılan yazılım geliştirme felsefesinin unsurlarıdır. Bu prensipler temelde yüksek kalite kodlamayı ve sürdürülebilirliği hedefler. Amaç kodun okunabilir, değiştirilebilir, genişletilebilir ve bakımının kolay yapılabilmesini sağlamaktır. Prensipler doğru ve yerinde kullanıldığında test edilebilirliği yüksek, güvenilir, daha az hataya sebep olan kodların üretilmesi mümkün hale gelir. Bu da standartlara uygun bir kodlama tabanının oluşmasına ve olası problemlerin minimize edilmesine zemin hazırlar. Bu dersteki bir diğer amacımız söz konusu prensipleri basit uygulamalar üzerinden incelemektir. Öncelikle her ilke kısaca neyi öğütlüyor bir bakalım.

- SRP _(Single Responsibility Principle)_ : Bir sınıfın yalnızca bir görevi ve bu görevin de yalnızca bir sebebi olmalıdır.
- OCP _(Open/Closed Principle)_ : Sınıflar yeni özelliklere açık, değişikliklere kapalı olmalıdır.
- LSP _(Liskov Substitution Principle)_ : Türetilmiş sınıflar bir üst sınıfın yerine _(türetildikleri sınıf)_ kullanılabilmelidir.
- ISP _(Interface Segregation Principle)_ : Bir interface onun uygulayıcısı olan türlerin ihtiyacı olmayan metotları içermemelidir.
- DIP _(Dependency Inversion Principle)_ : Yüksek seviyeli modüller, düşük seviyeli modüllere bağımlı olmamamlıdır. Tüm bu modüller _(component'ler de olabilir)_ soyutlamalara bağımlı olmalıdır.

İlkeler basit olmasına rağmen bazen birbirlerine karıştırıldığı durumlar da söz konusu olabilir. Bu durumları da kısaca ele almaya çalışalım.

- **SRP ve ISP Karışıklığı:** SRP bir sınıfın tek bir sorumluluğa sahip olmasını gerektirir ve Interface Segregation prensibi de bir arayüz için uygulayıcılarının ihtiyaç duymadığı metotları içermemesi gerektiğini belirtir. Bu bazen birbirlerine karıştırılabilir ama sınıfları SRP'ye uygun hale getirmek arayüzlerin de ISP'ye uygun hale getirilmesi sonucunu doğurur.
- **LSP ve OCP Karışıklığı:** Liskov ilkesi türetilmiş sınıfların türediği taban sınıf gibi davranabilmesini savunur ve bu OCP ile karışabilir ancak şöyle bir durum vardır; LSP'nin ihlal edildiği durumlarda OCP'yi sağlamak pek mümkün değildir.
- **OCP ve DIP Karışıklığı:** Open/Closed ilkesi yeni davranışlar eklemek için mevcut kodun değiştirilmemesini savunurken, Dependency Inversion prensibi bağımlılıkların soyutlanarak sağlanması gerektiğini öğütler. Esasında DIP ile bağımlılıklar soyutlandığında OCP otomatik olarak sağlanmış olur. Bağımlılıkların mümkün mertebe somut sınıflar yerine arayüzler _(interface)_ yardımıyla soyutlanması gerekir.
- **SRP ve OCP Karmaşıklığı:** OCP bir sınıfa yeni davranış eklerken mevcut kodun değiştirilmemesi gerektiğini söyler ve SRP'de bir sınıfın tek bir sorumluluğu olması gerektiğini belirtir. SRP'nin birincil olarak ele alınması sınıfların doğru şekilde bölünmesini de kolaylaştırır ve bu doğal olarak OCP'nin uygulanmasını da kolaylaştırır.

Yukarıda belirtilen ilkeler ile ilgili örnek kod uygulamaları FreeZone bölümünde yer almaktadır _(Learning.SOLID projesi)_

### JSON Serileştirme ve DTO Senaryosu

 _(Bu bölüm final sınavına dahil değildir)_

Chapter06 isimli projede JsonPersistence ile Control nesne koleksiyonlarının JSON formatında kaydedilmesi söz konusudur. Ancak burada bir problem vardır. Control türünden olan nesne topluluğunu bu şekilde serileştirdiğimizde varsayılan olarak sadece Control sınıfının public özellik değerleri serileşir. Ancak Control sınıfından türeyen diğer türevlerin özelliklerinin de JSON serileştirmeye alınması gerekir. Bu tip senaryolarda hedefin ihtiyaç duyduğu verileri taşıyan transfer nesneleri kullanılabilir. **Data Transfer Object _(DTO)_** esasında karmaşık kontrol nesneleri yerine sadece serileştirilmesi istenen özellikler barındıran basit sınıflardır. Sadece veriyi tutarlar ve genellikle katmanlar arasında dolaştırılırlar _(Repository'den Ön yüz tarafına inene kadar verinin dönüştürülüp taşınması gibi)_ Form sınıfı içerisindeki herhangibir Control nesnesinin karşılığı olan bir DTO nesnesine dönüştürülmesi ise sanıldığı kadar kolay olmayabilir. Zira public olmayan özelliklerin alınması için çalışma zamanında bir çözümleme yapılması gerekir.

Burada Control sınıfından türeyen nesnelerin karşılığı olan DTO nesnelerine dönüştürme işlemi için Reflection adı verilen teknik kullanılır. **Reflection**, tipler ve üyeler hakkında çalışma zamanında bilgi almamızı sağlayan bir metodolojidir. Bu yöntemle örneğin bir nesnenin çalışma zamanındaki verisini öğrenebiliriz. Yani bir CheckBox kontrolünün sahip olduğu değerleri çalışma zamanında yakalayabilir ve karşılık olarak bir DTO nesnesinin örneklenmesi için kullanabiliriz. Böylece **JSON** dosyasına Control türevleri değil Dto karşılıkları serileşir. Tam tersi işlem de mümkündür. Yani serileştirilmiş JSON içeriğini DTO nesnelerine **ters serileştirme _(Deserialization)_** ile almak ve bu DTO nesnelerinden asıl Control türevlerine geçmek de kolaydır. Chapter06'da bu işler için **ControlMapper** isimli sınıftan yararlanılmaktadır. Ayrıca JSON serileştirme için **NewtonSoft** nuget paketinden yararlanılmıştır. Zira **System.Text.Json**'dan gelen varsayılan Json serileştirme sınıfı polimorfik yapıları yani alt türleri olan koleksiyonları tüm detayları ile serileştiremeyebilir. Newtonsoft ile gelen serileştiricinin ise bu özelliği vardır. Sonuç itibariyle aşağıdaki gibi bir JSON çıktısı oluşur.

```json
{
  "$type": "System.Collections.Generic.List`1[[Chapter06.Dto.ControlDto, Chapter06]], System.Private.CoreLib",
  "$values": [
    {
      "$type": "Chapter06.Dto.ButtonDto, Chapter06",
      "IsCorneredCurve": false,
      "Text": "Save",
      "BackgroundColor": null,
      "ForegroundColor": null,
      "Id": 101,
      "Name": "btnSave",
      "Position": {
        "$type": "System.ValueTuple`2[[System.Double, System.Private.CoreLib],[System.Double, System.Private.CoreLib]], System.Private.CoreLib",
        "Item1": 0.0,
        "Item2": 100.0
      }
    },
    {
      "$type": "Chapter06.Dto.ButtonDto, Chapter06",
      "IsCorneredCurve": false,
      "Text": "Close",
      "BackgroundColor": null,
      "ForegroundColor": null,
      "Id": 102,
      "Name": "btnClose",
      "Position": {
        "$type": "System.ValueTuple`2[[System.Double, System.Private.CoreLib],[System.Double, System.Private.CoreLib]], System.Private.CoreLib",
        "Item1": 0.0,
        "Item2": 500.0
      }
    },
    {
      "$type": "Chapter06.Dto.LabelDto, Chapter06",
      "Text": "Title",
      "Id": 106,
      "Name": "lblTitle",
      "Position": {
        "$type": "System.ValueTuple`2[[System.Double, System.Private.CoreLib],[System.Double, System.Private.CoreLib]], System.Private.CoreLib",
        "Item1": 50.0,
        "Item2": 50.0
      }
    },
    {
      "$type": "Chapter06.Dto.LinkButtonDto, Chapter06",
      "Url": "https://www.azon.com.tr/about",
      "BackgroundColor": null,
      "ForegroundColor": null,
      "Id": 204,
      "Name": "lnkAbout",
      "Position": {
        "$type": "System.ValueTuple`2[[System.Double, System.Private.CoreLib],[System.Double, System.Private.CoreLib]], System.Private.CoreLib",
        "Item1": 400.0,
        "Item2": 50.0
      }
    },
    {
      "$type": "Chapter06.Dto.CheckBoxDto, Chapter06",
      "Text": "Is Active Profile",
      "IsChecked": true,
      "Id": 104,
      "Name": "chkIsActive",
      "Position": {
        "$type": "System.ValueTuple`2[[System.Double, System.Private.CoreLib],[System.Double, System.Private.CoreLib]], System.Private.CoreLib",
        "Item1": 0.0,
        "Item2": 10.0
      }
    },
    {
      "$type": "Chapter06.Dto.DbConnectorDto, Chapter06",
      "ConnectionString": "data source=localhost:database=Northwind;integrated security=sspi",
      "Id": 90,
      "Name": "dbConnector",
      "Position": {
        "$type": "System.ValueTuple`2[[System.Double, System.Private.CoreLib],[System.Double, System.Private.CoreLib]], System.Private.CoreLib",
        "Item1": 0.0,
        "Item2": 0.0
      }
    },
    {
      "$type": "Chapter06.Dto.PictureBoxDto, Chapter06",
      "ImagePath": "profilePhoto.png",
      "Width": 64,
      "Height": 64,
      "Id": 0,
      "Name": null,
      "Position": {
        "$type": "System.ValueTuple`2[[System.Double, System.Private.CoreLib],[System.Double, System.Private.CoreLib]], System.Private.CoreLib",
        "Item1": 0.0,
        "Item2": 0.0
      }
    }
  ]
}
```

**Not:** Nesneler arası özellik atamaları için yani bir nesnesyi başka bir nesneye dönüştürmek için çeşitli mapper araçları da vardır. AutoMapper, Mapster, TinyMapper gibi bazı Nuget paketleri ile de nesneler arası değişimler kolayca sağlanabilir.

## Ders 07 (Unit Test)

Önceki derslerde nesne yönelimli dil prensiplerine değinildi. Temel ilkeler olan **Encapsulation, Inheritance, Polymorphism** ve **Abstraction** üzerine kurulumuş olan pek çok yazılım prensibi veya davranışı söz konusudur **_(KISS, DRY, YAGNI vb)_** Bunlardan birisi olan **SOLID** ilkeleri _(Önceki derste örneklerle açıklanmıştır)_ aynı zamanda yüksek kalite kod geliştirmek için kullanılan metodolojileri içermektedir. Yüksek kalite kod denildiğinde, okunabilir, kolayca genişletilebilir, genel yazılım geliştirme standartlarına uygun, bakımı kolay, güvenilir ve az hataya sebebiyet veren çözümler kastedilir. **OOP** temellerinin bilinmesi yüksek kalite kodlama için yeterli bir kriter değildir. Bu ilkelerin bazı prensiplerle birlikte ele alınması gerekir. Ayrıca iyi kodlanmış programların önemli özelliklerinden birisi de yüksek seviyede test edilebilirlik oranlarıdır. Pek tabii test edilmiş kod hiç test edilmemiş koda göre çok daha güvenilirdir, zira beklenen çıktıları vermesi testler sayesinde garanti edilmiştir. Yüksek kalite kodlamanın genel kavramları aşağıdaki çizelge ile özetlenebilir.

![image](https://github.com/user-attachments/assets/eae899cc-e3ca-4b49-9303-ea78f3791bac)

Ayrıca nesne yönelimli diller için yüksek kalite kodlama prensiplerini aşağıdaki gösterim ile özetlenebilir.

![image](https://github.com/user-attachments/assets/90fdfbc9-5005-4688-863e-d5963e826836)

Kodun test edilebilir olması, içinde geçen birçok durumun beklenen davranışı sergileyeceğinin ispatı olarak da düşünülebilir. Kodun test edilebilirliği ile ilgili olarak kullanılan önemli yöntemlerden birisi de **birim test _(Unit Test)_** yazmaktır. Bir fonksiyonun olası tüm çalışma durumlarının **çeşitli kabül kriterleri ile _(Acceptence Criteria)_** test edilmesi olarak özetlenebilir. Ancak bazı durumlarda önceden yazılmış business fonksiyonlar için birim testler geliştirmek durumunda kalınır. Söz gelimi günümüz legacy sistemlerinin çoğu birim test içermez ve statik kod tarama araçları bu ürünlerde **Code Coverage** değerlerini **%0**'lar mertebesinde ölçümleyebilir. **Statik kod tarama araçları** bir kod tabanının kalitesini ölçümlemek için sıklıkla kullanılırlar. Özellikle ürünün **teknik borcunu _(Technical Debt)_** ortaya koymak, olası güvenlik açıklarını göstermek, kokan kod olarak da adlandırılan defolarını keştfetmek gibi birçok çıktıyı verirler. 

Diğer yandan ürün kod kalitesi için **Test Driven Development _(TDD)_** gibi teknikler kullanılarak de geliştirme yapılabilir. TDD oldukça önemli bir yazılım geliştirme pratiğidir. Yazılımda test kavramı genel olarak aşağıdaki grafikte görülen piramidle ifade edilir.

![image](https://github.com/user-attachments/assets/e8e44bc7-9360-4179-a8e6-018bbc7ab447)

**TDD _(Test Driven Development)_** yöntemi **Red, Blue, Green** ilkesine göre işletilen bir tekniktir. İlk olarak kabül kriterlerine göre kodlama yapılır ve ilk test **Fail** durumunda kalır. Bu safhada genellikle kullanıllmak istenen bileşenler, metotlar, parametre yapıları veya diğer enstrümanlar belirsizdir. Günümüzün pek çok kod geliştirme editörü _(Visual Studio Code, Visual Studio, IntelliJ IDE, Rustrover vs)_ bu durumda ilgili enstrümanların otomatik olarak oluşturulması için gerekli özellikler sunar _(Söz gelimi önce var olmayan sınıf adı ve çağırılacak metot ile dönüşt değişkeni yazılır ve bunlar ortada olmasa da editör üzerinden oluşturulması sağlanır)_ **Red** aşamasını testin başarılı olması için gerekli kod değişikliklerinin yapıldığı **Green** isimli safha takip eder. Bu aşamada artık testlerin **Success** durumuna geçmesi için gerekli kod değişiklikleri yapılır. **Blue** ile ifade edilen üçüncü ve son aşamada ise ilgili kod parçasının yeniden gözden geçirilip iyileştirilmesi söz konusudur. Bu etkinlik **Code Refactoring** olarak da bilinir.

![image](https://github.com/user-attachments/assets/f33a719c-103c-47da-9a74-dd7ce7c5cc1b)

TDD ile geliştirilen uygulamalarda tüm testler baştan tanımlanmış olduğu için **Code Coverage** değerleri yüksek olan ve beklenen davranışları sergiyeceği garanti edilmiş kodların üretilmesi sağlanır. Bu yaklaşım, geliştirme süresini bir miktar uzatır ve programcılara ters gelen bir bakış açısına sahiptir ancak test yazımları belli bir süre sonrasında ideal hızına ulaşır. **TDD** modelinin önemli avantajlarından birisi de kodda yapılan değişikliklere karşın sistemin vereceği tepkidir. Zira pek çok yazılım geliştirme süreci **Continous Integration/Continous Delivery _(CI/CD)_** gibi süreçleri barındırır. Bu süreçlerde **Unit Test** koşumları otomatik olarak dağıtım hattının _(Deployment)_ bir parçası olarak yürütülür. Çok doğal olarak testleri Fail durumuna düşürecek _(patlatacak)_ kod değişiklikleri bu aşamada ortaya çıkar.

*Bu dersteki örnekler Azon.Business ve Azon.Business.Test projeleri içerisinde yer almaktadır.*

## Ders 08 (Birim Testlerde Soyutlamalar ve Mock Kütüphane Kullanımları)

Birim testlerin gerçek hayat senaryolarındaki önemi üzerinde durulmalıdır. Bu ders konularına geçmeden önce aşağıdaki çizelge ile ilgili olarak konuşulur.

![image](https://github.com/user-attachments/assets/2711fc52-b16d-4fa3-a2b7-b8ae817273ec)

Önceki derste yazılım kod kalitesini artıran unsurlardan birisi olan birim test konusu işlenmiştir. Birim Testi yazılan metotların bulunduğu sınıflar bazen dış komponentlere bağımlı olabilirler. Yani test edilecek metotların kullandığı bileşenler **Tightly Coupled Dependency**'ler içerebilir. **Interface** soyutlamaları ile **Loosely Coupled** hale getirilen dependency'lerin birim testlerde **Mock** nesneler ile yer değiştirilerek kullanılması da mümkündür. Örneğin test edilen bir fonksiyonun kabül kriterlerini karşılamak için içeride kullanılan bir veritabanı operasyonu varsa ve test koşumlarının yapıldığı ortamlarda bu tip dış kaynaklara erişim yoksa/olmaması gerekiyorsa birim testler işletilemez. Ancak veri tabanı operasyonunu üstlenen bileşenin soyutlanması onu taklit eden bir bileşenle testin çalıştırılmasının yolunu da açar. **Mocking** kavramı burada ele alınabilir.

*Not: Bu derste 09ncu bölümün konularına da yer verilmiş olup örnek kodlar Chapter08 projesinde toplanmıştır.*

## Ders 09 (Delegate Tipi, Extension Methods ve LINQ)

C# programlama dilinin kullandığı önemli enstrümanlardan birisi de **Delegate** tipidir. Delegate tipi esasında bir metodu işaret eden **pointer** olarak düşünülebilir. Deleagate tipi sayesinde fonksiyonel programlama argümanları kolayca uygulanabilir. Örneğin metotlara parametre olarak başka metotlar aktarılabilir ya da metotlar bir değişkene eşitlenip çağırılabilir. Pek tabii **closure** olarak da bilinen fonksiyon gövdelerinin değişken olarak kullanılması ya da metotlara parametre olarak geçilmesi de mümkündür. **Delagate** tipi ayrıca **LINQ _(Language INtegrated Query)_** olarak bilinen ve nesne koleksiyonları üzerinde **SQL** ifadelerine benzer sorgular yazılmasında da kullanılır. Bunun haricinde **olay güdümlü programlama _(Event Driven Programming)_** konseptinde de ele alınır. Örneğin stok bilgisinin değişmesi sonnucu object user'ın ele alması beklenen bir aksiyon bu tip olay metodu argümanları ile desteklenebilir. Bu derste **delagate** tipinin nasıl tanımlandığı, **LINQ** sorgularında ne şekilde ele alındığı ve **Extension** metotların bu konudaki yeri ele alınmaktadır. Extension metot aslında var olan bir tipin fonksiyonel olarak genişletilmesi yani yeni kabiliyetler kazandırılması için bir yol sunar. Herhangibir tipin aslında var olmayan bir davranış için asıl kütüphaneyi değiştirmeden eklemeler yapılmasının yolunu açar. Microsoft .Net tarafında özellikle **LINQ** sorguları göz önüne alınırsa var olan koleksiyon tipleri için yazılmış bir çok genişletme metodu olduğu görülür **_(Where, OrderBy, Select vb)_**

.Net tarafında sık kullanılan bazı delegate tiplerinin tanımlamaları aşağıdaki gibidir.

```csharp
public delegate TResult Func<in T, out TResult>(T arg);

public delegate bool Predicate<in T>(T obj);
```

Bu temsiciler generic türlerle çalışır ve aslında işaret edilebilecek bir metodun parametrik yapısını temsil eder. Aşağıdaki örnek kullanımda kendi tanımladığımız delegate tipini kullanan genel bir metot vardır.

```csharp
public delegate bool PredicateDelegate(Game game);

public static class Scenario01
{
    public static List<Game> Search(List<Game> games,PredicateDelegate predicate)
    {
        var result = new List<Game>();

        foreach (var game in games)
        {
            if (predicate(game))
            {
                result.Add(game);
            }
        }

        return result;
    }
}
```

Burada Search metodu PredicateDelegate temsilcisini kullanır. Buna göre Search metoduna Game nesnesi alan ve boolean sonuç döndüren herhangi bir fonksiyon veya kob bloğu _(closure)_ geçilebilir. Örneğin,

```csharp
class Program
{
    static void Main()
    {
        var catalog = new Catalog();
        var games = catalog.LoadGames();

        var resultSet = Scenario01.Search(games, IsStrategyGame);
        resultSet = Scenario01.Search(games, IsUnderrated);
        resultSet = Scenario01.Search(games, g => !g.OnSale);
        resultSet = games.FindAll(g => g.ListPrice > 30);

    }
    static bool IsStrategyGame(Game game)
    {
        return game.Category.Name.ToLower().Contains("strategy");
    }
    static bool IsUnderrated(Game game)
    {
        return game.UserRate < 6;
    }
}
```

Burada games koleksiyonun her elemanı için parametre olarak gelen metotlar _(IsStrategyGame,IsUnderrated)_ çağırılır. Ayrıca OnSale kontrolü yapılan satırda lambda operatörü ile _(=>)_ PredicateDelegate üzerinden bir kod bloğunun Search fonksiyonuna geçilmesi söz konusudur. Esasında kendi yazdığımız bu arama fonksiyonu generic List türünün FindAll metodu ile de karşılanır. FindAll metodu built-in tanımlanmış Predicate temsilcisini kullanır. Where, Select, OrderBy, Sum vb birçok genişletme metodu da _(Extension Methods)_ Func gibi temsilcileri kullanarak nesne koleksiyonlarında her eleman için bir fonksiyonun ya da kod bloğunun çalıştırılmasını mümkün kılar. Fonksiyonel dillerde bu tip davranışlar sıklıkla görülür. Fonksiyonlar değişkenlere atanabilir, fonksiyonlara parametre olarak taşınabilirler. Diğer dillerdeki benzerlikler için High Order Functions konusu araştırılabilir. 

Aşağıdaki kod parçasında çok basit bir genişletme metoduna yer verilmiştir. 

```csharp
public static class StingExtensions
{
    public static string WriteSmart(this string text,char seperator)
    {
        var result = string.Empty;
        for (int i = 0; i < text.Length; i++)
        {
            result += text[i] + seperator.ToString();
        }

        return result;
    }
}
```

Böylece her string değişkeni üzerinden WriteSmart metodunu kullanabiliriz. Normalde String sınıfında böyle bir fonksiyon yoktur ama genişletme metodu tekniği ile eklenebilir ve aşağıdaki gibi çağırılabilir.

```csharp
string motto = "Ne kadar güzel bir gün değil mi?";
Console.WriteLine(motto.WriteSmart('_'));
```

## Ders 10 (Delegate Tipi ile Event Kullanımları ve Attribute Kavramı)

Önceki derste delegate türünden yararlanarak metotlara parametre olarak metotların nasıl aktarılabileceği incelenmiştir. Delegate türünün farklı kullanım alanları da vardır. Örneğinde birden fazla metodun tek bir delegate türü üzerinden çağırılması _(Multicast Delegates)_ ve event mekanizmalarıdır. Nesnelerin state değişikliklerinde, object user'lara ele alabilecekleri olay metotlarının _(event method)_ sağlanmasında da kullanılırlar. Burada verilebilecek en güzel örneklerden birisi görsel arayüz bileşenlerindeki olay metotlarıdır. Örneğin bir metodun tıklanması sonrasın Click isimli event gerçekleşir ve object user isterse bu olaya ilişkin bir metodu programlayabilir. Kendi tasarladığımız Framework kurgularında da, diğer kullanıcıların nesne durumlarındaki değişiklikler ile ilgili uygulayabilecekleri olay metotları _(event methods)_ sağlanabilir.

Bir event bir delegate türü ile ifade edilir. Event'in tetiklenmesi, kendi tanımında yer alan delegate türünün işaret ettiği metotların çağırılması anlamına gelir. Bu metot pek tabii object user tarafından yazılır. .Net kendi içerisinde standart türden olay bildirimleri için generic EventArgs< T > türünü sağlar. Olay metotlarına, olay çağrılarının yapıldığı yerden ekstra veriler de gönderilebilir. Bu genellikle EventArgs olarak da bilinen bir kavramdır. Aşağıda örnek bir olay bildirimi tanımı yer almaktadır.

```csharp
class StockLevelChangedEventArgs
{
    public int OldLevel { get; set; }
    public int Change { get; set; }
}

class StockService
{
    public event EventHandler<StockLevelChangedEventArgs> StockLevelChanged;

    public string Owner { get; set; }

    private int _level;
    public int Level
    {
        get
        {
            return _level;
        }
        set
        {
            var eventArgs = new StockLevelChangedEventArgs
            {
                OldLevel = value,
                Change = _level - value
            };

            _level = value;

            StockLevelChanged?.Invoke(this, eventArgs);
        }
    }
}
```

Bu basit ve temel kurguda StockService sınıfı onu kullanacak taraflara StockLevelChanged isimli bir event desteği sağlar. Buna göre Object User, StockService sınıfı için StockLevelChanged olayına karşılık bir metot tanımlamışsa, her stok değişikliğinde ilgili olay metodu _(event method)_ tetiklenecektir. Sürekli vurguladığımız Object User kullanımı aşağıdaki kod parçasında olduğu gibi örneklenebilir.

```csharp
public static void Main()
{
    var stockServiceLondon = new StockService
    {
        Owner = "London"
    };
    var stockServiceNewYork = new StockService
    {
        Owner = "New York"
    };

    stockServiceLondon.StockLevelChanged += StockService_StockLevelChanged;
    stockServiceNewYork.StockLevelChanged += StockService_StockLevelChanged;
    stockServiceLondon.Level = 90;
    stockServiceLondon.Level -= 5;
    stockServiceNewYork.Level = 45;
}

// Event Method
private static void StockService_StockLevelChanged(object? sender, StockLevelChangedEventArgs args)
{
    if (sender is StockService eventOwner)
    {
        Console.WriteLine($"{eventOwner.Owner}. Stok seviyesinin eski değeri {args.OldLevel}. Değişim {args.Change}");
    }
    else
    {
        Console.WriteLine($"Stok seviyesinin eski değeri {args.OldLevel}. Değişim {args.Change}");
    }
}
```

*Olayların .Net içerisindeki gerçek kullanımına ait örnek olarak [EF Core tarafına](https://learn.microsoft.com/en-us/ef/core/logging-events-diagnostics/events) bakılabilir.*

## Ders 11: Metadata Programlama, Attribute ve Reflection

Bu dersete metadata programlama kavramı ve bunun .Net içerisindeki ele alınış biçimleri üzerinde durulur. Metadata programlamada çalışma zamanında ek bilgiler gönderilmesini sağlayan enstrümanlar söz konusudur. Bu enstrümanlar ile çalışma zamanına otomatik kod çıkartılması, kod manipülasyonu *(Özellikle macro desteği sunan dillerde)* gibi işlemler yapılabilir. Ayrıca çalışma zamanları _(runtime)_ için verilen ekstra bilgiler ile kod akışının değiştirilemsi de sağlanabilir. Örneğin bir sınıfın servis olarak sunulabileceğine karar verilmesi, gelen talebin belirlenmiş yetkilere sahip olup olmadığının anlaşılması _(Authorization)_,  bir nesnenin tablo olarak oluşturulması için gerekli migration planının üretilmesi veya bir IDE'ye yeni özelliklerin kodu değiştirmeden dahil edilmesi _(plug-in tabanlı programlama)_ gibi bir çok durum metadata programlama enstrümanları ile sağlanabilir.

.Net dünyasında bunun için Attribute türünden ve Reflection tekniklerinden yararlanılır. Reflection, çalışma zamanında tipler ve üyeleri hakkında bilgi toplamak ve hatta nesne örneklerini oluşturmak için kullanılır. Buna göre bir çalışma zamanının kendisine bildirilen fonksiyonellikleri içeren nesneleri örneklemesi _(creating object's instance)_ ve işletmesi _(invoke)_ mümkün hale gelir.

Attribute konusunu anlamak için aşağıdaki örnek senaryo üzerinden çalışılabilir.

![image](https://github.com/user-attachments/assets/34473a4a-ce13-4ee4-bacb-eff2575e6fca)

Senaryoda Command Line Interface _(CLI)_ olarak çalışan bir migration aracı göz önüne alınır. Bu aracın çalışma zamanı _(runtime)_ bir kütüphane içerisindeki sınıfı/sınıfları okuyup, seçilen provider'a göre _(Sql Server, Postgresql, Mongodb vs)_ veri ile ilgili şemayı veya enstrümanı oluşturan script'leri hazırlar. Örneğin provider SQL server olarak seçilmişse, onunla ilgili Create Table script'ini hazırlar. Hazırlanan içerik bir migration plan olarak kaydedilir ve örneğin Up, Down gibi komutlarla çalıştırılarak veritabanının hazırlanması veya önceki verisyonuna döndürülmesi sağlanır. Burada program ortamındaki bir model nesnesinin, asıl veri kaynağında oluşturulması için gerekli içeriğin hazırlanmasında Attribute bildirimlerinden yararlanılır. Tablo adı ne olacak hangi şemada duracak, kolonun veri tipi ne olacak, bu kolon bir pimary key' mi vs gibi daha birçok bilgi, ilgili Attribute' lar sayesinde migration aracının runtime'ına taşınır. Aşağıdaki sınıf tanımı Attribute'lar ile bezenmiştir. Attribute'lar derleme aşamasında _(Compile Time)_ koda dahil olur, başka bir runtime ise bu attribute'ları Reflection tekniği ile okuyarak karar verir.

```csharp
[Table(Schema = "Catalog", Name = "Products")]
internal class Product
    : EntityBase
{
    [Column(Name = "p_id", DataType = SqlDataType.BigInt, PrimaryKey = true)]
    public int Id { get; set; }
    [Column(Name = "p_title", DataType = SqlDataType.Nvarchar, Length = 50)]
    public string Title { get; set; }
    [Column(Name = "p_title", DataType = SqlDataType.Decimal)]
    public decimal ListPrice { get; set; }
    [Column(Name = "p_in_stock", DataType = SqlDataType.Bool)]
    public bool InStock { get; set; }
}
```

Reflection oldukça geniş bir konsepttir ve özetle .Net içerisindeki tiplerin, tip üyelerinin tüm metadata bilgilerinin çalışma zamanında okunabilmesi için kullanılır. Bunun için .Net tip sisteminin genel karakteristiklerini bilmekte yarar vardır. Genel hatları ile .Net tarafında geliştirilen bir Solution, içerisinde yer alması muhtemel projeler, bu projeler içerisinde kullanılar tipler _(types)_ ve üyeleri _(members)_ aşağıda şemalar ile özetlenebilir.

![solution_structure](https://github.com/user-attachments/assets/2c1d6030-4689-4134-b429-b7c43f772048)

![reflection_design](https://github.com/user-attachments/assets/84316b47-c9ed-4185-9e14-7b5cb49198ba)

## Ders 12: Dönem Projelerinin Kontrolü

Bu derste dönem projelerinden birkaçı incelenir ve profesyonel anlamda Code Review süreçleri işletilir.

## Çerezlik Kod Pratikleri

Bu bölümde dersler sırasında işlenen konuları pekiştirmek amacıyla kullanılabilecek bazı örnek senaryolara yer verilmektedir. Kodlama pratiğinin artırılması için kullanılabilir.

Senaryo Kodları : Y -> Yellow _(Yani hafifsiklet kod parçaları)_, O -> Orange _(Orta seviye senaryolar)_ , R -> Red _(Bizi iyice zorlayacak senaryolar)_

| Kod       | Konu                                  | Açıklama                                                                             | Kurallar |
|-----------|---------------------------------------|--------------------------------------------------------------------------------------|----------|
| **Y00** | **Nesne Modellemeleri(Class)** |Okuduğunuz kitaplar için bir envanter uygulaması geliştirmektesiniz. Bir kitabın nesnel olarak moddellenmesinde kullanılacak tasarıma ihtiyacınız var. Bu anlamda sizden Book isimli bir sınıf tasarlamanız bekleniyor. |int, string, bool, decimal veri türleri mutlaka kullanılmalı. Kod, bir kitabın bilgilerini string türde özetleyen, kitap fiyatına indirim uygulayan en az iki metot içermeli.|
| **Y01** | **Value Type Tasarlaması(Struct)** |Geliştirmekte olduğumuz iki boyutlu oyunda Vektör değerlerini tutmak istiyoruz. Bunun için bir struct tasarlamanız bekleniyor.|Struct 2 boyutlu düzlemde mutlaka x ve y değerlerini taşımalı. double veri türü kullanılmalı. Bir vektörü birim vektöre dönüştüren, vektör bükülüğünü hesap eden en az iki metot yazılmalı|
| **Y02** | **Terminal ile Çalışmak** |Bu çalışmada bir Console uygulaması oluşturup ekrana en sevdiğiniz çizgi roman/kitap karakterinin bilgilerini yazdırmanız bekleniyor.|Karaktere ait tüm bilgiler öncelikle ayrı değişkenlerde toplanmalı. string, double, char, bool, uint veri türleri mutlaka kullanılmalı. Bilgileri ekrana yazdırma operasyonunu bir metot üstlenmeli |
| **Y03** | **Enum Türü Kullanımı** |Bir web uygulamasının backend tarafında kodlama yapıyorsunuz. İş kurallarını işleten bazı fonksiyonlar HTTP durum kodları ile çalışıyor. HTTP durum kodlarının sayısal anlamlarını bir Enum sabiti olarak tanımlamanız bekleniyor. |Enum sabiti HTTP durum kodlarından en az 5ini karşılamalı. Uygulama kodunda Enum değerine göre ekrana bilgilendirme yapmamızı sağlayacak string türden değer döndüren bir metot bulunmalı.|
| **Y04** | **Metot Kullanımları** |Termianale farklı desenelerde çıktılar veren bir metot geliştirmemiz isteniyor. Örneğin "Merhaba Dünya!" için "m_e_r_h_a_b_a d_ü_n_y_a_!" yazması vb |Parametre olarak stili değiştirilecek string değer alan ve geriye string değer döndüren bir metot olması bekleniyor. Metot parametre olarak nasıl bir formatta çıktı hazırlayacağını da argüman olarak alabilir.|
| **Y05** | **Döngülerin Etkin Kullanımı** |Elimizde birden fazla şehir bilgisinin tutulduğu bir sınıf olduğunu düşünelim. Bu şehir bilgileri List türünden bir koleksiyonda tutuluyor olsunlar _(Reporter sınıfına benzer)_ Belli mevsimlere göre sıcaklık ortalamalarının altına veya üstünde kalan şehirlerin listesini döndüren bir metot yazmamız bekleniyor |Reporter sınıfını baz alabiliriz. List koleksiyonlarının arama işlemleri için zengin metotları vardır ancak bunları kullanmayalım. Basit for veya while, do...while gibi döngülerden yararlanalım.|
| **Y06** | **Interface Kullanımının Temelleri** |Masaüstü uygulamalar geliştirmemizi sağlayan bir program üzerinde çalıştığımızı düşünelim _(Visual Studio kod editörü gibi)_ Senaryoda AzonButton, AzonImageButton, AzonRadioButton, AzonGridButton gibi kendi sınıflarımız olsun. Tüm bu sınıflar için ekrana çizdirme _(Render)_ operasyonunu ortak bir davranış olarak tasarlayalım. Draw operasyonu içeren tüm bileşenler için topluca bu işlevi çalıştıracak döngüyü içeren metodu yazmayı deneyin.|Tüm button kontrollerinin Draw operasyonunu kendince işletmesi ve mutlak suretle içermesi gerekmektedir. Button kontrolleri bizim tarafımızdan tasarlanan basit entity sınıfları olarak düşünülebilir. Id, Position, Text gibi özellikleri olabilir kendilerine has metotları da bulunabilir.|
| **Y07** | **Exception Durumları**  |Depo envanterinde olan ürünlerin yönetildiği bir uygulama kodu üzerinde çalıştığınızı düşünün. Inventory isimli sınıfızda farklı kategorilerdeki ürünlerin stok bilgileri de tutuluyor. Stok bilgileri için ayrı bir veri yapınız var. Stoktaki ürün sayısının eksi değer girilmesi halinde ortama InvalidProductCountException isimli bir exception nesnesi fırlatmanız bekleniyor. |Stok bilgilerini tutan sınıfta kateogori numarası, ürün numarası ve güncel ürün sayısı bilgilerini tutabilirsiniz. Inventory sınıfı bu stok sınıfına ait nesne örneklerinin koleksiyonunu taşımalıdır. Fırlatılan Exception runtime' da _(Console uygulaması olarak tasarlanabilir)_ yakalanmalıdır.|
| **Y08** | | | |
| **Y09** | | | |
| **Y10** | | | |
| **Y11** | | | |
| **Y12** | **Test Pratikleri** |Test Driven Development pratiklerinin kazanılması için yapılan çeşitli kod kataları vardır. Bunlardan birisi de Fizz Buzz problemidir. 0dan 100e kadar sayan bir metot 3 ve 5 ile bölünebilen sayılara bakar. 3 ile bölünenler için ekrana Fizz, 5 ile bölünenler için Buzz, hem 3 hem de 5 ile bölünenler için FizzBuzz yazar.  İstenen şey bu metodu test driven development yaklaşımı ile yazmaktır.|XUnit türünden bir test projesi üzerinde geliştirilmelidir. Proje en az 5 test metodu içermelidir.|
| **O01** | **Polimorfik Nesnelerin Keşfi** |Bu çalışmada bir oyunun anlık halinin kayıt edilmesi üzerine bir süreç söz konusudur. Bir oyunda sahadaki nesneleri yöneten nesnenin kayıt işlemini çalışma zamanından önce belirlenen ortama yazması beklenir. Bazı durumlarda metin tabanlı bir dosyaya bazı hallerde cloud ortamındaki bir servise veya veri tabanına yazdırabilir. |Buradaki tek kural oyun sahasındaki nesneleri tutan container bileşeninin yazma operasyonunu değiştirmek için kodunu değiştirmeden hareket edilmesi gerekliliğidir. Yani kaydetme davranışının değişime kapalı ama genişletilmeye açık bir şekilde tesis edilmesi beklenmektedir. Bu davranış genişletmesi için Interface kullanımı zaruridir|
| **O02** | **Metinsel Veri Manipülasyonları** |Elimizde şöyle bir metinsel içerik olduğunu düşünelim. **{html}{body}{head}Product Info{head}{p}Title: {@model.Title}{p}{br}{p}Description : {@model.Description}{br}{p}List Price : {@model.ListPrice}{p}{body}{html}** Yazacağımız bir runtime da @model ile başlayan yerleri gerçekten bir Product sınıfının verileri ile değiştirmek istiyoruz. Bunu işleten metotu yazmayı deneyiniz|Ortamda bir Product sınıfı olmalı ve ayrıca belirtilen metinsel ifade bir text dosyadan okunmalı. Metodumuz text tabanlı dosyayı almalı ve burada @model ile başlayan kısımları tespit edip doğru Product nesne özellikleri ile değiştirebilmeli.|
| **O03** | **Serileştirme İşleri** |Video oyunları ile ilgili bir almanac üzerinde çalışıyoruz. Kullanıcıdan gelen bilgileri alan ve bunları toplayan bir container nesnemiz bulunuyor. Bu container nesnenin oyunlara ait veri koleksiyonlarını JSON formatında serileştirip kaydetmesini ve gerektiğinde kaydedilmiş dosyadan ters serileştirme usulüyle okumasını bekliyoruz.| Newtonsoft paketi yerine .Net in built-in JSON serileştirme modülü kullanılmalı. Oyunlarla ilgili title, summary, category, release year, popularity point, in stock, platform gibi bilgiler tutulabilmeli. Girişler terminal ekranından yapılabilmeli ve kullanıcı istediği kadar oyun bilgisi girebilmeli. Oyun girdilerinde veri türü kontrolleri mutlak suretle yapılmalı.|
| **O04** | **Genişletme Fonksiyonellikleri** |Bir nesne topluluğu üzerinde filtreleme, sıralama, veri ayrıştırma gibi bazı işlemleri gerçekleştirmek istiyoruz. Burada istenilen türden bir nesne koleksiyonu tasarlanabilir. Bahsedilen fonksiyonellikler içinse LINQ _(Language INtegrated Query)_ sorguları haricinde kendi tasarladığımız metotlardan faydalanılmalıdır. |LINQ ile gelen hazır fonksiyonlar yerine kendi tasarladığımız metotların kullanılması gerekiyor.|
| **O05** | **Yeniden Terminale Dönüş** | Sarı kategoride yer alan 4 numaralı örnek (Y04) program kodunda bir metnin ekrana farklı stillerde yazdırılması için gerekli işlemleri ele alıyor. Yazı stillerine göre işlemlerin nasıl yapılacağı enum sabiti değerlerine karşılık gelen fonksiyonlarda işlenmekte. Ancak yeni bir yazı stili eklenmek istediğimizde WriteBeauty metodunun kodunu değiştirmemiz gerekmekte. Bu kodu değiştirmeden yeni bir yazı stilini Terminal sınıfına nasıl öğretebiliriz? | Örnek çözümde Dependency Inversion prensibinin mutlak suretle kullanılması gerekiyor. Component ilişkisini kurarken Interface kullanımı da gereksinimlerden birisi.|
| **O06** | | | |
| **O07** | | | |
| **O08** | | | |
| **O09** | | | |
| **O10** | | | |
| **O11** | | | |
| **O12** | | | |
| **R01** | **Plug-In Tabanlı Geliştirme** |Bu senaryoda bir programın kodunun değiştirilmeden genişletilebilmesi ele alınır. Örneğin bir grafik uygulamasının standart kütüphanesinde temel resim fonksiyonlarını sunduğunu düşünelim. Gölgeleme, siyah beyaza çevirme gibi efektleri işeten fonksiyonlar olarak düşünebiliriz. Amacımız yalın bir SDK geliştirmek ve buradan sunacağımız imkanlarla bu SDK'yi kullanan taraflara kendi efektlerini de ekleyebilmelerini sağlamak.|Bu örneklte SDK görevi gören bir Class Library, bunu kullanan hayali bir grafik uygulaması _(terminal tabanlı geliştirilebilir)_ söz konusudur. SDK kullanıcısı kendi efektini runtime'a öğretmek için SDK'yi baz alır. Grafik çizim uygulaması _(terminal uygulaması olduğunu bir kez daha hatırlatalım)_ yeni efektleri, SDK'den geliştirilen yeni Class Library' yi kullanarak ele alabilir. Önemli kural, grafik uygulaması _(runtime sahibi)_ yeni efektleri içeren _(ve bunun için SDK kütüphanesini referans eden)_ kütüphaneyi referans etmeden kullanmalıdır.|
| **R02** | **Nesne Bağımlılıklarını Gevşetmek** |Bir bayi otomasyon sistemindeki faturalama süreçlerinin ele alındığı bir modülde geliştirici olarak çalıştığınızı düşünün. Faturanın kendisini bir model nesnesi olarak tasarladınız ve bir başka bileşeniniz de fatura kesme işini üstleniyor. Bir fatura kesildiğinde müşteriye bildirim gönderilmesi isteniyor ancak bu bildirimin nasıl yapılacağı belli değil. SMS ile olabilir, E-Posta gönderimi olabilir, Whatsapp mesajı olabilir veya push notification tarzı yeni bir hizmet kullanılabilir. Bu işin Fatura kesme işini üstlenen component'ten soyutlanarak dışarı alınması ve gevşek bağlı bir bileşen halinde tasarlanması bekleniyor. Senaryo gereği bu gönderim işlemlerinden birden fazlası aynı anda yapılabilir. Yani hem SMS hem e-posta gönderimleri de söz konusu olabilir. Dolayısıyla bileşen bağımlılığının birden fazla dış enstrümanı kullanacak şekilde tesis edilmesi gerekiyor.|Yeni bir gönderim şeklini sisteme eklerken veya önceden tanımlanmış olanları kullanırken fatura kesme operasyonunu üstlenen bileşen kodunda değişiklik yapmamamlıyız.|
| **R03** | **Performanslı İçerik Üretmek** |Bir projede test verisi üretmemiz isteniyor. Test verileri rastgele metinsel içeriklerden oluşan ancak boyutları 2 ila 5 Mb arasında değişen dosyalar olmalı. Dosya sayısı istenen test kümesi için ayrılan fiziki disk alanına göre belirlenmekte. Örneğin 500 Mb lık bir test içeriği için 100 tane 5 mb'lık dosya üretmek gibi. İstenen şey bu üretim işinin mümkün mertebe en hızlı biçimde yapılması. |Dosya üretme işlerini üstlenen bir runtime geliştirilmeli ve dosyalar sıralı olarak değil eş zamanlı olarak üretilebilmeli ve ayrıca her dosyanın içeriği farklı olmalı. Her dosya PREPARED FOR TEST PURPOSE ifadesi ile başlamalı ve bitmeli.|
| **R04** | | | |
| **R05** | | | |
| **R06** | | | |
| **R07** | | | |
| **R08** | | | |
| **R09** | | | |
| **R10** | | | |
| **R11** | | | |
| **R12** | | | |

## Free Zone

Solution içerisinde yer alan Free Zone klasöründe normal ders müfredatı projelerini bozmadan ele aldığımız örnek kütüphanelere yer verilmektedir. Söz gelimi örnek struct tasarımları için Learning.Structs isimli kütühaneden yararlanılabilir ya da .Net standart kütüphanelerinde yer alan Interface kullanımlarını görmek için LearningInterfaces projesine bakılabilir vb

## Kaynak Önerileri

C# dilini nesne yönelimli dil özelliklerini de harmanlayan bazı kaynakların en azından referans olarak kullanılmasında yarar olabilir. Buradaki kitaplarda geçen kavramların birçoğu farklı diller içinde geçerlidir ve ağırlıklı olarak yazılım mühendisliği alanının önemli kavramlarını ele almaktadır.

- **Clean Code.** _Robert C. Martin_
- **Pragmatic Programmer.** _David Thomas, Andrew Hunt_
- **Refactoring: Improving the Design of Existing Code.** _Martin Fowler_
- **Design Patterns: Elements of Reusable Object-Oriented Software.** _Erich Gamma, Richard Helm, Ralph Johnson, John Vlissides_
- **Code Complete 2.** _Steve McConnell_
- **Street Coder.** _Sedat Kapanoğlu_
- **Dependency Injection Principles, Practices, and Patterns.** _Mark Seemann, Steven Van Deursen_
- **AntiPatterns: Refactoring Software, Architectures, and Projects in Crisis.** _William J. Brown, Raphael C. Malveau, Hays W. "Skip" McCormick, Thomas J. Mowbray_
- **Unit Testing Principles, Practices, and Patterns: Effective Testing Styles, Patterns, and Reliable Automation for Unit Testing, Mocking, and Integration Testing with Examples in C#.** _Vladimir Khorikov_

## Dönem Ödevleri

Ders dönemi boyunca öğrencilerden aşağıdaki projelerden birisini seçmeleri ve dönem sonuna kadar teslim etmeleri istenir.

|   Id | Homework                                                  | Summary                                                                                                                                                                                                                                                                      |   Level |
|-----:|:----------------------------------------------------------|:-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|--------:|
|    1 | Inventory Tracking System                                 | Bu projede amaç basit bir envanter takip sistemi geliştirilmesidir.                                                                                                                                                                                                          |      70 |
|    2 | Terminal-Based Dungeon Game                               | Terminalden programın sorduğu sorulara göre oyuncuyu yönlendirilen bir zindan oyunudur. Tek level tasarlanması yeterlidir. Görsel bir öğe içermemektedir.                                                                                                                    |      90 |
|    3 | Random Data Set Generator                                 | Hepimizin derdi bazen rastgele test verisi bulmak olur. Örnek ürün listeleri, kullanıcı profilleri gibi. Bu tip veri setlerini oluşturmayı kolaylaştıran bir programdır.                                                                                                     |      80 |
|    4 | Simple Abstract Syntax Tree (AST) Interpreter             | Oldukça basit seviyede bir dil yorumlayıcı programdır.                                                                                                                                                                                                                       |     100 |
|    5 | Lightweight API Gateway                                   | API Gateway prensiplerini içeren bir yönetim programıdır.                                                                                                                                                                                                                    |      70 |
|    6 | Backend Service Development for Kanban Board Applications | Önyüz tarafında Kanban modelinde çalışan bir arayüz için gerekli fonksiyonellikleri sağlayan bir Web API'dir. Rest veya gRPC şeklinde çalıştırılabilir.                                                                                                                      |      65 |
|    7 | Static Code Quality Analyzer                              | Bir .net uygulama kodunu tarayıp belli başlı kod kalite metriklerini ölçümleyerek raporlayan bir araçtır.                                                                                                                                                                    |     100 |
|    8 | Data Transfer Application Between Different Sources       | Farklı kaynaklar arasında veri taşıması yapılmasını sağlayan yönetici uygulamadır. SSIS (Sql Server Integration Services) benzeri bir uygulamanın çok basit bir sürümüdür.                                                                                                   |      85 |
|    9 | Radio Stations Program                                    | Internet üzerinden yayın yapan radyo programları için offline çalışan bir desktop uygulamasıdır.                                                                                                                                                                             |      60 |
|   10 | E-commerce Cart System                                    | Bir e-ticaret sistesinin sadece alışveriş sepeti modülünün geliştirilmesini içerir. Önyüz tasarımından ziyade arka plandaki model yapılarının tasarımı, bileşenler ve fonksiyonların içeriği önemlidir.                                                                      |      85 |
|   11 | Library Management System (Nuget Clone)                   | Burada Nuget benzeri bir paket yönetim sisteminin benzeri inşa edilir. Paket listeleme, versiyonlama, doküman desteği ve programlara indirebilme özelliklerinin olması yeterlidir.                                                                                           |      90 |
|   12 | Online Multi User Exam/Quiz Platform (Mentimeter Clone)   | Online platformda çalışan öğrenciler için soru setlerinin hazırlanabildiği bir web uygulamasıdır.                                                                                                                                                                            |     100 |
|   13 | Employee Management System                                | Hafifsiklet bir insan kaynakları yönetimi uygulamasıdır. Mavi yakalılar için tasarlanabilir. Organizasyon ağacı desteği olmalıdır.                                                                                                                                           |      65 |
|   14 | Topic Based ChatBot Application                           | Azure platformunun AI kabiliyetleri kullanılarak tasarlanacak ve platforma giren kullanıcılara yardım edebilecek bir chat bot uygulamasıdır                                                                                                                                  |      75 |
|   15 | Stock Market Tracking and Analysis Program                | Piyasa verilerini analiz ederen bir takım sonuçlar üreten ve tavsiyelerde bulunan bir web uygulaması olarak düşünülebilir.                                                                                                                                                   |      60 |
|   16 | Sequential Task Management System                         | Bir sistemdeki planlı işleri çalışıtırıp, yönetiminin de yapılabildiği desktop uygulamasıdır. Web tabanlı olarak da tasarlanabilir.                                                                                                                                          |      90 |
|   17 | Real-Time Data Processing Service                         | Bir veri setini gerçek zamanlı olarak analiz edip sonuç çıkartan servis uygulamasıdır. Performans öncelikli bir uygulama olduğu için paralel çalıştırma veya multitasking gibi özellikler öne çıkar.                                                                         |     100 |
|   18 | Smart Notepad Application (Notion Clone)                  | Notion benzeri bir not tutma uygulaması olarak düşünülebilir. Desktop uygulaması stilinde geliştirilebilir. Notion'daki her özelliği içermesine gerek yoktur ancak notları kalıcı olarak saklama, hatırlatma, önceliklendir ve export/import gibi özellikler barındırabilir. |      70 |
|   19 | Simple 2D Platform Game                                   | OpenGL veya DirectX gibi kütüphanelere erişebilen paketler ile masaüstü windows uygulaması olarak geliştirilebileceği gibi Unity ile de yazılabilir. Tek sahnelik bir platform oyunu olması yeterlidir.                                                                      |      80 |
|   20 | ECS Based Game Engine                                     | Burada asıl amaç ECS (Entity Component System) yapısını kullanan basit bir oyun motorunun inşasıdır. C# dilinin temel enstrümanları ve .net platformunun bazı özellikleri kullanılarak tasarlanmaya çalışılır.                                                               |     100 |

Dönem ödevi ders geçme notunda doğrudan etki eder ve aşağıdaki kriterlere göre puanlanır.

| Criterion                          | Factor |
|------------------------------------|--------|
| Use of OOP Principles              | 30     |
| Originality                        | 5      |
| Model Design                       | 5      |
| Clean Code Factors                 | 20     |
| Warning Counts                     | 15     |
| Memory Consumption                 | 5      |
| User Experience (Only for UI apps) | 5      |
| Tooling                            | 5      |
| Source Code Repo Check             | 10     |
| **Total**                          | **100**|

2024 - 2025 Güz döneminde İTÜ Matematik Mühendisliğinden bu dersi alan değerli meslektaşlarımın geliştirdikleri projelere aşağıdaki adreslerden ulaşabilirsiniz.

- Inventory Tracking System. [https://github.com/ecemerdogan/InventoryTrackingSystem](https://github.com/ecemerdogan/InventoryTrackingSystem) ve [https://github.com/oguzkaanis/MTH_Project](https://github.com/oguzkaanis/MTH_Project)
- Terminal Based Dungeon Game. [https://github.com/CSharpDersi](https://github.com/CSharpDersi)
- Random Dataset Generator. [https://github.com/koraykck/random-test-data-generator](https://github.com/koraykck/random-test-data-generator) ve [https://github.com/denizsahiner/RandomDataGeneratorWeb](https://github.com/denizsahiner/RandomDataGeneratorWeb)
- Backend Service Development for Kanban App. [https://github.com/melaaunn/Kanban-Project/](https://github.com/melaaunn/Kanban-Project/) ve [https://github.com/IsE333/Kanban-Board](https://github.com/IsE333/Kanban-Board)
- Radio Station Program [https://github.com/cinart22/radio_program](https://github.com/cinart22/radio_program) ve [https://github.com/zeynepygc/OfflineRadio](https://github.com/zeynepygc/OfflineRadio)
- E-Commerce Cart System [https://github.com/szgrm/EcomCartService](https://github.com/szgrm/EcomCartService) ve [https://github.com/zaferemre/CartApp-MTH404](https://github.com/zaferemre/CartApp-MTH404)
- Library Management System(Nuget Clone) [https://github.com/efemete1905/MTH404EPROJE](https://github.com/efemete1905/MTH404EPROJE)
- Online Multi User Exam/Quiz Platform [https://github.com/zerenenes18/LetsQuizWeb](https://github.com/zerenenes18/LetsQuizWeb)
- Employee Management System [https://github.com/zeyaladag/OrgChart](https://github.com/zeyaladag/OrgChart)
- Topic Based ChatBot Application [https://github.com/civanaban2/chatbot-project](https://github.com/civanaban2/chatbot-project)
- Sequential Task Management System [https://github.com/kadrcankahvci/Sequential-Task-Management-System](https://github.com/kadrcankahvci/Sequential-Task-Management-System) ve [https://github.com/bkaracali/Task-Manager-Frontend](https://github.com/bkaracali/Task-Manager-Frontend) ve [https://github.com/Zhrurhn/Mathematics-Eng-C-Project-Sequential-Task-Management](https://github.com/Zhrurhn/Mathematics-Eng-C-Project-Sequential-Task-Management)
- Simple 2D Platform Game [https://github.com/batuhancetinkaya1/2D-Platformer-Game](https://github.com/batuhancetinkaya1/2D-Platformer-Game)

## Vize Sınavı Soruları

Sorular ve cevaplar [Midterm.md](Midterm.md) isimli dokümanda yer almaktadır.

## Final Sınavı Soruları

Sonradan eklenecek;
