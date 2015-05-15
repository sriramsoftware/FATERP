// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 08-Nov-2013, 09:51:38




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
    public partial class REQRequisitionUploadInfoControl : BaseControl
    {       
        #region Properties

        public Int64 _RequisitionUploadInfoID
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

        public REQRequisitionUploadInfoEntity _REQRequisitionUploadInfoEntity
        {
            get
            {
                REQRequisitionUploadInfoEntity entity = new REQRequisitionUploadInfoEntity();

                if (ViewState["CurrentEntity"] != null)
                {
                    entity = (REQRequisitionUploadInfoEntity)ViewState["CurrentEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["CurrentEntity"] = value;
            }
        }

        private REQRequisitionUploadInfoEntity CurrentREQRequisitionUploadInfoEntity
        {
            get
            {
                if (_RequisitionUploadInfoID > 0)
                {
                    if (_REQRequisitionUploadInfoEntity.RequisitionUploadInfoID != _RequisitionUploadInfoID)
                    {
                        _REQRequisitionUploadInfoEntity = FCCREQRequisitionUploadInfo.GetFacadeCreate().GetByID(_RequisitionUploadInfoID);
                    }
                }

                return _REQRequisitionUploadInfoEntity;
            }
            set
            {
                _REQRequisitionUploadInfoEntity = value;
            }
        }

        #endregion

        #region Methods

        private void BuildDropDownList()
        {
            MiscUtil.PopulateREQRequisition(ddlRequisitionID, false);
        }

        private void PrepareValidator()
        {
        }

        private void PrepareInitialView()
        {
            BuildDropDownList();

            txtExtension.Text = String.Empty;
            txtRemarks.Text = String.Empty;
            txtPath.Text = String.Empty;
            txtOriginalFileName.Text = String.Empty;
            txtCurrentFileName.Text = String.Empty;
            txtFileType.Text = String.Empty;

            btnSubmit.Text = "Add";
            btnAddNew.Visible = false;
        }

        private void PrepareEditView()
        {
            REQRequisitionUploadInfoEntity rEQRequisitionUploadInfoEntity = CurrentREQRequisitionUploadInfoEntity;


            if (!rEQRequisitionUploadInfoEntity.IsNew)
            {
                if (ddlRequisitionID.Items.Count > 0 && rEQRequisitionUploadInfoEntity.RequisitionID != null)
                {
                    ddlRequisitionID.SelectedValue = rEQRequisitionUploadInfoEntity.RequisitionID.ToString();
                }

                txtExtension.Text = rEQRequisitionUploadInfoEntity.Extension.ToString();
                txtRemarks.Text = rEQRequisitionUploadInfoEntity.Remarks.ToString();
                txtPath.Text = rEQRequisitionUploadInfoEntity.Path.ToString();
                txtOriginalFileName.Text = rEQRequisitionUploadInfoEntity.OriginalFileName.ToString();
                txtCurrentFileName.Text = rEQRequisitionUploadInfoEntity.CurrentFileName.ToString();
                txtFileType.Text = rEQRequisitionUploadInfoEntity.FileType.ToString();

                btnSubmit.Text = "Update";
                btnAddNew.Visible = true;
            }
        }

        private void BindList()
        {
            BindREQRequisitionUploadInfoList();
        }

        private void BindREQRequisitionUploadInfoList()
        {
            lvREQRequisitionUploadInfo.DataBind();
        }

        private REQRequisitionUploadInfoEntity BuildREQRequisitionUploadInfoEntity()
        {
            REQRequisitionUploadInfoEntity rEQRequisitionUploadInfoEntity = CurrentREQRequisitionUploadInfoEntity;

            if (ddlRequisitionID.Items.Count > 0)
            {
                if (ddlRequisitionID.SelectedValue == "0")
                {
                }
                else
                {
                    rEQRequisitionUploadInfoEntity.RequisitionID = Int64.Parse(ddlRequisitionID.SelectedValue);
                }
            }

            rEQRequisitionUploadInfoEntity.Extension = txtExtension.Text.Trim();
            rEQRequisitionUploadInfoEntity.Remarks = txtRemarks.Text.Trim();
            rEQRequisitionUploadInfoEntity.Path = txtPath.Text.Trim();
            rEQRequisitionUploadInfoEntity.OriginalFileName = txtOriginalFileName.Text.Trim();
            rEQRequisitionUploadInfoEntity.CurrentFileName = txtCurrentFileName.Text.Trim();
            rEQRequisitionUploadInfoEntity.FileType = txtFileType.Text.Trim();

            return rEQRequisitionUploadInfoEntity;
        }

        private void SaveREQRequisitionUploadInfoEntity()
        {
            if (IsValid)
            {
                try
                {
                    REQRequisitionUploadInfoEntity rEQRequisitionUploadInfoEntity = BuildREQRequisitionUploadInfoEntity();

                    Int64 result = -1;

                    if (rEQRequisitionUploadInfoEntity.IsNew)
                    {
                        result = FCCREQRequisitionUploadInfo.GetFacadeCreate().Add(rEQRequisitionUploadInfoEntity, DatabaseOperationType.Add, TransactionRequired.No);
                    }
                    else
                    {
                        String filterExpression = SqlExpressionBuilder.PrepareFilterExpression(REQRequisitionUploadInfoEntity.FLD_NAME_RequisitionUploadInfoID, rEQRequisitionUploadInfoEntity.RequisitionUploadInfoID.ToString(), SQLMatchType.Equal);
                        result = FCCREQRequisitionUploadInfo.GetFacadeCreate().Update(rEQRequisitionUploadInfoEntity, filterExpression, DatabaseOperationType.Update, TransactionRequired.No);
                    }

                    if (result > 0)
                    {
                        _RequisitionUploadInfoID = 0;
                        _REQRequisitionUploadInfoEntity = new REQRequisitionUploadInfoEntity();
                        PrepareInitialView();
                        BindREQRequisitionUploadInfoList();

                        if (rEQRequisitionUploadInfoEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "R EQRequisition Upload Info Information has been added successfully.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "R EQRequisition Upload Info Information has been updated successfully.", false);
                        }
                    }
                    else
                    {
                        if (rEQRequisitionUploadInfoEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to add R EQRequisition Upload Info Information.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to update R EQRequisition Upload Info Information.", false);
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

        protected void lvREQRequisitionUploadInfo_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            Int64 RequisitionUploadInfoID;

            Int64.TryParse(e.CommandArgument.ToString(), out RequisitionUploadInfoID);

            if (RequisitionUploadInfoID > 0)
            {
                if (string.Equals(e.CommandName, "EditItem"))
                {
                    _RequisitionUploadInfoID = RequisitionUploadInfoID;

                    PrepareEditView();

                    cpeEditor.Collapsed = false;
                    cpeEditor.ClientState = "false";
                }
                else if (string.Equals(e.CommandName, "DeleteItem"))
                {
                    try
                    {
                        Int64 result = -1;

                        String fe = SqlExpressionBuilder.PrepareFilterExpression(REQRequisitionUploadInfoEntity.FLD_NAME_RequisitionUploadInfoID, RequisitionUploadInfoID.ToString(), SQLMatchType.Equal);

                        REQRequisitionUploadInfoEntity rEQRequisitionUploadInfoEntity = new REQRequisitionUploadInfoEntity();


                        result = FCCREQRequisitionUploadInfo.GetFacadeCreate().Delete(rEQRequisitionUploadInfoEntity, fe, DatabaseOperationType.Delete, TransactionRequired.No);

                        if (result == 0)
                        {
                            _RequisitionUploadInfoID = 0;
                            _REQRequisitionUploadInfoEntity = new REQRequisitionUploadInfoEntity();
                            PrepareInitialView();
                            BindREQRequisitionUploadInfoList();

                            MiscUtil.ShowMessage(lblMessage, "Requisition Upload Info has been successfully deleted.", true);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to delete R EQRequisition Upload Info.", true);
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

        protected void odsREQRequisitionUploadInfo_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {
            e.InputParameters["filterExpression"] = String.Empty;
        }

        #endregion

        #region Button Event

        protected void btnSave_Click(object sender, EventArgs e)
        {
            SaveREQRequisitionUploadInfoEntity();
        }

        protected void btnAddNew_Click(object sender, EventArgs e)
        {
            _RequisitionUploadInfoID = 0;
            _REQRequisitionUploadInfoEntity = new REQRequisitionUploadInfoEntity();
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
