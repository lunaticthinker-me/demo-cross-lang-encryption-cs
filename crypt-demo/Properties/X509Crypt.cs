using System;
using System.Text;
using System.Security.Cryptography.X509Certificates;
using System.Security.Cryptography;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Crypto.Encodings;
using Org.BouncyCastle.Crypto.Engines;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.OpenSsl;
using System.IO;

namespace crypt_demo.Properties
{
    public class X509Crypt : RsaCrypt
    {

        //private X509Certificate2 Cert;

        public X509Crypt(String PrvPath, String PubPath, int padding): base(ReadPrivateKey(PrvPath), ReadPublicKey(PubPath), padding)
        {
            //this.padding = padding;
            //PrivateKey = ReadPrivateKey(PrvPath);
            //PublicKey = ReadPublicKey(PubPath);
        }

        public X509Crypt(AsymmetricKeyParameter Private, RsaKeyParameters Public, int padding) : base(Private, Public, padding)
        {
            //this.padding = padding;
            //PrivateKey = Private;
            //PublicKey = Public;
        }

        //public X509Crypt(String CertPath, int padding)
        //    : base(null, null, padding)
        //{ }

        //private static Tuple<string, string> DiscoverKeys(String CertPath)
        //{
        //    //var Cert = new X509Certificate2(CertPath);
        //    var pkcs12 = new Pkcs12Store(new FileStream(CertPath, FileMode.Open, FileAccess.Read), new char[0]);
        //    string keyAlias = null;
        //    foreach (string name in pkcs12.Aliases)
        //    {
        //        if (pkcs12.IsKeyEntry(name))
        //        {
        //            keyAlias = name;
        //            break;
        //        }
        //    }


        //    return new Tuple<string, string>(Cert.GetRSAPublicKey().ToString(), Cert.GetRSAPublicKey().ToString());
        //}

        protected static AsymmetricKeyParameter ReadPrivateKey(String Path)
        {
            RsaPrivateCrtKeyParameters keyPair;

            using (var reader = File.OpenText(Path))
                keyPair = (RsaPrivateCrtKeyParameters)new PemReader(reader).ReadObject();

            return keyPair;
        }

        protected static Org.BouncyCastle.X509.X509Certificate ReadCertificate(String Path)
        {
            var FileStream = File.OpenText(Path);
            var PemReader = new PemReader(FileStream);
            var KeyParameter = (Org.BouncyCastle.X509.X509Certificate)PemReader.ReadObject();

            return KeyParameter;
        }

        protected static new RsaKeyParameters ReadPublicKey(String Path)
        {
            return (RsaKeyParameters)ReadCertificate(Path).GetPublicKey();
        }

        ///**
        // * Encrypt will encrypt a string password using an SSL certificate, returning a Base64 for of the encrypt result
        // */
        //public String Encrypt(String Password)
        //{
        //    using (RSA Rsa = Cert.GetRSAPublicKey())
        //    {
        //        byte[] PasswordBytes = Encoding.UTF8.GetBytes(Password);
        //        byte[] EncryptedPassword = Rsa.Encrypt(PasswordBytes, RSAEncryptionPadding.OaepSHA512);

        //        return Convert.ToBase64String(EncryptedPassword);
        //    }
        //}

        ///**
        // * Decrypt will decrypt a string password using an SSL certificate, expecting a Base64 form of the encrypted password
        // */
        //public String Decrypt(String Password)
        //{
        //    using (RSA Rsa = Cert.GetRSAPrivateKey())
        //    {
        //        byte[] PasswordBytes = Convert.FromBase64String(Password);
        //        byte[] DecryptedPassword = Rsa.Decrypt(PasswordBytes, RSAEncryptionPadding.OaepSHA512);

        //        return Encoding.UTF8.GetString(DecryptedPassword);
        //    }
        //}

    }
}
