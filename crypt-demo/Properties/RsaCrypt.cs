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
        public static int PADDING_PKCS1V15 = 0;
        public static int PADDING_OAEP = 1;

        protected int padding;
        protected RsaKeyParameters PublicKey;
        protected AsymmetricKeyParameter PrivateKey;
        protected IAsymmetricBlockCipher cipher;

        public RsaCrypt(AsymmetricKeyParameter Private, RsaKeyParameters Public, int padding)
        {
            this.padding = padding;
            PrivateKey = Private;
            PublicKey = Public;
        }

        public RsaCrypt(String PrvPath, String PubPath, int padding)
        {
            this.padding = padding;
            PrivateKey = ReadPrivateKey(PrvPath);
            PublicKey = ReadPublicKey(PubPath);
        }

        public string Encrypt(String plaintext)
        {
            var toEncrypt = Encoding.UTF8.GetBytes(plaintext);
            var ciphertext = new byte[1];

            if (padding == PADDING_PKCS1V15) {
                cipher = new Pkcs1Encoding(new RsaEngine());
                cipher.Init(true, PublicKey);
                ciphertext = cipher.ProcessBlock(toEncrypt, 0, toEncrypt.Length);
            } else
            {
                cipher = new OaepEncoding(new RsaEngine());
                cipher.Init(true, PublicKey);
                ciphertext = cipher.ProcessBlock(toEncrypt, 0, toEncrypt.Length);
            }

            return Convert.ToBase64String(ciphertext);
        }

        public string Decrypt(String ciphertext)
        {
            var bytesToDecrypt = Convert.FromBase64String(ciphertext);
            var plaintext = "";

            if (padding == PADDING_PKCS1V15)
            {
                var decryptEngine = new Pkcs1Encoding(new RsaEngine());
                decryptEngine.Init(false, PrivateKey);
                plaintext = Encoding.UTF8.GetString(decryptEngine.ProcessBlock(bytesToDecrypt, 0, bytesToDecrypt.Length));
            }
            else
            {
                var decryptEngine = new OaepEncoding(new RsaEngine());
                decryptEngine.Init(false, PrivateKey);
                plaintext = Encoding.UTF8.GetString(decryptEngine.ProcessBlock(bytesToDecrypt, 0, bytesToDecrypt.Length));
            }

            return plaintext;
        }

        protected static AsymmetricKeyParameter ReadPrivateKey(String Path)
        {
            AsymmetricCipherKeyPair keyPair;

            using (var reader = File.OpenText(Path))
                keyPair = (AsymmetricCipherKeyPair)new PemReader(reader).ReadObject();

            return keyPair.Private;
        }

        protected static RsaKeyParameters ReadPublicKey(String Path)
        {
            var FileStream = System.IO.File.OpenText(Path);
            var PemReader = new PemReader(FileStream);
            var KeyParameter = (RsaKeyParameters)PemReader.ReadObject();

            return KeyParameter;
        }
    }
}
