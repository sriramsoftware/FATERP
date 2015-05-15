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
    [ToolboxData("<{0}:BayDesignationTreeView runat=server></{0}:BayDesignationTreeView>")]
    public class BayDesignationTreeView : TreeView
    {
        #region Properties

        IList<MDDepartmentEntity> departmentList;
        IList<MDDepartmentEntity> rootDepartmentList;

        //[Bindable(true)]
        [Category("Appearance")]
        [DefaultValue(false)]
        [Localizable(true)]
        public Boolean ShowCheckBoxesInAllNodes
        {
            get
            {
                return (Boolean)ViewState["BayDesignationTreeView_PROP_ShowCheckBoxesInAllNodes"];
            }

            set
            {
                ViewState["BayDesignationTreeView_PROP_ShowCheckBoxesInAllNodes"] = value;
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
                return (Boolean)ViewState["BayDesignationTreeView_PROP_ShowCheckedAtLastNode"];
            }

            set
            {
                ViewState["BayDesignationTreeView_PROP_ShowCheckedAtLastNode"] = value;
            }
        }

        //[Bindable(true)]
        [Category("Appearance")]
        [DefaultValue(false)]
        [Localizable(true)]
        public Boolean ShowCheckBoxAtLastNode
        {
            get
            {
                return (Boolean)ViewState["BayDesignationTreeView_PROP_ShowCheckBoxAtLastNode"];
            }

            set
            {
                ViewState["BayDesignationTreeView_PROP_ShowCheckBoxAtLastNode"] = value;
            }
        }

        #endregion

        #region Methods

        private void BuildTree()
        {
            this.Nodes.Clear();

            departmentList = FCCMDDepartment.GetFacadeCreate().GetIL(null, null, String.Empty, String.Empty, DatabaseOperationType.Load);

            TreeNode rootNode = new TreeNode();

            rootNode.Text = "Designation Tree";
            rootNode.Value = "0";
            rootNode.SelectAction = TreeNodeSelectAction.Select;
            rootNode.Expanded = true;

            LoadCategories(rootNode);

            this.Nodes.Add(rootNode);
        }

        private void LoadCategories(TreeNode parentCategory)
        {
            #region Load Main Categories

            if (departmentList != null && departmentList.Count > 0)
            {
                rootDepartmentList = (from a in departmentList
                                      where a.ParentDepartmentID == null
                                      select a).ToList();

                if (rootDepartmentList != null && rootDepartmentList.Count > 0)
                {
                    foreach (MDDepartmentEntity ent in rootDepartmentList)
                    {
                        TreeNode category = new TreeNode();

                        category.Text = ent.Name;
                        category.Value = ent.DepartmentID.ToString();
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
            Int64 departmentID = Int64.Parse(parentCategory.Value);

            String fe = SqlExpressionBuilder.PrepareFilterExpression(MDDesignationEntity.FLD_NAME_DepartmentID, departmentID.ToString(), SQLMatchType.Equal);
            IList<MDDesignationEntity> childItemCategoryList = FCCMDDesignation.GetFacadeCreate().GetIL(null, null, String.Empty, fe, DatabaseOperationType.LoadWithFilterExpression);

            if (childItemCategoryList != null && childItemCategoryList.Count > 0)
            {
                foreach (MDDesignationEntity ent in childItemCategoryList)
                {
                    TreeNode childItemCategory = new TreeNode();

                    childItemCategory.Text = ent.Name;
                    childItemCategory.Value = ent.DesignationID.ToString();
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

        #endregion
    }
}