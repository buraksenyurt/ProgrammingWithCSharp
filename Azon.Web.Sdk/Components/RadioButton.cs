using Azon.Web.Sdk.Contracts;

namespace Azon.Web.Sdk.Components;

public class RadioButton(int id, string name, (double, double) position)
        : ButtonBase(id, name, position), IDrawable
{
    public List<string> Options { get; set; } = [];
    public string SelectedOption { get; set; }

    public void Draw()
    {
        Console.WriteLine("RadioButton draw at {0}:{1}", Position.Item1, Position.Item2);
    }
    public override string ToString()
    {
        return $"{base.ToString()}|{SelectedOption}";
    }
}
