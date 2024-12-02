using Azon.Web.Sdk.Components;
using Azon.Web.Sdk.Contracts;
using Newtonsoft.Json;

namespace Chapter06.Persistence;

public class JsonPersistence
    : IFilePersistence
{
    public string FilePath { get; set; } = Path.Combine(Environment.CurrentDirectory, "Form.json");

    public void Save(List<Control> controls)
    {
        var dtos = controls.Select(ControlMapper.ToDto).ToList();

        var json = JsonConvert.SerializeObject(dtos, Formatting.Indented, new JsonSerializerSettings
        {
            TypeNameHandling = TypeNameHandling.All
        });

        File.WriteAllText(FilePath, json);
    }
}
