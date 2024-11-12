namespace Y04;

class Program
{
    static void Main()
    {
        var motto = "it's a beautiful day";
        var shining_motto = Terminal.WriteBeauty(motto, Style.Underscore);

        Console.WriteLine(shining_motto);
        Console.WriteLine(Terminal.WriteBeauty(motto, Style.Spaces));
        Console.WriteLine(Terminal.WriteBeauty(motto, Style.Stars));
        Console.WriteLine(Terminal.WriteBeauty(motto, Style.Reversed));

        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("\nAşağıda ne yazıyor acaba? :D\n");
        Console.ResetColor();
        for (var i = 0; i < 3; i++)
        {
            Console.WriteLine(Terminal.WriteBeauty(motto, Style.Surprised));
        }
    }
}
