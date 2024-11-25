namespace Chapter05.Components;

/*
    DbConnector sınıfının en büyük özelliği bir Control olması ama Draw metodunu içermemesidir.
    Tasarımımıza göre her kontrol Container nesne içerisinde çizilebilir olacak diye bir kural yoktur.
 */
public class DbConnector(int id, string name, (double, double) position)
        : Control(id, name, position)
{
    public string? ConnectionString { get; set; }

    public override string ToString()
    {
        return $"{base.ToString()}|{ConnectionString}";
    }
}
