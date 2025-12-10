using SAPbobsCOM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weighbridge
{
    public class SBOConnection
    {
        public Company oCompany = new Company();

        public void connectSBO(ModGlobal modGlobal)
        {
            if (!oCompany.Connected)
            {
                oCompany = new Company();
                //oCompany.LicenseServer = "";
                oCompany.Server = modGlobal.serverName;
                oCompany.DbServerType = BoDataServerTypes.dst_HANADB;
                oCompany.CompanyDB = modGlobal.database;
                oCompany.DbUserName = modGlobal.databaseUsername;
                oCompany.DbPassword = modGlobal.databasePassword;
                oCompany.UserName = modGlobal.sboUsername;
                oCompany.Password = modGlobal.sboPassword;
                //oCompany.language = BoSuppLangs.ln_English;

                if (oCompany.Connect() != 0)
                {
                    throw new Exception("Error connection : " + oCompany.GetLastErrorCode().ToString() + " - " + oCompany.GetLastErrorDescription());
                }
            }
        }

        public bool connectionSBO(ModGlobal modGlobal)
        {
            if (!oCompany.Connected)
            {
                oCompany = new Company();
                //oCompany.LicenseServer = "";
                oCompany.Server = modGlobal.serverName;
                oCompany.DbServerType = BoDataServerTypes.dst_HANADB;
                oCompany.CompanyDB = modGlobal.database;
                oCompany.DbUserName = modGlobal.databaseUsername;
                oCompany.DbPassword = modGlobal.databasePassword;
                oCompany.UserName = modGlobal.sboUsername;
                oCompany.Password = modGlobal.sboPassword;
                //oCompany.language = BoSuppLangs.ln_English;

                if (oCompany.Connect() != 0)
                {
                    //return false;
                    throw new Exception("Error connection : " + oCompany.GetLastErrorCode().ToString() + " - " + oCompany.GetLastErrorDescription());
                }
            }

            return true;
        }
    }
}
