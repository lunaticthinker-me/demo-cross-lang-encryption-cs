﻿using System;
using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using crypt_demo.Properties;

namespace crypt_demo_test
{
    [TestClass]
    public class RsaCryptTest
    {

        protected string[] data = BaseTest.GenerateData();

        public RsaCrypt rsaPkcs1v15
        {
            get {
                String PubPath = String.Concat(Directory.GetCurrentDirectory(), "\\..\\..\\..\\cert\\rsa\\cert.pem").Replace("\\", Path.DirectorySeparatorChar.ToString());
                String PrvPath = String.Concat(Directory.GetCurrentDirectory(), "\\..\\..\\..\\cert\\rsa\\key.pem").Replace("\\", Path.DirectorySeparatorChar.ToString());
                return new RsaCrypt(PrvPath, PubPath, RsaCrypt.PADDING_PKCS1V15);
            }
        }

        public RsaCrypt rsaOaep
        {
            get {
                String PubPath = String.Concat(Directory.GetCurrentDirectory(), "\\..\\..\\..\\cert\\rsa\\cert.pem").Replace("\\", Path.DirectorySeparatorChar.ToString());
                String PrvPath = String.Concat(Directory.GetCurrentDirectory(), "\\..\\..\\..\\cert\\rsa\\key.pem").Replace("\\", Path.DirectorySeparatorChar.ToString());
                return new RsaCrypt(PrvPath, PubPath, RsaCrypt.PADDING_OAEP);
            }
        }

        [TestMethod]
        public void TestRsaEncryptDecrypt()
        {
            foreach (var item in data)
            {
                var encrypted = rsaPkcs1v15.Encrypt(item);
                var decrypted = rsaPkcs1v15.Decrypt(encrypted);
                Assert.AreEqual(decrypted, item);
            }
        }

        [TestMethod]
        public void TestRsaDecrypt_From_Go_Pkcs1v15()
        {
            var decrypted = rsaPkcs1v15.Decrypt(BaseTest.GO_RSA_PKCS1V1_5);
            Assert.AreEqual(decrypted, data[0]);
        }

        [TestMethod]
        [Ignore]
        public void TestRsaDecrypt_From_Go_Oaep()
        {
            var decrypted = rsaOaep.Decrypt(BaseTest.GO_RSA_OAEP);
            Assert.AreEqual(decrypted, data[0]);
        }

        [TestMethod]
        public void TestRsaDecrypt_From_Js_Pkcs1v15()
        {
            var decrypted = rsaPkcs1v15.Decrypt(BaseTest.JS_RSA_PKCS1V1_5);
            Assert.AreEqual(decrypted, data[0]);
        }

        [TestMethod]
        public void TestRsaDecrypt_From_Js_Oaep()
        {
            var decrypted = rsaOaep.Decrypt(BaseTest.JS_RSA_OAEP);
            Assert.AreEqual(decrypted, data[0]);
        }

        [TestMethod]
        public void TestRsaDecrypt_From_Py_Pkcs1v15()
        {
            var decrypted = rsaPkcs1v15.Decrypt(BaseTest.PY_RSA_PKCS1V1_5);
            Assert.AreEqual(decrypted, data[0]);
        }

        [TestMethod]
        public void TestRsaDecrypt_From_Py_Oaep()
        {
            var decrypted = rsaOaep.Decrypt(BaseTest.PY_RSA_OAEP);
            Assert.AreEqual(decrypted, data[0]);
        }
    }
}
