using Chapter05.Contracts;

namespace Chapter05.Components
{
    public class LinkButton
        : ButtonBase, IDrawable
    {
        public Uri Url { get; set; }
        public LinkButton(int id, string name, (double, double) position)
            : base(id, name, position)
        {
        }
        public void Draw()
        {
            Console.WriteLine("LinkButton draw at {0}:{1}", Position.Item1, Position.Item2);
        }
        public override string ToString()
        {
            return $"{base.ToString()}|{Url}";
        }
    }
}
