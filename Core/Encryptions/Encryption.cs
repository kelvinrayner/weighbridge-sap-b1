using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace Weighbridge.Core.Encryptions
{
    public class Encryption
    {
        public string encrypt(string sText)
        {
            string retVal = "";
            string encryptKey = sKey;
            byte[] clearBytes = Encoding.Unicode.GetBytes(sText);

            using (Aes encryptor = Aes.Create())
            {
                Rfc2898DeriveBytes pdb = new Rfc2898DeriveBytes(encryptKey, new byte[] { 0x49, 0x76, 0x61, 0x6E, 0x20, 0x4D, 0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76 });
                encryptor.Key = pdb.GetBytes(32);
                encryptor.IV = pdb.GetBytes(16);
                using (MemoryStream ms = new MemoryStream())
                {
                    using (CryptoStream cs = new CryptoStream(ms, encryptor.CreateEncryptor(), CryptoStreamMode.Write))
                    {
                        cs.Write(clearBytes, 0, clearBytes.Length);
                        cs.Close();
                    }
                    retVal = Convert.ToBase64String(ms.ToArray());
                }
            }

            return retVal;
        }

        public string decrypt(string sText)
        {
            string retVal = "";
            string encryptKey = sKey;
            byte[] cipherBytes = System.Convert.FromBase64String(sText);

            using (Aes encryptor = Aes.Create())
            {
                Rfc2898DeriveBytes pdb = new Rfc2898DeriveBytes(encryptKey, new byte[] { 0x49, 0x76, 0x61, 0x6E, 0x20, 0x4D, 0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76 });
                encryptor.Key = pdb.GetBytes(32);
                encryptor.IV = pdb.GetBytes(16);
                using (MemoryStream ms = new MemoryStream())
                {
                    using (CryptoStream cs = new CryptoStream(ms, encryptor.CreateDecryptor(), CryptoStreamMode.Write))
                    {
                        cs.Write(cipherBytes, 0, cipherBytes.Length);
                        cs.Close();
                    }
                    retVal = Encoding.Unicode.GetString(ms.ToArray());
                }
            }

            return retVal;
        }

        private static string sKey
        {
            get { return "SOMETHING DEAD INSIDE"; }
        }
    }
}
