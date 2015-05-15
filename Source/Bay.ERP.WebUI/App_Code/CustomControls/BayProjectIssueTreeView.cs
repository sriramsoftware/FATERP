using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using Bay.ERP.Common.BusinessEntities;
using Bay.ERP.Common.Helper;
using Bay.ERP.Common.Shared;
using Bay.ERP.FacadeCreator;
using Bay.ERP.FacadeCreator.FacadeContext;

/// <summary>
/// Summary description for ItemCategoryTree
/// </summary>
/// 
namespace Bay.ERP.Web.UI
{

    [DefaultProperty("Text")]
    [ToolboxData("<{0}:BayProjectIssueTreeView runat=server></{0}:BayProjectIssueTreeView>")]
    public class BayProjectIssueTreeView : TreeView
    {
        #region Properties

        IList<OTIssueEntity> nodeList;
        IList<OTIssueEntity> subCategoryNodeList;
        IList<OTIssueEntity> rootNodeList;

        //[Bindable(true)]
        [Category("Appearance")]
        [DefaultValue(false)]
        [Localizable(true)]
        public Boolean ShowCheckBoxesInAllNodes
        {
            get
            {
                return (Boolean)ViewState["BayProjectIssueTree_PROP_ShowCheckBoxesInAllNodes"];
            }

            set
            {
                ViewState["BayProjectIssueTree_PROP_ShowCheckBoxesInAllNodes"] = value;
            }
        }

        //[Bindable(true)]
        [Category("Appearance")]
        [DefaultValue(false)]
        [Localizable(true)]
        public Int64 ProjectID
        {
            get
            {
                return (Int64)ViewState["BayProjectIssueTree_PROP_ProjectID"];
            }

            set
            {
                ViewState["BayProjectIssueTree_PROP_ProjectID"] = value;
            }
        }



        #endregion

        #region Methods

        private void BuildTree()
        {
            this.Nodes.Clear();
            String fe1 = SqlExpressionBuilder.PrepareFilterExpression(OTIssueEntity.FLD_NAME_ReferenceID, ProjectID.ToString(), SQLMatchType.Equal);
            String fe2 = SqlExpressionBuilder.PrepareFilterExpression(OTIssueEntity.FLD_NAME_IssueIdentityCategoryID, MasterDataConstants.IssueIdentityCategory.PROJECT_TASK.ToString(), SQLMatchType.Equal);

            String fe = SqlExpressionBuilder.PrepareFilterExpression(fe1, SQLJoinType.AND, fe2);

            nodeList = FCCOTIssue.GetFacadeCreate().GetIL(null, null, String.Empty,fe, DatabaseOperationType.LoadWithFilterExpression);

            TreeNode rootNode= new TreeNode();
            if (nodeList != null && nodeList.Count > 0)
            {
                rootNodeList = (from a in nodeList
                                where a.ParentIssueID == null
                                select a).ToList();
                rootNode.Text = rootNodeList[0].Title;
                rootNode.Value = "0";
                rootNode.SelectAction = TreeNodeSelectAction.SelectExpand;
                rootNode.Expanded = true;

                LoadCategories(rootNode, rootNodeList[0].IssueID);

                this.Nodes.Add(rootNode);
            }
        }

        private void LoadCategories(TreeNode parentNode, Int64? parentIssueItemID)
        {
            #region Load Main Categories

            if (nodeList != null && nodeList.Count > 0)
            {
                subCategoryNodeList = (from a in nodeList
                                       where a.ParentIssueID == parentIssueItemID
                                        select a).ToList();

                if (subCategoryNodeList != null && subCategoryNodeList.Count > 0)
                {
                    foreach (OTIssueEntity ent in subCategoryNodeList)
                    {
                        TreeNode category = new TreeNode();

                        category.Text = ent.Title;
                        category.Value = ent.IssueID.ToString();
                        category.SelectAction = TreeNodeSelectAction.SelectExpand;
                        category.Expanded = false;
                        LoadCategories(category, ent.IssueID);
                        category.ImageUrl = "~/Images/Document/Foldere.png";
                        parentNode.ChildNodes.Add(category);
                    }
                }
            }

            #endregion
        }

        #endregion

        #region Events

        protected override void OnInit(EventArgs e)
        {
            //BuildTree();
        }

        protected override void RenderContents(HtmlTextWriter output)
        {
            base.RenderContents(output);
        }

        public void ReBuildTree()
        {
            BuildTree();
        }

        #endregion
    }
}