namespace Learning.SOLID.Basics.ISP;

/*
    Interface segregation prensibi bir arayüzün (interface) 
    onu kullanan tarafın ihtiyacı olmayan metotları içermemelidir der.
    
    LegacyPrinter sınıfı eski tür printer makinelerini ifade ediyor olsun. Bu makinelerde
    tarama veya fax gönderme gibi fonksiyonellikler bulunmayabilir. Ancak bu fonksiyonellikler IPrinter
    arayüzünde tanımlandıklarından mecburen LegacyPrinter sınıfı tarafından da ele alınmalıdır.
 */
public interface IPrinterMachine
{
    void Print();
    void ScanDocument();
    void SendFax();
}

public class LegacyPrinter
    : IPrinterMachine
{
    public void Print()
    {
    }
    public void ScanDocument()
    {
    }
    public void SendFax()
    {
    }
}

