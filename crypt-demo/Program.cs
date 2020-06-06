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

        static string password = "th1s1smyp@ssw0rd";

        static void doAes()
        {
            var aes = new AesCrypt("1234567890123456");

            String encPasswordAes = aes.Encrypt(password);
            String decPasswordAes = aes.Decrypt(encPasswordAes);

            Console.WriteLine("Using AES:");
            Console.Write("password: ");
            Console.WriteLine(password);
            Console.Write("enc password: ");
            Console.WriteLine(encPasswordAes);
            Console.Write("dec password: ");
            Console.WriteLine(decPasswordAes);

            Console.WriteLine("");
        }

        static void doRsa()
        {    
            var PubPath = String.Concat(Directory.GetCurrentDirectory(), "\\..\\..\\..\\cert\\rsa\\cert.pem").Replace("\\", Path.DirectorySeparatorChar.ToString());
            var PrvPath = String.Concat(Directory.GetCurrentDirectory(), "\\..\\..\\..\\cert\\rsa\\key.pem").Replace("\\", Path.DirectorySeparatorChar.ToString());
            var rsa = new RsaCrypt(PrvPath, PubPath);

            String encPasswordRsa = rsa.Encrypt(password);
            String decPasswordRsa = rsa.Decrypt(encPasswordRsa);

            Console.WriteLine("Using RSA:");
            Console.Write("password: ");
            Console.WriteLine(password);
            Console.Write("enc password: ");
            Console.WriteLine(encPasswordRsa);
            Console.Write("dec password: ");
            Console.WriteLine(decPasswordRsa);

            Console.WriteLine("");
        }

        static void doSsl()
        {
            var certPath = String.Concat(Directory.GetCurrentDirectory(), "\\..\\..\\..\\cert\\ssl\\cert.pfx").Replace("\\", Path.DirectorySeparatorChar.ToString());
            var ssl = new SslCrypt(certPath);

            String encPasswordSsl = ssl.Encrypt(password);
            String decPasswordSsl = ssl.Decrypt(encPasswordSsl);

            Console.WriteLine("Using SSL:");
            Console.Write("password: ");
            Console.WriteLine(password);
            Console.Write("enc password: ");
            Console.WriteLine(encPasswordSsl);
            Console.Write("dec password: ");
            Console.WriteLine(decPasswordSsl);

            Console.WriteLine("");
        }

        static void Main(string[] args)
        {
            doAes();
            //doRsa();
            doSsl();

            Console.ReadKey();
            Console.ReadKey();
        }

    }
}
