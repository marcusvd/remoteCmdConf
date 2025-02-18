using System.Text.Json;

namespace remoteCmdConf;

public class JsonOperations
{
    private readonly RemoteCmdJsonConf? _remoteCmdJsonConf;

    public JsonOperations()
    {
        _remoteCmdJsonConf = null;
    }
    public JsonOperations(
        RemoteCmdJsonConf RemoteCmdJsonConf

        )
    {
        _remoteCmdJsonConf = RemoteCmdJsonConf;

    }



    public void JsonBuilder()
    {
        var saveFileDialog = new SaveFileDialog
        {
            Filter = "JSON files (*.json)|*.json",
            Title = "Save appsettings.json",
            FileName = "appSettings.json"
        };
        if(saveFileDialog.ShowDialog() == DialogResult.OK)
        {
            var options = new JsonSerializerOptions
            {
                WriteIndented = true
            };

            string appSettingsJson = JsonSerializer.Serialize(_remoteCmdJsonConf, options);
            string appSettingsPathjson = JsonSerializer.Serialize(new AppSettingsPath(){Path = saveFileDialog.FileName}, options);

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

    public RemoteCmdJsonConf jsonLoad(string pathJsonFile)
    {
        try
        {
            string jsonfile = File.ReadAllText(pathJsonFile);
            var appSettings = new RemoteCmdJsonConf();
            appSettings = JsonSerializer.Deserialize<RemoteCmdJsonConf>(jsonfile);

            if (appSettings != null)
                return appSettings;

        }

        catch (Exception ex)
        {
            MessageBox.Show($"Error when load file JSON: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
           
        }

        return new RemoteCmdJsonConf();
    }

    public void FillForm(RemoteCmdJsonConf entity)
    {

    }




}