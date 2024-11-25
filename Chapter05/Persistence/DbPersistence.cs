using Chapter05.Components;
using Chapter05.Contracts;

namespace Chapter05.Persistence;

public class DbPersistence
    : IPersistence
{
    public void Save(List<Control> controls)
    {
        Console.WriteLine("Database save");
    }
}
