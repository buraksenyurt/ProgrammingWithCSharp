namespace Chapter04
{
    /*
        Sonraki derste bu konu üzerinde tekrar duracağız.
     */
    public interface IDrawable
    {
        void Draw();
    }

    public interface IUpdatable
    {
        void Update();
    }
    public class Enemy : IUpdatable, IDrawable
    {
        public void Draw()
        {
            throw new NotImplementedException();
        }

        public void Update()
        {
            throw new NotImplementedException();
        }
    }
    public class Tile : IDrawable
    {
        public void Draw()
        {
            throw new NotImplementedException();
        }
    }
    public class Score : IUpdatable
    {
        public void Update()
        {
            throw new NotImplementedException();
        }
    }
}
