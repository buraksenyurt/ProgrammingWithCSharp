namespace Azon.Web.Component;

public class Form(IPersistence persistence)
{
    private readonly List<Control> _controls = [];
    private readonly IPersistence _persistence = persistence;

    public void AddControls(params Control[] controls)
    {
        _controls.AddRange(controls);
    }
    public void LocateAll()
    {
        foreach (Control control in _controls)
        {
            Console.WriteLine($"{control.Id} location set");
        }
    }
    public void DrawAll()
    {
        foreach (Control control in _controls)
        {
            if (control is IDrawable drawable)
            {
                drawable.Draw();
            }
        }
    }

    public void Save()
    {
        _persistence.Save(_controls);
    }
}
