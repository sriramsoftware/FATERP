using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Web;

using Bay.ERP.Common.Helper;

namespace Bay.ERP.Web.UI.Helper
{
    public sealed class SecureUrl
	{
		private const string ENCRYPTED_KEY = "param";

		private const string RETURN_URL = "returnUrl";
		private const string RETURN_PARAM = "returnParam";

		private string _pageUrl = string.Empty;
        private Dictionary<string, string> _queryString = new Dictionary<string, string>(8, StringComparer.InvariantCultureIgnoreCase);

        private Dictionary<string, string> QueryStrings
		{
            [DebuggerStepThrough()]
			get
			{
				return _queryString;
			}
		}

		public string this[string key]
		{
            [DebuggerStepThrough()]
			get
			{
				if (QueryStrings.ContainsKey(key))
				{
					return QueryStrings[key];
				}

				return string.Empty;
			}
            [DebuggerStepThrough()]
			set
			{
                if (StringHelper.IsBlank(value))
                {
                    QueryStrings.Remove(key);
                }
                else
                {
                    QueryStrings[key] = value;
                }
			}
		}

		public string ReturnUrl
		{
            [DebuggerStepThrough()]
			get
			{
				if (QueryStrings.ContainsKey(RETURN_URL))
				{
					return QueryStrings[RETURN_URL];
				}

				return string.Empty;
			}
            [DebuggerStepThrough()]
			set
			{
				if (StringHelper.IsBlank(value))
				{
					QueryStrings.Remove(RETURN_URL);
				}
				else
				{
					QueryStrings[RETURN_URL] = value;
				}
			}
		}

		public string ReturnParameters
		{
            [DebuggerStepThrough()]
			get
			{
				if (QueryStrings.ContainsKey(RETURN_PARAM))
				{
					return QueryStrings[RETURN_PARAM];
				}

				return string.Empty;
			}
            [DebuggerStepThrough()]
			set
			{
                if (StringHelper.IsBlank(value))
				{
					QueryStrings.Remove(RETURN_PARAM);
				}
				else
				{
					QueryStrings[RETURN_PARAM] = value;
				}
			}
		}

        public SecureUrl(string fullUrl)
		{
            if (!StringHelper.IsBlank(fullUrl) && fullUrl.IndexOf('?') > 0)
			{
				string[] urlAndQueryString = fullUrl.Split('?');
				_pageUrl = urlAndQueryString[0];

				if (urlAndQueryString.Length > 1)
				{
                    int intTemp1, intTemp2, intTemp3;
                    intTemp1 = urlAndQueryString[1].IndexOf("/");
                    intTemp3 = urlAndQueryString[1].IndexOf(".");
                    intTemp2 = urlAndQueryString[1].IndexOf(".aspx");
                    intTemp2 = urlAndQueryString[1].IndexOf(".ascx");

                    if (!string.IsNullOrEmpty(urlAndQueryString[1]) && intTemp1 == -1 && intTemp2 == -1 && intTemp3 == -1)
                    {
                        Parse(urlAndQueryString[1]);
                    }
				}
			}
			else
			{
				_pageUrl = fullUrl;
			}
		}

        public SecureUrl(string url, 
		string queryString)
		{
			_pageUrl = url;
			Parse(queryString);
		}

        [DebuggerStepThrough()]
        public void Clear()
        {
            QueryStrings.Clear();
        }

        [DebuggerStepThrough()]
        public bool Contains(string key)
        {
            return QueryStrings.ContainsKey(key);
        }

		[DebuggerStepThrough()]
		public void Remove(string key)
		{
			QueryStrings.Remove(key);
		}

		[DebuggerStepThrough()]
		private void Parse(string queryString)
		{
			string[] parts = queryString.Split('&');

			foreach(string part in parts)
			{
				int equalToPosition = part.IndexOf('=');

				string name = part.Substring(0, equalToPosition);
				string val = part.Substring(equalToPosition + 1);
				val = HttpUtility.UrlDecode(val);

				if (StringHelper.IsEqual(name, ENCRYPTED_KEY))
				{
					if (val.Length > 0)
					{
						string decryptedString = HttpUtility.UrlDecode(StringHelper.Decrypt(val));

						string[] keyValue = decryptedString.Split('&');

						for(int i = 0; i < keyValue.Length; i++)
						{
							string param = keyValue[i];
							equalToPosition = param.IndexOf('=');

							if (equalToPosition > 0)
							{
								string paramName = param.Substring(0, equalToPosition);
								string paramValue = param.Substring(equalToPosition + 1);

								QueryStrings.Add(paramName, paramValue);
							}
						}
					}
				}
				else
				{
					QueryStrings.Add(name, val);
				}
			}
		}

		[DebuggerStepThrough()]
		public override string ToString()
		{
			return ToString(false);
		}

		[DebuggerStepThrough()]
		public string ToString(bool unicode)
		{
			StringBuilder queryString = new StringBuilder(QueryStrings.Count * 12);

			IDictionaryEnumerator e = QueryStrings.GetEnumerator();

			while(e.MoveNext())
			{
				queryString.Append(StringHelper.Convert(e.Key));
				queryString.Append('=');
				queryString.Append(HttpUtility.UrlEncode(StringHelper.Convert(e.Value)));
				queryString.Append('&');
			}

			if (queryString.Length > 0)
			{
				queryString.Remove(queryString.Length - 1, 1);
			}

			string encryptedQuery = StringHelper.Encrypt(queryString.ToString());

			string encodedQuery = HttpUtility.UrlEncode(encryptedQuery);

			if (unicode)
			{
				//Required if we are passing it to JavaScript
				encodedQuery = HttpUtility.UrlEncodeUnicode(encodedQuery);
			}

            if (encodedQuery.Length > 0)
            {
                return _pageUrl + "?" + ENCRYPTED_KEY + "=" + encodedQuery;
            }
            else
            {
                return _pageUrl;
            }
		}
	}
}