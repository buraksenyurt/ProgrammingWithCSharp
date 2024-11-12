namespace Y03;
class Program
{
    static void Main()
    {
        HttpStatusCode[] codes = [
            HttpStatusCode.Ok,HttpStatusCode.BadRequest,HttpStatusCode.NoContent
        ];

        foreach (var code in codes)
        {
            Console.WriteLine($"{code}: {GetStatusDescription(code)}");
        }
    }

    static string GetStatusDescription(HttpStatusCode code)
    {
        return code switch
        {
            HttpStatusCode.Ok => "İstek başarıyla tamamlandı.",
            HttpStatusCode.Created => "Kaynak başarıyla oluşturuldu.",
            HttpStatusCode.NoContent => "İstek başarıyla işlendi fakat içerik yok.",
            HttpStatusCode.BadRequest => "İstek geçersiz veya hatalı.",
            HttpStatusCode.NotFound => "İstenen kaynak bulunamadı.",
            HttpStatusCode.InternalServerError => "Sunucu hatası oluştu.",
            _ => "Bilinmeyen durum kodu."
        };
    }
}
