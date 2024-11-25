
using Chapter05.Contracts;

namespace Chapter05.Components
{
    public class CheckBox
        : Control, IDrawable
    {
        public string Text { get; set; }
        public bool IsChecked { get; set; }
        public CheckBox(int id, string name, (double, double) position) : base(id, name, position)
        {
        }
        public void Draw()
        {
            Console.WriteLine("CheckBox draw at {0}:{1}", Position.Item1, Position.Item2);
        }
        public override string ToString()
        {
            return $"{base.ToString()}|{Text}|{IsChecked}";
        }
    }
}
