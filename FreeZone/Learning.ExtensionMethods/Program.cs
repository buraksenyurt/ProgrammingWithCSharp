namespace Learning.ExtensionMethods;

internal class Program
{
    static void Main()
    {
        int number = 27;
        List<int> factors = number.GetFactors();
        Console.WriteLine($"Factors of {number}");
        foreach (int f in factors)
        {
            Console.Write($"{f},");
        }
        Console.WriteLine();

        number = 121;
        Console.WriteLine($"{number} is palindrome number? {number.IsPalindrome()}");

        number = 153;
        Console.WriteLine($"{number} is armstrong number? {number.IsArmstrongNumber()}");

        number = 28;
        Console.WriteLine($"{number} is perfect number? {number.IsPerfectNumber()}");

        number = 29;
        Console.WriteLine($"{number} is prime number? {number.IsPrime()}");

        string paragraph = "Bugün programlama dillerinden rust ile ilgili çalışmalar yapıyorum";
        int count = paragraph.WordCount();
        Console.WriteLine($"{paragraph}\b has {count} words");

        string word = "Madam";
        bool isPalindromeWord = word.IsPalindrome();
        Console.WriteLine($"{word} is palindrome word? {isPalindromeWord}");

        string input = "Klimanjoro sokak Numara 1234, Daire 32, Posto Kodu 19, Tokyo";
        string numbers = input.ExtractNumbers();
        Console.WriteLine($"{input}\ncontains this {numbers} ");

        Console.WriteLine("Hello World is alphabetic ? {0}", "Hello World!".IsAlphabetic());
        Console.WriteLine("John Doe 89 ? {0}", "John Doe 89!".IsAlphabetic());

    }
}
