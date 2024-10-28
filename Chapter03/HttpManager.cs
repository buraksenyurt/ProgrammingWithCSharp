namespace Chapter03
{
    /*
        HttpManager sınıfının görevi belli url'ler için çeşitli işlemleri gerçekleştirmek olsun.
        Örneğin bir web servisine veri göndermek ve cevap almak gibi(Send)
        Basit olması açısından sadece string türle çalıştık.
     */
    public class HttpManager
    {
        public string Send(string url, string data)
        {
            Console.WriteLine($"{url} adresine mesaj gönderilecek");

            // Url bilgisi boş veya null ise ya da https:// ile başlamıyorsa ortama exception fırlat
            if (string.IsNullOrEmpty(url) || !url.StartsWith("https://"))
            {
                throw new InvalidUrlException(url);
            }
            return "Http OK(200)";
        }
    }

    /*
        InvalidUrlException sınıfının bir Exception olarak throw edilebilmesi için
        Exception sınıfından türemesi(inherit) yeterlidir. Bu sayede Exception sınıfındaki bazı ortak
        özellik ve metotlara da sahip olur. Yani kendi exception nesnelerimiz için sahip olmaları gereken
        üyeleri tekrardan yazmak zorunda kalmayız. Bunları base type karşılar.
     */
    public class InvalidUrlException
        : Exception
    {
        /*
            base keyword, bir üst sınıfı işaret eder. 
            Şu anki senaryoda base ile Exception sınıfı ifade edilir.
            constructor' da yaptığımız kullanıma göre base türün yani Exception sınıfının constructor metodu
            çağırılır.
         */
        public InvalidUrlException(string url)
            : base($"{url} bilgisi geçersiz.")
        {
        }
    }
}
