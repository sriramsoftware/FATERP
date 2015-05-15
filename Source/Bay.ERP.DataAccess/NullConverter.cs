using System;
using System.Diagnostics;

namespace Bay.ERP.DataAccess
{
    public static class NullConverter
    {
        private const int Zero = 0;

        [DebuggerStepThrough()]
        public static object Convert(byte value)
        {
            if (value == Zero || value == byte.MinValue)
            {
                return DBNull.Value;
            }
            else
            {
                return value;
            }
        }

        [DebuggerStepThrough()]
        public static object Convert(short value)
        {
            if (value == Zero || value == short.MinValue)
            {
                return DBNull.Value;
            }
            else
            {
                return value;
            }
        }

        [DebuggerStepThrough()]
        public static object Convert(int value)
        {
            if (value == Zero || value == Int32.MinValue)
            {
                return DBNull.Value;
            }
            else
            {
                return value;
            }
        }

        [DebuggerStepThrough()]
        public static object Convert(float value)
        {
            if (value == Zero || value == float.MinValue)
            {
                return DBNull.Value;
            }
            else
            {
                return value;
            }
        }

        [DebuggerStepThrough()]
        public static object Convert(long value)
        {
            if (value == Zero || value == long.MinValue)
            {
                return DBNull.Value;
            }
            else
            {
                return value;
            }
        }

        [DebuggerStepThrough()]
        public static object Convert(double value)
        {
            if (value == Zero || value == double.MinValue)
            {
                return DBNull.Value;
            }
            else
            {
                return value;
            }
        }

        [DebuggerStepThrough()]
        public static object Convert(decimal value)
        {
            if (value == Zero || value == decimal.MinValue)
            {
                return DBNull.Value;
            }
            else
            {
                return value;
            }
        }

        [DebuggerStepThrough()]
        public static object Convert(DateTime value)
        {
            if ((value == DateTime.MinValue) || (value == DateTime.MaxValue))
            {
                return DBNull.Value;
            }
            else
            {
                return value;
            }
        }

        [DebuggerStepThrough()]
        public static object Convert(char value)
        {
            if (value.ToString(System.Globalization.CultureInfo.CurrentCulture).Length == 0)
            {
                return DBNull.Value;
            }
            else
            {
                return value;
            }
        }

        [DebuggerStepThrough()]
        public static object Convert(string value)
        {
            if (string.IsNullOrEmpty(value))
            {
                return DBNull.Value;
            }
            else
            {
                return value;
            }
        }

        [DebuggerStepThrough()]
        public static object Convert(Guid value)
        {
            if (value == Guid.Empty)
            {
                return DBNull.Value;
            }
            else
            {
                return value;
            }
        }
    }
}