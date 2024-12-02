namespace Azon.Web.Sdk.Contracts
{
    public interface IFilePersistence : IPersistence
    {
        string FilePath { get; set; }
    }
}
