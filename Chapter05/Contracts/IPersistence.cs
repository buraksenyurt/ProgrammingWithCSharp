using Chapter05.Components;

namespace Chapter05.Contracts
{
    public interface IPersistence
    {
        void Save(List<Control> controls);
    }
}
