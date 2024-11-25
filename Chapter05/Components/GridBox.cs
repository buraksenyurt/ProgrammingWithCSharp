using Chapter05.Contracts;

namespace Chapter05.Components
{
    internal class GridBox
        : Control, IDrawable
    {
        public int RowCount { get; set; }
        public int ColumnCount { get; set; }
        public GridBox(int id, string name, (double, double) position)
            : base(id, name, position)
        {
        }
        public void Draw()
        {
            Console.WriteLine("GridBox draw at {0}:{1}", Position.Item1, Position.Item2);
        }
        public override string ToString()
        {
            return $"{base.ToString()}|{RowCount}|{ColumnCount}";
        }
    }
}
