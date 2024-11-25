namespace Chapter05.Components;

/*
    Tasarımımıza göre ekrana çizilebilen tüm bileşenleri tarifleyen nesnedir.
 */
public abstract class Control(int id, string name, (double, double) position)
{
    public int Id { get; set; } = id;
    protected string? Name { get; set; } = name;
    protected (double, double) Position { get; set; } = position;

    public override string ToString()
    {
        return $"{Id}|{this.GetType().Name}|{Name}|{Position}";
    }
}
