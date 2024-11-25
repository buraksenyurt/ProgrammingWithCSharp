using Chapter05.Components;
using Chapter05.Contracts;

namespace Chapter05.Containers;

/*
    Form sınıfı bizim için bir Container görevi görüyor.
    Kendi içinde Control türünden herhangibir nesne listesini barındırabilir.
    Bu nesneler için toplu çizim, ekran yerleşimi, kaydetme veya yükleme(load) işlemlerini icra edebilir.
 */
public class Form(IPersistence persistence)
{
    private readonly List<Control> _controls = [];

    /*
        Form nesnesi kaydetme işlemi IPersistence arayüzünü implemente eden bileşenleri kullanır.
        Bunu constructor üzerinden parametre ile verebiliriz. Buna Constructor Injection denir.
     */
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
        /*
            DrawAll metodu Control türünden tüm nesne örneklerini dolaşır ama bunlardan
            sadece IDrawable interface' ini implemente etmiş olanların kullanılması gerekir. 
            Bunun için is operatörü ile o anki nesnenin IDrawable olup olmadığına (ya da) Draw
            davranışına sahip olup olmadığına bakılır.
         */
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
        /*
            Save metodu aslında IPersistence arayüzü üzerinden atanan bileşen kimse
            onun Save metodunu, bu sınıfın Controls listesi için çalıştırır.
         */
        _persistence.Save(_controls);
    }

    /*
        Save metodu aşağıdaki versiyon itibariyle tüm veri içeriğini tasarlandığı gibi
        Form.dat isimli bir dosyaya kaydeder.
        Peki farklı formatta kaydetmek istersem ya da başka bir yere 
        (Database, Cloud üzerinde bir servis vb)
        ne yapmam gerekir?

        Buradaki düşünce yapımız temelde şu, Form sınıfını değiştirmeden kaydetme işini üstlenen
        bir başka component'i kullanmasını sağlamak ve bu şekilde genişletmek.
        Kod değiştirilmeye kapalı, genişletilmeye açık.

        Burada Dependency Inversion prensibinden yararlanabiliriz.
     */
    //public void Save(string FileType)
    //{
    //    /*
    //        Id|Control Type|Name|X Position|Y Position|Other Control Properties|

    //        1|Button|btnSave|10|20|Save
    //        2|Button|btnClose||100|20|Is Active Profile
    //        3|LinkButton|lnkAbout|50|20|About
    //        4|CheckBoxButton|10|10|Is Active Profile
    //    */

    //    if (FileType == "csv")
    //    {

    //        var builder = new StringBuilder();
    //        foreach (Control control in _controls)
    //        {
    //            builder.AppendLine(control.ToString());
    //        }
    //        var content = builder.ToString();
    //        File.WriteAllText("Form.dat", content);
    //    }
    //    else if (FileType == "json")
    //    {
    //        // JSON formatında kaydetme işlemi
    //    }
    //    else if (FileType == "database")
    //    {
    //        // Database'e kaydetme işlemi
    //    } else if (FileType == "cloud")
    //    {

    //    }
    //}
}
