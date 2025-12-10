using Sap.Data.Hana;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Weighbridge.Connection;
using Weighbridge.Core;
using Weighbridge.Core.Config;
using Weighbridge.Core.Encryptions;
using Weighbridge.XML;

namespace Weighbridge
{
    public partial class FormSync : Form
    {
        private WBConfig _wbConfig;
        private SBOConfig _sboConfig;
        private WBConnection wbConn;

        private Encryption encryption;

        public string timbangType; //A = Auto, M = Manual

        public FormSync()
        {
            InitializeComponent();
        }

        private void FormSync_Load(object sender, EventArgs e)
        {
            LoadImageLogo();
            LoadConfig();
            ShowLoginOnly();
            runningTime.Start();
        }

        private void LoadImageLogo()
        {
            string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
            string imageFileName = "Assets/logo-tanimas.png";
            string imagePath = Path.Combine(baseDirectory, imageFileName);

            if (File.Exists(imagePath))
            {
                pbLogo.Image = Image.FromFile(imagePath);
            }
        }

        private void runningTime_Tick(object sender, EventArgs e)
        {
            lbDateTime.Text = DateTime.Now.ToLongDateString() + " / " + DateTime.Now.ToLongTimeString();
            lbDateTimeDO.Text = DateTime.Now.ToLongDateString() + " / " + DateTime.Now.ToLongTimeString();
        }

        #region Login

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = tbLoginUsrnm.Text;
            string password = tbLoginPass.Text;

            ModGlobal modGlobal = new ModGlobal();
            modGlobal = global();

            HANAConnetion hanaConn = new HANAConnetion();
            string connectionString = hanaConn.HanaConnectionString(modGlobal);

            var connection = new HanaConnection(connectionString);

            using (connection)
            {
                connection.Open();

                string queryString = "CALL SOL_SP_ADDON_WB_LOGIN_GET_ROLE('" + username + "','" + password + "')";

                using (var command = new HanaCommand(queryString, connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        if (!reader.HasRows)
                        {
                            MessageBox.Show("User tidak ditemukan, perhatikan Username dan Password!", "Error - Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            while (reader.Read())
                            {
                                string role = reader["USERROLE"].ToString();

                                if(role == "SU")
                                {
                                    ShowTabSuperuser();
                                }
                                else
                                {
                                    ShowTabAdmin();
                                }
                            }
                        }
                    }
                }

                connection.Close();
            }
        }

        #endregion

        #region Weighbridge

        private void cbWINManual_CheckedChanged(object sender, EventArgs e)
        {
            if (cbWINManual.Checked) 
            {
                timbangType = "M";
                tbQtyMasuk.Enabled = true;
                tbQtyMasuk.Text = "";
                btnTimbangMasuk.Visible = false;
            }
            else
            {
                timbangType = "A";
                tbQtyMasuk.Enabled = false;
                tbQtyMasuk.Text = "";
                btnTimbangMasuk.Visible = true;
            }

        }

        private void tbQtyMasuk_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow digits, control characters (like backspace), and the decimal separator
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true; // Prevent the character from being entered
            }

            // Only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true; // Prevent multiple decimal points
            }
        }

        private void btnWINTimbangNew_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Apakah anda yakin untuk Timbang Masuk baru?", "Konfirmasi Timbang Masuk baru", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                timbangBaruWIN();
            }
        }

        private void timbangBaruWIN()
        {
            tbTiketNum.Clear();
            cbWINDocType.ResetText();
            tbWINBaseDoc.Clear();
            //tbWINTiketSt.Clear();
            tbWINNopol.Clear();
            tbWINSupir.Clear();
            tbWINEksCod.Clear();
            cbWINManual.Checked = false;
            tbQtyMasuk.Text = "0";
            gbUjiLab.Visible = false;
        }

        private void btnTestWBConn_Click(object sender, EventArgs e)
        {
            ModGlobal modGlobal = new ModGlobal();

            modGlobal = global();

            wbConn = new WBConnection(modGlobal);

            try
            {
                wbConn.Connect();
                wbConn.WeightReceived += WbConn_WeightReceived;
                wbConn.Disconnect();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error - Weighbridge Connection", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void WbConn_WeightReceived(double weight)
        {
            if (InvokeRequired)
            {
                Invoke(new Action(() =>
                {
                    lbTestQtyTimbang.Text = weight.ToString();
                }));
            }
            else
            {
                lbTestQtyTimbang.Text = weight.ToString();
            }
        }

        #endregion

        #region Update DO

        private void chbManualDO_CheckedChanged(object sender, EventArgs e)
        {
            if (cbManualDO.Checked)
            {
                timbangType = "M";
                tbQtyTimbangDO.Enabled = true;
                tbQtyTimbangDO.Text = "";
                btnTimbangDO.Visible = false;
            }
            else
            {
                timbangType = "A"; 
                tbQtyTimbangDO.Enabled = true;
                tbQtyTimbangDO.Text = "";
                btnTimbangDO.Visible = true;
            }
        }

        private void tbQtyTimbangDO_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow digits, control characters (like backspace), and the decimal separator
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true; // Prevent the character from being entered
            }
        }

        #endregion

        #region Configuration

        private void btnSvConfig_Click(object sender, EventArgs e)
        {
            if (validateInput())
            {
                SaveConfig();
            }
        }

        private bool validateInput()
        {
            string msg = "";

            if (!validateInput_WBApp(ref msg))
            {
                MessageBox.Show(msg);
                return false;
            }
            else if (!validateInput_SBO(ref msg))
            {
                MessageBox.Show(msg);
                return false;
            }
            else
            {
                return true;
            }
        }

        private bool validateInput_WBApp(ref string msg)
        {
            if (isEmpty(cbPort.Text.Trim()))
                msg = "Weighbridge Port Cannot be Empty";
            else if (isEmpty(tbBaudRate.Text.Trim()))
                msg = "Weighbridge Baud Rate Cannot be Empty";
            else if (isEmpty(tbDataBits.Text.Trim()))
                msg = "Weighbridge Data Bits Cannot be Empty";
            else if (isEmpty(tbReadT.Text.Trim()))
                msg = "Weighbridge Read Timeout Cannot be Empty";
            else if (isEmpty(tbWriteT.Text.Trim()))
                msg = "Weighbridge Write Timeout Cannot be Empty";

            return isEmpty(msg);
        }

        private bool validateInput_SBO(ref string msg)
        {
            if (isEmpty(cbSrvType.Text.Trim()))
                msg = "SBO Database Server Type Cannot be Empty";
            else if (isEmpty(tbDBSrv.Text.Trim()))
                msg = "SBO Database Server Address Cannot be Empty";
            else if (isEmpty(tbDBSBO.Text.Trim()))
                msg = "SBO Company Database Cannot be Empty";
            else if (isEmpty(tbDBUsrnm.Text.Trim()))
                msg = "SBO Company Database Username Cannot be Empty";
            else if (isEmpty(tbDBPass.Text.Trim()))
                msg = "SBO Company Database Password Cannot be Empty";
            else if (isEmpty(tbSBOUsrnm.Text.Trim()))
                msg = "SBO Company User Name Cannot be Empty";
            else if (isEmpty(tbSBOPass.Text.Trim()))
                msg = "SBO Company User Password Cannot be Empty";

            return isEmpty(msg);
        }

        private bool isEmpty(string s)
        {
            return (string.IsNullOrWhiteSpace(s));
        }

        private ModGlobal global()
        {
            ModGlobal modGlobal = new ModGlobal();

            modGlobal.portName = _wbConfig.portName;
            modGlobal.baudRate = _wbConfig.baudRate;
            modGlobal.dataBits = _wbConfig.dataBits;
            modGlobal.readTimeout = _wbConfig.readTimeout;
            modGlobal.writeTimeout = _wbConfig.writeTimeout;

            //modGlobal.serverType = _sboConfig.serverType;
            modGlobal.serverName = _sboConfig.serverName;
            modGlobal.database = _sboConfig.database;
            modGlobal.databaseUsername = _sboConfig.databaseUsername;
            modGlobal.databasePassword = encryption.decrypt(_sboConfig.databasePassword);
            modGlobal.sboUsername = _sboConfig.sboUsername;
            modGlobal.sboPassword = encryption.decrypt(_sboConfig.sboPassword);

            return modGlobal;
        }

        private void LoadConfig()
        {
            string path = GetConfigPath();
            if (!File.Exists(path))
            {
                ShowConfigTab();
            }
            else
            {
                (_wbConfig, _sboConfig) = XMLHandler.LoadConfig();
                ModGlobal modGlobal = new ModGlobal();
                encryption = new Encryption();

                modGlobal = global();

                cbPort.Text = modGlobal.portName;
                tbBaudRate.Text = modGlobal.baudRate;
                tbDataBits.Text = modGlobal.dataBits;
                tbReadT.Text = modGlobal.readTimeout.ToString();
                tbWriteT.Text = modGlobal.writeTimeout.ToString();

                cbSrvType.Text = _sboConfig.serverType;
                tbDBSrv.Text = modGlobal.serverName;
                tbDBSBO.Text = modGlobal.database;
                tbDBUsrnm.Text = modGlobal.databaseUsername;
                tbDBPass.Text = modGlobal.databasePassword;
                tbSBOUsrnm.Text = modGlobal.sboUsername;
                tbSBOPass.Text = modGlobal.sboPassword;

                SBOConnection sboConnection = new SBOConnection();

                try
                {

                    if (sboConnection.connectionSBO(global()))
                    {
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error - SBO Connection", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ShowConfigTab();
                }
            }
        }

        private void SaveConfig()
        {
            _wbConfig = new WBConfig();
            _sboConfig = new SBOConfig();
            ModGlobal modGlobal = new ModGlobal();

            encryption = new Encryption();

            _wbConfig.portName = cbPort.Text;
            _wbConfig.baudRate = tbBaudRate.Text;
            _wbConfig.dataBits = tbDataBits.Text;
            _wbConfig.readTimeout = int.TryParse(tbReadT.Text, out int readTimeout) ? readTimeout : 0;
            _wbConfig.writeTimeout = int.TryParse(tbReadT.Text, out int writeTimeout) ? writeTimeout : 0;

            _sboConfig.serverType = cbSrvType.Text;
            _sboConfig.serverName = tbDBSrv.Text;
            _sboConfig.database = tbDBSBO.Text;
            _sboConfig.databaseUsername = tbDBUsrnm.Text;
            _sboConfig.databasePassword = encryption.encrypt(tbDBPass.Text);
            _sboConfig.sboUsername = tbSBOUsrnm.Text;
            _sboConfig.sboPassword = encryption.encrypt(tbSBOPass.Text);

            //modGlobal.serverType = _sboConfig.serverType;
            modGlobal.serverName = _sboConfig.serverName;
            modGlobal.database = _sboConfig.database;
            modGlobal.databaseUsername = _sboConfig.databaseUsername;
            modGlobal.databasePassword = tbDBPass.Text;
            modGlobal.sboUsername = _sboConfig.sboUsername;
            modGlobal.sboPassword = tbSBOPass.Text;

            SBOConnection sboConnection = new SBOConnection();

            try
            {

                if (sboConnection.connectionSBO(modGlobal))
                {
                    XMLHandler.SaveConfiguration(_wbConfig, _sboConfig);
                    MessageBox.Show("Configuration saved successfully, Shutdown the Application...", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    Application.Exit();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error - SBO Connection", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ShowConfigTab();
            }
        }

        public static string GetConfigPath()
        {
            string folder = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Config");
            Directory.CreateDirectory(folder);

            return Path.Combine(folder, "Config.xml");
        }

        #endregion

        #region Tab Configcuration

        private void ShowLoginOnly()
        {
            tabCtrlMain.TabPages.Clear();
            tabCtrlMain.TabPages.Add(tabLogin);
        }

        private void ShowTabAdmin()
        {
            tabCtrlMain.TabPages.Clear();
            tabCtrlMain.TabPages.Add(tabWB);
            tabCtrlMain.TabPages.Add(tabUpdateDO);

            tabCtrlMain.SelectedIndex = 0;
        }

        private void ShowTabSuperuser()
        {
            tabCtrlMain.TabPages.Clear();
            tabCtrlMain.TabPages.Add(tabConfig);
            tabCtrlMain.TabPages.Add(tabWB);
            tabCtrlMain.TabPages.Add(tabUpdateDO);

            tabCtrlMain.SelectedIndex = 0;
        }

        private void ShowConfigTab()
        {
            foreach (TabPage tab in tabCtrlMain.TabPages.Cast<TabPage>().ToList())
            {
                if (tab.Name != "tabConfig")
                    tab.Parent = null;
            }
            tabCtrlMain.SelectedTab = tabCtrlMain.TabPages["tabConfig"];
        }

        #endregion

    }
}
