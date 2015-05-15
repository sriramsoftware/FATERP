using System;
using System.Diagnostics;
using System.Web;
using Bay.ERP.Common.Helper;

namespace Bay.ERP.Web.UI.Helper
{
	public sealed class CookieHelper
	{
		private HttpRequest _request;
		private HttpResponse _response;

        public CookieHelper(HttpRequest request, 
		HttpResponse response)
		{
			_request = request;
			_response = response;
		}

		public CookieHelper(HttpRequest request):this(request, null)
		{
		}

		public CookieHelper(HttpResponse response):this(null, response)
		{
		}

        public CookieHelper()
		{
			HttpContext context = HttpContext.Current;

			_request = context.Request;
			_response = context.Response;
		}

		[DebuggerStepThrough()]
		public void Set(string key,
		string value,
		DateTime expire)
		{
            SetValue(StringHelper.Encrypt(BuildFullKey(key)), StringHelper.Encrypt(value), expire);
		}

		[DebuggerStepThrough()]
		public void Set(string key,
		string value)
		{
            SetValue(StringHelper.Encrypt(BuildFullKey(key)), StringHelper.Encrypt(value));
		}

		[DebuggerStepThrough()]
		private void SetValue(string key,
		string value,
		DateTime expire)
		{
			HttpCookie cookie = new HttpCookie(HttpUtility.UrlEncode(key), HttpUtility.UrlEncode(value));
			cookie.Expires = expire;

			SetCookie(cookie);
		}

		[DebuggerStepThrough()]
		private void SetValue(string key,
		string value)
		{
			SetCookie(new HttpCookie(HttpUtility.UrlEncode(key), HttpUtility.UrlEncode(value)));
		}

		[DebuggerStepThrough()]
		private void SetCookie(HttpCookie cookie)
		{
			_response.Cookies.Set(cookie);
		}

		[DebuggerStepThrough()]
		public string Get(string key)
		{
			string value = GetValue(key);

			if (value != null)
			{
                return StringHelper.Decrypt(value);
			}

			return null;
		}
		
		[DebuggerStepThrough()]
		private string GetValue(string key)
		{
            HttpCookie cookie = GetCookie(StringHelper.Encrypt(BuildFullKey(key)));

			if (cookie == null)
			{
				return null;
			}

			if (StringHelper.IsBlank(cookie.Value))
			{
				return null;
			}

			return HttpUtility.UrlDecode(cookie.Value);
		}
		
		[DebuggerStepThrough()]
		private HttpCookie GetCookie(string key)
		{
			return _request.Cookies[HttpUtility.UrlEncode(key)];
		}

		[DebuggerStepThrough()]
		public static string BuildFullKey(string localKey)
		{
			const string COOKIE_KEY = "Web.UI.Helper";

			if (localKey.IndexOf(COOKIE_KEY) > -1)
			{
				return localKey;
			}
			else
			{
				return COOKIE_KEY + localKey;
			}
		}
	}
}