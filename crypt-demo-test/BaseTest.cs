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

        public static string GO_AES_CFB_128 = "oY1l7SRz3vPu/nLaNf6euVkBZhLuy4pQwdinAXvF2yw=";
        public static string GO_AES_CFB_192 = "G+vaj9f0x9iBpQ6TLyP/fCXUHxh22K992SH54PnTk/0=";
        public static string GO_AES_CFB_256 = "nrJOJyOcYkUsONjMV9wTi2aGxCaDGtdsw7sboqUS7M0=";
        public static string GO_AES_CBC_128 = "q3COtjkmO4qgM01LlmE5tIJAhD9mqhMiJ6tSJjEKcqr22z4R4SLuZfMVp4Hf3/+h";
        public static string GO_AES_CBC_192 = "3ENacZVU6cNoMWQnVwc5CpjEErXXjg8dhFvSVLF3w2M222+YZrdDm6er2LV0CblB";
        public static string GO_AES_CBC_256 = "qJEl+hMQwkeDCU8AJNIrhkMsIJwOQgdBiYSYAzreK46pwNl9TxHy4yHW3oHuWoUg";

        public static string JS_AES_CFB_128 = "z11VkLYh2sxTyMSh4wr/VQyNGS0IuJelSVJKSH1piYc=";
        public static string JS_AES_CFB_192 = "4+eUuv4Hr03hXXVz2utBVZmn9fT5E/N95Qq4qIuHWdw=";
        public static string JS_AES_CFB_256 = "1cXCXZZxT4sZc2FzzLGyrE7OZ32GxWLmv2irxJ4KzqI=";
        public static string JS_AES_CFB8_128 = "1ZzwOUXOhhbCrxOXQvnO8lA0he+bZo7KCfu6J1w75MI=";
        public static string JS_AES_CFB8_192 = "EJ9WAk9j4i7j9Dm0xiRh8x5r7/KZHLXO/Y34wC7m7jE=";
        public static string JS_AES_CFB8_256 = "Y7i1V8qehMsUs0Oo8NDWOqT7rSMr1rRY+gP6Pa+7peU=";
        public static string JS_AES_CBC_128 = "ysMa13YpdgO0zsRmZlKUF7uarZsCuDutYdjjgnntSRm8dAZWj4Nm2yo4bRGAZrWq";
        public static string JS_AES_CBC_192 = "d52n/ivp5Vakrx30+IVn7kUjVc4gzCl1dZDa53+8GmvpgrH8GNQcnxJGPW9QkZd0";
        public static string JS_AES_CBC_256 = "RK3HQA6FhecHKMGZIMR+jOs6VnKxLT2Y2YYY/IEPxeGp687czg6iGDomrH/K9Gsh";

        public static string PY_AES_CFB8_128 = "mllIL/0l03VULBmJZpLfHgnpEIgBY20C6eUDd/C4nf0=";
        public static string PY_AES_CFB8_192 = "BKf2TvLAX/XhhobBBI90h9TapCweKd27M3vk5OEUcEc=";
        public static string PY_AES_CFB8_256 = "0/2/ZETH0ItnFwq2HG8Bz+1yRyi8Qn43GMBBJgbWxyM=";
        public static string PY_AES_CBC_128 = "w+9OjMn4Z6YeCrzo7DmhTpL++Udp/vMU+0nulOMcN0JL7iwYIEzKl9iGCVgzCuRf";
        public static string PY_AES_CBC_192 = "0PuhDzNNaDdFuIFYFN7wmt4ucCWNqYLs3mJdauJgOLx9GBH5zQ6BNQwdjd85I4Hd";
        public static string PY_AES_CBC_256 = "BALwcIvh+HaYRkkbuNuUfBWSfUlElpJNOY5YX8AvvLA9bI2N+966RAKRZFG0FZuW";


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
