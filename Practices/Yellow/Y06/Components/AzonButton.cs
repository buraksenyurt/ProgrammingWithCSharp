using Y06.Behaviors;

namespace Y06.Components;

public class AzonButton(int id, string text, (double, double) position)
        : BaseButton(id, text, position), IDrawable
{
    public void Draw()
    {
        Console.WriteLine("AzonButton için çizim yapılıyor");
    }
}
