using System;
using System.IO;
using System.Text;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Crypto.Encodings;
using Org.BouncyCastle.Crypto.Engines;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.OpenSsl;

namespace crypt_demo.Properties
{
    public class RsaCrypt
    {
        private RsaKeyParameters PublicKey;
        private AsymmetricKeyParameter PrivateKey;

        public RsaCrypt(String PrvPath, String PubPath)
        {
            PrivateKey = ReadPrivateKey(PrvPath);
            PublicKey = ReadPublicKey(PubPath);
        }

        public string Encrypt(String Password)
        {
            var cipher = new Pkcs1Encoding(new RsaEngine());
            cipher.Init(true, PublicKey);
            var toEncrypt = Encoding.UTF8.GetBytes(Password);
            var EncryptedPassword = cipher.ProcessBlock(toEncrypt, 0, toEncrypt.Length);

            return Convert.ToBase64String(EncryptedPassword);
        }

        public string Decrypt(String Password)
        {
            var bytesToDecrypt = Convert.FromBase64String(Password);
            var decryptEngine = new Pkcs1Encoding(new RsaEngine());
            decryptEngine.Init(false, PrivateKey);
            var EncryptedPassword = Encoding.UTF8.GetString(decryptEngine.ProcessBlock(bytesToDecrypt, 0, bytesToDecrypt.Length));

            return EncryptedPassword;
        }

        private AsymmetricKeyParameter ReadPrivateKey(String Path)
        {
            AsymmetricCipherKeyPair keyPair;

            using (var reader = File.OpenText(Path))
                keyPair = (AsymmetricCipherKeyPair)new PemReader(reader).ReadObject();

            return keyPair.Private;
            //var FileStream = System.IO.File.OpenText(Path);
            //var PemReader = new PemReader(FileStream);
            //var KeyParameter = (AsymmetricKeyParameter)PemReader.ReadObject();

            //return KeyParameter;
        }

        private RsaKeyParameters ReadPublicKey(String Path)
        {
            var FileStream = System.IO.File.OpenText(Path);
            var PemReader = new PemReader(FileStream);
            var KeyParameter = (RsaKeyParameters)PemReader.ReadObject();

            return KeyParameter;
        }
    }
}
