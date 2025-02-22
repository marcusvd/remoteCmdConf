public static class TextFileWriter
{
    public static void Write(string path, string text)
    {
        try
        {
            using (StreamWriter streamWriter = new StreamWriter(path))
            {
                streamWriter.Write(text);
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }

    }

    public static string Read(string path)
    {
        try
        {
            using (StreamReader streamReader = new StreamReader(path))
            {
                return streamReader.ReadToEnd();
            }
        }
        catch(Exception ex)
        {
            MessageBox.Show($"Error {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        return "";
    }
}