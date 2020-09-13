using System;
using System.IO;
using System.Text;
using System.Security.Cryptography;
using System.Collections.Generic;

namespace crypt_demo.Properties
{
    public class AesCrypt
    {

        private RijndaelManaged alg;
        //private Aes alg;

        private int BlockSize = 16;

        public AesCrypt(String Hash, CipherMode Mode = CipherMode.CFB)
        {

            if (Hash.Length != 16 && Hash.Length != 24 && Hash.Length != 32)
            {
                throw new Exception("Invalid hash length. Must be 16, 24 or 32.");
            }

            // https://gist.github.com/mark-adams/87aa34da3a5ed48ed0c7
            alg = new RijndaelManaged();
            //alg = Aes.Create();
            alg.KeySize = Hash.Length * 8;
            alg.BlockSize = BlockSize * 8;

            alg.FeedbackSize = 8; // seems that C# Likes only CFB-8
            alg.Mode = Mode;
            alg.Padding = (Mode == CipherMode.CBC) ? PaddingMode.PKCS7 : PaddingMode.None;

            alg.Key = Encoding.UTF8.GetBytes(Hash);
            alg.GenerateIV();
        }

        /**
         * Encrypt will encrypt a string password using AES algorithm, returning a Base64 for of the encrypt result
         */
        public string Encrypt(String password)
        {
            byte[] data = Encoding.UTF8.GetBytes(password);

            using (var encryptor = alg.CreateEncryptor(alg.Key, alg.IV))
            using (var msEncrypt = new MemoryStream())
            using (var csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))

            //using (var bw = new BinaryWriter(csEncrypt, Encoding.UTF8))
            //{
            //    bw.Write(data);
            //    bw.Close();

            {
                csEncrypt.Write(data, 0, data.Length);
                csEncrypt.FlushFinalBlock();

                List<byte> list = new List<byte>();
                list.AddRange(alg.IV);
                list.AddRange(msEncrypt.ToArray());

                return Convert.ToBase64String(list.ToArray());
            }
        }


        /**
         * Decrypt will decrypt a string password using AES algorithm, expecting a Base64 form of the encrypted password
         */
        public String Decrypt(String ciphertext)
        {
            byte[] data = Convert.FromBase64String(ciphertext);

            Array.Copy(data, 0, alg.IV, 0, BlockSize);

            //byte[] cryptedData = new byte[data.Length - 16];
            //Array.Copy(data, 16, cryptedData, 0, cryptedData.Length);

            using (var decrytpor = alg.CreateDecryptor(alg.Key, alg.IV))
            using (var msDecrypt = new MemoryStream())
            using (var csDecrypt = new CryptoStream(msDecrypt, decrytpor, CryptoStreamMode.Write))

            //using (var bw = new BinaryWriter(csDecrypt, Encoding.UTF8))
            //{
            //    bw.Write(cryptedData);
            //    bw.Close();

            {
                csDecrypt.Write(data, 0, data.Length);
                csDecrypt.FlushFinalBlock();

                var decryptedData = msDecrypt.ToArray();
                var decrypted = new byte[decryptedData.Length - 16];
                Array.Copy(decryptedData, 16, decrypted, 0, decrypted.Length);

                return Encoding.UTF8.GetString(decrypted);
            }
        }
    }
}
