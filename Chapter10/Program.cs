using Chapter10.Model;

namespace Chapter10
{
    internal class Program
    {
        static void Main()
        {
            Product product = new Product
            {
                Id = 1,
                Title = "Dolma kalem",
                InStock = true,
                ListPrice = 10.0M
            };
            var script = MigrationProvider.CreateTableScript(product); // product isimli nesne örneği için Create Table script'ini üret
            Console.WriteLine($"{script}");
            MigrationProvider.SaveScript(script,"CreateProduct.sql");
        }
    }
}
