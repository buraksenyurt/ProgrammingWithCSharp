using Cshapter10;

namespace Chapter10.Model;

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
    [Column(Name = "p_title", DataType = SqlDataType.Text, Length = 50)]
    public string Title { get; set; }
    [Column(Name = "p_list_price", DataType = SqlDataType.Decimal)]
    public decimal ListPrice { get; set; }
    [Column(Name = "p_in_stock", DataType = SqlDataType.Bool)]
    public bool InStock { get; set; }
}
