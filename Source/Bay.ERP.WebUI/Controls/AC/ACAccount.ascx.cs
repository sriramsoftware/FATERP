// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 22-Jan-2013, 03:28:28




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
    public partial class ACAccountControl : BaseControl
    {       
        #region Properties

        public Int64 _AccountID
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

        public ACAccountEntity _ACAccountEntity
        {
            get
            {
                ACAccountEntity entity = new ACAccountEntity();

                if (ViewState["CurrentEntity"] != null)
                {
                    entity = (ACAccountEntity)ViewState["CurrentEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["CurrentEntity"] = value;
            }
        }

        private ACAccountEntity CurrentACAccountEntity
        {
            get
            {
                if (_AccountID > 0)
                {
                    if (_ACAccountEntity.AccountID != _AccountID)
                    {
                        _ACAccountEntity = FCCACAccount.GetFacadeCreate().GetByID(_AccountID);
                    }
                }

                return _ACAccountEntity;
            }
            set
            {
                _ACAccountEntity = value;
            }
        }

        #endregion

        #region Methods

        private void BuildDropDownList()
        {
            MiscUtil.PopulateACAccountGroup(ddlAccountGroupID, false);
            MiscUtil.PopulateACAccountStatus(ddlAccountStatusID, false);
            MiscUtil.PopulateACTaxType(ddlTaxTypeID, false);
        }

        private void PrepareValidator()
        {
        }

        private String PrepareAccountCode()
        {
            String accountCode = String.Empty;

            if (ddlAccountGroupID != null && ddlAccountGroupID.Items.Count > 0)
            {
                switch (Int64.Parse(ddlAccountGroupID.SelectedValue))
                {
                    case MasterDataConstants.ACAccountGroup.CAPITAL_AND_RESERVE:
                        break;
                    //case MasterDataConstants.ACAccountGroup.CAPITAL_AND_RESERVE:
                    //    break;
                    //case MasterDataConstants.ACAccountGroup.CAPITAL_AND_RESERVE:
                    //    break;
                    //case MasterDataConstants.ACAccountGroup.CAPITAL_AND_RESERVE:
                    //    break;
                    //case MasterDataConstants.ACAccountGroup.CAPITAL_AND_RESERVE:
                    //    break;
                    //case MasterDataConstants.ACAccountGroup.CAPITAL_AND_RESERVE:
                    //    break;
                    //case MasterDataConstants.ACAccountGroup.CAPITAL_AND_RESERVE:
                    //    break;
                    //case MasterDataConstants.ACAccountGroup.CAPITAL_AND_RESERVE:
                    //    break;
                    
                }
            }
            return accountCode;
        }

        private void PrepareInitialView()
        {
            BuildDropDownList();

            txtAccountCode.Text = String.Empty;
            txtAccountCode2.Text = String.Empty;
            txtAccountName.Text = String.Empty;
            txtDescription.Text = String.Empty;
            chkIsRemoved.Checked = false;

            btnSubmit.Text = "Add";
            btnAddNew.Visible = false;
        }

        private void PrepareEditView()
        {
            ACAccountEntity aCAccountEntity = CurrentACAccountEntity;


            if (!aCAccountEntity.IsNew)
            {
                if (ddlAccountGroupID.Items.Count > 0 && aCAccountEntity.AccountGroupID != null)
                {
                    ddlAccountGroupID.SelectedValue = aCAccountEntity.AccountGroupID.ToString();
                }

                txtAccountCode.Text = aCAccountEntity.AccountCode.ToString();
                txtAccountCode2.Text = aCAccountEntity.AccountCode2.ToString();
                txtAccountName.Text = aCAccountEntity.AccountName.ToString();
                txtDescription.Text = aCAccountEntity.Description.ToString();
                if (ddlAccountStatusID.Items.Count > 0 && aCAccountEntity.AccountStatusID != null)
                {
                    ddlAccountStatusID.SelectedValue = aCAccountEntity.AccountStatusID.ToString();
                }

                if (ddlTaxTypeID.Items.Count > 0 && aCAccountEntity.TaxTypeID != null)
                {
                    ddlTaxTypeID.SelectedValue = aCAccountEntity.TaxTypeID.ToString();
                }

                chkIsRemoved.Checked = aCAccountEntity.IsRemoved;

                btnSubmit.Text = "Update";
                btnAddNew.Visible = true;
            }
        }

        private void BindList()
        {
            BindACAccountList();
        }

        private void BindACAccountList()
        {
            lvACAccount.DataBind();
        }

        private ACAccountEntity BuildACAccountEntity()
        {
            ACAccountEntity aCAccountEntity = CurrentACAccountEntity;

            if (ddlAccountGroupID.Items.Count > 0)
            {
                if (ddlAccountGroupID.SelectedValue == "0")
                {
                }
                else
                {
                    aCAccountEntity.AccountGroupID = Int64.Parse(ddlAccountGroupID.SelectedValue);
                }
            }

            aCAccountEntity.AccountCode = txtAccountCode.Text.Trim();
            aCAccountEntity.AccountCode2 = txtAccountCode2.Text.Trim();
            aCAccountEntity.AccountName = txtAccountName.Text.Trim();
            aCAccountEntity.Description = txtDescription.Text.Trim();
            if (ddlAccountStatusID.Items.Count > 0)
            {
                if (ddlAccountStatusID.SelectedValue == "0")
                {
                }
                else
                {
                    aCAccountEntity.AccountStatusID = Int64.Parse(ddlAccountStatusID.SelectedValue);
                }
            }

            if (ddlTaxTypeID.Items.Count > 0)
            {
                if (ddlTaxTypeID.SelectedValue == "0")
                {
                }
                else
                {
                    aCAccountEntity.TaxTypeID = Int64.Parse(ddlTaxTypeID.SelectedValue);
                }
            }

            aCAccountEntity.IsRemoved = chkIsRemoved.Checked;


            return aCAccountEntity;
        }

        private void SaveACAccountEntity()
        {
            if (IsValid)
            {
                try
                {
                    ACAccountEntity aCAccountEntity = BuildACAccountEntity();

                    Int64 result = -1;

                    if (aCAccountEntity.IsNew)
                    {
                        result = FCCACAccount.GetFacadeCreate().Add(aCAccountEntity, DatabaseOperationType.Add, TransactionRequired.No);
                    }
                    else
                    {
                        String filterExpression = SqlExpressionBuilder.PrepareFilterExpression(ACAccountEntity.FLD_NAME_AccountID, aCAccountEntity.AccountID.ToString(), SQLMatchType.Equal);
                        result = FCCACAccount.GetFacadeCreate().Update(aCAccountEntity, filterExpression, DatabaseOperationType.Update, TransactionRequired.No);
                    }

                    if (result > 0)
                    {
                        _AccountID = 0;
                        _ACAccountEntity = new ACAccountEntity();
                        PrepareInitialView();
                        BindACAccountList();

                        if (aCAccountEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "A CAccount Information has been added successfully.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "A CAccount Information has been updated successfully.", false);
                        }
                    }
                    else
                    {
                        if (aCAccountEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to add A CAccount Information.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to update A CAccount Information.", false);
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

        protected void lvACAccount_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            Int64 AccountID;

            Int64.TryParse(e.CommandArgument.ToString(), out AccountID);

            if (AccountID > 0)
            {
                if (string.Equals(e.CommandName, "EditItem"))
                {
                    _AccountID = AccountID;

                    PrepareEditView();

                    cpeEditor.Collapsed = false;
                    cpeEditor.ClientState = "false";
                }
                else if (string.Equals(e.CommandName, "DeleteItem"))
                {
                    try
                    {
                        Int64 result = -1;

                        String fe = SqlExpressionBuilder.PrepareFilterExpression(ACAccountEntity.FLD_NAME_AccountID, AccountID.ToString(), SQLMatchType.Equal);

                        ACAccountEntity aCAccountEntity = new ACAccountEntity();


                        result = FCCACAccount.GetFacadeCreate().Delete(aCAccountEntity, fe, DatabaseOperationType.Delete, TransactionRequired.No);

                        if (result == 0)
                        {
                            _AccountID = 0;
                            _ACAccountEntity = new ACAccountEntity();
                            PrepareInitialView();
                            BindACAccountList();

                            MiscUtil.ShowMessage(lblMessage, "A CAccount has been successfully deleted.", true);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to delete A CAccount.", true);
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

        protected void odsACAccount_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {
            e.InputParameters["filterExpression"] = String.Empty;
        }

        #endregion

        #region Button Event

        protected void btnSave_Click(object sender, EventArgs e)
        {
            SaveACAccountEntity();
        }

        protected void btnAddNew_Click(object sender, EventArgs e)
        {
            _AccountID = 0;
            _ACAccountEntity = new ACAccountEntity();
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
