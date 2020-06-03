using ssl_crypt.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// openssl req -newkey rsa:2048 -nodes -keyout key.pem -x509 -days 365 -out cert.pem
// openssl pkcs12 -export -out cert.pfx -inkey key.pem -in cert.pem

namespace ssl_crypt
{
    class Program
    {

        static void Main(string[] args)
        {
            String password = "TSC0d3r#@";

            //SimpleEncrypt aesEncrypt = new SimpleEncrypt("MZF9CPBVHGAT4FNSLGT4CU54PB8ZOMEY");

            //String encPasswordAes = aesEncrypt.Encrypt(password);
            //String decPasswordAes = aesEncrypt.Decrypt(encPasswordAes);

            //Console.WriteLine("Using SSL:");
            //Console.Write("password: ");
            //Console.WriteLine(password);
            //Console.Write("enc password: ");
            //Console.WriteLine(encPasswordAes);
            //Console.Write("dec password: ");
            //Console.WriteLine(decPasswordAes);

            //Console.WriteLine("");

            String certPath = String.Concat("C:\\Users\\dragosc\\source\\repos\\ssl-crypt", "\\cert.pfx");
            SslEncrypt sslEncrypt = new SslEncrypt(certPath);

            String encPasswordSsl = sslEncrypt.Encrypt(password);
            String decPasswordSsl = sslEncrypt.Decrypt(encPasswordSsl);

            Console.WriteLine("Using SSL:");
            Console.Write("password: ");
            Console.WriteLine(password);
            Console.Write("enc password: ");
            Console.WriteLine(encPasswordSsl);
            Console.Write("enc password: ");
            Console.WriteLine(decPasswordSsl);

            Console.ReadKey();
            Console.ReadKey();
        }

    }
}
