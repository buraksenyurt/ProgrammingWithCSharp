namespace Chapter06.Dto;

public class ControlDto
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public (double, double) Position { get; set; }
}
