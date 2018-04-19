using System.Security.Cryptography;

namespace IVGenerator.Encryption
{
    public static class RijndaelEncryptorHelper
    {
        public static CryptoKeys GenerateKeys()
        {
            using (var des = new RijndaelManaged())
            {
                des.GenerateKey();
                des.GenerateIV();

                var keys = new CryptoKeys();
                keys.Key = des.Key;
                keys.IV = des.IV;

                return keys;
            }
        }
    }
}
