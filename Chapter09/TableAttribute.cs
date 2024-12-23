namespace Chapter09
{
    /*
        Attribute sınıfları Attribute kelimesi ile bitecek şekilde isimlendirilir ve Attribute sınıfından türer.
        AttributeUsage isimli bir başka Attribute ile imzalanarak hangi seviye uygulanacakları belirtilebilir.
        Örneğin TableAttribute sadece sınıflara uygulanabilir.
        ColumnAttribute ise sadece Property'lere veya Field'lara uygulanabilir.
    */
    [AttributeUsage(AttributeTargets.Class)]
    internal class TableAttribute
    : Attribute
    {
        public string Schema { get; set; }
        public string Name { get; set; }
    }
}
