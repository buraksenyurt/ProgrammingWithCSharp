using Chapter05.Contracts;

namespace Chapter05.Components
{
    public class RadioButton
        : ButtonBase, IDrawable
    {
        public List<string> Options { get; set; } = [];
        public string SelectedOption { get; set; }
        public RadioButton(int id, string name, (double, double) position)
            : base(id, name, position)
        {
        }
        public void Draw()
        {
            Console.WriteLine("RadioButton draw at {0}:{1}", Position.Item1, Position.Item2);
        }
        public override string ToString()
        {
            return $"{base.ToString()}|{SelectedOption}";
        }
    }
}
