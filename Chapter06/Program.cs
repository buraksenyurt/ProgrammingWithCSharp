using Azon.Web.Sdk.Components;
using Chapter06.Persistence;

namespace Chapter06;

/*
    Bu proje Azon.Web.Sdk ve Azon.Web.Persistence projelerini referans edip kullanmaktadır.
    Sdk veya Persistence projelerinde bir değişiklik yapmadan yeni component'ler veya Persistence bileşenleri
    Chapter06 runtime'ına eklenebilir. Nitekim, Sdk projesi yeni form bileşeni oluşturmak veya Persistence
    bileşeni eklemek için gerekli olan Contract'ları (interface tanımlamaları) sağlar.
 */
internal class Program
{
    static void Main()
    {
        // var csvSaver = new CsvPersistence();
        var jsonSaver = new JsonPersistence(); // Bu runtime için eklediğimiz kendi Persistence bileşenimiz
        Form mainForm = new(jsonSaver);

        // Bu runtime için eklediğimiz kendi Control türevli nesnemiz
        PictureBox pictureBox = new(98, "pbProfilePhoto", (0, 0))
        {
            ImagePath = "profilePhoto.png",
            Width = 64,
            Height = 64,
        };
        Button btnSave = new(101, "btnSave", (0, 100))
        {
            Text = "Save"
        };
        Button btnClose = new(102, "btnClose", (0, 500))
        {
            Text = "Close"
        };
        CheckBox chkIsActiveProfile = new(104, "chkIsActive", (0, 10))
        {
            Text = "Is Active Profile",
            IsChecked = true
        };
        Label lblTitle = new(106, "lblTitle", (50, 50))
        {
            Text = "Title"
        };
        LinkButton lnkAbout = new(204, "lnkAbout", (400, 50))
        {
            Url = new Uri("https://www.azon.com.tr/about")
        };
        DbConnector dbConnector = new(90, "dbConnector", (0, 0))
        {
            ConnectionString = "data source=localhost:database=Northwind;integrated security=sspi"
        };

        mainForm.AddControls(btnSave, btnClose, lblTitle, lnkAbout, chkIsActiveProfile, dbConnector, pictureBox);
        mainForm.DrawAll();
        mainForm.Save();
    }
}
