using System;
using System.Security.Cryptography;
using System.Text;

namespace MassMailer
{
    static internal class Encryption
    {
        public static string Encrypt(string plainText, bool YandexFix = false)
        {
            byte[] plainBytes = Encoding.Unicode.GetBytes(plainText);
            byte[] encryptedBytes = ProtectedData.Protect(plainBytes, YandexFix ? new byte[] { 44, 111, 48, 138, 3, 53, 29, 173 } : new byte[] { 232, 82, 10, 190, 206, 77, 15, 224 }, DataProtectionScope.CurrentUser);
            return Convert.ToBase64String(encryptedBytes);
        }

        public static string Decrypt(string encryptedText, bool YandexFix = false)
        {
            byte[] encryptedBytes = Convert.FromBase64String(encryptedText);
            byte[] decryptedBytes = ProtectedData.Unprotect(encryptedBytes, YandexFix ? new byte[] { 44, 111, 48, 138, 3, 53, 29, 173 } : new byte[] { 232, 82, 10, 190, 206, 77, 15, 224 }, DataProtectionScope.CurrentUser);
            return Encoding.Unicode.GetString(decryptedBytes);
        }
    }
}
