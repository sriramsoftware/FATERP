// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 17-Feb-2013, 12:50:45




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
    public partial class ACMDTemporaryJournalApprovalStatusControl : BaseControl
    {       
        #region Properties

        public Int64 _TemporyJournalApprovalStatusID
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

        public ACMDTemporaryJournalApprovalStatusEntity _ACMDTemporaryJournalApprovalStatusEntity
        {
            get
            {
                ACMDTemporaryJournalApprovalStatusEntity entity = new ACMDTemporaryJournalApprovalStatusEntity();

                if (ViewState["CurrentEntity"] != null)
                {
                    entity = (ACMDTemporaryJournalApprovalStatusEntity)ViewState["CurrentEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["CurrentEntity"] = value;
            }
        }

        private ACMDTemporaryJournalApprovalStatusEntity CurrentACMDTemporaryJournalApprovalStatusEntity
        {
            get
            {
                if (_TemporyJournalApprovalStatusID > 0)
                {
                    if (_ACMDTemporaryJournalApprovalStatusEntity.TemporyJournalApprovalStatusID != _TemporyJournalApprovalStatusID)
                    {
                        _ACMDTemporaryJournalApprovalStatusEntity = FCCACMDTemporaryJournalApprovalStatus.GetFacadeCreate().GetByID(_TemporyJournalApprovalStatusID);
                    }
                }

                return _ACMDTemporaryJournalApprovalStatusEntity;
            }
            set
            {
                _ACMDTemporaryJournalApprovalStatusEntity = value;
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

            txtName.Text = String.Empty;
            txtDescription.Text = String.Empty;
            chkIsRemoved.Checked = false;

            btnSubmit.Text = "Add";
            btnAddNew.Visible = false;
        }

        private void PrepareEditView()
        {
            ACMDTemporaryJournalApprovalStatusEntity aCMDTemporaryJournalApprovalStatusEntity = CurrentACMDTemporaryJournalApprovalStatusEntity;


            if (!aCMDTemporaryJournalApprovalStatusEntity.IsNew)
            {
                txtName.Text = aCMDTemporaryJournalApprovalStatusEntity.Name.ToString();
                txtDescription.Text = aCMDTemporaryJournalApprovalStatusEntity.Description.ToString();
                chkIsRemoved.Checked = aCMDTemporaryJournalApprovalStatusEntity.IsRemoved;

                btnSubmit.Text = "Update";
                btnAddNew.Visible = true;
            }
        }

        private void BindList()
        {
            BindACMDTemporaryJournalApprovalStatusList();
        }

        private void BindACMDTemporaryJournalApprovalStatusList()
        {
            lvACMDTemporaryJournalApprovalStatus.DataBind();
        }

        private ACMDTemporaryJournalApprovalStatusEntity BuildACMDTemporaryJournalApprovalStatusEntity()
        {
            ACMDTemporaryJournalApprovalStatusEntity aCMDTemporaryJournalApprovalStatusEntity = CurrentACMDTemporaryJournalApprovalStatusEntity;

            aCMDTemporaryJournalApprovalStatusEntity.Name = txtName.Text.Trim();
            aCMDTemporaryJournalApprovalStatusEntity.Description = txtDescription.Text.Trim();
            aCMDTemporaryJournalApprovalStatusEntity.IsRemoved = chkIsRemoved.Checked;


            return aCMDTemporaryJournalApprovalStatusEntity;
        }

        private void SaveACMDTemporaryJournalApprovalStatusEntity()
        {
            if (IsValid)
            {
                try
                {
                    ACMDTemporaryJournalApprovalStatusEntity aCMDTemporaryJournalApprovalStatusEntity = BuildACMDTemporaryJournalApprovalStatusEntity();

                    Int64 result = -1;

                    if (aCMDTemporaryJournalApprovalStatusEntity.IsNew)
                    {
                        result = FCCACMDTemporaryJournalApprovalStatus.GetFacadeCreate().Add(aCMDTemporaryJournalApprovalStatusEntity, DatabaseOperationType.Add, TransactionRequired.No);
                    }
                    else
                    {
                        String filterExpression = SqlExpressionBuilder.PrepareFilterExpression(ACMDTemporaryJournalApprovalStatusEntity.FLD_NAME_TemporyJournalApprovalStatusID, aCMDTemporaryJournalApprovalStatusEntity.TemporyJournalApprovalStatusID.ToString(), SQLMatchType.Equal);
                        result = FCCACMDTemporaryJournalApprovalStatus.GetFacadeCreate().Update(aCMDTemporaryJournalApprovalStatusEntity, filterExpression, DatabaseOperationType.Update, TransactionRequired.No);
                    }

                    if (result > 0)
                    {
                        _TemporyJournalApprovalStatusID = 0;
                        _ACMDTemporaryJournalApprovalStatusEntity = new ACMDTemporaryJournalApprovalStatusEntity();
                        PrepareInitialView();
                        BindACMDTemporaryJournalApprovalStatusList();

                        if (aCMDTemporaryJournalApprovalStatusEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "A CTemporary Journal Approval Status Information has been added successfully.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "A CTemporary Journal Approval Status Information has been updated successfully.", false);
                        }
                    }
                    else
                    {
                        if (aCMDTemporaryJournalApprovalStatusEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to add A CTemporary Journal Approval Status Information.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to update A CTemporary Journal Approval Status Information.", false);
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

        protected void lvACMDTemporaryJournalApprovalStatus_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            Int64 TemporyJournalApprovalStatusID;

            Int64.TryParse(e.CommandArgument.ToString(), out TemporyJournalApprovalStatusID);

            if (TemporyJournalApprovalStatusID > 0)
            {
                if (string.Equals(e.CommandName, "EditItem"))
                {
                    _TemporyJournalApprovalStatusID = TemporyJournalApprovalStatusID;

                    PrepareEditView();

                    cpeEditor.Collapsed = false;
                    cpeEditor.ClientState = "false";
                }
                else if (string.Equals(e.CommandName, "DeleteItem"))
                {
                    try
                    {
                        Int64 result = -1;

                        String fe = SqlExpressionBuilder.PrepareFilterExpression(ACMDTemporaryJournalApprovalStatusEntity.FLD_NAME_TemporyJournalApprovalStatusID, TemporyJournalApprovalStatusID.ToString(), SQLMatchType.Equal);

                        ACMDTemporaryJournalApprovalStatusEntity aCMDTemporaryJournalApprovalStatusEntity = new ACMDTemporaryJournalApprovalStatusEntity();


                        result = FCCACMDTemporaryJournalApprovalStatus.GetFacadeCreate().Delete(aCMDTemporaryJournalApprovalStatusEntity, fe, DatabaseOperationType.Delete, TransactionRequired.No);

                        if (result == 0)
                        {
                            _TemporyJournalApprovalStatusID = 0;
                            _ACMDTemporaryJournalApprovalStatusEntity = new ACMDTemporaryJournalApprovalStatusEntity();
                            PrepareInitialView();
                            BindACMDTemporaryJournalApprovalStatusList();

                            MiscUtil.ShowMessage(lblMessage, "A CTemporary Journal Approval Status has been successfully deleted.", true);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to delete A CTemporary Journal Approval Status.", true);
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

        protected void odsACMDTemporaryJournalApprovalStatus_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {
            e.InputParameters["filterExpression"] = String.Empty;
        }

        #endregion

        #region Button Event

        protected void btnSave_Click(object sender, EventArgs e)
        {
            SaveACMDTemporaryJournalApprovalStatusEntity();
        }

        protected void btnAddNew_Click(object sender, EventArgs e)
        {
            _TemporyJournalApprovalStatusID = 0;
            _ACMDTemporaryJournalApprovalStatusEntity = new ACMDTemporaryJournalApprovalStatusEntity();
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
