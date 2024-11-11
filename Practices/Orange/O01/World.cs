namespace O01;

public class World(IPersistance<GameEntity> persistance)
{
    private readonly List<GameEntity> _entities = [];
    private readonly IPersistance<GameEntity> _persistance = persistance;
    public void AddEntities(params GameEntity[] entities) => _entities.AddRange(entities);
    public void SaveLastState()
    {
        Console.WriteLine($"Saving for {_entities.Count} objects");
        _persistance.Save(_entities);
    }
}
