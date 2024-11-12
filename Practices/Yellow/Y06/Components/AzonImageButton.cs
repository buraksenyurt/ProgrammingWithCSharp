using Y06.Behaviors;

namespace Y06.Components;

public class AzonImageButton(int id, string text, (double, double) position, string image)
: BaseButton(id, text, position), IDrawable
{
    public string Image { get; set; } = image;

    public void Draw()
    {
        Console.WriteLine("AzonImageButton için çizim yapılıyor");
    }
}
