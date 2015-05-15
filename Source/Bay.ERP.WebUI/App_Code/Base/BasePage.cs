using System;
using System.Diagnostics;
using System.Web.Security;
using System.Web.UI;
using System.Collections;
using System.Linq;

using Bay.ERP.BusinessFacade;
using Bay.ERP.Common.BusinessEntities;
using Bay.ERP.Web.UI.Helper;

using System.Web;
using System.IO.Compression;
using System.Text.RegularExpressions;
using System.Text;
using System.IO;
using System.Web.UI.HtmlControls;
using System.Collections.Generic;
using System.Configuration;
using System.Web.UI.WebControls;
using System.ComponentModel;

namespace Bay.ERP.Web.UI
{
    public abstract class BasePage : System.Web.UI.Page
    {
        #region Member Variables

        private WebHelper _helper;
        
        private static Regex _WhitespaceRemovalRegex = new Regex(@" {2,}|\t+", RegexOptions.Compiled | RegexOptions.Multiline | RegexOptions.CultureInvariant);
        private static Regex _LineTerminationRemoval = new Regex(@"\r\n\r\n|\r|^\s+|\s+$", RegexOptions.Compiled | RegexOptions.Multiline | RegexOptions.CultureInvariant);

        #endregion

        #region Properties

        [Bindable(true)]
        [Category("Appearance")]
        [DefaultValue("")]
        [Localizable(true)]
        public abstract string UniqueKey
        {
            get;
        }

        public virtual String WebUserControlPaths { get; set; }
        
        
        
        protected HRMemberEntity CurrentMember
        {
            [DebuggerStepThrough()]
            get
            {
                return HttpContext.Current.Session[SessionConstants.LOGIN_MEMBER_INFO] as HRMemberEntity;
            }
        }

        protected WebHelper Helper
        {
            [DebuggerStepThrough()]
            get
            {
                if (_helper == null)
                {
                    _helper = new WebHelper(this);
                }

                return _helper;
            }
        }

        protected Hashtable SiteSetting
        {
            [DebuggerStepThrough()]
            get
            {
                return Context.Items[ContextConstants.SITESETTING] as Hashtable;
            }
        }

        #endregion

        #region Methods

        protected void ChangeTheam(string colorName)
        {
            Page.Theme = colorName;
        }

        #endregion

        #region Events

        protected override void OnInit(EventArgs e)
        {
            base.OnInit(e);

            Boolean permissionfound = PermissionHelper.IsUerHasPermission(this.UniqueKey);
            //Boolean permissionfound = true;
            
            if (!permissionfound)
            {
                String url = ConfigurationManager.AppSettings["webRoot"] + "LogIn.aspx?returnUrl=" + Request.Url.AbsoluteUri;
                url = url.Replace("%", "_");
                Helper.Url.Redirect(url);
            }
        }

        protected override void OnPreInit(EventArgs e)
        {
            base.OnPreInit(e);

        //    string themeValue = Helper.Url.SecureUrl["theme"];

        //    string finalTheme = string.Empty;
        //    //string finalTheme = "Default";

        //    UserProfile profile = UserProfile.GetUserProfile(CurrentUserName);
        //    //profile.CurrentUserTheme = themeValue;

        //    if (!string.IsNullOrEmpty(themeValue))
        //    {
        //        //Session.Add("MyTheme", themeValue);
        //        finalTheme = themeValue;

        //        if (profile != null && !profile.IsAnonymous)
        //        {
        //            profile.CurrentUserTheme = themeValue;
        //            profile.Save();
        //        }
        //    }
        //    else if (profile != null && !string.IsNullOrEmpty(profile.CurrentUserTheme))
        //    {
        //        finalTheme = profile.CurrentUserTheme;
        //    }
        //    else if (string.IsNullOrEmpty((string)Session["MyTheme"]))
        //    {
        //        finalTheme = "Default";
        //    }
        //    else
        //    {
        //        finalTheme = (string)Session["MyTheme"];
        //    }

        //    if ((string)Session["MyTheme"] != finalTheme)
        //    {
        //        Session.Add("MyTheme", finalTheme);
        //    }

        //    //Page.Theme = "Oyster";

        //    Page.Theme = ((string)Session["MyTheme"]);

            string defaultPageTitle = ConfigurationManager.AppSettings["defaultPageTitle"].ToString();

            if (!string.IsNullOrEmpty(defaultPageTitle))
            {
                Page.Title = defaultPageTitle;
            }

        //    if (!string.IsNullOrEmpty(Helper.Url.SecureUrl.ReturnUrl) && (!string.IsNullOrEmpty(themeValue)))
        //    {
        //        Response.Redirect(Helper.Url.SecureUrl.ReturnUrl);
        //    }
        }

        //protected override void OnPreRender(EventArgs e)
        //{   
        //    base.OnPreRender(e);
        //}

        //protected override void Render(HtmlTextWriter writer)
        //{
        //    //var theme = this.Theme;

        //    //foreach (var link in Page.Header.Controls.OfType<HtmlLink>().ToList())
        //    //{
        //    //    var href = link.Attributes["href"];
        //    //    var type = link.Attributes["type"];

        //    //    var isCss = type.EqualsIgnoreCase("text/css");

        //    //    if (isCss)
        //    //    {
        //    //        //var url = ResolveUrl(href);                    
        //    //        //do not allow css.ashx to be removed
        //    //        if (link.Href.ContainsIgnoreCase("css.axd"))
        //    //        {
        //    //            var query = link.Href + "&t=" + theme +  "&" + UrlConstants.CssSuffix;
        //    //            link.Href = query;
        //    //            continue;
        //    //        }

        //    //        //remove theme css
        //    //        if (link.Href.ContainsIgnoreCase("App_Themes/{0}".Fill(theme)))
        //    //        {
        //    //            link.Parent.Controls.Remove(link);
        //    //        }
        //    //    }
        //    //}

        //    //foreach (Control c in Controls)
        //    //{
        //    //    IterateControlsToAddSuffixAndPrefix(c);
        //    //}

        //    base.Render(writer);
        //}

        //private void IterateControlsToAddSuffixAndPrefix(Control control)
        //{
        //    if (control is HtmlImage)
        //    {
        //        HtmlImage img = control as HtmlImage;
        //        img.Src = MiscUtil.AppendSuffixAndPrefix(img.Src, UrlConstants.ImageSuffix, UrlConstants.ImagePrefix);
        //    }
        //    else if (control is Image)
        //    {
        //        Image img = control as Image;
        //        //Condition added by Fazlur.No need to add prefix and suffix in case of Member personal resources
        //        if (img.ImageUrl.IndexOf("Resources") == -1)
        //        {
        //            img.ImageUrl = MiscUtil.AppendSuffixAndPrefix(img.ImageUrl, UrlConstants.ImageSuffix, UrlConstants.ImagePrefix);
        //        }
        //    }
        //    else if (control is HyperLink)
        //    {
        //        HyperLink hyperLinkImg = control as HyperLink;
        //        //Condition added by Fazlur.No need to add prefix and suffix in case of Member personal resources
        //        if (hyperLinkImg.ImageUrl.IsNotNullOrEmpty() && hyperLinkImg.ImageUrl.IndexOf("Resources") == -1)
        //        {
        //            hyperLinkImg.ImageUrl = MiscUtil.AppendSuffixAndPrefix(hyperLinkImg.ImageUrl, UrlConstants.ImageSuffix, UrlConstants.ImagePrefix);
        //        }
        //    }
        //    else
        //    {
        //        if (control.Controls.Count > 0)
        //        {
        //            for (int i = 0; i < control.Controls.Count; i++)
        //            {
        //                IterateControlsToAddSuffixAndPrefix(control.Controls[i]);
        //            }
        //        }
        //    }




        //}

        #endregion
    }
}