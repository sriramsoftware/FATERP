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
    [ToolboxData("<{0}:BayBrandItemMapTreeView runat=server></{0}:BayBrandItemMapTreeView>")]
    public class BayBrandItemMapTreeView : TreeView
    {
        #region Properties

        IList<PRMItemBrandMapDistinct_CustomEntity> brandItemList;

        //[Bindable(true)]
        [Category("Appearance")]
        [DefaultValue(false)]
        [Localizable(true)]
        public Boolean ShowCheckBoxesInAllNodes
        {
            get
            {
                return (Boolean)ViewState["BayBrandItemMapTree_PROP_ShowCheckBoxesInAllNodes"];
            }

            set
            {
                ViewState["BayBrandItemMapTree_PROP_ShowCheckBoxesInAllNodes"] = value;
            }
        }

        //[Bindable(true)]
        [Category("Appearance")]
        [DefaultValue(false)]
        [Localizable(true)]
        public Int64 SupplierID
        {
            get
            {
                return (Int64)ViewState["BayBrandItemMapTree_PROP_SupplierID"];
            }

            set
            {
                ViewState["BayBrandItemMapTree_PROP_SupplierID"] = value;
            }
        }

        #endregion

        #region Methods

        private void BuildTree()
        {
            this.Nodes.Clear();

            brandItemList = FCCPRMItemBrandMapDistinct_Custom.GetFacadeCreate().GetIL(SupplierID);

            TreeNode rootNode= new TreeNode();

            rootNode.Text = "Brand Item Map Tree";
            rootNode.Value = "0";
            rootNode.SelectAction = TreeNodeSelectAction.Select;
            rootNode.Expanded = true;

            LoadCategories(rootNode);

            this.Nodes.Add(rootNode);
        }

        private void LoadCategories(TreeNode parentCategory)
        {
            #region Load Main Categories

            if (brandItemList != null && brandItemList.Count > 0)
            {

                foreach (PRMItemBrandMapDistinct_CustomEntity ent in brandItemList)
                {
                        TreeNode category = new TreeNode();

                        category.Text = ent.BrandName;
                        category.Value = ent.BrandID.ToString();
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

            #endregion
        }

        private void LoadSubCategories(TreeNode parentCategory)
        {
            Int64 BrandID = Int64.Parse(parentCategory.Value);

            String fe = SqlExpressionBuilder.PrepareFilterExpression("PRMItemBrandMap." + PRMItemBrandMap_CustomEntity.FLD_NAME_BrandID, BrandID.ToString(), SQLMatchType.Equal);
            IList<PRMItemBrandMap_CustomEntity> childItemCategoryList = FCCPRMItemBrandMap_Custom.GetFacadeCreate().GetIL(fe);

            if (childItemCategoryList != null && childItemCategoryList.Count > 0)
            {
                foreach (PRMItemBrandMap_CustomEntity ent in childItemCategoryList)
                {
                    TreeNode childItemCategory = new TreeNode();

                    if (ent.ItemName.Length >= 60)
                    {
                        childItemCategory.Text = ent.ItemName.Substring(0, Math.Min(ent.ItemName.Length, 58));
                    }
                    else
                    {
                        childItemCategory.Text = ent.ItemName;
                    }
                    childItemCategory.Value = ent.ItemID.ToString();
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