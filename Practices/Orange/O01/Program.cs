using O01;

internal class Program
{
    private static void Main()
    {
        var writer = new CsvWriter();
        var world = new World(writer);
        world.AddEntities(
            new GameEntity { Position = new(10.0, 0.0) }
            , new GameEntity { Position = new(20.0, 30.0) }
            , new GameEntity { Position = new(0.0, -10.0) }
        );

        world.SaveLastState();
    }
}