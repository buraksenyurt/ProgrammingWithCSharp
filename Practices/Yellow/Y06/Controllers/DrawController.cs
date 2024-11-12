using Y06.Behaviors;

namespace Y06.Controllers;

public class DrawController
{
    public static void DrawAll(IDrawable[] drawables)
    {
        foreach (var drawable in drawables)
        {
            drawable.Draw();
        }
    }
}
