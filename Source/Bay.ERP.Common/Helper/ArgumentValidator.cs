using System;
using System.Globalization;
using System.Diagnostics;


namespace Bay.ERP.Common.Helper
{
    public static class ArgumentValidator
	{

		[DebuggerStepThrough()]
		public static bool IsPositiveNumeric(int variable)
		{
			return (variable > 0);
		}


		[DebuggerStepThrough()]
		public static bool IsPositiveNumeric(decimal variable)
		{
			return (variable > 0);
		}


		[DebuggerStepThrough()]
		public static bool IsValidDate(DateTime value)
		{
			return ((value != DateTime.MinValue) && (value != DateTime.MaxValue));
		}


		[DebuggerStepThrough()]
		public static bool IsEmptyString(string value)
		{
			return ((value == null) || (value.Trim().Length == 0));
		}


		[DebuggerStepThrough()]
		public static void CheckForEmptyString(string variable,
		string variableName)
		{
			CheckForNullReference(variableName, "variableName");
			CheckForNullReference(variable, variableName);

			if (IsEmptyString(variable))
			{
				throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "The '{0}' can not be null or an empty string.", variableName), variableName);
			}
		}


		[DebuggerStepThrough()]
		public static void CheckForNullReference(object variable,
		string variableName)
		{
			if (variableName == null)
			{
				throw new ArgumentNullException("variableName");
			}

			if (variable == null)
			{
				throw new ArgumentNullException(variableName);
			}
		}


		[DebuggerStepThrough()]
		public static void RaiseArgumnetException(string message,
		string paramName)
		{
			throw new ArgumentException(message, paramName);
		}


		[DebuggerStepThrough()]
		public static void RaiseArgumnetException(string message)
		{
			throw new ArgumentException(message);
		}
	}
}