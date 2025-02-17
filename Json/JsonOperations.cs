using System.Text.Json;

namespace remoteCmdConf;

public class JsonOperations
{
    private RemoteCmdJsonConf? _remoteCmdJsonConf;
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

        var options = new JsonSerializerOptions
        {
            WriteIndented = true
        };

        string json = JsonSerializer.Serialize(_remoteCmdJsonConf, options);
        string nameFileToSave = "appSettings.json";

        try
        {
            File.WriteAllText(nameFileToSave, json);
        }
        catch (IOException ex)
        {
            MessageBox.Show($"Error: {ex.Message}");
        }

        MessageBox.Show(json);
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
            return null;
        }

        return null;
    }

    public void FillForm(RemoteCmdJsonConf entity)
    {

    }




}