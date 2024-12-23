namespace Learning.Delegates;

delegate int MathOperation(int a, int b);

class BasicSample
{
    public static void Run()
    {
        MathOperation addition = (a, b) => a + b;
        // static int addition(int a, int b) => a + b; // Local Function kullanımı
        MathOperation subtraction = (a, b) => a - b;

        int x = 5;
        int y = 9;

        MathOperation operation = addition;
        Console.WriteLine($"Result: {operation(x, y)}");
        MathOperation operation1 = subtraction;
        Console.WriteLine($"Result: {operation(x, y)}");
    }
}
