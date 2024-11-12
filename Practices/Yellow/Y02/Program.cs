namespace Y02;

class Program
{
    static void Main()
    {
        string characterName = "Batman";
        double characterHeight = 1.88;
        char gender = 'M';
        bool hasSuperPowers = false;
        uint age = 35;

        PrintHeroInfo(characterName, characterHeight, gender, hasSuperPowers, age);
    }

    static void PrintHeroInfo(string name, double height, char gender, bool hasPowers, uint age)
    {
        Console.WriteLine($"{name.ToUpper()}");
        Console.WriteLine($"Boy: {height} metre");
        Console.WriteLine($"Cinsiyeti: {gender}");
        Console.WriteLine($"Yaşı: {age}");
        Console.WriteLine($"Süper Güçleri Var mı?: {(hasPowers ? "Evet" : "Hayır")}");
    }
}
