# Programming With CSharp

C# programalama dersi için açılmış olan ve örnek kodları içeren repodur.

- [Başlangıç](#programming-with-csharp)
    - [x] [Chapter 00](#ders-00)
    - [x] [Chapter 01](#ders-01)
    - [x] [Chapter 02](#ders-02)
    - [x] [Chapter 03](#ders-03)
    - [x] [Chapter 04](#ders-04)
    - [x] [Chapter 05](#ders-05)
    - [ ] [Chapter 06](#ders-06)
    - [ ] [Chapter 07](#ders-07)
    - [ ] [Chapter 08](#ders-08)
    - [ ] [Chapter 09](#ders-09)
    - [ ] [Chapter 10](#ders-10)
    - [ ] [Chapter 11](#ders-11)
    - [Çerezlik Kod Pratikleri](#çerezlik-kod-pratikleri)
    - [Free Zone](#free-zone)
    - [Kaynak Önerileri](#kaynak-önerileri)
    - [Vize Sınavı Soruları](#vize-sınavı-soruları)
    - [Final Sınavı Soruları](#final-sınavı-soruları)

## Ders 00

Bu ilk dersteki amacımız standart bir Hello World uygulamasından ziyade dersin ana konularından olan nesne kavramını anlamaya çalışmaktır. Nesne yönelimli dil konsepti _(Object Oriented Programming)_ gerçek hayat iş modellerinin kurgulanmasında büyük kolaylıklar sağlar. Bu açıdan bakıldığıda her hangibir şeyi nesnel olarak modellemek mümkündür. Bu felsefeyi kavramak soyut kavramları nedeniyle çoğu zaman zordur. Bu nedenle ders için verilen proje ödevlerinin tutulduğu JSON bazlı dosya üzerine basit bir iş modeli kurgusu tartışılmıştır. Data.json içerisinde yer alan her bir projeyi programatik ortamda başka object user'ların _(ya da diğer programcıların)_ da kullanabilmesi için nasıl bir yol izlenebilir? İşte burada kendi veri türümüzün tasarımını yapmamız gerektiği kararına varabiliriz.

Örnekte tasarlanmış olan Homework sınıfı bu işi üstlenir. Çok basit anlamda JSON dosyasındaki bir içeriğin nesnel izdüşümünü tanımlar. Ödevlerin benzersiz IDsi, başlığı, açıklaması ve seviye puanı sınıfın birer özelliği olur. Bu görsel olarak aşağıdaki çizelgede olduğu gibi ifade edilebilir. 

![image](https://github.com/user-attachments/assets/79a783ae-777c-4f76-86f9-bc503a604fa0)

Burada kavramları gerçek hayat örneği ile örtüştürmek için de ödevlerin başka hangi formatlarda saklanabileceğine değinilmelidir. En nihayetinde saklanan veri için dosya sisteminde farklı standartlar kullanılabilir. İdeal senaryolarda bu bir veritabanı tablosu bile olabilir ama sonuçta programatik ortamdaki izdüşümü, ifade şekli ne olmalıdır?

![image](https://github.com/user-attachments/assets/eb4b4018-a7ea-477e-b825-ac1800e579cd)

JSON _(Javascript Object Notation)_ standartlaşmış bir veri deseni kavramıdır. Bir dosya içeriğinde, ağ üzerinden gidip gelen bir pakette pekala mantıklıdır ancak programatik ortama gelindiğinde onun işe yarar bir nesne olarak hareketi için bir kılavuz işlemi _(mapping)_ gerekir _(İlerleyen derslerde bu konu Serialization, Deserialization işlemleri açısından da değerlendirilmelidir)_

Bu tartışmalarda özelliklere _(Properties)_ erişimi kasıtlı olarak kontrol altına almak ve ileride tartışabileceğimiz verinin doğrulanması ya da static factory metot ile nesnenin kendisinin üretimi için gerekli kavramlar için zemin hazırlanmaya çalışılır. Buna göre şu konular üzerinde durulması mühimdir;

- Private property kullanımı _(Encapsulation)_
- Object Instance kavramı
- Constructor ile nesne örnekleme ve primary constructor kavramı
- Herkesin bir Object olduğu teorisi ve varsayılan ToString davranışının değiştirilmesi

Başlangıçta zor gelen bu konular ilerleyen derslerde daha sık kullanılacağından panik yapmaya gerek yoktur ;)

## Ders 01

İkinci dersin amacı temel değişkenleri ve .Net Common Type System içerisinde [built-in](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/built-in-types) olarak gelen bazı veri türlerini tanımaktır. Konu genellikle türlerin bellekte tutuluş şekli ile ilişkilendirilir. Stack ve Heap bellek bölgelerinin işleyişi üzerinde durulur. Basit sayısal değerler, metinsel veri türleri, mantıksal olan versiyonlar, karakter türleri ele alınır.

.Net genel tip sistemi beş ana tür üzerine odaklanır. Class, struct, enum, interface, delegate. Duruma göre hangi türün kullanılacağına karar vermek iyi olacaktır. [CTS ile ilgili bu adresten genel bilgi alınabilir](https://learn.microsoft.com/en-us/dotnet/standard/base-types/common-type-system)

Odak noktası bir noktada var olan türleri kullanarak kendi türlerimizi inşa etmenin gerekliliğini de ortaya koymaktır. Bir IP adresi basit bir string türü ile ifade edilebileceği gibi herbir parçası byte türü olarak ele alınan bir struct ile de ifade edilebilir. Ya da bir renk bilgisini kullanım amacına göre enum sabiti şeklinde tasarlayabiliriz. Eğer bir grafik uygulama söz konusu ise RGB ve Alpha değerlerini içeren başka bir veri modeli olarak _(struct)_ da tasarlayabiliriz. Tüm bunlar temel veri türlerini kullanarak kendi veri yapılarımızı kurgulayabileceğimiz, yeniden kullanılabilir _(Reusable)_ , güvenilir _(Reliable)_ ve mantıksak bütünlüğe sahip kurgular inşa edilebileceğini gösterir.

IP demişken System.Net isimli alanındaki karşılığına da bir bakdın derim :smile:

Struct olarak inşa edilebilecek bazı nesne modelleri için bazı örnekler verilebilir. Vektörler, kompleks sayılar, dikdörtgen gibi geometrik şekiller, sıcaklık, web sitesine giriş yapan kullanıcı vb Görüldüğü üzere herhangi bir kavram bir nesne olarak değer türü _(value type)_ ya da referans türü _(reference type)_ olarak ifade edilebilir.

Sorular / Araştırma Konuları

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

## Ders 02

Bu dersteki amaç nesnelerin işe yarar fonksiyonellikler ile güçlendirilmesi ve bazı temel karar yapıları ile döngüleri kullanmaktır. Bu senaryoları kavramsal bütünlüğü olan namepsace siloları ve hatta ayrık sınıf kütüphanelerinde _(Class Library)_ inşa etmek de hedefler arasındadır.

Dersimizde Solution kavramı ve içeriğinden de bahsettik. Bir solution içerisinde birden fazla proje barındıran, projeler arasında anlamsal bütünlüğün sağlandığını bir çalışma ortamı olarak düşünülebilir. Bazı platformlarda bu workspace olarak da ifade edilebilir.

![image](https://github.com/user-attachments/assets/aa0b10f1-59cc-4a87-ac70-4d377b582c78)

**Metotlar Hakkında**

- Metot Overloading; Aynı isimde olan ama farklı sayıda veya tipte parametre ile çalışan metotlara verilen isimlendirmedir. Örneğin Console.WriteLine buna güzel bir örnek teşkil etmektedir.
- statik metotlar tanımlandıkları veri yapısının nesne örneğine ihtiyaç duymadan çalıştırılabilirler.
- Geriye değer döndürmeyen metotlar void olarak tanımlanır. Constructor _(yapıcı metotlar)_ bir istisnadır. Bulunduğu türle aynı adı taşırlar, parametre alabilirler ancak void dahi olamazlar. Amaçları bulunduğu veri modeline ait nesne örneklerini oluşturmaktır. 

Ayrıca debug işlemlerine de değindik. Kodun çalışma zamanında nasıl çalıştığını görmek açısından debug modda ilerlenebilir. Debug modda kodun belli uğrak noktaları _(Breakpoint)_ programcı tarafında belirlenebilir. Kod satırlarında ilerlerken Step Into, Step Over gibi teknikler kullanılabilir. Örneğin Step Into ile sıradaki metodun içerisine girilebilirken, Step Over ile metod çağrısı sonrasındaki satıra geçilebilir. F5 ile breakpoint noktaları arasında da hızlı hareket etmek imkanı vardır. Debug işlemlerini genelde kodun nasıl çalıştığını gözlemlemek için ya da çalışma zamanındaki problemleri görmek için kullanırız. Ancak tavsiye edilen çeşitli kabul kriterleri _(assertions)_ nezninden çalışırlığı test edilmiş kodlar yazmak ve gelişmiş log mekanizmaları ile olası problemleri gözlemlemektir.

## Ders 03

Bu derse kadar öğrendiklerimizle bir sınıf veya struct modelini inşa edebilir, belli özellikler ekleyebilir, bazı metotlar ile fonksiyonellikle ve davranışlar kazandırabiliriz. Encapsulation kavramını da gördüğümüz için nesne yönelimli dillerin bir diğer prensibi olan kalıtım konusuna değinebiliriz. Kalıtım(Inheritance) yine soyut bir kavram olduğunda teorik anlatımla öğrenilmesi zor olabilir. Ancak kullanılan platformun kendi dinamikleri içerisinde bu pratiğin sıklıkla uygulandığı gerçek hayat senaryolarına rastlarız. 

.Net platformu açısından düşünelim. Çalışma zamanında kullanılan Exception türlerini ele alalım. Var olan Exception hiyerarşisi türetme sistemi üzerine kuruludur. Kendi istisna türlerimizi de Exception sınıfından türeterek oluşturabilir ve çalışma zamanı için ele alınmasını sağlayabiliriz. Aşağıdaki çizelgede bu hiyerarşi basitçe örneklenmiştir.

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

Bir başka örnek ise Windows Form kontrolleri ile ilgilidir. Arayüzde kullanılan her kontrolün belli özellikleri ve davranışları ortaktır. Tekrardan yazılmak yerine üst sınıfta organize edilebilir ve devralınan sınıflarda kullanılabilir ve hatta istenirse davranış alt sınıflarca değiştirilebilir. Aşağıdaki çizelgede bu durum basitçe ele alınmıştır.

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

Bir başka güzel örnekte abstract tanımlanmış olan Stream sınıfıdır. Abstract sınıflar kısaca kendisinden nesne örneklenemeyen ama türetme amacıyla devralan sınıflara bir yol gösteren *(contract tanımlayan da diyebiliriz)*, türeyen sınıfları ortak özellik veya davranışları uygulamaya zorlayan tiplerdir. Stream sınıfı için örneğin aşağıdaki basit çizelgeyi göz önüne alabiliriz. Bir stream dosya tabanlı, bellek odaklı veya ağ üzerine çalıştırılabilir. Temelde hepsi ilgili ortamdan veri okuma veya veri yazma üzerine kendilerine has özelleştirmeler içerir. Belleğe veri yazıp okumak ile ağ soketi üzerinden bunu yapmak ya da fiziki diskten aynı işleri gerçekleştirmek farklı davranışlar olsa de özünde birer Streaming operasyonudur. 

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

İlerleyen derslerde çalışma zamanı kodlarına metadata _(çalışma zamanında kullanılabilecek ek bilgiler)_ eklemek için Attribute yapılarından nasıl faydalanabileceğimizi de göreceğiz. Kendi Attribute türlerimizi de Exception kurgusundakine benzer bir şekilde yazabiliriz. Aşağıda bu türetmenin de basit bir hali vardır.

```text
System.Attribute
  + TypeId : object
  + IsDefaultAttribute() : bool
      |
      +--> MyCustomAttribute
               + Description : string
               + IsValid() : bool

```

Türetmelerde class ve sınıfların farklı bir türü olan Abstract Class tipi ile Interface türünden yararlanılır. Interface türleri blokları olan özellik veya metotlar tanımlamazlar. Sadece kendisini implemente eden türlerin uygulaması gereken kuralları tanımlayan bir sözleşme _(contract)_ sağlarlar. SOLID prensiplerinin bir çok ilkesinde interface kullanımları tercih edilir. Örneğin Asp.Net Middleware hiyerarşisinde IMiddleware isimli interface için basitçe aşağıdakine benzer bir kullanım söz konusudur.

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

IMiddleware çalışma zamanında web motorunun kullanabileceği middleware olarak isimlendirilen ara katmanların yazım kuralını tanımlar. Buna göre kendi Middleware'imizi sisteme entegre etmek istersek tek yapmamız gereken IMiddleware implementasyonunu yazmak ve uygulama nesnesine bunu bildirmektir. Web motoru bu implementasyonu gördüğünde bizim yazdığımı middleware'in InvokeAsync metodunu tetikler. Aşağıdaki çizelgede bu durum gösterilmektedir.

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

*Not: Kalıtım(Inheritance) kullanışlı bir yetenek olmakla birlikte bazı durumlarda dez avantajlara sahip olabilir. Örneğin sınıflar arası katı bir yapı olması bir sınıfın her özelliğinin miras alınması demek ve bu bazen istenen esnekliği engelleyebiliyor. Bu nedenle günümüz moder oyun motorlarında kullanılan ECS(Entity Component System) mekanizmaları kalıtım yerine Composition over Inheritance yaklaşımını terchi ediyor.*

Bu derste kendi Exception sınıfımızı türetip basit bir türetme deneyiminden sonra aşağdaki görseli ele alıp GameObject, Plane ve Player ilişkilerini irdeledik.

![image](https://github.com/user-attachments/assets/598c9478-8279-4df0-b782-3dec3720fb66)

GameObject sınıfı kendisinden türeyen oyun sahası aktörleri için ortak özellikler ve metotlar barındırabilir. Bu türetme kabiliyetinin bir sonucudur. Plane ve Player nesneleri aynı zamanda birer GameObject nesnesidir. Base türde tanımlı özelliklere erişebilirler, metotları kullanabilir, değiştirebilirler ve ayrıca kendilerine has özellik ve metotları da barındırabilirler. Ayrıca Draw operasyonunu bu derste virtual olarak tanımladık. Buna göre Draw metodu default bir davranışa sahip olmakla birlikte türeyen sınıflarda istenirse yeniden yazılabilir. Plane için Draw yeniden yazılmıştır(overrider) Geldiğimiz noktada GameObject nesnesinin Draw operasyonu üzerinden çok biçimli davranış sergileyebilmesi mümkündür. Örneğin, Plane türünden bir değişken bir GameObject nesnesine atandıktan sonra GameObject nesnesi Plane sınıfında ezilmiş olan Draw operasyonunu işletebilir. Bu belli davranışı uygulayan alt türleri karşılayan veri listesinden anlam kazanan bir kabiliyettir. Örneğin Level 1'deki oyun nesnenelerinden Draw davranışını sergileyenlerin tamamı için ortak bir fonksiyonda List< GameObject > kullanılabilir. Bu noktada üst tür koleksiyonlarını kullanan sistemlerin alt türlerin mutlaka sahip olması ya da yapması gerekenleri nasıl tanımlayabileceğimiz sorusu ortaya çıkart. Abstract tür ve üye kullanımı ile interface tipi bu noktada önemli rollere sahiptir. Her ikisini önümüzdeki ders inceleyeceğiz.

## Ders 04

Bu derste ağırlıklı olarak kalıtım _(Inheritance)_ ve çok biçimlilik _(polymorphism)_ üzerinde duruldu. Bunun için abstract sınıf, abstract üyeler ve interface kavramlarına değinildi. Çok biçimlilik _(polymorphism)_ genel olarak çalışma zamanı olan veya genişletilebilir olması istenen kütüphanelerde daha çok anlam kazanan bir kavramdır. Sistemin hangi davranışları işletebileceğini dışarıya bir sözleşme olarak açması olarak da düşünülebilir. 

Abstract sınıflar normal sınıflara benzer bir başka deyişle metotlar, özellikler, alanlar vs içerebilir. new operatörü ile örneklenip kullanılamazlar ancak yapıcı metot _(constructor)_ içerbilirler zira bu yapıcı metotlar türeyen tipler tarafından kullanılabilir. Örneklerimizde bu tip bir kullanım da yer alıyor. Abstract tanımlanmış üyeler türeyen sınıflarda ezilmek _(override)_ zorundadır. Bu, bir üyenin üst türde virtual tanımlanmasından farklı bir durumdur. Virtual tanımlanmış olan bir fonksiyonellik _istenirse_ alt sınıflarda override edilir ve eğer edilmezse kendi varsayılan davranışını sergiler. 

Interface türü iş yapan kod blokları içermez. Sadece kendisini uygulayan türler için uygulamaları gereken kuralları belirten bir sözleşme _(contract)_ sunar. Hem interface hem de abstract türler kendilerinden türeyen nesneleri taşıyabildiğinden farklı türetme örneklerinin yer aldığı toplu veri kümelerini işlemek kolaylaşır. Bu da uygulamaların kod değişikliğine gerek kalmadan genişletilebilirliğinin yolunu açar. Plug-In'ler geliştirmek, çalışma zamanlarına yeni davranış biçimleri kazandırmak bu ilkenin uygulanmasının bir sonucudur. .Net sistemi içerisinde kullanılan birçok interface türü vardır. Bunların bazıları ile ilgili örnekler Learning.Interfaces projesinde yer almaktadır.

## Ders 05

Bir önceki dersimizde kalıtım ve polimorfik yapıları incelemiş ve son olarak interface türünün nasıl kullanılabileceğine bakmıştım. Bu derste amacımız bileşenler arası bağımlılıkları konuşmak ve özellikle Dependency Inversion prensibini öğrenmek olacak. Bileşenler (Component) kendi işleri ile uğraşan ve bu anlamda belli fonksiyonellikleri icra eden yapıtaşları olarak düşünülebilirler. Çoğu senaryoda bir bileşen bazı işlevleri için farklı bileşenlere ihtiyaç duyar. Bileşenler arası bağımlılıkları yönetimi önemli bir konudur. Kodun değişime uğramadan genişletilebilmesi gibi önemli problemlerin çözümünde sıkı bağlı (tightly coupled) ilişkiler yerine gevşek bağlı (loosely coupled) bir yaklaşım tercih edilir. Bu soyut konuları daha iyi irdelemek ve kalıtım konusunu da bu çerçevede tekrar etmek için aşağıdaki örnek senaryoyu ele alabiliriz.

![image](https://github.com/user-attachments/assets/a5f4cc08-2865-4f1f-83a7-ba1f228392d0)

Masaüstü uygulamalar için bir form geliştirme ürünü tasarladığımı düşünelim. Formu tasarlayan diğer programcılar için bir framework sunuyoruz. Buna göre kullanabilecekleri bileşenleri hazır olarak da vermekteyiz. Örneğin çeşitli türden butonlar , resim içerebilen kutular, metinsel bilgiler barındıran alanları birer bileşen olarak sağlıyoruz. Bunların hemen hepsinde ortak özellikler ve davranışlar yer alıyor. Söz gelimi her kontrolün ekran üzerindeki konumu, benzersiz kimlik tanımlayıcısı (ID gibi) ya da geliştiricinin onu kolayca anlayabileceği adı var. Fakat bunlara ek kendilerine has özellikleri de olabilir. Örneğin RadioButton bir Button kontrolüdür ama ekstradan opsiyonların listesini ve hangisinin seçili olduğunu da barındırır. Ya da PictureBox bileşeni de bir kontroldür ama örneğin resmin adresini ya da byte array içeriğini taşıyan bir özelliği de vardır. Dolayısıyla kontroller arasındaki ilişkiyi tesis ederken her şeyin bir Control nesnesi olduğunu ama butonlar, liste kutuları, metin kontrolleri gibi alt nesne gruplarının da olduğu göz önüne alınmalıdır.

Burada bileşenler arasındaki ilişkileri çok basit seviyede aşağıdaki gibi tasarladığımızı ifade edebiliriz. Editör tarafından sunulan bütün bileşeneler esasında bir Control nesnesidir. Ortak özellikler Control sınıfında toplanmıştır ve bu sınıf abstract olarak tanımlanmıştır. Bir alt seviyeye inilebileceğini göstermek için Button türevli bileşenler BaseButton sınıfından türetilmiştir. Örneğin Button, RadioButton, LinkButton sınıfları ButtonBase türünden birer Control nesnesidir diyebiliriz. Button'lar ile ortak özellikler içermeyen kontroller ise farklı sınıflarda toplanmıştır. Label, GridBox veya CheckBox gibi. Tüm kontrollerin ekrana çizilmesi gibi ortak bir davranış söz konusudur. Lakin bu davranış örneğin DbConnector için geçerli değildir zira bu nesne ekran çizdirilmesi gereken bir bileşen değildir. Çizdirme davranışı IDrawable arayüzü üzerinde tanımlanmıştır. Programdaki Form sınıfı basit bir Container görevini icra eder. Kendi içinde n adet Control nesnesi barındırabilir ve bunlardan sadece IDrawable olanları çizer.

![image](https://github.com/user-attachments/assets/727b9072-8171-47bb-80d6-756288072915)

Senaryoda bizi bileşenler arası bağımlılıkları çözmeye itecek nokta kaydetme operasyonudur. Herhangibir t anında designer uygulamasının ekranın o anki halini kaydetmesi beklenir. Buna göre form üzerinde hangi kontrolleri olduğu, nerede konumlandıkları, adları, id bilgileri varsa ekstra değerleri kayıt altına alınmalıdır. Framework sunan taraf bu davranışı bir Interface üzerinde sağlar. Kendi için varsayılan olarak dosyaya kaydetme bileşenini de verir ancak framework'ü kullanan geliştiriciler isterlerse kendi kaydetme davranışlarını içeren bileşenleri çalışma zamanında kullanabilirler. Bu, framework içerisinde Form yönetimini sağlayan çalışma zamanının kendisine enjekte edilen kaydetme bileşeni ile birlikte çalışabilmesi demektir. İşte bu noktada SOLID' in Dependency Inversion ilkesi devreye girerek ilgili bağımlılığın tersine çevrilmesine ve dolayısıyla kapalı sistem kodunu değiştirmeden dışarıdan çalışacağı bileşenin entegre edilebilmesi olanağına kavuşulur. Interface türünün kendisini implemente eden türleri taşıyabilmesi ve sebeple polimorfik *(çok biçimli)* hareket edebilmesi işin çözüldüğü noktadır. Örneğimizde Form bileşeninin bağımlı olduğu kaydetme operasyonu IPersistence arayüzü üzerinden CsvPersistence ve DbPersistence bileşenlerine uygulanmıştır. Bunun için Form sınıfından Constructor Injection tekniği ele alınmıştır.

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

Burada dikkat edileceği üzere Form sınıfının yapıcı metodu IPersistence arayüzü tarafından taşınabilecek bir nesne alır. Sınıfın gerekli olan noktasında ki bu örnekte Save metodudur, IPersistence'ın çalışma zamanında bağlanmış olan bileşenindeki asıl Save metodu işletilir. Bunu Program.cs içerisinde aşağıdaki gibi kullandığımızı ifade edebiliriz.

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

Bu yaklaşımın bir sonraki seviyesi bu tip bileşen bağımlılıklarını bir Dependency Injection Container aracı üzerinden yürütmek olacaktır. Bu amaçla DI Container araçları incelenebilir. Microsoft .net platformunun güncel versiyonları core sürümlerinden beri internal bir DI mekanizması sağlar ancak büyük projelerde yetersiz kaldığı noktalar olabilir. Autofac, Windsor Castle, Ninject, SimpleInjector vb alternatifler düşünülebilir.

**Alternatif Senaryolar**

Yukarıdaki senaryoya alternatif olabilecek farklı konular da ele alınabilir. Bunları aşağıdaki gibi listeleyebiliriz. Tüm bu örnekler kalıtım, polimorfizm, dependency inversion, single responsibility gibi kavramlardan birkaçını ön plana çıkarmak üzere ele alınabilir.

- **Robot Otomasyon Fabrikası:** Robotlar için ortak özellikler ve metotlar Robot isimli bir sınıfta toplanırken AssemblyRobot, TransportRobot, InspectionRobot gibi alt türler tasarlanabilir. Fabrika üretim hattını kontrol eden bir manager sınıf DI prensibi ile değerlendirilir. Robot üretimi ve araştırma için Single Responsbility'yi baz alan RobotBuilder, RobotInspector gibi türler yazılabilir. Sistemde robotlara görev atanır ve icra etmeleri sağlanır. Kendi robotlarımızı sisteme kolayca dahil edebiliriz _(Bu konu ile ilgili olarak FreeZone bölgesindeki RobotFactory isimli projeye bakılabilir)_
- **Elektronik Ticaret Sistemi:** Günlük hayatta sık kullanılan bir senaryo olarak düşünülebilir. Ürünler Product sınıfı ile temsil edilir ve türlü kategoride olabilir. Kullanıcıları User ve siparişleri de Order isimli sınıflar da ele alabiliriz. Sipariş işlemlerini ele alan PaymentFlow isimli sınıf farklı ödeme yöntemlerini kullanırken DI prensibinden yararlanır. Ödeme şekli örneğin IPayment isimli bir arayüz ile tanımlanır ve PaymentFlow bu arayüz üstünden gelen asıl nesneyi kullanır. Sistem de bir ürün kataloğu oluşturulabilir ve buradan alışveriş yapılması simüle edilebilir. Kullanıcıların puanlarına göre farklı rollere alınmaları sağlanabilir. Rollerin farklılaştırılmasında polimorfizm'den yararlanılabilir.
- **Roll Playing Game Türevi:** Bir oyun dünyasındaki nesneler ve arasındaki etkileşimler ele alınabilir. Örneğin Warrior, Mage, Rogue gibi karakterler Actor isimli bir base sınıftan türeyebilir. Her oyun karakterinin bazı ortak özellikleri Actor sınfından devralınır _(Mana, AttackPower, Health, Defend vb)_ Lakin her oyun karakterinin kendine has Attack ve SpecialSkill uygulaması olur ki burada da polimorfizm devreye girer. Oyundaki bazı sistemler karakterlere bağımlı olmadan çalışmalıdır. Örneğin BattleSystem, boss karaktere bağımlı olmadan çalışabilir. Burada Inventory, BattleSystem, QuestSystem gibi sınıflar single responsibility prensibini uygular ve kendi sorumlulukları ile ilgili işleri yaparlar.
- **Restoran Yönetim Sistemi:** Farklı menülerin ortak özellikleri MenuItem isimli bir sınıfta tutulur. Buradan Drink, Dessert, MainCourse gibi alt türler oluşturulabilir. Siparişleri Order isimli bir sınıf takip ederken bunları mutfağa ileten de Waiter isimli bir sınıftır. Menülerdeki farklı türlerin fiyatlandırmasında polimorfizmden yararlanılabilir ve ödeme yöntemleri de dependency inversion prensibi kullanılarak ele alınabilir.

# Ders 06

Önceki derslerde nesne yönelimli dil özelliklerinin temellerini inceledik. Son derslerde ise özellikle Single Responsibility ve Depedency Inversion gibi kavramlara hafif geçişler yaptık. Her iki prensip Robert C. Martin tarafından ortaya konan ve S.O.L.I.D. olarak kısaltılan yazılım geliştirme felsefesinin unsurlarıdır. Bu prensipler temelde yüksek kalite kodlamayı ve sürdürülebilirliği hedefler. Amaç kodun okunabilir, değiştirilebilir, genişletilebilir ve bakımının kolay yapılabilmesini sağlamaktır. Prensipler doğru ve yerinde kullanıldığında test edilebilirliği yüksek, güvenilir, daha az hataya sebep olan kodların üretilmesi mümkün hale gelir. Bu da standartlara uygun bir kodlama tabanının oluşmasına ve olası problemlerin minimize edilmesine zemin hazırlar. Bu dersteki amacımız prensipleri basit uygulamalar üzerinden incelemektir. Öncelikle her ilke kısaca neyi öğütlüyor bir bakalım.

- SRP _(Single Responsibility Principle)_ : Bir sınıfın yalnızca bir görevi ve bu görevin de yalnızca bir sebebi olmalıdır.
- OCP _(Open/Closed Principle)_ : Sınıflar yeni özelliklere açık, değişikliklere kapalı olmalıdır.
- LSP _(Liskov Substitution Principle)_ : Türetilmiş sınıflar bir üst sınıfın yerine (türetildikleri sınıf) kullanılabilmelidir.
- ISP _(Interface Segregation Principle)_ : Bir interface onun uygulayıcısı olan türlerin ihtiyacı olmayan metotları içermemelidir.
- DIP _(Dependency Inversion Principle)_ : Yüksek seviyeli modüller, düşük seviyeli modüllere bağımlı olmamamlıdır. Tüm bu modüller _(component'ler de olabilir)_ soyutlamalara bağımlı olmalıdır.

İlkeler basit olmasına rağmen bazen birbirlerine karıştırıldığı durumlar da söz konusu olabilir. Bu durumları da kısaca ele almaya çalışalım.

- **SRP ve ISP Karışıklığı:** SRP bir sınıfın tek bir sorumluluğa sahip olmasını gerektirir ve Interface Segregation prensibi de bir arayüz için uygulayıcılarının ihtiyaç duymadığı metotları içermemesi gerektiğini belirtir. Bu bazen birbirlerine karıştırılabilir ama sınıfları SRP'ye uygun hale getirmek arayüzlerin de ISP'ye uygun hale getirilmesi sonucunu doğurur.
- **LSP ve OCP Karışıklığı:** Liskov ilkesi türetilmiş sınıfların türediği taban sınıf gibi davranabilmesini savunur ve bu OCP ile karışabilir ancak şöyle bir durum vardır; LSP'nin ihlal edildiği durumlarda OCP'yi sağlamak pek mümkün değildir.
- **OCP ve DIP Karışıklığı:** Open/Closed ilkesi yeni davranışlar eklemek için mevcut kodun değiştirilmemesini savunurken, Dependency Inversion prensibi bağımlılıkların soyutlanarak sağlanması gerektiğini öğütler. Esasında DIP ile bağımlılıklar soyutlandığında OCP otomatik olarak sağlanmış olur. Bağımlılıkların mümkün mertebe somut sınıflar yerine arayüzler _(interface)_ yardımıyla soyutlanması gerekir.
- SRP ve OCP Karmaşıklığı: OCP bir sınıfa yeni davranış eklerken mevcut kodun değiştirilmemesi gerektiğini söyler ve SPR'de bir sınıfın tek bir sorumluluğu olması gerektiğini belirtir. SRP'nin birincil olarak ele alınması sınıfların doğru şekilde bölünmesini de kolaylaştırır ve bu doğarl olarak OCP'nin uygulanmasını da kolaylaştırır.

Yukarıda belirtilen ilkeler ile ilgili örnek kod uygulamaları FreeZone bölümünde yer almaktadır.

# Ders 07

**throw new NotImplementedException();**

# Ders 08

**throw new NotImplementedException();**

# Ders 09

**throw new NotImplementedException();**

# Ders 10

**throw new NotImplementedException();**

# Ders 11

**throw new NotImplementedException();**

# Ders 12

**throw new NotImplementedException();**

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

## Vize Sınavı Soruları

Sorular ve cevaplar [Midterm.md](Midterm.md) isimli dokümanda yer almaktadır.

## Final Sınavı Soruları

Sonradan eklenecek;
