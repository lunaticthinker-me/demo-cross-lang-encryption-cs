using System;
using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using crypt_demo.Properties;

namespace crypt_demo_test
{
    [TestClass]
    public class X509CryptTest
    {

        public X509Crypt x509Oaep
        {
            get
            {
                String PubPath = String.Concat(Directory.GetCurrentDirectory(), "\\..\\..\\..\\cert\\x509\\cert.pem").Replace("\\", Path.DirectorySeparatorChar.ToString());
                String PrvPath = String.Concat(Directory.GetCurrentDirectory(), "\\..\\..\\..\\cert\\x509\\key.pem").Replace("\\", Path.DirectorySeparatorChar.ToString());
                return new X509Crypt(PrvPath, PubPath, X509Crypt.PADDING_OAEP);
            }
        }

        public X509Crypt x509Pkcs1v15
        {
            get
            {
                String PubPath = String.Concat(Directory.GetCurrentDirectory(), "\\..\\..\\..\\cert\\x509\\cert.pem").Replace("\\", Path.DirectorySeparatorChar.ToString());
                String PrvPath = String.Concat(Directory.GetCurrentDirectory(), "\\..\\..\\..\\cert\\x509\\key.pem").Replace("\\", Path.DirectorySeparatorChar.ToString());
                return new X509Crypt(PrvPath, PubPath, X509Crypt.PADDING_PKCS1V15);
            }
        }

        [TestMethod]
        public void TestRsaEncryptDecrypt_Oaep()
        {
            foreach (var item in BaseTest.data)
            {
                var encrypted = x509Oaep.Encrypt(item);
                var decrypted = x509Oaep.Decrypt(encrypted);
                Assert.AreEqual(decrypted, item);
            }
        }

        [TestMethod]
        public void TestRsaEncryptDecrypt_Pkcs1v15()
        {
            foreach (var item in BaseTest.data)
            {
                var encrypted = x509Pkcs1v15.Encrypt(item);
                var decrypted = x509Pkcs1v15.Decrypt(encrypted);
                Assert.AreEqual(decrypted, item);
            }
        }

        [TestMethod]
        [Ignore]
        public void TestX509Decrypt_From_Go_Oaep()
        {
            var decrypted = x509Oaep.Decrypt(BaseTest.GO_X509_OAEP);
            Assert.AreEqual(decrypted, BaseTest.data[0]);
        }

        [TestMethod]
        public void TestX509Decrypt_From_Go_Pkcs1v15()
        {
            var decrypted = x509Pkcs1v15.Decrypt(BaseTest.GO_X509_PKCS1V1_5);
            Assert.AreEqual(decrypted, BaseTest.data[0]);
        }

        [TestMethod]
        [Ignore]
        public void TestX509Decrypt_From_Js_Oaep()
        {
            var decrypted = x509Oaep.Decrypt(BaseTest.JS_X509_OAEP);
            Assert.AreEqual(decrypted, BaseTest.data[0]);
        }

        [TestMethod]
        public void TestX509Decrypt_From_Js_Pkcs1v15()
        {
            var decrypted = x509Pkcs1v15.Decrypt(BaseTest.JS_X509_PKCS1V1_5);
            Assert.AreEqual(decrypted, BaseTest.data[0]);
        }

        [TestMethod]
        public void TestX509Decrypt_From_Py_Oaep()
        {
            var decrypted = x509Oaep.Decrypt(BaseTest.PY_X509_OAEP);
            Assert.AreEqual(decrypted, BaseTest.data[0]);
        }

        [TestMethod]
        public void TestX509Decrypt_From_Py_Pkcs1v15()
        {
            var decrypted = x509Pkcs1v15.Decrypt(BaseTest.PY_X509_PKCS1V1_5);
            Assert.AreEqual(decrypted, BaseTest.data[0]);
        }
    }
}
