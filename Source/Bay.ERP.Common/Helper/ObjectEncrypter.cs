using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Security.Cryptography;

namespace Bay.ERP.Common.Helper
{
    public static class ObjectEncrypter
    {
        #region Public Methods

        [DebuggerStepThrough()]
        public static byte[] Encrypt<Text>(Text plain) where Text : class
        {
            if (!plain.GetType().IsSerializable)
            {
                throw new SerializationException("Object is not serializable.");
            }

            using (MemoryStream ms = new MemoryStream())
            {
                using (SymmetricAlgorithm crypto = CreateSymmetricAlgorithm())
                {
                    using (CryptoStream cs = new CryptoStream(ms, crypto.CreateEncryptor(), CryptoStreamMode.Write))
                    {
                        (new BinaryFormatter()).Serialize(cs, plain);

                        cs.FlushFinalBlock();

                        using (KeyedHashAlgorithm hash = CreateHashAlgorithm())
                        {
                            hash.Key = crypto.Key;
                            ms.Seek(0, SeekOrigin.Begin);
                            hash.ComputeHash(ms);
                            ms.Write(hash.Hash, 0, hash.Hash.Length);
                        }
                    }
                }

                return ms.ToArray();
            }
        }

        [DebuggerStepThrough()]
        public static Text Decrypt<Text>(byte[] cipher) where Text : class
        {
            using (SymmetricAlgorithm crypto = CreateSymmetricAlgorithm())
            {
                using (KeyedHashAlgorithm hash = CreateHashAlgorithm())
                {
                    hash.Key = crypto.Key;

                    int hashSizeInBytes = (hash.HashSize / 8);

                    byte[] data = new byte[cipher.Length - hashSizeInBytes];

                    Buffer.BlockCopy(cipher, 0, data, 0, data.Length);

                    byte[] DAC = new byte[hashSizeInBytes];

                    Buffer.BlockCopy(cipher, data.Length, DAC, 0, DAC.Length);

                    hash.ComputeHash(data, 0, data.Length);

                    if (!CompareByteArray(hash.Hash, DAC))
                    {
                        throw new CryptographicException("Object hash does not match!");
                    }

                    using (MemoryStream ms = new MemoryStream())
                    {
                        using (CryptoStream cs = new CryptoStream(ms, crypto.CreateDecryptor(), CryptoStreamMode.Write))
                        {
                            cs.Write(data, 0, data.Length);
                            cs.FlushFinalBlock();
                            ms.Seek(0, SeekOrigin.Begin);

                            return (new BinaryFormatter()).Deserialize(ms) as Text;
                        }
                    }
                }
            }
        }

        [DebuggerStepThrough()]
        public static string OurEncrypt(string input)
        {
            string s1 = Convert.ToBase64String(System.Text.Encoding.Unicode.GetBytes(input));

            return s1;
        }

        [DebuggerStepThrough()]
        public static string OurDecrypt(string input)
        {
            string s2 = System.Text.Encoding.Unicode.GetString(Convert.FromBase64String(input));

            return s2;
        }

        #endregion

        #region Helper Methods

        [DebuggerStepThrough()]
        private static SymmetricAlgorithm CreateSymmetricAlgorithm()
        {
            SymmetricAlgorithm crypto = new RijndaelManaged();

            crypto.Mode = CipherMode.CBC;
            crypto.Padding = PaddingMode.PKCS7;

            crypto.Key = new byte[] { 4, 93, 171, 3, 85, 23, 41, 34, 216, 14, 78, 156, 78, 3, 103, 154, 9, 150, 65, 54, 226, 95, 68, 79, 159, 36, 246, 57, 177, 107, 116, 8 };
            crypto.IV = new byte[] { 56, 2, 86, 234, 139, 10, 67, 10, 223, 210, 0, 19, 87, 21, 142, 100 };

            return crypto;
        }

        [DebuggerStepThrough()]
        private static KeyedHashAlgorithm CreateHashAlgorithm()
        {
            return HMACSHA1.Create();
        }

        [DebuggerStepThrough()]
        private static bool CompareByteArray(byte[] array1, byte[] array2)
        {
            if (array1.Length != array2.Length)
            {
                return false;
            }

            for (int i = 0; i < array1.Length; i++)
            {
                if (array1[i] != array2[i])
                {
                    return false;
                }
            }

            return true;
        }

        #endregion

        public static System.Collections.IDictionary Decrypt1(object p)
        {
            throw new Exception("The method or operation is not implemented.");
        }
    }
}