using Chapter05.Contracts;

namespace Chapter05.Components;

public class LinkButton(int id, string name, (double, double) position)
        : ButtonBase(id, name, position), IDrawable
{
    public Uri Url { get; set; }

    public void Draw()
    {
        Console.WriteLine("LinkButton draw at {0}:{1}", Position.Item1, Position.Item2);
    }
    public override string ToString()
    {
        return $"{base.ToString()}|{Url}";
    }
}
