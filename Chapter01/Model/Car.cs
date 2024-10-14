/*
    Bütün tip tanımları(class, struct, interface, delegate, enum vs) bir namespace içerisinde yer alır.
    Namespace, aynı amaca hizmet eden enstrümanların toplandığı yerdir(Farklı dillerde package, module gibi görebiliriz)
    Namespace, kavramsal bir anlam bütünlüğü sağlar.
*/
namespace Chapter01.Model
{
    internal class Car
    {
        public string Name;
        // Color field'ının string yerine kendi tasarladığımı ProductColor enum sabiti ile de kullanabiliriz
        // public string Color;
        public ProductColor Color; // Color alanı(field) sadece ProductColor enum sabiti türünden bir değer alabilir
        public string Model;
        public short Year;
    }
}
