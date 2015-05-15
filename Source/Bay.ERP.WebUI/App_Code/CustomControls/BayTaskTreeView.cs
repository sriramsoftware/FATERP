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
    [ToolboxData("<{0}:BayTaskTreeView runat=server></{0}:BayTaskTreeView>")]
    public class BayTaskTreeView : TreeView
    {
        #region Properties

        IList<BDMDTaskCategoryEntity> nodeList;
        IList<BDMDTaskCategoryEntity> subCategoryNodeList;
        IList<BDMDTaskEntity> taskList;
        IList<BDMDTaskEntity> catTaskList;

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
                return (Boolean)ViewState["BayTaskTreeView_PROP_ShowCheckBoxesInDocumentNodes"];
            }

            set
            {
                ViewState["BayTaskTreeView_PROP_ShowCheckBoxesInDocumentNodes"] = value;
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
                return (String)ViewState["BayTaskTreeView_PROP_RootNodeText"];
            }

            set
            {
                ViewState["BayTaskTreeView_PROP_RootNodeText"] = value;
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
                return (Int64)ViewState["BayTaskTreeView_PROP_ProjectID"];
            }

            set
            {
                ViewState["BayTaskTreeView_PROP_ProjectID"] = value;
            }
        }

        #endregion

        public BayTaskTreeView()
        {
            this.ShowCheckBoxesInDocumentNodes = false;
            this.RootNodeText = "Task";
        }

        #region Methods

        private void PopulateTree()
        {
            this.Nodes.Clear();

            nodeList = FCCBDMDTaskCategory.GetFacadeCreate().GetIL(null, null, String.Empty, String.Empty, DatabaseOperationType.Load);
            taskList = FCCBDMDTask.GetFacadeCreate().GetIL(null, null, String.Empty, String.Empty, DatabaseOperationType.Load);
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

        private void LoadCategories(TreeNode parentNode, Int64? parentTaskCategoryID)
        {
            #region Load Main Categories

            if (ProjectID > 0 && projectDocumentList == null)
            {
                return;
            }

            if (nodeList != null && nodeList.Count > 0)
            {
                subCategoryNodeList = (from a in nodeList
                                       where a.ParentTaskCategoryID == parentTaskCategoryID
                                        select a).ToList();

                if (subCategoryNodeList != null && subCategoryNodeList.Count > 0)
                {
                    foreach (BDMDTaskCategoryEntity ent in subCategoryNodeList)
                    {
                        TreeNode category = new TreeNode();

                        BayTreeNodeValue categoryNodeValue = new BayTreeNodeValue();
                        categoryNodeValue.Value = ent.TaskCategoryID.ToString();
                        categoryNodeValue.Attributes["NodeType"] = CustomControlConstants.DocumentNodeType.DocumentCategory;
                        category.ImageUrl = ImageConstants.DOCUMENT_CATEGORY;
                        category.Text = ent.Name;
                        category.Value = categoryNodeValue.GetValueString();
                        category.SelectAction = TreeNodeSelectAction.SelectExpand;
                        category.Expanded = false;                        

                        LoadCategories(category, ent.TaskCategoryID);

                        #region Loading the Documents

                        if (taskList != null && taskList.Count > 0)
                        {
                            catTaskList = (from d in taskList
                                               where d.TaskCategoryID == ent.TaskCategoryID
                                               select d).ToList();

                            #region If Project Id is setup, the list will be filtered by the project id

                            if (ProjectID > 0)
                            {
                                IList<MDProjectDocumentEntity> felteredDocumentList = new List<MDProjectDocumentEntity>();
                                if (projectDocumentList != null && projectDocumentList.Count > 0)
                                {

                                    foreach (BDProjectCollectedDocumentInfoEntity proDocEnt in projectDocumentList)
                                    {
                                      //  IList<BDMDTaskEntity> tempCatDocumentList = (from pd in catTaskList
                                        //                                                      where pd.TaskID == proDocEnt.TaskID
                                          //                                                    select pd).ToList();
                                        //if (tempCatDocumentList != null && tempCatDocumentList.Count > 0)
                                        //{
                                            //foreach (BDMDTaskEntitytempDocEnt in tempCatDocumentList)
                                            //{
                                                //felteredDocumentList.Add(tempDocEnt);
                                            //}
                                        //}
                                    }

                                    //catDocumentList = felteredDocumentList;
                                }
                            }

                            #endregion


                            foreach (BDMDTaskEntity docEnt in catTaskList)
                            {
                                TreeNode docNode = new TreeNode();

                                BayTreeNodeValue docNodeValue = new BayTreeNodeValue();
                                docNodeValue.Value = docEnt.TaskID.ToString();
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
            BuildTree();
        }

        protected override void RenderContents(HtmlTextWriter output)
        {
            base.RenderContents(output);
        }

        #endregion
    }
}