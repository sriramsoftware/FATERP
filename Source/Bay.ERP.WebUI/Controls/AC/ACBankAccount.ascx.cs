// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 27-Jan-2013, 02:50:43




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
    public partial class ACBankAccountControl : BaseControl
    {       
        #region Properties

        public Int64 _BankAccountID
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

        public ACBankAccountEntity _ACBankAccountEntity
        {
            get
            {
                ACBankAccountEntity entity = new ACBankAccountEntity();

                if (ViewState["CurrentEntity"] != null)
                {
                    entity = (ACBankAccountEntity)ViewState["CurrentEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["CurrentEntity"] = value;
            }
        }

        private ACBankAccountEntity CurrentACBankAccountEntity
        {
            get
            {
                if (_BankAccountID > 0)
                {
                    if (_ACBankAccountEntity.BankAccountID != _BankAccountID)
                    {
                        _ACBankAccountEntity = FCCACBankAccount.GetFacadeCreate().GetByID(_BankAccountID);
                    }
                }

                return _ACBankAccountEntity;
            }
            set
            {
                _ACBankAccountEntity = value;
            }
        }

        #endregion

        #region Methods

        private void BuildDropDownList()
        {
            MiscUtil.PopulateACAccountByAccountGroup(ddlACCAccountID, false);
            MiscUtil.PopulateACMDBankAccountType(ddlBankAccountTypeID, false);
            MiscUtil.PopulateMDCurrency(ddlCurrencyID, false);
        }

        private void PrepareValidator()
        {
        }

        private void PrepareInitialView()
        {
            BuildDropDownList();

            txtBankAccountName.Text = String.Empty;
            txtBankAccountNumber.Text = String.Empty;
            chkIsDefaultCurrencyAccount.Checked = false;
            txtBankName.Text = String.Empty;
            txtBankAddress.Text = String.Empty;

            btnSubmit.Text = "Add";
            btnAddNew.Visible = false;
        }

        private void PrepareEditView()
        {
            ACBankAccountEntity aCBankAccountEntity = CurrentACBankAccountEntity;


            if (!aCBankAccountEntity.IsNew)
            {
                if (ddlACCAccountID.Items.Count > 0 && aCBankAccountEntity.ACCAccountID != null)
                {
                    ddlACCAccountID.SelectedValue = aCBankAccountEntity.ACCAccountID.ToString();
                }

                txtBankAccountName.Text = aCBankAccountEntity.BankAccountName.ToString();
                txtBankAccountNumber.Text = aCBankAccountEntity.BankAccountNumber.ToString();
                if (ddlBankAccountTypeID.Items.Count > 0 && aCBankAccountEntity.BankAccountTypeID != null)
                {
                    ddlBankAccountTypeID.SelectedValue = aCBankAccountEntity.BankAccountTypeID.ToString();
                }

                if (ddlCurrencyID.Items.Count > 0 && aCBankAccountEntity.CurrencyID != null)
                {
                    ddlCurrencyID.SelectedValue = aCBankAccountEntity.CurrencyID.ToString();
                }

                chkIsDefaultCurrencyAccount.Checked = aCBankAccountEntity.IsDefaultCurrencyAccount;
                txtBankName.Text = aCBankAccountEntity.BankName.ToString();
                txtBankAddress.Text = aCBankAccountEntity.BankAddress.ToString();

                btnSubmit.Text = "Update";
                btnAddNew.Visible = false;
            }
        }

        private void BindList()
        {
            BindACBankAccountList();
        }

        private void BindACBankAccountList()
        {
            lvACBankAccount.DataBind();
        }

        private ACBankAccountEntity BuildACBankAccountEntity()
        {
            ACBankAccountEntity aCBankAccountEntity = CurrentACBankAccountEntity;

            if (ddlACCAccountID.Items.Count > 0)
            {
                if (ddlACCAccountID.SelectedValue == "0")
                {
                }
                else
                {
                    aCBankAccountEntity.ACCAccountID = Int64.Parse(ddlACCAccountID.SelectedValue);
                }
            }

            aCBankAccountEntity.BankAccountName = txtBankAccountName.Text.Trim();
            aCBankAccountEntity.BankAccountNumber = txtBankAccountNumber.Text.Trim();
            if (ddlBankAccountTypeID.Items.Count > 0)
            {
                if (ddlBankAccountTypeID.SelectedValue == "0")
                {
                }
                else
                {
                    aCBankAccountEntity.BankAccountTypeID = Int64.Parse(ddlBankAccountTypeID.SelectedValue);
                }
            }

            if (ddlCurrencyID.Items.Count > 0)
            {
                if (ddlCurrencyID.SelectedValue == "0")
                {
                }
                else
                {
                    aCBankAccountEntity.CurrencyID = Int64.Parse(ddlCurrencyID.SelectedValue);
                }
            }

            aCBankAccountEntity.IsDefaultCurrencyAccount = chkIsDefaultCurrencyAccount.Checked;

            aCBankAccountEntity.BankName = txtBankName.Text.Trim();
            aCBankAccountEntity.BankAddress = txtBankAddress.Text.Trim();

            return aCBankAccountEntity;
        }

        private void SaveACBankAccountEntity()
        {
            if (IsValid)
            {
                try
                {
                    ACBankAccountEntity aCBankAccountEntity = BuildACBankAccountEntity();

                    Int64 result = -1;

                    if (aCBankAccountEntity.IsNew)
                    {
                        result = FCCACBankAccount.GetFacadeCreate().Add(aCBankAccountEntity, DatabaseOperationType.Add, TransactionRequired.No);
                    }
                    else
                    {
                        String filterExpression = SqlExpressionBuilder.PrepareFilterExpression(ACBankAccountEntity.FLD_NAME_BankAccountID, aCBankAccountEntity.BankAccountID.ToString(), SQLMatchType.Equal);
                        result = FCCACBankAccount.GetFacadeCreate().Update(aCBankAccountEntity, filterExpression, DatabaseOperationType.Update, TransactionRequired.No);
                    }

                    if (result > 0)
                    {
                        _BankAccountID = 0;
                        _ACBankAccountEntity = new ACBankAccountEntity();
                        PrepareInitialView();
                        BindACBankAccountList();

                        if (aCBankAccountEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "A CBank Account Information has been added successfully.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "A CBank Account Information has been updated successfully.", false);
                        }
                    }
                    else
                    {
                        if (aCBankAccountEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to add A CBank Account Information.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to update A CBank Account Information.", false);
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

        protected void lvACBankAccount_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            Int64 BankAccountID;

            Int64.TryParse(e.CommandArgument.ToString(), out BankAccountID);

            if (BankAccountID > 0)
            {
                if (string.Equals(e.CommandName, "EditItem"))
                {
                    _BankAccountID = BankAccountID;

                    PrepareEditView();

                    cpeEditor.Collapsed = false;
                    cpeEditor.ClientState = "false";
                }
                else if (string.Equals(e.CommandName, "DeleteItem"))
                {
                    try
                    {
                        Int64 result = -1;

                        String fe = SqlExpressionBuilder.PrepareFilterExpression(ACBankAccountEntity.FLD_NAME_BankAccountID, BankAccountID.ToString(), SQLMatchType.Equal);

                        ACBankAccountEntity aCBankAccountEntity = new ACBankAccountEntity();


                        result = FCCACBankAccount.GetFacadeCreate().Delete(aCBankAccountEntity, fe, DatabaseOperationType.Delete, TransactionRequired.No);

                        if (result == 0)
                        {
                            _BankAccountID = 0;
                            _ACBankAccountEntity = new ACBankAccountEntity();
                            PrepareInitialView();
                            BindACBankAccountList();

                            MiscUtil.ShowMessage(lblMessage, "A CBank Account has been successfully deleted.", true);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to delete A CBank Account.", true);
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

        protected void odsACBankAccount_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {
            e.InputParameters["filterExpression"] = String.Empty;
        }

        #endregion

        #region Button Event

        protected void btnSave_Click(object sender, EventArgs e)
        {
            SaveACBankAccountEntity();
        }

        protected void btnAddNew_Click(object sender, EventArgs e)
        {
            _BankAccountID = 0;
            _ACBankAccountEntity = new ACBankAccountEntity();
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
