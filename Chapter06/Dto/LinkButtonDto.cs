namespace Chapter06.Dto;

public class LinkButtonDto : ButtonBaseDto
{
    public Uri Url { get; set; } = new Uri("http://localhost");
}
