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
    [ToolboxData("<{0}:BayHRDesignationTreeView runat=server></{0}:BayHRDesignationTreeView>")]
    public class BayHRDesignationTreeView : TreeView
    {
        #region Properties

        IList<MDDepartmentEntity> departmentList;
        IList<MDDepartmentEntity> rootDepartmentList;
        IList<MDDesignationEntity> designationList;

        //[Bindable(true)]
        [Category("Appearance")]
        [DefaultValue(false)]
        [Localizable(true)]
        public Boolean ShowCheckBoxesInAllNodes
        {
            get
            {
                if (ViewState["BayHRDesignationTree_PROP_ShowCheckBoxesInAllNodes"] == null)
                {
                    return false;
                }

                return (Boolean)ViewState["BayHRDesignationTree_PROP_ShowCheckBoxesInAllNodes"];
            }

            set
            {
                ViewState["BayHRDesignationTree_PROP_ShowCheckBoxesInAllNodes"] = value;
            }
        }

        #endregion

        #region Methods

        private void BuildTree()
        {
            this.Nodes.Clear();

            departmentList = FCCMDDepartment.GetFacadeCreate().GetILFC();
            designationList = FCCMDDesignation.GetFacadeCreate().GetILFC();
            
            BayTreeNodeValue rootNodeValue = new BayTreeNodeValue();
            rootNodeValue.Value = "0";
            rootNodeValue.Attributes["NodeType"] = CustomControlConstants.HRNodeType.RootNode;

            TreeNode rootNode = new TreeNode();

            rootNode.Text = "Designation Tree";
            rootNode.Value = rootNodeValue.GetValueString();
            rootNode.SelectAction = TreeNodeSelectAction.None;
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
                        BayTreeNodeValue departmentNodeValue = new BayTreeNodeValue();
                        departmentNodeValue.Value = ent.DepartmentID.ToString();
                        departmentNodeValue.Attributes["NodeType"] = CustomControlConstants.HRNodeType.Department;


                        TreeNode department = new TreeNode();

                        department.Text = ent.Name;
                        department.Value = departmentNodeValue.GetValueString();
                        department.SelectAction = TreeNodeSelectAction.Select;
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
            Int64 departmentID = Int64.Parse(BayTreeNodeValue.GetValue(parentDepartment.Value));

            IList<MDDepartmentEntity> childDepartmentList = FCCMDDepartment.GetFacadeCreate().GetByParentDepartmentILFC(departmentID);

            if (childDepartmentList != null && childDepartmentList.Count > 0)
            {
                foreach (MDDepartmentEntity ent in childDepartmentList)
                {
                    BayTreeNodeValue childDepartmentNodeValue = new BayTreeNodeValue();
                    childDepartmentNodeValue.Value = ent.DepartmentID.ToString();
                    childDepartmentNodeValue.Attributes["NodeType"] = CustomControlConstants.HRNodeType.Department;

                    TreeNode childDepartment = new TreeNode();

                    childDepartment.Text = ent.Name;
                    childDepartment.Value = childDepartmentNodeValue.GetValueString();
                    childDepartment.SelectAction = TreeNodeSelectAction.Select;
                    childDepartment.ImageUrl = "~/Images/department-16.png";
                    childDepartment.Expanded = false;

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
            Int64 departmentID = Int64.Parse(BayTreeNodeValue.GetValue(department.Value));

            IList<MDDesignationEntity> tempDesignationList = (from a in designationList
                                                              where a.DepartmentID == departmentID
                                                              select a).ToList();


            if (tempDesignationList != null && tempDesignationList.Count > 0)
            {
                foreach (MDDesignationEntity ent in tempDesignationList)
                {
                    BayTreeNodeValue designationNodeValue = new BayTreeNodeValue();
                    designationNodeValue.Value = ent.DesignationID.ToString();
                    designationNodeValue.Attributes["NodeType"] = CustomControlConstants.HRNodeType.Designation;

                    TreeNode designation = new TreeNode();

                    designation.Text = ent.Name;
                    designation.Value = designationNodeValue.GetValueString();
                    designation.SelectAction = TreeNodeSelectAction.Select;
                    designation.ImageUrl = "~/Images/designation-16.png";
                    designation.Expanded = false;

                    if (ShowCheckBoxesInAllNodes == true)
                    {
                        designation.ShowCheckBox = true;
                    }

                    department.ChildNodes.Add(designation);
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