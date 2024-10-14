# Programming With CSharp

C# programalama dersi için açılmış olan ve örnek kodları içeren repodur.

- [Başlangıç](#programming-with-csharp)
    - [Chapter 00](#ders-00)
    - [Chapter 01](#ders-01)
    - [Chapter 02](#ders-02)

## Ders 00

Bu ilk dersteki amacımız standart bir Hello World uygulamasından ziyade dersin ana konularından olan nesne kavramını anlatmaya çalışmaktı. Nesne yönelimli dil konsepti _(Object Oriented Programming)_ gerçek hayat iş modellerinin kurgulanmasında büyük kolaylıklar sağlar. Bu açıdan bakıldığıda her hangibir şeyi nesnel olarak modellemek mümkündür.

Bu felsefeyi kavramak soyut kavramları nedeniyle çoğu zaman zordur. Bu nedenle ders için verilen proje ödevlerinin tutulduğu JSON bazlı dosya üzerine basit bir iş modeli kurgusu tartışılmıştır. Data.json içerisinde yer alan her bir projeyi programatik ortamda başka object user'ların da kullanabilmesi için nasıl bir yol izlenebilir? İşte burada kendi veri türümüzün tasarımını yapmamız gerektiği kararına varabiliriz.

Örnekte tasarlanmış olan Homework sınıfı bu işi üstlenir. Çok basit anlamda JSON dosyasındaki bir içeriğin nesnel izdüşümünü tanımlar. Ödevlerin benzersiz IDsi, başlığı, açıklaması ve seviye puanı sınıfın birer özelliği olur. Özelliklere erişimi kasıtlı olarak kontrol altına almak ve ileride tartışabileceğimiz verinin doğrulanması ya da static factory metot ile nesnenin kendisinin üretimi için gerekli kavramlar için zemin hazırlanmaya çalışılmıştır. Buna göre şu konular üzerinde durulmuştur diyebiliriz;

- Private property kullanımı _(Encapsulation)_
- Object Instance kavramı
- Constructor ile nesne örnekleme ve primary constructor kavramı
- Herkesin bir Object olduğu teorisi ve varsayılan ToString davranışının değiştirilmesi

Başlangıçta zor gelen bu konular ilerleyen derslerde daha sık kullanılacağından panik yapmaya gerek yoktur ;)

## Ders 01

İkinci dersin amacı temel değişkenleri ve .Net Common Type System içerisinde [built-in](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/built-in-types) olarak gelen bazı veri türlerini tanımaktır. Konu genellikle türlerin bellekte tutuluş şekli ile ilişkilendirilir. Stack ve Heap bellek bölgelerinin işleyişi üzerinde durulmuştur. Basit sayısal değerler, metinsel veri türleri, mantıksal olan versiyonları ele alınmıştır.

.Net genel tip sistemi beş ana tür üzerine odaklanır. Class, struct, enum, interface, delegate. Duruma göre hangi türü kullanacağımıza karar vermek iyi olacaktır. [CTS ile ilgili bu adresten genel bilgi alınabilir](https://learn.microsoft.com/en-us/dotnet/standard/base-types/common-type-system)

Odak noktası bir noktada var olan türleri kullanarak kendi türlerimizi inşa etmenin gerekliliğini de ortaya koymaktır. Bir IP adresini basit bir string türü ile ifade edebileceğimiz gibi herbir parçasını byte türü olarak ele alan bir struct ile de ifade edebiliriz. Ya da bir renk bilgisini kullanım amacına göre enum sabiti gibi düşünebiliriz. Eğer bir grafik uygulama söz konusu ise RGB ve Alpha değerlerini içeren başka bir veri modeli olarak _(struct)_ da tasarlayabiliriz. Tüm bunlar temel veri türlerini kullanarak kendi veri yapılarımızı kurgulayabileceğimiz, yeniden kullanılabilir _(Reusable)_ , güvenilir _(Reliable)_ , mantıksak bütünlüğe sahip kurgular inşa etmemizi sağlayacaktır.

IP demişken System.Net isimli alanındaki karşılığına da bir bakdın derim :smile:

Sorular / Araştırma Konuları

- Solution (sln) ne işe yarar?
- Main metodu hakkında neler söyleyebiliriz?
- Hangi durumlarda kendi türlerimizi yazma ihtiyacı doğar? _(IP veya RGB mevzusu)_

Bugün kullandığımız komutlar.

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

Bu dersteki amacımız nesnelerimizi işe yarar fonksiyonellikler ile güçlendirmek ve bazı temel karar yapıları ile döngüleri kullanmak.

