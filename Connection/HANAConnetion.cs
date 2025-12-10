using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weighbridge.Connection
{
    public class HANAConnetion
    {
        public string HanaConnectionString(ModGlobal modGlobal)
        {
            string hostnameServer = modGlobal.serverName.Split('@')[1].Split(':')[0];
            string hanaServer = hostnameServer + ":30015";

            string connectionString = "server=" + hanaServer + ";currentSchema=" + modGlobal.database + ";userid=" + modGlobal.databaseUsername + ";password=" + modGlobal.databasePassword; 

            return connectionString;
        }
    }
}
