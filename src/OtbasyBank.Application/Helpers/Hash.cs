using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XSystem.Security.Cryptography;

namespace OtbasyBank.Application.Helpers
{
    public class Hash
    {
        public static string CreateSha1Hash(byte[] data)
        {
            StringBuilder sb = new StringBuilder(); ;
            SHA1 sha = new SHA1Managed();
            var hash = sha.ComputeHash(data);
            sb = new StringBuilder(hash.Length * 2);

            foreach (byte b in hash)
            {
                sb.Append(b.ToString("X2"));
            }

            return sb.ToString();
        }
    }
}
