using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weighbridge
{
    public class ModGlobal
    {
        public int readTimeout { get; set; }
        public int writeTimeout { get; set; }
        public string portName { get; set; }
        public string baudRate { get; set; }
        public string dataBits { get; set; }
        public string serverType { get; set; }
        public string serverName { get; set; }
        public string database { get; set; }
        public string databaseUsername { get; set; }
        public string databasePassword { get; set; }
        public string sboUsername { get; set; }
        public string sboPassword { get; set; }
    }
}
