using System;
using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using crypt_demo.Properties;

namespace crypt_demo_test
{
    [TestClass]
    public class X509CryptTest
    {
        [TestMethod]
        public void TestNewAes()
        {
            var certPath = String.Concat(Directory.GetCurrentDirectory(), "\\..\\..\\..\\cert\\x509\\cert.pfx").Replace("\\", Path.DirectorySeparatorChar.ToString());
            var ssl = new X509Crypt(certPath);
        }

        [TestMethod]
        public void TestAesEncrypt()
        {
            var certPath = String.Concat(Directory.GetCurrentDirectory(), "\\..\\..\\..\\cert\\x509\\cert.pfx").Replace("\\", Path.DirectorySeparatorChar.ToString());
            var ssl = new X509Crypt(certPath);
            var encrypted = ssl.Encrypt("test");
        }

        [TestMethod]
        public void TestAesDecrypt()
        {
            var certPath = String.Concat(Directory.GetCurrentDirectory(), "\\..\\..\\..\\cert\\x509\\cert.pfx").Replace("\\", Path.DirectorySeparatorChar.ToString());
            var ssl = new X509Crypt(certPath);
            var encrypted = ssl.Encrypt("test");
            var decrypted = ssl.Decrypt(encrypted);

            Assert.AreEqual(decrypted, "test");
        }
    }
}
