using Interface;
using System.Security.Cryptography;
using System.Text;

namespace Framework
{
    public class EncryptionTool : IEncryptionTool
    {
        //Advanced Encryption Standard (AES) algorithm.
        private readonly AesCryptoServiceProvider _aesProvider;

        public EncryptionTool()
        {
            // Initialize the AesCryptoServiceProvider with a unique key and IV
            _aesProvider = new AesCryptoServiceProvider();

            _aesProvider.GenerateKey();
            _aesProvider.GenerateIV();

            /* Eigene Key und Vector
            _aesProvider.Key = Convert.FromBase64String("");
            _aesProvider.IV = Convert.FromBase64String("");
            */
        }

        public string Encrypt(string plainText)
        {
            // Encrypt the plain text using the AesCryptoServiceProvider
            byte[] plainTextBytes = Encoding.UTF8.GetBytes(plainText);
            byte[] cipherTextBytes = _aesProvider.CreateEncryptor().TransformFinalBlock(plainTextBytes, 0, plainTextBytes.Length);
            return Convert.ToBase64String(cipherTextBytes);
        }

        public string Decrypt(string cipherText)
        {
            // Decrypt the cipher text using the AesCryptoServiceProvider
            byte[] cipherTextBytes = Convert.FromBase64String(cipherText);
            byte[] plainTextBytes = _aesProvider.CreateDecryptor().TransformFinalBlock(cipherTextBytes, 0, cipherTextBytes.Length);
            return Encoding.UTF8.GetString(plainTextBytes);
        }


    }
}
