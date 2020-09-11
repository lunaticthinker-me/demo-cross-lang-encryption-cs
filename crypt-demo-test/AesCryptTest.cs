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
        static string[] data = BaseTest.GenerateData();

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
            foreach (string item in data)
            {
                var encrypted = aes128Cfb.Encrypt(item);
                var decrypted = aes128Cfb.Decrypt(encrypted);

                Assert.AreEqual(decrypted, item);
            }
        }

        [TestMethod]
        public void TestAesEncryptDecrypt_192_Cfb()
        {
            foreach (string item in data)
            {
                var encrypted = aes192Cfb.Encrypt(item);
                var decrypted = aes192Cfb.Decrypt(encrypted);

                Assert.AreEqual(decrypted, item);
            }
        }

        [TestMethod]
        public void TestAesEncryptDecrypt_256_Cfb()
        {
            foreach (string item in data)
            {
                var encrypted = aes256Cfb.Encrypt(item);
                var decrypted = aes256Cfb.Decrypt(encrypted);

                Assert.AreEqual(decrypted, item);
            }
        }

        [TestMethod]
        public void TestAesEncryptDecrypt_128_Cbc()
        {

            foreach (string item in data)
            {
                var encrypted = aes128Cbc.Encrypt(item);
                var decrypted = aes128Cbc.Decrypt(encrypted);

                Assert.AreEqual(decrypted, item);
            }
        }

        [TestMethod]
        public void TestAesEncryptDecrypt_192_Cbc()
        {
            foreach (string item in data)
            {
                var encrypted = aes192Cbc.Encrypt(item);
                var decrypted = aes192Cbc.Decrypt(encrypted);

                Assert.AreEqual(decrypted, item);
            }
        }

        [TestMethod]
        public void TestAesEncryptDecrypt_256_Cbc()
        {

            foreach (string item in data)
            {
                var encrypted = aes256Cbc.Encrypt(item);
                var decrypted = aes256Cbc.Decrypt(encrypted);

                Assert.AreEqual(decrypted, item);
            }
        }

        // GoLang

        [TestMethod]
        public void TestAesDecrypt_FromGo_128_Cfb()
        {
            var decrypted = aes128Cfb.Decrypt("JLbKSQXWKFFs+727w1dBJXCAVQypFDYr+FwoJ+u3IMg=");

            Assert.AreEqual(decrypted, data[0]);
        }

        [TestMethod]
        public void TestAesDecrypt_FromGo_192_Cfb()
        {
            var decrypted = aes192Cfb.Decrypt("lkyhuJGvKOwOT5cKYJz9mmO6ND2PGo/XOM5mv5OIvYM=");

            Assert.AreEqual(decrypted, data[0]);
        }

        [TestMethod]
        public void TestAesDecrypt_FromGo_256_Cfb()
        {
            var decrypted = aes256Cfb.Decrypt("bmcX3+xKhz3Xml4/mQTL9qILe7SEIOfocERs4ZcqD74=");

            Assert.AreEqual(decrypted, data[0]);
        }

        [TestMethod]
        public void TestAesDecrypt_FromGo_128_Cbc()
        {
            var decrypted = aes128Cbc.Decrypt("U2FsdGVkX19XBYvodmAen0okxjD6wSPQoBWuEdsVkKU=");

            Assert.AreEqual(decrypted, data[0]);
        }

        [TestMethod]
        public void TestAesDecrypt_FromGo_192_Cbc()
        {
            var decrypted = aes192Cbc.Decrypt("hCNI0Yb90jKAhds4x9c4G0c5CwtRxMtCfe4As3JIq8A=");

            Assert.AreEqual(decrypted, data[0]);
        }

        [TestMethod]
        public void TestAesDecrypt_FromGo_256_Cbc()
        {
            var decrypted = aes256Cbc.Decrypt("dXP9pSWf6cgAegouT5UDTfkDE+t7A3j9khe7N/vNB00=");

            Assert.AreEqual(decrypted, data[0]);
        }

        // Js

        [TestMethod]
        public void TestAesDecrypt_FromJs_128_Cfb()
        {
            var decrypted = aes128Cfb.Decrypt("y8R99YhPP/lxUgjqY+SpQAf1YwtONFeup7URr/2vmMk=");

            Assert.AreEqual(decrypted, data[0]);
        }

        [TestMethod]
        public void TestAesDecrypt_FromJs_192_Cfb()
        {
            var decrypted = aes192Cfb.Decrypt("/LTF6sDSYCuZZz/89YsbKHFSLMfLGnJcUTmeOXwN+Jc=");

            Assert.AreEqual(decrypted, data[0]);
        }

        [TestMethod]
        public void TestAesDecrypt_FromJs_256_Cfb()
        {
            var decrypted = aes256Cfb.Decrypt("pw+xIqA9PLYZcpbvYrungH/7sVXkNBZ3euvyEnDpnfk=");

            Assert.AreEqual(decrypted, data[0]);
        }

        [TestMethod]
        public void TestAesDecrypt_FromJs_128_Cbc()
        {
            var decrypted = aes128Cbc.Decrypt("kqiHehYhsAo+ba+w5aJw+7nVftIu9TDIEG39uJHIEXPlfiVjRGc8dYBW2CCqshO2");

            Assert.AreEqual(decrypted, data[0]);
        }

        [TestMethod]
        public void TestAesDecrypt_FromJs_192_Cbc()
        {
            var decrypted = aes192Cbc.Decrypt("Aq4VxKVFXRTZ+8OvzKsw2WGa/DAMC3JZfoLdqza1rcbUdrccUc+7QCTn7cRgyMua");

            Assert.AreEqual(decrypted, data[0]);
        }

        [TestMethod]
        public void TestAesDecrypt_FromJs_256_Cbc()
        {
            var decrypted = aes256Cbc.Decrypt("jWnvB3QpTqPeSTXc5rFQVfTg4RBmKAPcNOE8SQ+BphFv5N0U5Fw5DGZiPTOJkic7");

            Assert.AreEqual(decrypted, data[0]);
        }

        //// Py

        //[TestMethod]
        //public void TestAesDecrypt_FromPy_128_Cfb()
        //{
        //    var decrypted = aes128Cfb.Decrypt("5WPWeBKWEafSfZCAscojoXjpr6AG78cC7Sqx52X9/fo=");

        //    Assert.AreEqual(decrypted, data[0]);
        //}

        //[TestMethod]
        //public void TestAesDecrypt_FromPy_192_Cfb()
        //{
        //    var decrypted = aes192Cfb.Decrypt("lkyhuJGvKOwOT5cKYJz9mmO6ND2PGo/XOM5mv5OIvYM=");

        //    Assert.AreEqual(decrypted, data[0]);
        //}

        //[TestMethod]
        //public void TestAesDecrypt_FromPy_256_Cfb()
        //{
        //    var decrypted = aes256Cfb.Decrypt("bmcX3+xKhz3Xml4/mQTL9qILe7SEIOfocERs4ZcqD74=");

        //    Assert.AreEqual(decrypted, data[0]);
        //}

        //[TestMethod]
        //public void TestAesDecrypt_FromPy_128_Cbc()
        //{
        //    var decrypted = aes128Cbc.Decrypt("6u9RmbQs5XQQEIug+lP1+zRssBPfkQ5e0Y78TUbCtUE=");

        //    Assert.AreEqual(decrypted, data[0]);
        //}

        //[TestMethod]
        //public void TestAesDecrypt_FromPy_192_Cbc()
        //{
        //    var decrypted = aes192Cbc.Decrypt("hCNI0Yb90jKAhds4x9c4G0c5CwtRxMtCfe4As3JIq8A=");

        //    Assert.AreEqual(decrypted, data[0]);
        //}

        //[TestMethod]
        //public void TestAesDecrypt_FromPy_256_Cbc()
        //{
        //    var decrypted = aes256Cbc.Decrypt("dXP9pSWf6cgAegouT5UDTfkDE+t7A3j9khe7N/vNB00=");

        //    Assert.AreEqual(decrypted, data[0]);
        //}
    }
}
