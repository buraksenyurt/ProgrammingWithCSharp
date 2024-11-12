namespace Y04;

public static class Terminal
{
    public static string WriteBeauty(string content, Style style)
    {
        switch (style)
        {
            case Style.Underscore:
                return Underscore(content);
            case Style.Stars:
                return Stars(content);
            case Style.Spaces:
                return Spaces(content);
            case Style.Reversed:
                return Reversed(content);
            case Style.Surprised:
                return Surprised(content);
            default:
                return content;
        }
    }
    private static string Underscore(string content)
    {
        string result = string.Empty;
        foreach (char c in content)
        {
            result += c.ToString() + '_';
        }
        return result.Remove(result.Length - 1, 1);
    }
    private static string Stars(string content)
    {
        string result = string.Empty;
        foreach (char c in content)
        {
            result += c.ToString() + '*';
        }
        return result.Remove(result.Length - 1, 1);
    }
    private static string Spaces(string content)
    {
        string result = string.Empty;
        foreach (char c in content)
        {
            result += c.ToString() + ' ';
        }
        return result.Remove(result.Length - 1, 1);
    }
    private static string Reversed(string content)
    {
        string result = string.Empty;
        var reversedContent = content.Reverse();
        foreach (var c in reversedContent)
        {
            result += c.ToString();
        }
        return result;
    }
    private static string Surprised(string content)
    {
        var characters = content.ToCharArray();
        var rand = new Random();

        for (int i = characters.Length - 1; i > 0; i--)
        {
            int j = rand.Next(0, i + 1);
            (characters[j], characters[i]) = (characters[i], characters[j]);
        }

        return new string(characters);
    }
}

public enum Style
{
    Underscore,
    Stars,
    Spaces,
    Reversed,
    Surprised
}
