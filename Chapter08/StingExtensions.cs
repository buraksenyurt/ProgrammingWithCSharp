namespace Chapter08;

/*
    LINQ sorgularında yer alan metotlar genellikle genişletme metotlarıdır.
    Extension Method'lar statik sınıflarda statik metotlar ile yazılır.
    this keyword ile başlayan ilk parametre hangi tipi genişleteceğimizi belirtir.
    Örneğin aşağıdaki WriteSmart metodu String sınıfı için bir genişletme metodudur.
 */
public static class StingExtensions
{
    public static string WriteSmart(this string text,char seperator)
    {
        var result = string.Empty;
        for (int i = 0; i < text.Length; i++)
        {
            result += text[i] + seperator.ToString();
        }

        return result;
    }
}
