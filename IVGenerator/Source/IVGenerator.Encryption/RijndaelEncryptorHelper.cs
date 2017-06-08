using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace IVGenerator.Encryption
{
    public static class RijndaelEncryptorHelper
    {
        public static byte[] GenerateVector()
        {
            using (var des = new RijndaelManaged())
            {
                des.GenerateIV();

                return des.IV;
            }
        }
    }
}
