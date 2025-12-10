using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using Weighbridge.Core.Config;

namespace Weighbridge.XML
{
    public static class XMLHandler
    {
        public static string GetConfigPath() 
        {
            string folder = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Config");
            Directory.CreateDirectory(folder);

            return Path.Combine(folder, "Config.xml");
        }

        public static void SaveConfiguration(WBConfig wbConfig, SBOConfig sboConfig)
        {
            var xml = new XDocument(
                new XDeclaration("1.0", "UTF-8", null),
                new XElement("ADDON_CONFIGURATION",
                    new XAttribute(XNamespace.Xmlns + "xsi", "http://www.w3.org/2001/XMLSchema-instance"),
                    new XAttribute(XNamespace.Xmlns + "xsd", "http://www.w3.org/2001/XMLSchema"),
                    new XElement("CONFIGURATION",
                        new XElement("WEIGHBRIDGE",
                            new XElement("PORT_NAME", wbConfig.portName ?? ""),
                            new XElement("BAUD_RATE", wbConfig.baudRate ?? ""),
                            new XElement("DATA_BITS", wbConfig.dataBits ?? ""),
                            new XElement("READ_TIMEOUT", wbConfig.readTimeout),
                            new XElement("WRITE_TIMEOUT", wbConfig.writeTimeout)
                        ),
                        new XElement("SBO_DATABASE",
                            new XElement("DATABASE_SERVER_TYPE", sboConfig.serverType ?? ""),
                            new XElement("DATABASE_SERVER_NAME", sboConfig.serverName ?? ""),
                            new XElement("SBO_DATABASE_NAME", sboConfig.database ?? ""),
                            new XElement("SBO_DATABASE_USERNAME", sboConfig.databaseUsername ?? ""),
                            new XElement("SBO_DATABASE_PASSWORD", sboConfig.databasePassword ?? ""),
                            new XElement("SBO_USER_NAME", sboConfig.sboUsername ?? ""),
                            new XElement("SBO_PASSWORD", sboConfig.sboPassword ?? "")
                        )
                    )
                )
            );

            xml.Save(GetConfigPath());
        }

        public static (WBConfig, SBOConfig) LoadConfig()
        {
            string path = GetConfigPath();
            
            var xml = XDocument.Load(path);
            var configNode = xml.Element("ADDON_CONFIGURATION")?.Element("CONFIGURATION");

            var wbNode = configNode?.Element("WEIGHBRIDGE");
            var sboNode = configNode?.Element("SBO_DATABASE");

            var wbConfig = new WBConfig
            {
                portName = wbNode?.Element("PORT_NAME")?.Value ?? "",
                baudRate = wbNode?.Element("BAUD_RATE")?.Value ?? "",
                dataBits = wbNode?.Element("DATA_BITS")?.Value ?? "",
                readTimeout = int.TryParse(wbNode?.Element("READ_TIMEOUT")?.Value, out int readTimeout) ? readTimeout : 0,
                writeTimeout = int.TryParse(wbNode?.Element("WRITE_TIMEOUT")?.Value, out int writeTimeout) ? writeTimeout : 0
            };

            var sboConfig = new SBOConfig
            {
                serverType = sboNode?.Element("DATABASE_SERVER_TYPE")?.Value ?? "",
                serverName = sboNode?.Element("DATABASE_SERVER_NAME")?.Value ?? "",
                database = sboNode?.Element("SBO_DATABASE_NAME")?.Value ?? "",
                databaseUsername = sboNode?.Element("SBO_DATABASE_USERNAME")?.Value ?? "",
                databasePassword = sboNode?.Element("SBO_DATABASE_PASSWORD")?.Value ?? "",
                sboUsername = sboNode?.Element("SBO_USER_NAME")?.Value ?? "",
                sboPassword = sboNode?.Element("SBO_PASSWORD")?.Value ?? ""
            };

            return (wbConfig, sboConfig);
        }
    }
}
