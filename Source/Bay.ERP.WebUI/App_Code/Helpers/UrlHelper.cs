using System;
using System.Diagnostics;
using System.Globalization;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using Bay.ERP.Common.Helper;
using Bay.ERP.BusinessFacade;
using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.Web.UI.Helper
{
	public sealed class UrlHelper
	{
        private HttpRequest _request;
        private HttpResponse _response;

        private SecureUrl _secureUrl;

        public SecureUrl SecureUrl
        {
            get
            {
                if (_secureUrl == null)
                {
                    _secureUrl = new SecureUrl(_request.Url.PathAndQuery);
                }

                return _secureUrl;
            }
        }

        public UrlHelper(HttpRequest request, HttpResponse response)
		{
            _request = request;
            _response = response;
		}

		[DebuggerStepThrough()]
		public void RedirectOnSessionTimeOut(string url)
		{
			_response.AppendHeader("Refresh", Convert.ToString(((HttpContext.Current.Session.Timeout * 60) - 5), System.Globalization.CultureInfo.CurrentCulture) + "; Url=" + url);
		}

		[DebuggerStepThrough()]
		public void Redirect(string url)
		{
            _response.Redirect(url, true);
		}

		[DebuggerStepThrough()]
        public void Redirect(SecureUrl url)
		{
			Redirect(url.ToString());
		}

        //[DebuggerStepThrough()]
        public void Redirect(string url,
        string returnUrl,
        params string[] parameters)
        {
            
            Redirect(BuildSecureUrl(url, returnUrl, AppendSiteMapParams(parameters)));
        }

        //[DebuggerStepThrough()]
        public string[] AppendSiteMapParams(string[] parameters)
        {
            string siteMapId = this.SecureUrl[UrlConstants.PARAM_SITEMAP_ID];
            string siteMapParentId = this.SecureUrl[UrlConstants.PARAM_SITEMAP_PARENT_ID];
            string[] siteMapParam = null;

            if((!string.IsNullOrEmpty(siteMapId)) ||  (!string.IsNullOrEmpty(siteMapParentId)))
            {
                siteMapParam = new string[4];
                siteMapParam[0] = UrlConstants.PARAM_SITEMAP_ID;
                siteMapParam[1] = siteMapId;
                siteMapParam[2] = UrlConstants.PARAM_SITEMAP_PARENT_ID;
                siteMapParam[3] = siteMapParentId;
            }

            if (siteMapParam != null && siteMapParam.Length > 0)
            {
                string[] temp = new string[siteMapParam.Length + parameters.Length];
                parameters.CopyTo(temp, 0);
                siteMapParam.CopyTo(temp, parameters.Length);

                return temp;
            }

            return parameters;
        }

		[DebuggerStepThrough()]
        public void RedirectIfNoReturnUrl(string url,
		string returnUrl,
		params string[] parameters)
		{
            string currentReturnUrl = SecureUrl.ReturnUrl;

            SecureUrl secureUrl;

            if (currentReturnUrl.Length > 0)
            {
                secureUrl = new SecureUrl(currentReturnUrl);
            }
            else
            {
                secureUrl = new SecureUrl(url);
            }

            if (!StringHelper.IsBlank(returnUrl))
            {
                secureUrl.ReturnUrl = returnUrl;
            }

            if (parameters != null)
            {
                if ((parameters.Length % 2) == 0)
                {
                    for (int i = 0; i < parameters.Length; i += 2)
                    {
                        secureUrl[parameters[i]] = parameters[i + 1];
                    }
                }
            }

            Redirect(secureUrl);
		}

        [DebuggerStepThrough()]
        public void RedirectIfNoReturnUrl(string url)
        {
            RedirectIfNoReturnUrl(url, string.Empty, null);
        }

		public static SecureUrl BuildSecureUrl(string url,
        string returnUrl,
		params string[] parameters)
		{
            SecureUrl secureUrl = new SecureUrl(url);

			 if ((parameters != null) && (parameters.Length > 0))
			{
                if ((parameters.Length % 2) == 0)
                {
                    for (int i = 0; i < parameters.Length; i += 2)
                    {
                        secureUrl[parameters[i]] = parameters[i + 1];
                    }
                }
			}
            
            if (!StringHelper.IsBlank(returnUrl))
            {
                secureUrl.ReturnUrl = returnUrl;
            }

			return secureUrl;
		}

        public static SecureUrl BuildSecureUrl(string url,
        //string returnUrl,IFacade facade, // just to make the code error free
            string returnUrl, IHRMemberFacade facade,
        params string[] parameters)
        {
            SecureUrl secureUrl = new SecureUrl(url);

            if ((parameters != null) && (parameters.Length > 0))
            {
                if ((parameters.Length % 2) == 0)
                {
                    for (int i = 0; i < parameters.Length; i += 2)
                    {
                        secureUrl[parameters[i]] = parameters[i + 1];
                    }
                }
            }
            
            if (!StringHelper.IsBlank(returnUrl))
            {
                secureUrl.ReturnUrl = returnUrl;
            }

            return secureUrl;
        }

        [DebuggerStepThrough()]
        public static SecureUrl BuildSecureUrlFromControlState(string url,
        string returnUrl,
        ControlCollection controls)
        {
            SecureUrl securlUrl = new SecureUrl(url);

            PopulateControlStateIntoSecureUrl(securlUrl, controls);

            if (!StringHelper.IsBlank(returnUrl))
            {
                securlUrl.ReturnUrl = returnUrl;
            }

            return securlUrl;
        }

        [DebuggerStepThrough()]
        public static void PopulateControlStateIntoSecureUrl(SecureUrl url,
        ControlCollection controls)
        {
            if (controls.Count > 0)
            {
                for (int i = 0; i < controls.Count; i++)
                {
                    IterateControlsToBuildUrl(ref url, controls[i]);
                }
            }
        }

        private static void IterateControlsToBuildUrl(ref SecureUrl url,
        Control control)
        {
            TextBox txt = control as TextBox;
            CheckBox chk = control as CheckBox;
            RadioButton rdo = control as RadioButton;
            ListControl lst = control as ListControl;

            if (txt != null)
            {
                if (!StringHelper.IsBlank(txt.Text))
                {
                    url[txt.UniqueID] = txt.Text;
                }
            }
            else if (chk != null)
            {
                url[chk.UniqueID] = StringHelper.Convert(chk.Checked);
            }
            else if (rdo != null)
            {
                url[rdo.UniqueID] = StringHelper.Convert(rdo.Checked);
            }
            else if (lst != null)
            {
                StringBuilder sb = new StringBuilder();

                for (int i = 0; i < lst.Items.Count; i++)
                {
                    if (lst.Items[i].Selected)
                    {
                        sb.Append(lst.Items[i].Value);
                        sb.Append("|");
                    }
                }

                if (sb.Length > 0)
                {
                    sb.Remove(sb.Length - 1, 1);
                }

                if (sb.Length > 0)
                {
                    url[lst.UniqueID] = sb.ToString();
                }
            }
            else
            {
                if (control.Controls.Count > 0)
                {
                    for (int i = 0; i < control.Controls.Count; i++)
                    {
                        IterateControlsToBuildUrl(ref url, control.Controls[i]);
                    }
                }
            }
        }

        [DebuggerStepThrough()]
        public void LoadControlStateFromUrl(ControlCollection controls)
        {
            if (controls.Count > 0)
            {
                for (int i = 0; i < controls.Count; i++)
                {
                    IterateControlsToLoadState(controls[i]);
                }
            }
        }

        private void IterateControlsToLoadState(Control control)
        {
            TextBox txt = control as TextBox;
            CheckBox chk = control as CheckBox;
            RadioButton rdo = control as RadioButton;
            ListControl lst = control as ListControl;

            SecureUrl url = this.SecureUrl;

            if (url.Contains(control.UniqueID))
            {
                if (txt != null)
                {
                    txt.Text = url[txt.UniqueID];
                }
                else if (chk != null)
                {
                    chk.Checked = Convert.ToBoolean(url[chk.UniqueID], CultureInfo.CurrentCulture);
                }
                else if (rdo != null)
                {
                    rdo.Checked = Convert.ToBoolean(url[rdo.UniqueID], CultureInfo.CurrentCulture);
                }
                else if (lst != null)
                {
                    string[] selectedItems = url[lst.UniqueID].Split('|');

                    if ((selectedItems != null) && (selectedItems.Length > 0))
                    {
                        for (int i = 0; i < selectedItems.Length; i++)
                        {
                            for (int j = 0; j < lst.Items.Count; j++)
                            {
                                if (StringHelper.IsEqual(selectedItems[i], lst.Items[j].Value))
                                {
                                    lst.Items[j].Selected = true;
                                    break;
                                }
                            }
                        }
                    }
                }
            }
            else
            {
                if (control.Controls.Count > 0)
                {
                    for (int i = 0; i < control.Controls.Count; i++)
                    {
                        IterateControlsToLoadState(control.Controls[i]);
                    }
                }
            }
        }
	}
}