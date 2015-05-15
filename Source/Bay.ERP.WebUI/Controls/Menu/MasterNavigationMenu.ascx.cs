using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using Bay.ERP.Common.Helper;
using Bay.ERP.Common.Shared;
using Bay.ERP.Web.UI.Helper;
using Bay.ERP.Common.BusinessEntities;
using Bay.ERP.FacadeCreator.FacadeContext;

namespace Bay.ERP.Web.UI
{
    public partial class MasterNavigationMenuControl : BaseControl
    {
        IList<ASSiteMapNode_DetailedEntity> list = new List<ASSiteMapNode_DetailedEntity>();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session[SessionConstants.MASTER_NAVIGATION_MENU_ITEMS] != null &&
                    ((IList<ASSiteMapNode_DetailedEntity>)Session[SessionConstants.MASTER_NAVIGATION_MENU_ITEMS]).Count > 0)
            {
                list = (IList<ASSiteMapNode_DetailedEntity>)Session[SessionConstants.MASTER_NAVIGATION_MENU_ITEMS];

                BindMenu();
            }
        }

        protected void BindMenu()
        {
            var lst = from a in list
                      where ( a.ASSiteMapID == SecurityConstants.ASSiteMap.MASTER_NAVIGATION_MENU 
                      && a.ParentASSiteMapNodeID == null) 
                        select a;

            foreach (var i in lst)
            {
                MenuItem rootNode = new MenuItem();
                rootNode.Text = i.MenuTitle;
                rootNode.Value = i.ASSiteMapNodeID.ToString();
                rootNode.NavigateUrl = i.NavigationURL;
                rootNode.ToolTip = String.Empty;

                AddChildNodes(rootNode, i.ASSiteMapNodeID);

                mnu.Items.Add(rootNode);
            }
        }

        protected void AddChildNodes(MenuItem parentNode, Int64 parentID)
        {
            var lst = from a in list
                      where (a.ASSiteMapID == SecurityConstants.ASSiteMap.MASTER_NAVIGATION_MENU
                      && a.ParentASSiteMapNodeID == parentID)
                      select a;

            foreach (var i in lst)
            {
                MenuItem node = new MenuItem();
                node.Text = i.MenuTitle;
                node.Value = i.ASSiteMapNodeID.ToString();
                node.NavigateUrl = i.NavigationURL;
                node.ToolTip = String.Empty;

                AddChildNodes(node, i.ASSiteMapNodeID);

                parentNode.ChildItems.Add(node);
            } 
        }

        //protected void mnuApplicationMenu_ItemDataBound(object sender, Telerik.Web.UI.RadMenuEventArgs e)
        //{
        //    try
        //    {
        //        if (e.Item.Text == "My Self Service")
        //        {
        //            // need to handel if current user is null
        //            e.Item.NavigateUrl = UrlHelper.BuildSecureUrl(e.Item.NavigateUrl, String.Empty, UrlConstants.OVERVIEW_MEMBER_ID, this.CurrentMember.MemberID.ToString()).ToString();
        //        }
        //        if (e.Item.NavigateUrl.Contains("TMTaskEditor.aspx"))
        //        {
        //            e.Item.NavigateUrl = BuildNavigationUrlForTask(e.Item.NavigateUrl);
        //        }
        //        else if (e.Item.NavigateUrl.Contains("TMTaskEditorList.aspx"))
        //        {
        //            e.Item.NavigateUrl = BuildNavigationUrlForTask(e.Item.NavigateUrl);
        //        }
        //    }
        //    catch
        //    { }
        //}
        //private String BuildNavigationUrlForTask(String url)
        //{
        //    if (url.IsNotNullOrEmpty())
        //    {

        //        Int64 _MemberID = this.CurrentMember.MemberID;

        //        if (_MemberID > 0)
        //        {
        //            url = UrlHelper.BuildSecureUrl(url, String.Empty, UrlConstants.OVERVIEW_MEMBER_ID, _MemberID.ToString(), UrlConstants.ERM_MEMBER_OVERVIEW_SKIN, "", UrlConstants.OVERVIEW_TMTASKREFERENCEINFOID, _MemberID.ToString(), UrlConstants.OVERVIEW_MDTMTASKREFERENCECATEGORYID, "5").ToString();
        //        }
        //    }

        //    return url;
        //}
    }
}