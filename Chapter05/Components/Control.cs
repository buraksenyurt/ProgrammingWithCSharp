namespace Chapter05.Components
{
    /*
        Tasarımımıza göre ekrana çizilebilen tüm bileşenleri tarifleyen nesnedir.
     */
    public abstract class Control
    {
        public int Id { get; set; }
        protected string Name { get; set; }
        protected (double, double) Position { get; set; }
        protected Control(int id, string name, (double, double) position)
        {
            Id = id;
            Name = name;
            Position = position;
        }
        public override string ToString()
        {
            return $"{Id}|{this.GetType().Name}|{Name}|{Position}";
        }
    }
}
