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
    [ToolboxData("<{0}:BayHRDepartmentTreeView runat=server></{0}:BayHRDepartmentTreeView>")]
    public class BayHRDepartmentTreeView : TreeView
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
                if (ViewState["BayHRDepartmentTree_PROP_ShowCheckBoxesInAllNodes"] == null)
                {
                    return false;
                }

                return (Boolean)ViewState["BayHRDepartmentTree_PROP_ShowCheckBoxesInAllNodes"];
            }

            set
            {
                ViewState["BayHRDepartmentTree_PROP_ShowCheckBoxesInAllNodes"] = value;
            }
        }

        #endregion

        #region Methods

        private void BuildTree()
        {
            this.Nodes.Clear();

            departmentList = FCCMDDepartment.GetFacadeCreate().GetILFC();

            TreeNode rootNode= new TreeNode();

            rootNode.Text = "Department Tree";
            rootNode.Value = "0";
            rootNode.SelectAction = TreeNodeSelectAction.Select;
            rootNode.Expanded = true;

            LoadDepartments(rootNode);

            this.Nodes.Add(rootNode);
        }

        private void LoadDepartments(TreeNode parentDepartment)
        {
            #region Load Main Departments

            if (departmentList != null && departmentList.Count > 0)
            {
                rootDepartmentList = (from a in departmentList
                                        where a.ParentDepartmentID == null
                                        select a).ToList();

                if (rootDepartmentList != null && rootDepartmentList.Count > 0)
                {
                    foreach (MDDepartmentEntity ent in rootDepartmentList)
                    {
                        TreeNode department = new TreeNode();

                        department.Text = ent.Name;
                        department.Value = ent.DepartmentID.ToString();
                        department.SelectAction = TreeNodeSelectAction.SelectExpand;
                        department.Expanded = false;
                        department.ImageUrl = "~/Images/department-16.png";

                        if (ShowCheckBoxesInAllNodes == true)
                        {
                            parentDepartment.ShowCheckBox = true;
                        }

                        LoadSubDepartments(department);

                        parentDepartment.ChildNodes.Add(department);
                    }
                }
            }

            #endregion
        }

        private void LoadSubDepartments(TreeNode parentDepartment)
        {
            Int64 departmentID = Int64.Parse(parentDepartment.Value);

            IList<MDDepartmentEntity> childDepartmentList = FCCMDDepartment.GetFacadeCreate().GetByParentDepartmentILFC(departmentID);

            if (childDepartmentList != null && childDepartmentList.Count > 0)
            {
                foreach (MDDepartmentEntity ent in childDepartmentList)
                {
                    TreeNode childDepartment = new TreeNode();

                    childDepartment.Text = ent.Name;
                    childDepartment.Value = ent.DepartmentID.ToString();
                    childDepartment.SelectAction = TreeNodeSelectAction.Select;
                    childDepartment.ImageUrl = "~/Images/department-16.png";

                    if (ShowCheckBoxesInAllNodes == true)
                    {
                        childDepartment.ShowCheckBox = true;
                    }

                    LoadSubDepartments(childDepartment);

                    parentDepartment.ChildNodes.Add(childDepartment);
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