namespace Chapter09;

internal static class AttributeSample
{
    public static void Run()
    {

    }
}

/*
    Kendisine verilen nesneler için gerekli SQL Tablo oluşturma script'lerini üretir.
    Bir nevi otomatik kod üretici olarak düşünebiliriz.
    Kendisine ait bir runtime'ı vardır. Dolayısıyla çalışma zamanında okuduğu sınıflar için
    Create Table script'leri hazırlar.

    EF'in Migration Tool'u (CLI) göz önüne getirilebilir.
*/
internal class MigrationProvider
{
    /*
        CrateTableScript metodu EntityBase sınıfından türemiş sınıflarla çalışacak şekilde 
        tasarlanmıştır. Görevi, instance örneğinin Table ve Column attribute'larını tarayıp
        uygun Create Table script'ini üretmektir
    */
    public static string CreateTableScript<T>(T instance)
        where T : EntityBase
    {
        // TableAttribute var mı kontrol et.
        // TableAttribute varsa scheman ve table adlarını yerleştir
        // instance'ın bütün Property'lerini dolaş
        // O anki property Column attribute'una sahipse, ilgili bilgileri al script'e yerleştir

        return string.Empty;
    }
}


internal class EntityBase
{
}
/*
    Product sınıfını MigrationProvider senaryo gereği bir runtime olarak okur.
    Amacı bu sınıfa ve üyelerine bakıp bir SQL Table Create script' i oluşturmaktır.
    Bunun için Table ve Column Attribute sınıfları ile, runtime'a ekstra bilgiler taşınır.
    Örneğin, tablo adı ve şeması ne olacak, property'ler kolon haline çevrilirken hangi
    veri türünden olacak vs
*/

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

internal class DataType
{
}
internal class SqlDataType : DataType
{
    public const string Nvarchar = "nvarchar";
    public const string Decimal = "decimal";
    public const string Bool = "bit";
    public const string BigInt = "bigint";
}