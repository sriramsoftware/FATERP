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
    [ToolboxData("<{0}:BayConstructionToolTreeView runat=server></{0}:BayConstructionToolTreeView>")]
    public class BayConstructionToolTreeView : TreeView
    {
        #region Properties

        IList<CMConstructionToolEntity> nodeList;
        IList<CMConstructionToolEntity> mainCategoryList;
        IList<CMConstructionToolDetailEntity> toolDetailList;

        //[Bindable(true)]
        [Category("Appearance")]
        [DefaultValue(false)]
        [Localizable(true)]
        public Boolean ShowCheckBoxesInAllNodes
        {
            get
            {
                return (Boolean)ViewState["BayConstructionToolTreeView_PROP_ShowCheckBoxesInDocumentNodes"];
            }

            set
            {
                ViewState["BayConstructionToolTreeView_PROP_ShowCheckBoxesInDocumentNodes"] = value;
            }
        }

        //[Bindable(true)]
        [Category("Appearance")]
        [DefaultValue("Project Documents")]
        [Localizable(true)]
        public String RootNodeText
        {
            get
            {
                return (String)ViewState["BayConstructionToolTreeView_PROP_RootNodeText"];
            }

            set
            {
                ViewState["BayConstructionToolTreeView_PROP_RootNodeText"] = value;
            }
        }

        #endregion

        public BayConstructionToolTreeView()
        {
            this.ShowCheckBoxesInAllNodes = false;
            this.RootNodeText = "Construction Tool";
        }

        #region Methods

        private void PopulateTree()
        {
            this.Nodes.Clear();

            nodeList = FCCCMConstructionTool.GetFacadeCreate().GetIL(null, null, String.Empty, String.Empty, DatabaseOperationType.Load);
            toolDetailList = FCCCMConstructionToolDetail.GetFacadeCreate().GetIL(null, null, String.Empty, String.Empty, DatabaseOperationType.Load);

            TreeNode rootNode= new TreeNode();

            rootNode.Text = RootNodeText;
            rootNode.Value ="0";
            rootNode.SelectAction = TreeNodeSelectAction.Expand;
            rootNode.Expanded = true;
            LoadCategories(rootNode);

            this.Nodes.Add(rootNode);
        }

        private void LoadCategories(TreeNode parentCategory)
        {
            #region Load Main Categories

            Int64 ParentCategory = Int64.Parse(parentCategory.Value.ToString());
            if (nodeList != null && nodeList.Count > 0)
            {
                foreach (CMConstructionToolEntity ent in nodeList)
                {
                    TreeNode category = new TreeNode();

                    category.Text = ent.ToolName;
                    category.Value = ent.ConstructionToolID.ToString();
                    category.ImageUrl = "~/Images/Document/Foldere.png";
                    category.SelectAction = TreeNodeSelectAction.Expand;
                    category.Expanded = false;

                    LoadSubCategories(category);

                    parentCategory.ChildNodes.Add(category);
                }
            }

            #endregion
        }

        private void LoadSubCategories(TreeNode parentCategory)
        {
            Int64 CategoryID = Int64.Parse(parentCategory.Value);

            if (toolDetailList != null && toolDetailList.Count > 0)
            {
                IList<CMConstructionToolDetailEntity> childItemCategoryList = (from s in toolDetailList
                                                                               where s.ConstructionToolID == CategoryID
                                                                               select s).ToList();

                if (childItemCategoryList != null && childItemCategoryList.Count > 0)
                {
                    foreach (CMConstructionToolDetailEntity ent in childItemCategoryList)
                    {
                        TreeNode childConstructionTool = new TreeNode();

                        childConstructionTool.Text = ent.Specification;
                        childConstructionTool.Value = ent.ConstructionToolDetailID.ToString();
                        childConstructionTool.ImageUrl = "~/Images/Document/Document.png";
                        childConstructionTool.SelectAction = TreeNodeSelectAction.None;

                        if (ShowCheckBoxesInAllNodes == true)
                        {
                            childConstructionTool.ShowCheckBox = true;
                        }

                        parentCategory.ChildNodes.Add(childConstructionTool);
                    }
                }
            }
        }

        public void BuildTree()
        {
            PopulateTree();
        }

        public void ReBuildTree()
        {
            PopulateTree();
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

        #endregion
    }
}