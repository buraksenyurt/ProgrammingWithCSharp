using Azon.Web.Persistence;
using Azon.Web.Sdk.Components;

namespace Azon.Web.Editor;

internal class Program
{
    static void Main(string[] args)
    {
        var csvPersistence = new CsvPersistence();
        Form mainForm = new(csvPersistence);

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

        mainForm.AddControls(btnSave, btnClose, lblTitle, lnkAbout, chkIsActiveProfile, dbConnector);
        mainForm.DrawAll();
        mainForm.Save();
    }
}
