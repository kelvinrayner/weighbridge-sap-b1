using System.Drawing;
using System.Windows.Forms;

namespace Weighbridge
{
    partial class FormSync
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSync));
            this.tabCtrlMain = new System.Windows.Forms.TabControl();
            this.tabLogin = new System.Windows.Forms.TabPage();
            this.lbPass = new System.Windows.Forms.Label();
            this.lbUsr = new System.Windows.Forms.Label();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.tbLoginPass = new System.Windows.Forms.TextBox();
            this.tbLoginUsrnm = new System.Windows.Forms.TextBox();
            this.tabConfig = new System.Windows.Forms.TabPage();
            this.tabCtrlConfig = new System.Windows.Forms.TabControl();
            this.tabAppDB = new System.Windows.Forms.TabPage();
            this.btnSvConfig = new System.Windows.Forms.Button();
            this.gbDB = new System.Windows.Forms.GroupBox();
            this.tbDBPass = new System.Windows.Forms.TextBox();
            this.tbDBUsrnm = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbDBUsrnm = new System.Windows.Forms.Label();
            this.tbSBOPass = new System.Windows.Forms.TextBox();
            this.tbSBOUsrnm = new System.Windows.Forms.TextBox();
            this.tbDBSBO = new System.Windows.Forms.TextBox();
            this.tbDBSrv = new System.Windows.Forms.TextBox();
            this.cbSrvType = new System.Windows.Forms.ComboBox();
            this.lbDBPass = new System.Windows.Forms.Label();
            this.lbUsrnm = new System.Windows.Forms.Label();
            this.lbDB = new System.Windows.Forms.Label();
            this.lbServerNm = new System.Windows.Forms.Label();
            this.lbSvrType = new System.Windows.Forms.Label();
            this.gbApp = new System.Windows.Forms.GroupBox();
            this.lbTestQtyTimbang = new System.Windows.Forms.Label();
            this.btnTestWBConn = new System.Windows.Forms.Button();
            this.tbWriteT = new System.Windows.Forms.TextBox();
            this.tbReadT = new System.Windows.Forms.TextBox();
            this.tbDataBits = new System.Windows.Forms.TextBox();
            this.tbBaudRate = new System.Windows.Forms.TextBox();
            this.cbPort = new System.Windows.Forms.ComboBox();
            this.lbWriteT = new System.Windows.Forms.Label();
            this.lbReadT = new System.Windows.Forms.Label();
            this.lbDataBits = new System.Windows.Forms.Label();
            this.lbBaudRate = new System.Windows.Forms.Label();
            this.lbPort = new System.Windows.Forms.Label();
            this.tabWB = new System.Windows.Forms.TabPage();
            this.lbNoKontrak = new System.Windows.Forms.Label();
            this.tbJnsTruck = new System.Windows.Forms.TextBox();
            this.lbJnsTruck = new System.Windows.Forms.Label();
            this.lbDateTime = new System.Windows.Forms.Label();
            this.cbWINDocType = new System.Windows.Forms.ComboBox();
            this.gbWINKen = new System.Windows.Forms.GroupBox();
            this.tbMOISTKebun = new System.Windows.Forms.TextBox();
            this.tbFFAKebun = new System.Windows.Forms.TextBox();
            this.lbMOISTKebun = new System.Windows.Forms.Label();
            this.lbFFAKebun = new System.Windows.Forms.Label();
            this.tbNettoKebun = new System.Windows.Forms.TextBox();
            this.lblNettoKebun = new System.Windows.Forms.Label();
            this.tbTaraKebun = new System.Windows.Forms.TextBox();
            this.lblTaraKebun = new System.Windows.Forms.Label();
            this.tbBrutoKebun = new System.Windows.Forms.TextBox();
            this.lblBrutoKebun = new System.Windows.Forms.Label();
            this.lblNetto = new System.Windows.Forms.Label();
            this.lbHasilUjiLab = new System.Windows.Forms.Label();
            this.gbUjiLab = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.tbDOBI = new System.Windows.Forms.TextBox();
            this.tbIMP = new System.Windows.Forms.TextBox();
            this.tbMOIST = new System.Windows.Forms.TextBox();
            this.tbCAROTINE = new System.Windows.Forms.TextBox();
            this.lblCAROTINE = new System.Windows.Forms.Label();
            this.lblDOBI = new System.Windows.Forms.Label();
            this.lblIMP = new System.Windows.Forms.Label();
            this.lblMoist = new System.Windows.Forms.Label();
            this.tbFFA = new System.Windows.Forms.TextBox();
            this.lblFFA = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.btnTimbangKeluar = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.cbWINManual = new System.Windows.Forms.CheckBox();
            this.btnTimbangMasuk = new System.Windows.Forms.Button();
            this.tbQtyMasuk = new System.Windows.Forms.TextBox();
            this.btnWINSave = new System.Windows.Forms.Button();
            this.btnCariBaseDoc = new System.Windows.Forms.Button();
            this.tbWINBaseDoc = new System.Windows.Forms.TextBox();
            this.lbTiketNum = new System.Windows.Forms.Label();
            this.lbWINBaseDoc = new System.Windows.Forms.Label();
            this.tbTiketNum = new System.Windows.Forms.TextBox();
            this.tbWINNopol = new System.Windows.Forms.TextBox();
            this.tbWINEksCod = new System.Windows.Forms.TextBox();
            this.lbWINNopol = new System.Windows.Forms.Label();
            this.lbWINSupir = new System.Windows.Forms.Label();
            this.tbWINSupir = new System.Windows.Forms.TextBox();
            this.lbWINEksCod = new System.Windows.Forms.Label();
            this.tabUpdateDO = new System.Windows.Forms.TabPage();
            this.lbNoKontrakDO = new System.Windows.Forms.Label();
            this.btnUpdateDO = new System.Windows.Forms.Button();
            this.cbManualDO = new System.Windows.Forms.CheckBox();
            this.btnTimbangDO = new System.Windows.Forms.Button();
            this.tbQtyTimbangDO = new System.Windows.Forms.TextBox();
            this.lbDateTimeDO = new System.Windows.Forms.Label();
            this.btnSearchDO = new System.Windows.Forms.Button();
            this.tbDODocNum = new System.Windows.Forms.TextBox();
            this.lbDODocNum = new System.Windows.Forms.Label();
            this.runningTime = new System.Windows.Forms.Timer(this.components);
            this.tabCtrlMain.SuspendLayout();
            this.tabLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.tabConfig.SuspendLayout();
            this.tabCtrlConfig.SuspendLayout();
            this.tabAppDB.SuspendLayout();
            this.gbDB.SuspendLayout();
            this.gbApp.SuspendLayout();
            this.tabWB.SuspendLayout();
            this.gbWINKen.SuspendLayout();
            this.gbUjiLab.SuspendLayout();
            this.tabUpdateDO.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabCtrlMain
            // 
            this.tabCtrlMain.Controls.Add(this.tabLogin);
            this.tabCtrlMain.Controls.Add(this.tabConfig);
            this.tabCtrlMain.Controls.Add(this.tabWB);
            this.tabCtrlMain.Controls.Add(this.tabUpdateDO);
            this.tabCtrlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabCtrlMain.Location = new System.Drawing.Point(0, 0);
            this.tabCtrlMain.Name = "tabCtrlMain";
            this.tabCtrlMain.SelectedIndex = 0;
            this.tabCtrlMain.Size = new System.Drawing.Size(738, 553);
            this.tabCtrlMain.TabIndex = 0;
            // 
            // tabLogin
            // 
            this.tabLogin.Controls.Add(this.lbPass);
            this.tabLogin.Controls.Add(this.lbUsr);
            this.tabLogin.Controls.Add(this.pbLogo);
            this.tabLogin.Controls.Add(this.btnLogin);
            this.tabLogin.Controls.Add(this.tbLoginPass);
            this.tabLogin.Controls.Add(this.tbLoginUsrnm);
            this.tabLogin.Location = new System.Drawing.Point(4, 22);
            this.tabLogin.Name = "tabLogin";
            this.tabLogin.Padding = new System.Windows.Forms.Padding(3);
            this.tabLogin.Size = new System.Drawing.Size(730, 527);
            this.tabLogin.TabIndex = 0;
            this.tabLogin.Text = "Login";
            this.tabLogin.UseVisualStyleBackColor = true;
            // 
            // lbPass
            // 
            this.lbPass.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbPass.AutoSize = true;
            this.lbPass.Location = new System.Drawing.Point(74, 338);
            this.lbPass.Name = "lbPass";
            this.lbPass.Size = new System.Drawing.Size(56, 13);
            this.lbPass.TabIndex = 7;
            this.lbPass.Text = "Password:";
            // 
            // lbUsr
            // 
            this.lbUsr.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbUsr.AutoSize = true;
            this.lbUsr.Location = new System.Drawing.Point(74, 289);
            this.lbUsr.Name = "lbUsr";
            this.lbUsr.Size = new System.Drawing.Size(58, 13);
            this.lbUsr.TabIndex = 6;
            this.lbUsr.Text = "Username:";
            // 
            // pbLogo
            // 
            this.pbLogo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pbLogo.BackColor = System.Drawing.Color.Transparent;
            this.pbLogo.ImageLocation = "";
            this.pbLogo.Location = new System.Drawing.Point(246, 76);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(218, 198);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLogo.TabIndex = 5;
            this.pbLogo.TabStop = false;
            // 
            // btnLogin
            // 
            this.btnLogin.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnLogin.Location = new System.Drawing.Point(588, 389);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(87, 24);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // tbLoginPass
            // 
            this.tbLoginPass.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbLoginPass.Location = new System.Drawing.Point(74, 354);
            this.tbLoginPass.Name = "tbLoginPass";
            this.tbLoginPass.PasswordChar = '●';
            this.tbLoginPass.Size = new System.Drawing.Size(601, 20);
            this.tbLoginPass.TabIndex = 1;
            // 
            // tbLoginUsrnm
            // 
            this.tbLoginUsrnm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbLoginUsrnm.Location = new System.Drawing.Point(74, 308);
            this.tbLoginUsrnm.Name = "tbLoginUsrnm";
            this.tbLoginUsrnm.Size = new System.Drawing.Size(601, 20);
            this.tbLoginUsrnm.TabIndex = 0;
            // 
            // tabConfig
            // 
            this.tabConfig.Controls.Add(this.tabCtrlConfig);
            this.tabConfig.Location = new System.Drawing.Point(4, 22);
            this.tabConfig.Name = "tabConfig";
            this.tabConfig.Padding = new System.Windows.Forms.Padding(3);
            this.tabConfig.Size = new System.Drawing.Size(730, 527);
            this.tabConfig.TabIndex = 1;
            this.tabConfig.Text = "Configuration";
            this.tabConfig.UseVisualStyleBackColor = true;
            // 
            // tabCtrlConfig
            // 
            this.tabCtrlConfig.Controls.Add(this.tabAppDB);
            this.tabCtrlConfig.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabCtrlConfig.Location = new System.Drawing.Point(3, 3);
            this.tabCtrlConfig.Name = "tabCtrlConfig";
            this.tabCtrlConfig.SelectedIndex = 0;
            this.tabCtrlConfig.Size = new System.Drawing.Size(724, 521);
            this.tabCtrlConfig.TabIndex = 0;
            // 
            // tabAppDB
            // 
            this.tabAppDB.Controls.Add(this.btnSvConfig);
            this.tabAppDB.Controls.Add(this.gbDB);
            this.tabAppDB.Controls.Add(this.gbApp);
            this.tabAppDB.Location = new System.Drawing.Point(4, 22);
            this.tabAppDB.Name = "tabAppDB";
            this.tabAppDB.Padding = new System.Windows.Forms.Padding(3);
            this.tabAppDB.Size = new System.Drawing.Size(716, 495);
            this.tabAppDB.TabIndex = 0;
            this.tabAppDB.Text = "Application & Database";
            this.tabAppDB.UseVisualStyleBackColor = true;
            // 
            // btnSvConfig
            // 
            this.btnSvConfig.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSvConfig.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSvConfig.Location = new System.Drawing.Point(626, 466);
            this.btnSvConfig.Name = "btnSvConfig";
            this.btnSvConfig.Size = new System.Drawing.Size(84, 24);
            this.btnSvConfig.TabIndex = 2;
            this.btnSvConfig.Text = "Save";
            this.btnSvConfig.UseVisualStyleBackColor = true;
            this.btnSvConfig.Click += new System.EventHandler(this.btnSvConfig_Click);
            // 
            // gbDB
            // 
            this.gbDB.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbDB.Controls.Add(this.tbDBPass);
            this.gbDB.Controls.Add(this.tbDBUsrnm);
            this.gbDB.Controls.Add(this.label1);
            this.gbDB.Controls.Add(this.lbDBUsrnm);
            this.gbDB.Controls.Add(this.tbSBOPass);
            this.gbDB.Controls.Add(this.tbSBOUsrnm);
            this.gbDB.Controls.Add(this.tbDBSBO);
            this.gbDB.Controls.Add(this.tbDBSrv);
            this.gbDB.Controls.Add(this.cbSrvType);
            this.gbDB.Controls.Add(this.lbDBPass);
            this.gbDB.Controls.Add(this.lbUsrnm);
            this.gbDB.Controls.Add(this.lbDB);
            this.gbDB.Controls.Add(this.lbServerNm);
            this.gbDB.Controls.Add(this.lbSvrType);
            this.gbDB.Location = new System.Drawing.Point(356, 3);
            this.gbDB.Name = "gbDB";
            this.gbDB.Size = new System.Drawing.Size(354, 459);
            this.gbDB.TabIndex = 1;
            this.gbDB.TabStop = false;
            this.gbDB.Text = "SBO Database";
            // 
            // tbDBPass
            // 
            this.tbDBPass.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbDBPass.Location = new System.Drawing.Point(116, 124);
            this.tbDBPass.Name = "tbDBPass";
            this.tbDBPass.Size = new System.Drawing.Size(236, 20);
            this.tbDBPass.TabIndex = 15;
            // 
            // tbDBUsrnm
            // 
            this.tbDBUsrnm.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbDBUsrnm.Location = new System.Drawing.Point(116, 99);
            this.tbDBUsrnm.Name = "tbDBUsrnm";
            this.tbDBUsrnm.Size = new System.Drawing.Size(236, 20);
            this.tbDBUsrnm.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Database Password";
            // 
            // lbDBUsrnm
            // 
            this.lbDBUsrnm.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbDBUsrnm.AutoSize = true;
            this.lbDBUsrnm.Location = new System.Drawing.Point(5, 102);
            this.lbDBUsrnm.Name = "lbDBUsrnm";
            this.lbDBUsrnm.Size = new System.Drawing.Size(104, 13);
            this.lbDBUsrnm.TabIndex = 12;
            this.lbDBUsrnm.Text = "Database Username";
            // 
            // tbSBOPass
            // 
            this.tbSBOPass.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbSBOPass.Location = new System.Drawing.Point(116, 175);
            this.tbSBOPass.Name = "tbSBOPass";
            this.tbSBOPass.Size = new System.Drawing.Size(236, 20);
            this.tbSBOPass.TabIndex = 11;
            // 
            // tbSBOUsrnm
            // 
            this.tbSBOUsrnm.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbSBOUsrnm.Location = new System.Drawing.Point(116, 150);
            this.tbSBOUsrnm.Name = "tbSBOUsrnm";
            this.tbSBOUsrnm.Size = new System.Drawing.Size(236, 20);
            this.tbSBOUsrnm.TabIndex = 10;
            // 
            // tbDBSBO
            // 
            this.tbDBSBO.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbDBSBO.Location = new System.Drawing.Point(116, 73);
            this.tbDBSBO.Name = "tbDBSBO";
            this.tbDBSBO.Size = new System.Drawing.Size(236, 20);
            this.tbDBSBO.TabIndex = 9;
            // 
            // tbDBSrv
            // 
            this.tbDBSrv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbDBSrv.Location = new System.Drawing.Point(116, 48);
            this.tbDBSrv.Name = "tbDBSrv";
            this.tbDBSrv.Size = new System.Drawing.Size(236, 20);
            this.tbDBSrv.TabIndex = 7;
            // 
            // cbSrvType
            // 
            this.cbSrvType.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbSrvType.FormattingEnabled = true;
            this.cbSrvType.Items.AddRange(new object[] {
            "MSSQL2012",
            "MSSQL2014",
            "MSSQL2016",
            "MSSQL2017",
            "MSSQL2019",
            "HANA"});
            this.cbSrvType.Location = new System.Drawing.Point(116, 23);
            this.cbSrvType.Name = "cbSrvType";
            this.cbSrvType.Size = new System.Drawing.Size(236, 21);
            this.cbSrvType.TabIndex = 6;
            // 
            // lbDBPass
            // 
            this.lbDBPass.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbDBPass.AutoSize = true;
            this.lbDBPass.Location = new System.Drawing.Point(5, 177);
            this.lbDBPass.Name = "lbDBPass";
            this.lbDBPass.Size = new System.Drawing.Size(78, 13);
            this.lbDBPass.TabIndex = 5;
            this.lbDBPass.Text = "SBO Password";
            // 
            // lbUsrnm
            // 
            this.lbUsrnm.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbUsrnm.AutoSize = true;
            this.lbUsrnm.Location = new System.Drawing.Point(5, 153);
            this.lbUsrnm.Name = "lbUsrnm";
            this.lbUsrnm.Size = new System.Drawing.Size(80, 13);
            this.lbUsrnm.TabIndex = 4;
            this.lbUsrnm.Text = "SBO Username";
            // 
            // lbDB
            // 
            this.lbDB.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbDB.AutoSize = true;
            this.lbDB.Location = new System.Drawing.Point(5, 76);
            this.lbDB.Name = "lbDB";
            this.lbDB.Size = new System.Drawing.Size(53, 13);
            this.lbDB.TabIndex = 3;
            this.lbDB.Text = "Database";
            // 
            // lbServerNm
            // 
            this.lbServerNm.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbServerNm.AutoSize = true;
            this.lbServerNm.Location = new System.Drawing.Point(5, 50);
            this.lbServerNm.Name = "lbServerNm";
            this.lbServerNm.Size = new System.Drawing.Size(38, 13);
            this.lbServerNm.TabIndex = 1;
            this.lbServerNm.Text = "Server";
            // 
            // lbSvrType
            // 
            this.lbSvrType.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbSvrType.AutoSize = true;
            this.lbSvrType.Location = new System.Drawing.Point(5, 26);
            this.lbSvrType.Name = "lbSvrType";
            this.lbSvrType.Size = new System.Drawing.Size(65, 13);
            this.lbSvrType.TabIndex = 0;
            this.lbSvrType.Text = "Server Type";
            // 
            // gbApp
            // 
            this.gbApp.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbApp.Controls.Add(this.lbTestQtyTimbang);
            this.gbApp.Controls.Add(this.btnTestWBConn);
            this.gbApp.Controls.Add(this.tbWriteT);
            this.gbApp.Controls.Add(this.tbReadT);
            this.gbApp.Controls.Add(this.tbDataBits);
            this.gbApp.Controls.Add(this.tbBaudRate);
            this.gbApp.Controls.Add(this.cbPort);
            this.gbApp.Controls.Add(this.lbWriteT);
            this.gbApp.Controls.Add(this.lbReadT);
            this.gbApp.Controls.Add(this.lbDataBits);
            this.gbApp.Controls.Add(this.lbBaudRate);
            this.gbApp.Controls.Add(this.lbPort);
            this.gbApp.Location = new System.Drawing.Point(3, 3);
            this.gbApp.Name = "gbApp";
            this.gbApp.Size = new System.Drawing.Size(349, 459);
            this.gbApp.TabIndex = 0;
            this.gbApp.TabStop = false;
            this.gbApp.Text = "Weighbridge";
            // 
            // lbTestQtyTimbang
            // 
            this.lbTestQtyTimbang.AutoSize = true;
            this.lbTestQtyTimbang.Location = new System.Drawing.Point(223, 202);
            this.lbTestQtyTimbang.Name = "lbTestQtyTimbang";
            this.lbTestQtyTimbang.Size = new System.Drawing.Size(91, 13);
            this.lbTestQtyTimbang.TabIndex = 11;
            this.lbTestQtyTimbang.Text = "Test Qty Timbang";
            // 
            // btnTestWBConn
            // 
            this.btnTestWBConn.Location = new System.Drawing.Point(223, 172);
            this.btnTestWBConn.Name = "btnTestWBConn";
            this.btnTestWBConn.Size = new System.Drawing.Size(116, 23);
            this.btnTestWBConn.TabIndex = 10;
            this.btnTestWBConn.Text = "Test WB Connection";
            this.btnTestWBConn.UseVisualStyleBackColor = true;
            this.btnTestWBConn.Click += new System.EventHandler(this.btnTestWBConn_Click);
            // 
            // tbWriteT
            // 
            this.tbWriteT.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tbWriteT.Location = new System.Drawing.Point(116, 120);
            this.tbWriteT.Name = "tbWriteT";
            this.tbWriteT.Size = new System.Drawing.Size(223, 20);
            this.tbWriteT.TabIndex = 9;
            // 
            // tbReadT
            // 
            this.tbReadT.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tbReadT.Location = new System.Drawing.Point(116, 96);
            this.tbReadT.Name = "tbReadT";
            this.tbReadT.Size = new System.Drawing.Size(223, 20);
            this.tbReadT.TabIndex = 8;
            // 
            // tbDataBits
            // 
            this.tbDataBits.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tbDataBits.Location = new System.Drawing.Point(115, 72);
            this.tbDataBits.Name = "tbDataBits";
            this.tbDataBits.Size = new System.Drawing.Size(224, 20);
            this.tbDataBits.TabIndex = 7;
            // 
            // tbBaudRate
            // 
            this.tbBaudRate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tbBaudRate.Location = new System.Drawing.Point(115, 48);
            this.tbBaudRate.Name = "tbBaudRate";
            this.tbBaudRate.Size = new System.Drawing.Size(224, 20);
            this.tbBaudRate.TabIndex = 6;
            // 
            // cbPort
            // 
            this.cbPort.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.cbPort.FormattingEnabled = true;
            this.cbPort.Items.AddRange(new object[] {
            "COM1",
            "COM3",
            "COM4",
            "COM5",
            "COM6"});
            this.cbPort.Location = new System.Drawing.Point(115, 23);
            this.cbPort.Name = "cbPort";
            this.cbPort.Size = new System.Drawing.Size(224, 21);
            this.cbPort.TabIndex = 5;
            // 
            // lbWriteT
            // 
            this.lbWriteT.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbWriteT.AutoSize = true;
            this.lbWriteT.Location = new System.Drawing.Point(5, 123);
            this.lbWriteT.Name = "lbWriteT";
            this.lbWriteT.Size = new System.Drawing.Size(73, 13);
            this.lbWriteT.TabIndex = 4;
            this.lbWriteT.Text = "Write Timeout";
            // 
            // lbReadT
            // 
            this.lbReadT.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbReadT.AutoSize = true;
            this.lbReadT.Location = new System.Drawing.Point(5, 99);
            this.lbReadT.Name = "lbReadT";
            this.lbReadT.Size = new System.Drawing.Size(74, 13);
            this.lbReadT.TabIndex = 3;
            this.lbReadT.Text = "Read Timeout";
            // 
            // lbDataBits
            // 
            this.lbDataBits.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbDataBits.AutoSize = true;
            this.lbDataBits.Location = new System.Drawing.Point(5, 75);
            this.lbDataBits.Name = "lbDataBits";
            this.lbDataBits.Size = new System.Drawing.Size(50, 13);
            this.lbDataBits.TabIndex = 2;
            this.lbDataBits.Text = "Data Bits";
            // 
            // lbBaudRate
            // 
            this.lbBaudRate.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbBaudRate.AutoSize = true;
            this.lbBaudRate.Location = new System.Drawing.Point(5, 50);
            this.lbBaudRate.Name = "lbBaudRate";
            this.lbBaudRate.Size = new System.Drawing.Size(58, 13);
            this.lbBaudRate.TabIndex = 1;
            this.lbBaudRate.Text = "Baud Rate";
            // 
            // lbPort
            // 
            this.lbPort.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbPort.AutoSize = true;
            this.lbPort.Location = new System.Drawing.Point(5, 26);
            this.lbPort.Name = "lbPort";
            this.lbPort.Size = new System.Drawing.Size(57, 13);
            this.lbPort.TabIndex = 0;
            this.lbPort.Text = "Port Name";
            // 
            // tabWB
            // 
            this.tabWB.Controls.Add(this.lbNoKontrak);
            this.tabWB.Controls.Add(this.tbJnsTruck);
            this.tabWB.Controls.Add(this.lbJnsTruck);
            this.tabWB.Controls.Add(this.lbDateTime);
            this.tabWB.Controls.Add(this.cbWINDocType);
            this.tabWB.Controls.Add(this.gbWINKen);
            this.tabWB.Controls.Add(this.btnWINSave);
            this.tabWB.Controls.Add(this.btnCariBaseDoc);
            this.tabWB.Controls.Add(this.tbWINBaseDoc);
            this.tabWB.Controls.Add(this.lbTiketNum);
            this.tabWB.Controls.Add(this.lbWINBaseDoc);
            this.tabWB.Controls.Add(this.tbTiketNum);
            this.tabWB.Controls.Add(this.tbWINNopol);
            this.tabWB.Controls.Add(this.tbWINEksCod);
            this.tabWB.Controls.Add(this.lbWINNopol);
            this.tabWB.Controls.Add(this.lbWINSupir);
            this.tabWB.Controls.Add(this.tbWINSupir);
            this.tabWB.Controls.Add(this.lbWINEksCod);
            this.tabWB.Location = new System.Drawing.Point(4, 22);
            this.tabWB.Name = "tabWB";
            this.tabWB.Size = new System.Drawing.Size(730, 527);
            this.tabWB.TabIndex = 2;
            this.tabWB.Text = "Weighbridge IN & OUT";
            this.tabWB.UseVisualStyleBackColor = true;
            // 
            // lbNoKontrak
            // 
            this.lbNoKontrak.AutoSize = true;
            this.lbNoKontrak.Location = new System.Drawing.Point(13, 124);
            this.lbNoKontrak.Name = "lbNoKontrak";
            this.lbNoKontrak.Size = new System.Drawing.Size(44, 13);
            this.lbNoKontrak.TabIndex = 12;
            this.lbNoKontrak.Text = "Kontrak";
            // 
            // tbJnsTruck
            // 
            this.tbJnsTruck.Location = new System.Drawing.Point(496, 114);
            this.tbJnsTruck.Name = "tbJnsTruck";
            this.tbJnsTruck.Size = new System.Drawing.Size(212, 20);
            this.tbJnsTruck.TabIndex = 11;
            // 
            // lbJnsTruck
            // 
            this.lbJnsTruck.AutoSize = true;
            this.lbJnsTruck.Location = new System.Drawing.Point(414, 116);
            this.lbJnsTruck.Name = "lbJnsTruck";
            this.lbJnsTruck.Size = new System.Drawing.Size(62, 13);
            this.lbJnsTruck.TabIndex = 10;
            this.lbJnsTruck.Text = "Jenis Truck";
            // 
            // lbDateTime
            // 
            this.lbDateTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbDateTime.AutoSize = true;
            this.lbDateTime.Location = new System.Drawing.Point(493, 6);
            this.lbDateTime.Name = "lbDateTime";
            this.lbDateTime.Size = new System.Drawing.Size(56, 13);
            this.lbDateTime.TabIndex = 6;
            this.lbDateTime.Text = "Date Time";
            // 
            // cbWINDocType
            // 
            this.cbWINDocType.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbWINDocType.FormattingEnabled = true;
            this.cbWINDocType.Items.AddRange(new object[] {
            "PO",
            "SO"});
            this.cbWINDocType.Location = new System.Drawing.Point(12, 51);
            this.cbWINDocType.Name = "cbWINDocType";
            this.cbWINDocType.Size = new System.Drawing.Size(49, 21);
            this.cbWINDocType.TabIndex = 7;
            // 
            // gbWINKen
            // 
            this.gbWINKen.Controls.Add(this.tbMOISTKebun);
            this.gbWINKen.Controls.Add(this.tbFFAKebun);
            this.gbWINKen.Controls.Add(this.lbMOISTKebun);
            this.gbWINKen.Controls.Add(this.lbFFAKebun);
            this.gbWINKen.Controls.Add(this.tbNettoKebun);
            this.gbWINKen.Controls.Add(this.lblNettoKebun);
            this.gbWINKen.Controls.Add(this.tbTaraKebun);
            this.gbWINKen.Controls.Add(this.lblTaraKebun);
            this.gbWINKen.Controls.Add(this.tbBrutoKebun);
            this.gbWINKen.Controls.Add(this.lblBrutoKebun);
            this.gbWINKen.Controls.Add(this.lblNetto);
            this.gbWINKen.Controls.Add(this.lbHasilUjiLab);
            this.gbWINKen.Controls.Add(this.gbUjiLab);
            this.gbWINKen.Controls.Add(this.textBox2);
            this.gbWINKen.Controls.Add(this.checkBox1);
            this.gbWINKen.Controls.Add(this.btnTimbangKeluar);
            this.gbWINKen.Controls.Add(this.textBox1);
            this.gbWINKen.Controls.Add(this.cbWINManual);
            this.gbWINKen.Controls.Add(this.btnTimbangMasuk);
            this.gbWINKen.Controls.Add(this.tbQtyMasuk);
            this.gbWINKen.Location = new System.Drawing.Point(7, 151);
            this.gbWINKen.Name = "gbWINKen";
            this.gbWINKen.Size = new System.Drawing.Size(715, 338);
            this.gbWINKen.TabIndex = 3;
            this.gbWINKen.TabStop = false;
            this.gbWINKen.Text = "Timbangan Masuk dan Keluar";
            // 
            // tbMOISTKebun
            // 
            this.tbMOISTKebun.Location = new System.Drawing.Point(313, 47);
            this.tbMOISTKebun.Name = "tbMOISTKebun";
            this.tbMOISTKebun.Size = new System.Drawing.Size(129, 20);
            this.tbMOISTKebun.TabIndex = 28;
            // 
            // tbFFAKebun
            // 
            this.tbFFAKebun.Location = new System.Drawing.Point(313, 21);
            this.tbFFAKebun.Name = "tbFFAKebun";
            this.tbFFAKebun.Size = new System.Drawing.Size(129, 20);
            this.tbFFAKebun.TabIndex = 27;
            // 
            // lbMOISTKebun
            // 
            this.lbMOISTKebun.AutoSize = true;
            this.lbMOISTKebun.Location = new System.Drawing.Point(230, 50);
            this.lbMOISTKebun.Name = "lbMOISTKebun";
            this.lbMOISTKebun.Size = new System.Drawing.Size(75, 13);
            this.lbMOISTKebun.TabIndex = 26;
            this.lbMOISTKebun.Text = "MOIST Kebun";
            // 
            // lbFFAKebun
            // 
            this.lbFFAKebun.AutoSize = true;
            this.lbFFAKebun.Location = new System.Drawing.Point(230, 24);
            this.lbFFAKebun.Name = "lbFFAKebun";
            this.lbFFAKebun.Size = new System.Drawing.Size(60, 13);
            this.lbFFAKebun.TabIndex = 24;
            this.lbFFAKebun.Text = "FFA Kebun";
            // 
            // tbNettoKebun
            // 
            this.tbNettoKebun.Location = new System.Drawing.Point(85, 73);
            this.tbNettoKebun.Name = "tbNettoKebun";
            this.tbNettoKebun.Size = new System.Drawing.Size(129, 20);
            this.tbNettoKebun.TabIndex = 23;
            // 
            // lblNettoKebun
            // 
            this.lblNettoKebun.AutoSize = true;
            this.lblNettoKebun.Location = new System.Drawing.Point(10, 76);
            this.lblNettoKebun.Name = "lblNettoKebun";
            this.lblNettoKebun.Size = new System.Drawing.Size(70, 13);
            this.lblNettoKebun.TabIndex = 22;
            this.lblNettoKebun.Text = "Nettto Kebun";
            // 
            // tbTaraKebun
            // 
            this.tbTaraKebun.Location = new System.Drawing.Point(85, 47);
            this.tbTaraKebun.Name = "tbTaraKebun";
            this.tbTaraKebun.Size = new System.Drawing.Size(129, 20);
            this.tbTaraKebun.TabIndex = 21;
            // 
            // lblTaraKebun
            // 
            this.lblTaraKebun.AutoSize = true;
            this.lblTaraKebun.Location = new System.Drawing.Point(10, 50);
            this.lblTaraKebun.Name = "lblTaraKebun";
            this.lblTaraKebun.Size = new System.Drawing.Size(63, 13);
            this.lblTaraKebun.TabIndex = 20;
            this.lblTaraKebun.Text = "Tara Kebun";
            // 
            // tbBrutoKebun
            // 
            this.tbBrutoKebun.Location = new System.Drawing.Point(85, 21);
            this.tbBrutoKebun.Name = "tbBrutoKebun";
            this.tbBrutoKebun.Size = new System.Drawing.Size(129, 20);
            this.tbBrutoKebun.TabIndex = 19;
            // 
            // lblBrutoKebun
            // 
            this.lblBrutoKebun.AutoSize = true;
            this.lblBrutoKebun.Location = new System.Drawing.Point(10, 24);
            this.lblBrutoKebun.Name = "lblBrutoKebun";
            this.lblBrutoKebun.Size = new System.Drawing.Size(66, 13);
            this.lblBrutoKebun.TabIndex = 18;
            this.lblBrutoKebun.Text = "Bruto Kebun";
            // 
            // lblNetto
            // 
            this.lblNetto.AutoSize = true;
            this.lblNetto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNetto.Location = new System.Drawing.Point(596, 204);
            this.lblNetto.Name = "lblNetto";
            this.lblNetto.Size = new System.Drawing.Size(102, 20);
            this.lblNetto.TabIndex = 17;
            this.lblNetto.Text = "Berat Netto";
            // 
            // lbHasilUjiLab
            // 
            this.lbHasilUjiLab.AutoSize = true;
            this.lbHasilUjiLab.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHasilUjiLab.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbHasilUjiLab.Location = new System.Drawing.Point(337, 296);
            this.lbHasilUjiLab.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbHasilUjiLab.Name = "lbHasilUjiLab";
            this.lbHasilUjiLab.Size = new System.Drawing.Size(105, 29);
            this.lbHasilUjiLab.TabIndex = 16;
            this.lbHasilUjiLab.Text = "UJI LAB";
            this.lbHasilUjiLab.Visible = false;
            // 
            // gbUjiLab
            // 
            this.gbUjiLab.Controls.Add(this.button1);
            this.gbUjiLab.Controls.Add(this.tbDOBI);
            this.gbUjiLab.Controls.Add(this.tbIMP);
            this.gbUjiLab.Controls.Add(this.tbMOIST);
            this.gbUjiLab.Controls.Add(this.tbCAROTINE);
            this.gbUjiLab.Controls.Add(this.lblCAROTINE);
            this.gbUjiLab.Controls.Add(this.lblDOBI);
            this.gbUjiLab.Controls.Add(this.lblIMP);
            this.gbUjiLab.Controls.Add(this.lblMoist);
            this.gbUjiLab.Controls.Add(this.tbFFA);
            this.gbUjiLab.Controls.Add(this.lblFFA);
            this.gbUjiLab.Location = new System.Drawing.Point(13, 114);
            this.gbUjiLab.Margin = new System.Windows.Forms.Padding(2);
            this.gbUjiLab.Name = "gbUjiLab";
            this.gbUjiLab.Padding = new System.Windows.Forms.Padding(2);
            this.gbUjiLab.Size = new System.Drawing.Size(290, 183);
            this.gbUjiLab.TabIndex = 15;
            this.gbUjiLab.TabStop = false;
            this.gbUjiLab.Text = "Uji Lab";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(230, 156);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(50, 20);
            this.button1.TabIndex = 10;
            this.button1.Text = "Submit";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // tbDOBI
            // 
            this.tbDOBI.Location = new System.Drawing.Point(79, 97);
            this.tbDOBI.Margin = new System.Windows.Forms.Padding(2);
            this.tbDOBI.Name = "tbDOBI";
            this.tbDOBI.Size = new System.Drawing.Size(202, 20);
            this.tbDOBI.TabIndex = 9;
            // 
            // tbIMP
            // 
            this.tbIMP.Location = new System.Drawing.Point(79, 73);
            this.tbIMP.Margin = new System.Windows.Forms.Padding(2);
            this.tbIMP.Name = "tbIMP";
            this.tbIMP.Size = new System.Drawing.Size(202, 20);
            this.tbIMP.TabIndex = 8;
            // 
            // tbMOIST
            // 
            this.tbMOIST.Location = new System.Drawing.Point(79, 48);
            this.tbMOIST.Margin = new System.Windows.Forms.Padding(2);
            this.tbMOIST.Name = "tbMOIST";
            this.tbMOIST.Size = new System.Drawing.Size(202, 20);
            this.tbMOIST.TabIndex = 7;
            // 
            // tbCAROTINE
            // 
            this.tbCAROTINE.Location = new System.Drawing.Point(79, 125);
            this.tbCAROTINE.Margin = new System.Windows.Forms.Padding(2);
            this.tbCAROTINE.Name = "tbCAROTINE";
            this.tbCAROTINE.Size = new System.Drawing.Size(202, 20);
            this.tbCAROTINE.TabIndex = 6;
            // 
            // lblCAROTINE
            // 
            this.lblCAROTINE.AutoSize = true;
            this.lblCAROTINE.Location = new System.Drawing.Point(6, 127);
            this.lblCAROTINE.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCAROTINE.Name = "lblCAROTINE";
            this.lblCAROTINE.Size = new System.Drawing.Size(62, 13);
            this.lblCAROTINE.TabIndex = 5;
            this.lblCAROTINE.Text = "CAROTINE";
            // 
            // lblDOBI
            // 
            this.lblDOBI.AutoSize = true;
            this.lblDOBI.Location = new System.Drawing.Point(6, 101);
            this.lblDOBI.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDOBI.Name = "lblDOBI";
            this.lblDOBI.Size = new System.Drawing.Size(33, 13);
            this.lblDOBI.TabIndex = 4;
            this.lblDOBI.Text = "DOBI";
            // 
            // lblIMP
            // 
            this.lblIMP.AutoSize = true;
            this.lblIMP.Location = new System.Drawing.Point(6, 75);
            this.lblIMP.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblIMP.Name = "lblIMP";
            this.lblIMP.Size = new System.Drawing.Size(26, 13);
            this.lblIMP.TabIndex = 3;
            this.lblIMP.Text = "IMP";
            // 
            // lblMoist
            // 
            this.lblMoist.AutoSize = true;
            this.lblMoist.Location = new System.Drawing.Point(4, 48);
            this.lblMoist.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMoist.Name = "lblMoist";
            this.lblMoist.Size = new System.Drawing.Size(41, 13);
            this.lblMoist.TabIndex = 2;
            this.lblMoist.Text = "MOIST";
            // 
            // tbFFA
            // 
            this.tbFFA.Location = new System.Drawing.Point(79, 21);
            this.tbFFA.Margin = new System.Windows.Forms.Padding(2);
            this.tbFFA.Name = "tbFFA";
            this.tbFFA.Size = new System.Drawing.Size(202, 20);
            this.tbFFA.TabIndex = 1;
            // 
            // lblFFA
            // 
            this.lblFFA.AutoSize = true;
            this.lblFFA.Location = new System.Drawing.Point(4, 23);
            this.lblFFA.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFFA.Name = "lblFFA";
            this.lblFFA.Size = new System.Drawing.Size(26, 13);
            this.lblFFA.TabIndex = 0;
            this.lblFFA.Text = "FFA";
            // 
            // textBox2
            // 
            this.textBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox2.BackColor = System.Drawing.Color.CadetBlue;
            this.textBox2.Enabled = false;
            this.textBox2.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(488, 229);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(213, 50);
            this.textBox2.TabIndex = 13;
            this.textBox2.Text = "0";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // checkBox1
            // 
            this.checkBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(496, 122);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(61, 17);
            this.checkBox1.TabIndex = 12;
            this.checkBox1.Text = "Manual";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // btnTimbangKeluar
            // 
            this.btnTimbangKeluar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTimbangKeluar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimbangKeluar.Location = new System.Drawing.Point(568, 114);
            this.btnTimbangKeluar.Name = "btnTimbangKeluar";
            this.btnTimbangKeluar.Size = new System.Drawing.Size(132, 28);
            this.btnTimbangKeluar.TabIndex = 11;
            this.btnTimbangKeluar.Text = "Timbang Keluar";
            this.btnTimbangKeluar.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.BackColor = System.Drawing.Color.CadetBlue;
            this.textBox1.Enabled = false;
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(488, 148);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(213, 50);
            this.textBox1.TabIndex = 10;
            this.textBox1.Text = "0";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // cbWINManual
            // 
            this.cbWINManual.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbWINManual.AutoSize = true;
            this.cbWINManual.Location = new System.Drawing.Point(496, 27);
            this.cbWINManual.Name = "cbWINManual";
            this.cbWINManual.Size = new System.Drawing.Size(61, 17);
            this.cbWINManual.TabIndex = 2;
            this.cbWINManual.Text = "Manual";
            this.cbWINManual.UseVisualStyleBackColor = true;
            this.cbWINManual.CheckedChanged += new System.EventHandler(this.cbWINManual_CheckedChanged);
            // 
            // btnTimbangMasuk
            // 
            this.btnTimbangMasuk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTimbangMasuk.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimbangMasuk.Location = new System.Drawing.Point(568, 19);
            this.btnTimbangMasuk.Name = "btnTimbangMasuk";
            this.btnTimbangMasuk.Size = new System.Drawing.Size(132, 28);
            this.btnTimbangMasuk.TabIndex = 1;
            this.btnTimbangMasuk.Text = "Timbang Masuk";
            this.btnTimbangMasuk.UseVisualStyleBackColor = true;
            // 
            // tbQtyMasuk
            // 
            this.tbQtyMasuk.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbQtyMasuk.BackColor = System.Drawing.Color.CadetBlue;
            this.tbQtyMasuk.Enabled = false;
            this.tbQtyMasuk.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbQtyMasuk.Location = new System.Drawing.Point(488, 53);
            this.tbQtyMasuk.Name = "tbQtyMasuk";
            this.tbQtyMasuk.Size = new System.Drawing.Size(213, 50);
            this.tbQtyMasuk.TabIndex = 0;
            this.tbQtyMasuk.Text = "0";
            this.tbQtyMasuk.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbQtyMasuk.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbQtyMasuk_KeyPress);
            // 
            // btnWINSave
            // 
            this.btnWINSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnWINSave.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWINSave.Location = new System.Drawing.Point(626, 495);
            this.btnWINSave.Name = "btnWINSave";
            this.btnWINSave.Size = new System.Drawing.Size(96, 25);
            this.btnWINSave.TabIndex = 5;
            this.btnWINSave.Text = "Save";
            this.btnWINSave.UseVisualStyleBackColor = true;
            // 
            // btnCariBaseDoc
            // 
            this.btnCariBaseDoc.Location = new System.Drawing.Point(287, 52);
            this.btnCariBaseDoc.Name = "btnCariBaseDoc";
            this.btnCariBaseDoc.Size = new System.Drawing.Size(56, 20);
            this.btnCariBaseDoc.TabIndex = 6;
            this.btnCariBaseDoc.Text = "Search";
            this.btnCariBaseDoc.UseVisualStyleBackColor = true;
            // 
            // tbWINBaseDoc
            // 
            this.tbWINBaseDoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbWINBaseDoc.Location = new System.Drawing.Point(66, 51);
            this.tbWINBaseDoc.Name = "tbWINBaseDoc";
            this.tbWINBaseDoc.Size = new System.Drawing.Size(215, 21);
            this.tbWINBaseDoc.TabIndex = 5;
            // 
            // lbTiketNum
            // 
            this.lbTiketNum.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbTiketNum.AutoSize = true;
            this.lbTiketNum.Location = new System.Drawing.Point(10, 80);
            this.lbTiketNum.Name = "lbTiketNum";
            this.lbTiketNum.Size = new System.Drawing.Size(65, 13);
            this.lbTiketNum.TabIndex = 0;
            this.lbTiketNum.Text = "Nomor Tiket";
            // 
            // lbWINBaseDoc
            // 
            this.lbWINBaseDoc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbWINBaseDoc.AutoSize = true;
            this.lbWINBaseDoc.Location = new System.Drawing.Point(10, 35);
            this.lbWINBaseDoc.Name = "lbWINBaseDoc";
            this.lbWINBaseDoc.Size = new System.Drawing.Size(83, 13);
            this.lbWINBaseDoc.TabIndex = 4;
            this.lbWINBaseDoc.Text = "Base Document";
            // 
            // tbTiketNum
            // 
            this.tbTiketNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTiketNum.Location = new System.Drawing.Point(13, 96);
            this.tbTiketNum.Name = "tbTiketNum";
            this.tbTiketNum.Size = new System.Drawing.Size(268, 21);
            this.tbTiketNum.TabIndex = 2;
            // 
            // tbWINNopol
            // 
            this.tbWINNopol.Location = new System.Drawing.Point(496, 35);
            this.tbWINNopol.Name = "tbWINNopol";
            this.tbWINNopol.Size = new System.Drawing.Size(212, 20);
            this.tbWINNopol.TabIndex = 7;
            // 
            // tbWINEksCod
            // 
            this.tbWINEksCod.Location = new System.Drawing.Point(496, 88);
            this.tbWINEksCod.Name = "tbWINEksCod";
            this.tbWINEksCod.Size = new System.Drawing.Size(212, 20);
            this.tbWINEksCod.TabIndex = 9;
            // 
            // lbWINNopol
            // 
            this.lbWINNopol.AutoSize = true;
            this.lbWINNopol.Location = new System.Drawing.Point(414, 37);
            this.lbWINNopol.Name = "lbWINNopol";
            this.lbWINNopol.Size = new System.Drawing.Size(65, 13);
            this.lbWINNopol.TabIndex = 0;
            this.lbWINNopol.Text = "Nomor Polisi";
            // 
            // lbWINSupir
            // 
            this.lbWINSupir.AutoSize = true;
            this.lbWINSupir.Location = new System.Drawing.Point(414, 64);
            this.lbWINSupir.Name = "lbWINSupir";
            this.lbWINSupir.Size = new System.Drawing.Size(62, 13);
            this.lbWINSupir.TabIndex = 1;
            this.lbWINSupir.Text = "Nama Supir";
            // 
            // tbWINSupir
            // 
            this.tbWINSupir.Location = new System.Drawing.Point(496, 61);
            this.tbWINSupir.Name = "tbWINSupir";
            this.tbWINSupir.Size = new System.Drawing.Size(212, 20);
            this.tbWINSupir.TabIndex = 8;
            // 
            // lbWINEksCod
            // 
            this.lbWINEksCod.AutoSize = true;
            this.lbWINEksCod.Location = new System.Drawing.Point(414, 90);
            this.lbWINEksCod.Name = "lbWINEksCod";
            this.lbWINEksCod.Size = new System.Drawing.Size(70, 13);
            this.lbWINEksCod.TabIndex = 2;
            this.lbWINEksCod.Text = "No SIM Supir";
            // 
            // tabUpdateDO
            // 
            this.tabUpdateDO.Controls.Add(this.lbNoKontrakDO);
            this.tabUpdateDO.Controls.Add(this.btnUpdateDO);
            this.tabUpdateDO.Controls.Add(this.cbManualDO);
            this.tabUpdateDO.Controls.Add(this.btnTimbangDO);
            this.tabUpdateDO.Controls.Add(this.tbQtyTimbangDO);
            this.tabUpdateDO.Controls.Add(this.lbDateTimeDO);
            this.tabUpdateDO.Controls.Add(this.btnSearchDO);
            this.tabUpdateDO.Controls.Add(this.tbDODocNum);
            this.tabUpdateDO.Controls.Add(this.lbDODocNum);
            this.tabUpdateDO.Location = new System.Drawing.Point(4, 22);
            this.tabUpdateDO.Name = "tabUpdateDO";
            this.tabUpdateDO.Size = new System.Drawing.Size(730, 527);
            this.tabUpdateDO.TabIndex = 3;
            this.tabUpdateDO.Text = "Update Delivery Order";
            this.tabUpdateDO.UseVisualStyleBackColor = true;
            // 
            // lbNoKontrakDO
            // 
            this.lbNoKontrakDO.AutoSize = true;
            this.lbNoKontrakDO.Location = new System.Drawing.Point(10, 84);
            this.lbNoKontrakDO.Name = "lbNoKontrakDO";
            this.lbNoKontrakDO.Size = new System.Drawing.Size(44, 13);
            this.lbNoKontrakDO.TabIndex = 17;
            this.lbNoKontrakDO.Text = "Kontrak";
            // 
            // btnUpdateDO
            // 
            this.btnUpdateDO.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpdateDO.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateDO.Location = new System.Drawing.Point(613, 494);
            this.btnUpdateDO.Name = "btnUpdateDO";
            this.btnUpdateDO.Size = new System.Drawing.Size(96, 25);
            this.btnUpdateDO.TabIndex = 16;
            this.btnUpdateDO.Text = "Update DO";
            this.btnUpdateDO.UseVisualStyleBackColor = true;
            // 
            // cbManualDO
            // 
            this.cbManualDO.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbManualDO.AutoSize = true;
            this.cbManualDO.Location = new System.Drawing.Point(493, 43);
            this.cbManualDO.Name = "cbManualDO";
            this.cbManualDO.Size = new System.Drawing.Size(61, 17);
            this.cbManualDO.TabIndex = 15;
            this.cbManualDO.Text = "Manual";
            this.cbManualDO.UseVisualStyleBackColor = true;
            this.cbManualDO.CheckedChanged += new System.EventHandler(this.chbManualDO_CheckedChanged);
            // 
            // btnTimbangDO
            // 
            this.btnTimbangDO.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTimbangDO.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimbangDO.Location = new System.Drawing.Point(577, 35);
            this.btnTimbangDO.Name = "btnTimbangDO";
            this.btnTimbangDO.Size = new System.Drawing.Size(132, 28);
            this.btnTimbangDO.TabIndex = 14;
            this.btnTimbangDO.Text = "Timbang";
            this.btnTimbangDO.UseVisualStyleBackColor = true;
            // 
            // tbQtyTimbangDO
            // 
            this.tbQtyTimbangDO.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbQtyTimbangDO.BackColor = System.Drawing.Color.CadetBlue;
            this.tbQtyTimbangDO.Enabled = false;
            this.tbQtyTimbangDO.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbQtyTimbangDO.Location = new System.Drawing.Point(493, 69);
            this.tbQtyTimbangDO.Name = "tbQtyTimbangDO";
            this.tbQtyTimbangDO.Size = new System.Drawing.Size(213, 50);
            this.tbQtyTimbangDO.TabIndex = 13;
            this.tbQtyTimbangDO.Text = "0";
            this.tbQtyTimbangDO.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbQtyTimbangDO.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbQtyTimbangDO_KeyPress);
            // 
            // lbDateTimeDO
            // 
            this.lbDateTimeDO.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbDateTimeDO.AutoSize = true;
            this.lbDateTimeDO.Location = new System.Drawing.Point(493, 6);
            this.lbDateTimeDO.Name = "lbDateTimeDO";
            this.lbDateTimeDO.Size = new System.Drawing.Size(56, 13);
            this.lbDateTimeDO.TabIndex = 10;
            this.lbDateTimeDO.Text = "Date Time";
            // 
            // btnSearchDO
            // 
            this.btnSearchDO.Location = new System.Drawing.Point(231, 52);
            this.btnSearchDO.Name = "btnSearchDO";
            this.btnSearchDO.Size = new System.Drawing.Size(56, 20);
            this.btnSearchDO.TabIndex = 9;
            this.btnSearchDO.Text = "Search";
            this.btnSearchDO.UseVisualStyleBackColor = true;
            // 
            // tbDODocNum
            // 
            this.tbDODocNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDODocNum.Location = new System.Drawing.Point(10, 51);
            this.tbDODocNum.Name = "tbDODocNum";
            this.tbDODocNum.Size = new System.Drawing.Size(215, 21);
            this.tbDODocNum.TabIndex = 8;
            // 
            // lbDODocNum
            // 
            this.lbDODocNum.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbDODocNum.AutoSize = true;
            this.lbDODocNum.Location = new System.Drawing.Point(10, 35);
            this.lbDODocNum.Name = "lbDODocNum";
            this.lbDODocNum.Size = new System.Drawing.Size(126, 13);
            this.lbDODocNum.TabIndex = 7;
            this.lbDODocNum.Text = "Delivery Order Document";
            // 
            // runningTime
            // 
            this.runningTime.Enabled = true;
            this.runningTime.Tick += new System.EventHandler(this.runningTime_Tick);
            // 
            // FormSync
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(738, 553);
            this.Controls.Add(this.tabCtrlMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormSync";
            this.Text = "Weighbridge";
            this.Load += new System.EventHandler(this.FormSync_Load);
            this.tabCtrlMain.ResumeLayout(false);
            this.tabLogin.ResumeLayout(false);
            this.tabLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.tabConfig.ResumeLayout(false);
            this.tabCtrlConfig.ResumeLayout(false);
            this.tabAppDB.ResumeLayout(false);
            this.gbDB.ResumeLayout(false);
            this.gbDB.PerformLayout();
            this.gbApp.ResumeLayout(false);
            this.gbApp.PerformLayout();
            this.tabWB.ResumeLayout(false);
            this.tabWB.PerformLayout();
            this.gbWINKen.ResumeLayout(false);
            this.gbWINKen.PerformLayout();
            this.gbUjiLab.ResumeLayout(false);
            this.gbUjiLab.PerformLayout();
            this.tabUpdateDO.ResumeLayout(false);
            this.tabUpdateDO.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tabCtrlMain;
        private TabPage tabLogin;
        private TabPage tabConfig;
        private TextBox tbLoginUsrnm;
        private TabPage tabWB;
        private TextBox tbLoginPass;
        private Button btnLogin;
        private PictureBox pbLogo;
        private TabControl tabCtrlConfig;
        private TabPage tabAppDB;
        private GroupBox gbDB;
        private GroupBox gbApp;
        private Label lbPort;
        private Button btnSvConfig;
        private Label lbBaudRate;
        private Label lbDataBits;
        private Label lbReadT;
        private Label lbWriteT;
        private TextBox tbWriteT;
        private TextBox tbReadT;
        private TextBox tbDataBits;
        private TextBox tbBaudRate;
        private ComboBox cbPort;
        private Label lbSvrType;
        private Label lbServerNm;
        private Label lbDB;
        private Label lbUsrnm;
        private Label lbDBPass;
        private ComboBox cbSrvType;
        private TextBox tbDBSrv;
        private TextBox tbDBSBO;
        private TextBox tbSBOUsrnm;
        private TextBox tbSBOPass;
        private Label lbTiketNum;
        private TextBox tbTiketNum;
        private GroupBox gbWINKen;
        private Label lbWINNopol;
        private Label lbWINSupir;
        private Label lbWINEksCod;
        private Button btnCariBaseDoc;
        private TextBox tbWINBaseDoc;
        private Label lbWINBaseDoc;
        private ComboBox cbWINDocType;
        private TextBox tbWINEksCod;
        private TextBox tbWINSupir;
        private TextBox tbWINNopol;
        private TextBox tbQtyMasuk;
        private Button btnTimbangMasuk;
        private Button btnWINSave;
        private Label lbUsr;
        private Label lbPass;
        private Label lbDateTime;
        private Timer runningTime;
        private CheckBox cbWINManual;
        private GroupBox gbUjiLab;
        private TextBox textBox2;
        private CheckBox checkBox1;
        private Button btnTimbangKeluar;
        private TextBox textBox1;
        private TextBox tbFFA;
        private Label lblFFA;
        private TextBox tbDOBI;
        private TextBox tbIMP;
        private TextBox tbMOIST;
        private TextBox tbCAROTINE;
        private Label lblCAROTINE;
        private Label lblDOBI;
        private Label lblIMP;
        private Label lblMoist;
        private Label lbHasilUjiLab;
        private Button button1;
        private TextBox tbJnsTruck;
        private Label lbJnsTruck;
        private Label lblNetto;
        private Label lblBrutoKebun;
        private Label lbFFAKebun;
        private TextBox tbNettoKebun;
        private Label lblNettoKebun;
        private TextBox tbTaraKebun;
        private Label lblTaraKebun;
        private TextBox tbBrutoKebun;
        private TextBox tbMOISTKebun;
        private TextBox tbFFAKebun;
        private Label lbMOISTKebun;
        private TextBox tbDBPass;
        private TextBox tbDBUsrnm;
        private Label label1;
        private Label lbDBUsrnm;
        private TabPage tabUpdateDO;
        private Label lbDateTimeDO;
        private Button btnSearchDO;
        private TextBox tbDODocNum;
        private Label lbDODocNum;
        private CheckBox cbManualDO;
        private Button btnTimbangDO;
        private TextBox tbQtyTimbangDO;
        private Button btnUpdateDO;
        private Label lbNoKontrak;
        private Label lbNoKontrakDO;
        private Button btnTestWBConn;
        private Label lbTestQtyTimbang;
    }
}


