namespace remoteCmdConf;

public class JsonOperations
{
    private string _imapServerAddress = string.Empty;
    private int _port;
    private bool _useSSL;
    private string _userName = string.Empty;
    private string _password = string.Empty;
    private int _delayCheckNewMail;

    public JsonOperations(
        string imapServerAddress,
         int port,
         bool useSSL,
         string userName,
         string password,
         int delayCheckNewMail
        )
    {

        _imapServerAddress = imapServerAddress;
        _port = port;
        _useSSL = useSSL;
        _userName = userName;
        _password = password;
        _delayCheckNewMail = delayCheckNewMail;
    }




    public void Test()
    {

        var form1 = new Form1();
        MessageBox.Show(_imapServerAddress);
    }
}