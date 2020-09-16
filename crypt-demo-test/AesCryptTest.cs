using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using crypt_demo.Properties;

/**
 * Thank God for Tutorials:
 * https://docs.microsoft.com/en-us/visualstudio/test/walkthrough-creating-and-running-unit-tests-for-managed-code?view=vs-2019
 */

namespace crypt_demo_test
{
    [TestClass]
    public class AesCryptTest
    {

        AesCrypt aes128Cfb = new AesCrypt(BaseTest.aes128Hash);
        AesCrypt aes192Cfb = new AesCrypt(BaseTest.aes192Hash);
        AesCrypt aes256Cfb = new AesCrypt(BaseTest.aes256Hash);
        AesCrypt aes128Cbc = new AesCrypt(BaseTest.aes128Hash, System.Security.Cryptography.CipherMode.CBC);
        AesCrypt aes192Cbc = new AesCrypt(BaseTest.aes192Hash, System.Security.Cryptography.CipherMode.CBC);
        AesCrypt aes256Cbc = new AesCrypt(BaseTest.aes256Hash, System.Security.Cryptography.CipherMode.CBC);

        [TestMethod]
        public void TestNewAes()
        {
            var aes = new AesCrypt(BaseTest.aes128Hash);
        }

        [TestMethod]
        public void TestAesEncryptDecrypt_128_Cfb()
        {
            foreach (string item in BaseTest.data)
            {
                var encrypted = aes128Cfb.Encrypt(item);
                var decrypted = aes128Cfb.Decrypt(encrypted);

                Assert.AreEqual(decrypted, item);
            }
        }

        [TestMethod]
        public void TestAesEncryptDecrypt_192_Cfb()
        {
            foreach (string item in BaseTest.data)
            {
                var encrypted = aes192Cfb.Encrypt(item);
                var decrypted = aes192Cfb.Decrypt(encrypted);

                Assert.AreEqual(decrypted, item);
            }
        }

        [TestMethod]
        public void TestAesEncryptDecrypt_256_Cfb()
        {
            foreach (string item in BaseTest.data)
            {
                var encrypted = aes256Cfb.Encrypt(item);
                var decrypted = aes256Cfb.Decrypt(encrypted);

                Assert.AreEqual(decrypted, item);
            }
        }

        [TestMethod]
        public void TestAesEncryptDecrypt_128_Cbc()
        {

            foreach (string item in BaseTest.data)
            {
                var encrypted = aes128Cbc.Encrypt(item);
                var decrypted = aes128Cbc.Decrypt(encrypted);

                Assert.AreEqual(decrypted, item);
            }
        }

        [TestMethod]
        public void TestAesEncryptDecrypt_192_Cbc()
        {
            foreach (string item in BaseTest.data)
            {
                var encrypted = aes192Cbc.Encrypt(item);
                var decrypted = aes192Cbc.Decrypt(encrypted);

                Assert.AreEqual(decrypted, item);
            }
        }

        [TestMethod]
        public void TestAesEncryptDecrypt_256_Cbc()
        {

            foreach (string item in BaseTest.data)
            {
                var encrypted = aes256Cbc.Encrypt(item);
                var decrypted = aes256Cbc.Decrypt(encrypted);

                Assert.AreEqual(decrypted, item);
            }
        }

        // GoLang

        [TestMethod]
        [Ignore]
        public void TestAesDecrypt_FromGo_128_Cfb()
        {
            var decrypted = aes128Cfb.Decrypt(BaseTest.GO_AES_CFB_128);
            Assert.AreEqual(decrypted, BaseTest.data[0]);
        }

        [TestMethod]
        [Ignore]
        public void TestAesDecrypt_FromGo_192_Cfb()
        {
            var decrypted = aes192Cfb.Decrypt(BaseTest.GO_AES_CFB_192);
            Assert.AreEqual(decrypted, BaseTest.data[0]);
        }

        [TestMethod]
        [Ignore]
        public void TestAesDecrypt_FromGo_256_Cfb()
        {
            var decrypted = aes256Cfb.Decrypt(BaseTest.GO_AES_CFB_256);
            Assert.AreEqual(decrypted, BaseTest.data[0]);
        }

        [TestMethod]
        public void TestAesDecrypt_FromGo_128_Cbc()
        {
            var decrypted = aes128Cbc.Decrypt(BaseTest.GO_AES_CBC_128);
            Assert.AreEqual(decrypted, BaseTest.data[0]);
        }

        [TestMethod]
        public void TestAesDecrypt_FromGo_192_Cbc()
        {
            var decrypted = aes192Cbc.Decrypt(BaseTest.GO_AES_CBC_192);
            Assert.AreEqual(decrypted, BaseTest.data[0]);
        }

        [TestMethod]
        public void TestAesDecrypt_FromGo_256_Cbc()
        {
            var decrypted = aes256Cbc.Decrypt(BaseTest.GO_AES_CBC_256);
            Assert.AreEqual(decrypted, BaseTest.data[0]);
        }

        // Js

        [TestMethod]
        public void TestAesDecrypt_FromJs_128_Cfb()
        {
            var decrypted = aes128Cfb.Decrypt(BaseTest.JS_AES_CFB8_128);
            Assert.AreEqual(decrypted, BaseTest.data[0]);
        }

        [TestMethod]
        public void TestAesDecrypt_FromJs_192_Cfb()
        {
            var decrypted = aes192Cfb.Decrypt(BaseTest.JS_AES_CFB8_192);
            Assert.AreEqual(decrypted, BaseTest.data[0]);
        }

        [TestMethod]
        public void TestAesDecrypt_FromJs_256_Cfb()
        {
            var decrypted = aes256Cfb.Decrypt(BaseTest.JS_AES_CFB8_256);
            Assert.AreEqual(decrypted, BaseTest.data[0]);
        }

        [TestMethod]
        public void TestAesDecrypt_FromJs_128_Cbc()
        {
            var decrypted = aes128Cbc.Decrypt(BaseTest.JS_AES_CBC_128);
            Assert.AreEqual(decrypted, BaseTest.data[0]);
        }

        [TestMethod]
        public void TestAesDecrypt_FromJs_192_Cbc()
        {
            var decrypted = aes192Cbc.Decrypt(BaseTest.JS_AES_CBC_192);
            Assert.AreEqual(decrypted, BaseTest.data[0]);
        }

        [TestMethod]
        public void TestAesDecrypt_FromJs_256_Cbc()
        {
            var decrypted = aes256Cbc.Decrypt(BaseTest.JS_AES_CBC_256);
            Assert.AreEqual(decrypted, BaseTest.data[0]);
        }

        // Py

        [TestMethod]
        public void TestAesDecrypt_FromPy_128_Cfb()
        {
            var decrypted = aes128Cfb.Decrypt(BaseTest.PY_AES_CFB8_128);

            Assert.AreEqual(decrypted, BaseTest.data[0]);
        }

        [TestMethod]
        public void TestAesDecrypt_FromPy_192_Cfb()
        {
            var decrypted = aes192Cfb.Decrypt(BaseTest.PY_AES_CFB8_192);

            Assert.AreEqual(decrypted, BaseTest.data[0]);
        }

        [TestMethod]
        public void TestAesDecrypt_FromPy_256_Cfb()
        {
            var decrypted = aes256Cfb.Decrypt(BaseTest.PY_AES_CFB8_256);

            Assert.AreEqual(decrypted, BaseTest.data[0]);
        }

        [TestMethod]
        public void TestAesDecrypt_FromPy_128_Cbc()
        {
            var decrypted = aes128Cbc.Decrypt(BaseTest.PY_AES_CBC_128);

            Assert.AreEqual(decrypted, BaseTest.data[0]);
        }

        [TestMethod]
        public void TestAesDecrypt_FromPy_192_Cbc()
        {
            var decrypted = aes192Cbc.Decrypt(BaseTest.PY_AES_CBC_192);

            Assert.AreEqual(decrypted, BaseTest.data[0]);
        }

        [TestMethod]
        public void TestAesDecrypt_FromPy_256_Cbc()
        {
            var decrypted = aes256Cbc.Decrypt(BaseTest.PY_AES_CBC_256);

            Assert.AreEqual(decrypted, BaseTest.data[0]);
        }
    }
}
