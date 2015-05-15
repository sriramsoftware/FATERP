// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 17-Feb-2013, 12:00:20




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
    public partial class ACMDBankAccountDepositApprovalStatusControl : BaseControl
    {       
        #region Properties

        public Int64 _BankAccountDepositApprovalStatusID
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

        public ACMDBankAccountDepositApprovalStatusEntity _ACMDBankAccountDepositApprovalStatusEntity
        {
            get
            {
                ACMDBankAccountDepositApprovalStatusEntity entity = new ACMDBankAccountDepositApprovalStatusEntity();

                if (ViewState["CurrentEntity"] != null)
                {
                    entity = (ACMDBankAccountDepositApprovalStatusEntity)ViewState["CurrentEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["CurrentEntity"] = value;
            }
        }

        private ACMDBankAccountDepositApprovalStatusEntity CurrentACMDBankAccountDepositApprovalStatusEntity
        {
            get
            {
                if (_BankAccountDepositApprovalStatusID > 0)
                {
                    if (_ACMDBankAccountDepositApprovalStatusEntity.BankAccountDepositApprovalStatusID != _BankAccountDepositApprovalStatusID)
                    {
                        _ACMDBankAccountDepositApprovalStatusEntity = FCCACMDBankAccountDepositApprovalStatus.GetFacadeCreate().GetByID(_BankAccountDepositApprovalStatusID);
                    }
                }

                return _ACMDBankAccountDepositApprovalStatusEntity;
            }
            set
            {
                _ACMDBankAccountDepositApprovalStatusEntity = value;
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
            ACMDBankAccountDepositApprovalStatusEntity aCMDBankAccountDepositApprovalStatusEntity = CurrentACMDBankAccountDepositApprovalStatusEntity;


            if (!aCMDBankAccountDepositApprovalStatusEntity.IsNew)
            {
                txtName.Text = aCMDBankAccountDepositApprovalStatusEntity.Name.ToString();
                txtDescription.Text = aCMDBankAccountDepositApprovalStatusEntity.Description.ToString();
                chkIsRemoved.Checked = aCMDBankAccountDepositApprovalStatusEntity.IsRemoved;

                btnSubmit.Text = "Update";
                btnAddNew.Visible = true;
            }
        }

        private void BindList()
        {
            BindACMDBankAccountDepositApprovalStatusList();
        }

        private void BindACMDBankAccountDepositApprovalStatusList()
        {
            lvACMDBankAccountDepositApprovalStatus.DataBind();
        }

        private ACMDBankAccountDepositApprovalStatusEntity BuildACMDBankAccountDepositApprovalStatusEntity()
        {
            ACMDBankAccountDepositApprovalStatusEntity aCMDBankAccountDepositApprovalStatusEntity = CurrentACMDBankAccountDepositApprovalStatusEntity;

            aCMDBankAccountDepositApprovalStatusEntity.Name = txtName.Text.Trim();
            aCMDBankAccountDepositApprovalStatusEntity.Description = txtDescription.Text.Trim();
            aCMDBankAccountDepositApprovalStatusEntity.IsRemoved = chkIsRemoved.Checked;


            return aCMDBankAccountDepositApprovalStatusEntity;
        }

        private void SaveACMDBankAccountDepositApprovalStatusEntity()
        {
            if (IsValid)
            {
                try
                {
                    ACMDBankAccountDepositApprovalStatusEntity aCMDBankAccountDepositApprovalStatusEntity = BuildACMDBankAccountDepositApprovalStatusEntity();

                    Int64 result = -1;

                    if (aCMDBankAccountDepositApprovalStatusEntity.IsNew)
                    {
                        result = FCCACMDBankAccountDepositApprovalStatus.GetFacadeCreate().Add(aCMDBankAccountDepositApprovalStatusEntity, DatabaseOperationType.Add, TransactionRequired.No);
                    }
                    else
                    {
                        String filterExpression = SqlExpressionBuilder.PrepareFilterExpression(ACMDBankAccountDepositApprovalStatusEntity.FLD_NAME_BankAccountDepositApprovalStatusID, aCMDBankAccountDepositApprovalStatusEntity.BankAccountDepositApprovalStatusID.ToString(), SQLMatchType.Equal);
                        result = FCCACMDBankAccountDepositApprovalStatus.GetFacadeCreate().Update(aCMDBankAccountDepositApprovalStatusEntity, filterExpression, DatabaseOperationType.Update, TransactionRequired.No);
                    }

                    if (result > 0)
                    {
                        _BankAccountDepositApprovalStatusID = 0;
                        _ACMDBankAccountDepositApprovalStatusEntity = new ACMDBankAccountDepositApprovalStatusEntity();
                        PrepareInitialView();
                        BindACMDBankAccountDepositApprovalStatusList();

                        if (aCMDBankAccountDepositApprovalStatusEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "A CBank Account Deposit Approval Status Information has been added successfully.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "A CBank Account Deposit Approval Status Information has been updated successfully.", false);
                        }
                    }
                    else
                    {
                        if (aCMDBankAccountDepositApprovalStatusEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to add A CBank Account Deposit Approval Status Information.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to update A CBank Account Deposit Approval Status Information.", false);
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

        protected void lvACMDBankAccountDepositApprovalStatus_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            Int64 BankAccountDepositApprovalStatusID;

            Int64.TryParse(e.CommandArgument.ToString(), out BankAccountDepositApprovalStatusID);

            if (BankAccountDepositApprovalStatusID > 0)
            {
                if (string.Equals(e.CommandName, "EditItem"))
                {
                    _BankAccountDepositApprovalStatusID = BankAccountDepositApprovalStatusID;

                    PrepareEditView();

                    cpeEditor.Collapsed = false;
                    cpeEditor.ClientState = "false";
                }
                else if (string.Equals(e.CommandName, "DeleteItem"))
                {
                    try
                    {
                        Int64 result = -1;

                        String fe = SqlExpressionBuilder.PrepareFilterExpression(ACMDBankAccountDepositApprovalStatusEntity.FLD_NAME_BankAccountDepositApprovalStatusID, BankAccountDepositApprovalStatusID.ToString(), SQLMatchType.Equal);

                        ACMDBankAccountDepositApprovalStatusEntity aCMDBankAccountDepositApprovalStatusEntity = new ACMDBankAccountDepositApprovalStatusEntity();


                        result = FCCACMDBankAccountDepositApprovalStatus.GetFacadeCreate().Delete(aCMDBankAccountDepositApprovalStatusEntity, fe, DatabaseOperationType.Delete, TransactionRequired.No);

                        if (result == 0)
                        {
                            _BankAccountDepositApprovalStatusID = 0;
                            _ACMDBankAccountDepositApprovalStatusEntity = new ACMDBankAccountDepositApprovalStatusEntity();
                            PrepareInitialView();
                            BindACMDBankAccountDepositApprovalStatusList();

                            MiscUtil.ShowMessage(lblMessage, "A CBank Account Deposit Approval Status has been successfully deleted.", true);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to delete A CBank Account Deposit Approval Status.", true);
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

        protected void odsACMDBankAccountDepositApprovalStatus_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {
            e.InputParameters["filterExpression"] = String.Empty;
        }

        #endregion

        #region Button Event

        protected void btnSave_Click(object sender, EventArgs e)
        {
            SaveACMDBankAccountDepositApprovalStatusEntity();
        }

        protected void btnAddNew_Click(object sender, EventArgs e)
        {
            _BankAccountDepositApprovalStatusID = 0;
            _ACMDBankAccountDepositApprovalStatusEntity = new ACMDBankAccountDepositApprovalStatusEntity();
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
