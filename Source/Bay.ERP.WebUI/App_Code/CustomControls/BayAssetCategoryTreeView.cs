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
    [ToolboxData("<{0}:BayAssetCategoryTreeView runat=server></{0}:BayAssetCategoryTreeView>")]
    public class BayAssetCategoryTreeView : TreeView
    {
        #region Properties

        IList<MDAssetCateogryEntity> assetCategoryList;
        IList<MDAssetCateogryEntity> rootAssetCategoryList;

        //[Bindable(true)]
        [Category("Appearance")]
        [DefaultValue(false)]
        [Localizable(true)]
        public Boolean ShowCheckBoxesInAllNodes
        {
            get
            {
                return (Boolean)ViewState["BayAssetCategoryTree_PROP_ShowCheckBoxesInAllNodes"];
            }

            set
            {
                ViewState["BayAssetCategoryTree_PROP_ShowCheckBoxesInAllNodes"] = value;
            }
        }

        #endregion

        #region Methods

        private void BuildTree()
        {
            this.Nodes.Clear();

            assetCategoryList = FCCMDAssetCateogry.GetFacadeCreate().GetIL(null, null, String.Empty, String.Empty, DatabaseOperationType.Load);

            TreeNode rootNode= new TreeNode();

            rootNode.Text = "Asset Categories";
            rootNode.Value = "0";
            rootNode.SelectAction = TreeNodeSelectAction.Select;
            rootNode.Expanded = true;

            LoadCategories(rootNode);

            this.Nodes.Add(rootNode);
        }

        private void LoadCategories(TreeNode parentCategory)
        {
            #region Load Main Categories

            if (assetCategoryList != null && assetCategoryList.Count > 0)
            {
                rootAssetCategoryList = (from a in assetCategoryList
                                        where a.ParentAssetCateogryID == null
                                        select a).ToList();

                if (rootAssetCategoryList != null && rootAssetCategoryList.Count > 0)
                {
                    foreach (MDAssetCateogryEntity ent in rootAssetCategoryList)
                    {
                        TreeNode category = new TreeNode();

                        category.Text = ent.CategoryName;
                        category.Value = ent.AssetCateogryID.ToString();
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
            Int64 assetCategoryID = Int64.Parse(parentCategory.Value);

            String fe = SqlExpressionBuilder.PrepareFilterExpression(MDAssetCateogryEntity.FLD_NAME_ParentAssetCateogryID, assetCategoryID.ToString(), SQLMatchType.Equal);
            IList<MDAssetCateogryEntity> childItemCategoryList = FCCMDAssetCateogry.GetFacadeCreate().GetIL(null,null,String.Empty,fe,DatabaseOperationType.LoadWithFilterExpression);

            if (childItemCategoryList != null && childItemCategoryList.Count > 0)
            {
                foreach (MDAssetCateogryEntity ent in childItemCategoryList)
                {
                    TreeNode childItemCategory = new TreeNode();

                    childItemCategory.Text = ent.CategoryName;
                    childItemCategory.Value = ent.AssetCateogryID.ToString();
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