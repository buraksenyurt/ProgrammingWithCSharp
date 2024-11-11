namespace O01;

public class DatabaseWriter
    : IPersistance<GameEntity>
{
    public void Save(List<GameEntity> entities)
    {
        Console.WriteLine("Database save operations");
    }
}
