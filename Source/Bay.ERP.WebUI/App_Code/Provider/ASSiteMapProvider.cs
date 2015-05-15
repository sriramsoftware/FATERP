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
using Bay.ERP.Common.Helper;
using Bay.ERP.FacadeCreator.FacadeContext;
using Bay.ERP.Common.Shared;
using System.IO;

namespace Bay.ERP.Provider
{
    public class ASSiteMapProvider : DynamicSiteMapProvider
    {
        private Int64 aSSiteMapID;

        private readonly object _siteMapLock = new object();
        
        private SiteMapNode rootSiteMapNode = null;


        public ASSiteMapProvider()
        {

        }

        public override void Initialize(string name, NameValueCollection attributes)
        {
            base.Initialize(name, attributes);
            aSSiteMapID = Int64.Parse(attributes["ASSiteMapID"].ToString());
        }

        public override SiteMapNode BuildSiteMap()
        {
            lock (_siteMapLock)
            {
                if (rootSiteMapNode != null)
                {
                    return rootSiteMapNode;
                }

                base.Clear();


                String sortExpression = SqlExpressionBuilder.PrepareSortExpression(ASSiteMapNode_DetailedEntity.FLD_NAME_SequenceNumber, SQLSortOrderType.Assending);
                String filterExpression1 = "ASSiteMapNode." + SqlExpressionBuilder.PrepareFilterExpression(ASSiteMapNode_DetailedEntity.FLD_NAME_ASSiteMapID, aSSiteMapID.ToString(), SQLMatchType.Equal);
                String filterExpression2 = SqlExpressionBuilder.PrepareFilterExpression(ASSiteMapNode_DetailedEntity.FLD_NAME_ParentASSiteMapNodeID, String.Empty, SQLMatchType.IsNull);
                String filterExpression = SqlExpressionBuilder.PrepareFilterExpression(filterExpression1, SQLJoinType.AND, filterExpression2);

                IList<ASSiteMapNode_DetailedEntity> aSSiteMapNode_DetailedEntityList = FCCASSiteMapNode_Detailed.GetFacadeCreate().GetIL(1, 1000000, sortExpression, filterExpression);

                if (aSSiteMapNode_DetailedEntityList != null && aSSiteMapNode_DetailedEntityList.Count > 0)
                {
                    rootSiteMapNode = new SiteMapNode(this, aSSiteMapNode_DetailedEntityList[0].ASSiteMapNodeID.ToString());
                    rootSiteMapNode.Title = aSSiteMapNode_DetailedEntityList[0].MenuTitle;
                    rootSiteMapNode.Url = aSSiteMapNode_DetailedEntityList[0].NavigationURL;
                    rootSiteMapNode.Description = aSSiteMapNode_DetailedEntityList[0].ToolTip;

                    AddChildNodeToMenu(rootSiteMapNode, aSSiteMapNode_DetailedEntityList[0].ASSiteMapNodeID);

                    if (rootSiteMapNode.ChildNodes.Count > 0)
                    {
                        AddNode(rootSiteMapNode);
                    }
                    else
                    {
                        rootSiteMapNode = null;
                    }                    
                }

                return rootSiteMapNode;
            }
        }

        private void AddChildNodeToMenu(SiteMapNode currentNode, Int64 parentID)
        {            
            //String ss = "a";
            //File.AppendAllText("C://Test//test.txt", ss);

            String sortExpression = SqlExpressionBuilder.PrepareSortExpression(ASSiteMapNode_DetailedEntity.FLD_NAME_SequenceNumber, SQLSortOrderType.Assending);
            String filterExpression1 = "ASSiteMapNode." + SqlExpressionBuilder.PrepareFilterExpression(ASSiteMapNode_DetailedEntity.FLD_NAME_ASSiteMapID, aSSiteMapID.ToString(), SQLMatchType.Equal);
            String filterExpression2 = SqlExpressionBuilder.PrepareFilterExpression(ASSiteMapNode_DetailedEntity.FLD_NAME_ParentASSiteMapNodeID, parentID.ToString(), SQLMatchType.Equal);
            String filterExpression = SqlExpressionBuilder.PrepareFilterExpression(filterExpression1, SQLJoinType.AND, filterExpression2);

            IList<ASSiteMapNode_DetailedEntity> aSSiteMapNode_DetailedEntityList = FCCASSiteMapNode_Detailed.GetFacadeCreate().GetIL(1, 1000000, sortExpression, filterExpression);

            if (aSSiteMapNode_DetailedEntityList != null && aSSiteMapNode_DetailedEntityList.Count > 0)
            {
                foreach (ASSiteMapNode_DetailedEntity aSSiteMapNode_DetailedEntity in aSSiteMapNode_DetailedEntityList)
                {
                    Boolean hasPermission = false;

                    if (aSSiteMapNode_DetailedEntity.ASPhysicalSiteMapID == null)
                    {
                        hasPermission = PermissionHelper.IsUerHasPermission(aSSiteMapNode_DetailedEntity.UniqueKey);
                    }
                    else if (aSSiteMapNode_DetailedEntity.ASPhysicalSiteMapID > 0)
                    {
                        hasPermission = PermissionHelper.IsUerHasPermission(aSSiteMapNode_DetailedEntity.ASPhysicalSiteMapUniqueKey);
                    }

                    if (hasPermission == true)
                    {
                        SiteMapNode siteMapNode = new SiteMapNode(this, aSSiteMapNode_DetailedEntity.ASSiteMapNodeID.ToString());

                        siteMapNode.Title = aSSiteMapNode_DetailedEntity.MenuTitle;
                        siteMapNode.Url = aSSiteMapNode_DetailedEntity.NavigationURL;
                        siteMapNode.Description = aSSiteMapNode_DetailedEntity.ToolTip;

                        AddNode(siteMapNode, currentNode);

                        AddChildNodeToMenu(siteMapNode, aSSiteMapNode_DetailedEntity.ASSiteMapNodeID);
                    }
                }
            } 
        }

        protected override SiteMapNode GetRootNodeCore()
        {
            return rootSiteMapNode;
        }
    }
}
