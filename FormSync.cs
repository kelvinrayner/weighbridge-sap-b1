using Sap.Data.Hana;
using SAPbobsCOM;
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
            this.AcceptButton = btnLogin;
        }

        private void FormSync_Load(object sender, EventArgs e)
        {
            LoadConfig();
            LoadImageLogo();
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

        private void cbTMManual_CheckedChanged_1(object sender, EventArgs e)
        {
            if (cbTMManual.Checked)
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

        private void cbTKManual_CheckedChanged(object sender, EventArgs e)
        {
            if (cbTKManual.Checked)
            {
                timbangType = "M";
                tbQtyKeluar.Enabled = true;
                tbQtyKeluar.Text = "";
                btnTimbangKeluar.Visible = false;
            }
            else
            {
                timbangType = "A";
                tbQtyKeluar.Enabled = false;
                tbQtyKeluar.Text = "";
                btnTimbangKeluar.Visible = true;
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

        private void tbQtyKeluar_KeyPress(object sender, KeyPressEventArgs e)
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

        //private void btnWINTimbangNew_Click(object sender, EventArgs e)
        //{
        //    DialogResult result = MessageBox.Show("Apakah anda yakin untuk Timbang Masuk baru?", "Konfirmasi Timbang Masuk baru", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

        //    if (result == DialogResult.Yes)
        //    {
        //        timbangBaruWIN();
        //    }
        //}

        //private void timbangBaruWIN()
        //{
        //    tbTiketNum.Clear();
        //    cbDocType.ResetText();
        //    tbBaseDoc.Clear();
        //    //tbWINTiketSt.Clear();
        //    tbNopol.Clear();
        //    tbNamaSupir.Clear();
        //    tbSIMSupir.Clear();
        //    cbTMManual.Checked = false;
        //    tbQtyMasuk.Text = "0";
        //    gbUjiLab.Visible = false;
        //}

        private void btnTestWBConn_Click(object sender, EventArgs e)
        {
            ModGlobal modGlobal = new ModGlobal();

            modGlobal = global();

            wbConn = new WBConnection(modGlobal);

            try
            {
                wbConn.OnWeightReceived += weight =>
                {
                    this.Invoke((MethodInvoker)(() =>
                    {
                        lbTestQtyTimbang.Text = weight.ToString("F2");
                    }));
                };
                wbConn.Connect();

                if (wbConn.IsConnected)
                {
                    lbStatusWBConnection.Text = "Connected";
                    lbStatusWBConnection.ForeColor = Color.Green;
                }
                else
                {
                    lbStatusWBConnection.Text = "Not Connected";
                    lbStatusWBConnection.ForeColor = Color.Red;
                }

                wbConn.Disconnect();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error - Weighbridge Connection", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCariBaseDoc_Click(object sender, EventArgs e)
        {
            int objType;
            int docEntry;
            string docType = cbDocType.SelectedItem.ToString();
            string docNum = tbBaseDoc.Text;
            string noKontrak;

            if (String.IsNullOrEmpty(docType) || String.IsNullOrEmpty(docNum))
            {
                MessageBox.Show("Document Type atau Document Number SAP tidak boleh kosong.", "Error - Weighbridge UI", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                ModGlobal modGlobal = new ModGlobal();
                modGlobal = global();

                HANAConnetion hanaConn = new HANAConnetion();
                string connectionString = hanaConn.HanaConnectionString(modGlobal);

                var connection = new HanaConnection(connectionString);

                using (connection)
                {
                    connection.Open();

                    string queryString = "CALL SOL_SP_ADDON_WB_SEARCH_BASE_DOC('" + docType + "','" + docNum + "')";

                    using (var command = new HanaCommand(queryString, connection))
                    {
                        using (var reader = command.ExecuteReader())
                        {
                            if (!reader.HasRows)
                            {
                                MessageBox.Show("Document SAP tidak ditemukan.", "Not Found - Weighbridge", MessageBoxButtons.OK, MessageBoxIcon.Error);

                                DisableFieldWB();
                            }
                            else
                            {
                                while (reader.Read())
                                {
                                    MessageBox.Show("Document SAP ditemukan.", "Found - Weighbridge", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                    objType = Convert.ToInt32(reader["OBJTYPE"]);
                                    docEntry = Convert.ToInt32(reader["DOCENTRY"]);
                                    docNum = reader["DOCNUM"].ToString();
                                    noKontrak = reader["KONTRAK"].ToString();

                                    lblValDocNo.Text =  ": " + docNum;
                                    lblValKontrak.Text = ": " + noKontrak;

                                    EnableFieldWB();
                                }
                            }
                        }
                    }

                    connection.Close();
                }
            }
        }

        private void btnWBSave_Click(object sender, EventArgs e)
        {

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

        private void EnableFieldWB()
        {
            tbTiketNum.Enabled = true;
            tbNopol.Enabled = true;
            tbNamaSupir.Enabled = true;
            tbSIMSupir.Enabled = true;
            tbJnsTruck.Enabled = true;
            tbBrutoKebun.Enabled = true;
            tbTaraKebun.Enabled = true;
            tbNettoKebun.Enabled = true;
            tbFFAKebun.Enabled = true;
            tbMOISTKebun.Enabled = true;
            tbFFA.Enabled = true;
            tbMOIST.Enabled = true;
            tbIMP.Enabled = true;
            tbDOBI.Enabled = true;
            tbCAROTINE.Enabled = true;
            cbTMManual.Enabled = true;
            cbTKManual.Enabled = true;
            btnTimbangMasuk.Enabled = true;
            btnTimbangKeluar.Enabled = true;
            btnSubmitUjiLab.Enabled = true;
            btnWBSave.Enabled = true;
            //tbQtyMasuk.Enabled = true;
            //tbQtyKeluar.Enabled = true;
            //tbQtyNetto.Enabled = true;
        }

        private void DisableFieldWB()
        {
            tbTiketNum.Enabled = false;
            tbNopol.Enabled = false;
            tbNamaSupir.Enabled = false;
            tbSIMSupir.Enabled = false;
            tbJnsTruck.Enabled = false;
            tbBrutoKebun.Enabled = false;
            tbTaraKebun.Enabled = false;
            tbNettoKebun.Enabled = false;
            tbFFAKebun.Enabled = false;
            tbMOISTKebun.Enabled = false;
            tbFFA.Enabled = false;
            tbMOIST.Enabled = false;
            tbIMP.Enabled = false;
            tbDOBI.Enabled = false;
            tbCAROTINE.Enabled = false;
            cbTMManual.Enabled = false;
            cbTKManual.Enabled = false;
            btnTimbangMasuk.Enabled = false;
            btnTimbangKeluar.Enabled = false;
            btnSubmitUjiLab.Enabled = false;
            btnWBSave.Enabled = false;
            //tbQtyMasuk.Enabled = false;
            //tbQtyKeluar.Enabled = false;
            //tbQtyNetto.Enabled = false;
        }

        private void SyncGRPO()
        {
            SBOConnection oSBOConnection = new SBOConnection();
            ModGlobal modGlobal = new ModGlobal();

            try
            {
                //oSBOConnection.connectSBO(global());

                //Documents oGRPO = null;
                //oGRPO = oSBOConnection.oCompany.GetBusinessObject(BoObjectTypes.oPurchaseDeliveryNotes);

                //oGRPO.DocDate = DateTime.Today;
                //oGRPO.Comments = grpo.Remarks;
                //oGRPO.UserFields.Fields.Item("U_SOL_SOPIR").Value = grpo.Supir;
                //oGRPO.UserFields.Fields.Item("U_RKM_NO_KENDARAAN").Value = grpo.NoKendaraan;
                //oGRPO.UserFields.Fields.Item("U_RKM_DIBUAT_OLEH_GRPO").Value = grpo.WmsUser;
                //oGRPO.UserFields.Fields.Item("U_SOL_WMS_NO").Value = grpo.WmsNo;
                //oGRPO.NumAtCard = grpo.VendorRefNo;


                //oGRPO.Lines.BaseType = 22;
                //oGRPO.Lines.BaseEntry = grpodetail.PODocEntry;
                //oGRPO.Lines.BaseLine = grpodetail.LineNo - 1;
                //oGRPO.Lines.ItemCode = grpodetail.ItemCode;
                //oGRPO.Lines.ItemDescription = grpodetail.ItemName;
                //oGRPO.Lines.Quantity = grpodetail.TotalQty;
                //oGRPO.Lines.WarehouseCode = grpo.Warehouse;
                ////oDO.Lines.LineNum = dodetail.LineNo;

                //oGRPO.Lines.Add();

                //int retval = 0;

                //retval = oGRPO.Add();

            }
            catch (Exception ex)
            {

            }
        }

        private void SyncDO()
        {

        }

        private void AddWBUDO()
        {
            SBOConnection oSBOConnection = new SBOConnection();
            ModGlobal modGlobal = new ModGlobal();

            try
            {
                oSBOConnection.connectSBO(global());

                //Declare all SAPbobsCOM untuk DI API UDO
                SAPbobsCOM.GeneralService oGeneralService;
                SAPbobsCOM.GeneralData oGeneralData;

                SAPbobsCOM.CompanyService oSTR = null;
                oSTR = oSBOConnection.oCompany.GetCompanyService();

                //Get a handle to the Stock Request UDO
                oGeneralService = oSTR.GetGeneralService("OWB");

                //Specify data for main UDO (Header)
                oGeneralData = oGeneralService.GetDataInterface(SAPbobsCOM.GeneralServiceDataInterfaces.gsGeneralData);
                oGeneralData.SetProperty("U_SOL_DOC_TYPE", cbDocType.SelectedItem.ToString());
                oGeneralData.SetProperty("U_SOL_DOCNUM_SAP", tbBaseDoc.Text);
                oGeneralData.SetProperty("U_SOL_TIKET_WB", tbTiketNum.Text);
                oGeneralData.SetProperty("U_SOL_NOPOL", tbNopol.Text);
                oGeneralData.SetProperty("U_SOL_NAMA_SUPIR", tbNamaSupir.Text);
                oGeneralData.SetProperty("U_SOL_NO_SIM_SUPIR", tbSIMSupir.Text);
                oGeneralData.SetProperty("U_SOL_JENIS_TRUCK", tbJnsTruck.Text);
                oGeneralData.SetProperty("U_SOL_BERAT_MASUK", tbQtyMasuk.Text);
                oGeneralData.SetProperty("U_SOL_BERAT_KELUAR", tbQtyKeluar.Text);
                oGeneralData.SetProperty("U_SOL_BERAT_NETTO", tbQtyNetto.Text);
                oGeneralData.SetProperty("U_SOL_BRUTO_KEBUN", tbBrutoKebun.Text);
                oGeneralData.SetProperty("U_SOL_TARA_KEBUN", tbTaraKebun.Text);
                oGeneralData.SetProperty("U_SOL_NETTO_KEBUN", tbNettoKebun.Text);
                oGeneralData.SetProperty("U_SOL_FFA_KEBUN", tbFFAKebun.Text);
                oGeneralData.SetProperty("U_SOL_MOIST_KEBUN", tbMOIST.Text);
                oGeneralData.SetProperty("U_SOL_LAB_FFA", tbFFA.Text);
                oGeneralData.SetProperty("U_SOL_LAB_MOIST", tbMOIST.Text);
                oGeneralData.SetProperty("U_SOL_LAB_IMP", tbIMP.Text);
                oGeneralData.SetProperty("U_SOL_LAB_DOBI", tbDOBI.Text);
                oGeneralData.SetProperty("U_SOL_LAB_CAROTINE", tbCAROTINE.Text);

                //Add records
                oGeneralService.Add(oGeneralData);

                oSBOConnection.oCompany.Disconnect();

            }
            catch (Exception ex)
            {

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
                tbQtyTimbangDO.Enabled = false;
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

        private void btnSearchDO_Click(object sender, EventArgs e)
        {
            int objType;
            int docEntry;
            string docNum = tbDODocNum.Text;
            string noKontrak;

            if (String.IsNullOrEmpty(docNum))
            {
                MessageBox.Show("Document Number SAP tidak boleh kosong.", "Error - Weighbridge UI", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                ModGlobal modGlobal = new ModGlobal();
                modGlobal = global();

                HANAConnetion hanaConn = new HANAConnetion();
                string connectionString = hanaConn.HanaConnectionString(modGlobal);

                var connection = new HanaConnection(connectionString);

                using (connection)
                {
                    connection.Open();

                    string queryString = "CALL SOL_SP_ADDON_WB_SEARCH_BASE_DOC_DO('" + docNum + "')";

                    using (var command = new HanaCommand(queryString, connection))
                    {
                        using (var reader = command.ExecuteReader())
                        {
                            if (!reader.HasRows)
                            {
                                MessageBox.Show("Document SAP tidak ditemukan.", "Not Found - Weighbridge", MessageBoxButtons.OK, MessageBoxIcon.Error);

                                //DisableFieldWB();
                                cbManualDO.Enabled = false;
                                btnTimbangDO.Enabled = false;
                                btnUpdateDO.Enabled = false;
                            }
                            else
                            {
                                while (reader.Read())
                                {
                                    MessageBox.Show("Document SAP ditemukan.", "Found - Weighbridge", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                    objType = Convert.ToInt32(reader["OBJTYPE"]);
                                    docEntry = Convert.ToInt32(reader["DOCENTRY"]);
                                    docNum = reader["DOCNUM"].ToString();
                                    noKontrak = reader["KONTRAK"].ToString();

                                    lbValKontrakDO.Text = ": " + noKontrak;

                                    cbManualDO.Enabled = true;
                                    btnTimbangDO.Enabled = true;
                                    btnUpdateDO.Enabled = true;
                                }
                            }
                        }
                    }

                    connection.Close();
                }
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
                    MessageBox.Show("Configuration saved successfully, shutting down the Application...", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
