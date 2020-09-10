﻿using crypt_demo.Properties;
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
            //String decPasswordAes = aes.Decrypt("kzGAW4f9c1KiwdxSlfsgAKQ2OCY=");

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

        static void doX509()
        {
            var certPath = String.Concat(Directory.GetCurrentDirectory(), "\\..\\..\\..\\cert\\x509\\cert.pfx").Replace("\\", Path.DirectorySeparatorChar.ToString());
            var ssl = new X509Crypt(certPath);

            String encPasswordSsl = ssl.Encrypt(password);
            String decPasswordSsl = ssl.Decrypt(encPasswordSsl);

            Console.WriteLine("Using X509:");
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
            doX509();

            Console.ReadKey();
            Console.ReadKey();
        }

    }
}
