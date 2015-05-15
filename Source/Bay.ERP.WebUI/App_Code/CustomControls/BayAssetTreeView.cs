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

namespace Bay.ERP.Web.UI
{
    [DefaultProperty("Text")]
    [ToolboxData("<{0}:BayAssetTreeView runat=server></{0}:BayAssetTreeView>")]
    public class BayAssetTreeView : TreeView
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
                return (Boolean)ViewState["BayAssetTreeView_PROP_ShowCheckBoxesInAllNodes"];
            }

            set
            {
                ViewState["BayAssetTreeView_PROP_ShowCheckBoxesInAllNodes"] = value;
            }
        }

        //[Bindable(true)]
        [Category("Appearance")]
        [DefaultValue(false)]
        [Localizable(true)]
        public Boolean ShowCheckedAtLastNode
        {
            get
            {
                return (Boolean)ViewState["BayAssetTreeView_PROP_ShowCheckedAtLastNode"];
            }

            set
            {
                ViewState["BayAssetTreeView_PROP_ShowCheckedAtLastNode"] = value;
            }
        }

        #endregion

        #region Methods

        private void BuildTree()
        {
            this.Nodes.Clear();

            assetCategoryList = FCCMDAssetCateogry.GetFacadeCreate().GetIL(null, null, String.Empty, String.Empty, DatabaseOperationType.Load);

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
                        TreeNode parentCategory = new TreeNode();

                        parentCategory.Text = ent.CategoryName;
                        parentCategory.Value = ent.AssetCateogryID.ToString();
                        parentCategory.SelectAction = TreeNodeSelectAction.Expand;
                        parentCategory.Expanded = false;

                        if (ShowCheckBoxesInAllNodes == true)
                        {
                           // parentCategory.ShowCheckBox = true;
                        }

                        LoadSubCategories(parentCategory);

                        this.Nodes.Add(parentCategory);
                    }
                }
            }

            #endregion
        }

        private void LoadSubCategories(TreeNode parentCategory)
        {
            Int64 assetCategoryID = Int64.Parse(parentCategory.Value);

            String fe = SqlExpressionBuilder.PrepareFilterExpression(MDAssetCateogryEntity.FLD_NAME_ParentAssetCateogryID, assetCategoryID.ToString(), SQLMatchType.Equal);
            IList<MDAssetCateogryEntity> childItemCategoryList = FCCMDAssetCateogry.GetFacadeCreate().GetIL(null, null, String.Empty, fe, DatabaseOperationType.LoadWithFilterExpression);

            if (childItemCategoryList != null && childItemCategoryList.Count > 0)
            {
                foreach (MDAssetCateogryEntity ent in childItemCategoryList)
                {
                    TreeNode childItemCategory = new TreeNode();

                    childItemCategory.Text = ent.CategoryName;
                    childItemCategory.Value = ent.AssetCateogryID.ToString();
                    childItemCategory.SelectAction = TreeNodeSelectAction.SelectExpand;

                    if (ShowCheckBoxesInAllNodes == true)
                    {
                       // childItemCategory.ShowCheckBox = true;
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
        
        protected override void OnSelectedNodeChanged(EventArgs e)
        {
            
            
            TreeNode selectedNode = this.SelectedNode;

            Int64 assetCategoryID = Int64.Parse(selectedNode.Value);

            switch (selectedNode.Depth)
            {
                case 0:
                    break;
                case 1:
                    if (selectedNode.ChildNodes.Count <= 0)
                    {
                        String fe = SqlExpressionBuilder.PrepareFilterExpression(MDAssetEntity.FLD_NAME_AssetCateogryID, assetCategoryID.ToString(), SQLMatchType.Equal);
                        IList<MDAssetEntity> assetList = FCCMDAsset.GetFacadeCreate().GetIL(null,null,String.Empty,fe,DatabaseOperationType.LoadWithFilterExpression);

                        if (assetList != null && assetList.Count > 0)
                        {
                            foreach (MDAssetEntity ent in assetList)
                            {
                                TreeNode childItemCategory = new TreeNode();

                                childItemCategory.Text = ent.AssetName;
                                childItemCategory.Value = ent.AssetID.ToString();
                                childItemCategory.SelectAction = TreeNodeSelectAction.Select;

                                if (ShowCheckBoxesInAllNodes == true)
                                {
                                    childItemCategory.ShowCheckBox = true;
                                    if (ShowCheckedAtLastNode == true)
                                    {
                                        childItemCategory.Checked = true;
                                    }
                                }
                             selectedNode.ChildNodes.Add(childItemCategory);
                            }
                        }
                    }
                    break;
                case 2:
                    break;
                default:
                    break;
            }

            base.OnSelectedNodeChanged(e);
        }

        public void ReBuildTree()
        {
            BuildTree();
        }

        #endregion
    }
}