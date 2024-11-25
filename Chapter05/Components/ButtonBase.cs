namespace Chapter05.Components;

/*
    Control sınıfından türeyen ButtonBase, Button türevli bileşenleri ifade eder.
    Tüm Button'lar için ortak olabilecek bazı özellikleri veya metotları içerebilir.
 */
public abstract class ButtonBase(int id, string name, (double, double) position)
        : Control(id, name, position)
{
    /*
        Aslında arka plan ve ön plan rengi ve hatta yazının büyüklüğü, türü, yatık olması vs
        gibi unsular FontStyle gibi farklı bir sınıfın özellikleri olabilir.
     */
    public string? BackgroundColor { get; set; }
    public string? ForegroundColor { get; set; }
}
