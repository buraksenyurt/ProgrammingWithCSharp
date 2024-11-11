namespace O01;

public interface IPersistance<T>
    where T : GameEntity
{
    void Save(List<T> entities);
}
