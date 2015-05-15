// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 30-Nov-2011, 02:49:46




using System;
using System.Web.UI.WebControls;
using System.Collections.Generic;

using Bay.ERP.Web.UI.Helper;
using Bay.ERP.Common.BusinessEntities;
using Bay.ERP.BusinessFacade;
using Bay.ERP.FacadeCreator.FacadeContext;
using Bay.ERP.Common.Helper;
using Bay.ERP.Common.Shared;

namespace Bay.ERP.Web.UI
{
    public partial class BDProjectCollectedDocumentUploadInfoControl : ProjectBaseControl
    {       
        #region Properties

        public Int64 _ProjectCollectedDocumentUploadInfoID
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

        public BDProjectCollectedDocumentUploadInfoEntity _BDProjectCollectedDocumentUploadInfoEntity
        {
            get
            {
                BDProjectCollectedDocumentUploadInfoEntity entity = new BDProjectCollectedDocumentUploadInfoEntity();

                if (ViewState["CurrentEntity"] != null)
                {
                    entity = (BDProjectCollectedDocumentUploadInfoEntity)ViewState["CurrentEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["CurrentEntity"] = value;
            }
        }

        private BDProjectCollectedDocumentUploadInfoEntity CurrentBDProjectCollectedDocumentUploadInfoEntity
        {
            get
            {
                if (_ProjectCollectedDocumentUploadInfoID > 0)
                {
                    if (_BDProjectCollectedDocumentUploadInfoEntity.ProjectCollectedDocumentUploadInfoID != _ProjectCollectedDocumentUploadInfoID)
                    {
                        _BDProjectCollectedDocumentUploadInfoEntity = FCCBDProjectCollectedDocumentUploadInfo.GetFacadeCreate().GetByID(_ProjectCollectedDocumentUploadInfoID);
                    }
                }

                return _BDProjectCollectedDocumentUploadInfoEntity;
            }
            set
            {
                _BDProjectCollectedDocumentUploadInfoEntity = value;
            }
        }

        #endregion

        #region Methods

        private void BuildDropDownList()
        {
            MiscUtil.PopulateBDProjectCollectedDocumentInfo(ddlProjectCollectedDocumentInfoID, false);
        }

        private void PrepareValidator()
        {
        }

        private void PrepareInitialView()
        {
            BuildDropDownList();

            txtRemarks.Text = String.Empty;
            txtPath.Text = String.Empty;
            txtOriginalFileName.Text = String.Empty;
            txtCurrentFileName.Text = String.Empty;
            txtFileType.Text = String.Empty;
            txtExtension.Text = String.Empty;

            btnSubmit.Text = "Add";
            btnAddNew.Visible = false;
        }

        private void PrepareEditView()
        {
            BDProjectCollectedDocumentUploadInfoEntity bDProjectCollectedDocumentUploadInfoEntity = CurrentBDProjectCollectedDocumentUploadInfoEntity;


            if (!bDProjectCollectedDocumentUploadInfoEntity.IsNew)
            {
                if (ddlProjectCollectedDocumentInfoID.Items.Count > 0 && bDProjectCollectedDocumentUploadInfoEntity.ProjectCollectedDocumentInfoID != null)
                {
                    ddlProjectCollectedDocumentInfoID.SelectedValue = bDProjectCollectedDocumentUploadInfoEntity.ProjectCollectedDocumentInfoID.ToString();
                }

                txtRemarks.Text = bDProjectCollectedDocumentUploadInfoEntity.Remarks.ToString();
                txtPath.Text = bDProjectCollectedDocumentUploadInfoEntity.Path.ToString();
                txtOriginalFileName.Text = bDProjectCollectedDocumentUploadInfoEntity.OriginalFileName.ToString();
                txtCurrentFileName.Text = bDProjectCollectedDocumentUploadInfoEntity.CurrentFileName.ToString();
                txtFileType.Text = bDProjectCollectedDocumentUploadInfoEntity.FileType.ToString();
                txtExtension.Text = bDProjectCollectedDocumentUploadInfoEntity.Extension.ToString();

                btnSubmit.Text = "Update";
                btnAddNew.Visible = true;
            }
        }

        private void BindList()
        {
            BindBDProjectCollectedDocumentUploadInfoList();
        }

        private void BindBDProjectCollectedDocumentUploadInfoList()
        {
            lvBDProjectCollectedDocumentUploadInfo.DataBind();
        }

        private BDProjectCollectedDocumentUploadInfoEntity BuildBDProjectCollectedDocumentUploadInfoEntity()
        {
            BDProjectCollectedDocumentUploadInfoEntity bDProjectCollectedDocumentUploadInfoEntity = CurrentBDProjectCollectedDocumentUploadInfoEntity;

            if (ddlProjectCollectedDocumentInfoID.Items.Count > 0)
            {
                if (ddlProjectCollectedDocumentInfoID.SelectedValue == "0")
                {
                }
                else
                {
                    bDProjectCollectedDocumentUploadInfoEntity.ProjectCollectedDocumentInfoID = Int64.Parse(ddlProjectCollectedDocumentInfoID.SelectedValue);
                }
            }

            bDProjectCollectedDocumentUploadInfoEntity.Remarks = txtRemarks.Text.Trim();
            bDProjectCollectedDocumentUploadInfoEntity.Path = txtPath.Text.Trim();
            bDProjectCollectedDocumentUploadInfoEntity.OriginalFileName = txtOriginalFileName.Text.Trim();
            bDProjectCollectedDocumentUploadInfoEntity.CurrentFileName = txtCurrentFileName.Text.Trim();
            bDProjectCollectedDocumentUploadInfoEntity.FileType = txtFileType.Text.Trim();
            bDProjectCollectedDocumentUploadInfoEntity.Extension = txtExtension.Text.Trim();

            return bDProjectCollectedDocumentUploadInfoEntity;
        }

        private void SaveBDProjectCollectedDocumentUploadInfoEntity()
        {
            if (IsValid)
            {
                try
                {
                    BDProjectCollectedDocumentUploadInfoEntity bDProjectCollectedDocumentUploadInfoEntity = BuildBDProjectCollectedDocumentUploadInfoEntity();

                    Int64 result = -1;

                    if (bDProjectCollectedDocumentUploadInfoEntity.IsNew)
                    {
                        result = FCCBDProjectCollectedDocumentUploadInfo.GetFacadeCreate().Add(bDProjectCollectedDocumentUploadInfoEntity, DatabaseOperationType.Add, TransactionRequired.No);
                    }
                    else
                    {
                        String filterExpression = SqlExpressionBuilder.PrepareFilterExpression(BDProjectCollectedDocumentUploadInfoEntity.FLD_NAME_ProjectCollectedDocumentUploadInfoID, bDProjectCollectedDocumentUploadInfoEntity.ProjectCollectedDocumentUploadInfoID.ToString(), SQLMatchType.Equal);
                        result = FCCBDProjectCollectedDocumentUploadInfo.GetFacadeCreate().Update(bDProjectCollectedDocumentUploadInfoEntity, filterExpression, DatabaseOperationType.Update, TransactionRequired.No);
                    }

                    if (result > 0)
                    {
                        _ProjectCollectedDocumentUploadInfoID = 0;
                        _BDProjectCollectedDocumentUploadInfoEntity = new BDProjectCollectedDocumentUploadInfoEntity();
                        PrepareInitialView();
                        BindBDProjectCollectedDocumentUploadInfoList();

                        if (bDProjectCollectedDocumentUploadInfoEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Project Collected Document Upload Info Information has been added successfully.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Project Collected Document Upload Info Information has been updated successfully.", false);
                        }
                    }
                    else
                    {
                        if (bDProjectCollectedDocumentUploadInfoEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to add Project Collected Document Upload Info Information.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to update Project Collected Document Upload Info Information.", false);
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
            if (!IsPostBack)
            {
                PrepareValidator();
                PrepareInitialView();
                PrepareEditView();
            }
        }

        #endregion

        #region List View Event

        protected void lvBDProjectCollectedDocumentUploadInfo_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            Int64 ProjectCollectedDocumentUploadInfoID;

            Int64.TryParse(e.CommandArgument.ToString(), out ProjectCollectedDocumentUploadInfoID);

            if (ProjectCollectedDocumentUploadInfoID > 0)
            {
                if (string.Equals(e.CommandName, "EditItem"))
                {
                    _ProjectCollectedDocumentUploadInfoID = ProjectCollectedDocumentUploadInfoID;

                    PrepareEditView();

                    cpeEditor.Collapsed = false;
                    cpeEditor.ClientState = "false";
                }
                else if (string.Equals(e.CommandName, "DeleteItem"))
                {
                    try
                    {
                        Int64 result = -1;

                        String fe = SqlExpressionBuilder.PrepareFilterExpression(BDProjectCollectedDocumentUploadInfoEntity.FLD_NAME_ProjectCollectedDocumentUploadInfoID, ProjectCollectedDocumentUploadInfoID.ToString(), SQLMatchType.Equal);

                        BDProjectCollectedDocumentUploadInfoEntity bDProjectCollectedDocumentUploadInfoEntity = new BDProjectCollectedDocumentUploadInfoEntity();


                        result = FCCBDProjectCollectedDocumentUploadInfo.GetFacadeCreate().Delete(bDProjectCollectedDocumentUploadInfoEntity, fe, DatabaseOperationType.Delete, TransactionRequired.No);

                        if (result == 0)
                        {
                            _ProjectCollectedDocumentUploadInfoID = 0;
                            _BDProjectCollectedDocumentUploadInfoEntity = new BDProjectCollectedDocumentUploadInfoEntity();
                            PrepareInitialView();
                            BindBDProjectCollectedDocumentUploadInfoList();

                            MiscUtil.ShowMessage(lblMessage, "Project Collected Document Upload Info has been successfully deleted.", true);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to delete Project Collected Document Upload Info.", true);
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

        protected void odsBDProjectCollectedDocumentUploadInfo_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {
            e.InputParameters["filterExpression"] = String.Empty;
        }

        #endregion

        #region Button Event

        protected void btnSave_Click(object sender, EventArgs e)
        {
            SaveBDProjectCollectedDocumentUploadInfoEntity();
        }

        protected void btnAddNew_Click(object sender, EventArgs e)
        {
            _ProjectCollectedDocumentUploadInfoID = 0;
            _BDProjectCollectedDocumentUploadInfoEntity = new BDProjectCollectedDocumentUploadInfoEntity();
            PrepareInitialView();
        }

        protected void btnClear_Click(object sender, EventArgs e)
        {
            PrepareInitialView();
            PrepareEditView();
        }

        #endregion

        #endregion Event
    }
}
