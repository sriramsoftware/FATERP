using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.UI.WebControls;

namespace Bay.ERP.Common.BusinessEntities
{
    public static class DataTimeExtension
    {
        public static string Ago(this DateTime target)
        {
            StringBuilder result = new StringBuilder();
            TimeSpan diff = (DateTime.Now - target.ToLocalTime());

            if (diff.Days > 0)
            {
                result.AppendFormat("{0} days", diff.Days);
            }

            if (diff.Hours > 0)
            {
                if (result.Length > 0)
                {
                    result.Append(", ");
                }

                result.AppendFormat("{0} hours", diff.Hours);
            }

            if (diff.Minutes > 0)
            {
                if (result.Length > 0)
                {
                    result.Append(", ");
                }

                result.AppendFormat("{0} minutes", diff.Minutes);
            }

            if (result.Length == 0)
            {
                result.Append("few moments");
            }

            return result.ToString();
        }

        public static string ToValidShortDateString(this DateTime value)
        {
            if (IsValidDate(value))
            {
                return value.ToShortDateString();
            }
            else
            {
                return string.Empty;
            }
        }

        public static string ToValidDateString(this DateTime value)
        {
            if (IsValidDate(value))
            {
                return value.ToString();
            }
            else
            {
                return string.Empty;
            }
        }

        public static bool IsValidDate(this DateTime value)
        {
            if ((value == DateTime.MinValue) || (value == DateTime.MaxValue) || (value <= DateTime.Parse("01/01/1754")))
            {
                return false;
            }

            return true;
        }

        public static String ToString(this DateTime? value, String format)
        {
            if (value == null)
            {
                return String.Empty;
            }
            else
            {
                return value.Value.ToString(format);
            }
        }

        public static String ToStringDefault(this DateTime? value)
        {
            if (value == null)
            {
                return String.Empty;
            }
            else
            {
                return value.Value.ToString(Bay.ERP.Common.Shared.CommonConstants.DefaultDateFormat);
            }
        }

        public static String ToStringDefault(this DateTime value)
        {
            if (value == null)
            {
                return String.Empty;
            }
            else
            {
                return value.ToString(Bay.ERP.Common.Shared.CommonConstants.DefaultDateFormat);
            }
        }

    }

    public static class StringExtension
    {
        public static string Concate(this string value, char separator, string valueToAdd)
        {
            if (valueToAdd.IsNotNullOrEmpty())
            {
                if (value.IsNullOrEmpty())
                {
                    value = valueToAdd;
                }
                else
                {
                    value = value + separator + valueToAdd;
                }
            }
            return value;
        }

        public static bool ContainsIgnoreCase(this string left, string right)
        {
            var pattern = new Regex(right, RegexOptions.IgnoreCase);
            return pattern.IsMatch(left);
        }

        public static bool IsNotNullOrEmpty(this string input)
        {
            return !String.IsNullOrEmpty(input);
        }

        public static bool IsNotNullOrEmpty(this string input, bool eliminateHtml)
        {
            string output = input;
            if (eliminateHtml)
            {
                output = Regex.Replace(output, @"<(.|\n)*?>", string.Empty);
                output = output.Replace("&nbsp;", string.Empty);
            }
            return IsNotNullOrEmpty(output.Trim());
        }

        public static bool IsNullOrEmpty(this string input)
        {
            return String.IsNullOrEmpty(input);
        }

        public static string Fill(this string format, params object[] args)
        {
            return String.Format(format, args);
        }

        public static string RemoveWhiteSpaces(this string input)
        {
            Regex r = new Regex(@"\s");
            return r.Replace(input, "");
        }

        public static string CssMinify(this string input)
        {
            // add minify logic here
            return input;
        }

        public static bool EqualsIgnoreCase(this string left, string right)
        {
            return String.Compare(left, right, true) == 0;
        }

        public static int ToInteger(this string value)
        {
            try
            {
                return Int32.Parse(value);
            }
            catch
            {
                return Int32.MinValue;
            }
        }

        public static int ToInteger(this string value, bool isEmptyToZero)
        {
            if (isEmptyToZero && value.IsNullOrEmpty())
            {
                value = "0";
            }
            try
            {
                return Int32.Parse(value);
            }
            catch
            {
                return Int32.MinValue;
            }
        }

        public static bool ToBoolean(this string value)
        {
            try
            {
                return Boolean.Parse(value);
            }
            catch
            {
                return false;
            }
        }

        public static decimal ToDecimal(this string value)
        {
            try
            {
                if (value.IsNotNullOrEmpty())
                {
                    return Decimal.Parse(value);
                }
                else
                {
                    return 0;
                }
            }
            catch
            {
                return decimal.MinValue;
            }
        }

        public static DateTime ToDateTime(this string value)
        {
            try
            {
                if (value.IsNotNullOrEmpty())
                {
                    return DateTime.Parse(value);
                }
                else
                {
                    return DateTime.MinValue;
                }
            }
            catch
            {
                return DateTime.MinValue;
            }
        }

        public static string InitCap(this string value)
        {
            if (value.IsNotNullOrEmpty())
            {
                value = value.ToLower();
                Char firstCharacter = value.GetFirstChar();
                if (value.Length > 0)
                {
                    string otherCharacters = value.Substring(1);
                    value = firstCharacter.ToString().ToUpper() + otherCharacters;
                }
                else
                {
                    value = firstCharacter.ToString().ToUpper();
                }

            }
            return value;
        }

        public static char GetFirstChar(this string value)
        {
            if (value.IsNotNullOrEmpty())
            {
                Char[] firstCharacter = value.Substring(0, 1).ToCharArray();
                return firstCharacter[0];
            }
            return ' ';
        }

        public static string ToString(this string value, bool IgnoreZeroValue)
        {
            if (IgnoreZeroValue)
            {
                if (value.Trim() == "0")
                {
                    return string.Empty;
                }
                else
                {
                    return value.Trim();
                }
            }
            else
            {
                return value.Trim();
            }
        }

    }

    public static class StringArrayExtension
    {
        public static bool Contains(this string[] values, string value)
        {
            foreach (string currentValue in values)
            {
                if (currentValue == value)
                    return true;
            }
            return false;
        }
    }

    public static class DecimalExtension
    {
        public static bool IsZero(this decimal value)
        {
            if (value == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static string ToString(this decimal value, bool IgnoreZeroValue)
        {
            if (IgnoreZeroValue)
            {
                if (value.IsZero())
                {
                    return string.Empty;
                }
                else
                {
                    return value.ToString();
                }
            }
            else
            {
                return value.ToString();
            }
        }
    }

    public static class IntegerExtension
    {
        public static string ToString(this int value, bool isZeroToEmpty)
        {
            if (isZeroToEmpty)
            {
                if (value == 0)
                {
                    return string.Empty;
                }
                else
                {
                    return value.ToString();
                }
            }
            else
            {
                return value.ToString();
            }
        }
    }
    public static class FileUploadExtension
    {
        public static bool IsValidSize(this FileUpload value)
        {
            //less than 10MB
            if (value.PostedFile.ContentLength / 1048576 <= 10)
            {
                return true;
            }
            return false;
        }

        public static bool IsValidSize(this HttpPostedFile value)
        {
            //less than 10MB
            if (value.ContentLength / 1048576 <= 10)
            {
                return true;
            }
            return false;
        }
    }
}