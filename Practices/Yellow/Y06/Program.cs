using Y06.Behaviors;
using Y06.Components;
using Y06.Controllers;

internal class Program
{
    private static void Main()
    {
        List<IDrawable> buttons = [
            new AzonButton(1, "Save", (0, 0)),
            new AzonButton(2, "Print", (250, 0)),
            new AzonButton(3, "Close", (500, 0)),
            new AzonRadioButton(4, "Save Password", (0, 500)),
            new AzonImageButton(5,"Profile Picture",(50,50),"photo.png")
        ];
        DrawController.DrawAll([.. buttons]);
    }
}