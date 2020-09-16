using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace crypt_demo.Properties
{
    public class BaseTest
    {
        protected static Random random = new Random();

        // Go

        // AES Encrypted Values:
        public static string GO_AES_CFB_128 = "nrXew/t/9K2jYdHLgUAgbeUpwi51YJq8Q6vvgTG9qbc=";
        public static string GO_AES_CFB_192 = "ySdP1HptCAQdlhm2MkAB7zS4KXicsyIUbVMFJf9lQCQ=";
        public static string GO_AES_CFB_256 = "akFwTa9vEw/hZ63r9kI3uhFg4IB56m6tbzkF6Ti3l3w=";
        public static string GO_AES_CBC_128 = "SHVkBLAxV0FRbiNJiqW6bV2aq+a+qbGofh0kwYmXlyryU4721aTV9OLWZafZ3QAt";
        public static string GO_AES_CBC_192 = "Cl01q9P117P0VRb5H/3ks6zXdAEKdjPLughXuvI3WKmsjxtAVPwEXwJEbpf4OUpY";
        public static string GO_AES_CBC_256 = "FSDf7qutHZqfsGK2V2da7YRS2syEua6FUA8JC9Dzz0F6iXs8j0wZJw3p/Xeg4ngD";

        // RSA Encrypted Values:
        public static string GO_RSA_OAEP = "iJ9w5XZXU6sMfCwCkLcjmuXTem7Jnul9qv80q1OrHAivHhhPcHpHQBWq0BHyvLT/k1XmmVUNaMLRQaaf357yjVi2Zu4QNVRr867Nm5ATZnA5Gczk6GAAwIeCf0BX1y93C15oVHQVRiCiBY+6W4q4s5ogUoKj8CkOqmWm48+Whe+heXsQo4t9Dgrf+FpaZYRi/oleo8oq7g4X4lyQrfABMwdAkESgJAt1TqqWMuE3GC7aQbklgiPQSs74V3hcd6AYqxI2G9a2KzDCf3wXw/YBj8Yp4Wt2yY+MvBn8XZrX++F0DkUKz5pVPXVmkGulGuFLW/kfzcbxjx69Vrq5SPTO4g==";
        public static string GO_RSA_PKCS1V1_5 = "T7PggYIASKJSFw2eC2GCfh537wGl41qUbenK+3HPjams3z6acCVslj4loUJ2Hk8F44kQ1j8EnfbQMrU0AL4RlX1HJQOEBpKFeeIZxiN07nsN9s3yQvRiTelZt9jybikji5hhHx+72ZHkmrpXdhighRTVY1Fjxvd7FJHZ4pTRDsH+hxsaONI5kq53Im4HNTKiSx3vb4Kmaxnh1A4lmmjBAXA6XPMaEw/+MtQ/NC+LSFeWzmEO5XeFh4mMMmelDh1a8N1zZYYuYJJ7FBNmpFR4qxA3ZwUSpVTbjW0wj2xqldh9YbqXfBbExIPSEn9JIbI9bq+fiUJvdcT2dquu/qLmJQ==";

        // X509 Encrypted Values:
        public static string GO_X509_OAEP = "N1lPw1P/P1EcyDevGAw23qPC3/emJHWyghwYJ5iQ4gLjmVQxikf78hm9aOd+24ow7uvqASMD/MhykLXyMJGbDmP9LqyVc8gMuS1hPAuMEjVZR/mHuiWRyzMfVFnvSNdUjg7+h2BM0esMGxnv6R5bGkZqTinLAvImx8VYi04Rz6olCYLg9WceVRJJMzDKxDiDrNNylVaesAGQDJQ+Fu0VhX8biToZipEKALVx2Yv9nw0fgVaMgljbT22Rl8RUcUroCenpS3f/P0u0xNansQ41Ky8j5zqd2E4uxndi2OB2ZtRpX+NyDFWs3toZHeMacZJDDbKPBz4dw32iLg5Y4Up0nQ==";
        public static string GO_X509_PKCS1V1_5 = "Kh7crNBL4VRBuIvSRS/3009mmAYofBIuyhgNJX2t168pn8mbY+a3YJ6BAulLj4gMZKPhWCnTg4QMYbHAQNba4MyZ7PINWxTAESvXDwfTgw9jwbq1paadRsTYVUKCO5IkvEvNggd0mtNlVtup+CUEMvYWMEbwCq9a6/AHzIbOQ/vvwnUTpv6yEXKgDzeNl9vXv//4uplJuh+wawyOscT/BhUcGncDBcWzhz7MMPuF6K1fffvm6NZT5OACU7Vmy0r0pG9PU1ZwyJFDvC7AhdGu4HwjFnwYGjwbrpeTh2BZF2WssyxqFwb3wSg4xHefv44oLoNTonxd70gY7HE6BmIkFA==";

        // Js

        // AES Encrypted Values:
        public static string JS_AES_CFB_128 = "G7YnYFgfz3tUhY6TupW4woRYlsFE61XJJkiKbmE47PY=";
        public static string JS_AES_CFB_192 = "C1xXJpRJSgkLnv7/XhSI3DypM3Gml5aP4PLKL9Xwf1E=";
        public static string JS_AES_CFB_256 = "mOsMPfOpFELVsuqfXChlQe5b9690I8/WqGNUF7yoUDs=";
        public static string JS_AES_CFB8_128 = "K6kEjr2MARJNae08G1XIP+zLUsaqM0WtEplYferSGok=";
        public static string JS_AES_CFB8_192 = "rc4jZhmVvSaTlqMpPLcTNY3FeNscejyMrV7dhs8+kLA=";
        public static string JS_AES_CFB8_256 = "4Hyim7as94E8nxl56qUC7Wx8BkHgSR+2xsQ5x/eboQE=";
        public static string JS_AES_CBC_128 = "FGDijMbXk9evDR7AFk8UokmT/NPbE/fZx02BiBxrpEvntvf+dxJmIIf7FKCds8xs";
        public static string JS_AES_CBC_192 = "IMs1sgTHMn3G54t9f236Dj+/AysI2XZroFMosQPp5vUpAgzvoj3WNXXPyy9z0oaY";
        public static string JS_AES_CBC_256 = "s/siCHlv4YHQE8q5iBuWiDTLkeUmPUVO793+6UvZBG7An/7WaYYosTME4gQQ4/xV";

        // RSA Encrypted Values:
        public static string JS_RSA_PKCS1V1_5 = "fjI9f0QMM8b+TxjeAx+HY8DqTjo/vTUw4wYXmKJyZgweg/HHCSU/eWlapgq4VFhPCCFoJLgAiS36KGp+fqPqqO9BeMX3jCJ4XcckCg/aYSRs35j8Wtyaj1xN8dvVlVkz0DKvGhsE1JjP3My8BbLIHbDfdMs8lH1ZkqvDtUAnDf0XPlFXbnMc5/D78nUVYKFkUt8eArh/qO8pMRRXrkiUN0UYvHHPzPO+WyoQfzQvzlahx2M3LpczUD1akzbBJZPox6yWLtht/S43PA3rofdrX9qaQi19jHlwS2UpFCRkka4q8ULi79/gAB9TVwm5ZcokQMzyQ9FOAoTOYr2yWROrlA==";
        public static string JS_RSA_OAEP = "KFqFAKmc5gksTnycRwWKU+3elRnGgrXaTCFoaF36Logo8leHjJWjrP6l5+BQx1XOr6u84bzZUa1pYwIgRrtZrW3VtDQzm4zROvg+nzNgmyCF0tHJdVGmm1b7vUm6ZWdUrd+CbEqMapf0pOsnxVxM+vq9WaBa+U98Ng7sYKYp56tIOQSaFLqaVfVY4qAEIINPl2uBAfJH5wr8cAfKeWzR3UxMKPKC6QRoUMMb59qHT4/RPh51D0q8AGI6by4JoFW2UaKROmWSJWOEGsBSDD17DHZgjX1aIrO7X1fE0o8eJg0G7WV8um/aSXO86L0Gac37CbJspsKAxfwWpYcxMYZF9g==";

        // X509 Encrypted Values:
        public static string JS_X509_PKCS1V1_5 = "HSvT3MD9NKJebcp8pQRohMiBAx+N/JyN7IP1VSmhNt11A/uTppUzVs/xq6+dQGJfiJ9ff/559j2AfvtFMH1k4QN6pSUF+VWjierluGhezE6Fg9K2uM1cutMKFqVCI8J59j1M2pNqSLXaE3rJs46iQhe0AOaNvafj6q4NrMspvwpqYiDg02XJGF/+72Y8OzQZNtuNzRNfY+yvnWXwp8MXq/C0TgwJA3wa+1yW1nLdyu155QOySOSXUUWbC99D0n60lno3ZK5MZLRz8shpOg3+QoUGVwpkE1oXQrNodic0n/EtaL59WvbfzaxOxD7FFfjrn+KFBUnohlR93UjNY5pdGA==";
        public static string JS_X509_OAEP = "LMVMGVEm2ORZ1S3k3giqAf7Eayc4SR/H+oVngB+OCv0xfag08NHJMBhjxy5g3vvnERRj36OOCA07PlJMaNMPCiySIlUXGityCnWe7PTcPRJlZdA13i91rGNZr1mVuQe8CAG0OwXlxdNGD2ZXcjQLLRh77tHntj1/To55KAcOb22eqowXL4WwXhupfGqr1EDT9rcmMI4RgA3cCGqYTOpiLS2xeBRF2jwR/g7XLG5Gc38woQMkznkrmHzLYQmU7gIAuPpHRke6eYOK+oxmwt+ePgiqNZweyTBkf5VayGAIHnO5XFlFi76yrUqxcqRdJdhXBixiVNXhHCSuBBPGx+L9YQ==";
        
        // Py

        // AES Encrypted Values:
        public static string PY_AES_CFB8_128 = "snEone8EWWld/wPzCtrZsKgu/EP13eEupSNXq5oIzDM=";
        public static string PY_AES_CFB8_192 = "j7LdWe60cjcEWF1xmogth9X/oYhGneqvIUUnHllGeAM=";
        public static string PY_AES_CFB8_256 = "IMk9BlzyPwG31lbd4IurkLUk7xrvokYeSY8UabqUpy4=";
        public static string PY_AES_CBC_128 = "P54h5CUfim8Dqhs7Y9GJCmciqAs5ucKFDY2nqdPZAEHP0XlU+A1SjsDvuXznnUq2";
        public static string PY_AES_CBC_192 = "Us1h/OylOGdvHxg5K5hF7U5+M9IHSOWZCqAegaQp+Lm91S+J73urlE23DZtTCiyf";
        public static string PY_AES_CBC_256 = "Wyihy9Sv/AiLUChhRO4bxptha1fML71JxIzJx4v7T7UUOYaRqCsk+m2SZnlvIKLz";

        // RSA Encrypted Values:
        public static string PY_RSA_PKCS1V1_5 = "eEcx1BwBZKKFIHysk/2WsV2xcQSAmHM3FpMr7nlxYtHEKWn+Hhq4R2GQG8kEwcXx1XhMb+IBJ4TvhNDKODBg5r8x8s0oVBnyk2fcIyks0vufroHq9W12gLjY00cXjyWsrIYjxzphYaMXBusD24JF8y2YRvPSGZs9i72OP5fFiy7ZxEac76GcKPu4QOVSCsvI9HH/v+tF+fBnVPLWAAqA81nA7rGKAR5BfHT/0cH1d5IK19kyw2iMBR86TIBaQZ0PBcsKUObaAnwnidKnkTPYr2eSg6PC/lurcse3Sz8c6ADwW7iHpG0rlyqrNyEqxHM5+QjSzPI8zwqdWGHic31sjw==";
        public static string PY_RSA_OAEP = "SetLwJ2g/19Wr5BKgGjGfFqlRwz5QyjLDl3ajB3zz2yGFDSAi+EyQxtVuCS8z3HQVkmXCrOKZgB7JbWbQFNMGFE6OaWud9wCLbpCt0Wsmkeo70CPOZNtuc3E/gwo81+Lz4biodzptcc09lxbOEQFwtiItitrTO33R4lvq0gVHkOuVlY7bzK17zFiWdqO/h6lYF4b96w1qHfBr3UNaGMK2Xeo2iRfLjYTHAENOljIEdGFNdzUtkQ+e1dTz5JcvVqOrhTWkMbLC6j+PrQV/cM40i5me4KfKtKIgVgrykkRAITaYaSuRTCc/tKZmaNgYeHs2zUvl76Yxi0/X8fg7mficg==";

        // X509 Encrypted Values:
        public static string PY_X509_PKCS1V1_5 = "Hkf+vT0iwVwmx5M7BqDnkiK5jp5dH26r0c9zvUS1s5EG3AJ/3IgJsaZcbEeS/Q+eK+HvVMiLioUjNJhir7krDcEnyJOX8cb12lIcXjkmIZKyD9Xin6aMRNJbB9ou6FdE97gDJa01ndTY1JJ+Gf9ZTg/hFnD5gIc3t/Hr3PaormFtlpWxqtOF9dOuKs6JvmcUew6B98Efg231FfncyiwWUtgWSUXkf0NJOcGz4DIPqR90TEtkOQyB6D6rlV1HIytTJdGgr1kZBZu8wgBad+yz4xyTZJ3CzO3v8Ro79F/6aZ7QWHVOOCyckssDth+t2gSsrx617EhrFvCr+ybhnEIFFA==";
        public static string PY_X509_OAEP = "GK4I4HqE7Y8fH1DOiXlyrVWeDb/uBJJda3a2t6AXwgTFCWk+8OQlJ87XQ2n9JBX7nV2n/h+WP7pcjc0LdqWuLkFDEBcjxwRMIrWH/SF1a2RJGLVnqdmv+RNbRjcMMk586f9cwiZ7zVhsLuCp53n5So30CxjiQ02aDXW4Y+nKQ+RbUK9O5Nz496fHXFuDu/lNQ2dcWo38hcVGRmQ7VPv5oJyPA8hQHHz+H33Hf0rFWqDnBRL5Up63ZobXhZdPr4Drdtfc2Aun/hs6mA990c0r6126/scSNi8eersaJrEKezmJ7qpGTqmKFrYjgwQALvaejnqOLS8Og/MTzh1W7vP8IA==";

        // AES

        public static string[] data = GenerateData();

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
