using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weighbridge.Core.Config
{
    public class SBOConfig
    {
        public string serverType {  get; set; }
        public string serverName { get; set; }
        public string tenantName { get; set; }
        public int port {  get; set; }
        public string database { get; set; }
        public string databaseUsername { get; set; }
        public string databasePassword { get; set; }
        public string sboUsername { get; set; }
        public string sboPassword { get; set; }
    }
}
