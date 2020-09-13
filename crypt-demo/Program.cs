using crypt_demo.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace crypt_demo
{
    class Program
    {

        static string data = "th1s1smyp@ssw0rd";
        static string aes128Hash = "1234567890123456";
        static string aes192Hash = "123456789012345612345678";
        static string aes256Hash = "12345678901234561234567890123456";

        static void Main(string[] args)
        {

            Console.WriteLine("// AES Encrypted Values:");
            Console.WriteLine("CS_AES_CFB8_128 = '{0}'", (new AesCrypt(aes128Hash)).Encrypt(data));
            Console.WriteLine("CS_AES_CFB8_192 = '{0}'", (new AesCrypt(aes192Hash)).Encrypt(data));
            Console.WriteLine("CS_AES_CFB8_256 = '{0}'", (new AesCrypt(aes256Hash)).Encrypt(data));
            Console.WriteLine("CS_AES_CBC_128 = '{0}'", (new AesCrypt(aes128Hash, System.Security.Cryptography.CipherMode.CBC)).Encrypt(data));
            Console.WriteLine("CS_AES_CBC_192 = '{0}'", (new AesCrypt(aes192Hash, System.Security.Cryptography.CipherMode.CBC)).Encrypt(data));
            Console.WriteLine("CS_AES_CBC_256 = '{0}'", (new AesCrypt(aes256Hash, System.Security.Cryptography.CipherMode.CBC)).Encrypt(data));

            //var PubPath = String.Concat(Directory.GetCurrentDirectory(), "\\..\\..\\..\\cert\\rsa\\cert.pem").Replace("\\", Path.DirectorySeparatorChar.ToString());
            //var PrvPath = String.Concat(Directory.GetCurrentDirectory(), "\\..\\..\\..\\cert\\rsa\\key.pem").Replace("\\", Path.DirectorySeparatorChar.ToString());

            //Console.WriteLine("// RSA Encrypted Values:");
            //Console.WriteLine("CS_RSA = '{}'", (new RsaCrypt(PrvPath, PubPath)).Encrypt(data));

            //var certPath = String.Concat(Directory.GetCurrentDirectory(), "\\..\\..\\..\\cert\\x509\\cert.pfx").Replace("\\", Path.DirectorySeparatorChar.ToString());

            //Console.WriteLine("// X509 Encrypted Values:");
            //Console.WriteLine("CS_X509 = '{}'", (new X509Crypt(certPath)).Encrypt(data));

            Console.ReadKey();
            Console.ReadKey();
        }

    }
}
