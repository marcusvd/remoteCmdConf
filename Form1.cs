using System.Windows.Forms;

namespace remoteCmdConf;

public partial class Form1 : Form
{

    

    public Form1()
    {
        InitializeComponent();
        // Adicionar um botão
        Button button = new Button();
        button.Text = "Clique aqui";
        button.Location = new System.Drawing.Point(100, 100);
        button.Click += (sender, e) => MessageBox.Show("Olá, Mundo!");
        button.Size = new System.Drawing.Size(100, 100);
        this.Controls.Add(button);

    }

    private void Form1_Load(object sender, EventArgs e)
    {

    }

    private void gbxServicesConfUserAccount_Enter(object sender, EventArgs e)
    {

    }

    private void btnStartServices_Click(object sender, EventArgs e)
    {

    }

    private void btnSaveSettings_Click(object sender, EventArgs e)
    {

        string imapServerAddress = txtServerAddress.Text;

        int imapServerPort = stringToInt(mkdTxtServerPort.Text);
        bool useSSL = chkUseSSL.Checked;
        string ServerUserName = txtServerUserName.Text;
        string ServerPassword = txtServerPassword.Text;
        int serviceTime = stringToInt(mkdTxtServiceTime.Text);

        JsonOperations test = new JsonOperations(imapServerAddress,imapServerPort,useSSL,ServerUserName,ServerPassword,serviceTime);
        //JsonOperations test = new JsonOperations(imapServerAddress);

        test.Test();

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
        

        //if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
        //{
        //    e.Handled = true;
        //}
    }
}
