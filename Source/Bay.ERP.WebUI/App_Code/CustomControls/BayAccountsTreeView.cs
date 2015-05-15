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
    [ToolboxData("<{0}:BayAccountsTreeView runat=server></{0}:BayAccountsTreeView>")]
    public class BayAccountsTreeView : TreeView
    {
        #region Properties

        IList<ACAccountGroupEntity> nodeList;
        IList<ACAccountGroupEntity> subCategoryNodeList;
        IList<ACAccountEntity> accountList;
        IList<ACAccountEntity> catAccountList;

        #endregion

        #region Methods

        private void BuildTree()
        {
            this.Nodes.Clear();

            nodeList = FCCACAccountGroup.GetFacadeCreate().GetIL(null, null, String.Empty, String.Empty, DatabaseOperationType.Load);
            accountList = FCCACAccount.GetFacadeCreate().GetIL(null, null, String.Empty, String.Empty, DatabaseOperationType.Load);

            TreeNode rootNode= new TreeNode();

            rootNode.Text = "Accounts Tree";
            rootNode.Value = "0";
            rootNode.SelectAction = TreeNodeSelectAction.SelectExpand;
            rootNode.Expanded = true;

            LoadCategories(rootNode, null);

            this.Nodes.Add(rootNode);
        }

        private void LoadCategories(TreeNode parentNode, Int64? parentProjectDocumentCategoryID)
        {
            #region Load Main Categories

            if (nodeList != null && nodeList.Count > 0)
            {
                subCategoryNodeList = (from a in nodeList
                                       where a.ParentAccountGroupID == parentProjectDocumentCategoryID
                                        select a).ToList();

                if (subCategoryNodeList != null && subCategoryNodeList.Count > 0)
                {
                    foreach (ACAccountGroupEntity ent in subCategoryNodeList)
                    {
                        TreeNode category = new TreeNode();

                        category.Text = ent.Name;
                        category.Value = ent.AccountGroupID.ToString();
                        category.SelectAction = TreeNodeSelectAction.SelectExpand;
                        category.Expanded = false;

                        LoadCategories(category, ent.AccountGroupID);
                        category.ImageUrl = ImageConstants.ACCOUNTS_CATEGORY;
                        parentNode.ChildNodes.Add(category);

                        #region Loading the Documents

                        if (accountList != null && accountList.Count > 0)
                        {
                            catAccountList = (from d in accountList
                                              where d.AccountGroupID == ent.AccountGroupID
                                              select d).ToList();


                            foreach (ACAccountEntity aCAccountEntity in catAccountList)
                            {
                                TreeNode docNode = new TreeNode();
                                docNode.Value = aCAccountEntity.AccountID.ToString();
                                docNode.Text = aCAccountEntity.AccountCode + " - " + aCAccountEntity.AccountName;
                                docNode.SelectAction = TreeNodeSelectAction.Select;
                                docNode.ImageUrl = ImageConstants.ACCOUNTS;
                                docNode.Expanded = false;

                                category.ChildNodes.Add(docNode);
                            }
                        }

                        #endregion
                    }
                }
            }

            #endregion
        }

        #endregion

        #region Events

        protected override void OnInit(EventArgs e)
        {
            BuildTree();
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