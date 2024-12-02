using Azon.Web.Sdk.Components;
using Azon.Web.Sdk.Contracts;
using System.Text.Json;

namespace Chapter06.Persistence;

public class JsonPersistence 
    : IFilePersistence
{
    public string FilePath { get; set; } = Path.Combine(Environment.CurrentDirectory, "Form.json");

    public void Save(List<Control> controls)
    {
        var dtos = controls.Select(ControlMapper.ToDto).ToList();

        var json = JsonSerializer.Serialize(dtos, options: new JsonSerializerOptions
        {
            WriteIndented = true,
            IncludeFields = true
        });

        File.WriteAllText(FilePath, json);
    }
}
