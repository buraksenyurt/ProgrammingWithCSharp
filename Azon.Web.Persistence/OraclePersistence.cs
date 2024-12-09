using Azon.Web.Sdk.Components;
using Azon.Web.Sdk.Contracts;

namespace Azon.Web.Persistence;

public class OraclePersistence
    :IDatabasePersistence
{
    public string ConnectionString { get; set; }
    public string UserName { get; set; }

    public void Save(List<Control> controls)
    {
        Console.WriteLine("Database save");
    }
}
