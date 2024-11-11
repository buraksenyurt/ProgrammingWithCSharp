namespace Learning.Structs.Client
{
    internal class Program
    {
        static void Main()
        {
            var cmpx_1 = new ComplexNumber(1.2f, -3.4f);
            Console.WriteLine(cmpx_1);
            var cmpx_2 = cmpx_1.Add(new ComplexNumber(3.4f, 1.0f));
            Console.WriteLine(cmpx_2);

            var rectangle = new Square(10, 20);
            Console.WriteLine("Rectangle area is {0}. Perimeter is {1}", rectangle.GetArea(), rectangle.GetPerimeter());

            var velocity = new Vector2D(3.0, 1.0);
            Console.WriteLine($"Vector magnitude ise {velocity.Magnitude()}");
        }
    }
}
