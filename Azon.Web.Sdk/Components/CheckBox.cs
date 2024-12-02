using Azon.Web.Sdk.Contracts;

namespace Azon.Web.Sdk.Components;

public class CheckBox(int id, string name, (double, double) position)
        : Control(id, name, position), IDrawable
{
    public string? Text { get; set; }
    public bool IsChecked { get; set; }

    public void Draw()
    {
        Console.WriteLine("CheckBox draw at {0}:{1}", Position.Item1, Position.Item2);
    }
    public override string ToString()
    {
        return $"{base.ToString()}|{Text}|{IsChecked}";
    }
}
