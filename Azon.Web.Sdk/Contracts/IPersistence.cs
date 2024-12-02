using Azon.Web.Sdk.Components;

namespace Azon.Web.Sdk.Contracts;

public interface IPersistence
{
    void Save(List<Control> controls);
}
