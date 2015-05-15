// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 02-Sep-2012, 12:46:09




using System;
using System.Web.UI.WebControls;
using System.Collections.Generic;
using System.Linq;

using Bay.ERP.Web.UI.Helper;
using Bay.ERP.Common.BusinessEntities;
using Bay.ERP.BusinessFacade;
using Bay.ERP.FacadeCreator.FacadeContext;
using Bay.ERP.Common.Helper;
using Bay.ERP.Common.Shared;
using Geekees.Common.Controls;
using AjaxControlToolkit;
using System.IO;
using System.Web.UI;
using System.Configuration;

namespace Bay.ERP.Web.UI
{
    public partial class DMSDocumentNodeControl : DMSBaseControl
    {
        #region Properties

        public Int64 _DocumentNodeID
        {
            get
            {
                Int64 id = 0;

                if (ViewState["ID"] != null)
                {
                    Int64.TryParse(ViewState["ID"].ToString(), out id);
                }

                return id;
            }
            set
            {
                ViewState["ID"] = value;
            }
        }

        public DMSDocumentNodeEntity _DMSDocumentNodeEntity
        {
            get
            {
                DMSDocumentNodeEntity entity = new DMSDocumentNodeEntity();

                if (ViewState["CurrentEntity"] != null)
                {
                    entity = (DMSDocumentNodeEntity)ViewState["CurrentEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["CurrentEntity"] = value;
            }
        }

        private DMSDocumentNodeEntity CurrentDMSDocumentNodeEntity
        {
            get
            {
                if (_DocumentNodeID > 0)
                {
                    if (_DMSDocumentNodeEntity.DocumentNodeID != _DocumentNodeID)
                    {
                        _DMSDocumentNodeEntity = FCCDMSDocumentNode.GetFacadeCreate().GetByID(_DocumentNodeID);
                    }
                }

                return _DMSDocumentNodeEntity;
            }
            set
            {
                _DMSDocumentNodeEntity = value;
            }
        }

        public Int64 TreeDocumentNodeID
        {
            get
            {
                Int64 _treeDocumentNodeID = 0;

                if (!StringHelper.IsBlank(Helper.Url.SecureUrl[UrlConstants.OVERVIEW_DMS_DOCUMENT_NODE_ID]))
                {
                    Int64.TryParse(Helper.Url.SecureUrl[UrlConstants.OVERVIEW_DMS_DOCUMENT_NODE_ID], out _treeDocumentNodeID);
                }

                return _treeDocumentNodeID;
            }
        }

        public IList<DMSDocumentNodeEntity> DMSDocumentList
        {
            get
            {
                String fe = SqlExpressionBuilder.PrepareFilterExpression(DMSDocumentNodeEntity.FLD_NAME_UploadedByMemberID, this.CurrentMember.MemberID.ToString(), SQLMatchType.Equal);
                String fe1 = DMSDocumentNodeEntity.FLD_NAME_ParentDocumentNodeID+" "+"is null";
                fe = SqlExpressionBuilder.PrepareFilterExpression(fe, SQLJoinType.AND, fe1);

                ViewState["vs_CurrentDMSDocumentNodeEntity"] = FCCDMSDocumentNode.GetFacadeCreate().GetIL(null, null, String.Empty, fe, DatabaseOperationType.LoadWithFilterExpression);

                return (IList<DMSDocumentNodeEntity>)ViewState["vs_CurrentDMSDocumentNodeEntity"];
            }
            set
            {
                ViewState["vs_CurrentDMSDocumentNodeEntity"] = value;
            }
        }

        IList<DMSDocumentNodeEntity> nodeList;
        IList<DMSDocumentNodeEntity> subCategoryNodeList;

        #endregion

        #region Methods

        #region Build Tree

        private void BuildBayDriveWizard()
        {

            try
            {
                String[] driveInfo = new String[] { "My Drive", "Shared with me", "Starred", "Design", "All Items", "Bin" };

                Int64 result = -1;

                foreach (String ent in driveInfo)
                {

                    DMSDocumentNodeEntity dMSDocumentNodeEntity = new DMSDocumentNodeEntity();
                    dMSDocumentNodeEntity.ParentDocumentNodeID = null;
                    dMSDocumentNodeEntity.IsDocumentNodeType = true;
                    dMSDocumentNodeEntity.Name = ent;
                    dMSDocumentNodeEntity.DocumentStorageTypeID = MasterDataConstants.DMSDocumentStorageType.SYSTEM_NODE;
                    dMSDocumentNodeEntity.ReferenceID = 1; //Need To assign here project ID or others based on Storgae type ID.

                    dMSDocumentNodeEntity.Extension = null;
                    dMSDocumentNodeEntity.Remarks = null;
                    dMSDocumentNodeEntity.Path = null;
                    dMSDocumentNodeEntity.OriginalFileName = null;
                    dMSDocumentNodeEntity.CurrentFileName = null;
                    dMSDocumentNodeEntity.FileType = null;
                    dMSDocumentNodeEntity.TagKeyword = null;
                    dMSDocumentNodeEntity.IsStarred = false;
                    dMSDocumentNodeEntity.IsRemoved = false;
                    dMSDocumentNodeEntity.UploadedByMemberID = this.CurrentMember.MemberID;
                    dMSDocumentNodeEntity.OwnerTypeID = MasterDataConstants.DMSOwnerType.EMPLOYEE;
                    dMSDocumentNodeEntity.OwnerReferenceID = this.CurrentMember.MemberID;
                    dMSDocumentNodeEntity.QuotaUsed = null;
                    dMSDocumentNodeEntity.LastModifiedDate = System.DateTime.Now;

                    result = FCCDMSDocumentNode.GetFacadeCreate().Add(dMSDocumentNodeEntity, DatabaseOperationType.Add, TransactionRequired.No);
                }

                if (result > 0)
                {
                    
                }
                else
                {
                    MiscUtil.ShowMessage(lblMessage, "Failed to add Document Node Information.", false);
                }

            }
            catch (Exception ex)
            {
                MiscUtil.ShowMessage(lblMessage, ex.Message, true);
            }

        }

        private void BuildDMSDocumentNodeTree()
        {
            astvMyTree.RootNode.Clear();
            nodeList = FCCDMSDocumentNode.GetFacadeCreate().GetIL(null, null, String.Empty, String.Empty, DatabaseOperationType.Load);

            subCategoryNodeList = (from a in nodeList
                                   where a.ParentDocumentNodeID == null && a.UploadedByMemberID == this.CurrentMember.MemberID
                                   select a).ToList();

            if (subCategoryNodeList != null && subCategoryNodeList.Count > 0)
            {
                foreach (DMSDocumentNodeEntity ent in subCategoryNodeList)
                {
                    ASTreeViewNode category = new ASTreeViewNode(ent.Name);
                    category.NodeValue = ent.DocumentNodeID.ToString();
                    category.EnableDragDrop = false;
                   // category.enable
                    LoadCategories(category, ent.DocumentNodeID);
                    astvMyTree.RootNode.AppendChild(category);
                    astvMyTree.CollapseAll();
                }
            }
        }

        private void LoadCategories(ASTreeViewNode parentNode, Int64? parentDMSDocumentNodeID)
        {
            #region Load Main Categories

            if (nodeList != null && nodeList.Count > 0)
            {


                if (parentNode.NodeText.ToString() != MasterDataConstants.DMSCommonDocumentNode.STARRED && parentNode.NodeText.ToString() != MasterDataConstants.DMSCommonDocumentNode.ALL_ITEMS && parentNode.NodeText.ToString() != MasterDataConstants.DMSCommonDocumentNode.BIN)
                {
                    subCategoryNodeList = (from a in nodeList
                                           where a.ParentDocumentNodeID == parentDMSDocumentNodeID
                                           select a).ToList();

                    if (subCategoryNodeList != null && subCategoryNodeList.Count > 0)
                    {
                        foreach (DMSDocumentNodeEntity ent in subCategoryNodeList)
                        {
                            String title = ent.Name;
                            if (title.Length > 20)
                            {
                                title = ent.Name.Substring(0, 20);
                            }

                            ASTreeViewNode Subcategory = new ASTreeViewNode(title);
                            Subcategory.NodeValue = ent.DocumentNodeID.ToString();
                            Subcategory.EnableDragDrop = true;
                            LoadCategories(Subcategory, ent.DocumentNodeID);
                            parentNode.ChildNodes.Add(Subcategory);
                        }
                    }
                }
            }

           // astvMyTree.CollapseAll();
            #endregion
            #region Previous Code

            //switch (parentNode.NodeText.ToString())
                //{
                //    case MasterDataConstants.DMSCommonDocumentNode.STARRED:
                //        //subCategoryNodeList = (from a in nodeList
                //        //                       where a.IsStarred == true
                //        //                       select a).ToList();

                //        //if (subCategoryNodeList != null && subCategoryNodeList.Count > 0)
                //        //{
                //        //    foreach (DMSDocumentNodeEntity ent in subCategoryNodeList)
                //        //    {
                //        //        ASTreeViewNode Subcategory = new ASTreeViewNode(ent.Name);
                //        //        Subcategory.NodeValue = ent.DocumentNodeID.ToString();
                //        //        Subcategory.EnableDragDrop = true;
                //        //        LoadCategories(Subcategory, ent.DocumentNodeID);
                //        //        parentNode.ChildNodes.Add(Subcategory);
                //        //    }
                //        //}
                //        break;
                //    case MasterDataConstants.DMSCommonDocumentNode.ALL_ITEMS:
                //        break;
                //    default:
                //        if (parentNode.NodeText.ToString() != MasterDataConstants.DMSCommonDocumentNode.STARRED || parentNode.NodeText.ToString() != MasterDataConstants.DMSCommonDocumentNode.ALL_ITEMS || parentNode.NodeText.ToString() != MasterDataConstants.DMSCommonDocumentNode.BIN || parentNode.NodeText.ToString() != MasterDataConstants.DMSCommonDocumentNode.RECENT)
                //        {
                //            subCategoryNodeList = (from a in nodeList
                //                                   where a.ParentDocumentNodeID == parentDMSDocumentNodeID
                //                                   select a).ToList();

                //            if (subCategoryNodeList != null && subCategoryNodeList.Count > 0)
                //            {
                //                foreach (DMSDocumentNodeEntity ent in subCategoryNodeList)
                //                {
                //                    ASTreeViewNode Subcategory = new ASTreeViewNode(ent.Name);
                //                    Subcategory.NodeValue = ent.DocumentNodeID.ToString();
                //                    Subcategory.EnableDragDrop = true;
                //                    LoadCategories(Subcategory, ent.DocumentNodeID);
                //                    parentNode.ChildNodes.Add(Subcategory);
                //                }
                //            }
                //        }
                //        break;
                //}

                #endregion
        }

        #endregion

        protected Boolean IsSystemNode(String nodeText)
        {
            Boolean flag = true;

            if (CurrentDMSDocumentNodeEntity.DocumentStorageTypeID == MasterDataConstants.DMSDocumentStorageType.SYSTEM_NODE)
            {

                switch (nodeText)
                {
                    case MasterDataConstants.DMSCommonDocumentNode.MY_DRIVE:
                        flag = false;
                        break;
                    case MasterDataConstants.DMSCommonDocumentNode.SHARED_WITH_ME:
                        flag = false;
                        break;
                    case MasterDataConstants.DMSCommonDocumentNode.STARRED:
                        flag = false;
                        break;
                    case MasterDataConstants.DMSCommonDocumentNode.ALL_ITEMS:
                        flag = false;
                        break;
                    case MasterDataConstants.DMSCommonDocumentNode.BIN:
                        flag = false;
                        break;
                    case MasterDataConstants.DMSCommonDocumentNode.DESIGN:
                        flag = false;
                        break;
                }
            }

            return flag;
        }

        private void BuildDropDownList()
        {
        }

        private void PrepareValidator()
        {
        }

        private void PrepareInitialView()
        {
            txtName.Text = String.Empty;
        }

        private void PrepareEditView()
        {
            DMSDocumentNodeEntity dMSDocumentNodeEntity = CurrentDMSDocumentNodeEntity;
        }

        private void BindList()
        {
            BindDMSDocumentNodeList();
        }

        private void BindDMSDocumentNodeList()
        {
            lvDMSDocumentNode.DataBind();
        }

        private DMSDocumentNodeEntity BuildDMSDocumentNodeEntity()
        {
            DMSDocumentNodeEntity dMSDocumentNodeEntity = CurrentDMSDocumentNodeEntity;

            dMSDocumentNodeEntity.ParentDocumentNodeID = GetParentDocumentNodeFromTreeSelection();

            dMSDocumentNodeEntity.IsDocumentNodeType = true;
            dMSDocumentNodeEntity.Name = txtName.Text.Trim();
            dMSDocumentNodeEntity.DocumentStorageTypeID = MasterDataConstants.DMSDocumentStorageType.REGULAR_NODE;
            dMSDocumentNodeEntity.ReferenceID = 1; //Need To assign here project ID or others based on Storgae type ID.

            dMSDocumentNodeEntity.Extension = null;
            dMSDocumentNodeEntity.Remarks = null;
            dMSDocumentNodeEntity.Path = null;
            dMSDocumentNodeEntity.OriginalFileName = null;
            dMSDocumentNodeEntity.CurrentFileName = null;
            dMSDocumentNodeEntity.FileType = null;
            dMSDocumentNodeEntity.TagKeyword = null;
            dMSDocumentNodeEntity.IsStarred = false;
            dMSDocumentNodeEntity.IsRemoved = false;
            dMSDocumentNodeEntity.UploadedByMemberID = this.CurrentMember.MemberID;
            dMSDocumentNodeEntity.OwnerTypeID = MasterDataConstants.DMSOwnerType.EMPLOYEE;
            dMSDocumentNodeEntity.OwnerReferenceID = this.CurrentMember.MemberID;
            dMSDocumentNodeEntity.QuotaUsed = null;
            dMSDocumentNodeEntity.LastModifiedDate = System.DateTime.Now;

            return dMSDocumentNodeEntity;
        }

     

        private void SaveDMSDocumentNodeEntity()
        {
            if (IsValid)
            {
                try
                {
                    DMSDocumentNodeEntity dMSDocumentNodeEntity = BuildDMSDocumentNodeEntity();

                    Int64 result = -1;
                 
                    result = FCCDMSDocumentNode.GetFacadeCreate().Add(dMSDocumentNodeEntity, DatabaseOperationType.Add, TransactionRequired.No);

                    if (result > 0)
                    {
                        _DocumentNodeID = 0;
                        _DMSDocumentNodeEntity = new DMSDocumentNodeEntity();
                        PrepareInitialView();
                        BindDMSDocumentNodeList();
                        BuildDMSDocumentNodeTree();

                        MiscUtil.ShowMessage(lblMessage, "Document Node Information has been added successfully.", false);
                    }
                    else
                    {   
                        MiscUtil.ShowMessage(lblMessage, "Failed to add Document Node Information.", false);
                    }
                }
                catch (Exception ex)
                {
                    MiscUtil.ShowMessage(lblMessage, ex.Message, true);
                }
            }
        }

        private void AddToStarDMSDocumentNodeEntity()
        {
            if (IsValid)
            {
                try
                {
                    IList<ListViewDataItem> list = lvDMSDocumentNode.Items;

                    if (list != null && list.Count > 0)
                    {
                        Int64 result = -1;

                        foreach (ListViewDataItem lvdi in list)
                        {
                            CheckBox chbxState = (CheckBox)lvdi.FindControl("chbxDocumentNode");

                            if (chbxState.Checked == true)
                            {
                                Int64 DocumentNodeID;
                                Label lblDocumentNodeID = (Label)lvdi.FindControl("lblDocumentNodeID");

                                Int64.TryParse(lblDocumentNodeID.Text, out DocumentNodeID);

                                if (DocumentNodeID > 0)
                                {
                                    _DocumentNodeID = DocumentNodeID;
                                    DMSDocumentNodeEntity ent = CurrentDMSDocumentNodeEntity;
                                    ent.IsStarred = true; //Stared Info

                                    String filterExpression = SqlExpressionBuilder.PrepareFilterExpression(DMSDocumentNodeEntity.FLD_NAME_DocumentNodeID, DocumentNodeID.ToString(), SQLMatchType.Equal);
                                    result = FCCDMSDocumentNode.GetFacadeCreate().Update(ent, filterExpression, DatabaseOperationType.Update, TransactionRequired.No);
                                }
                            }
                        }

                        if (result > 0)
                        {
                            _DocumentNodeID = 0;
                            _DMSDocumentNodeEntity = new DMSDocumentNodeEntity();
                            PrepareInitialView();
                            BindDMSDocumentNodeList();
                            BuildDMSDocumentNodeTree();

                            MiscUtil.ShowMessage(lblMessage, "Add To Star successfully.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to Add To Star Document.", false);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MiscUtil.ShowMessage(lblMessage, ex.Message, true);
                }
            }
        }

        private void RemoveToStarDMSDocumentNodeEntity()
        {
            if (IsValid)
            {
                try
                {
                    IList<ListViewDataItem> list = lvDMSDocumentNode.Items;

                    if (list != null && list.Count > 0)
                    {
                        Int64 result = -1;

                        foreach (ListViewDataItem lvdi in list)
                        {
                            CheckBox chbxState = (CheckBox)lvdi.FindControl("chbxDocumentNode");

                            if (chbxState.Checked == true)
                            {
                                Int64 DocumentNodeID;
                                Label lblDocumentNodeID = (Label)lvdi.FindControl("lblDocumentNodeID");

                                Int64.TryParse(lblDocumentNodeID.Text, out DocumentNodeID);

                                if (DocumentNodeID > 0)
                                {
                                    _DocumentNodeID = DocumentNodeID;
                                    DMSDocumentNodeEntity ent = CurrentDMSDocumentNodeEntity;
                                    ent.IsStarred = false; //Stared Info

                                    String filterExpression = SqlExpressionBuilder.PrepareFilterExpression(DMSDocumentNodeEntity.FLD_NAME_DocumentNodeID, DocumentNodeID.ToString(), SQLMatchType.Equal);
                                    result = FCCDMSDocumentNode.GetFacadeCreate().Update(ent, filterExpression, DatabaseOperationType.Update, TransactionRequired.No);
                                }
                            }
                        }

                        if (result > 0)
                        {
                            _DocumentNodeID = 0;
                            _DMSDocumentNodeEntity = new DMSDocumentNodeEntity();
                            PrepareInitialView();
                            BindDMSDocumentNodeList();
                            BuildDMSDocumentNodeTree();

                            MiscUtil.ShowMessage(lblMessage, "Add To Star successfully.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to Add To Star Document.", false);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MiscUtil.ShowMessage(lblMessage, ex.Message, true);
                }
            }
        }

        private void RemoveDMSDocumentNodeEntity()
        {
            if (IsValid)
            {
                try
                {
                    IList<ListViewDataItem> list = lvDMSDocumentNode.Items;

                    if (list != null && list.Count > 0)
                    {
                        Int64 result = -1;

                        foreach (ListViewDataItem lvdi in list)
                        {
                            CheckBox chbxState = (CheckBox)lvdi.FindControl("chbxDocumentNode");

                            if (chbxState.Checked == true)
                            {
                                Int64 DocumentNodeID;
                                Label lblDocumentNodeID = (Label)lvdi.FindControl("lblDocumentNodeID");

                                Int64.TryParse(lblDocumentNodeID.Text, out DocumentNodeID);

                                if (DocumentNodeID > 0)
                                {
                                    _DocumentNodeID = DocumentNodeID;
                                    DMSDocumentNodeEntity ent = CurrentDMSDocumentNodeEntity;

                                    //ent.ParentDocumentNodeID = GetParentDocumentNodeByCurrentCommonDocumentName(MasterDataConstants.DMSCommonDocumentNode.BIN);
                                    //result = FCCDMSDocumentNode.GetFacadeCreate().Update(ent, filterExpression, DatabaseOperationType.Update, TransactionRequired.No);

                                    String filterExpression = SqlExpressionBuilder.PrepareFilterExpression(DMSDocumentNodeEntity.FLD_NAME_DocumentNodeID, DocumentNodeID.ToString(), SQLMatchType.Equal);
                                    result = FCCDMSDocumentNode.GetFacadeCreate().Delete(ent, filterExpression, DatabaseOperationType.Delete, TransactionRequired.No);

                                    if (result == 0)
                                    {
                                        if (File.Exists(Server.MapPath(ent.Path)))
                                        {
                                            File.Delete(Server.MapPath(ent.Path));
                                        }

                                        _DocumentNodeID = 0;
                                        _DMSDocumentNodeEntity = new DMSDocumentNodeEntity();
                                    }
                                }
                            }
                        }

                        if (result == 0)
                        {  
                            PrepareInitialView();
                            BindDMSDocumentNodeList();
                            BuildDMSDocumentNodeTree();
                            MiscUtil.ShowMessage(lblMessage, "Document Node Deleted successfully.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to Delete Document.", true);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MiscUtil.ShowMessage(lblMessage, ex.Message, true);
                }
            }
        }

        

        private void MoveToArchiveDMSDocumentNodeEntity()
        {
            if (IsValid)
            {
                try
                {
                    IList<ListViewDataItem> list = lvDMSDocumentNode.Items;

                    if (list != null && list.Count > 0)
                    {
                        Int64 result = -1;

                        foreach (ListViewDataItem lvdi in list)
                        {
                            CheckBox chbxState = (CheckBox)lvdi.FindControl("chbxDocumentNode");

                            if (chbxState.Checked == true)
                            {  
                                Int64 DocumentNodeID;
                                Label lblDocumentNodeID = (Label)lvdi.FindControl("lblDocumentNodeID");
                               
                                Int64.TryParse(lblDocumentNodeID.Text, out DocumentNodeID);

                                if (DocumentNodeID > 0)
                                {
                                    _DocumentNodeID = DocumentNodeID;
                                    DMSDocumentNodeEntity ent = CurrentDMSDocumentNodeEntity;
                                    ent.IsArchived = true;//Archive Info

                                    ent.ParentDocumentNodeID = GetParentDocumentNodeByCurrentCommonDocumentName(MasterDataConstants.DMSCommonDocumentNode.ALL_ITEMS);

                                    String filterExpression = SqlExpressionBuilder.PrepareFilterExpression(DMSDocumentNodeEntity.FLD_NAME_DocumentNodeID, DocumentNodeID.ToString(), SQLMatchType.Equal);
                                    result = FCCDMSDocumentNode.GetFacadeCreate().Update(ent, filterExpression, DatabaseOperationType.Update, TransactionRequired.No);
                                }
                            }
                        }

                        if (result > 0)
                        {
                            _DocumentNodeID = 0;
                            _DMSDocumentNodeEntity = new DMSDocumentNodeEntity();
                            PrepareInitialView();
                            BindDMSDocumentNodeList();
                            BuildDMSDocumentNodeTree();

                            MiscUtil.ShowMessage(lblMessage, "Move To Archive successfully.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to Move To Archive Document.", false);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MiscUtil.ShowMessage(lblMessage, ex.Message, true);
                }
            }
        }

        #region Common Method

        private Int64 GetParentDocumentNodeByCurrentCommonDocumentName(String currentDocumentName)
        {
            Int64 ParentdocumentNodeID = 0;
            IList<DMSDocumentNodeEntity> documentNodeList = DMSDocumentList;

            if (documentNodeList != null && documentNodeList.Count > 0)
            {
                DMSDocumentNodeEntity documentNode = (from s in documentNodeList
                                                      where s.Name == currentDocumentName
                                                      select s).FirstOrDefault();

                if (documentNode != null)
                {
                    ParentdocumentNodeID = documentNode.DocumentNodeID;
                }
            }

            return ParentdocumentNodeID;
        }

        private Int64 GetParentDocumentNodeFromTreeSelection()
        {
            Int64 selectedNodeValue = 0;

            ASTreeViewNode selectedNode = astvMyTree.GetSelectedNode();

            if (selectedNode != null)
            {
                Int64.TryParse(selectedNode.NodeValue.ToString(), out selectedNodeValue);
            }

            Int64 parentNodeID = 0;

            IList<DMSDocumentNodeEntity> documentNodeList = DMSDocumentList;

            if (documentNodeList != null && documentNodeList.Count > 0)
            {
                var documentNode = (from s in documentNodeList
                                    where s.Name == MasterDataConstants.DMSCommonDocumentNode.MY_DRIVE
                                    select s).ToList();

                if (selectedNodeValue == 0)
                {
                    parentNodeID = documentNode[0].DocumentNodeID;
                }
                else
                {
                    switch (selectedNode.NodeText.ToString())
                    {
                        case MasterDataConstants.DMSCommonDocumentNode.SHARED_WITH_ME:
                        case MasterDataConstants.DMSCommonDocumentNode.STARRED:
                        case MasterDataConstants.DMSCommonDocumentNode.ALL_ITEMS:
                        case MasterDataConstants.DMSCommonDocumentNode.BIN:
                            parentNodeID = documentNode[0].DocumentNodeID;
                            break;
                        default:
                            parentNodeID = selectedNodeValue;
                            break;
                    }
                }
            }

            return parentNodeID;
        }

        #endregion

        #endregion

        #region Event

        #region Page Event

        protected void Page_Load(object sender, EventArgs e)
        {

            if (AjaxFileUpload1.IsInFileUploadPostBack)
            {
                // do for ajax file upload partial postback request
            }
            else
            {
                // do for normal page request
            }

            if (Request.QueryString["preview"] == "1" && !string.IsNullOrEmpty(Request.QueryString["fileId"]))
            {
                var fileId = Request.QueryString["fileId"];
                var fileContents = (byte[])Session["fileContents_" + fileId];
                var fileContentType = (string)Session["fileContentType_" + fileId];

                if (fileContents != null)
                {
                    Response.Clear();
                    Response.ContentType = fileContentType;
                    Response.BinaryWrite(fileContents);
                    Response.End();
                }
            }


            afuFiles.UploadedComplete += new EventHandler<AsyncFileUploadEventArgs>(afuFiles_UploadedComplete);
            afuFiles.UploadedFileError += new EventHandler<AsyncFileUploadEventArgs>(afuFiles_UploadedFileError);

            if (!IsPostBack)
            {
                IList<DMSDocumentNodeEntity> documentNodeList = DMSDocumentList;

                if (documentNodeList != null && documentNodeList.Count > 0)
                {

                }
                else
                {
                    BuildBayDriveWizard();
                }

                PrepareValidator();
                PrepareInitialView();
                PrepareEditView();
                BuildDMSDocumentNodeTree();
            }
        }

        #endregion

        #region List View Event

        protected void lvCMNDashboardItem_ItemDataBound(object sender, ListViewItemEventArgs e)
        {
            if (e.Item.ItemType == ListViewItemType.DataItem)
            {
                ListViewDataItem dataItem = (ListViewDataItem)e.Item;

                DMSDocumentNodeEntity ent = (DMSDocumentNodeEntity)dataItem.DataItem;

                if (ent.IsDocumentNodeType)
                {
                    HyperLink hypName = (HyperLink)e.Item.FindControl("hypName");
                    hypName.NavigateUrl = UrlHelper.BuildSecureUrl("~/DMS/DMSDocumentNode.aspx", string.Empty, UrlConstants.OVERVIEW_DMS_DOCUMENT_NODE_ID, ent.DocumentNodeID.ToString()).ToString();
                    hypName.Target = "_self";
                }
            }
        }

        protected void lvDMSDocumentNode_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            Int64 DocumentNodeID;

            Int64.TryParse(e.CommandArgument.ToString(), out DocumentNodeID);

            if (DocumentNodeID > 0)
            {
                if (string.Equals(e.CommandName, "EditItem"))
                {
                    _DocumentNodeID = DocumentNodeID;

                    PrepareEditView();
                }
                else if (string.Equals(e.CommandName, "DeleteItem"))
                {
                    try
                    {
                        Int64 result = -1;

                        String fe = SqlExpressionBuilder.PrepareFilterExpression(DMSDocumentNodeEntity.FLD_NAME_DocumentNodeID, DocumentNodeID.ToString(), SQLMatchType.Equal);

                        DMSDocumentNodeEntity dMSDocumentNodeEntity = new DMSDocumentNodeEntity();


                        result = FCCDMSDocumentNode.GetFacadeCreate().Delete(dMSDocumentNodeEntity, fe, DatabaseOperationType.Delete, TransactionRequired.No);

                        if (result == 0)
                        {
                            _DocumentNodeID = 0;
                            _DMSDocumentNodeEntity = new DMSDocumentNodeEntity();
                            PrepareInitialView();
                            BindDMSDocumentNodeList();

                            MiscUtil.ShowMessage(lblMessage, "Document Node has been successfully deleted.", true);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to delete Document Node.", true);
                        }
                    }
                    catch (Exception ex)
                    {
                        MiscUtil.ShowMessage(lblMessage, ex.Message, true);
                    }
                }
            }
        }

        #endregion List View Event

        #region ObjectDataSource Event

        protected void odsDMSDocumentNode_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {
            String fe = DMSDocumentNodeEntity.FLD_NAME_ParentDocumentNodeID.ToString()+" "+"is not null";

            ASTreeViewNode selectedNode = astvMyTree.GetSelectedNode();

            if (selectedNode != null)
            {
                fe = SqlExpressionBuilder.PrepareFilterExpression(DMSDocumentNodeEntity.FLD_NAME_ParentDocumentNodeID, selectedNode.NodeValue.ToString(), SQLMatchType.Equal);
            }
            else if (TreeDocumentNodeID != 0)
            {
                fe = SqlExpressionBuilder.PrepareFilterExpression(DMSDocumentNodeEntity.FLD_NAME_ParentDocumentNodeID, TreeDocumentNodeID.ToString(), SQLMatchType.Equal);
            }
            if (selectedNode != null)
            {
                if (selectedNode.NodeText.ToString() == MasterDataConstants.DMSCommonDocumentNode.STARRED)
                {
                    fe = SqlExpressionBuilder.PrepareFilterExpression(DMSDocumentNodeEntity.FLD_NAME_IsStarred, "true", SQLMatchType.Equal);
                }
                else if (selectedNode.NodeText.ToString() == MasterDataConstants.DMSCommonDocumentNode.ALL_ITEMS)
                {
                    fe = DMSDocumentNodeEntity.FLD_NAME_ParentDocumentNodeID.ToString() + " " + "is not null";
                }
            }

            String fe1 = SqlExpressionBuilder.PrepareFilterExpression(DMSDocumentNodeEntity.FLD_NAME_UploadedByMemberID, this.CurrentMember.MemberID.ToString(), SQLMatchType.Equal);
            fe = SqlExpressionBuilder.PrepareFilterExpression(fe, SQLJoinType.AND, fe1);
            e.InputParameters["filterExpression"] = fe;
        }

        #endregion

        #region Button Event

        protected void btnSave_Click(object sender, EventArgs e)
        {
            SaveDMSDocumentNodeEntity();
        }

        protected void btnAddNew_Click(object sender, EventArgs e)
        {
            _DocumentNodeID = 0;
            _DMSDocumentNodeEntity = new DMSDocumentNodeEntity();
            PrepareInitialView();
        }

        protected void btnClear_Click(object sender, EventArgs e)
        {
            PrepareInitialView();
            PrepareEditView();
        }

        protected void btnClick_Click(object sender, EventArgs e)
        {
            BindList();
            BuildDMSDocumentNodeTree();
        }
      
        #endregion

        #region Treeview Event

        protected void astvMyTree_OnSelectedNodeChanged(object src, ASTreeViewNodeSelectedEventArgs e)
        {
            ASTreeViewNode selectedNode = astvMyTree.GetSelectedNode();

            if (selectedNode != null)
            {
                //String navUrl = UrlHelper.BuildSecureUrl("~/DMS/DMSDocumentNode.aspx", String.Empty, UrlConstants.OVERVIEW_DMS_DOCUMENT_NODE_ID, selectedNode.NodeValue.ToString()).ToString();
                //Response.Redirect(navUrl);

                Session["SelectedNodeID"] = selectedNode.NodeValue.ToString();
                //_DocumentNodeID = Int64.Parse(selectedNode.NodeValue.ToString());
            }
            else
            {
                Session["SelectedNodeID"] = null;
                //ViewState["selectedNodeID"] = null;
            }
            
            BindList();
        }

        #endregion

        #region File Uploader Events


        protected void AjaxFileUpload1_AllFilesUploaded(object sender, AjaxFileUploadEventArgs e)
        { 
  
             }

        protected void AjaxFileUpload1_OnUploadComplete(object sender, AjaxFileUploadEventArgs e)
        {   
            DMSDocumentNodeEntity dMSDocumentNodeEntity = new DMSDocumentNodeEntity();

            Int64 parentDocumentID=0;

            if (Session["SelectedNodeID"] !=null)
            {
                Int64.TryParse((String)Session["SelectedNodeID"].ToString(), out parentDocumentID);
            }
            else
            {
                parentDocumentID = GetParentDocumentNodeFromTreeSelection();
            }

            dMSDocumentNodeEntity.ParentDocumentNodeID = parentDocumentID;

            dMSDocumentNodeEntity.Name = Path.GetFileName(e.FileName);
            dMSDocumentNodeEntity.OriginalFileName = Path.GetFileName(e.FileName);
            dMSDocumentNodeEntity.CurrentFileName = Guid.NewGuid().ToString()+"." + dMSDocumentNodeEntity.Name;//+ ".ERP_" + Guid.NewGuid().ToString(); // +"" + Path.GetExtension(e.FileName);
            dMSDocumentNodeEntity.FileType = "";
            dMSDocumentNodeEntity.Extension = Path.GetExtension(e.FileName);

            //String path = @"D:\Reza\source\ERP\Source\Bay.ERP.WebUI\Upload\DMS\Document\abc";

            String savingPath = ConfigurationManager.AppSettings["ProjectRoot"].ToString() + ConfigurationManager.AppSettings["DMSUserFiles"].ToString();
            String databasePath = "~\\"+ ConfigurationManager.AppSettings["DMSUserFiles"].ToString();

            databasePath += CurrentMember.MemberID.ToString()+"\\";
            savingPath += CurrentMember.MemberID.ToString() + "\\";

            if (!Directory.Exists(savingPath))
            {
                Directory.CreateDirectory(savingPath);
            }

            String savingFilePath = savingPath + dMSDocumentNodeEntity.CurrentFileName;

            dMSDocumentNodeEntity.Path = databasePath + dMSDocumentNodeEntity.CurrentFileName;
            dMSDocumentNodeEntity.Remarks = String.Empty;

            dMSDocumentNodeEntity.IsDocumentNodeType = false;
            dMSDocumentNodeEntity.DocumentStorageTypeID = MasterDataConstants.DMSDocumentStorageType.REGULAR_NODE;
            dMSDocumentNodeEntity.ReferenceID = 1; //Need To assign here project ID or others based on Storgae type ID.

            dMSDocumentNodeEntity.TagKeyword = null;
            dMSDocumentNodeEntity.IsStarred = false;
            dMSDocumentNodeEntity.IsRemoved = false;
            dMSDocumentNodeEntity.UploadedByMemberID = this.CurrentMember.MemberID;
            dMSDocumentNodeEntity.OwnerTypeID = MasterDataConstants.DMSOwnerType.EMPLOYEE;
            dMSDocumentNodeEntity.OwnerReferenceID = this.CurrentMember.MemberID;
            dMSDocumentNodeEntity.QuotaUsed = null;
            dMSDocumentNodeEntity.LastModifiedDate = System.DateTime.Now;

            FCCDMSDocumentNode.GetFacadeCreate().Add(dMSDocumentNodeEntity, DatabaseOperationType.Add, TransactionRequired.No);

            // file upload

            //AjaxFileUpload1.SaveAs(Server.MapPath(dMSDocumentNodeEntity.Path));
            AjaxFileUpload1.SaveAs(savingFilePath);

            #region Try To save it physical path

            //string sfile = afuFiles.FileName; 
            //string spath = Server.MapPath(@"D:\DMS\Document"); 
            //string sfullpath = spath + @"\" + sfile; 

            //afuFiles.SaveAs(sfullpath); 

            #endregion

            //LoadFileListGried
            BindDMSDocumentNodeList();

            // User can save file to File System, database or in session state
            //if (file.ContentType.Contains("jpg") || file.ContentType.Contains("gif")
            //    || file.ContentType.Contains("png") || file.ContentType.Contains("jpeg"))
            //{
            //    Session["fileContentType_" + file.FileId] = file.ContentType;
            //    Session["fileContents_" + file.FileId] = file.GetContents();
            //}

            //// Set PostedUrl to preview the uploaded file.         
            //file.PostedUrl = string.Format("?preview=1&fileId={0}", file.FileId);

            MiscUtil.ShowMessage(lblMessage, "File Uploaded Successfully", false);
        }

        protected void afuFiles_UploadedComplete(object sender, AsyncFileUploadEventArgs e)
        {
            //ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "size", "top.$get(\"" + uploadResult.ClientID + "\").innerHTML = 'Uploaded size: " + AsyncFileUpload1.FileBytes.Length.ToString() + "';", true);

            // Uncomment to save to AsyncFileUpload\Uploads folder.
            // ASP.NET must have the necessary permissions to write to the file system

            DMSDocumentNodeEntity dMSDocumentNodeEntity = new DMSDocumentNodeEntity();

            dMSDocumentNodeEntity.ParentDocumentNodeID = GetParentDocumentNodeFromTreeSelection();

            dMSDocumentNodeEntity.Name = Path.GetFileName(e.FileName);
            dMSDocumentNodeEntity.OriginalFileName = Path.GetFileName(e.FileName);
            dMSDocumentNodeEntity.CurrentFileName = Guid.NewGuid().ToString() + Path.GetExtension(e.FileName);
            dMSDocumentNodeEntity.FileType = "";
            dMSDocumentNodeEntity.Extension = Path.GetExtension(e.FileName);
            dMSDocumentNodeEntity.Path = FileUploadConstants.DMS.DOCUMENTS + dMSDocumentNodeEntity.CurrentFileName;
            dMSDocumentNodeEntity.Remarks = String.Empty;

            dMSDocumentNodeEntity.IsDocumentNodeType = false;
            dMSDocumentNodeEntity.DocumentStorageTypeID = MasterDataConstants.DMSDocumentStorageType.REGULAR_NODE;
            dMSDocumentNodeEntity.ReferenceID = 1; //Need To assign here project ID or others based on Storgae type ID.

            dMSDocumentNodeEntity.TagKeyword = null;
            dMSDocumentNodeEntity.IsStarred = false;
            dMSDocumentNodeEntity.IsRemoved = false;
            dMSDocumentNodeEntity.UploadedByMemberID = this.CurrentMember.MemberID;
            dMSDocumentNodeEntity.OwnerTypeID = MasterDataConstants.DMSOwnerType.EMPLOYEE;
            dMSDocumentNodeEntity.OwnerReferenceID = this.CurrentMember.MemberID;
            dMSDocumentNodeEntity.QuotaUsed = null;
            dMSDocumentNodeEntity.LastModifiedDate = System.DateTime.Now;

            FCCDMSDocumentNode.GetFacadeCreate().Add(dMSDocumentNodeEntity, DatabaseOperationType.Add, TransactionRequired.No);

            // file upload

            afuFiles.SaveAs(Server.MapPath(dMSDocumentNodeEntity.Path));

            #region Try To save it physical path

            //string sfile = afuFiles.FileName; 
            //string spath = Server.MapPath(@"D:\DMS\Document"); 
            //string sfullpath = spath + @"\" + sfile; 

            //afuFiles.SaveAs(sfullpath); 

            #endregion

            //LoadFileListGried
            BindDMSDocumentNodeList();
        }

        protected void afuFiles_UploadedFileError(object sender, AsyncFileUploadEventArgs e)
        {
            //ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "error", "top.$get(\"" + uploadResult.ClientID + "\").innerHTML = 'Error: " + e.StatusMessage + "';", true);
        }

        #endregion

        #region Tree Related Button Event
        //Delete Document Node Method
        protected void btnPostBackTrigger_Click(object sender, EventArgs e)
        {
            String deletedNodeId = this.txtIDContainer.Text;

            Int64 DocumentNodeID = 0;
            DocumentNodeID = Int64.Parse(deletedNodeId.ToString());

            if (DocumentNodeID > 0)
            {

            _DocumentNodeID = DocumentNodeID;
            DMSDocumentNodeEntity dMSDocumentNodeEntity = CurrentDMSDocumentNodeEntity;

            if (IsSystemNode(dMSDocumentNodeEntity.Name))
            {
                try
                {
                    Int64 result = -1;
                    
                    String fe = SqlExpressionBuilder.PrepareFilterExpression(DMSDocumentNodeEntity.FLD_NAME_DocumentNodeID, DocumentNodeID.ToString(), SQLMatchType.Equal);
                    result = FCCDMSDocumentNode.GetFacadeCreate().Delete(dMSDocumentNodeEntity, fe, DatabaseOperationType.Delete, TransactionRequired.No);

                    if (result == 0)
                    {
                        if (File.Exists(Server.MapPath(dMSDocumentNodeEntity.Path)))
                        {
                            File.Delete(Server.MapPath(dMSDocumentNodeEntity.Path));
                        }

                        _DocumentNodeID = 0;
                        _DMSDocumentNodeEntity = new DMSDocumentNodeEntity();
                        PrepareInitialView();
                        BindDMSDocumentNodeList();
                        BuildDMSDocumentNodeTree();

                        MiscUtil.ShowMessage(lblMessage, "Document Node has been successfully deleted.", true);
                    }
                    else
                    {
                        MiscUtil.ShowMessage(lblMessage, "Failed to delete Document Node.", true);
                        BindDMSDocumentNodeList();
                        BuildDMSDocumentNodeTree();
                    }
                }

                catch (Exception ex)
                {
                    MiscUtil.ShowMessage(lblMessage, "Failed to delete Document Node.", true);
                    MiscUtil.ShowMessage(lblMessage, ex.Message, true);
                }
            }
            else
            {
                BuildDMSDocumentNodeTree();
            }
            }
        }
        

        protected void btnPostBackDNDTrigger_Click(object sender, EventArgs e)
        {
            String curNodeValue = this.txtCurrentNode.Text;
            String newParentValue = this.txtNewParentNode.Text;

            if (curNodeValue != "")
            {
                Int64 DocumentNodeID = 0;
                DocumentNodeID = Int64.Parse(curNodeValue.ToString());

                if (DocumentNodeID > 0)
                {
                    _DocumentNodeID = DocumentNodeID;
                    DMSDocumentNodeEntity dMSDocumentNodeEntity = CurrentDMSDocumentNodeEntity;

                    try
                    {
                        Int64 result = -1;

                        String fe = SqlExpressionBuilder.PrepareFilterExpression(DMSDocumentNodeEntity.FLD_NAME_DocumentNodeID, DocumentNodeID.ToString(), SQLMatchType.Equal);

                        dMSDocumentNodeEntity.ParentDocumentNodeID = Int64.Parse(newParentValue.ToString()); // New Parent Value.
                        dMSDocumentNodeEntity.UploadedByMemberID = this.CurrentMember.MemberID;

                        result = FCCDMSDocumentNode.GetFacadeCreate().Update(dMSDocumentNodeEntity, fe, DatabaseOperationType.Update, TransactionRequired.No);

                        if (result > 0)
                        {
                            _DocumentNodeID = 0;
                            _DMSDocumentNodeEntity = new DMSDocumentNodeEntity();
                            PrepareInitialView();
                            BindDMSDocumentNodeList();
                            BuildDMSDocumentNodeTree();
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to DND Document Node.", true);
                        }
                    }
                    catch (Exception ex)
                    {
                        MiscUtil.ShowMessage(lblMessage, ex.Message, true);
                    }
                    
                }
            }
        }

        protected void btnPostBackEditedTrigger_Click(object sender, EventArgs e)
        {
            String deletedNodeId = this.txtIDEditedContainer.Text;

            String editedText =this.txtEditedNodeText.Text;

            Int64 DocumentNodeID = 0;
            DocumentNodeID = Int64.Parse(deletedNodeId.ToString());

            if (DocumentNodeID > 0)
            {

                _DocumentNodeID = DocumentNodeID;
                DMSDocumentNodeEntity dMSDocumentNodeEntity = CurrentDMSDocumentNodeEntity;

                if (IsSystemNode(dMSDocumentNodeEntity.Name))
                {
                    try
                    {
                        Int64 result = -1;

                        dMSDocumentNodeEntity.Name = editedText.ToString();
                        dMSDocumentNodeEntity.UploadedByMemberID = this.CurrentMember.MemberID;

                        String fe = SqlExpressionBuilder.PrepareFilterExpression(DMSDocumentNodeEntity.FLD_NAME_DocumentNodeID, DocumentNodeID.ToString(), SQLMatchType.Equal);
                        result = FCCDMSDocumentNode.GetFacadeCreate().Update(dMSDocumentNodeEntity, fe, DatabaseOperationType.Update, TransactionRequired.No);

                        if (result > 0)
                        {
                            _DocumentNodeID = 0;
                            _DMSDocumentNodeEntity = new DMSDocumentNodeEntity();
                            PrepareInitialView();
                            BindDMSDocumentNodeList();
                            BuildDMSDocumentNodeTree();

                            MiscUtil.ShowMessage(lblMessage, "Document Node has been successfully Renamed.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to rename Document Node.", true);
                        }
                    }
                    catch (Exception ex)
                    {
                        MiscUtil.ShowMessage(lblMessage, ex.Message, true);
                    }
                }
                else
                {
                    MiscUtil.ShowMessage(lblMessage, "Failed to rename Document Node.", true);
                    BuildDMSDocumentNodeTree();
                }
            }
        }

        protected void btnPostBackAddedTrigger_Click(object sender, EventArgs e)
        {
            String deletedNodeId = this.txtIDContainer.Text;
        }
       
        #endregion

        #region Panel Option Button Event

        protected void btnAddStar_Click(object sender, EventArgs e)
        {
            AddToStarDMSDocumentNodeEntity();
        }

        protected void btnRemoveStar_Click(object sender, EventArgs e)
        {
            RemoveToStarDMSDocumentNodeEntity();
        }

        protected void btnMoveToArchive_Click(object sender, EventArgs e)
        {
            MoveToArchiveDMSDocumentNodeEntity();
        }

        protected void btnRemove_Click(object sender, EventArgs e)
        {
            RemoveDMSDocumentNodeEntity();
        }

        #endregion

        #endregion Event
    }
}
