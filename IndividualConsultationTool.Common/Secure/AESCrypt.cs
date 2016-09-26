using System.Security.Cryptography;
using System;
using System.IO;
using System.Text;

namespace IndividualConsultationTool.Common.Secure
{
    public class AESCrypt : ICrypt
    {
        private readonly SecurityOptions _securityOptions;

        public AESCrypt(SecurityOptions securityOptions)
        {
            _securityOptions = securityOptions;
        }


        public string Encrypt(string plainText)
        {
            byte[] plainTextBytes = Encoding.UTF8.GetBytes(plainText);
            byte[] saltBytes = Encoding.ASCII.GetBytes(_securityOptions.Salt);
            byte[] vectorBytes = Encoding.ASCII.GetBytes(_securityOptions.Vector);

            PasswordDeriveBytes password = new PasswordDeriveBytes(_securityOptions.Password, saltBytes, _securityOptions.HashAlghorithm, _securityOptions.Iterations);
            byte[] keyBytes = password.GetBytes(_securityOptions.KeySize/8);

            RijndaelManaged symmetricKey = new RijndaelManaged();
            symmetricKey.Mode = CipherMode.CBC;
            ICryptoTransform encryptor = symmetricKey.CreateEncryptor(keyBytes, vectorBytes);

            MemoryStream memoryStream = new MemoryStream();
            CryptoStream cryptoStream = new CryptoStream(memoryStream, encryptor, CryptoStreamMode.Write);
            cryptoStream.Write(plainTextBytes, 0, plainTextBytes.Length);
            cryptoStream.FlushFinalBlock();

            byte[] cipherTextBytes = memoryStream.ToArray();
            memoryStream.Close();
            cryptoStream.Close();

            string cipherText = Convert.ToBase64String(cipherTextBytes);
            return  cipherText;
        }

        public string Decrypt(string cipherText)
        {
            byte[] cipherTextBytes = Convert.FromBase64String(cipherText);
            byte[] saltBytes = Encoding.ASCII.GetBytes(_securityOptions.Salt);
            byte[] vectorBytes = Encoding.ASCII.GetBytes(_securityOptions.Vector);

            PasswordDeriveBytes password = new PasswordDeriveBytes(_securityOptions.Password, saltBytes, _securityOptions.HashAlghorithm, _securityOptions.Iterations);
            byte[] keyBytes = password.GetBytes(_securityOptions.KeySize / 8);

            RijndaelManaged symmetricKey = new RijndaelManaged();
            symmetricKey.Mode = CipherMode.CBC;
            ICryptoTransform decryptor = symmetricKey.CreateDecryptor(keyBytes, vectorBytes);

            MemoryStream memoryStream = new MemoryStream(cipherTextBytes);
            CryptoStream cryptoStream = new CryptoStream(memoryStream, decryptor, CryptoStreamMode.Read);
            byte[] plainTextBytes = new byte[cipherTextBytes.Length];
            int decryptedByteCount = cryptoStream.Read(plainTextBytes, 0, plainTextBytes.Length);

            memoryStream.Close();
            cryptoStream.Close();

            string plainText = Encoding.UTF8.GetString(plainTextBytes, 0, decryptedByteCount);
            return plainText;
        }
    }
}