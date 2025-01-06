namespace Learning.Abstractions;

public class ElasticLogger
    : ILogger
{
    public void Error(string message)
    {
        // Elasticsearch veritabanına error log basar
    }

    public void Info(string message)
    {
        // Elasticsearch veritabanına info log basar
    }

    public void Warn(string message)
    {
        // Elasticsearch veritabanına warn log basar
    }
}
