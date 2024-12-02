using Azon.Web.Sdk.Components;
using Azon.Web.Sdk.Contracts;
using System.Text;

namespace Azon.Web.Persistence;

public class CsvPersistence
    : IFilePersistence
{
    public string FilePath { get; set; } = Path.Combine(Environment.CurrentDirectory, "Form.dat");
    public void Save(List<Control> controls)
    {
        var builder = new StringBuilder();
        foreach (Control control in controls)
        {
            builder.AppendLine(control.ToString());
        }
        var content = builder.ToString();
        File.WriteAllText(FilePath, content);
    }
}
