namespace O01;

public class GameEntity
{
    public Guid Id { get; private set; } = Guid.NewGuid();
    public (double, double) Position { get; set; }

    public override string ToString() => $"{Id}|{Position.Item1}:{Position.Item2}";
}
