using System;
using System.Data;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using System.Collections;
using System.Collections.Generic;

namespace Bay.ERP.Web.UI
{
    public class PageLibrary
    {
        private IList<SitePage> _sitepages = new List<SitePage>();
        private IList<GroupNode> _sitegroupnodes = new List<GroupNode>();

        public IList<SitePage> RootPages
        {
            get { return _sitepages; }
            set { _sitepages = value; }
        }

        public IList<GroupNode> RootGroupNodes
        {
            get { return _sitegroupnodes; }
            set { _sitegroupnodes = value; }
        }

        public PageLibrary()
        {
        }

        public static PageLibrary GetSiteLibrary(string file)
        {
            XDocument doc = XDocument.Load(file);
            PageLibrary lib = new PageLibrary()
            {

                RootPages = GetSitePageObjects(doc.Root),
                RootGroupNodes = GetSiteGroupNodeObjects(doc.Root)
            };
            return lib;
        }

        public static IList<SitePage> GetSitePageObjects(XElement element)
        {
            IList<SitePage> pages = new List<SitePage>();
            var query = from p in element.Elements("Page")
                        select p;
            foreach (var page in query)
            {
                pages.Add(new SitePage() { Name = page.Attribute("Name").Value, PageUrl = page.Attribute("PageUrl").Value, UniqueKey = page.Attribute("UniqueKey").Value });
            }
            return pages;
        }

        public static IList<GroupNode> GetSiteGroupNodeObjects(XElement element)
        {
            IList<GroupNode> groupnodes = new List<GroupNode>();
            var query = from p in element.Elements("GroupNode")
                        select p;
            foreach (var groupnode in query)
            {
                groupnodes.Add(new GroupNode() { Name = groupnode.Attribute("Name").Value, ChildSitePages = GetSitePageObjects(groupnode), ChildGroupNodes = GetSiteGroupNodeObjects(groupnode) });
            }
            return groupnodes;
        }
    }
    

    public class SitePage
    {
        private string _name = string.Empty;
        private string _pageurl = string.Empty;
        private string _uniquekey = string.Empty;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public string PageUrl
        {
            get { return _pageurl; }
            set { _pageurl = value; }
        }
        public string UniqueKey
        {
            get { return _uniquekey; }
            set { _uniquekey = value; }
        }
    }


    public class GroupNode
    {
        private string _name = string.Empty;
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        private IList<SitePage> _childsitepages = new List<SitePage>();

        private IList<GroupNode> _childgroupnodes = new List<GroupNode>();

        public IList<SitePage> ChildSitePages
        {
            get { return _childsitepages; }
            set { _childsitepages = value; }
        }

        public IList<GroupNode> ChildGroupNodes
        {
            get { return _childgroupnodes; }
            set { _childgroupnodes = value; }
        }
    }
}