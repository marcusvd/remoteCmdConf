using System.Windows.Forms;

namespace remoteCmdConf;

public partial class Form1 : Form
{

    private System.Windows.Forms.Timer timerUpdate;

    public Form1()
    {
        InitializeComponent();

        timerUpdate = new System.Windows.Forms.Timer();
        timerUpdate.Interval = 3000; // interval in milliseconds (30.00 ms = 3 second)
        timerUpdate.Tick += TimerUpdate_Tick;
        timerUpdate.Start();

        // Adicionar um botão
        Button button = new Button();
        button.Text = "Clique aqui";
        button.Location = new System.Drawing.Point(100, 100);
        button.Click += (sender, e) => MessageBox.Show("Olá, Mundo!");
        button.Size = new System.Drawing.Size(100, 100);
        this.Controls.Add(button);

    }

    private void TimerUpdate_Tick(object sender, EventArgs e)
    {
        var serviceStatus = new StatusPanel();

        try
        {
            var status = serviceStatus.CheckServiceStatus();
            lblStatusPanelServiceStatus.Text = $"{status}.";

            switch (status)
            {
                case "running":
                    lblStatusPanelServiceStatus.ForeColor = Color.Green;
                    btnStartServices.Text = "Stop";
                    break;
                case "stopped":
                    lblStatusPanelServiceStatus.ForeColor = Color.Red;
                    btnStartServices.Text = "Start";
                    break;
                default:
                    lblStatusPanelServiceStatus.ForeColor = Color.Orange;
                    break;
            }
        }
        catch (Exception ex)
        {
            lblStatusPanelServiceStatus.Text = $"Erro: {ex.Message}";
            lblStatusPanelServiceStatus.ForeColor = Color.Gray;
        }
    }

    protected override void OnFormClosing(FormClosingEventArgs e)
    {
        timerUpdate.Stop();
        timerUpdate.Dispose();
        base.OnFormClosing(e);
    }



    private void Form1_Load(object sender, EventArgs e)
    {
        var jsonOps = new JsonOperations();

        var remoteCmdJsonConf = jsonOps.jsonLoad("appSettings.json");

        FillFormLoad(remoteCmdJsonConf);


    }

    private void FillFormLoad(RemoteCmdJsonConf entity)
    {

        var EncryptedPasswordImap = PasswordManager.Decrypt(entity.ServerImap.PasswordImap);
        var EncryptedSecretExecutionCode = PasswordManager.Decrypt(entity.ParamsExecution.SecretExecutionCode);
        var EncryptedPasswordService = PasswordManager.Decrypt(entity.ServiceConf.ServicePassword);

        txtServerAddress.Text = entity.ServerImap.Server;
        mkdTxtServerPort.Text = entity.ServerImap.Port.ToString();
        chkUseSSL.Checked = entity.ServerImap.UseSsl;
        txtServerUserName.Text = entity.ServerImap.UserName;
        txtServerPassword.Text = EncryptedPasswordImap;
        txtServiceGroupExecution.Text = entity.ParamsExecution.GroupExecution;
        txtServiceSecretExecutionCode.Text = EncryptedSecretExecutionCode;
        txtServiceRunUserNameAccount.Text = entity.ServiceConf.ServiceUserName;
        txtServiceRunPasswordAccount.Text = EncryptedPasswordService;
        mkdTxtServiceTime.Text = entity.ServiceConf.DelayCheckNewMail.ToString();
    }


    private void gbxServicesConfUserAccount_Enter(object sender, EventArgs e)
    {

    }

    private void btnStartServices_Click(object sender, EventArgs e)
    {
        var serviceStatus = new StatusPanel();

        if (serviceStatus.CheckServiceStatus() == "running")
            serviceStatus.StartStopServices("stop");

        if (serviceStatus.CheckServiceStatus() == "stopped")
            serviceStatus.StartStopServices("start");
    }

    private void btnSaveSettings_Click(object sender, EventArgs e)
    {

        var EncryptedPasswordImap = PasswordManager.Encrypt(txtServerPassword.Text);
        var EncryptedSecretExecutionCode = PasswordManager.Encrypt(txtServiceSecretExecutionCode.Text);
        var EncryptedPasswordService = PasswordManager.Encrypt(txtServiceRunPasswordAccount.Text);



        var remoteCmdConf = new RemoteCmdJsonConf
        {
            ServerImap = new()
            {
                Server = txtServerAddress.Text,
                Port = stringToInt(mkdTxtServerPort.Text),
                UseSsl = chkUseSSL.Checked,
                UserName = txtServerUserName.Text,
                PasswordImap = EncryptedPasswordImap,
            },

            ParamsExecution = new()
            {
                GroupExecution = txtServiceGroupExecution.Text,
                SecretExecutionCode = EncryptedSecretExecutionCode,
            },
            ServiceConf = new()
            {
                ServiceUserName = txtServiceRunUserNameAccount.Text,
                ServicePassword = EncryptedPasswordService,
                DelayCheckNewMail = stringToInt(mkdTxtServiceTime.Text),
            },

        };

        JsonOperations jsonOps = new JsonOperations(remoteCmdConf);
        jsonOps.JsonBuilder();
    }

    private int stringToInt(string valueToConvert)
    {
        int number;
        bool result = int.TryParse(valueToConvert, out number);

        if (result)
            return number;
        else
            return 0;
    }
    private void txtServerPort_TextChanged(object sender, EventArgs e)
    {

    }
}
