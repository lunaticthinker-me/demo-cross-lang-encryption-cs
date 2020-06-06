using System;
using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using crypt_demo.Properties;

namespace crypt_demo_test
{
    [TestClass]
    public class SslCryptTest
    {
        [TestMethod]
        public void TestNewAes()
        {
            var certPath = String.Concat(Directory.GetCurrentDirectory(), "\\..\\..\\..\\cert\\ssl\\cert.pfx").Replace("\\", Path.DirectorySeparatorChar.ToString());
            var ssl = new SslCrypt(certPath);
        }

        [TestMethod]
        public void TestAesEncrypt()
        {
            var certPath = String.Concat(Directory.GetCurrentDirectory(), "\\..\\..\\..\\cert\\ssl\\cert.pfx").Replace("\\", Path.DirectorySeparatorChar.ToString());
            var ssl = new SslCrypt(certPath);
            var encrypted = ssl.Encrypt("test");
        }

        [TestMethod]
        public void TestAesDecrypt()
        {
            var certPath = String.Concat(Directory.GetCurrentDirectory(), "\\..\\..\\..\\cert\\ssl\\cert.pfx").Replace("\\", Path.DirectorySeparatorChar.ToString());
            var ssl = new SslCrypt(certPath);
            var encrypted = ssl.Encrypt("test");
            var decrypted = ssl.Decrypt(encrypted);

            Assert.AreEqual(decrypted, "test");
        }
    }
}
