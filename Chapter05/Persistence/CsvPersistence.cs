using Chapter05.Components;
using Chapter05.Contracts;
using System.Text;

namespace Chapter05.Persistence
{
    public class CsvPersistence
        : IPersistence
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
}
