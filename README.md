# Programming With CSharp

C# programalama dersi için açılmış olan ve örnek kodları içeren repodur.

- [Başlangıç](#programming-with-csharp)
    - [Chapter 00](#ders-00)
    - [Chapter 01](#ders-01)
    - [Chapter 02](#ders-02)
    - [Çerezlik Kod Pratikleri](#çerezlik-kod-pratikleri)

## Ders 00

Bu ilk dersteki amacımız standart bir Hello World uygulamasından ziyade dersin ana konularından olan nesne kavramını anlatmaya çalışmaktır. Nesne yönelimli dil konsepti _(Object Oriented Programming)_ gerçek hayat iş modellerinin kurgulanmasında büyük kolaylıklar sağlar. Bu açıdan bakıldığıda her hangibir şeyi nesnel olarak modellemek mümkündür.

Bu felsefeyi kavramak soyut kavramları nedeniyle çoğu zaman zordur. Bu nedenle ders için verilen proje ödevlerinin tutulduğu JSON bazlı dosya üzerine basit bir iş modeli kurgusu tartışılmıştır. Data.json içerisinde yer alan her bir projeyi programatik ortamda başka object user'ların da kullanabilmesi için nasıl bir yol izlenebilir? İşte burada kendi veri türümüzün tasarımını yapmamız gerektiği kararına varabiliriz.

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

//TODO@buraksenyurt

## Çerezlik Kod Pratikleri

Bu bölümde dersler sırasında işlenen konuları pekiştirmek amacıyla kullanılabilecek bazı örnek senaryolara yer verilmektedir. Kodlama pratiğinin artırılması için kullanılabilir.

Senaryo Kodları : Y -> Yellow, O -> Orange, R -> Red

| Kod       | Konu                                  | Açıklama                                                                             | Kurallar |
|-----------|---------------------------------------|--------------------------------------------------------------------------------------|----------|
| **Y00** | Nesne Modellemeleri(Class)            | Okuduğunuz kitaplar için bir envanter uygulaması geliştirmektesiniz. Bir kitabın nesnel olarak moddellenmesinde kullanılacak tasarıma ihtiyacınız var. Bu anlamda sizden Book isimli bir sınıf tasarlamanız bekleniyor. | int, string, bool, decimal veri türleri mutlaka kullanılmalı. Kod, bir kitabın bilgilerini string türde özetleyen, kitap fiyatına indirim uygulayan en az iki metot içermeli.|
| **Y01** | Value Type Tasarlaması(Struct)        | Geliştirmekte olduğumuz iki boyutlu oyunda Vektör değerlerini tutmak istiyoruz. Bunun için bir struct tasarlamanız bekleniyor. | Struct 2 boyutlu düzlemde mutlaka x ve y değerlerini taşımalı. double veri türü kullanılmalı. Bir vektörü birim vektöre dönüştüren, vektör bükülüğünü hesap eden en az iki metot yazılmalı|
| **Y02** | Terminal ile Çalışmak| Bu çalışmada bir Console uygulaması oluşturup ekrana en sevdiğiniz çizgi roman/kitap karakterinin bilgilerini yazdırmanız bekleniyor. | Karaktere ait tüm bilgiler öncelikle ayrı değişkenlerde toplanmalı. string, double, char, bool, uint veri türleri mutlaka kullanılmalı. Bilgileri ekrana yazdırma operasyonunu bir metot üstlenmeli  |
| **Y03** | Enum Türü Kullanımı | Bir web uygulamasının backend tarafında kodlama yapıyorsunuz. İş kurallarını işleten bazı fonksiyonlar HTTP durum kodları ile çalışıyor. HTTP durum kodlarının sayısal anlamlarını bir Enum sabiti olarak tanımlamanız bekleniyor. | Enum sabiti HTTP durum kodlarından en az 5ini karşılamalı. Uygulama kodunda Enum değerine göre ekrana bilgilendirme yapmamızı sağlayacak string türden değer döndüren bir metot bulunmalı. |
| **Y04** | | | |
| **Y05** | | | |
| **Y06** | | | |
| **Y07** | | | |
| **Y08** | | | |
| **Y09** | | | |
| **Y10** | | | |
| **Y11** | | | |
| **Y12** | | | |
| **O01** | | | |
| **O02** | | | |
| **O03** | | | |
| **O04** | | | |
| **O05** | | | |
| **O06** | | | |
| **O07** | | | |
| **O08** | | | |
| **O09** | | | |
| **O10** | | | |
| **O11** | | | |
| **O12** | | | |
| **R01** | | | |
| **R02** | | | |
| **R03** | | | |
| **R04** | | | |
| **R05** | | | |
| **R06** | | | |
| **R07** | | | |
| **R08** | | | |
| **R09** | | | |
| **R10** | | | |
| **R11** | | | |
| **R12** | | | |
