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
    [ToolboxData("<{0}:BayHREmployeeTreeView runat=server></{0}:BayHREmployeeTreeView>")]
    public class BayHREmployeeTreeView : TreeView
    {
        #region Properties

        IList<MDDepartmentEntity> departmentList;
        IList<MDDepartmentEntity> rootDepartmentList;
        IList<MDDesignationEntity> designationList;
        IList<ResourceEmployee_CustomEntity> employeeList;

        //[Bindable(true)]
        [Category("Appearance")]
        [DefaultValue(false)]
        [Localizable(true)]
        public Boolean ShowCheckBoxesInAllNodes
        {
            get
            {
                if (ViewState["BayHREmployeeTree_PROP_ShowCheckBoxesInAllNodes"] == null)
                {
                    return false;
                }

                return (Boolean)ViewState["BayHREmployeeTree_PROP_ShowCheckBoxesInAllNodes"];
            }

            set
            {
                ViewState["BayHREmployeeTree_PROP_ShowCheckBoxesInAllNodes"] = value;
            }
        }

        #endregion

        #region Methods

        private void BuildTree()
        {
            this.Nodes.Clear();

            departmentList = FCCMDDepartment.GetFacadeCreate().GetILFC();
            designationList = FCCMDDesignation.GetFacadeCreate().GetILFC();

            employeeList = FCCResourceEmployee_Custom.GetFacadeCreate().GetIL(1000000, 1, String.Empty, String.Empty);

            TreeNode rootNode = new TreeNode();

            rootNode.Text = "Employee Tree";
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

                        LoadDesignations(department);

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

                    LoadDesignations(childDepartment);

                    parentDepartment.ChildNodes.Add(childDepartment);
                }
            }
        }

        private void LoadDesignations(TreeNode department)
        {
            Int64 departmentID = Int64.Parse(department.Value);

            IList<MDDesignationEntity> tempDesignationList = (from a in designationList
                                                              where a.DepartmentID == departmentID
                                                              select a).ToList();


            if (tempDesignationList != null && tempDesignationList.Count > 0)
            {
                foreach (MDDesignationEntity ent in tempDesignationList)
                {
                    TreeNode designation = new TreeNode();

                    designation.Text = ent.Name;
                    designation.Value = ent.DesignationID.ToString();
                    designation.SelectAction = TreeNodeSelectAction.Select;
                    designation.ImageUrl = "~/Images/designation-16.png";

                    if (ShowCheckBoxesInAllNodes == true)
                    {
                        designation.ShowCheckBox = true;
                    }

                    LoadEmployees(designation);

                    department.ChildNodes.Add(designation);
                }
            }
        }

        private void LoadEmployees(TreeNode designation)
        {
            Int64 designationID = Int64.Parse(designation.Value);

            IList<ResourceEmployee_CustomEntity> tempEmployeeList = (from a in employeeList
                                                        where a.DesignationID == designationID
                                                              select a).ToList();


            if (tempEmployeeList != null && tempEmployeeList.Count > 0)
            {
                foreach (ResourceEmployee_CustomEntity ent in tempEmployeeList)
                {
                    TreeNode employee = new TreeNode();

                    employee.Text = ent.MemberFullName + " (" + ent.EmployeeCode + ")";
                    employee.Value = ent.ReferenceID.ToString();
                    employee.SelectAction = TreeNodeSelectAction.Select;
                    employee.ImageUrl = "~/Images/employee-16.png";

                    if (ShowCheckBoxesInAllNodes == true)
                    {
                        employee.ShowCheckBox = true;
                    }

                    designation.ChildNodes.Add(employee);
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