using System;
using System.Text;
using System.Security.Cryptography.X509Certificates;
using System.Security.Cryptography;

namespace crypt_demo.Properties
{
    public class X509Crypt
    {

        private X509Certificate2 Cert;

        public X509Crypt(String CertPath)
        {
            Cert = new X509Certificate2(CertPath);
        }

        /**
         * Encrypt will encrypt a string password using an SSL certificate, returning a Base64 for of the encrypt result
         */
        public String Encrypt(String Password)
        {
            using (RSA Rsa = Cert.GetRSAPublicKey())
            {
                byte[] PasswordBytes = Encoding.UTF8.GetBytes(Password);
                byte[] EncryptedPassword = Rsa.Encrypt(PasswordBytes, RSAEncryptionPadding.OaepSHA512);

                return Convert.ToBase64String(EncryptedPassword);
            }
        }

        /**
         * Decrypt will decrypt a string password using an SSL certificate, expecting a Base64 form of the encrypted password
         */
        public String Decrypt(String Password)
        {
            using (RSA Rsa = Cert.GetRSAPrivateKey())
            {
                byte[] PasswordBytes = Convert.FromBase64String(Password);
                byte[] DecryptedPassword = Rsa.Decrypt(PasswordBytes, RSAEncryptionPadding.OaepSHA512);

                return Encoding.UTF8.GetString(DecryptedPassword);
            }
        }

    }
}
