using Azon.Web.Sdk.Contracts;

namespace Azon.Web.Sdk.Components;

public class GridBox(int id, string name, (double, double) position)
        : Control(id, name, position), IDrawable
{
    public int RowCount { get; set; }
    public int ColumnCount { get; set; }

    public void Draw()
    {
        Console.WriteLine("GridBox draw at {0}:{1}", Position.Item1, Position.Item2);
    }
    public override string ToString()
    {
        return $"{base.ToString()}|{RowCount}|{ColumnCount}";
    }
}
