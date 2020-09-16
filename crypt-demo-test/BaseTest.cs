﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace crypt_demo_test
{
    class BaseTest
    {
        protected static Random random = new Random();

        // Go

        public static string GO_AES_CFB_128 = "oY1l7SRz3vPu/nLaNf6euVkBZhLuy4pQwdinAXvF2yw=";
        public static string GO_AES_CFB_192 = "G+vaj9f0x9iBpQ6TLyP/fCXUHxh22K992SH54PnTk/0=";
        public static string GO_AES_CFB_256 = "nrJOJyOcYkUsONjMV9wTi2aGxCaDGtdsw7sboqUS7M0=";
        public static string GO_AES_CBC_128 = "q3COtjkmO4qgM01LlmE5tIJAhD9mqhMiJ6tSJjEKcqr22z4R4SLuZfMVp4Hf3/+h";
        public static string GO_AES_CBC_192 = "3ENacZVU6cNoMWQnVwc5CpjEErXXjg8dhFvSVLF3w2M222+YZrdDm6er2LV0CblB";
        public static string GO_AES_CBC_256 = "qJEl+hMQwkeDCU8AJNIrhkMsIJwOQgdBiYSYAzreK46pwNl9TxHy4yHW3oHuWoUg";

        public static string GO_RSA_OAEP = "F07Bx1Ok/pPQuHiCW2KUPAkqoqg+15JsZRY6dFyOEnu6j5KysSc4VMov3Y6UXiQztCjD2xdu7cnkkGVGz5388TH/k6tFk4MHUIxBrEzwCXjlQIKZtw6Fvx8+CBqWY3npAixiPjS8ETe0GIxKc8NptB+wwI5lYBd7L1PeGmS65uCy9LMdv2Z45OboLIHB/XOtmwvAuvsNluVJ3rtvhw2dSv/1GXuJCxEdxVkU6N7E+kbdR+qB4bcbCuYsuGKURvOYAZffraAMc1lOjYdwS5bnCdGczD+0Wv+2uYVyUZi1mrVqMYSHLDE4lF00OOwwFlE1WNrfM9hK57CEaGagbCkvlw==";
        public static string GO_RSA_PKCS1V1_5 = "kxve9Bpm4vWjF4UqZMiGkNHQhI8QJ9UFW5ps6Q3bTUliDSlF3bIOBQED0fMCWfWhTveaUrZQWEf8rTs3Xnlkeaf5RN/gZdsDJxZuueFB3sQN8tjPFUetrgcBSk+1HLIbL2K5roU44rX31Rxd6QFk6+Dj4eVBk91Hx+UxfRAETSypbmyVSBItHz6WBFz+CIwhXTqJnmqeOn6rr0TzcyOAUlNKscc8VFjNrMTHQWuOb456hxDMuNzI8wHtFjhnpW6i0XeXyT68U63rxwhfAMQIpfoeSgk/IDCx3WiL7XVlCMLw5UPY9Ir5N9+oemnPX9MD/8wQ00I7HSwg8R0BDqKkUQ==";

        public static string GO_X509_OAEP = "d1oIBE9i+EmGBbijj3G6lqo3sN1BOdtRIDt24Jx1HKnvnAjIcqvqMgnS8Ts5C5k4ya5Xd31ojqljsPaIJwUIoT53Ce99yoxxfzXXg8c59FM6MxbejEzTnK55FGUmjY+cKugCGLMWwECv4JwenNgkHE2ckVHo9Hvd+/W5RSSKwdzacy7yWqIw9fvRboBdhKl/poNHx4+5XCXOb/Z85R6ROO64yxMhstTV7T9g1OPbgx+3HDCV/RNMKBfIyu1HaJKLMoXiYCKeyMTi1yE8UsBD4KOS/w7jBbFyq5kRsFSUzImL9EDPLSAHX5uyZdqy/lkQQTZEicbtqWHS/+lj2gnaOQ==";
        public static string GO_X509_PKCS1V1_5 = "3hSPEOYYRnS/1aes529eMoTt/h44sfpUU2r7AotOP0JWxjKss3vxSHDfuPBG6ICKe1Fhye/v5Z724pYgw9KlSkHLi+9kDDT4vribkkve7eVK3bGRZy5Zjer3vVe5zaSkvepdEz8Jdwd3Y/kGQuuQC4h5HRE/3rimw4adUV4KbNVgWH9l8osFszUSMbPROkMe1ZXFikMvALXplkBAeL3QKT82Xe8OAGVXOOsgJ39xfkriuwdQedy0OqYkef14w+u4G8qxc5hTHPEFC6hybGBvEJS2J6XSU5s84JjWsqkIyxbCIshGA//DHdZ0uA/jiS1MH2ulZryJMcbi9fJYSpD99A==";

        // Js

        public static string JS_AES_CFB_128 = "z11VkLYh2sxTyMSh4wr/VQyNGS0IuJelSVJKSH1piYc=";
        public static string JS_AES_CFB_192 = "4+eUuv4Hr03hXXVz2utBVZmn9fT5E/N95Qq4qIuHWdw=";
        public static string JS_AES_CFB_256 = "1cXCXZZxT4sZc2FzzLGyrE7OZ32GxWLmv2irxJ4KzqI=";
        public static string JS_AES_CFB8_128 = "1ZzwOUXOhhbCrxOXQvnO8lA0he+bZo7KCfu6J1w75MI=";
        public static string JS_AES_CFB8_192 = "EJ9WAk9j4i7j9Dm0xiRh8x5r7/KZHLXO/Y34wC7m7jE=";
        public static string JS_AES_CFB8_256 = "Y7i1V8qehMsUs0Oo8NDWOqT7rSMr1rRY+gP6Pa+7peU=";
        public static string JS_AES_CBC_128 = "ysMa13YpdgO0zsRmZlKUF7uarZsCuDutYdjjgnntSRm8dAZWj4Nm2yo4bRGAZrWq";
        public static string JS_AES_CBC_192 = "d52n/ivp5Vakrx30+IVn7kUjVc4gzCl1dZDa53+8GmvpgrH8GNQcnxJGPW9QkZd0";
        public static string JS_AES_CBC_256 = "RK3HQA6FhecHKMGZIMR+jOs6VnKxLT2Y2YYY/IEPxeGp687czg6iGDomrH/K9Gsh";

        public static string JS_RSA_PKCS1V1_5 = "Qfe9Nd+KEVFgikZeUVAXoopFbJ1/nOWFjKIkhgKt794lZUzv4EbgF7MbVuKzwiI5XnLamJ+5Ki96xNjPEo7WQNbF9AQVwXhhuwj83OLxB8Jps6zyshQn4FbQ0q7trboscHD7rMDMBsn+MPyHz1oYI1C/C9v8eUoCTc7UEo1UcAoQTid1oEigayrR2x15TQY5gLuaTRvpMkqbUUOI1sOgHr5QOsDkqJJWdeE82xhjOthVFUJ+gJrDTFcq7tqYI9FL++nAHjDq4tLS/by1Lif8ivZ3Q+4x2NWlYjUYpFwBT4FULBX58v/PRpr3E3Puh5rs47jHzGdLyMYMx8xm5tC8Ww==";
        public static string JS_RSA_OAEP = "by+ECCKCT8YzHJSmZLZwJKDY01PpMVFOBHhbvZxIQju15Vbhjmg1U7UU+w4dPVGDuApOwY2sLsy+vcabsbqFBotBDQr0wNqPz6ZcjtjDbi5mXvytjd4YGFGDh40U2EiVrMI8lcfVQ/tgWqQ3o7IuOcllAaKFmWexKX+S6esMxkEwlWYQ/anU5wsYtG6E2KhxvI9uL0H/8ycWge0tAl0Vc1p0jEwjmAOozfz0Lzo6Z63tBM+8qNpveRUSLwVlNDW/2RqNYInyfld5vthJuON2EAAFrOaD6NivRLutLkTm+QcIHjMXtNgkYi4t4X0uoziAa8Fq/VdPgHrq9IXxEqz3TA==";

        public static string JS_X509_OAEP = "b+M8mkbPEXfmwSn4Pq36ZdTWJKxqwAscWfvGeJav/mg80hPevM1NkTXXgAOqxeN9ReZNRp31orvsxh+8MVdNQcVMxIpbe/4bTJ7F3HUpbLJKjHtfxllKII9dFjtgpFqqfajsc/6gefXMAZ8Rp/T7Q1943nMrcp3FVTA8TNzeYfWQbS0VDjPSfreaqaK0O2m96m02fEViWuxf4dB/BIrKMcIU7JbpZ2Pwz43HkwQuzCRBNmfM3Fe1UsVIODg/1mTEvOU6DgpU7gbfV+vc0C1KWSjJLVPdWbocExTmcpfJaSRY92w4Pr2ANzjGdUWcYOs5ePUu71+r2IVMa9grl8HCTA==";
        public static string JS_X509_PKCS1V1_5 = "jAH/fnDGo2N8Zn0zxz2WuqwnSIT83fNifIaEZpu+7xefQkdcjciRuTKSRe6WtWNF3B+dSZqWo4WaxLs2vps17tN1qjZAuAJ+8jPHl0tstDiYCZ+uPwRjZbMzGXD80Gl09AeQdgRm6vMEJXX2YnknoD5EdnSM8fgYFrPfl5XWhim62/ToYTZlFTIaYkNxnGIgMsin+3YjX1k8bJJGnQ6KszgojblY5fetzX3OxJApwKseofs2END5CFbW97shezJQsL0DXiZ6SshVTJ3VQ3e28Lmogaqt/a3BYGa2qM6yKG6h7ZXuVJs1BviwtoZgjnUn2gR2MtsPuYCP3YBGBRxY0g==";

        // Py

        public static string PY_AES_CFB8_128 = "mllIL/0l03VULBmJZpLfHgnpEIgBY20C6eUDd/C4nf0=";
        public static string PY_AES_CFB8_192 = "BKf2TvLAX/XhhobBBI90h9TapCweKd27M3vk5OEUcEc=";
        public static string PY_AES_CFB8_256 = "0/2/ZETH0ItnFwq2HG8Bz+1yRyi8Qn43GMBBJgbWxyM=";
        public static string PY_AES_CBC_128 = "w+9OjMn4Z6YeCrzo7DmhTpL++Udp/vMU+0nulOMcN0JL7iwYIEzKl9iGCVgzCuRf";
        public static string PY_AES_CBC_192 = "0PuhDzNNaDdFuIFYFN7wmt4ucCWNqYLs3mJdauJgOLx9GBH5zQ6BNQwdjd85I4Hd";
        public static string PY_AES_CBC_256 = "BALwcIvh+HaYRkkbuNuUfBWSfUlElpJNOY5YX8AvvLA9bI2N+966RAKRZFG0FZuW";

        public static string PY_RSA_PKCS1V1_5 = "fGbqSNgYCioKV7Kz/RXsOqSLp2e1vUAGnOJ3MMCMoOP+tTLiz69hyJRoPYlZwVkepOWmnEM2i3IZzAfqA7FzICecsjjk/hJOC3D6I+D2L4PVXPyTBsLSxvu9va8F/KzEfUBh/ysuw+JeSUc7k6OAsMPdGZPa8cyGDagKCPrGonaCe8Jnqac+zf81/a5sIche2YOqvQnz3V8ESR3XYuS3WYIn7LHkIFvfb4oxDgN1jSpxSZNImdmmLgjN0pW1Vp/UGQQAhnGgJW2Hs3noQtswq0O0XM3hpHJGzV6NA7eKTUSe1X1BrcAI3cUqwlL0XNBVnsNoq/Mj/Z1/4DgvMl34yg==";
        public static string PY_RSA_OAEP = "jbEtUjq4qFzMb1+1LZRO8AZi6UHqm2YYAQjEzYfM5XAYysSdPaFy9EtPFZmgM5ZxbNkThOSvRU2yw9tKUR46F/HRxtqCcnRnbNr+nZoGYRSZzqjyQQsNOGxLBG0X4K0TugvZAu3zU/nFbytEZX/OM/RkiagztXcTGWGWbvfRZ/wvLZTuVH1nAdI9r33PQGceUwplwJ8WFl3amMCC2OejitIXBrkgiHpuAz2IMfj/PM3HN2hykPCb7tTxNmUtc0050NMLaVHYQgxtmQSSCpUPaCz9kZxyjqU1+QYGWw03bgeA02D9tXz13h3j2E9a7CW+Ut6LBja6vOPqnu3oF/p9dw==";

        public static string PY_X509_PKCS1V1_5 = "LlxYVfvKyx8JYWCQWzP44lrVxrIOpjBLxl14eHL/VnQneCHuF7ltRpmnYuVyI7jJHwFDTHokquF4AeTsWwj8zpkTNuWAPPINZ7fL3mfLUqDr+m/P7sCYYMefYFr7cQauS5jQzf60Csbx+U1MKt21/f0IZO00R4VU0S4D3lVY6b2Rs1YhGUYm6rREeSt2jjXO/QtE5gLB8fyEVD7qph+eMvdOkdPwBSr2QtOeL/ol7tEf5ER2oBONEmi0LEXsmc1D/lcFVEdDyRr+ZkQsWd3gUrgpnccBIiC8B9gfrnV2LIfCq4oGQDC+x9uW7/VcofQ5XQ/GaCbqPM47GSy4Uahc6A==";
        public static string PY_X509_OAEP = "uhkBnjBbi56po+XUy8py8hcsDq7zWUpW7//nBn0Ld6roL1LYz1+6o6EK2h+6itr6eeZz2zIiE++eOKHyTdI1IttL04lxbSKHchXRxUmVbk0AJHSRL3rQSMBUHown7YsH9NnnQTiT9+IoqtVUvNo7JM6oA1Ikcv9N9VEPgEbbYvVRLoH4nQt+EGSr6KVX8Uwjh8hBJvZkohpv4OhODailatEEnCPI1224pbchBGd1ebrfFL5VBcWv01KsmbYlYaEolpd7mcXYBtfcv078aA1CmpopHp4B9a+eBXuAkmZ5V4RKWPNeqIx9sSVXaoWAu1Q2DjJ1X6WwNlu+1UuVK106bg==";

        // AES

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
