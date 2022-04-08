using System;
using System.Text;
using System.Security.Cryptography;

namespace _3_Itransition
{
    class HMAC
    {
        static public string GenerateKey()
        {
            var key = new byte[64];
            var rnd = RandomNumberGenerator.Create();
            rnd.GetBytes(key);
            return BitConverter.ToString(key).Replace("-", "");
        }

        static public string GenerateHMAC(string key, string message)
        {
            var hmacsha256 = new HMACSHA256(Encoding.UTF8.GetBytes(key));
            var hash = hmacsha256.ComputeHash(Encoding.UTF8.GetBytes(message));
            return BitConverter.ToString(hash).Replace("-", "");
        }
    }
}
