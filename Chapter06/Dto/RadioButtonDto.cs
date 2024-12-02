namespace Chapter06.Dto;

public class RadioButtonDto : ButtonBaseDto
{
    public List<string> Options { get; set; } = [];
    public string SelectedOption { get; set; } = string.Empty;
}
