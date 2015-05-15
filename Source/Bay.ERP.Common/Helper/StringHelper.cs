using System;
using System.Diagnostics;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.Common.Helper
{
    public static class StringHelper
    {
        private static System.Globalization.CultureInfo CurrentCulture
        {
            [DebuggerStepThrough()]
            get
            {
                return System.Globalization.CultureInfo.CurrentCulture;
            }
        }

        [DebuggerStepThrough()]
        public static string Convert(string value)
        {
            if ((value == null) || (value.Trim().Length == 0))
            {
                return string.Empty;
            }
            else
            {
                return value.Trim();
            }
        }

        [DebuggerStepThrough()]
        public static string Convert(byte value)
        {
            return value.ToString(CurrentCulture);
        }

        [DebuggerStepThrough()]
        public static string Convert(string format,
        byte value)
        {
            return value.ToString(format, CurrentCulture);
        }

        [DebuggerStepThrough()]
        public static string Convert(short value)
        {
            return value.ToString(CurrentCulture);
        }

        [DebuggerStepThrough()]
        public static string Convert(string format,
        short value)
        {
            return value.ToString(format, CurrentCulture);
        }

        [DebuggerStepThrough()]
        public static string Convert(int value)
        {
            return value.ToString(CurrentCulture);
        }

        [DebuggerStepThrough()]
        public static string Convert(string format,
        int value)
        {
            return value.ToString(format, CurrentCulture);
        }

        [DebuggerStepThrough()]
        public static string Convert(long value)
        {
            return value.ToString(CurrentCulture);
        }

        [DebuggerStepThrough()]
        public static string Convert(string format,
        long value)
        {
            return value.ToString(format, CurrentCulture);
        }

        [DebuggerStepThrough()]
        public static string Convert(float value)
        {
            return value.ToString(CurrentCulture);
        }

        [DebuggerStepThrough()]
        public static string Convert(string format,
        float value)
        {
            return value.ToString(format, CurrentCulture);
        }

        [DebuggerStepThrough()]
        public static string Convert(double value)
        {
            return value.ToString(CurrentCulture);
        }

        [DebuggerStepThrough()]
        public static string Convert(string format,
        double value)
        {
            return value.ToString(format, CurrentCulture);
        }

        [DebuggerStepThrough()]
        public static string Convert(string format,
        decimal value)
        {
            return value.ToString(format, CurrentCulture);
        }

        [DebuggerStepThrough()]
        public static string Convert(decimal value)
        {
            return value.ToString(CurrentCulture);
        }

        [DebuggerStepThrough()]
        public static string Convert(DateTime value)
        {
            return value.ToString(CurrentCulture);
        }

        [DebuggerStepThrough()]
        public static string Convert(string format,
        DateTime value)
        {
            return value.ToString(format, CurrentCulture);
        }

        [DebuggerStepThrough()]
        public static string Convert(object value)
        {
            if ((value == null) || (value == DBNull.Value))
            {
                return string.Empty;
            }
            else
            {
                return value.ToString().Trim();
            }
        }

        [DebuggerStepThrough()]
        public static string Format(string format, params object[] arg)
        {
            return string.Format(CurrentCulture, format, arg);
        }

        [DebuggerStepThrough()]
        public static string[] ToArray(System.Collections.Specialized.StringCollection collection)
        {
            if ((collection == null) || (collection.Count == 0))
            {
                return null;
            }

            string[] values = new string[collection.Count];

            collection.CopyTo(values, 0);

            return values;
        }

        [DebuggerStepThrough()]
        public static string ToLower(string value)
        {
            if (IsBlank(value))
            {
                return string.Empty;
            }
            else
            {
                return value.Trim().ToLower(CurrentCulture);
            }
        }

        [DebuggerStepThrough()]
        public static string ToUpper(string value)
        {
            if (IsBlank(value))
            {
                return string.Empty;
            }
            else
            {
                return value.Trim().ToUpper(CurrentCulture);
            }
        }

        [DebuggerStepThrough()]
        public static bool IsBlank(string value)
        {
            //return ((value == null) || (value.Trim().Length == 0));
            return string.IsNullOrEmpty(value);
        }

        [DebuggerStepThrough()]
        public static bool IsBlank(StringBuilder value)
        {
            //return ((value == null) || (value.Trim().Length == 0));
            return string.IsNullOrEmpty(value.ToString());
        }

        [DebuggerStepThrough()]
        public static bool IsEqual(string leftHandSide,
        string rightHandSide,
        bool ignoreCase)
        {
            return (Compare(leftHandSide, rightHandSide, ignoreCase) == 0);
        }

        [DebuggerStepThrough()]
        public static bool IsEqual(string leftHandSide,
        string rightHandSide)
        {
            return IsEqual(leftHandSide, rightHandSide, true);
        }

        [DebuggerStepThrough()]
        public static int Compare(string leftHandSide,
        string rightHandSide,
        bool ignoreCase)
        {
            return string.Compare(leftHandSide, rightHandSide, ignoreCase, CurrentCulture);
        }

        [DebuggerStepThrough()]
        public static int Compare(string leftHandSide,
        string rightHandSide)
        {
            return Compare(leftHandSide, rightHandSide, true);
        }

        [DebuggerStepThrough()]
        public static string Hash(string plain)
        {
            if (IsBlank(plain)) return string.Empty;

            using (KeyedHashAlgorithm csp = HMACSHA1.Create())
            {
                csp.Key = Key;
                byte[] data = System.Text.Encoding.Default.GetBytes(plain);
                byte[] hash = csp.ComputeHash(data);

                return System.Convert.ToBase64String(hash);
            }
        }

        [DebuggerStepThrough()]
        public static string Encrypt(string plain)
        {
            if (IsBlank(plain)) return string.Empty;

            using (SymmetricAlgorithm crypto = CreateAlgorithm())
            {
                return System.Convert.ToBase64String(Read(crypto.CreateEncryptor(), Encoding.Default.GetBytes(plain)));
            }
        }

        [DebuggerStepThrough()]
        public static string Decrypt(string cipher)
        {
            if (IsBlank(cipher)) return string.Empty;

            using (SymmetricAlgorithm crypto = CreateAlgorithm())
            {
                return Encoding.Default.GetString(Read(crypto.CreateDecryptor(), System.Convert.FromBase64String(cipher)));
            }
        }

        [DebuggerStepThrough()]
        private static SymmetricAlgorithm CreateAlgorithm()
        {
            SymmetricAlgorithm crypto = new RijndaelManaged();

            crypto.Key = Key;
            crypto.IV = new byte[crypto.IV.Length];

            return crypto;
        }

        [DebuggerStepThrough()]
        private static byte[] Read(ICryptoTransform transformer,
        byte[] data)
        {
            using (MemoryStream memoryStream = new MemoryStream())
            {
                using (CryptoStream cryptoStream = new CryptoStream(memoryStream, transformer, CryptoStreamMode.Write))
                {
                    cryptoStream.Write(data, 0, data.Length);
                    cryptoStream.FlushFinalBlock();

                    return memoryStream.ToArray();
                }
            }
        }

        [DebuggerStepThrough()]
        private static string ReplaceUnWantedCharacter(string input)
        {
            //input = input.Replace('(', ',');
            //input = input.Replace(')', ',');
            //input = input.Replace(", ", ",");
            //input = input.Replace(" ,", ",");
            //input = input.Replace(' ', ',');
            input = input.Replace("++", "--");
            input = input.Replace('+', ',');
            input = input.Replace("--", "++");
            input = input.Replace('&', ',');
            input = input.Replace('[', ',');
            input = input.Replace(']', ',');

            return input;
        }

        [DebuggerStepThrough()]
        public static string[] BuildKeyWordArray(string searchString)
        {
            string correctedString = ReplaceUnWantedCharacter(searchString);
            string[] keyWordArray = correctedString.Split(',');
            return keyWordArray;
        }

        [DebuggerStepThrough()]
        public static bool IsNullOrEmpty(this StringBuilder value)
        {
            if (string.IsNullOrEmpty(value.ToString()))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private static readonly byte[] Key = new byte[] { 4, 93, 171, 3, 85, 23, 41, 34, 216, 14, 78, 156, 78, 3, 103, 154, 9, 150, 65, 54, 226, 95, 68, 79, 159, 36, 246, 57, 177, 107, 116, 8 };

        public static bool IsStringMatch(string StringToSearch, string StringInSearch)
        {
            StringToSearch = RemoveWhiteSpaces(StringToSearch);
            StringToSearch = StringToSearch.ToLower();
            StringInSearch = RemoveWhiteSpaces(StringInSearch);
            StringInSearch = StringInSearch.ToLower();
            if (StringToSearch.Length > StringInSearch.Length)
            {
                string strTemp = StringToSearch;
                StringToSearch = StringInSearch;
                StringInSearch = strTemp;
            }
            int prevIndex = -1;
            int count = 1;
            int lastCount = 0;
            for (int i = 0; i < StringToSearch.Length; i++)
            {
                char chr = StringToSearch[i];
                int index = StringInSearch.IndexOf(chr, i);
                if (index > -1 && prevIndex == -1)
                {
                    prevIndex = index;
                    count++;
                }
                else
                {
                    if (prevIndex + 1 == index)
                    {
                        prevIndex = index;
                        count++;
                        //lastCount = count;
                    }
                    else
                    {
                        prevIndex = -1;
                        count = 0;
                    }
                }
                if (count > lastCount)
                {
                    lastCount = count;
                }
            }

            //2/3 of job title
            int length = StringToSearch.Length / 3;
            if (lastCount > length)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static string RemoveWhiteSpaces(string strSource)
        {
            Regex r = new Regex(@"\s");
            string strDestination = r.Replace(strSource, "");
            return strDestination;
        }

        public static string Concate(char separator, params string[] values)
        {
            string concatedValue = string.Empty;
            foreach (string value in values)
            {
                if (value.IsNotNullOrEmpty())
                {
                    if (concatedValue.IsNullOrEmpty())
                    {
                        concatedValue = value;
                    }
                    else
                    {
                        concatedValue = concatedValue + separator + value;
                    }
                }
            }
            return concatedValue;
        }

        public static string[] Separate(char separator, string value)
        {
            return value.Split(new char[] { separator });
        }

        public static string Concate(string p, string instituteName, string p_3, string countryName)
        {
            throw new NotImplementedException();
        }
    }
}