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
using System.Threading;
using System.Web.Security;

namespace Bay.ERP.Web.UI
{
    public partial class KBUserTreeControl : BaseControl
    {
        #region Properties

        public Int64 _UserTreeID
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

        public KBUserTreeEntity _KBUserTreeEntity
        {
            get
            {
                KBUserTreeEntity entity = new KBUserTreeEntity();

                if (ViewState["CurrentEntity"] != null)
                {
                    entity = (KBUserTreeEntity)ViewState["CurrentEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["CurrentEntity"] = value;
            }
        }

        private KBUserTreeEntity CurrentKBUserTreeEntity
        {
            get
            {
                if (_UserTreeID > 0)
                {
                    if (_KBUserTreeEntity.UserTreeID != _UserTreeID)
                    {
                        _KBUserTreeEntity = FCCKBUserTree.GetFacadeCreate().GetByID(_UserTreeID);
                    }
                }

                return _KBUserTreeEntity;
            }
            set
            {
                _KBUserTreeEntity = value;
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

        public Int64 CurrentemployeeID
        {
            get
            {
                Int64 _employeeID = 0;

                if (ViewState["currentEmployeeID"] != null)
                {
                    Int64.TryParse(ViewState["currentEmployeeID"].ToString(), out _employeeID);
                }

                if (ViewState["currentEmployeeID"] == null)
                {
                    ViewState["currentEmployeeID"] = MiscUtil.GetCurrentEmployeeByMemberID(CurrentMember);
                    _employeeID = (Int64)ViewState["currentEmployeeID"];
                }

                return _employeeID;
            }
            set
            {
                ViewState["currentEmployeeID"] = value;
            }
        }

        public Int64 _UserTreeSharedID
        {
            get
            {
                Int64 id = 0;

                if (ViewState["UserTreeSharedID"] != null)
                {
                    Int64.TryParse(ViewState["UserTreeSharedID"].ToString(), out id);
                }

                return id;
            }
            set
            {
                ViewState["UserTreeSharedID"] = value;
            }
        }

        public KBUserTreeSharedEntity _KBUserTreeSharedEntity
        {
            get
            {
                KBUserTreeSharedEntity entity = new KBUserTreeSharedEntity();

                if (ViewState["KBUserTreeSharedEntity"] != null)
                {
                    entity = (KBUserTreeSharedEntity)ViewState["KBUserTreeSharedEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["KBUserTreeSharedEntity"] = value;
            }
        }

        private KBUserTreeSharedEntity CurrentKBUserTreeSharedEntity
        {
            get
            {
                if (_UserTreeSharedID > 0)
                {
                    if (_KBUserTreeSharedEntity.UserTreeSharedID != _UserTreeSharedID)
                    {
                        _KBUserTreeSharedEntity = FCCKBUserTreeShared.GetFacadeCreate().GetByID(_UserTreeSharedID);
                    }
                }

                return _KBUserTreeSharedEntity;
            }
            set
            {
                _KBUserTreeSharedEntity = value;
            }
        }

        public String Action
        {
            get
            {
                String action = "Add";

                if (ViewState["do"] != null)
                {
                    action = ViewState["do"].ToString();
                }
                else if (!StringHelper.IsBlank(Helper.Url.SecureUrl["do"].ToString()))
                {
                    action = Helper.Url.SecureUrl["do"].ToString();

                    ViewState["do"] = action;
                }

                return action;
            }
            set
            {
                ViewState["do"] = value;
            }
        }

        public IList<KBUserTreeSharedEntity> kBUserTreeSharedEntityList
        {
            get
            {
                IList<KBUserTreeSharedEntity> lst=null;//= new List<KBUserTreeSharedEntity>();

                if (ViewState["kBUserTreeSharedEntityList"] == null)
                {
                    String fe = SqlExpressionBuilder.PrepareFilterExpression(KBUserTreeSharedEntity.FLD_NAME_SharedGivenToEmployeeID, CurrentemployeeID.ToString(), SQLMatchType.Equal);
                    ViewState["kBUserTreeSharedEntityList"] = FCCKBUserTreeShared.GetFacadeCreate().GetIL(null, null, String.Empty, fe, DatabaseOperationType.LoadWithFilterExpression);
                    lst = (IList<KBUserTreeSharedEntity>)ViewState["kBUserTreeSharedEntityList"];
                }
                if (ViewState["kBUserTreeSharedEntityList"] != null)
                {
                    lst = (IList<KBUserTreeSharedEntity>)ViewState["kBUserTreeSharedEntityList"];
                }

                return lst!=null?lst:new List<KBUserTreeSharedEntity>();
            }
            set
            {
                ViewState["kBUserTreeSharedEntityList"] = value;
            }
        }

        public Int64 _FavoriteID
        {
            get
            {
                Int64 id = 0;

                if (ViewState["FavoriteID"] != null)
                {
                    Int64.TryParse(ViewState["FavoriteID"].ToString(), out id);
                }

                return id;
            }
            set
            {
                ViewState["FavoriteID"] = value;
            }
        }

        public CMNFavoriteEntity _CMNFavoriteEntity
        {
            get
            {
                CMNFavoriteEntity entity = new CMNFavoriteEntity();

                if (ViewState["CMNFavoriteEntity"] != null)
                {
                    entity = (CMNFavoriteEntity)ViewState["CMNFavoriteEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["CMNFavoriteEntity"] = value;
            }
        }

        private CMNFavoriteEntity CurrentCMNFavoriteEntity
        {
            get
            {
                if (_FavoriteID > 0)
                {
                    if (_CMNFavoriteEntity.FavoriteID != _FavoriteID)
                    {
                        _CMNFavoriteEntity = FCCCMNFavorite.GetFacadeCreate().GetByID(_FavoriteID);
                    }
                }

                return _CMNFavoriteEntity;
            }
            set
            {
                _CMNFavoriteEntity = value;
            }
        }

        //public IList<KBUserTreeEntity> KBUserTreeEntityList
        //{
        //    get
        //    {
        //        String fe = SqlExpressionBuilder.PrepareFilterExpression(DMSDocumentNodeEntity.FLD_NAME_UploadedByMemberID, this.CurrentMember.MemberID.ToString(), SQLMatchType.Equal);
        //        String fe1 = DMSDocumentNodeEntity.FLD_NAME_ParentDocumentNodeID+" "+"is null";
        //        fe = SqlExpressionBuilder.PrepareFilterExpression(fe, SQLJoinType.AND, fe1);

        //        ViewState["vs_CurrentDMSDocumentNodeEntity"] = FCCDMSDocumentNode.GetFacadeCreate().GetIL(null, null, String.Empty, fe, DatabaseOperationType.LoadWithFilterExpression);

        //        return (IList<DMSDocumentNodeEntity>)ViewState["vs_CurrentDMSDocumentNodeEntity"];
        //    }
        //    set
        //    {
        //        ViewState["vs_CurrentDMSDocumentNodeEntity"] = value;
        //    }
        //}

        IList<KBUserTreeEntity> nodeList;
        IList<KBUserTreeEntity> subCategoryNodeList;

        #endregion

        #region Methods

        #region Build Tree

        private void BuildKBUserTree()
        {
            astvMyTree.RootNode.Clear();
            nodeList = FCCKBUserTree.GetFacadeCreate().GetIL(null, null, String.Empty, String.Empty, DatabaseOperationType.Load);

            subCategoryNodeList = (from a in nodeList
                                   where a.ParentUserTreeID == null // && a.UploadedByMemberID == this.CurrentMember.MemberID
                                   select a).ToList();

            if (subCategoryNodeList != null && subCategoryNodeList.Count > 0)
            {
                foreach (KBUserTreeEntity ent in subCategoryNodeList)
                {
                    ASTreeViewNode category = new ASTreeViewNode(ent.Title);
                    category.NodeValue = ent.UserTreeID.ToString();
                    category.EnableDragDrop = true;
                   // category.enable
                    LoadCategories(category, ent.UserTreeID);
                    astvMyTree.RootNode.AppendChild(category);
                    astvMyTree.CollapseAll();
                }
            }
        }

        private void LoadCategories(ASTreeViewNode parentNode, Int64? parentUserTreeID)
        {
            #region Load Main Categories

            if (nodeList != null && nodeList.Count > 0)
            {

                    subCategoryNodeList = (from a in nodeList
                                           where a.ParentUserTreeID == parentUserTreeID
                                           select a).ToList();

                    if (subCategoryNodeList != null && subCategoryNodeList.Count > 0)
                    {
                        foreach (KBUserTreeEntity ent in subCategoryNodeList)
                        {
                            String title = ent.Title;
                            if (title.Length > 20)
                            {
                                title = ent.Title.Substring(0, 20);
                            }
                            ASTreeViewNode Subcategory = new ASTreeViewNode(title);
                            Subcategory.NodeValue = ent.UserTreeID.ToString();
                            Subcategory.EnableDragDrop = true;
                            LoadCategories(Subcategory, ent.UserTreeID);

                            if (ent.UserTreeStatusID == MasterDataConstants.KBMDUserTreeStatus.MAKE_IT_PUBLIC)
                            {
                                parentNode.ChildNodes.Add(Subcategory);
                            }
                            else
                            {
                                //Checking Owner Info
                                if (ent.IsDocumentNodeType == true && ent.OwnerEmployeeID == CurrentemployeeID)
                                {
                                    parentNode.ChildNodes.Add(Subcategory);
                                }

                                //Confirm the Shared Info
                                else if (ent.IsDocumentNodeType == true && ent.OwnerEmployeeID != CurrentemployeeID)
                                {
                                    KBUserTreeSharedEntity lstUser = (from s in kBUserTreeSharedEntityList
                                                                      where s.UserTreeID == ent.UserTreeID
                                                                      select s).FirstOrDefault();

                                    if (lstUser != null && lstUser.UserTreeID > 0)
                                    {
                                        //if (ent.UserTreeID == lstUserTreeShared[0].UserTreeID)
                                        //{
                                        parentNode.ChildNodes.Add(Subcategory);
                                        //}
                                    }
                                }

                                //Ensure the Document Node Type Info
                                else if (ent.IsDocumentNodeType == false)
                                {
                                    parentNode.ChildNodes.Add(Subcategory);
                                }
                            }
                        }
                    }
            }

            #endregion
        }

        #endregion

        private KBUserTreeSharedEntity BuildKBUserTreeSharedEntity()
        {
            KBUserTreeSharedEntity kBUserTreeSharedEntity = new KBUserTreeSharedEntity();

            kBUserTreeSharedEntity.UserTreeID = _UserTreeID;
            kBUserTreeSharedEntity.UserTreeSettingID = MasterDataConstants.KBMDUserTreeSetting.OPEN;

            kBUserTreeSharedEntity.Message = "Not implement Yet";
            kBUserTreeSharedEntity.SharedGivenByEmployeeID = CurrentemployeeID;
            kBUserTreeSharedEntity.SharedDateTime = System.DateTime.Now;
            if (ddlSharedGivenToEmployeeID.Items.Count > 0)
            {
                if (ddlSharedGivenToEmployeeID.SelectedValue == "0")
                {
                }
                else
                {
                    kBUserTreeSharedEntity.SharedGivenToEmployeeID = Int64.Parse(ddlSharedGivenToEmployeeID.SelectedValue);
                }
            }

            kBUserTreeSharedEntity.IP = MiscUtil.GetLocalIP();
            if (ddlUserTreePermissionID.Items.Count > 0)
            {
                if (ddlUserTreePermissionID.SelectedValue == "0")
                {
                }
                else
                {
                    kBUserTreeSharedEntity.UserTreePermissionID = Int64.Parse(ddlUserTreePermissionID.SelectedValue);
                }
            }

            return kBUserTreeSharedEntity;
        }

        private void SaveKBUserTreeSharedEntity()
        {
            if (IsValid)
            {
                try
                {
                    KBUserTreeSharedEntity kBUserTreeSharedEntity = BuildKBUserTreeSharedEntity();

                    Int64 result = -1;

                    if (kBUserTreeSharedEntity.IsNew)
                    {
                        result = FCCKBUserTreeShared.GetFacadeCreate().Add(kBUserTreeSharedEntity, DatabaseOperationType.Add, TransactionRequired.No);
                    }
                    else
                    {
                        String filterExpression = SqlExpressionBuilder.PrepareFilterExpression(KBUserTreeSharedEntity.FLD_NAME_UserTreeSharedID, kBUserTreeSharedEntity.UserTreeSharedID.ToString(), SQLMatchType.Equal);
                        result = FCCKBUserTreeShared.GetFacadeCreate().Update(kBUserTreeSharedEntity, filterExpression, DatabaseOperationType.Update, TransactionRequired.No);
                    }

                    if (result > 0)
                    {
                        _UserTreeSharedID = 0;
                        _KBUserTreeSharedEntity = new KBUserTreeSharedEntity();
                        PrepareInitialView();
                        BindKBUserTreeSharedList();

                        this.ModalPopupExtender1.Show();

                        if (kBUserTreeSharedEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "User Tree Shared Information has been added successfully.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "User Tree Shared Information has been updated successfully.", false);
                        }
                    }
                    else
                    {
                        if (kBUserTreeSharedEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to add User Tree Shared Information.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to update User Tree Shared Information.", false);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MiscUtil.ShowMessage(lblMessage, ex.Message, true);
                }
            }
        }

        private void BindKBUserTreeSharedList()
        {
            lvKBUserTreeShared.DataBind();
        }

        private void BuildDropDownList()
        {   
        }

        private void BindKBUserTreeUploadInfoOperationList()
        {
            lstKBUserTreeUploadInfoOperation.DataBind();
        }

        private void BindKBUserTreeList()
        {
            lvKBUserTree.DataBind();
        }

        private void PrepareValidator()
        {
        }

        private void PrepareInitialView()
        {
            txtName.Text = String.Empty;

            btnCreatePost.Visible = true;
            btnArchiveAndUnshare.Visible = false;
            btnShareAndPermission.Visible = false;
            btnMarkNotinUse.Visible = false;
            btnCanShare.Visible = false;
            btnUploadInfo.Visible = false;
            btnTransferOwnership.Visible = false;

            MiscUtil.PopulateKBUserTree(ddlSearchSelect, true);
        }

        private void PrepareEditView()
        {
            KBUserTreeEntity kBUserTreeEntity = CurrentKBUserTreeEntity;


            if (!kBUserTreeEntity.IsNew)
            {

                txtTitle.Text = kBUserTreeEntity.Title.ToString();
                txtDescription.Content = kBUserTreeEntity.Description.ToString();

                txtTagKeyword.Text = kBUserTreeEntity.TagKeyword.ToString();

                btnSubmit.Text = "Update";
            }
        }

        private void PrepareInitialViewUserTree()
        {
            BuildDropDownList();
            
            txtTitle.Text = String.Empty;
            txtDescription.Content = String.Empty;
            txtTagKeyword.Text = String.Empty;

            btnSubmit.Text = "Add";
            btnPreview.Visible = false;
        }

        private void PrepareEditViewUserTree()
        {
            KBUserTreeEntity kBUserTreeEntity = CurrentKBUserTreeEntity;

            if (!kBUserTreeEntity.IsNew)
            {  
                txtTitle.Text = kBUserTreeEntity.Title.ToString();
                txtDescription.Content = kBUserTreeEntity.Description.ToString();
                txtTagKeyword.Text = kBUserTreeEntity.TagKeyword.ToString();

                if (kBUserTreeEntity.UserTreeStatusID == MasterDataConstants.KBMDUserTreeStatus.MAKE_IT_PUBLIC)
                {
                    chkIsMakeItPublic.Checked = true;
                }
                else
                {
                    chkIsMakeItPublic.Checked = false;
                }
           
                btnSavePost.Text = "Update Page";
                btnPreview.Visible = true;
            }
        }

        private void BindList()
        {
            BindDMSDocumentNodeList();
        }

        private void BindKBUserTreeUploadInfoList()
        {
            lvKBUserTreeUploadInfo.DataBind();
        }

        private void BindKBUserTreeModifiedHistoryInfoList()
        {
            lvKBUserTreeModifiedHistory.DataBind();
        }

        private Boolean ValidatePermission()
        {
            Boolean flag = true;

            KBUserTreeEntity kBUserTreeEntity = CurrentKBUserTreeEntity;

            if (kBUserTreeEntity.OwnerEmployeeID == CurrentemployeeID)
            {
                flag = true;
            }

            else if (kBUserTreeEntity.OwnerEmployeeID != CurrentemployeeID && kBUserTreeEntity.IsDocumentNodeType == true)
            {
                String fe_shared1 = SqlExpressionBuilder.PrepareFilterExpression(KBUserTreeSharedEntity.FLD_NAME_UserTreeID, _UserTreeID.ToString(), SQLMatchType.Equal);
                String fe_shared2 = SqlExpressionBuilder.PrepareFilterExpression(KBUserTreeSharedEntity.FLD_NAME_SharedGivenToEmployeeID, CurrentemployeeID.ToString(), SQLMatchType.Equal);
                String fe_shared = SqlExpressionBuilder.PrepareFilterExpression(fe_shared1, SQLJoinType.AND, fe_shared2);
                IList<KBUserTreeSharedEntity> lstkBUserTreeSharedEntity = FCCKBUserTreeShared.GetFacadeCreate().GetIL(null, null, String.Empty, fe_shared, DatabaseOperationType.LoadWithFilterExpression);

                if (lstkBUserTreeSharedEntity != null && lstkBUserTreeSharedEntity.Count > 0)
                {
                    if (lstkBUserTreeSharedEntity[0].UserTreePermissionID != MasterDataConstants.KBMDUserTreeSharedPermission.CAN_EDIT)
                    {
                        flag = false;
                        MiscUtil.ShowMessage(lblMessage, "You don't have any Permission to Edit", true);
                        BuildKBUserTree();
                    }

                    else if (lstkBUserTreeSharedEntity[0].UserTreePermissionID == MasterDataConstants.KBMDUserTreeSharedPermission.CAN_EDIT)
                    {   
                        flag = true;
                    }
                }
                else
                {
                    flag = false;
                    MiscUtil.ShowMessage(lblMessage, "You don't have any Permission to Edit", true);
                }
            }
            else
            {
                flag = false;
                MiscUtil.ShowMessage(lblMessage, "You don't have any Permission to Edit", true);
            }

            return flag;
        }

        private void BindDMSDocumentNodeList()
        {
            //lvDMSDocumentNode.DataBind();
        }

        private void BindDropdownForSharedInfo()
        {
            MiscUtil.PopulateHREmployee(ddlSharedGivenToEmployeeID, false);
            MiscUtil.PopulateKBMDUserTreeSharedPermission(ddlUserTreePermissionID, false);
        }

        private void TreeViewSelectedNodeChanged()
        {
            Int64 selectedNodeValue = 0;

            ASTreeViewNode selectedNode = astvMyTree.GetSelectedNode();

            if (selectedNode != null)
            {
                Int64.TryParse(selectedNode.NodeValue.ToString(), out selectedNodeValue);
            }

            _UserTreeID = selectedNodeValue;

            PrepareViewOnSelectedNodeChanged(selectedNodeValue);
        }

        private void PrepareViewOnSelectedNodeChanged(Int64 selectedNodeValue)
        {
            KBUserTreeEntity kBUserTreeEntity = CurrentKBUserTreeEntity;

            btnSavePost.Text = "Save Page";

            if (kBUserTreeEntity.IsNew == false && kBUserTreeEntity.IsDocumentNodeType == true)
            {
                ucCMNERPCommentEntity.PageProcessType = MasterDataConstants.CMNProcessCategory.KNOWLEDGE_BASE;
                ucCMNERPCommentEntity.PageReferenceID = _UserTreeID;

                pnlKBDocumentView.Visible = true;
                pnlCreatePost.Visible = false;
                pnlKBSearchView.Visible = false;

                lblTitle.Text = kBUserTreeEntity.Title.ToString();
                lblDescription.Text = Server.HtmlDecode(kBUserTreeEntity.Description);
                lblTagKeyword.Text = kBUserTreeEntity.TagKeyword;

                BindDropdownForSharedInfo();

                BindKBUserTreeSharedList();

                BindKBUserTreeUploadInfoOperationList();

                BindKBUserTreeUploadInfoList();
                BindKBUserTreeModifiedHistoryInfoList();

                if (kBUserTreeEntity.UserTreeStatusID == MasterDataConstants.KBMDUserTreeStatus.MAKE_IT_PUBLIC)
                {
                    btnCreatePost.Visible = false;
                    btnArchiveAndUnshare.Visible = false;
                    btnShareAndPermission.Visible = false;
                    btnMarkNotinUse.Visible = false;
                    btnCanShare.Visible = false;
                    btnUploadInfo.Visible = false;
                    dvAdditionalInfo.Visible = false;
                }
            }

            if (kBUserTreeEntity.IsDocumentNodeType == false)
            {
                btnCreatePost.Text = "Create Page";
                btnCreatePost.Visible = true;
                btnArchiveAndUnshare.Visible = false;
                btnShareAndPermission.Visible = false;
                btnMarkNotinUse.Visible = false;
                btnCanShare.Visible = false;
                btnUploadInfo.Visible = false;
                btnTransferOwnership.Visible = false;
                dvAdditionalInfo.Visible = false;

                pnlKBDocumentView.Visible = false;
                pnlCreatePost.Visible = false;
                pnlKBSearchView.Visible = false;

            }

            if (kBUserTreeEntity.OwnerEmployeeID == CurrentemployeeID && kBUserTreeEntity.IsDocumentNodeType == true)
            {
                btnCreatePost.Text = "Update Page";
                btnCreatePost.Visible = true;
                btnArchiveAndUnshare.Visible = true;
                btnShareAndPermission.Visible = true;
                btnMarkNotinUse.Visible = true;
                btnCanShare.Visible = false;
                btnUploadInfo.Visible = true;
                dvAdditionalInfo.Visible = true;
                lnkShareInfo.Visible = true;
                hypUploadInfo.Visible = true;

                BindDropdownForSharedInfo();

                BindKBUserTreeUploadInfoOperationList();
                BindKBUserTreeSharedList();
            }

            #region Ajax Rating

            String fe1 = SqlExpressionBuilder.PrepareFilterExpression(CMNFavoriteEntity.FLD_NAME_ProcessCategoryID, MasterDataConstants.CMNProcessCategory.KNOWLEDGE_BASE.ToString(), SQLMatchType.Equal);
            String fe2 = SqlExpressionBuilder.PrepareFilterExpression(CMNFavoriteEntity.FLD_NAME_ReferenceID, selectedNodeValue.ToString(), SQLMatchType.Equal);
            String fe3 = SqlExpressionBuilder.PrepareFilterExpression(CMNFavoriteEntity.FLD_NAME_EmployeeID, CurrentemployeeID.ToString(), SQLMatchType.Equal);
            String fe4 = SqlExpressionBuilder.PrepareFilterExpression(fe1, SQLJoinType.AND, fe2);
            String fe = SqlExpressionBuilder.PrepareFilterExpression(fe3, SQLJoinType.AND, fe4);

            IList<CMNFavoriteEntity> lst = FCCCMNFavorite.GetFacadeCreate().GetIL(null, null, String.Empty, fe, DatabaseOperationType.LoadWithFilterExpression);

            if (lst != null && lst.Count > 0)
            {
                ThaiRating.CurrentRating = 1;
            }
            else
            {
                ThaiRating.CurrentRating = 0;
            }

            #endregion

            if (kBUserTreeEntity.IsDocumentNodeType == true)
            {
                if (this.Page.User.Identity.IsAuthenticated == true)
                {
                    if (Roles.IsUserInRole(this.Page.User.Identity.Name, "Admin") == true)
                    {
                        btnTransferOwnership.Visible = true;
                    }
                }

                btnCreatePost.Text = "Edit Page";

                KBUserTreeSharedEntity lstUser = (from s in kBUserTreeSharedEntityList
                                                  where s.UserTreeID == _UserTreeID
                                                  select s).FirstOrDefault();
                

                if (lstUser != null && lstUser.UserTreeID > 0)
                {
                    switch (lstUser.UserTreePermissionID)
                    {
                        case MasterDataConstants.KBMDUserTreeSharedPermission.CAN_EDIT:
                            btnCreatePost.Visible = true;
                            btnArchiveAndUnshare.Visible = false;
                            btnShareAndPermission.Visible = true;
                            btnMarkNotinUse.Visible = false;
                            btnCanShare.Visible = false;
                            btnUploadInfo.Visible = true;
                            dvAdditionalInfo.Visible = true;
                            lnkShareInfo.Visible = true;
                            hypUploadInfo.Visible = true;
                            BindKBUserTreeUploadInfoOperationList();
                            BindKBUserTreeSharedList();
                            break;
                        case MasterDataConstants.KBMDUserTreeSharedPermission.CAN_SHARE:
                            btnCanShare.Visible = true;
                            btnCreatePost.Visible = false;
                            btnArchiveAndUnshare.Visible = false;
                            btnShareAndPermission.Visible = false;
                            btnMarkNotinUse.Visible = false;
                            btnUploadInfo.Visible = false;
                            dvAdditionalInfo.Visible = true;
                            hypUploadInfo.Visible = false;
                            lnkShareInfo.Visible = true;
                            BindKBUserTreeSharedList();
                            break;
                        case MasterDataConstants.KBMDUserTreeSharedPermission.CAN_VIEW:
                            btnCreatePost.Visible = false;
                            btnArchiveAndUnshare.Visible = false;
                            btnShareAndPermission.Visible = false;
                            btnMarkNotinUse.Visible = false;
                            btnCanShare.Visible = false;
                            btnUploadInfo.Visible = false;
                            dvAdditionalInfo.Visible = false;
                            break;
                    }
                }
            }
        }

        private KBUserTreeEntity BuildKBUserTreeEntity()
        {
            KBUserTreeEntity kBUserTreeEntity = CurrentKBUserTreeEntity;

            kBUserTreeEntity.ParentUserTreeID = GetParentNodeFromTreeSelection();

            kBUserTreeEntity.IsDocumentNodeType = false;
            kBUserTreeEntity.Title = txtName.Text.Trim();
            kBUserTreeEntity.Description = "Auto Generated Description for Wiki Category";
            kBUserTreeEntity.ReferenceID = 1; //Need To assign here project ID or others based on Storgae type ID.
            kBUserTreeEntity.TagKeyword = null;
            kBUserTreeEntity.IsStarred = false;
            kBUserTreeEntity.IsRemoved = false;

            Int64 employeeID = MiscUtil.GetCurrentEmployeeByMemberID(CurrentMember);

            if (employeeID > 0)
            {
                kBUserTreeEntity.OwnerEmployeeID = employeeID;
                kBUserTreeEntity.CreatedByEmployeeID = employeeID;
                kBUserTreeEntity.CreateDate = System.DateTime.Now;
                kBUserTreeEntity.CountViewState = 0;
            }

            kBUserTreeEntity.DocumentSize = null;
            kBUserTreeEntity.IP = MiscUtil.GetLocalIP();

            if (chkIsMakeItPublic.Checked)
            {
                kBUserTreeEntity.UserTreeStatusID = MasterDataConstants.KBMDUserTreeStatus.MAKE_IT_PUBLIC;
            }
            else
            {
                kBUserTreeEntity.UserTreeStatusID = MasterDataConstants.KBMDUserTreeStatus.REGULAR;
            }

            kBUserTreeEntity.LastModifiedDate = System.DateTime.Now;

            return kBUserTreeEntity;
        }

        private void SaveKBUserTreeEntity()
        {
            if (IsValid)
            {
                try
                {
                    KBUserTreeEntity kBUserTreeEntity = BuildKBUserTreeEntity();

                    Int64 result = -1;

                    result = FCCKBUserTree.GetFacadeCreate().Add(kBUserTreeEntity, DatabaseOperationType.Add, TransactionRequired.No);

                    if (result > 0)
                    {
                        //if (kBUserTreeEntity.UserTreeStatusID == MasterDataConstants.KBMDUserTreeStatus.MAKE_IT_PUBLIC)
                        //{
                        //    String fe_shared = SqlExpressionBuilder.PrepareFilterExpression(KBUserTreeSharedEntity.FLD_NAME_UserTreeID,result.ToString(),SQLMatchType.Equal);
                        //    IList<KBUserTreeSharedEntity> lstSharedEntity = FCCKBUserTreeShared.GetFacadeCreate().GetIL(null, null, String.Empty, fe_shared, DatabaseOperationType.LoadWithFilterExpression);

                        //    if (lstSharedEntity != null && lstSharedEntity.Count > 0)
                        //    {
                        //        Int64 resultC = -1;
                        //        KBUserTreeSharedEntity kBUserTreeSharedEntity=new KBUserTreeSharedEntity();

                        //        resultC = FCCKBUserTreeShared.GetFacadeCreate().Delete(kBUserTreeSharedEntity, fe_shared, DatabaseOperationType.Delete, TransactionRequired.No);

                        //        if (resultC == 0)
                        //        {
                        //            //Successfully Deleted.
                        //        }
                        //    }
                        //}

                        _UserTreeID = 0;
                        _KBUserTreeEntity = new KBUserTreeEntity();
                        PrepareInitialView();
                        BindDMSDocumentNodeList();
                        BuildKBUserTree();

                        MiscUtil.ShowMessage(lblMessage, "User Tree Information has been added successfully.", false);
                    }
                    else
                    {   
                        MiscUtil.ShowMessage(lblMessage, "Failed to add User Tree Node Information.", false);
                    }
                }
                catch (Exception ex)
                {
                    MiscUtil.ShowMessage(lblMessage, ex.Message, true);
                }
            }
        }

        private KBUserTreeEntity BuildPostKBUserTreeEntity()
        {
            KBUserTreeEntity kBUserTreeEntity = CurrentKBUserTreeEntity;

            if (kBUserTreeEntity.IsDocumentNodeType == false)
            {   
                kBUserTreeEntity.ParentUserTreeID = GetParentNodeFromTreeSelection();
            }

            kBUserTreeEntity.IsDocumentNodeType = true;
            kBUserTreeEntity.Title = txtTitle.Text.Trim();

            if (txtDescription.Content.Trim().IsNotNullOrEmpty())
            {
                kBUserTreeEntity.Description = txtDescription.Content.Trim();
            }

            kBUserTreeEntity.ReferenceID = 1; //Need To assign here project ID or others based on Storgae type ID.
            kBUserTreeEntity.TagKeyword = txtTagKeyword.Text.Trim();
            kBUserTreeEntity.IsStarred = false;
            kBUserTreeEntity.IsRemoved = false;
            Int64 employeeID = MiscUtil.GetCurrentEmployeeByMemberID(CurrentMember);

            if (employeeID > 0)
            {
                kBUserTreeEntity.OwnerEmployeeID = employeeID;
                kBUserTreeEntity.CreatedByEmployeeID = employeeID;
                kBUserTreeEntity.CreateDate = System.DateTime.Now;
                kBUserTreeEntity.CountViewState = 0;
            }

            kBUserTreeEntity.DocumentSize = null;
            kBUserTreeEntity.IP = MiscUtil.GetLocalIP();

            if (chkIsMakeItPublic.Checked)
            {
                kBUserTreeEntity.UserTreeStatusID = MasterDataConstants.KBMDUserTreeStatus.MAKE_IT_PUBLIC;
            }
            else
            {
                kBUserTreeEntity.UserTreeStatusID = MasterDataConstants.KBMDUserTreeStatus.REGULAR;
            }
            kBUserTreeEntity.LastModifiedDate = System.DateTime.Now;

            return kBUserTreeEntity;
        }

        private void SavePostKBUserTreeEntity()
        {
            if (IsValid)
            {
                try
                {
                    KBUserTreeEntity kBUserTreeEntity = BuildPostKBUserTreeEntity();

                    Int64 result = -1;

                    //if (kBUserTreeEntity.IsNew)
                    //{
                    //    result = FCCKBUserTree.GetFacadeCreate().Add(kBUserTreeEntity, DatabaseOperationType.Add, TransactionRequired.No);
                    //}
                    //else
                    //{
                    //    String filterExpression = SqlExpressionBuilder.PrepareFilterExpression(KBUserTreeEntity.FLD_NAME_UserTreeID, kBUserTreeEntity.UserTreeID.ToString(), SQLMatchType.Equal);
                    //    result = FCCKBUserTree.GetFacadeCreate().Update(kBUserTreeEntity, filterExpression, DatabaseOperationType.Update, TransactionRequired.No);
                    //}

                    if (Action == "Add")
                    {
                        result = FCCKBUserTree.GetFacadeCreate().Add(kBUserTreeEntity, DatabaseOperationType.Add, TransactionRequired.No);
                    }
                    else if (Action == "Update")
                    {
                        String filterExpression = SqlExpressionBuilder.PrepareFilterExpression(KBUserTreeEntity.FLD_NAME_UserTreeID, kBUserTreeEntity.UserTreeID.ToString(), SQLMatchType.Equal);
                        result = FCCKBUserTree.GetFacadeCreate().Update(kBUserTreeEntity, filterExpression, DatabaseOperationType.Update, TransactionRequired.No);
                    }

                    if (result > 0)
                    {
                        if (Action == "Add")
                        {
                            Action = "Update";
                        }
                        _UserTreeID = result;
                        //_KBUserTreeEntity = CurrentKBUserTreeEntity;
                        PrepareInitialViewUserTree();
                        PrepareEditViewUserTree();
                        //hypUploadInfo.NavigateUrl = UrlHelper.BuildSecureUrl("~/KB/KBUserTreeUploadInfo.aspx",
                        //                                String.Empty, UrlConstants.OVERVIEW_USER_TREE_ID.ToString(),
                        //                                result.ToString()).ToString();
                        //hypShareInfo.NavigateUrl = UrlHelper.BuildSecureUrl("~/KB/KBUserTreeShared.aspx",
                        //                                String.Empty, UrlConstants.OVERVIEW_USER_TREE_ID.ToString(),
                        //                                result.ToString()).ToString();
                        //hypShareInfo.Target = "_blank";
                       // hypUploadInfo.Target = "_blank";
                        dvAdditionalInfo.Visible = true;
                        BuildKBUserTree();

                        MiscUtil.ShowMessage(lblMessage, "User Tree Information has been added successfully.", false);
                    }
                    else
                    {
                        MiscUtil.ShowMessage(lblMessage, "Failed to add User Tree Node Information.", false);
                    }
                }
                catch (Exception ex)
                {
                    MiscUtil.ShowMessage(lblMessage, ex.Message, true);
                }
            }
        }

        private void UpdateStatusAndDeleteSharedInfo(Int64 UserTreestatus,Int64 parentUserTreeID)
        {
            KBUserTreeEntity kBUserTreeEntity = CurrentKBUserTreeEntity;
            kBUserTreeEntity.UserTreeStatusID = UserTreestatus;
            kBUserTreeEntity.ParentUserTreeID = parentUserTreeID;

            Int64 result = -1;

            String fe = SqlExpressionBuilder.PrepareFilterExpression(KBUserTreeEntity.FLD_NAME_UserTreeID, kBUserTreeEntity.UserTreeID.ToString(), SQLMatchType.Equal);
            result = FCCKBUserTree.GetFacadeCreate().Update(kBUserTreeEntity, fe, DatabaseOperationType.Update, TransactionRequired.No);

            if (result > 0)
            {
                String fe_shared = SqlExpressionBuilder.PrepareFilterExpression(KBUserTreeSharedEntity.FLD_NAME_UserTreeID, kBUserTreeEntity.UserTreeID.ToString(), SQLMatchType.Equal);
                IList<KBUserTreeSharedEntity> lst = FCCKBUserTreeShared.GetFacadeCreate().GetIL(null, null, String.Empty, fe_shared, DatabaseOperationType.LoadWithFilterExpression);

                if (lst != null && lst.Count > 0)
                {
                    foreach (KBUserTreeSharedEntity ent in lst)
                    {
                        String fe_delete = SqlExpressionBuilder.PrepareFilterExpression(KBUserTreeSharedEntity.FLD_NAME_UserTreeSharedID, ent.UserTreeSharedID.ToString(), SQLMatchType.Equal);
                        FCCKBUserTreeShared.GetFacadeCreate().Delete(ent, fe_delete, DatabaseOperationType.Delete, TransactionRequired.No);
                    }
                }
                MiscUtil.ShowMessage(lblMessage, "Sucessfully Updated", false);
                BuildKBUserTree();
            }
            else
            {
                MiscUtil.ShowMessage(lblMessage, "Some Error Occured", true);
            }
        }

        private CMNFavoriteEntity BuildCMNFavoriteEntity()
        {
            CMNFavoriteEntity cMNFavoriteEntity = CurrentCMNFavoriteEntity;

            cMNFavoriteEntity.ProcessCategoryID = MasterDataConstants.CMNProcessCategory.KNOWLEDGE_BASE;

            Int64 selectedNodeValue = 1;

            ASTreeViewNode selectedNode = astvMyTree.GetSelectedNode();

            if (selectedNode != null)
            {
                Int64.TryParse(selectedNode.NodeValue.ToString(), out selectedNodeValue);
            }

            cMNFavoriteEntity.ReferenceID = selectedNodeValue;
            cMNFavoriteEntity.FavoriteDate = System.DateTime.Now;
            cMNFavoriteEntity.EmployeeID = CurrentemployeeID;

            cMNFavoriteEntity.Remarks = "Auto Remarks";
            cMNFavoriteEntity.IsRemoved = false;


            return cMNFavoriteEntity;
        }

        private void SaveCMNFavoriteEntity()
        {
            if (IsValid)
            {
                try
                {
                    CMNFavoriteEntity cMNFavoriteEntity = BuildCMNFavoriteEntity();

                    Int64 result = -1;

                    if (cMNFavoriteEntity.IsNew)
                    {
                        result = FCCCMNFavorite.GetFacadeCreate().Add(cMNFavoriteEntity, DatabaseOperationType.Add, TransactionRequired.No);
                    }
                    else
                    {
                        String filterExpression = SqlExpressionBuilder.PrepareFilterExpression(CMNFavoriteEntity.FLD_NAME_FavoriteID, cMNFavoriteEntity.FavoriteID.ToString(), SQLMatchType.Equal);
                        result = FCCCMNFavorite.GetFacadeCreate().Update(cMNFavoriteEntity, filterExpression, DatabaseOperationType.Update, TransactionRequired.No);
                    }

                    if (result > 0)
                    {
                        _FavoriteID = 0;
                        _CMNFavoriteEntity = new CMNFavoriteEntity();

                        if (cMNFavoriteEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Favorite Information has been added successfully.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Favorite Information has been updated successfully.", false);
                        }
                    }
                    else
                    {
                        if (cMNFavoriteEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to add Favorite Information.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to update Favorite Information.", false);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MiscUtil.ShowMessage(lblMessage, ex.Message, true);
                }
            }
        }

        private void EditedNodeSaveToKBUserEntity(String editedText)
        {
            try
            {
                Int64 result = -1;

                String fe = SqlExpressionBuilder.PrepareFilterExpression(KBUserTreeEntity.FLD_NAME_UserTreeID, _UserTreeID.ToString(), SQLMatchType.Equal);
                KBUserTreeEntity kBUserTreeEntity = CurrentKBUserTreeEntity;
                kBUserTreeEntity.Title = editedText.ToString();

                result = FCCKBUserTree.GetFacadeCreate().Update(kBUserTreeEntity, fe, DatabaseOperationType.Update, TransactionRequired.No);

                if (result > 0)
                {
                    _UserTreeID = result;
                    PrepareInitialViewUserTree();
                    PrepareEditViewUserTree();
                    BuildKBUserTree();

                    MiscUtil.ShowMessage(lblMessage, "User Tree Info been successfully Renamed.", false);
                }
                else
                {
                    MiscUtil.ShowMessage(lblMessage, "Failed to rename User Tree Info.", true);
                }
            }
            catch (Exception ex)
            {
                MiscUtil.ShowMessage(lblMessage, ex.Message, true);
            }
        }

        #region Common Method

        private Int64 GetParentNodeFromTreeSelection()
        {
            Int64 selectedNodeValue = 0;

            ASTreeViewNode selectedNode = astvMyTree.GetSelectedNode();

            if (selectedNode != null)
            {
                Int64.TryParse(selectedNode.NodeValue.ToString(), out selectedNodeValue);
            }

            Int64 parentNodeID = 0;

            

            if (selectedNodeValue != 0)
            {

                if (selectedNodeValue == MasterDataConstants.KBUserTreeDefault.ARCHIEVE
                    || selectedNodeValue == MasterDataConstants.KBUserTreeDefault.MARK_NOT_IN_USE)
                {
                    return 1;
                }

                else
                {
                    KBUserTreeEntity lst = FCCKBUserTree.GetFacadeCreate().GetByID(selectedNodeValue);

                    if (lst != null && lst.UserTreeID > 0)
                    {
                        if (lst.IsDocumentNodeType == true)
                        {
                            return 1;
                        }
                        parentNodeID = selectedNodeValue;
                    }
                }

            }
            else
            {
                parentNodeID = 1;
            }

            return parentNodeID;
        }

        #endregion

        #endregion

        #region Event

        #region Page Event

        protected void Page_Load(object sender, EventArgs e)
        {
            afuFiles.UploadedComplete += new EventHandler<AsyncFileUploadEventArgs>(afuFiles_UploadedComplete);
            afuFiles.UploadedFileError += new EventHandler<AsyncFileUploadEventArgs>(afuFiles_UploadedFileError);

            ucCMNERPCommentEntity.PageProcessType = MasterDataConstants.CMNProcessCategory.KNOWLEDGE_BASE;

            Int64 selectedNodeValue = 1;

            ASTreeViewNode selectedNode = astvMyTree.GetSelectedNode();

            if (selectedNode != null)
            {
                Int64.TryParse(selectedNode.NodeValue.ToString(), out selectedNodeValue);
            }

            ucCMNERPCommentEntity.PageReferenceID = selectedNodeValue;


            if (!IsPostBack)
            {
                PrepareValidator();
                PrepareInitialView();
                PrepareEditView();
                BuildKBUserTree();
            }
        }

        #endregion

        #region List View Event

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
            SaveKBUserTreeEntity();
        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            BindKBUserTreeList();
            pnlKBDocumentView.Visible = false;
            pnlCreatePost.Visible = false;
            pnlKBSearchView.Visible = true;
        }

        protected void btnSavePost_Click(object sender, EventArgs e)
        {
            SavePostKBUserTreeEntity();
        }

        protected void btnPreview_Click(object sender, EventArgs e)
        {
            if (_UserTreeID > 0)
            {
                PrepareViewOnSelectedNodeChanged(_UserTreeID);
                astvMyTree.SelectNode(_UserTreeID.ToString());
                btnSavePost.Text = "Save Page";
            }
        }

        protected void btnCreatePost_Click(object sender, EventArgs e)
        {
            pnlKBDocumentView.Visible = false;
            pnlCreatePost.Visible = true;
            pnlKBSearchView.Visible = false;

            BindDropdownForSharedInfo();

            BindKBUserTreeSharedList();

            BindKBUserTreeUploadInfoOperationList();

            Int64 selectedNodeValue = 0;

            ASTreeViewNode selectedNode = astvMyTree.GetSelectedNode();

            if (selectedNode != null)
            {
                Int64.TryParse(selectedNode.NodeValue.ToString(), out selectedNodeValue);
            }

            _UserTreeID = selectedNodeValue;

            PrepareDocumentView();
        }

        private void PrepareDocumentView()
        {
            KBUserTreeEntity kBUserTreeEntity = CurrentKBUserTreeEntity;

            switch (kBUserTreeEntity.IsDocumentNodeType)
            {
                case true:
                    PrepareEditViewUserTree();
                    Action = "Update";

                    //hypUploadInfo.NavigateUrl = UrlHelper.BuildSecureUrl("~/KB/KBUserTreeUploadInfo.aspx",
                    //                                    String.Empty, UrlConstants.OVERVIEW_USER_TREE_ID.ToString(),
                    //                                    _UserTreeID.ToString()).ToString();

                    //hypUploadInfo.Target = "_blank";
                    dvAdditionalInfo.Visible = true;
                    break;
                case false:
                    PrepareInitialViewUserTree();
                    dvAdditionalInfo.Visible = false;
                    Action = "Add";
                    break;
            }
        }

        protected void btnClick_Click(object sender, EventArgs e)
        {
            BindKBUserTreeUploadInfoOperationList();
            //BuildKBUserTree();
        }

        #endregion

        #region Treeview Event

        protected void astvMyTree_OnSelectedNodeChanged(object src, ASTreeViewNodeSelectedEventArgs e)
        {
            TreeViewSelectedNodeChanged();
        }

        #endregion

        #region ObjectDataSource Event(Upload File)

        protected void odsKBUserTreeUploadInfo_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {
            String fe = SqlExpressionBuilder.PrepareFilterExpression(KBUserTreeUploadInfoEntity.FLD_NAME_UserTreeID, _UserTreeID.ToString(), SQLMatchType.Equal);
            e.InputParameters["filterExpression"] = fe;
        }

        #endregion

        #region File Uploader Events

        protected void afuFiles_UploadedComplete(object sender, AsyncFileUploadEventArgs e)
        {
            KBUserTreeUploadInfoEntity ent = new KBUserTreeUploadInfoEntity();
            ent.UserTreeID =_UserTreeID;
            ent.OriginalFileName = Path.GetFileName(e.FileName);
            ent.CurrentFileName = Guid.NewGuid().ToString() + Path.GetExtension(e.FileName);
            ent.FileType = "";
            ent.Extension = Path.GetExtension(e.FileName);
            ent.Path = FileUploadConstants.KBUserTree.KBDocument + ent.CurrentFileName;
            ent.Remarks = String.Empty;

            FCCKBUserTreeUploadInfo.GetFacadeCreate().Add(ent, DatabaseOperationType.Add, TransactionRequired.No);

            // file upload

            afuFiles.SaveAs(Server.MapPath(ent.Path));

            //LoadFileListGried
            BindKBUserTreeUploadInfoList();

            this.ModalPopupExtenderUploadInfo.Show();
        }

        protected void afuFiles_UploadedFileError(object sender, AsyncFileUploadEventArgs e)
        {
            //ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "error", "top.$get(\"" + uploadResult.ClientID + "\").innerHTML = 'Error: " + e.StatusMessage + "';", true);
        }

        #endregion

        #region Tree Related Button Event

        protected void btnPostBackTrigger_Click(object sender, EventArgs e)
        {   
            String deletedNodeId = this.txtIDContainer.Text;

            Int64 userTreeID = 0;
            userTreeID = Int64.Parse(deletedNodeId.ToString());

            if (userTreeID > 0)
            {
                _UserTreeID = userTreeID;

                if (ValidatePermission())
                {
                    try
                    {
                        Int64 result = -1;

                        String fe = SqlExpressionBuilder.PrepareFilterExpression(KBUserTreeEntity.FLD_NAME_UserTreeID, _UserTreeID.ToString(), SQLMatchType.Equal);
                        KBUserTreeEntity kbUserTreeEntity = new KBUserTreeEntity();
                        result = FCCKBUserTree.GetFacadeCreate().Delete(kbUserTreeEntity, fe, DatabaseOperationType.Delete, TransactionRequired.No);

                        if (result == 0)
                        {
                            _UserTreeID = 0;
                            _KBUserTreeEntity = new KBUserTreeEntity();

                            BuildKBUserTree();

                            MiscUtil.ShowMessage(lblMessage, "User Tree Info has been successfully deleted.", true);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to delete User Tree Info.", true);
                            BuildKBUserTree();
                        }
                    }
                    catch (Exception ex)
                    {
                        MiscUtil.ShowMessage(lblMessage, ex.Message, true);
                        BuildKBUserTree();
                    }
                }
                else
                {
                    BuildKBUserTree();
                }
            }
        }

        protected void btnPostBackDNDTrigger_Click(object sender, EventArgs e)
        {
            String curNodeValue = this.txtCurrentNode.Text;
            String newParentValue = this.txtNewParentNode.Text;
            
            if (curNodeValue != "")
            {
                Int64 userTreeID = 0;
                userTreeID = Int64.Parse(curNodeValue.ToString());
                _UserTreeID = userTreeID;

                try
                {
                    //Int64 result = -1;

                    //String fe = SqlExpressionBuilder.PrepareFilterExpression(DMSDocumentNodeEntity.FLD_NAME_DocumentNodeID, DocumentNodeID.ToString(), SQLMatchType.Equal);
                    //DMSDocumentNodeEntity dMSDocumentNodeEntity = CurrentDMSDocumentNodeEntity;
                    //dMSDocumentNodeEntity.ParentDocumentNodeID = Int64.Parse(newParentValue.ToString()); // New Parent Value.
                    //dMSDocumentNodeEntity.UploadedByMemberID = this.CurrentMember.MemberID;

                    //result = FCCDMSDocumentNode.GetFacadeCreate().Update(dMSDocumentNodeEntity, fe, DatabaseOperationType.Update, TransactionRequired.No);

                    //if (result > 0)
                    //{
                    //    _DocumentNodeID = 0;
                    //    _DMSDocumentNodeEntity = new DMSDocumentNodeEntity();
                    //    PrepareInitialView();
                    //    BindDMSDocumentNodeList();
                    //    BuildKBUserTree();
                    //}
                    //else
                    //{
                    //    MiscUtil.ShowMessage(lblMessage, "Failed to DND Document Node.", true);
                    //}
                }
                catch (Exception ex)
                {
                    MiscUtil.ShowMessage(lblMessage, ex.Message, true);
                }
            }
        }

        protected void btnPostBackEditedTrigger_Click(object sender, EventArgs e)
        {
            String deletedNodeId = this.txtIDEditedContainer.Text;

            ASTreeViewNode selectedNode = astvMyTree.GetSelectedNode();
            String editedText =String.Empty;

            if (selectedNode != null)
            {
                editedText = selectedNode.NodeText;
            }

            Int64 userTreeID = 0;
            userTreeID = Int64.Parse(deletedNodeId.ToString());

            if (userTreeID > 0)
            {
                _UserTreeID = userTreeID;

                if (ValidatePermission())
                {
                    EditedNodeSaveToKBUserEntity(editedText);
                }

                else
                {
                    BuildKBUserTree();
                }

                //KBUserTreeEntity kBUserTreeEntity = CurrentKBUserTreeEntity;

                //if (kBUserTreeEntity.OwnerEmployeeID == CurrentemployeeID)
                //{
                    
                //}

                //else if (kBUserTreeEntity.OwnerEmployeeID != CurrentemployeeID && kBUserTreeEntity.IsDocumentNodeType==true)
                //{
                //    String fe_shared1=SqlExpressionBuilder.PrepareFilterExpression(KBUserTreeSharedEntity.FLD_NAME_UserTreeID,_UserTreeID.ToString(),SQLMatchType.Equal);
                //    String fe_shared2=SqlExpressionBuilder.PrepareFilterExpression(KBUserTreeSharedEntity.FLD_NAME_SharedGivenToEmployeeID,CurrentemployeeID.ToString(),SQLMatchType.Equal);
                //    String fe_shared=SqlExpressionBuilder.PrepareFilterExpression(fe_shared1,SQLJoinType.AND,fe_shared2);
                //    IList<KBUserTreeSharedEntity> lstkBUserTreeSharedEntity = FCCKBUserTreeShared.GetFacadeCreate().GetIL(null, null, String.Empty, fe_shared, DatabaseOperationType.LoadWithFilterExpression);

                //    if (lstkBUserTreeSharedEntity != null && lstkBUserTreeSharedEntity.Count > 0)
                //    {
                //        if (lstkBUserTreeSharedEntity[0].UserTreePermissionID != MasterDataConstants.KBMDUserTreeSharedPermission.CAN_EDIT)
                //        {
                //            MiscUtil.ShowMessage(lblMessage, "You don't have any Permission to Edit", true);
                //            BuildKBUserTree();
                //        }

                //        else if (lstkBUserTreeSharedEntity[0].UserTreePermissionID == MasterDataConstants.KBMDUserTreeSharedPermission.CAN_EDIT)
                //        {
                //            EditedNodeSaveToKBUserEntity(editedText);
                //        }
                //    }
                //    else
                //    {
                //        MiscUtil.ShowMessage(lblMessage, "You don't have any Permission to Edit", true);
                //        BuildKBUserTree();
                //    }
                //}
                //else
                //{
                //    MiscUtil.ShowMessage(lblMessage, "You don't have any Permission to Edit", true);
                //    BuildKBUserTree();
                //}
            }
        }

        protected void btnPostBackAddedTrigger_Click(object sender, EventArgs e)
        {
            String deletedNodeId = this.txtIDContainer.Text;
        }
       
        #endregion

        #region Panel Option Button Event

        protected void btnTransferOwnership_Click(object sender, EventArgs e)
        {
            KBUserTreeEntity kBUserTreeEntity = CurrentKBUserTreeEntity;
            kBUserTreeEntity.OwnerEmployeeID = CurrentemployeeID;

            Int64 result = -1;
            String fe=SqlExpressionBuilder.PrepareFilterExpression(KBUserTreeEntity.FLD_NAME_UserTreeID,kBUserTreeEntity.UserTreeID.ToString(),SQLMatchType.Equal);
            result=FCCKBUserTree.GetFacadeCreate().Update(kBUserTreeEntity, fe, DatabaseOperationType.Update, TransactionRequired.No);

            if (result > 0)
            {
                MiscUtil.ShowMessage(lblMessage, "Ownership Transferred Successfully.", false);
            }
            else
            {
                MiscUtil.ShowMessage(lblMessage, "Unable to Transfer Ownership.", true);
            }

        }

        protected void btnUploadInfo_Click(object sender, EventArgs e)
        {
            Int64 selectedNodeValue = 0;

            ASTreeViewNode selectedNode = astvMyTree.GetSelectedNode();

            if (selectedNode != null)
            {
                Int64.TryParse(selectedNode.NodeValue.ToString(), out selectedNodeValue);
            }

            if (selectedNodeValue > 0)
            {
                _UserTreeID = selectedNodeValue;
                BindKBUserTreeUploadInfoOperationList();
                this.ModalPopupExtenderUploadInfo.Show();
                //String navUrl = UrlHelper.BuildSecureUrl("~/KB/KBUserTreeUploadInfo.aspx",
                //                                            String.Empty, UrlConstants.OVERVIEW_USER_TREE_ID.ToString(),
                //                                            selectedNodeValue.ToString()).ToString();

            
                //Response.Redirect(navUrl);
            }
        }

        protected void btnMarkNotinUse_Click(object sender, EventArgs e)
        {
            UpdateStatusAndDeleteSharedInfo(MasterDataConstants.KBMDUserTreeStatus.MAKE_NOT_IN_USE, MasterDataConstants.KBUserTreeDefault.MARK_NOT_IN_USE);
        }

        protected void btnArchiveAndUnshare_Click(object sender, EventArgs e)
        {
            UpdateStatusAndDeleteSharedInfo(MasterDataConstants.KBMDUserTreeStatus.ARCHIEVED_AND_UNSHARE, MasterDataConstants.KBUserTreeDefault.ARCHIEVE);
        }

        protected void btnShareAndPermission_Click(object sender, EventArgs e)
        {
            BindDropdownForSharedInfo();
            BindKBUserTreeSharedList();
            this.ModalPopupExtender1.Show();
        }

        protected void btnCanShare_Click(object sender, EventArgs e)
        {
            BindDropdownForSharedInfo();
            BindKBUserTreeSharedList();
            this.ModalPopupExtender1.Show();
        }

        protected void btnSearchPopupSearch_Click(object sender, EventArgs e)
        {
            pnlCreatePost.Visible = false;
            pnlKBDocumentView.Visible = false;
            pnlKBSearchView.Visible = true;
            BindKBUserTreeList();
        }

        #endregion

        #region Shared Modal Popup Button Event

        protected void btnAddShared_Click(object sender, EventArgs e)
        {
            SaveKBUserTreeSharedEntity();
        }

        #endregion

        #region List View Event Shared Modal Popup

        protected void lvKBUserTreeShared_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            Int64 UserTreeSharedID;

            Int64.TryParse(e.CommandArgument.ToString(), out UserTreeSharedID);

            if (UserTreeSharedID > 0)
            {
                if (string.Equals(e.CommandName, "EditItem"))
                {
                    //_UserTreeSharedID = UserTreeSharedID;

                    PrepareEditView();
                }
                else if (string.Equals(e.CommandName, "DeleteItem"))
                {
                    try
                    {
                        Int64 result = -1;

                        String fe = SqlExpressionBuilder.PrepareFilterExpression(KBUserTreeSharedEntity.FLD_NAME_UserTreeSharedID, UserTreeSharedID.ToString(), SQLMatchType.Equal);

                        KBUserTreeSharedEntity kBUserTreeSharedEntity = new KBUserTreeSharedEntity();


                        result = FCCKBUserTreeShared.GetFacadeCreate().Delete(kBUserTreeSharedEntity, fe, DatabaseOperationType.Delete, TransactionRequired.No);

                        if (result == 0)
                        {
                           // _UserTreeSharedID = 0;
                          //  _KBUserTreeSharedEntity = new KBUserTreeSharedEntity();
                          //  PrepareInitialView();
                         //   BindKBUserTreeSharedList();

                            MiscUtil.ShowMessage(lblMessage, "K BUser Tree Shared has been successfully deleted.", true);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to delete K BUser Tree Shared.", true);
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

        #region ObjectDataSource Event Shared Popup

        protected void odsKBUserTreeShared_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {
            String fe = SqlExpressionBuilder.PrepareFilterExpression("KBUserTreeShared." + KBUserTreeSharedEntity.FLD_NAME_UserTreeID, _UserTreeID.ToString(), SQLMatchType.Equal);
            e.InputParameters["filterExpression"] = fe;
        }

        #endregion

        #region ObjectDataSource Event Modified History

        protected void odsKBUserTreeModifiedHistory_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {
            String fe = SqlExpressionBuilder.PrepareFilterExpression(KBUserTreeModifiedHistoryEntity.FLD_NAME_UserTreeID, _UserTreeID.ToString(), SQLMatchType.Equal);
            e.InputParameters["filterExpression"] = fe;
        }

        #endregion

        #region ObjectDataSource Event User Tree

        protected void odsKBUserTree_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {
            String fe = SqlExpressionBuilder.PrepareFilterExpression("KBUserTree." + KBUserTreeEntity.FLD_NAME_UserTreeID, "0", SQLMatchType.Equal);

            if(txtSearch.Text.Trim().IsNotNullOrEmpty())
            {
                String fe1 = SqlExpressionBuilder.PrepareFilterExpression("KBUserTree." + KBUserTreeEntity.FLD_NAME_Title, txtSearch.Text.ToString(), SQLMatchType.LikeWithBothMath);
                String fe2 = SqlExpressionBuilder.PrepareFilterExpression("KBUserTree." + KBUserTreeEntity.FLD_NAME_Description, txtSearch.Text.ToString(), SQLMatchType.LikeWithBothMath);
                String fe3 = "KBUserTree.TagKeyword in('" + txtSearch.Text.ToString() + "')";
                String fe4 = SqlExpressionBuilder.PrepareFilterExpression(fe1, SQLJoinType.OR, fe2);
                fe = SqlExpressionBuilder.PrepareFilterExpression(fe3, SQLJoinType.OR, fe4);
            }

            if (txtSearchCreated.Text.Trim().IsNotNullOrEmpty()
                || txtSearchDescription.Text.Trim().IsNotNullOrEmpty()
                || txtSearchTagKeyword.Text.Trim().IsNotNullOrEmpty()
                || txtSearchTitle.Text.Trim().IsNotNullOrEmpty()
                || chkSearchHasAttachment.Checked)
            {
                if (ddlSearchSelect.Items.Count > 0)
                {
                    if (ddlSearchSelect.SelectedValue != "0")
                    {
                        fe = SqlExpressionBuilder.PrepareFilterExpression("KBUserTree." + KBUserTreeEntity.FLD_NAME_UserTreeID, ddlSearchSelect.SelectedValue.ToString(), SQLMatchType.LikeWithBothMath);
                    }

                    else
                    {
                        fe = " KBUserTree.ParentUserTreeID is not null";
                    }
                }
                String fe1=String.Empty;

                if (txtSearchCreated.Text.Trim().IsNotNullOrEmpty())
                {
                    fe1 = SqlExpressionBuilder.PrepareFilterExpression("MC.FirstName + CASE WHEN MC.MiddleName != '' THEN ' ' + MC.MiddleName ELSE '' END + CASE WHEN MC.MiddleName != NULL	THEN ' ' + MC.MiddleName ELSE '' END + ' ' + MC.LastName", txtSearchCreated.Text.ToString(), SQLMatchType.LikeWithBothMath);
                    String fe2=SqlExpressionBuilder.PrepareFilterExpression("MO.FirstName + CASE WHEN MO.MiddleName != '' THEN ' ' + MO.MiddleName ELSE '' END + CASE WHEN MO.MiddleName != NULL THEN ' ' + MO.MiddleName ELSE '' END + ' ' + MO.LastName AS OwnerMemberFullName", txtSearchCreated.Text.ToString(), SQLMatchType.LikeWithBothMath);
                    fe1 = SqlExpressionBuilder.PrepareFilterExpression(fe1, SQLJoinType.OR, fe2);
                    fe = SqlExpressionBuilder.PrepareFilterExpression(fe, SQLJoinType.AND, fe1);
                }

                if (txtSearchDescription.Text.Trim().IsNotNullOrEmpty())
                {
                    fe1 = SqlExpressionBuilder.PrepareFilterExpression("KBUserTree." + KBUserTreeEntity.FLD_NAME_Description, txtSearchDescription.Text.ToString(), SQLMatchType.LikeWithBothMath);
                    fe = SqlExpressionBuilder.PrepareFilterExpression(fe, SQLJoinType.AND, fe1);
                }
                if (txtSearchTitle.Text.Trim().IsNotNullOrEmpty())
                {
                    fe1 = SqlExpressionBuilder.PrepareFilterExpression("KBUserTree." + KBUserTreeEntity.FLD_NAME_Title, txtSearchTitle.Text.ToString(), SQLMatchType.LikeWithBothMath);
                    fe = SqlExpressionBuilder.PrepareFilterExpression(fe, SQLJoinType.AND, fe1);
                }
                if (txtSearchTagKeyword.Text.Trim().IsNotNullOrEmpty())
                {
                    fe1 = "KBUserTree.TagKeyword in('" + txtSearchTagKeyword.Text.ToString() + "')";
                    fe = SqlExpressionBuilder.PrepareFilterExpression(fe, SQLJoinType.AND, fe1);
                }
                if (chkSearchHasAttachment.Checked)
                {
                    //IList<KBUserTreeUploadInfoEntity> lst = FCCKBUserTreeUploadInfo.GetFacadeCreate().GetIL(null, null, String.Empty, String.Empty, DatabaseOperationType.Load);

                    //if (lst != null && lst.Count > 0)
                    //{
                        //foreach(
                    //}
                    //fe1 = "KBUserTree.TagKeyword in('" + txtTagKeyword.Text.ToString() + "')";
                    //fe = SqlExpressionBuilder.PrepareFilterExpression(fe, SQLJoinType.AND, fe1);
                }
            }

            e.InputParameters["filterExpression"] = fe;
        }

        #endregion

        #region Ajax Rating

        protected void ThaiRating_Changed(object sender, RatingEventArgs e)
        {
            if (e.Value == "1")
            {
            }
            Int64 selectedNodeValue = 1;

            ASTreeViewNode selectedNode = astvMyTree.GetSelectedNode();

            if (selectedNode != null)
            {
                Int64.TryParse(selectedNode.NodeValue.ToString(), out selectedNodeValue);
            }
            
            String fe1=SqlExpressionBuilder.PrepareFilterExpression(CMNFavoriteEntity.FLD_NAME_ProcessCategoryID,MasterDataConstants.CMNProcessCategory.KNOWLEDGE_BASE.ToString(),SQLMatchType.Equal);
            String fe2=SqlExpressionBuilder.PrepareFilterExpression(CMNFavoriteEntity.FLD_NAME_ReferenceID,selectedNodeValue.ToString(),SQLMatchType.Equal);
            String fe=SqlExpressionBuilder.PrepareFilterExpression(fe1,SQLJoinType.AND,fe2);

            IList<CMNFavoriteEntity> lst = FCCCMNFavorite.GetFacadeCreate().GetIL(null, null, String.Empty, fe, DatabaseOperationType.LoadWithFilterExpression);

            if (lst != null && lst.Count > 0)
            {
                String fe_delete = SqlExpressionBuilder.PrepareFilterExpression(CMNFavoriteEntity.FLD_NAME_FavoriteID, lst[0].FavoriteID.ToString(), SQLMatchType.Equal);
                CMNFavoriteEntity cMNFavoriteEntity=new CMNFavoriteEntity();
                FCCCMNFavorite.GetFacadeCreate().Delete(cMNFavoriteEntity, fe_delete, DatabaseOperationType.Delete, TransactionRequired.No);
                //e.CallbackResult = "1";
            }
            else
            {
              //Thread.Sleep(400);
                SaveCMNFavoriteEntity();
            }

            //e.CallbackResult = "Update done. Value = " + e.Value + " Tag = " + e.Tag;
        }

        #endregion

        #region Upload info Operation

        protected void lstKBUserTreeUploadInfoOperation_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            Int64 UserTreeUploadInfoID;

            Int64.TryParse(e.CommandArgument.ToString(), out UserTreeUploadInfoID);

            if (UserTreeUploadInfoID > 0)
            {
                if (string.Equals(e.CommandName, "EditItem"))
                {
                    //_UserTreeUploadInfoID = UserTreeUploadInfoID;

                    PrepareEditView();
                }
                else if (string.Equals(e.CommandName, "DeleteItem"))
                {
                    try
                    {
                        Int64 result = -1;

                        String fe = SqlExpressionBuilder.PrepareFilterExpression(KBUserTreeUploadInfoEntity.FLD_NAME_UserTreeUploadInfoID, UserTreeUploadInfoID.ToString(), SQLMatchType.Equal);

                        KBUserTreeUploadInfoEntity kBUserTreeUploadInfoEntity = new KBUserTreeUploadInfoEntity();


                        result = FCCKBUserTreeUploadInfo.GetFacadeCreate().Delete(kBUserTreeUploadInfoEntity, fe, DatabaseOperationType.Delete, TransactionRequired.No);

                        if (result == 0)
                        {
                            //_UserTreeUploadInfoID = 0;
                           // _KBUserTreeUploadInfoEntity = new KBUserTreeUploadInfoEntity();
                            PrepareInitialView();
                            BindKBUserTreeUploadInfoList();

                            MiscUtil.ShowMessage(lblMessage, "K BUser Tree Upload Info has been successfully deleted.", true);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to delete K BUser Tree Upload Info.", true);
                        }
                    }
                    catch (Exception ex)
                    {
                        MiscUtil.ShowMessage(lblMessage, ex.Message, true);
                    }
                }
            }
        }

        #endregion

        protected void ContentChanged(object sender, EventArgs e)
        {
            //ContentChangedLabel.Text = "<span style='color:red'>Content changed</span>";
        }

        #endregion Event
    }
}
