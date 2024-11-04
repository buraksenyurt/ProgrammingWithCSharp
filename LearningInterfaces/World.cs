using System.Collections;

namespace LearningInterfaces
{
    public class World
        : IEnumerable<GameEntity>
    {
        private readonly List<GameEntity> _entities =
        [
            new Tower{Id=1 },
            new Tower{Id=2 },
            new Tower{Id=3 },
            new Wall{Id=4 },
            new Wall{Id=5 },
            new Tile{Id=6 },
            new Wall{Id=7 },
        ];

        public IEnumerator<GameEntity> GetEnumerator()
        {
            return _entities.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }

    public class GameEntity
    {
        public int Id;
    }
    public class Wall : GameEntity { }
    public class Tile : GameEntity { }
    public class Tower : GameEntity { }
}
