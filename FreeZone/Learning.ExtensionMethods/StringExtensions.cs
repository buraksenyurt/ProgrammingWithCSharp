namespace Learning.ExtensionMethods;

public static class StringExtensions
{
    public static string FirstNCharacters(this string text, int n)
    {
        if (string.IsNullOrEmpty(text) || n <= 0)
        {
            return string.Empty;
        }

        return text.Length <= n ? text : text[..n];
    }

    public static bool IsPalindrome(this string text)
    {
        if (string.IsNullOrEmpty(text))
        {
            return false;
        }

        var reversed = new string(text.ToLower().Where(char.IsLetterOrDigit).Reverse().ToArray());
        var original = new string(text.ToLower().Where(char.IsLetterOrDigit).ToArray());

        return original == reversed;
    }

    public static int WordCount(this string text)
    {
        if (string.IsNullOrWhiteSpace(text))
        {
            return 0;
        }

        return text.Split([' ', '\t', '\n'], StringSplitOptions.RemoveEmptyEntries).Length;
    }

    public static bool AnyNumber(this string text)
    {
        return text.Any(char.IsDigit);
    }

    public static bool IsAlphabetic(this string text)
    {
        return !string.IsNullOrEmpty(text) && text.All(char.IsLetter);
    }

    public static string ExtractNumbers(this string text)
    {
        return new string(text.Where(char.IsDigit).ToArray());
    }
}
