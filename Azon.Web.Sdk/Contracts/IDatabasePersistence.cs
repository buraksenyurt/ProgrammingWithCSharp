namespace Azon.Web.Sdk.Contracts;

public interface IDatabasePersistence 
    : IPersistence
{
    string ConnectionString { get; set; }
    string UserName { get; set; }
}
