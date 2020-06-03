using System;
using System.IO;
using System.Text;
using System.Security.Cryptography;
using System.Collections.Generic;

namespace crypt_demo.Properties
{
    public class AesCrypt
    {

        private RijndaelManaged aes;

        public AesCrypt(String Hash)
        {

            if (Hash.Length != 16 && Hash.Length != 24 && Hash.Length != 32)
            {
                throw new Exception("Invalid hash length. Must be 16, 24 or 32.");
            }

            aes = new RijndaelManaged();
            aes.KeySize = Hash.Length * 8;
            aes.Mode = CipherMode.CFB;
            aes.Padding = PaddingMode.None;
            aes.Key = Encoding.UTF8.GetBytes(Hash);
            aes.GenerateIV();
        }

        /**
         * Encrypt will encrypt a string password using AES algorithm, returning a Base64 for of the encrypt result
         */
        public string Encrypt(String password)
        {
            byte[] data = Encoding.UTF8.GetBytes(password);

            using (var encryptor = this.aes.CreateEncryptor())
            using (var msEncrypt = new MemoryStream())
            using (var csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
            using (var bw = new BinaryWriter(csEncrypt, Encoding.UTF8))
            {
                bw.Write(data);
                bw.Close();

                List<byte> list = new List<byte>();
                list.AddRange(this.aes.IV);
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

            Array.Copy(data, 0, this.aes.IV, 0, 16);

            byte[] cryptedData = new byte[data.Length - 16];
            Array.Copy(data, 16, cryptedData, 0, data.Length - 16);

            using (var decrytpor = this.aes.CreateDecryptor())
            using (var msEncrypt = new MemoryStream())
            using (var csEncrypt = new CryptoStream(msEncrypt, decrytpor, CryptoStreamMode.Write))
            using (var bw = new BinaryWriter(csEncrypt, Encoding.UTF8))
            {
                bw.Write(cryptedData);
                bw.Close();

                return Encoding.UTF8.GetString(msEncrypt.ToArray());
            }
        }
    }
}
