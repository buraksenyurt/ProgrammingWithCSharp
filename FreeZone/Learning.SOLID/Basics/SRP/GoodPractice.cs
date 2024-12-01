namespace Learning.SOLID.Basics.SRP;

/*
    Fatura türü ile ilgili olan görevler uygun sınıflara ayrılmış vaziyette.
    Her sınıf tek bir sorumluluğa sahiptir. 
    Invoice sadece fatura tutarı hesaplar, InvoiceRepository bir veritabanı ya da farklı bir ortama
    kaydetme işini üstlenir, InvoicePrinter ise faturayı yazdırma işini.
 */
public class Invoice
{
    public void CalculateTotal()
    {

    }
}

public class InvoiceRepository
{
    public void Save(Invoice invoice)
    {

    }
}

public class InvoicePrinter
{
    public void Print(Invoice invoice)
    {

    }
}

public class InvoiceConverter
{
    public void ConvertToPdf(Invoice invoice)
    {

    }
}
