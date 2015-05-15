using System.Diagnostics;
using System.Web;
using System.Web.UI;

namespace Bay.ERP.Web.UI.Helper
{
	public sealed class WebHelper
	{
		private HttpRequest _request;
        private HttpResponse _response;

		private ControlHelper _control;
		private SessionHelper _session;
		private UrlHelper _url;
		private CookieHelper _cookie;

		public ControlHelper Control
		{
            [DebuggerStepThrough()]
			get
			{
				return _control;
			}
		}
		
		public SessionHelper Session
		{
            [DebuggerStepThrough()]
			get
			{
				return _session;
			}
		}

		public UrlHelper Url
		{
            [DebuggerStepThrough()]
			get
			{
				return _url;
			}
		}

		public CookieHelper Cookie
		{
            [DebuggerStepThrough()]
			get
			{
				return _cookie;
			}
		}

		public HttpRequest Request
		{
            [DebuggerStepThrough()]
			get
			{
                return _request;
			}
		}

		public HttpResponse Response
		{
            [DebuggerStepThrough()]
			get
			{
                return _response;
			}
		}

        public WebHelper(MasterPage page)
        {
            _request = page.Request;
            _response = page.Response;
            _control = new ControlHelper(page.Request);
            _session = new SessionHelper(page.Session);
            _url = new UrlHelper(page.Request, page.Response);
            _cookie = new CookieHelper(page.Request, page.Response);
        }

        public WebHelper(Page page)
        {
            _request = page.Request;
            _response = page.Response;
            _control = new ControlHelper(page.Request);
            _session = new SessionHelper(page.Session);
            _url = new UrlHelper(page.Request, page.Response);
            _cookie = new CookieHelper(page.Request, page.Response);
        }

        public WebHelper(UserControl control)
        {
            _request = control.Request;
            _response = control.Response;
            _control = new ControlHelper(control.Request);
            _session = new SessionHelper(control.Session);
            _url = new UrlHelper(control.Request, control.Response);
            _cookie = new CookieHelper(control.Request, control.Response);
        }

        public WebHelper(HttpContext context)
        {
            _request = context.Request;
            _response = context.Response;
            _control = new ControlHelper(context.Request);
            _session = new SessionHelper(context.Session);
            _url = new UrlHelper(context.Request, context.Response);
            _cookie = new CookieHelper(context.Request, context.Response);
        }

        public void WriteXml(string xml, string fileName)
        {
            _response.Clear();
            _response.AddHeader("content-disposition", "attachment; filename=" + fileName);
            _response.ContentEncoding = System.Text.Encoding.UTF8;
            _response.Cache.SetCacheability(HttpCacheability.NoCache);
            _response.ContentType = "text/xml";
            _response.Write(xml);
            _response.End();
        }

        public void WriteCode(string code, string fileName)
        {
            _response.Clear();
            _response.ContentType = "text/plain";
            _response.AddHeader("content-disposition", "attachment; filename=" + fileName);
            _response.Write(code);
            _response.End();
        }
	}
}