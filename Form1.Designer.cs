namespace remoteCmdConf;

partial class Form1
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        gbxServerConf = new GroupBox();
        mkdTxtServerPort = new MaskedTextBox();
        lblServerPort = new Label();
        txtServerPassword = new TextBox();
        txtServerUserName = new TextBox();
        txtServerAddress = new TextBox();
        chkUseSSL = new CheckBox();
        lblServerPassword = new Label();
        lblServerUserName = new Label();
        lblServerAddress = new Label();
        gbxServicesConf = new GroupBox();
        mkdTxtServiceTime = new MaskedTextBox();
        btnSaveSettings = new Button();
        btnStartServices = new Button();
        gbxServiceConf = new GroupBox();
        txtServiceSecretExecutionCode = new TextBox();
        txtServiceGroupExecution = new TextBox();
        lblServiceSecretExecutionCode = new Label();
        lblGroupExecution = new Label();
        gbxServicesConfUserAccount = new GroupBox();
        txtServiceRunPasswordAccount = new TextBox();
        txtServiceRunUserNameAccount = new TextBox();
        lblServiceRunPasswordAccount = new Label();
        lblServiceRunUserNameAccount = new Label();
        lblServicesTimeConf = new Label();
        gbxStatusPanel = new GroupBox();
        lblStatusPanelErros = new Label();
        lblStatusPanelServiceStatus = new Label();
        lblStatusPanelServiceStatusStatic = new Label();
        gbxServerConf.SuspendLayout();
        gbxServicesConf.SuspendLayout();
        gbxServiceConf.SuspendLayout();
        gbxServicesConfUserAccount.SuspendLayout();
        gbxStatusPanel.SuspendLayout();
        SuspendLayout();
        // 
        // gbxServerConf
        // 
        gbxServerConf.Controls.Add(mkdTxtServerPort);
        gbxServerConf.Controls.Add(lblServerPort);
        gbxServerConf.Controls.Add(txtServerPassword);
        gbxServerConf.Controls.Add(txtServerUserName);
        gbxServerConf.Controls.Add(txtServerAddress);
        gbxServerConf.Controls.Add(chkUseSSL);
        gbxServerConf.Controls.Add(lblServerPassword);
        gbxServerConf.Controls.Add(lblServerUserName);
        gbxServerConf.Controls.Add(lblServerAddress);
        gbxServerConf.Location = new Point(22, 16);
        gbxServerConf.Margin = new Padding(3, 4, 3, 4);
        gbxServerConf.Name = "gbxServerConf";
        gbxServerConf.Padding = new Padding(3, 4, 3, 4);
        gbxServerConf.Size = new Size(361, 349);
        gbxServerConf.TabIndex = 9;
        gbxServerConf.TabStop = false;
        gbxServerConf.Text = "Imap Server Configurations";
        // 
        // mkdTxtServerPort
        // 
        mkdTxtServerPort.Location = new Point(283, 61);
        mkdTxtServerPort.Margin = new Padding(3, 4, 3, 4);
        mkdTxtServerPort.Mask = "00000";
        mkdTxtServerPort.Name = "mkdTxtServerPort";
        mkdTxtServerPort.Size = new Size(41, 27);
        mkdTxtServerPort.TabIndex = 18;
        mkdTxtServerPort.ValidatingType = typeof(int);
        // 
        // lblServerPort
        // 
        lblServerPort.AutoSize = true;
        lblServerPort.Location = new Point(267, 37);
        lblServerPort.Name = "lblServerPort";
        lblServerPort.Size = new Size(83, 20);
        lblServerPort.TabIndex = 16;
        lblServerPort.Text = "Server Port:";
        lblServerPort.TextAlign = ContentAlignment.TopCenter;
        // 
        // txtServerPassword
        // 
        txtServerPassword.Location = new Point(18, 193);
        txtServerPassword.Margin = new Padding(3, 4, 3, 4);
        txtServerPassword.Name = "txtServerPassword";
        txtServerPassword.PasswordChar = '*';
        txtServerPassword.Size = new Size(210, 27);
        txtServerPassword.TabIndex = 15;
        txtServerPassword.UseSystemPasswordChar = true;
        // 
        // txtServerUserName
        // 
        txtServerUserName.Location = new Point(15, 124);
        txtServerUserName.Margin = new Padding(3, 4, 3, 4);
        txtServerUserName.Name = "txtServerUserName";
        txtServerUserName.Size = new Size(210, 27);
        txtServerUserName.TabIndex = 14;
        // 
        // txtServerAddress
        // 
        txtServerAddress.Location = new Point(18, 61);
        txtServerAddress.Margin = new Padding(3, 4, 3, 4);
        txtServerAddress.Name = "txtServerAddress";
        txtServerAddress.Size = new Size(242, 27);
        txtServerAddress.TabIndex = 13;
        // 
        // chkUseSSL
        // 
        chkUseSSL.AutoSize = true;
        chkUseSSL.Location = new Point(18, 232);
        chkUseSSL.Margin = new Padding(3, 4, 3, 4);
        chkUseSSL.Name = "chkUseSSL";
        chkUseSSL.Size = new Size(85, 24);
        chkUseSSL.TabIndex = 12;
        chkUseSSL.Text = "Use SSL:";
        chkUseSSL.UseVisualStyleBackColor = true;
        // 
        // lblServerPassword
        // 
        lblServerPassword.AutoSize = true;
        lblServerPassword.Location = new Point(18, 169);
        lblServerPassword.Name = "lblServerPassword";
        lblServerPassword.Size = new Size(73, 20);
        lblServerPassword.TabIndex = 11;
        lblServerPassword.Text = "Password:";
        // 
        // lblServerUserName
        // 
        lblServerUserName.AutoSize = true;
        lblServerUserName.Location = new Point(15, 100);
        lblServerUserName.Name = "lblServerUserName";
        lblServerUserName.Size = new Size(85, 20);
        lblServerUserName.TabIndex = 10;
        lblServerUserName.Text = "User Name:";
        lblServerUserName.TextAlign = ContentAlignment.TopCenter;
        // 
        // lblServerAddress
        // 
        lblServerAddress.AutoSize = true;
        lblServerAddress.Location = new Point(18, 37);
        lblServerAddress.Name = "lblServerAddress";
        lblServerAddress.Size = new Size(148, 20);
        lblServerAddress.TabIndex = 9;
        lblServerAddress.Text = "Imap Server Address:";
        // 
        // gbxServicesConf
        // 
        gbxServicesConf.Controls.Add(mkdTxtServiceTime);
        gbxServicesConf.Controls.Add(btnSaveSettings);
        gbxServicesConf.Controls.Add(btnStartServices);
        gbxServicesConf.Controls.Add(gbxServiceConf);
        gbxServicesConf.Controls.Add(gbxServicesConfUserAccount);
        gbxServicesConf.Controls.Add(lblServicesTimeConf);
        gbxServicesConf.Location = new Point(417, 16);
        gbxServicesConf.Margin = new Padding(3, 4, 3, 4);
        gbxServicesConf.Name = "gbxServicesConf";
        gbxServicesConf.Padding = new Padding(3, 4, 3, 4);
        gbxServicesConf.Size = new Size(747, 349);
        gbxServicesConf.TabIndex = 10;
        gbxServicesConf.TabStop = false;
        gbxServicesConf.Text = "Service Configurations";
        // 
        // mkdTxtServiceTime
        // 
        mkdTxtServiceTime.Location = new Point(16, 65);
        mkdTxtServiceTime.Margin = new Padding(3, 4, 3, 4);
        mkdTxtServiceTime.Mask = "00000";
        mkdTxtServiceTime.Name = "mkdTxtServiceTime";
        mkdTxtServiceTime.Size = new Size(39, 27);
        mkdTxtServiceTime.TabIndex = 26;
        mkdTxtServiceTime.ValidatingType = typeof(int);
        // 
        // btnSaveSettings
        // 
        btnSaveSettings.Location = new Point(377, 264);
        btnSaveSettings.Margin = new Padding(3, 4, 3, 4);
        btnSaveSettings.Name = "btnSaveSettings";
        btnSaveSettings.Size = new Size(137, 43);
        btnSaveSettings.TabIndex = 25;
        btnSaveSettings.Text = "Save";
        btnSaveSettings.UseVisualStyleBackColor = true;
        btnSaveSettings.Click += btnSaveSettings_Click;
        // 
        // btnStartServices
        // 
        btnStartServices.Location = new Point(551, 264);
        btnStartServices.Margin = new Padding(3, 4, 3, 4);
        btnStartServices.Name = "btnStartServices";
        btnStartServices.Size = new Size(137, 43);
        btnStartServices.TabIndex = 24;
        btnStartServices.Text = "Start";
        btnStartServices.UseVisualStyleBackColor = true;
        btnStartServices.Click += btnStartServices_Click;
        // 
        // gbxServiceConf
        // 
        gbxServiceConf.Controls.Add(txtServiceSecretExecutionCode);
        gbxServiceConf.Controls.Add(txtServiceGroupExecution);
        gbxServiceConf.Controls.Add(lblServiceSecretExecutionCode);
        gbxServiceConf.Controls.Add(lblGroupExecution);
        gbxServiceConf.Location = new Point(390, 29);
        gbxServiceConf.Margin = new Padding(3, 4, 3, 4);
        gbxServiceConf.Name = "gbxServiceConf";
        gbxServiceConf.Padding = new Padding(3, 4, 3, 4);
        gbxServiceConf.Size = new Size(330, 184);
        gbxServiceConf.TabIndex = 23;
        gbxServiceConf.TabStop = false;
        gbxServiceConf.Text = "Execution keys";
        // 
        // txtServiceSecretExecutionCode
        // 
        txtServiceSecretExecutionCode.Location = new Point(16, 129);
        txtServiceSecretExecutionCode.Margin = new Padding(3, 4, 3, 4);
        txtServiceSecretExecutionCode.Name = "txtServiceSecretExecutionCode";
        txtServiceSecretExecutionCode.Size = new Size(210, 27);
        txtServiceSecretExecutionCode.TabIndex = 29;
        txtServiceSecretExecutionCode.UseSystemPasswordChar = true;
        // 
        // txtServiceGroupExecution
        // 
        txtServiceGroupExecution.Location = new Point(13, 60);
        txtServiceGroupExecution.Margin = new Padding(3, 4, 3, 4);
        txtServiceGroupExecution.Name = "txtServiceGroupExecution";
        txtServiceGroupExecution.Size = new Size(210, 27);
        txtServiceGroupExecution.TabIndex = 28;
        // 
        // lblServiceSecretExecutionCode
        // 
        lblServiceSecretExecutionCode.AutoSize = true;
        lblServiceSecretExecutionCode.Location = new Point(19, 105);
        lblServiceSecretExecutionCode.Name = "lblServiceSecretExecutionCode";
        lblServiceSecretExecutionCode.Size = new Size(157, 20);
        lblServiceSecretExecutionCode.TabIndex = 26;
        lblServiceSecretExecutionCode.Text = "Secret Execution Code";
        // 
        // lblGroupExecution
        // 
        lblGroupExecution.AutoSize = true;
        lblGroupExecution.Location = new Point(13, 36);
        lblGroupExecution.Name = "lblGroupExecution";
        lblGroupExecution.Size = new Size(121, 20);
        lblGroupExecution.TabIndex = 25;
        lblGroupExecution.Text = "Group Execution:";
        lblGroupExecution.TextAlign = ContentAlignment.TopCenter;
        // 
        // gbxServicesConfUserAccount
        // 
        gbxServicesConfUserAccount.Controls.Add(txtServiceRunPasswordAccount);
        gbxServicesConfUserAccount.Controls.Add(txtServiceRunUserNameAccount);
        gbxServicesConfUserAccount.Controls.Add(lblServiceRunPasswordAccount);
        gbxServicesConfUserAccount.Controls.Add(lblServiceRunUserNameAccount);
        gbxServicesConfUserAccount.Location = new Point(16, 116);
        gbxServicesConfUserAccount.Margin = new Padding(3, 4, 3, 4);
        gbxServicesConfUserAccount.Name = "gbxServicesConfUserAccount";
        gbxServicesConfUserAccount.Padding = new Padding(3, 4, 3, 4);
        gbxServicesConfUserAccount.Size = new Size(330, 184);
        gbxServicesConfUserAccount.TabIndex = 20;
        gbxServicesConfUserAccount.TabStop = false;
        gbxServicesConfUserAccount.Text = "User account for services run. (Optional)";
        gbxServicesConfUserAccount.Enter += gbxServicesConfUserAccount_Enter;
        // 
        // txtServiceRunPasswordAccount
        // 
        txtServiceRunPasswordAccount.Location = new Point(16, 129);
        txtServiceRunPasswordAccount.Margin = new Padding(3, 4, 3, 4);
        txtServiceRunPasswordAccount.Name = "txtServiceRunPasswordAccount";
        txtServiceRunPasswordAccount.Size = new Size(210, 27);
        txtServiceRunPasswordAccount.TabIndex = 29;
        txtServiceRunPasswordAccount.UseSystemPasswordChar = true;
        // 
        // txtServiceRunUserNameAccount
        // 
        txtServiceRunUserNameAccount.Location = new Point(13, 60);
        txtServiceRunUserNameAccount.Margin = new Padding(3, 4, 3, 4);
        txtServiceRunUserNameAccount.Name = "txtServiceRunUserNameAccount";
        txtServiceRunUserNameAccount.Size = new Size(210, 27);
        txtServiceRunUserNameAccount.TabIndex = 28;
        // 
        // lblServiceRunPasswordAccount
        // 
        lblServiceRunPasswordAccount.AutoSize = true;
        lblServiceRunPasswordAccount.Location = new Point(16, 105);
        lblServiceRunPasswordAccount.Name = "lblServiceRunPasswordAccount";
        lblServiceRunPasswordAccount.Size = new Size(73, 20);
        lblServiceRunPasswordAccount.TabIndex = 26;
        lblServiceRunPasswordAccount.Text = "Password:";
        // 
        // lblServiceRunUserNameAccount
        // 
        lblServiceRunUserNameAccount.AutoSize = true;
        lblServiceRunUserNameAccount.Location = new Point(13, 36);
        lblServiceRunUserNameAccount.Name = "lblServiceRunUserNameAccount";
        lblServiceRunUserNameAccount.Size = new Size(85, 20);
        lblServiceRunUserNameAccount.TabIndex = 25;
        lblServiceRunUserNameAccount.Text = "User Name:";
        lblServiceRunUserNameAccount.TextAlign = ContentAlignment.TopCenter;
        // 
        // lblServicesTimeConf
        // 
        lblServicesTimeConf.AutoSize = true;
        lblServicesTimeConf.Location = new Point(14, 40);
        lblServicesTimeConf.Name = "lblServicesTimeConf";
        lblServicesTimeConf.Size = new Size(338, 20);
        lblServicesTimeConf.TabIndex = 18;
        lblServicesTimeConf.Text = "Time interval in seconds to check new commands.";
        lblServicesTimeConf.TextAlign = ContentAlignment.TopCenter;
        // 
        // gbxStatusPanel
        // 
        gbxStatusPanel.Controls.Add(lblStatusPanelErros);
        gbxStatusPanel.Controls.Add(lblStatusPanelServiceStatus);
        gbxStatusPanel.Controls.Add(lblStatusPanelServiceStatusStatic);
        gbxStatusPanel.Location = new Point(22, 392);
        gbxStatusPanel.Margin = new Padding(3, 4, 3, 4);
        gbxStatusPanel.Name = "gbxStatusPanel";
        gbxStatusPanel.Padding = new Padding(3, 4, 3, 4);
        gbxStatusPanel.Size = new Size(1143, 93);
        gbxStatusPanel.TabIndex = 11;
        gbxStatusPanel.TabStop = false;
        gbxStatusPanel.Text = "Status Panel";
        // 
        // lblStatusPanelErros
        // 
        lblStatusPanelErros.AutoSize = true;
        lblStatusPanelErros.Location = new Point(536, 24);
        lblStatusPanelErros.Name = "lblStatusPanelErros";
        lblStatusPanelErros.Size = new Size(0, 20);
        lblStatusPanelErros.TabIndex = 28;
        // 
        // lblStatusPanelServiceStatus
        // 
        lblStatusPanelServiceStatus.AutoSize = true;
        lblStatusPanelServiceStatus.Location = new Point(113, 24);
        lblStatusPanelServiceStatus.Name = "lblStatusPanelServiceStatus";
        lblStatusPanelServiceStatus.Size = new Size(0, 20);
        lblStatusPanelServiceStatus.TabIndex = 28;
        // 
        // lblStatusPanelServiceStatusStatic
        // 
        lblStatusPanelServiceStatusStatic.AutoSize = true;
        lblStatusPanelServiceStatusStatic.Location = new Point(6, 24);
        lblStatusPanelServiceStatusStatic.Name = "lblStatusPanelServiceStatusStatic";
        lblStatusPanelServiceStatusStatic.Size = new Size(101, 20);
        lblStatusPanelServiceStatusStatic.TabIndex = 27;
        lblStatusPanelServiceStatusStatic.Text = "Service status:";
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(1187, 521);
        Controls.Add(gbxStatusPanel);
        Controls.Add(gbxServicesConf);
        Controls.Add(gbxServerConf);
        Margin = new Padding(3, 4, 3, 4);
        Name = "Form1";
        Text = "Form1";
        Load += Form1_Load;
        gbxServerConf.ResumeLayout(false);
        gbxServerConf.PerformLayout();
        gbxServicesConf.ResumeLayout(false);
        gbxServicesConf.PerformLayout();
        gbxServiceConf.ResumeLayout(false);
        gbxServiceConf.PerformLayout();
        gbxServicesConfUserAccount.ResumeLayout(false);
        gbxServicesConfUserAccount.PerformLayout();
        gbxStatusPanel.ResumeLayout(false);
        gbxStatusPanel.PerformLayout();
        ResumeLayout(false);
    }

    #endregion

    private GroupBox gbxServerConf;
    private Label lblServerPort;
    private TextBox txtServerPassword;
    private TextBox txtServerUserName;
    private TextBox txtServerAddress;
    private CheckBox chkUseSSL;
    private Label lblServerPassword;
    private Label lblServerUserName;
    private Label lblServerAddress;
    private GroupBox gbxServicesConf;
    private GroupBox gbxServicesConfUserAccount;
    private Label lblServicesTimeConf;
    private TextBox txtServiceRunPasswordAccount;
    private TextBox txtServiceRunUserNameAccount;
    private Label lblServiceRunPasswordAccount;
    private Label lblServiceRunUserNameAccount;
    private Button btnSaveSettings;
    private Button btnStartServices;
    private GroupBox gbxServiceConf;
    private TextBox txtServiceSecretExecutionCode;
    private TextBox txtServiceGroupExecution;
    private Label lblServiceSecretExecutionCode;
    private Label lblGroupExecution;
    private GroupBox gbxStatusPanel;
    private MaskedTextBox mkdTxtServerPort;
    private MaskedTextBox mkdTxtServiceTime;
    private Label lblStatusPanelServiceStatus;
    private Label lblStatusPanelServiceStatusStatic;
    private Label lblStatusPanelErros;
}
