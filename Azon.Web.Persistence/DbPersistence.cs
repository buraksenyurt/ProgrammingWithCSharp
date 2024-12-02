using Azon.Web.Sdk.Components;
using Azon.Web.Sdk.Contracts;

namespace Azon.Web.Persistence;

public class DbPersistence
    : IPersistence
{
    public void Save(List<Control> controls)
    {
        Console.WriteLine("Database save");
    }
}
