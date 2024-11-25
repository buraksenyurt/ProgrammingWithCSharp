namespace Chapter05.Components
{
    /*
        DbConnector sınıfının en büyük özelliği bir Control olması ama Draw metodunu içermemesidir.
        Tasarımımıza göre her kontrol Container nesne içerisinde çizilebilir olacak diye bir kural yoktur.
     */
    public class DbConnector
        : Control
    {
        public string ConnectionString { get; set; }

        public DbConnector(int id, string name, (double, double) position)
            : base(id, name, position)
        {
        }
        public override string ToString()
        {
            return $"{base.ToString()}|{ConnectionString}";
        }
    }
}
