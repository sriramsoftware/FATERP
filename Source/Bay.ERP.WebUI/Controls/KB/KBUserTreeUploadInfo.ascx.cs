// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 23-Mar-2013, 04:14:01




using System;
using System.Web.UI.WebControls;
using System.Collections.Generic;

using Bay.ERP.Web.UI.Helper;
using Bay.ERP.Common.BusinessEntities;
using Bay.ERP.BusinessFacade;
using Bay.ERP.FacadeCreator.FacadeContext;
using Bay.ERP.Common.Helper;
using Bay.ERP.Common.Shared;
using AjaxControlToolkit;
using System.IO;

namespace Bay.ERP.Web.UI
{
    public partial class KBUserTreeUploadInfoControl : BaseControl
    {       
        #region Properties

        public Int64 _UserTreeUploadInfoID
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

        public KBUserTreeUploadInfoEntity _KBUserTreeUploadInfoEntity
        {
            get
            {
                KBUserTreeUploadInfoEntity entity = new KBUserTreeUploadInfoEntity();

                if (ViewState["CurrentEntity"] != null)
                {
                    entity = (KBUserTreeUploadInfoEntity)ViewState["CurrentEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["CurrentEntity"] = value;
            }
        }

        private KBUserTreeUploadInfoEntity CurrentKBUserTreeUploadInfoEntity
        {
            get
            {
                if (_UserTreeUploadInfoID > 0)
                {
                    if (_KBUserTreeUploadInfoEntity.UserTreeUploadInfoID != _UserTreeUploadInfoID)
                    {
                        _KBUserTreeUploadInfoEntity = FCCKBUserTreeUploadInfo.GetFacadeCreate().GetByID(_UserTreeUploadInfoID);
                    }
                }

                return _KBUserTreeUploadInfoEntity;
            }
            set
            {
                _KBUserTreeUploadInfoEntity = value;
            }
        }

        public Int64 OverviewUserTreeID
        {
            get
            {
                Int64 kBUserTreeID = 0;

                if (!StringHelper.IsBlank(Helper.Url.SecureUrl[UrlConstants.OVERVIEW_USER_TREE_ID]))
                {
                    Int64.TryParse(Helper.Url.SecureUrl[UrlConstants.OVERVIEW_USER_TREE_ID], out kBUserTreeID);
                }

                return kBUserTreeID;
            }
        }

        #endregion

        #region Methods

        private void BuildDropDownList()
        {
          
        }

        private void PrepareValidator()
        {
        }

        private void PrepareInitialView()
        {
            BuildDropDownList();
        }

        private void PrepareEditView()
        {
            KBUserTreeUploadInfoEntity kBUserTreeUploadInfoEntity = CurrentKBUserTreeUploadInfoEntity;


            if (!kBUserTreeUploadInfoEntity.IsNew)
            {
               
            }
        }

        private void BindList()
        {
            BindKBUserTreeUploadInfoList();
        }

        private void BindKBUserTreeUploadInfoList()
        {
            lvKBUserTreeUploadInfo.DataBind();
        }

        private KBUserTreeUploadInfoEntity BuildKBUserTreeUploadInfoEntity()
        {
            KBUserTreeUploadInfoEntity kBUserTreeUploadInfoEntity = CurrentKBUserTreeUploadInfoEntity;

            return kBUserTreeUploadInfoEntity;
        }

        private void SaveKBUserTreeUploadInfoEntity()
        {
            if (IsValid)
            {
                try
                {
                    KBUserTreeUploadInfoEntity kBUserTreeUploadInfoEntity = BuildKBUserTreeUploadInfoEntity();

                    Int64 result = -1;

                    if (kBUserTreeUploadInfoEntity.IsNew)
                    {
                        result = FCCKBUserTreeUploadInfo.GetFacadeCreate().Add(kBUserTreeUploadInfoEntity, DatabaseOperationType.Add, TransactionRequired.No);
                    }
                    else
                    {
                        String filterExpression = SqlExpressionBuilder.PrepareFilterExpression(KBUserTreeUploadInfoEntity.FLD_NAME_UserTreeUploadInfoID, kBUserTreeUploadInfoEntity.UserTreeUploadInfoID.ToString(), SQLMatchType.Equal);
                        result = FCCKBUserTreeUploadInfo.GetFacadeCreate().Update(kBUserTreeUploadInfoEntity, filterExpression, DatabaseOperationType.Update, TransactionRequired.No);
                    }

                    if (result > 0)
                    {
                        _UserTreeUploadInfoID = 0;
                        _KBUserTreeUploadInfoEntity = new KBUserTreeUploadInfoEntity();
                        PrepareInitialView();
                        BindKBUserTreeUploadInfoList();

                        if (kBUserTreeUploadInfoEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "K BUser Tree Upload Info Information has been added successfully.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "K BUser Tree Upload Info Information has been updated successfully.", false);
                        }
                    }
                    else
                    {
                        if (kBUserTreeUploadInfoEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to add K BUser Tree Upload Info Information.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to update K BUser Tree Upload Info Information.", false);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MiscUtil.ShowMessage(lblMessage, ex.Message, true);
                }
            }
        }

        #endregion

        #region Event

        #region Page Event

        protected void Page_Load(object sender, EventArgs e)
        {
            afuFiles.UploadedComplete += new EventHandler<AsyncFileUploadEventArgs>(afuFiles_UploadedComplete);
            afuFiles.UploadedFileError += new EventHandler<AsyncFileUploadEventArgs>(afuFiles_UploadedFileError);

            if (!IsPostBack)
            {
                PrepareValidator();
                PrepareInitialView();
                PrepareEditView();
            }
        }

        #endregion

        #region List View Event

        protected void lvKBUserTreeUploadInfo_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            Int64 UserTreeUploadInfoID;

            Int64.TryParse(e.CommandArgument.ToString(), out UserTreeUploadInfoID);

            if (UserTreeUploadInfoID > 0)
            {
                if (string.Equals(e.CommandName, "EditItem"))
                {
                    _UserTreeUploadInfoID = UserTreeUploadInfoID;

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
                            _UserTreeUploadInfoID = 0;
                            _KBUserTreeUploadInfoEntity = new KBUserTreeUploadInfoEntity();
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

        #endregion List View Event

        #region ObjectDataSource Event

        protected void odsKBUserTreeUploadInfo_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {
            String fe = SqlExpressionBuilder.PrepareFilterExpression(KBUserTreeUploadInfoEntity.FLD_NAME_UserTreeID, OverviewUserTreeID.ToString(), SQLMatchType.Equal);
            e.InputParameters["filterExpression"] = fe;
        }

        #endregion

        #region Button Event

        protected void btnClick_Click(object sender, EventArgs e)
        {
            BindKBUserTreeUploadInfoList();
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            SaveKBUserTreeUploadInfoEntity();
        }

        protected void btnAddNew_Click(object sender, EventArgs e)
        {
            _UserTreeUploadInfoID = 0;
            _KBUserTreeUploadInfoEntity = new KBUserTreeUploadInfoEntity();
            PrepareInitialView();
        }

        protected void btnClear_Click(object sender, EventArgs e)
        {
            PrepareInitialView();
            PrepareEditView();
        }

        #endregion

        #region File Uploader Events

        protected void afuFiles_UploadedComplete(object sender, AsyncFileUploadEventArgs e)
        {
            KBUserTreeUploadInfoEntity ent = new KBUserTreeUploadInfoEntity();
            ent.UserTreeID = this.OverviewUserTreeID;
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
        }

        protected void afuFiles_UploadedFileError(object sender, AsyncFileUploadEventArgs e)
        {
            //ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "error", "top.$get(\"" + uploadResult.ClientID + "\").innerHTML = 'Error: " + e.StatusMessage + "';", true);
        }

        #endregion

        #endregion Event
    }
}
