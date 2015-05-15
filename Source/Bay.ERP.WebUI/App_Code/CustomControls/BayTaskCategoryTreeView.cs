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
    [ToolboxData("<{0}:BayTaskCategoryTreeView runat=server></{0}:BayTaskCategoryTreeView>")]
    public class BayTaskCategoryTreeView : TreeView
    {
        #region Properties

        IList<BDMDTaskCategoryEntity> nodeList;
        IList<BDMDTaskCategoryEntity> subCategoryNodeList;

        ////[Bindable(true)]
        //[Category("Appearance")]
        //[DefaultValue(false)]
        //[Localizable(true)]
        //public Boolean ShowCheckBoxesInAllNodes
        //{
        //    get
        //    {
        //        return (Boolean)ViewState["BayItemCategoryTree_PROP_ShowCheckBoxesInAllNodes"];
        //    }

        //    set
        //    {
        //        ViewState["BayItemCategoryTree_PROP_ShowCheckBoxesInAllNodes"] = value;
        //    }
        //}

        #endregion

        #region Methods

        private void BuildTree()
        {
            this.Nodes.Clear();

            nodeList = FCCBDMDTaskCategory.GetFacadeCreate().GetIL(null, null, String.Empty, String.Empty, DatabaseOperationType.Load);

            TreeNode rootNode= new TreeNode();

            rootNode.Text = "Task Categories";
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
                                       where a.ParentTaskCategoryID == parentProjectDocumentCategoryID
                                        select a).ToList();

                if (subCategoryNodeList != null && subCategoryNodeList.Count > 0)
                {
                    foreach (BDMDTaskCategoryEntity ent in subCategoryNodeList)
                    {
                        TreeNode category = new TreeNode();

                        category.Text = ent.Name;
                        category.Value = ent.TaskCategoryID.ToString();
                        category.SelectAction = TreeNodeSelectAction.SelectExpand;
                        category.Expanded = false;

                        LoadCategories(category, ent.TaskCategoryID);
                        category.ImageUrl = ImageConstants.DOCUMENT_CATEGORY;
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