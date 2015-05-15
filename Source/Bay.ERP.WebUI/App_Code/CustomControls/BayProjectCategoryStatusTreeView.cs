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
    [ToolboxData("<{0}:BayProjectCategoryStatusTreeView runat=server></{0}:BayProjectCategoryStatusTreeView>")]
    public class BayProjectCategoryStatusTreeView : TreeView
    {
        #region Properties

        IList<MDProjectCategoryEntity> projectCategoryList;

        //[Bindable(true)]
        [Category("Appearance")]
        [DefaultValue(false)]
        [Localizable(true)]
        public Boolean ShowCheckBoxesInAllNodes
        {
            get
            {
                return (Boolean)ViewState["BayProjectCategoryStatusTree_PROP_ShowCheckBoxesInAllNodes"];
            }

            set
            {
                ViewState["BayProjectCategoryStatusTree_PROP_ShowCheckBoxesInAllNodes"] = value;
            }
        }

        #endregion

        #region Methods

        private void BuildTree()
        {
            this.Nodes.Clear();

            projectCategoryList = FCCMDProjectCategory.GetFacadeCreate().GetIL(null, null, String.Empty, String.Empty, DatabaseOperationType.Load);

            TreeNode rootNode= new TreeNode();

            rootNode.Text = "Project Category Status Tree";
            rootNode.Value = "0";
            rootNode.SelectAction = TreeNodeSelectAction.Expand;
            rootNode.Expanded = true;

            LoadCategories(rootNode);

            this.Nodes.Add(rootNode);
        }

        private void LoadCategories(TreeNode parentCategory)
        {
            #region Load Main Categories

            if (projectCategoryList != null && projectCategoryList.Count > 0)
            {

                foreach (MDProjectCategoryEntity ent in projectCategoryList)
                {
                        TreeNode category = new TreeNode();

                        category.Text = ent.Name;
                        category.Value = ent.ProjectCategoryID.ToString();
                        category.SelectAction = TreeNodeSelectAction.Expand;
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
            Int64 ProjectCategoryID = Int64.Parse(parentCategory.Value);

            String fe = SqlExpressionBuilder.PrepareFilterExpression("BDProject." + BDProjectStatusDistinct_CustomEntity.FLD_NAME_ProjectCategoryID, ProjectCategoryID.ToString(), SQLMatchType.Equal);
            IList<BDProjectStatusDistinct_CustomEntity> ProjectStatusList = FCCBDProjectStatusDistinct_Custom.GetFacadeCreate().GetIL(fe);

            if (ProjectStatusList != null && ProjectStatusList.Count > 0)
            {
                foreach (BDProjectStatusDistinct_CustomEntity ent in ProjectStatusList)
                {
                    TreeNode childCategory = new TreeNode();

                    childCategory.Text = ent.ProjectStatusName;
                    childCategory.Value = ent.ProjectStatusID.ToString();
                    childCategory.SelectAction = TreeNodeSelectAction.Expand;
                    childCategory.Expanded = false;

                    parentCategory.ChildNodes.Add(childCategory);

                    String fe1 = SqlExpressionBuilder.PrepareFilterExpression("BDProject." + BDProject_CustomEntity.FLD_NAME_ProjectCategoryID, ProjectCategoryID.ToString(), SQLMatchType.Equal);
                    String fe2 = SqlExpressionBuilder.PrepareFilterExpression("BDProject." + BDProject_CustomEntity.FLD_NAME_ProjectStatusID, ent.ProjectStatusID.ToString(), SQLMatchType.Equal);

                    String fiterExpression = SqlExpressionBuilder.PrepareFilterExpression(fe1, SQLJoinType.AND, fe2);
                    IList<BDProject_CustomEntity> childList = FCCBDProject_Custom.GetFacadeCreate().GetIL(fiterExpression);

                    foreach (BDProject_CustomEntity entBDProject in childList)
                    {
                        TreeNode child = new TreeNode();
                        child.Text = entBDProject.ProjectName;
                        child.Value = entBDProject.ProjectID.ToString();
                        child.SelectAction = TreeNodeSelectAction.Select;
                        childCategory.ChildNodes.Add(child);
                    }
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