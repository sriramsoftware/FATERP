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
    [ToolboxData("<{0}:BayProjectDocumentTreeView runat=server></{0}:BayProjectDocumentTreeView>")]
    public class BayProjectDocumentTreeView : TreeView
    {
        #region Properties

        IList<MDProjectDocumentCategoryEntity> nodeList;
        IList<MDProjectDocumentCategoryEntity> subCategoryNodeList;
        IList<MDProjectDocumentEntity> documentList;
        IList<MDProjectDocumentEntity> catDocumentList;

      //  public Int64 ProjectID = 0;
        IList<BDProjectCollectedDocumentInfoEntity> projectDocumentList;

        //[Bindable(true)]
        [Category("Appearance")]
        [DefaultValue(false)]
        [Localizable(true)]
        public Boolean ShowCheckBoxesInDocumentNodes
        {
            get
            {
                return (Boolean)ViewState["BayProjectDocumentTreeView_PROP_ShowCheckBoxesInDocumentNodes"];
            }

            set
            {
                ViewState["BayProjectDocumentTreeView_PROP_ShowCheckBoxesInDocumentNodes"] = value;
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
                return (String)ViewState["BayProjectDocumentTreeView_PROP_RootNodeText"];
            }

            set
            {
                ViewState["BayProjectDocumentTreeView_PROP_RootNodeText"] = value;
            }
        }

        //[Bindable(true)]
        [Category("Appearance")]
        [DefaultValue(0)]
        [Localizable(true)]
        public Int64 ProjectID
        {
            get
            {
                return (Int64)ViewState["BayProjectDocumentTree_PROP_ProjectID"];
            }

            set
            {
                ViewState["BayProjectDocumentTree_PROP_ProjectID"] = value;
            }
        }

        #endregion



        public BayProjectDocumentTreeView()
        {
            this.ShowCheckBoxesInDocumentNodes = false;
            this.RootNodeText = "Project Documents";
        }

        #region Methods

        private void PopulateTree()
        {
            this.Nodes.Clear();

            nodeList = FCCMDProjectDocumentCategory.GetFacadeCreate().GetIL(null, null, String.Empty, String.Empty, DatabaseOperationType.Load);
            documentList = FCCMDProjectDocument.GetFacadeCreate().GetIL(null, null, String.Empty, String.Empty, DatabaseOperationType.Load);
            if (ProjectID > 0)
            {
                String fe_Project_Document = SqlExpressionBuilder.PrepareFilterExpression(BDProjectCollectedDocumentInfoEntity.FLD_NAME_ProjectID, ProjectID.ToString(), SQLMatchType.Equal);
                projectDocumentList = FCCBDProjectCollectedDocumentInfo.GetFacadeCreate().GetIL(null, null, String.Empty, fe_Project_Document, DatabaseOperationType.LoadWithFilterExpression);
            }
          
            TreeNode rootNode= new TreeNode();

            BayTreeNodeValue rootNodeValue = new BayTreeNodeValue();
            rootNodeValue.Value = "0";
            rootNodeValue.Attributes["NodeType"] = CustomControlConstants.DocumentNodeType.RootNode;

            rootNode.Text = RootNodeText;
            rootNode.Value = rootNodeValue.GetValueString();
            rootNode.SelectAction = TreeNodeSelectAction.Expand;
            rootNode.Expanded = true;
            LoadCategories(rootNode, null);

            this.Nodes.Add(rootNode);
        }

        private void LoadCategories(TreeNode parentNode, Int64? parentProjectDocumentCategoryID)
        {
            #region Load Main Categories

            if (ProjectID > 0 && projectDocumentList == null)
            {
                return;
            }

            if (nodeList != null && nodeList.Count > 0)
            {
                subCategoryNodeList = (from a in nodeList
                                       where a.ParentProjectDocumentCategoryID == parentProjectDocumentCategoryID
                                        select a).ToList();

                if (subCategoryNodeList != null && subCategoryNodeList.Count > 0)
                {
                    foreach (MDProjectDocumentCategoryEntity ent in subCategoryNodeList)
                    {
                        TreeNode category = new TreeNode();

                        BayTreeNodeValue categoryNodeValue = new BayTreeNodeValue();
                        categoryNodeValue.Value = ent.ProjectDocumentCategoryID.ToString();
                        categoryNodeValue.Attributes["NodeType"] = CustomControlConstants.DocumentNodeType.DocumentCategory;
                        category.ImageUrl = ImageConstants.DOCUMENT_CATEGORY;
                        category.Text = ent.Name;
                        category.Value = categoryNodeValue.GetValueString();
                        category.SelectAction = TreeNodeSelectAction.SelectExpand;
                        category.Expanded = false;                        

                        LoadCategories(category, ent.ProjectDocumentCategoryID);

                        #region Loading the Documents

                        if (documentList != null && documentList.Count > 0)
                        {
                            catDocumentList = (from d in documentList
                                               where d.ProjectDocumentCategoryID == ent.ProjectDocumentCategoryID
                                               select d).ToList();

                            #region If Project Id is setup, the list will be filtered by the project id

                            if (ProjectID > 0)
                            {
                                IList<MDProjectDocumentEntity> felteredDocumentList = new List<MDProjectDocumentEntity>();
                                if (projectDocumentList != null && projectDocumentList.Count > 0)
                                {

                                    foreach (BDProjectCollectedDocumentInfoEntity proDocEnt in projectDocumentList)
                                    {
                                        IList<MDProjectDocumentEntity> tempCatDocumentList = (from pd in catDocumentList
                                                                                              where pd.ProjectDocumentID == proDocEnt.ProjectDocumentID
                                                                                              select pd).ToList();
                                        if (tempCatDocumentList != null && tempCatDocumentList.Count > 0)
                                        {
                                            foreach (MDProjectDocumentEntity tempDocEnt in tempCatDocumentList)
                                            {
                                                felteredDocumentList.Add(tempDocEnt);
                                            }
                                        }
                                    }

                                    catDocumentList = felteredDocumentList;
                                }
                            }

                            #endregion


                            foreach (MDProjectDocumentEntity docEnt in catDocumentList)
                            {
                                TreeNode docNode = new TreeNode();

                                BayTreeNodeValue docNodeValue = new BayTreeNodeValue();
                                docNodeValue.Value = docEnt.ProjectDocumentID.ToString();
                                docNodeValue.Attributes["NodeType"] = CustomControlConstants.DocumentNodeType.Document;
                                
                                docNode.Text = docEnt.Name;
                                docNode.Value = docNodeValue.GetValueString();
                                docNode.SelectAction = TreeNodeSelectAction.Select;
                                docNode.ImageUrl = ImageConstants.DOCUMENT;
                                docNode.Expanded = false;
                                if (ShowCheckBoxesInDocumentNodes == true)
                                {
                                    docNode.ShowCheckBox = true;
                                }

                                category.ChildNodes.Add(docNode);
                            }
                        }

                        #endregion


                        if (ProjectID == 0)
                        {
                            parentNode.ChildNodes.Add(category);
                        }
                        else if(category.ChildNodes.Count > 0)
                        {
                            parentNode.ChildNodes.Add(category);
                        }
                    }
                }
            }

            #endregion
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