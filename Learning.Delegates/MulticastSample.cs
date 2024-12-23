namespace Learning.Delegates;

/*
    Multicast Delegate; Bir delegate ile birden fazla metodu zincir olarak bağlayıp kullanmamız mümkündür. 
    Tek bir delegate çağrısı kendisine += operatörü ile eklenmiş tüm metotların çağırılması anlamına gelir
    
    Event; Delegate tipleri ile event'lerin tetiklenmesi de mümkündür.
*/

delegate void LogHandler(string message);

static class MulticastSample
{
    public static void Run()
    {
        #region Multicast Delegate Kullanımı

        // Aşağıdaki satırda handlers isimli değişkene LogToConsole metodunu atadık
        LogHandler handlers = LogToConsole;
        handlers += LogToTextFile; // handlers değişkenine ikinci bir metot daha ekledik
        handlers += LogToDatabase;
        Log(handlers, "API gateway online");

        //handlers("Connection succedded..."); // Hem Console, hem text hem de db loglama fonksiyonları arka arkaya çağrılır

        // handlers -= LogToTextFile;

        //handlers("Loading games...");

        #endregion
    }
    static void Log(LogHandler handler, string message)
    {
        handler(message);
    }

    static void LogToConsole(string message)
    {
        Console.WriteLine($"{DateTime.Now}: {message}");
    }
    static void LogToTextFile(string message)
    {
        var logText = $"\n{DateTime.Now}: {message}";
        File.AppendAllText(Path.Combine(Environment.CurrentDirectory, "logs.txt"), logText);
    }
    static void LogToDatabase(string message)
    {
        Console.WriteLine("Writing to db");
    }
}
