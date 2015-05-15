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
    [ToolboxData("<{0}:BayItemCategoryTreeView runat=server></{0}:BayItemCategoryTreeView>")]
    public class BayItemCategoryTreeView : TreeView
    {
        #region Properties

        IList<MDItemCategoryEntity> itemCategoryList;
        IList<MDItemCategoryEntity> rootItemCategoryList;

        //[Bindable(true)]
        [Category("Appearance")]
        [DefaultValue(false)]
        [Localizable(true)]
        public Boolean ShowCheckBoxesInAllNodes
        {
            get
            {
                return (Boolean)ViewState["BayItemCategoryTree_PROP_ShowCheckBoxesInAllNodes"];
            }

            set
            {
                ViewState["BayItemCategoryTree_PROP_ShowCheckBoxesInAllNodes"] = value;
            }
        }

        #endregion

        #region Methods

        private void BuildTree()
        {
            this.Nodes.Clear();

            itemCategoryList = FCCMDItemCategory.GetFacadeCreate().GetILFC();

            TreeNode rootNode= new TreeNode();

            rootNode.Text = "Item Categories";
            rootNode.Value = "0";
            rootNode.SelectAction = TreeNodeSelectAction.Select;
            rootNode.Expanded = true;

            LoadCategories(rootNode);

            this.Nodes.Add(rootNode);
        }

        private void LoadCategories(TreeNode parentCategory)
        {
            #region Load Main Categories

            if (itemCategoryList != null && itemCategoryList.Count > 0)
            {
                rootItemCategoryList = (from a in itemCategoryList
                                        where a.ParentItemCategoryID == null
                                        select a).ToList();

                if (rootItemCategoryList != null && rootItemCategoryList.Count > 0)
                {
                    foreach (MDItemCategoryEntity ent in rootItemCategoryList)
                    {
                        TreeNode category = new TreeNode();

                        category.Text = ent.CategoryName;
                        category.Value = ent.ItemCategoryID.ToString();
                        category.SelectAction = TreeNodeSelectAction.SelectExpand;
                        category.Expanded = false;

                        if (ShowCheckBoxesInAllNodes == true)
                        {
                            parentCategory.ShowCheckBox = true;
                        }

                        LoadSubCategories(category);

                        parentCategory.ChildNodes.Add(category);
                    }
                }
            }

            #endregion
        }

        private void LoadSubCategories(TreeNode parentCategory)
        {
            Int64 itemCategoryID = Int64.Parse(parentCategory.Value);

            IList<MDItemCategoryEntity> childItemCategoryList = FCCMDItemCategory.GetFacadeCreate().GetByParentCategoryILFC(itemCategoryID);

            if (childItemCategoryList != null && childItemCategoryList.Count > 0)
            {
                foreach (MDItemCategoryEntity ent in childItemCategoryList)
                {
                    TreeNode childItemCategory = new TreeNode();

                    childItemCategory.Text = ent.CategoryName;
                    childItemCategory.Value = ent.ItemCategoryID.ToString();
                    childItemCategory.SelectAction = TreeNodeSelectAction.Select;

                    if (ShowCheckBoxesInAllNodes == true)
                    {
                        childItemCategory.ShowCheckBox = true;
                    }

                    parentCategory.ChildNodes.Add(childItemCategory);
                }
            }
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

        //public void SetSelectedNode(Int64 parentItemCategoryID)
        //{
        //    foreach(TreeNode tn in this.Nodes)
        //    {
        //        SetSelectedNode(tn.Value)
        //    }

        //}

        //private void SetSelectedNode(Int64 parentItemCategoryID)
        //{

        //}



        #endregion
    }
}