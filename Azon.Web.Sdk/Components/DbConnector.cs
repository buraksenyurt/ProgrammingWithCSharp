namespace Azon.Web.Sdk.Components;

public class DbConnector(int id, string name, (double, double) position)
        : Control(id, name, position)
{
    public string? ConnectionString { get; set; }

    public override string ToString()
    {
        return $"{base.ToString()}|{ConnectionString}";
    }
}
