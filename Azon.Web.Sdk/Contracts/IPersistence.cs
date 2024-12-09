using Azon.Web.Sdk.Components;

namespace Azon.Web.Sdk.Contracts;

/*
    Aşağıdaki arayüz generic hale çevrilmiştir. Yani T türü yerine herhangi bir tip gelebilir,
    arayüz içerisindeki üyelerde T görülen yerlere seçilen tip gelir.

    Buradaki senaryoda T türü için kısıt koymak gerekir (Generic Constraints)
 */
//public interface IPersistence<T>
//    // where T: class,new() // Burada T türünün bir sınıf olması ve mutlaka default constructor içermesi belirtiliyor
//    // where T : Control, IDrawable // Burada ise T türünün Control sınıfından türemiş olması ve IDrawable arayüzünü implemente etmiş olması gerektiği belirtiliyor
//    // where T : Control
//{
//    void Save(List<T> controls);
//}

public interface IPersistence
{
    void Save(List<Control> controls);
}