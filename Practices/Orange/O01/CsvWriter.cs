using System.Text;

namespace O01;

public class CsvWriter(string fileName = "GameState.dat")
        : IPersistance<GameEntity>
{
    private string FileName { get; } = fileName;

    public void Save(List<GameEntity> entities)
    {
        var builder = new StringBuilder();

        foreach (var entity in entities)
        {
            builder.AppendLine(entity.ToString());
        }

        File.WriteAllText(Path.Combine(Environment.CurrentDirectory, FileName), builder.ToString());
    }
}
