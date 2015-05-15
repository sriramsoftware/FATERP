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
using System.Data;

namespace Bay.ERP.Web.UI
{
    [DefaultProperty("Text")]
    [ToolboxData("<{0}:BayRequistionItemTreeView runat=server></{0}:BayRequistionItemTreeView>")]
    public class BayRequistionItemTreeView : TreeView
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
                return (Boolean)ViewState["BayRequistionItemTreeView_PROP_ShowCheckBoxesInAllNodes"];
            }

            set
            {
                ViewState["BayRequistionItemTreeView_PROP_ShowCheckBoxesInAllNodes"] = value;
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
                return (Boolean)ViewState["BayRequistionItemTreeView_PROP_ShowCheckedAtLastNode"];
            }

            set
            {
                ViewState["BayRequistionItemTreeView_PROP_ShowCheckedAtLastNode"] = value;
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
                return (Int64)ViewState["BayRequistionItemTreeView_PROP_ProjectID"];
            }

            set
            {
                ViewState["BayRequistionItemTreeView_PROP_ProjectID"] = value;
            }
        }

        #endregion

        #region Methods

        private void BuildTree()
        {
            this.Nodes.Clear();

            itemCategoryList = FCCMDItemCategory.GetFacadeCreate().GetILFC();

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
                        TreeNode parentCategory = new TreeNode();

                        parentCategory.Text = ent.CategoryName;
                        parentCategory.Value = ent.ItemCategoryID.ToString();
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
            Int64 itemCategoryID = Int64.Parse(parentCategory.Value);

            IList<MDItemCategoryEntity> childItemCategoryList = FCCMDItemCategory.GetFacadeCreate().GetByParentCategoryILFC(itemCategoryID);

            if (childItemCategoryList != null && childItemCategoryList.Count > 0)
            {
                foreach (MDItemCategoryEntity ent in childItemCategoryList)
                {
                    TreeNode childItemCategory = new TreeNode();

                    childItemCategory.Text = ent.CategoryName;
                    childItemCategory.Value = ent.ItemCategoryID.ToString();
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

            Int64 itemCategoryID = Int64.Parse(selectedNode.Value);

            switch (selectedNode.Depth)
            {
                case 0:
                    break;
                case 1:

                    String fe = SqlExpressionBuilder.PrepareFilterExpression(PRMPreBOQEntity.FLD_NAME_ProjectID,ProjectID.ToString(),SQLMatchType.Equal);
                    IList<PRMPreBOQEntity> lstPreBOQ = FCCPRMPreBOQ.GetFacadeCreate().GetIL(null, null, String.Empty, fe, DatabaseOperationType.LoadWithFilterExpression);

                    if (lstPreBOQ != null && lstPreBOQ.Count > 0)
                    {
                        switch (lstPreBOQ[0].IsLocked)
                        {
                            case true:

                                #region Get Item From BOQ/Project Cost

                                if (selectedNode.ChildNodes.Count <= 0)
                                {

                                    IList<PRMBOQRequisitionItem_CustomEntity> itemList = FCCPRMBOQRequisitionItem_Custom.GetFacadeCreate().GetIL(ProjectID, itemCategoryID);
                                    //IList<MDItemEntity> itemList = FCCMDItem.GetFacadeCreate().GetByCategoryIDILFC(itemCategoryID);

                                    if (itemList != null && itemList.Count > 0)
                                    {
                                        foreach (PRMBOQRequisitionItem_CustomEntity ent in itemList)
                                        {
                                            TreeNode childItemCategory = new TreeNode();

                                            childItemCategory.Text = ent.MDItemItemName;
                                            childItemCategory.Value = ent.ItemID.ToString();
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

                                #endregion

                                break;
                            case false:

                                #region Get Item From Pre BOQ/ BOQ

                                if (selectedNode.ChildNodes.Count <= 0)
                                {

                                    IList<PRMPreBOQRequisitionItem_CustomEntity> itemList = FCCPRMPreBOQRequisitionItem_Custom.GetFacadeCreate().GetIL(ProjectID, itemCategoryID);
                                    //IList<MDItemEntity> itemList = FCCMDItem.GetFacadeCreate().GetByCategoryIDILFC(itemCategoryID);

                                    if (itemList != null && itemList.Count > 0)
                                    {
                                        foreach (PRMPreBOQRequisitionItem_CustomEntity ent in itemList)
                                        {
                                            TreeNode childItemCategory = new TreeNode();

                                            childItemCategory.Text = ent.MDItemItemName;
                                            childItemCategory.Value = ent.ItemID.ToString();
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

                                #endregion

                                break;
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