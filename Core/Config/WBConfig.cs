using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weighbridge.Core.Config
{
    public class WBConfig
    {
        public string portName { get; set; }
        public string baudRate { get; set; }
        public string dataBits { get; set; }
        public int readTimeout { get; set; }
        public int writeTimeout { get; set; }
    }
}
