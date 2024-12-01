namespace Learning.SOLID.Basics.ISP;

public interface IPrinter
{
    void Print();
}

public interface IScanner
{
    void ScanDocument();
}

public interface IFax
{
    void SendFax();
}

public class BasicPrinter : IPrinter
{
    public void Print()
    {
    }
}

public class SmartPrinter : IPrinter, IScanner
{
    public void Print()
    {
    }

    public void ScanDocument()
    {
    }
}

public class OfficePrinter : IPrinter, IScanner, IFax
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
