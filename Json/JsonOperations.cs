using System.Text.Json;

namespace remoteCmdConf;

public class JsonOperations
{
    private readonly Appsettings? _Appsettings;

    public JsonOperations()
    {
        _Appsettings = null;
    }
    public JsonOperations(
        Appsettings Appsettings

        )
    {
        _Appsettings = Appsettings;

    }



    public void JsonBuilder()
    {
        var saveFileDialog = new SaveFileDialog
        {
            Filter = "JSON files (*.json)|*.json",
            Title = "Save appsettings.json",
            FileName = "appSettings.json"
        };
        if (saveFileDialog.ShowDialog() == DialogResult.OK)
        {
            var options = new JsonSerializerOptions
            {
                WriteIndented = true
            };

            string appSettingsJson = JsonSerializer.Serialize(_Appsettings, options);
            string appSettingsPathjson = JsonSerializer.Serialize(new AppSettingsPath() { Path = saveFileDialog.FileName }, options);

            try
            {
                File.WriteAllText(saveFileDialog.FileName, appSettingsJson);
                File.WriteAllText("path.json", appSettingsPathjson);
            }
            catch (IOException ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
            MessageBox.Show("JSON file saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //MessageBox.Show(json);
        }
    }

    public Appsettings LoadAppSettingsJson(string pathJsonFile)
    {
        try
        {
            string jsonfile = File.ReadAllText(pathJsonFile);
            var appSettings = new Appsettings();
            appSettings = JsonSerializer.Deserialize<Appsettings>(jsonfile);

            if (appSettings != null)
                return appSettings;

        }

        catch (Exception)
        {
            MessageBox.Show($"JSON file not found.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        return new Appsettings();
    }
    public AppSettingsPath LoadAppSettingsPathJson(string pathJsonFile)
    {
        try
        {
            string jsonfile = File.ReadAllText(pathJsonFile);
            var appSettingsPath = new AppSettingsPath();
            appSettingsPath = JsonSerializer.Deserialize<AppSettingsPath>(jsonfile);

            if (appSettingsPath != null)
                return appSettingsPath;

        }

        catch (Exception)
        {
            MessageBox.Show($"JSON file not found.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        return new AppSettingsPath();
    }

    public void FillForm(Appsettings entity)
    {

    }




}