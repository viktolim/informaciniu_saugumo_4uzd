using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    class AesCrypto
    {
        AesCryptoServiceProvider aes_provider;
       
        public AesCrypto()
        {
            aes_provider = new AesCryptoServiceProvider();
            aes_provider.BlockSize = 128;
            aes_provider.Mode = CipherMode.ECB;
            aes_provider.KeySize = 128;
            aes_provider.Padding = PaddingMode.PKCS7;

        }
        public string encrypt(string plainText, string password)
        {
            try
            {
                key(password);
                ICryptoTransform transform = aes_provider.CreateEncryptor();
                byte[] encrypted = transform.TransformFinalBlock(ASCIIEncoding.ASCII.GetBytes(plainText), 0, ASCIIEncoding.ASCII.GetBytes(plainText).Length);
                return Convert.ToBase64String(encrypted);
            }
            catch(Exception e)
            {
                return null;
            }
            
        }
        public string decrypt(string plainText, string password)
        {

            key(password);
            ICryptoTransform transform = aes_provider.CreateDecryptor();
            byte[] encrypted = transform.TransformFinalBlock(Convert.FromBase64String(plainText), 0,Convert.FromBase64String(plainText).Length);
            return ASCIIEncoding.ASCII.GetString(encrypted);
        }

        private void key(string password) {
            int lenght = password.Length;
            if (lenght < 16)
            {
                while (lenght != 16)
                {
                    password = password + (char)lenght;
                    lenght++;
                }
            }
            else
            {
                password = password.Substring(0, 16);
            }
            aes_provider.Key = Encoding.UTF8.GetBytes(password);
        }
    }
}
