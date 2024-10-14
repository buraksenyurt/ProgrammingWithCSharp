namespace Chapter01.Model
{
    /*
        Kendi tasarlayabileceğimi türlerden birisi de Enum sabitleridir.
        Genellikle sayısal ifadeleri daha okunabilir anlamlı ifadelere eşleştirmek için kullanılır.
        enum türleri struct veya class gibi iş yapan fonksiyonlar veya metotlar içermez.

        Sorular :

        - ProductColor enum sabitinde renkler için sayısal değerler kullanılabilir mi?
     */
    internal enum ProductColor
    {
        Black,
        White,
        Green,
        Blue,
        Yellow
    }
    /*
        Renk gibi bir kavram dahi kullanılacağı yere göre farklı veri türleri şeklinde inşa edilebilir.
        Bir grafik programda RGB ayarında kullanılması gerekirken, belki bir e-ticaret sisteminde business anlamda 
        kullanılan sabit renkleri ifade eden bir enum da olabilir.

        ObjectColor struct'ı da ProductColor.cs gibi ayrı bir dosyaya alınsa iyi olur.

        Sorular : 

        - Metinsel bir ifadeden(örneğin hexadecimal bir string değerden, #FFFF00 gibi RGB struct nesnesi elde edilebilir mi?
        - Bir ObjectColor nesnesini örneklerken constructor gibi metotlar kullanılabilir mi?
     */
    internal struct ObjectColor
    {
        public byte Red;
        public byte Green;
        public byte Blue;
        public byte TransperencyRate;
    }
}
