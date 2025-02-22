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
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
        gbxServerConf = new GroupBox();
        label5 = new Label();
        mkdTxtSmtpServerPort = new MaskedTextBox();
        lblSmtpServerPort = new Label();
        mkdTxtSmtpServerPassword = new TextBox();
        txtSmtpServerUserName = new TextBox();
        txtSmtpServerAddress = new TextBox();
        chkUseSSLSmtpServer = new CheckBox();
        lblSmtpServerPassword = new Label();
        lblSmtpServerUserName = new Label();
        lblSmtpServerAddress = new Label();
        mkdTxtServerPort = new MaskedTextBox();
        lblImapServerPort = new Label();
        txtServerPassword = new TextBox();
        txtServerUserName = new TextBox();
        txtServerAddress = new TextBox();
        chkUseSSL = new CheckBox();
        lblServerPassword = new Label();
        lblServerUserName = new Label();
        lblServerAddress = new Label();
        gbxServiceConf = new GroupBox();
        gbxServicesExecutionKey = new GroupBox();
        txtServiceSecretExecutionCode = new TextBox();
        txtServiceGroupExecution = new TextBox();
        lblGroupExecution = new Label();
        lblServiceSecretExecutionCode = new Label();
        btnLoadAppsettings = new Button();
        btnSaveSettings = new Button();
        lblInfoServiceUserAccount = new Label();
        txtServiceRunPasswordAccount = new TextBox();
        txtServiceRunUserNameAccount = new TextBox();
        mkdTxtServiceTime = new MaskedTextBox();
        lblServiceRunPasswordAccount = new Label();
        lblServiceRunUserNameAccount = new Label();
        lblServicesTimeConf = new Label();
        btnStartServices = new Button();
        gbxStatusPanel = new GroupBox();
        lblStatusErrorPanelServiceStatusStatic = new Label();
        lblStatusPanelErros = new Label();
        lblStatusPanelServiceStatus = new Label();
        lblStatusPanelServiceStatusStatic = new Label();
        lblConfFilePath = new Label();
        txtConfFilePath = new TextBox();
        btnExit = new Button();
        gbxServerConf.SuspendLayout();
        gbxServicesExecutionKey.SuspendLayout();
        gbxStatusPanel.SuspendLayout();
        SuspendLayout();
        // 
        // gbxServerConf
        // 
        gbxServerConf.Controls.Add(label5);
        gbxServerConf.Controls.Add(mkdTxtSmtpServerPort);
        gbxServerConf.Controls.Add(lblSmtpServerPort);
        gbxServerConf.Controls.Add(mkdTxtSmtpServerPassword);
        gbxServerConf.Controls.Add(txtSmtpServerUserName);
        gbxServerConf.Controls.Add(txtSmtpServerAddress);
        gbxServerConf.Controls.Add(chkUseSSLSmtpServer);
        gbxServerConf.Controls.Add(lblSmtpServerPassword);
        gbxServerConf.Controls.Add(lblSmtpServerUserName);
        gbxServerConf.Controls.Add(lblSmtpServerAddress);
        gbxServerConf.Controls.Add(mkdTxtServerPort);
        gbxServerConf.Controls.Add(lblImapServerPort);
        gbxServerConf.Controls.Add(txtServerPassword);
        gbxServerConf.Controls.Add(txtServerUserName);
        gbxServerConf.Controls.Add(txtServerAddress);
        gbxServerConf.Controls.Add(chkUseSSL);
        gbxServerConf.Controls.Add(lblServerPassword);
        gbxServerConf.Controls.Add(lblServerUserName);
        gbxServerConf.Controls.Add(lblServerAddress);
        gbxServerConf.Location = new Point(15, 13);
        gbxServerConf.Margin = new Padding(3, 4, 3, 4);
        gbxServerConf.Name = "gbxServerConf";
        gbxServerConf.Padding = new Padding(3, 4, 3, 4);
        gbxServerConf.Size = new Size(769, 241);
        gbxServerConf.TabIndex = 9;
        gbxServerConf.TabStop = false;
        gbxServerConf.Text = "Imap Server Configurations";
        // 
        // label5
        // 
        label5.AutoSize = true;
        label5.Location = new Point(453, 0);
        label5.Name = "label5";
        label5.Size = new Size(193, 20);
        label5.TabIndex = 32;
        label5.Text = "Smtp Server Configurations:";
        // 
        // mkdTxtSmtpServerPort
        // 
        mkdTxtSmtpServerPort.Location = new Point(512, 71);
        mkdTxtSmtpServerPort.Margin = new Padding(3, 4, 3, 4);
        mkdTxtSmtpServerPort.Mask = "00000";
        mkdTxtSmtpServerPort.Name = "mkdTxtSmtpServerPort";
        mkdTxtSmtpServerPort.Size = new Size(41, 27);
        mkdTxtSmtpServerPort.TabIndex = 27;
        mkdTxtSmtpServerPort.ValidatingType = typeof(int);
        // 
        // lblSmtpServerPort
        // 
        lblSmtpServerPort.AutoSize = true;
        lblSmtpServerPort.Location = new Point(405, 71);
        lblSmtpServerPort.Name = "lblSmtpServerPort";
        lblSmtpServerPort.Size = new Size(77, 20);
        lblSmtpServerPort.TabIndex = 26;
        lblSmtpServerPort.Text = "Smtp Port:";
        lblSmtpServerPort.TextAlign = ContentAlignment.TopCenter;
        // 
        // mkdTxtSmtpServerPassword
        // 
        mkdTxtSmtpServerPassword.Location = new Point(511, 148);
        mkdTxtSmtpServerPassword.Margin = new Padding(3, 4, 3, 4);
        mkdTxtSmtpServerPassword.Name = "mkdTxtSmtpServerPassword";
        mkdTxtSmtpServerPassword.Size = new Size(210, 27);
        mkdTxtSmtpServerPassword.TabIndex = 25;
        mkdTxtSmtpServerPassword.UseSystemPasswordChar = true;
        // 
        // txtSmtpServerUserName
        // 
        txtSmtpServerUserName.Location = new Point(512, 111);
        txtSmtpServerUserName.Margin = new Padding(3, 4, 3, 4);
        txtSmtpServerUserName.Name = "txtSmtpServerUserName";
        txtSmtpServerUserName.Size = new Size(210, 27);
        txtSmtpServerUserName.TabIndex = 24;
        // 
        // txtSmtpServerAddress
        // 
        txtSmtpServerAddress.Location = new Point(511, 32);
        txtSmtpServerAddress.Margin = new Padding(3, 4, 3, 4);
        txtSmtpServerAddress.Name = "txtSmtpServerAddress";
        txtSmtpServerAddress.Size = new Size(242, 27);
        txtSmtpServerAddress.TabIndex = 23;
        // 
        // chkUseSSLSmtpServer
        // 
        chkUseSSLSmtpServer.AutoSize = true;
        chkUseSSLSmtpServer.Location = new Point(405, 189);
        chkUseSSLSmtpServer.Margin = new Padding(3, 4, 3, 4);
        chkUseSSLSmtpServer.Name = "chkUseSSLSmtpServer";
        chkUseSSLSmtpServer.Size = new Size(85, 24);
        chkUseSSLSmtpServer.TabIndex = 22;
        chkUseSSLSmtpServer.Text = "Use SSL:";
        chkUseSSLSmtpServer.UseVisualStyleBackColor = true;
        // 
        // lblSmtpServerPassword
        // 
        lblSmtpServerPassword.AutoSize = true;
        lblSmtpServerPassword.Location = new Point(405, 148);
        lblSmtpServerPassword.Name = "lblSmtpServerPassword";
        lblSmtpServerPassword.Size = new Size(73, 20);
        lblSmtpServerPassword.TabIndex = 21;
        lblSmtpServerPassword.Text = "Password:";
        // 
        // lblSmtpServerUserName
        // 
        lblSmtpServerUserName.AutoSize = true;
        lblSmtpServerUserName.Location = new Point(405, 111);
        lblSmtpServerUserName.Name = "lblSmtpServerUserName";
        lblSmtpServerUserName.Size = new Size(85, 20);
        lblSmtpServerUserName.TabIndex = 20;
        lblSmtpServerUserName.Text = "User Name:";
        lblSmtpServerUserName.TextAlign = ContentAlignment.TopCenter;
        // 
        // lblSmtpServerAddress
        // 
        lblSmtpServerAddress.AutoSize = true;
        lblSmtpServerAddress.Location = new Point(401, 32);
        lblSmtpServerAddress.Name = "lblSmtpServerAddress";
        lblSmtpServerAddress.Size = new Size(104, 20);
        lblSmtpServerAddress.TabIndex = 19;
        lblSmtpServerAddress.Text = "Smtp Address:";
        // 
        // mkdTxtServerPort
        // 
        mkdTxtServerPort.Location = new Point(133, 70);
        mkdTxtServerPort.Margin = new Padding(3, 4, 3, 4);
        mkdTxtServerPort.Mask = "00000";
        mkdTxtServerPort.Name = "mkdTxtServerPort";
        mkdTxtServerPort.Size = new Size(41, 27);
        mkdTxtServerPort.TabIndex = 18;
        mkdTxtServerPort.ValidatingType = typeof(int);
        mkdTxtServerPort.MaskInputRejected += mkdTxtServerPort_MaskInputRejected;
        // 
        // lblImapServerPort
        // 
        lblImapServerPort.AutoSize = true;
        lblImapServerPort.Location = new Point(22, 74);
        lblImapServerPort.Name = "lblImapServerPort";
        lblImapServerPort.Size = new Size(76, 20);
        lblImapServerPort.TabIndex = 16;
        lblImapServerPort.Text = "Imap Port:";
        lblImapServerPort.TextAlign = ContentAlignment.TopCenter;
        // 
        // txtServerPassword
        // 
        txtServerPassword.Location = new Point(133, 141);
        txtServerPassword.Margin = new Padding(3, 4, 3, 4);
        txtServerPassword.Name = "txtServerPassword";
        txtServerPassword.Size = new Size(210, 27);
        txtServerPassword.TabIndex = 15;
        txtServerPassword.UseSystemPasswordChar = true;
        // 
        // txtServerUserName
        // 
        txtServerUserName.Location = new Point(133, 106);
        txtServerUserName.Margin = new Padding(3, 4, 3, 4);
        txtServerUserName.Name = "txtServerUserName";
        txtServerUserName.Size = new Size(210, 27);
        txtServerUserName.TabIndex = 14;
        // 
        // txtServerAddress
        // 
        txtServerAddress.Location = new Point(133, 31);
        txtServerAddress.Margin = new Padding(3, 4, 3, 4);
        txtServerAddress.Name = "txtServerAddress";
        txtServerAddress.Size = new Size(242, 27);
        txtServerAddress.TabIndex = 13;
        txtServerAddress.TextChanged += txtServerAddress_TextChanged;
        // 
        // chkUseSSL
        // 
        chkUseSSL.AutoSize = true;
        chkUseSSL.Location = new Point(22, 188);
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
        lblServerPassword.Location = new Point(22, 150);
        lblServerPassword.Name = "lblServerPassword";
        lblServerPassword.Size = new Size(73, 20);
        lblServerPassword.TabIndex = 11;
        lblServerPassword.Text = "Password:";
        // 
        // lblServerUserName
        // 
        lblServerUserName.AutoSize = true;
        lblServerUserName.Location = new Point(22, 109);
        lblServerUserName.Name = "lblServerUserName";
        lblServerUserName.Size = new Size(85, 20);
        lblServerUserName.TabIndex = 10;
        lblServerUserName.Text = "User Name:";
        lblServerUserName.TextAlign = ContentAlignment.TopCenter;
        // 
        // lblServerAddress
        // 
        lblServerAddress.AutoSize = true;
        lblServerAddress.Location = new Point(22, 34);
        lblServerAddress.Name = "lblServerAddress";
        lblServerAddress.Size = new Size(103, 20);
        lblServerAddress.TabIndex = 9;
        lblServerAddress.Text = "Imap Address:";
        // 
        // gbxServiceConf
        // 
        gbxServiceConf.Location = new Point(398, 13);
        gbxServiceConf.Margin = new Padding(3, 4, 3, 4);
        gbxServiceConf.Name = "gbxServiceConf";
        gbxServiceConf.Padding = new Padding(3, 4, 3, 4);
        gbxServiceConf.Size = new Size(10, 240);
        gbxServiceConf.TabIndex = 23;
        gbxServiceConf.TabStop = false;
        // 
        // gbxServicesExecutionKey
        // 
        gbxServicesExecutionKey.Controls.Add(txtServiceSecretExecutionCode);
        gbxServicesExecutionKey.Controls.Add(txtServiceGroupExecution);
        gbxServicesExecutionKey.Controls.Add(lblGroupExecution);
        gbxServicesExecutionKey.Controls.Add(lblServiceSecretExecutionCode);
        gbxServicesExecutionKey.Location = new Point(791, 15);
        gbxServicesExecutionKey.Margin = new Padding(3, 4, 3, 4);
        gbxServicesExecutionKey.Name = "gbxServicesExecutionKey";
        gbxServicesExecutionKey.Padding = new Padding(3, 4, 3, 4);
        gbxServicesExecutionKey.Size = new Size(256, 238);
        gbxServicesExecutionKey.TabIndex = 10;
        gbxServicesExecutionKey.TabStop = false;
        gbxServicesExecutionKey.Text = "Execution keys";
        // 
        // txtServiceSecretExecutionCode
        // 
        txtServiceSecretExecutionCode.Location = new Point(18, 130);
        txtServiceSecretExecutionCode.Margin = new Padding(3, 4, 3, 4);
        txtServiceSecretExecutionCode.Name = "txtServiceSecretExecutionCode";
        txtServiceSecretExecutionCode.Size = new Size(210, 27);
        txtServiceSecretExecutionCode.TabIndex = 29;
        txtServiceSecretExecutionCode.UseSystemPasswordChar = true;
        // 
        // txtServiceGroupExecution
        // 
        txtServiceGroupExecution.Location = new Point(15, 61);
        txtServiceGroupExecution.Margin = new Padding(3, 4, 3, 4);
        txtServiceGroupExecution.Name = "txtServiceGroupExecution";
        txtServiceGroupExecution.Size = new Size(210, 27);
        txtServiceGroupExecution.TabIndex = 28;
        // 
        // lblGroupExecution
        // 
        lblGroupExecution.AutoSize = true;
        lblGroupExecution.Location = new Point(15, 37);
        lblGroupExecution.Name = "lblGroupExecution";
        lblGroupExecution.Size = new Size(121, 20);
        lblGroupExecution.TabIndex = 25;
        lblGroupExecution.Text = "Group Execution:";
        lblGroupExecution.TextAlign = ContentAlignment.TopCenter;
        // 
        // lblServiceSecretExecutionCode
        // 
        lblServiceSecretExecutionCode.AutoSize = true;
        lblServiceSecretExecutionCode.Location = new Point(21, 106);
        lblServiceSecretExecutionCode.Name = "lblServiceSecretExecutionCode";
        lblServiceSecretExecutionCode.Size = new Size(157, 20);
        lblServiceSecretExecutionCode.TabIndex = 26;
        lblServiceSecretExecutionCode.Text = "Secret Execution Code";
        // 
        // btnLoadAppsettings
        // 
        btnLoadAppsettings.Location = new Point(810, 310);
        btnLoadAppsettings.Margin = new Padding(3, 4, 3, 4);
        btnLoadAppsettings.Name = "btnLoadAppsettings";
        btnLoadAppsettings.Size = new Size(137, 43);
        btnLoadAppsettings.TabIndex = 32;
        btnLoadAppsettings.Text = "Load File";
        btnLoadAppsettings.UseVisualStyleBackColor = true;
        btnLoadAppsettings.Click += btnLoadAppsettings_Click;
        // 
        // btnSaveSettings
        // 
        btnSaveSettings.Location = new Point(976, 310);
        btnSaveSettings.Margin = new Padding(3, 4, 3, 4);
        btnSaveSettings.Name = "btnSaveSettings";
        btnSaveSettings.Size = new Size(137, 43);
        btnSaveSettings.TabIndex = 25;
        btnSaveSettings.Text = "Save";
        btnSaveSettings.UseVisualStyleBackColor = true;
        btnSaveSettings.Click += btnSaveSettings_Click;
        // 
        // lblInfoServiceUserAccount
        // 
        lblInfoServiceUserAccount.AutoSize = true;
        lblInfoServiceUserAccount.Location = new Point(1029, 387);
        lblInfoServiceUserAccount.Name = "lblInfoServiceUserAccount";
        lblInfoServiceUserAccount.Size = new Size(272, 20);
        lblInfoServiceUserAccount.TabIndex = 30;
        lblInfoServiceUserAccount.Text = "User account for services run. (Optional)";
        lblInfoServiceUserAccount.Visible = false;
        // 
        // txtServiceRunPasswordAccount
        // 
        txtServiceRunPasswordAccount.Location = new Point(1029, 491);
        txtServiceRunPasswordAccount.Margin = new Padding(3, 4, 3, 4);
        txtServiceRunPasswordAccount.Name = "txtServiceRunPasswordAccount";
        txtServiceRunPasswordAccount.Size = new Size(210, 27);
        txtServiceRunPasswordAccount.TabIndex = 29;
        txtServiceRunPasswordAccount.UseSystemPasswordChar = true;
        txtServiceRunPasswordAccount.Visible = false;
        // 
        // txtServiceRunUserNameAccount
        // 
        txtServiceRunUserNameAccount.Location = new Point(1029, 436);
        txtServiceRunUserNameAccount.Margin = new Padding(3, 4, 3, 4);
        txtServiceRunUserNameAccount.Name = "txtServiceRunUserNameAccount";
        txtServiceRunUserNameAccount.Size = new Size(210, 27);
        txtServiceRunUserNameAccount.TabIndex = 28;
        txtServiceRunUserNameAccount.Visible = false;
        // 
        // mkdTxtServiceTime
        // 
        mkdTxtServiceTime.Location = new Point(1032, 356);
        mkdTxtServiceTime.Margin = new Padding(3, 4, 3, 4);
        mkdTxtServiceTime.Mask = "00000";
        mkdTxtServiceTime.Name = "mkdTxtServiceTime";
        mkdTxtServiceTime.Size = new Size(39, 27);
        mkdTxtServiceTime.TabIndex = 26;
        mkdTxtServiceTime.ValidatingType = typeof(int);
        mkdTxtServiceTime.Visible = false;
        // 
        // lblServiceRunPasswordAccount
        // 
        lblServiceRunPasswordAccount.AutoSize = true;
        lblServiceRunPasswordAccount.Location = new Point(1029, 467);
        lblServiceRunPasswordAccount.Name = "lblServiceRunPasswordAccount";
        lblServiceRunPasswordAccount.Size = new Size(73, 20);
        lblServiceRunPasswordAccount.TabIndex = 26;
        lblServiceRunPasswordAccount.Text = "Password:";
        lblServiceRunPasswordAccount.Visible = false;
        // 
        // lblServiceRunUserNameAccount
        // 
        lblServiceRunUserNameAccount.AutoSize = true;
        lblServiceRunUserNameAccount.Location = new Point(1032, 412);
        lblServiceRunUserNameAccount.Name = "lblServiceRunUserNameAccount";
        lblServiceRunUserNameAccount.Size = new Size(85, 20);
        lblServiceRunUserNameAccount.TabIndex = 25;
        lblServiceRunUserNameAccount.Text = "User Name:";
        lblServiceRunUserNameAccount.TextAlign = ContentAlignment.TopCenter;
        lblServiceRunUserNameAccount.Visible = false;
        // 
        // lblServicesTimeConf
        // 
        lblServicesTimeConf.AutoSize = true;
        lblServicesTimeConf.Location = new Point(1030, 328);
        lblServicesTimeConf.Name = "lblServicesTimeConf";
        lblServicesTimeConf.Size = new Size(338, 20);
        lblServicesTimeConf.TabIndex = 18;
        lblServicesTimeConf.Text = "Time interval in seconds to check new commands.";
        lblServicesTimeConf.TextAlign = ContentAlignment.TopCenter;
        lblServicesTimeConf.Visible = false;
        // 
        // btnStartServices
        // 
        btnStartServices.Location = new Point(812, 394);
        btnStartServices.Margin = new Padding(3, 4, 3, 4);
        btnStartServices.Name = "btnStartServices";
        btnStartServices.Size = new Size(137, 43);
        btnStartServices.TabIndex = 24;
        btnStartServices.Text = "Start";
        btnStartServices.UseVisualStyleBackColor = true;
        btnStartServices.Click += btnStartServices_Click;
        // 
        // gbxStatusPanel
        // 
        gbxStatusPanel.Controls.Add(lblStatusErrorPanelServiceStatusStatic);
        gbxStatusPanel.Controls.Add(lblStatusPanelErros);
        gbxStatusPanel.Controls.Add(lblStatusPanelServiceStatus);
        gbxStatusPanel.Controls.Add(lblStatusPanelServiceStatusStatic);
        gbxStatusPanel.Location = new Point(10, 357);
        gbxStatusPanel.Margin = new Padding(3, 4, 3, 4);
        gbxStatusPanel.Name = "gbxStatusPanel";
        gbxStatusPanel.Padding = new Padding(3, 4, 3, 4);
        gbxStatusPanel.Size = new Size(774, 93);
        gbxStatusPanel.TabIndex = 11;
        gbxStatusPanel.TabStop = false;
        gbxStatusPanel.Text = "Status Panel";
        gbxStatusPanel.Enter += gbxStatusPanel_Enter;
        // 
        // lblStatusErrorPanelServiceStatusStatic
        // 
        lblStatusErrorPanelServiceStatusStatic.AutoSize = true;
        lblStatusErrorPanelServiceStatusStatic.Location = new Point(6, 52);
        lblStatusErrorPanelServiceStatusStatic.Name = "lblStatusErrorPanelServiceStatusStatic";
        lblStatusErrorPanelServiceStatusStatic.Size = new Size(44, 20);
        lblStatusErrorPanelServiceStatusStatic.TabIndex = 29;
        lblStatusErrorPanelServiceStatusStatic.Text = "Error:";
        // 
        // lblStatusPanelErros
        // 
        lblStatusPanelErros.AutoSize = true;
        lblStatusPanelErros.Location = new Point(45, 52);
        lblStatusPanelErros.Name = "lblStatusPanelErros";
        lblStatusPanelErros.Size = new Size(134, 20);
        lblStatusPanelErros.TabIndex = 28;
        lblStatusPanelErros.Text = "lblStatusPanelErros";
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
        // lblConfFilePath
        // 
        lblConfFilePath.AutoSize = true;
        lblConfFilePath.Location = new Point(14, 273);
        lblConfFilePath.Name = "lblConfFilePath";
        lblConfFilePath.Size = new Size(162, 20);
        lblConfFilePath.TabIndex = 29;
        lblConfFilePath.Text = "Configuration File Path:";
        // 
        // txtConfFilePath
        // 
        txtConfFilePath.Location = new Point(16, 305);
        txtConfFilePath.Name = "txtConfFilePath";
        txtConfFilePath.Size = new Size(759, 27);
        txtConfFilePath.TabIndex = 30;
        // 
        // btnExit
        // 
        btnExit.Location = new Point(976, 398);
        btnExit.Margin = new Padding(3, 4, 3, 4);
        btnExit.Name = "btnExit";
        btnExit.Size = new Size(137, 43);
        btnExit.TabIndex = 31;
        btnExit.Text = "Exit";
        btnExit.UseVisualStyleBackColor = true;
        btnExit.Click += btnExit_Click;
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(1125, 468);
        Controls.Add(btnSaveSettings);
        Controls.Add(btnLoadAppsettings);
        Controls.Add(gbxServiceConf);
        Controls.Add(btnStartServices);
        Controls.Add(lblConfFilePath);
        Controls.Add(txtConfFilePath);
        Controls.Add(btnExit);
        Controls.Add(lblInfoServiceUserAccount);
        Controls.Add(gbxStatusPanel);
        Controls.Add(gbxServicesExecutionKey);
        Controls.Add(gbxServerConf);
        Controls.Add(lblServicesTimeConf);
        Controls.Add(txtServiceRunUserNameAccount);
        Controls.Add(txtServiceRunPasswordAccount);
        Controls.Add(lblServiceRunPasswordAccount);
        Controls.Add(lblServiceRunUserNameAccount);
        Controls.Add(mkdTxtServiceTime);
        Icon = (Icon)resources.GetObject("$this.Icon");
        Margin = new Padding(3, 4, 3, 4);
        Name = "Form1";
        Text = "Form1";
        Load += Form1_Load;
        gbxServerConf.ResumeLayout(false);
        gbxServerConf.PerformLayout();
        gbxServicesExecutionKey.ResumeLayout(false);
        gbxServicesExecutionKey.PerformLayout();
        gbxStatusPanel.ResumeLayout(false);
        gbxStatusPanel.PerformLayout();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private GroupBox gbxServerConf;
    private Label lblImapServerPort;
    private TextBox txtServerPassword;
    private TextBox txtServerUserName;
    private TextBox txtServerAddress;
    private CheckBox chkUseSSL;
    private Label lblServerPassword;
    private Label lblServerUserName;
    private Label lblServerAddress;
    private GroupBox gbxServicesExecutionKey;
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
    private Label lblConfFilePath;
    private TextBox txtConfFilePath;
    private Button btnExit;
    private Button btnLoadAppsettings;
    private Label lblInfoServiceUserAccount;
    private MaskedTextBox mkdTxtSmtpServerPort;
    private Label lblSmtpServerPort;
    private TextBox mkdTxtSmtpServerPassword;
    private TextBox txtSmtpServerUserName;
    private TextBox txtSmtpServerAddress;
    private CheckBox chkUseSSLSmtpServer;
    private Label lblSmtpServerPassword;
    private Label lblSmtpServerUserName;
    private Label lblSmtpServerAddress;
    private Label label5;
    private Label lblStatusErrorPanelServiceStatusStatic;
}
