using Azon.Web.Sdk.Components;
using Chapter06.Dto;
using System.Reflection;

namespace Chapter06.Persistence;

public static class ControlMapper
{
    public static ControlDto ToDto(Control control)
    {
        return control switch
        {
            Button button => new ButtonDto
            {
                Id = button.Id,
                Name = GetProtectedProperty<Control, string?>(button, "Name"),
                Position = GetProtectedProperty<Control, (double, double)>(button, "Position"),
                BackgroundColor = button.BackgroundColor,
                ForegroundColor = button.ForegroundColor,
                IsCorneredCurve = button.IsCorneredCurve,
                Text = button.Text
            },
            CheckBox checkBox => new CheckBoxDto
            {
                Id = checkBox.Id,
                Name = GetProtectedProperty<Control, string?>(checkBox, "Name"),
                Position = GetProtectedProperty<Control, (double, double)>(checkBox, "Position"),
                Text = checkBox.Text,
                IsChecked = checkBox.IsChecked
            },
            Label label => new LabelDto
            {
                Id = label.Id,
                Name = GetProtectedProperty<Control, string?>(label, "Name"),
                Position = GetProtectedProperty<Control, (double, double)>(label, "Position"),
                Text = label.Text
            },
            LinkButton linkButton => new LinkButtonDto
            {
                Id = linkButton.Id,
                Name = GetProtectedProperty<Control, string?>(linkButton, "Name"),
                Position = GetProtectedProperty<Control, (double, double)>(linkButton, "Position"),
                BackgroundColor = linkButton.BackgroundColor,
                ForegroundColor = linkButton.ForegroundColor,
                Url = linkButton.Url
            },
            DbConnector dbConnector => new DbConnectorDto
            {
                Id = dbConnector.Id,
                Name = GetProtectedProperty<Control, string?>(dbConnector, "Name"),
                Position = GetProtectedProperty<Control, (double, double)>(dbConnector, "Position"),
                ConnectionString = dbConnector.ConnectionString
            },
            PictureBox pictureBox => new PictureBoxDto
            {
                ImagePath = pictureBox.ImagePath,
                Height = pictureBox.Height,
                Width = pictureBox.Width
            },
            _ => throw new NotSupportedException($"Control type {control.GetType().Name} is not supported.")
        };
    }

    public static Control FromDto(ControlDto dto)
    {
        return dto switch
        {
            ButtonDto buttonDto => new Button(buttonDto.Id, buttonDto.Name!, buttonDto.Position)
            {
                BackgroundColor = buttonDto.BackgroundColor,
                ForegroundColor = buttonDto.ForegroundColor,
                Text = buttonDto.Text,
                IsCorneredCurve = buttonDto.IsCorneredCurve,
            },
            CheckBoxDto checkBoxDto => new CheckBox(checkBoxDto.Id, checkBoxDto.Name!, checkBoxDto.Position)
            {
                Text = checkBoxDto.Text,
                IsChecked = checkBoxDto.IsChecked
            },
            LabelDto labelDto => new Label(labelDto.Id, labelDto.Name!, labelDto.Position)
            {
                Text = labelDto.Text
            },
            LinkButtonDto linkButtonDto => new LinkButton(linkButtonDto.Id, linkButtonDto.Name!, linkButtonDto.Position)
            {
                BackgroundColor = linkButtonDto.BackgroundColor,
                ForegroundColor = linkButtonDto.ForegroundColor,
                Url = linkButtonDto.Url
            },
            DbConnectorDto dbConnectorDto => new DbConnector(dbConnectorDto.Id, dbConnectorDto.Name!, dbConnectorDto.Position)
            {
                ConnectionString = dbConnectorDto.ConnectionString
            },
            PictureBoxDto pictureBoxDto => new PictureBox(pictureBoxDto.Id, pictureBoxDto.Name!, pictureBoxDto.Position)
            {
                ImagePath = pictureBoxDto.ImagePath,
                Width = pictureBoxDto.Width,
                Height = pictureBoxDto.Height
            },
            _ => throw new NotSupportedException($"DTO type {dto.GetType().Name} is not supported.")
        };
    }

    private static TProperty GetProtectedProperty<T, TProperty>(T instance, string propertyName)
    {
        var propertyInfo = typeof(T).GetProperty(propertyName, BindingFlags.NonPublic | BindingFlags.Instance);
        if (propertyInfo == null)
        {
            throw new InvalidOperationException($"Property {propertyName} not found on type {typeof(T).Name}");
        }
        return (TProperty)propertyInfo.GetValue(instance);
    }
}
