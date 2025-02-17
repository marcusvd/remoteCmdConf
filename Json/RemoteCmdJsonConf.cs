namespace remoteCmdConf;
public class RemoteCmdJsonConf
{
    public string Server { get; set; } = string.Empty;
    public int Port { get; set; }
    public bool UseSsl { get; set; }
    public string UserName { get; set; } = string.Empty;
    public string PasswordHash { get; set; } = string.Empty;
    public string Salt { get; set; } = string.Empty;

    //Execution Conf
    public string GroupExecution { get; set; } = string.Empty;
    public string SecretExecutionCode { get; set; } = string.Empty;

    //Service Conf
    public string ServiceUserName { get; set; } = string.Empty;
    public string ServicePassword { get; set; } = string.Empty;
    public int DelayCheckNewMail { get; set; } = 1000;

}