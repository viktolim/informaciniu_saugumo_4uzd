using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    class RSACrypto
    {

        public string Encrypt(string text, string key)
        {

            try
            {
                CspParameters CSApars = new CspParameters();
                CSApars.KeyContainerName = key;
                RSACryptoServiceProvider rsa = new RSACryptoServiceProvider(CSApars);


                byte[] byteText = Encoding.ASCII.GetBytes(text);
                byte[] byteEntry = rsa.Encrypt(byteText, false);

                return Convert.ToBase64String(byteEntry);
            }
            catch (Exception e)
            {
                return "turite įrašyti dešifruotą slaptažodį";
            }

        }
        public string Decrypt(string text, string key)
        {

            try
            {
                CspParameters CSApars = new CspParameters();
                CSApars.KeyContainerName = key;

                RSACryptoServiceProvider rsa = new RSACryptoServiceProvider(CSApars);
                byte[] byteEntry = Convert.FromBase64String(text);
                byte[] byteText = rsa.Decrypt(byteEntry, false);

                return Encoding.UTF8.GetString(byteText);
            }
            catch (Exception e)
            {
                return "";
            }


        }
    }
}
