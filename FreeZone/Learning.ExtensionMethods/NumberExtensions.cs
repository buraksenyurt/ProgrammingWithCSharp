namespace Learning.ExtensionMethods;

public static class NumberExtensions
{
    public static bool IsPrime(this int number)
    {
        if (number <= 1) return false;

        for (int i = 2; i <= Math.Sqrt(number); i++)
        {
            if (number % i == 0) return false;
        }

        return true;
    }

    public static bool IsPalindrome(this int number)
    {
        string original = number.ToString();
        string reversed = new(original.Reverse().ToArray());
        return original == reversed;
    }

    public static bool IsPerfectNumber(this int number)
    {
        if (number <= 0) return false;

        int sum = 0;
        for (int i = 1; i <= number / 2; i++)
        {
            if (number % i == 0)
                sum += i;
        }

        return sum == number;
    }

    public static long Factorial(this int number)
    {
        if (number < 0)
        {
            throw new ArgumentException("Negatif sayıların faktöriyeli hesaplanamaz.");
        }

        long result = 1;
        for (int i = 1; i <= number; i++)
        {
            result *= i;
        }
        return result;
    }

    public static bool IsArmstrongNumber(this int number)
    {
        if (number < 0) return false;

        var digits = number.ToString().Select(c => int.Parse(c.ToString())).ToArray();
        int power = digits.Length;

        int sum = digits.Select(d => (int)Math.Pow(d, power)).Sum();

        return sum == number;
    }

    public static List<int> GetFactors(this int number)
    {
        var factors = new List<int>();

        for (int i = 1; i <= number; i++)
        {
            if (number % i == 0)
                factors.Add(i);
        }

        return factors;
    }
}
