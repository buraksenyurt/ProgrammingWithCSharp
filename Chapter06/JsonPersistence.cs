using Azon.Web.Sdk.Components;
using Azon.Web.Sdk.Contracts;
using System.Text.Json;

namespace Chapter06
{
    public class JsonPersistence
        : IFilePersistence
    {
        public string FilePath { get; set; } = Path.Combine(Environment.CurrentDirectory, "Form.json");
        public void Save(List<Control> controls)
        {
            //TODO@buraksenyurt Türeyen bileşenlerin verisi JSON formatında serileşemiyor
            var serialized = JsonSerializer.Serialize(controls);
            File.WriteAllText(FilePath, serialized);
        }
    }
}
