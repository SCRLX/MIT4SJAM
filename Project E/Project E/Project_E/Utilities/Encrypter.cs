using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using PCLCrypto;

namespace Project_E.Utilities
{
    public class Encrypter
    {
        

        public static int lenghtInBytes = 16;

        public static string password = "zuyd";

        public static byte[] CreateSalt(int _lengthInBytes)
        {
            return WinRTCrypto.CryptographicBuffer.GenerateRandom(_lengthInBytes);
        }

        public static byte[] CreateDerivedKey(string password, byte[] salt, int keyLengthInBytes = 32, int iterations = 1000)
        {
            byte[] key = NetFxCrypto.DeriveBytes.GetBytes(password, salt, iterations, keyLengthInBytes);
            return key;
        }


        public byte[] Enqrypt(string decrypted)
        {
            var salt = CreateSalt(lenghtInBytes);
            byte[] key = CreateDerivedKey(password, salt);

            ISymmetricKeyAlgorithmProvider aes = WinRTCrypto.SymmetricKeyAlgorithmProvider.OpenAlgorithm(SymmetricAlgorithm.AesCbcPkcs7);
            ICryptographicKey symetricKey = aes.CreateSymmetricKey(key);
            var bytes = WinRTCrypto.CryptographicEngine.Encrypt(symetricKey, Encoding.UTF8.GetBytes(decrypted));
            return bytes;
        }
    }
}
