namespace Chapter01.Model
{
    /*
        struct ve class arasındaki en temel fark bellekte tutulma biçimidir.
        Struct'lar değer türü(Value Type) formatında, kaplayacakları alanlar belli olan türlerdir ve bellekte Stack bölgesinde dururlar.
        Class'lar ise referans türü(Reference Type) formatında olup kaplayacakları alan genelde runtime'de belli olan, değişebilen
        ve bu sebeplerden belleğin Heap bölgesinde duran enstrümanlardır.
        Buna göre birbirleri arasındaki atamalar farklılık gösterebilir.

        Kendi tasarlayacağımız türler class olmak zorunda değildir. Veri içeriğine bunları struct olarak da ele alabiliriz.

        Örneğin IpInfo veri modelinde içerikteki tüm türler byte cinsindendir. Yani herbiri birer Struct'tır. Bellekte kaplayacağı yer bellidir.
        Değer türü gibi kullanılabilir bir modeldir.
     */
    internal struct IpInfo
    {
        public byte Part1;
        public byte Part2;
        public byte Part3;
        public byte Part4;
    }
}
