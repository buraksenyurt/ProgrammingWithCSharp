using Y06.Behaviors;

namespace Y06.Components;

public class AzonRadioButton(int id, string text, (double, double) position)
        : BaseButton(id, text, position), IDrawable
{
    private readonly Dictionary<string, string> options = [];

    public void AddOption(string optionName, string option) => options.Add(optionName, option);

    public void Draw()
    {
        Console.WriteLine("AzonRadioButton için çizim yapılıyor");
    }
}
