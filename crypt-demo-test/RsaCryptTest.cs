using System;
using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using crypt_demo.Properties;

namespace crypt_demo_test
{
    [TestClass]
    public class RsaCryptTest
    {
        [TestMethod]
        public void TestNewAes()
        {
            var PubPath = String.Concat(Directory.GetCurrentDirectory(), "\\..\\..\\..\\cert\\rsa\\cert.pem").Replace("\\", Path.PathSeparator.ToString());
            var PrvPath = String.Concat(Directory.GetCurrentDirectory(), "\\..\\..\\..\\cert\\rsa\\key.pem").Replace("\\", Path.PathSeparator.ToString());
            var rsa = new RsaCrypt(PrvPath, PubPath);
        }

        [TestMethod]
        public void TestAesEncrypt()
        {
            var PubPath = String.Concat(Directory.GetCurrentDirectory(), "\\..\\..\\..\\cert\\rsa\\cert.pem").Replace("\\", Path.PathSeparator.ToString());
            var PrvPath = String.Concat(Directory.GetCurrentDirectory(), "\\..\\..\\..\\cert\\rsa\\key.pem").Replace("\\", Path.PathSeparator.ToString());
            var rsa = new RsaCrypt(PrvPath, PubPath);
            var encrypted = rsa.Encrypt("test");
        }

        [TestMethod]
        public void TestAesDecrypt()
        {
            var PubPath = String.Concat(Directory.GetCurrentDirectory(), "\\..\\..\\..\\cert\\rsa\\cert.pem").Replace("\\", Path.PathSeparator.ToString());
            var PrvPath = String.Concat(Directory.GetCurrentDirectory(), "\\..\\..\\..\\cert\\rsa\\key.pem").Replace("\\", Path.PathSeparator.ToString());
            var rsa = new RsaCrypt(PrvPath, PubPath);
            var encrypted = rsa.Encrypt("test");
            var decrypted = rsa.Decrypt(encrypted);

            Assert.AreEqual(decrypted, "test");
        }
    }
}
