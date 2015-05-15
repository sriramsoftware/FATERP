using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml;
using System.Xml.Linq;
using Bay.ERP.BusinessFacade;
using Bay.ERP.Common.BusinessEntities;
using Bay.ERP.Web.UI;

namespace Bay.ERP.Provider
{
    public class DynamicSiteMapProvider : StaticSiteMapProvider
    {
        IASRolePermissionFacade rolepermissionfacade = null;
        IASUserPermissionExcludedFacade userpermissionexclusionfacade = null;
        IList<ASRolePermissionEntity> permissions = null;
        IList<ASUserPermissionExcludedEntity> userpermissionexcluded = null;

        private string _sitemapfilename = string.Empty;
        public const string sitemapnodename = "siteMapNode";
        private SiteMapNode _rootsitemapnode = null;

        public DynamicSiteMapProvider()
        {
        }

        public override SiteMapNode RootNode
        {
            get
            {
                return BuildSiteMap();
            }
        }

        public override void Initialize(string name, NameValueCollection attributes)
        {
            base.Initialize(name, attributes);
            _sitemapfilename = attributes["siteMapFile"];
        }

        protected override void Clear()
        {
            lock (this)
            {
                _rootsitemapnode = null;

                //_rootsitemapnode.ChildNodes.Clear();

                base.Clear();
            }
        }

        public override SiteMapNode BuildSiteMap()
        {
            lock (this)
            {
                Clear();

                if (null == _rootsitemapnode)
                {
                    Clear();

                    XmlDocument siteMapXml = LoadSiteMap();                    

                    XmlElement rootElement = (XmlElement)siteMapXml.GetElementsByTagName(sitemapnodename)[0];

                    GenerateSiteMapNodes(rootElement);
                }
            }

            return _rootsitemapnode;
        }

        private XmlDocument LoadSiteMap()
        {
            XmlDocument sitemapxml = new XmlDocument();
            sitemapxml.Load(AppDomain.CurrentDomain.BaseDirectory + "\\" + _sitemapfilename.Replace("~", "").Replace("/", "\\"));
            
            return sitemapxml;
        }

        protected override SiteMapNode GetRootNodeCore()
        {
            return RootNode;
        }

        private void GenerateSiteMapNodes(XmlElement rootElement)
        {
            _rootsitemapnode = GetSiteMapNodeFromElement(rootElement);
            AddNode(_rootsitemapnode);
            CreateChildNodes(rootElement, _rootsitemapnode);
        }

        private void CreateChildNodes(XmlElement parentelement, SiteMapNode parentnode)
        {
            foreach (XmlNode xmlelement in parentelement.ChildNodes)
            {
                if (xmlelement.Name == sitemapnodename)
                {
                    SiteMapNode childnode = GetSiteMapNodeFromElement((XmlElement)xmlelement);

                    //if (permissions != null)
                    //{
                        //if (childnode.Url != string.Empty)
                        //{
                            if (HttpContext.Current.Session[SessionConstants.USER_PERMISSION_KEYS] != null)
                            {
                                if (PermissionHelper.IsUerHasPermission(childnode["uniquekey"]) == true)
                                {
                                    AddNode(childnode, parentnode);
                                    CreateChildNodes((XmlElement)xmlelement, childnode);
                                }
                            }

                            //foreach (EPMS.Common.BusinessEntities.ASRolePermissionEntity permission in permissions)
                            //{
                            //    if (childnode["uniquekey"] == permission.PermissionKey)
                            //    {
                            //        AddNode(childnode, parentnode);
                            //        CreateChildNodes((XmlElement)xmlelement, childnode);
                            //        break;
                            //    }
                            //}
                        //}
                        //else
                        //{
                        //    AddNode(childnode, parentnode);
                        //    CreateChildNodes((XmlElement)xmlelement, childnode);
                        //}
                    //}
                }
            }
        }

        private SiteMapNode GetSiteMapNodeFromElement(XmlElement rootElement)
        {
            SiteMapNode newSiteMapNode;

            String url = rootElement.GetAttribute("url");
            String title = rootElement.GetAttribute("title");
            String description = rootElement.GetAttribute("description");

            newSiteMapNode = new SiteMapNode(this, (url + title).GetHashCode().ToString(), url, title, description);
            newSiteMapNode["uniquekey"] = rootElement.GetAttribute("uniquekey");

            return newSiteMapNode;
        }
    }
}
