using System.Security.Cryptography;
using System.Text;

namespace SMS.Helpers
{
    public sealed class SecurityHelper
    {
        public static string CalculateMD5Hash(string input)
        {
            MD5 md5 = MD5.Create();

            byte[] inputBytes = Encoding.UTF8.GetBytes(input);
            byte[] hash = md5.ComputeHash(inputBytes);

            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < hash.Length; i++)
                sb.Append(hash[i].ToString("x2"));

            return sb.ToString();
        }
    }
}
