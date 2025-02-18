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
        gbxServerConf.Location = new Point(19, 12);
        gbxServerConf.Name = "gbxServerConf";
        gbxServerConf.Size = new Size(316, 262);
        gbxServerConf.TabIndex = 9;
        gbxServerConf.TabStop = false;
        gbxServerConf.Text = "Imap Server Configurations";
        // 
        // mkdTxtServerPort
        // 
        mkdTxtServerPort.Location = new Point(248, 46);
        mkdTxtServerPort.Mask = "00000";
        mkdTxtServerPort.Name = "mkdTxtServerPort";
        mkdTxtServerPort.Size = new Size(36, 23);
        mkdTxtServerPort.TabIndex = 18;
        mkdTxtServerPort.ValidatingType = typeof(int);
        // 
        // lblServerPort
        // 
        lblServerPort.AutoSize = true;
        lblServerPort.Location = new Point(234, 28);
        lblServerPort.Name = "lblServerPort";
        lblServerPort.Size = new Size(67, 15);
        lblServerPort.TabIndex = 16;
        lblServerPort.Text = "Server Port:";
        lblServerPort.TextAlign = ContentAlignment.TopCenter;
        // 
        // txtServerPassword
        // 
        txtServerPassword.Location = new Point(16, 145);
        txtServerPassword.Name = "txtServerPassword";
        txtServerPassword.Size = new Size(184, 23);
        txtServerPassword.TabIndex = 15;
        // 
        // txtServerUserName
        // 
        txtServerUserName.Location = new Point(13, 93);
        txtServerUserName.Name = "txtServerUserName";
        txtServerUserName.Size = new Size(184, 23);
        txtServerUserName.TabIndex = 14;
        // 
        // txtServerAddress
        // 
        txtServerAddress.Location = new Point(16, 46);
        txtServerAddress.Name = "txtServerAddress";
        txtServerAddress.Size = new Size(212, 23);
        txtServerAddress.TabIndex = 13;
        // 
        // chkUseSSL
        // 
        chkUseSSL.AutoSize = true;
        chkUseSSL.Location = new Point(16, 174);
        chkUseSSL.Name = "chkUseSSL";
        chkUseSSL.Size = new Size(69, 19);
        chkUseSSL.TabIndex = 12;
        chkUseSSL.Text = "Use SSL:";
        chkUseSSL.UseVisualStyleBackColor = true;
        // 
        // lblServerPassword
        // 
        lblServerPassword.AutoSize = true;
        lblServerPassword.Location = new Point(16, 127);
        lblServerPassword.Name = "lblServerPassword";
        lblServerPassword.Size = new Size(60, 15);
        lblServerPassword.TabIndex = 11;
        lblServerPassword.Text = "Password:";
        // 
        // lblServerUserName
        // 
        lblServerUserName.AutoSize = true;
        lblServerUserName.Location = new Point(13, 75);
        lblServerUserName.Name = "lblServerUserName";
        lblServerUserName.Size = new Size(68, 15);
        lblServerUserName.TabIndex = 10;
        lblServerUserName.Text = "User Name:";
        lblServerUserName.TextAlign = ContentAlignment.TopCenter;
        // 
        // lblServerAddress
        // 
        lblServerAddress.AutoSize = true;
        lblServerAddress.Location = new Point(16, 28);
        lblServerAddress.Name = "lblServerAddress";
        lblServerAddress.Size = new Size(117, 15);
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
        gbxServicesConf.Location = new Point(365, 12);
        gbxServicesConf.Name = "gbxServicesConf";
        gbxServicesConf.Size = new Size(654, 262);
        gbxServicesConf.TabIndex = 10;
        gbxServicesConf.TabStop = false;
        gbxServicesConf.Text = "Service Configurations";
        // 
        // mkdTxtServiceTime
        // 
        mkdTxtServiceTime.Location = new Point(14, 49);
        mkdTxtServiceTime.Mask = "00000";
        mkdTxtServiceTime.Name = "mkdTxtServiceTime";
        mkdTxtServiceTime.Size = new Size(35, 23);
        mkdTxtServiceTime.TabIndex = 26;
        mkdTxtServiceTime.ValidatingType = typeof(int);
        // 
        // btnSaveSettings
        // 
        btnSaveSettings.Location = new Point(330, 198);
        btnSaveSettings.Name = "btnSaveSettings";
        btnSaveSettings.Size = new Size(120, 32);
        btnSaveSettings.TabIndex = 25;
        btnSaveSettings.Text = "Save";
        btnSaveSettings.UseVisualStyleBackColor = true;
        btnSaveSettings.Click += btnSaveSettings_Click;
        // 
        // btnStartServices
        // 
        btnStartServices.Location = new Point(482, 198);
        btnStartServices.Name = "btnStartServices";
        btnStartServices.Size = new Size(120, 32);
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
        gbxServiceConf.Location = new Point(341, 22);
        gbxServiceConf.Name = "gbxServiceConf";
        gbxServiceConf.Size = new Size(289, 138);
        gbxServiceConf.TabIndex = 23;
        gbxServiceConf.TabStop = false;
        gbxServiceConf.Text = "Execution keys";
        // 
        // txtServiceSecretExecutionCode
        // 
        txtServiceSecretExecutionCode.Location = new Point(14, 97);
        txtServiceSecretExecutionCode.Name = "txtServiceSecretExecutionCode";
        txtServiceSecretExecutionCode.Size = new Size(184, 23);
        txtServiceSecretExecutionCode.TabIndex = 29;
        // 
        // txtServiceGroupExecution
        // 
        txtServiceGroupExecution.Location = new Point(11, 45);
        txtServiceGroupExecution.Name = "txtServiceGroupExecution";
        txtServiceGroupExecution.Size = new Size(184, 23);
        txtServiceGroupExecution.TabIndex = 28;
        // 
        // lblServiceSecretExecutionCode
        // 
        lblServiceSecretExecutionCode.AutoSize = true;
        lblServiceSecretExecutionCode.Location = new Point(17, 79);
        lblServiceSecretExecutionCode.Name = "lblServiceSecretExecutionCode";
        lblServiceSecretExecutionCode.Size = new Size(125, 15);
        lblServiceSecretExecutionCode.TabIndex = 26;
        lblServiceSecretExecutionCode.Text = "Secret Execution Code";
        // 
        // lblGroupExecution
        // 
        lblGroupExecution.AutoSize = true;
        lblGroupExecution.Location = new Point(11, 27);
        lblGroupExecution.Name = "lblGroupExecution";
        lblGroupExecution.Size = new Size(98, 15);
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
        gbxServicesConfUserAccount.Location = new Point(14, 87);
        gbxServicesConfUserAccount.Name = "gbxServicesConfUserAccount";
        gbxServicesConfUserAccount.Size = new Size(289, 138);
        gbxServicesConfUserAccount.TabIndex = 20;
        gbxServicesConfUserAccount.TabStop = false;
        gbxServicesConfUserAccount.Text = "User account for services run. (Optional)";
        gbxServicesConfUserAccount.Enter += gbxServicesConfUserAccount_Enter;
        // 
        // txtServiceRunPasswordAccount
        // 
        txtServiceRunPasswordAccount.Location = new Point(14, 97);
        txtServiceRunPasswordAccount.Name = "txtServiceRunPasswordAccount";
        txtServiceRunPasswordAccount.Size = new Size(184, 23);
        txtServiceRunPasswordAccount.TabIndex = 29;
        // 
        // txtServiceRunUserNameAccount
        // 
        txtServiceRunUserNameAccount.Location = new Point(11, 45);
        txtServiceRunUserNameAccount.Name = "txtServiceRunUserNameAccount";
        txtServiceRunUserNameAccount.Size = new Size(184, 23);
        txtServiceRunUserNameAccount.TabIndex = 28;
        // 
        // lblServiceRunPasswordAccount
        // 
        lblServiceRunPasswordAccount.AutoSize = true;
        lblServiceRunPasswordAccount.Location = new Point(14, 79);
        lblServiceRunPasswordAccount.Name = "lblServiceRunPasswordAccount";
        lblServiceRunPasswordAccount.Size = new Size(60, 15);
        lblServiceRunPasswordAccount.TabIndex = 26;
        lblServiceRunPasswordAccount.Text = "Password:";
        // 
        // lblServiceRunUserNameAccount
        // 
        lblServiceRunUserNameAccount.AutoSize = true;
        lblServiceRunUserNameAccount.Location = new Point(11, 27);
        lblServiceRunUserNameAccount.Name = "lblServiceRunUserNameAccount";
        lblServiceRunUserNameAccount.Size = new Size(68, 15);
        lblServiceRunUserNameAccount.TabIndex = 25;
        lblServiceRunUserNameAccount.Text = "User Name:";
        lblServiceRunUserNameAccount.TextAlign = ContentAlignment.TopCenter;
        // 
        // lblServicesTimeConf
        // 
        lblServicesTimeConf.AutoSize = true;
        lblServicesTimeConf.Location = new Point(12, 30);
        lblServicesTimeConf.Name = "lblServicesTimeConf";
        lblServicesTimeConf.Size = new Size(273, 15);
        lblServicesTimeConf.TabIndex = 18;
        lblServicesTimeConf.Text = "Time interval in seconds to check new commands.";
        lblServicesTimeConf.TextAlign = ContentAlignment.TopCenter;
        // 
        // gbxStatusPanel
        // 
        gbxStatusPanel.Controls.Add(lblStatusPanelErros);
        gbxStatusPanel.Controls.Add(lblStatusPanelServiceStatus);
        gbxStatusPanel.Controls.Add(lblStatusPanelServiceStatusStatic);
        gbxStatusPanel.Location = new Point(19, 294);
        gbxStatusPanel.Name = "gbxStatusPanel";
        gbxStatusPanel.Size = new Size(1000, 70);
        gbxStatusPanel.TabIndex = 11;
        gbxStatusPanel.TabStop = false;
        gbxStatusPanel.Text = "Status Panel";
        // 
        // lblStatusPanelErros
        // 
        lblStatusPanelErros.AutoSize = true;
        lblStatusPanelErros.Location = new Point(469, 18);
        lblStatusPanelErros.Name = "lblStatusPanelErros";
        lblStatusPanelErros.Size = new Size(0, 15);
        lblStatusPanelErros.TabIndex = 28;
        // 
        // lblStatusPanelServiceStatus
        // 
        lblStatusPanelServiceStatus.AutoSize = true;
        lblStatusPanelServiceStatus.Location = new Point(99, 18);
        lblStatusPanelServiceStatus.Name = "lblStatusPanelServiceStatus";
        lblStatusPanelServiceStatus.Size = new Size(0, 15);
        lblStatusPanelServiceStatus.TabIndex = 28;
        // 
        // lblStatusPanelServiceStatusStatic
        // 
        lblStatusPanelServiceStatusStatic.AutoSize = true;
        lblStatusPanelServiceStatusStatic.Location = new Point(5, 18);
        lblStatusPanelServiceStatusStatic.Name = "lblStatusPanelServiceStatusStatic";
        lblStatusPanelServiceStatusStatic.Size = new Size(81, 15);
        lblStatusPanelServiceStatusStatic.TabIndex = 27;
        lblStatusPanelServiceStatusStatic.Text = "Service status:";
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(1039, 391);
        Controls.Add(gbxStatusPanel);
        Controls.Add(gbxServicesConf);
        Controls.Add(gbxServerConf);
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
