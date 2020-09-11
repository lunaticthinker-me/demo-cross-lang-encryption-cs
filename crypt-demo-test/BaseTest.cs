using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace crypt_demo_test
{
    class BaseTest
    {
        protected static Random random = new Random();

        public static string aes128Hash = "1234567890123456";
        public static string aes192Hash = "123456789012345612345678";
        public static string aes256Hash = "12345678901234561234567890123456";

        public static string[] GenerateData()
        {
            string[] data = {
                "th1s1smyp@ssw0rd",
                RandomString(4),
                RandomString(16),
                RandomString(100),
            };
            return data;
        }
        protected static string RandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }

    }
}
