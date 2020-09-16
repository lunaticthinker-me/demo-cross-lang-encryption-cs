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

        static void Main(string[] args)
        {

            string[][] terms = new string[][] { 
                new string[] { "Go", "var CS", "\"" }, 
                new string[] { "Js", "export const CS", "'" }, 
                new string[] { "Py", "CS", "'" }
            };

            for (int i = 0; i < terms.Length; i++) {
                Console.WriteLine("// {0}", terms[i][0]);
                Console.WriteLine("");
                Console.WriteLine("// AES Encrypted Values:");
                Console.WriteLine("{0}_AES_CFB8_128 = {1}{2}{3}", terms[i][1], terms[i][2], (new AesCrypt(BaseTest.aes128Hash)).Encrypt(BaseTest.data[0]), terms[i][2]);
                Console.WriteLine("{0}_AES_CFB8_192 = {1}{2}{3}", terms[i][1], terms[i][2], (new AesCrypt(BaseTest.aes192Hash)).Encrypt(BaseTest.data[0]), terms[i][2]);
                Console.WriteLine("{0}_AES_CFB8_256 = {1}{2}{3}", terms[i][1], terms[i][2], (new AesCrypt(BaseTest.aes256Hash)).Encrypt(BaseTest.data[0]), terms[i][2]);
                Console.WriteLine("{0}_AES_CBC_128 = {1}{2}{3}", terms[i][1], terms[i][2], (new AesCrypt(BaseTest.aes128Hash, System.Security.Cryptography.CipherMode.CBC)).Encrypt(BaseTest.data[0]), terms[i][2]);
                Console.WriteLine("{0}_AES_CBC_192 = {1}{2}{3}", terms[i][1], terms[i][2], (new AesCrypt(BaseTest.aes192Hash, System.Security.Cryptography.CipherMode.CBC)).Encrypt(BaseTest.data[0]), terms[i][2]);
                Console.WriteLine("{0}_AES_CBC_256 = {1}{2}{3}", terms[i][1], terms[i][2], (new AesCrypt(BaseTest.aes256Hash, System.Security.Cryptography.CipherMode.CBC)).Encrypt(BaseTest.data[0]), terms[i][2]);
                Console.WriteLine("");

                var PubPath = String.Concat(Directory.GetCurrentDirectory(), "\\..\\..\\..\\cert\\rsa\\cert.pem").Replace("\\", Path.DirectorySeparatorChar.ToString());
                var PrvPath = String.Concat(Directory.GetCurrentDirectory(), "\\..\\..\\..\\cert\\rsa\\key.pem").Replace("\\", Path.DirectorySeparatorChar.ToString());

                Console.WriteLine("// RSA Encrypted Values:");
                Console.WriteLine("{0}_RSA_PKCS1V1_5 = {1}{2}{3}", terms[i][1], terms[i][2], (new RsaCrypt(PrvPath, PubPath, RsaCrypt.PADDING_PKCS1V15)).Encrypt(BaseTest.data[0]), terms[i][2]);
                Console.WriteLine("{0}_RSA_OAEP = {1}{2}{3}", terms[i][1], terms[i][2], (new RsaCrypt(PrvPath, PubPath, RsaCrypt.PADDING_OAEP)).Encrypt(BaseTest.data[0]), terms[i][2]);
                Console.WriteLine("");

                var certPath = String.Concat(Directory.GetCurrentDirectory(), "\\..\\..\\..\\cert\\x509\\cert.pfx").Replace("\\", Path.DirectorySeparatorChar.ToString());
                PubPath = String.Concat(Directory.GetCurrentDirectory(), "\\..\\..\\..\\cert\\x509\\cert.pem").Replace("\\", Path.DirectorySeparatorChar.ToString());
                PrvPath = String.Concat(Directory.GetCurrentDirectory(), "\\..\\..\\..\\cert\\x509\\key.pem").Replace("\\", Path.DirectorySeparatorChar.ToString());

                Console.WriteLine("// X509 Encrypted Values:");
                Console.WriteLine("{0}_X509_OAEP = {1}{2}{3}", terms[i][1], terms[i][2], (new X509Crypt(PrvPath, PubPath, X509Crypt.PADDING_OAEP)).Encrypt(BaseTest.data[0]), terms[i][2]);
                Console.WriteLine("{0}_X509_PKCS1V1_5 = {1}{2}{3}", terms[i][1], terms[i][2], (new X509Crypt(PrvPath, PubPath, X509Crypt.PADDING_PKCS1V15)).Encrypt(BaseTest.data[0]), terms[i][2]);
                Console.WriteLine("");
                Console.WriteLine("");
            }

            Console.ReadKey();
            Console.ReadKey();
        }

    }
}
