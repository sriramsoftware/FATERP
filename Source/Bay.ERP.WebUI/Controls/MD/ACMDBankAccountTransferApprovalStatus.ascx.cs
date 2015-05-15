// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 03-Mar-2013, 10:27:29




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
    public partial class ACMDBankAccountTransferApprovalStatusControl : BaseControl
    {       
        #region Properties

        public Int64 _BankAccountTransferApprovalStatusID
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

        public ACMDBankAccountTransferApprovalStatusEntity _ACMDBankAccountTransferApprovalStatusEntity
        {
            get
            {
                ACMDBankAccountTransferApprovalStatusEntity entity = new ACMDBankAccountTransferApprovalStatusEntity();

                if (ViewState["CurrentEntity"] != null)
                {
                    entity = (ACMDBankAccountTransferApprovalStatusEntity)ViewState["CurrentEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["CurrentEntity"] = value;
            }
        }

        private ACMDBankAccountTransferApprovalStatusEntity CurrentACMDBankAccountTransferApprovalStatusEntity
        {
            get
            {
                if (_BankAccountTransferApprovalStatusID > 0)
                {
                    if (_ACMDBankAccountTransferApprovalStatusEntity.BankAccountTransferApprovalStatusID != _BankAccountTransferApprovalStatusID)
                    {
                        _ACMDBankAccountTransferApprovalStatusEntity = FCCACMDBankAccountTransferApprovalStatus.GetFacadeCreate().GetByID(_BankAccountTransferApprovalStatusID);
                    }
                }

                return _ACMDBankAccountTransferApprovalStatusEntity;
            }
            set
            {
                _ACMDBankAccountTransferApprovalStatusEntity = value;
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
            ACMDBankAccountTransferApprovalStatusEntity aCMDBankAccountTransferApprovalStatusEntity = CurrentACMDBankAccountTransferApprovalStatusEntity;


            if (!aCMDBankAccountTransferApprovalStatusEntity.IsNew)
            {
                txtName.Text = aCMDBankAccountTransferApprovalStatusEntity.Name.ToString();
                txtDescription.Text = aCMDBankAccountTransferApprovalStatusEntity.Description.ToString();
                chkIsRemoved.Checked = aCMDBankAccountTransferApprovalStatusEntity.IsRemoved;

                btnSubmit.Text = "Update";
                btnAddNew.Visible = true;
            }
        }

        private void BindList()
        {
            BindACMDBankAccountTransferApprovalStatusList();
        }

        private void BindACMDBankAccountTransferApprovalStatusList()
        {
            lvACMDBankAccountTransferApprovalStatus.DataBind();
        }

        private ACMDBankAccountTransferApprovalStatusEntity BuildACMDBankAccountTransferApprovalStatusEntity()
        {
            ACMDBankAccountTransferApprovalStatusEntity aCMDBankAccountTransferApprovalStatusEntity = CurrentACMDBankAccountTransferApprovalStatusEntity;

            aCMDBankAccountTransferApprovalStatusEntity.Name = txtName.Text.Trim();
            if (!txtDescription.Text.Trim().IsNullOrEmpty())
            {
                aCMDBankAccountTransferApprovalStatusEntity.Description = Char.Parse(txtDescription.Text.Trim());
            }

            aCMDBankAccountTransferApprovalStatusEntity.IsRemoved = chkIsRemoved.Checked;


            return aCMDBankAccountTransferApprovalStatusEntity;
        }

        private void SaveACMDBankAccountTransferApprovalStatusEntity()
        {
            if (IsValid)
            {
                try
                {
                    ACMDBankAccountTransferApprovalStatusEntity aCMDBankAccountTransferApprovalStatusEntity = BuildACMDBankAccountTransferApprovalStatusEntity();

                    Int64 result = -1;

                    if (aCMDBankAccountTransferApprovalStatusEntity.IsNew)
                    {
                        result = FCCACMDBankAccountTransferApprovalStatus.GetFacadeCreate().Add(aCMDBankAccountTransferApprovalStatusEntity, DatabaseOperationType.Add, TransactionRequired.No);
                    }
                    else
                    {
                        String filterExpression = SqlExpressionBuilder.PrepareFilterExpression(ACMDBankAccountTransferApprovalStatusEntity.FLD_NAME_BankAccountTransferApprovalStatusID, aCMDBankAccountTransferApprovalStatusEntity.BankAccountTransferApprovalStatusID.ToString(), SQLMatchType.Equal);
                        result = FCCACMDBankAccountTransferApprovalStatus.GetFacadeCreate().Update(aCMDBankAccountTransferApprovalStatusEntity, filterExpression, DatabaseOperationType.Update, TransactionRequired.No);
                    }

                    if (result > 0)
                    {
                        _BankAccountTransferApprovalStatusID = 0;
                        _ACMDBankAccountTransferApprovalStatusEntity = new ACMDBankAccountTransferApprovalStatusEntity();
                        PrepareInitialView();
                        BindACMDBankAccountTransferApprovalStatusList();

                        if (aCMDBankAccountTransferApprovalStatusEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Bank Account Transfer Approval Status Information has been added successfully.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Bank Account Transfer Approval Status Information has been updated successfully.", false);
                        }
                    }
                    else
                    {
                        if (aCMDBankAccountTransferApprovalStatusEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to add Bank Account Transfer Approval Status Information.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to update Bank Account Transfer Approval Status Information.", false);
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

        protected void lvACMDBankAccountTransferApprovalStatus_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            Int64 BankAccountTransferApprovalStatusID;

            Int64.TryParse(e.CommandArgument.ToString(), out BankAccountTransferApprovalStatusID);

            if (BankAccountTransferApprovalStatusID > 0)
            {
                if (string.Equals(e.CommandName, "EditItem"))
                {
                    _BankAccountTransferApprovalStatusID = BankAccountTransferApprovalStatusID;

                    PrepareEditView();

                    cpeEditor.Collapsed = false;
                    cpeEditor.ClientState = "false";
                }
                else if (string.Equals(e.CommandName, "DeleteItem"))
                {
                    try
                    {
                        Int64 result = -1;

                        String fe = SqlExpressionBuilder.PrepareFilterExpression(ACMDBankAccountTransferApprovalStatusEntity.FLD_NAME_BankAccountTransferApprovalStatusID, BankAccountTransferApprovalStatusID.ToString(), SQLMatchType.Equal);

                        ACMDBankAccountTransferApprovalStatusEntity aCMDBankAccountTransferApprovalStatusEntity = new ACMDBankAccountTransferApprovalStatusEntity();


                        result = FCCACMDBankAccountTransferApprovalStatus.GetFacadeCreate().Delete(aCMDBankAccountTransferApprovalStatusEntity, fe, DatabaseOperationType.Delete, TransactionRequired.No);

                        if (result == 0)
                        {
                            _BankAccountTransferApprovalStatusID = 0;
                            _ACMDBankAccountTransferApprovalStatusEntity = new ACMDBankAccountTransferApprovalStatusEntity();
                            PrepareInitialView();
                            BindACMDBankAccountTransferApprovalStatusList();

                            MiscUtil.ShowMessage(lblMessage, "A CBank Account Transfer Approval Status has been successfully deleted.", true);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to delete A CBank Account Transfer Approval Status.", true);
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

        protected void odsACMDBankAccountTransferApprovalStatus_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {
            e.InputParameters["filterExpression"] = String.Empty;
        }

        #endregion

        #region Button Event

        protected void btnSave_Click(object sender, EventArgs e)
        {
            SaveACMDBankAccountTransferApprovalStatusEntity();
        }

        protected void btnAddNew_Click(object sender, EventArgs e)
        {
            _BankAccountTransferApprovalStatusID = 0;
            _ACMDBankAccountTransferApprovalStatusEntity = new ACMDBankAccountTransferApprovalStatusEntity();
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
