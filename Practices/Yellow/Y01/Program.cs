using Y01;

internal class Program
{
    private static void Main()
    {
        Vector2D vector1 = new(2.4, 4.5);
        Vector2D vector2 = new(1.2, -2.5);

        Vector2D unitVector = vector1.ToUnitVector();
        Console.WriteLine($"{vector1} için birim vektör değeri: {unitVector}");

        double curvature = vector1.Curvature(vector2);
        Console.WriteLine($"{vector1} ile {vector2} arası eğim: {curvature} derecedir");
    }
}