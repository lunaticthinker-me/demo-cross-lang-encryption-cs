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
        [TestMethod]
        public void TestNewAes()
        {
            var aes = new AesCrypt("1234567890123456");
        }

        [TestMethod]
        public void TestAesEncrypt()
        {
            var aes = new AesCrypt("1234567890123456");
            //seems C# has length limit when it comes to AES Encryption - default value should have been 'test'
            var encrypted = aes.Encrypt("th1s1smyp@ssw0rd");
        }

        [TestMethod]
        public void TestAesDecrypt()
        {
            var aes = new AesCrypt("1234567890123456");
            var encrypted = aes.Encrypt("th1s1smyp@ssw0rd");
            var decrypted = aes.Decrypt(encrypted);

            Assert.AreEqual(decrypted, "th1s1smyp@ssw0rd");
        }
    }
}
