namespace Y06.Components;

public abstract class BaseButton(int id, string text, (double, double) position)
{
    protected int ID { get; set; } = id;
    protected string? Text { get; set; } = text;
    protected (double, double) Position { get; set; } = position;
}
