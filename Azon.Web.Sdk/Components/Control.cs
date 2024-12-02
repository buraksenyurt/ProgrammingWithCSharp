namespace Azon.Web.Sdk.Components;

public abstract class Control(int id, string name, (double, double) position)
{
    public int Id { get; set; } = id;
    protected string? Name { get; set; } = name;
    protected (double, double) Position { get; set; } = position;

    public override string ToString()
    {
        return $"{Id}|{GetType().Name}|{Name}|{Position}";
    }
}
