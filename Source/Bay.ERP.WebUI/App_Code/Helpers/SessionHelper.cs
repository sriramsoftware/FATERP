using System.Diagnostics;
using System.Web.SessionState;

namespace Bay.ERP.Web.UI.Helper
{
	public sealed class SessionHelper
	{
		private HttpSessionState _session;

        public string Id
        {
            get
            {
                return _session.SessionID;
            }
        }

        public int Timeout
        {
            get
            {
                return _session.Timeout;
            }
        }

        public SessionHelper(HttpSessionState session)
		{
			_session = session;
		}

		[DebuggerStepThrough()]
		public void Clear()
		{
			_session.Clear();
		}

		[DebuggerStepThrough()]
		public void Restart()
		{
			_session.Abandon();
		}

		[DebuggerStepThrough()]
        public object Get(string key)
		{
            return _session[BuildFullKey(key)];
		}

        [DebuggerStepThrough()]
        public string GetValue(string key)
        {
            key = BuildFullKey(key);
            if (_session[key] != null)
            {
                return _session[key].ToString();
            }
            else
            {
                return string.Empty;
            }
        }

		[DebuggerStepThrough()]
        public void Set(string key,
        object value)
		{
			if (value == null)
			{
				_session.Remove(BuildFullKey(key));
			}
			else
			{
				_session[BuildFullKey(key)] = value;
			}
		}

		[DebuggerStepThrough()]
		public void Remove(string key)
		{
			_session.Remove(BuildFullKey(key));
		}

		[DebuggerStepThrough()]
		private static string BuildFullKey(string localKey)
		{
			const string SESSION_KEY = "Web.UI.";

			if (localKey.IndexOf(SESSION_KEY) > -1)
			{
				return localKey;
			}
			else
			{
				return SESSION_KEY + localKey;
			}
		}
	}
}