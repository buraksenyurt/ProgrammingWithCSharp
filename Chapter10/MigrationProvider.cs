using Chapter10.Model;
using Cshapter10;
using System.Reflection;
using System.Text;

namespace Chapter10;

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
        var builder = new StringBuilder();
        builder.Append("CREATE OR ALTER TABLE ");
        var instanceType = typeof(T); // Burada instance değişkeni ile gelen type bilgisini yakalarız

        // TableAttribute'u yakalıyoruz
        var tableAttribute = instanceType.GetCustomAttribute<TableAttribute>();
        if (tableAttribute != null) // Eğer uygulanmışsa şema adı ve tablo adını kullan
        {
            builder.AppendLine($"{tableAttribute.Schema}.{tableAttribute.Name} (");
        }
        else // Eğer TableAttribute uygulanmamışsa varsayılan tablo adı için sınıf adı kullanılabilir
        {
            builder.AppendLine($"{instanceType.Name} (");
        }

        // Type üzerindeki tüm property üyelerini dolaşıyoruz.
        foreach (var property in instanceType.GetProperties())
        {
            // Eğer bu özellik ColumnAttribute'u uygulamışsa kolonları ona göre ekliyoruz
            var columnAttribute = property.GetCustomAttribute<ColumnAttribute>();
            if (columnAttribute != null)
            {
                // Text türünde bir alansa length bilgisi gerekeceğinden bu tip bir ayrıma gittik
                if (columnAttribute.DataType == SqlDataType.Text)
                {
                    builder.AppendLine($"\t{columnAttribute.Name} {columnAttribute.DataType}({columnAttribute.Length}),");
                }else
                {
                    builder.AppendLine($"\t{columnAttribute.Name} {columnAttribute.DataType},");
                }
            }
            else
            {
                builder.AppendLine($"\t{property.Name},");
                //TODO@buraksenyurt Eğer ColumnAttribute uygulanmadıysa özellik tipine bakarak varsayılan bir tanımlama yapılmalı
            }
        }

        var script = builder.ToString()[..(builder.Length - 3)] + "\n)\nGo";
        return script;
    }

    internal static void SaveScript(string script, string filePath)
    {
        var fPath = Path.Combine(Environment.CurrentDirectory,filePath);
        File.WriteAllText(fPath,script);
    }
}
