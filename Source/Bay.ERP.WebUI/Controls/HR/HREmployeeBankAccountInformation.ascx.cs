// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 20-Dec-2013, 02:17:52




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
    public partial class HREmployeeBankAccountInformationControl : EmployeeBaseControl
    {       
        #region Properties

        public Int64 _EmployeeBankAccountInformationID
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

        public HREmployeeBankAccountInformationEntity _HREmployeeBankAccountInformationEntity
        {
            get
            {
                HREmployeeBankAccountInformationEntity entity = new HREmployeeBankAccountInformationEntity();

                if (ViewState["CurrentEntity"] != null)
                {
                    entity = (HREmployeeBankAccountInformationEntity)ViewState["CurrentEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["CurrentEntity"] = value;
            }
        }

        private HREmployeeBankAccountInformationEntity CurrentHREmployeeBankAccountInformationEntity
        {
            get
            {
                if (_EmployeeBankAccountInformationID > 0)
                {
                    if (_HREmployeeBankAccountInformationEntity.EmployeeBankAccountInformationID != _EmployeeBankAccountInformationID)
                    {
                        _HREmployeeBankAccountInformationEntity = FCCHREmployeeBankAccountInformation.GetFacadeCreate().GetByID(_EmployeeBankAccountInformationID);
                    }
                }

                return _HREmployeeBankAccountInformationEntity;
            }
            set
            {
                _HREmployeeBankAccountInformationEntity = value;
            }
        }

        #endregion

        #region Methods

        private void BuildDropDownList()
        {
            MiscUtil.PopulateMDCity(ddlCityID, false);
            MiscUtil.PopulateMDBankAccountCategory(ddlBankAccountCategoryID, false);
            MiscUtil.PopulateACBankAccount(ddlBankList, false);
        }

        private void PrepareValidator()
        {
            revZipCode.ValidationExpression = ValidationConstants.RegularExpression.ZipCode;
            txtZipCode.MaxLength = ValidationConstants.FieldLength.ZipCode;
            revZipCode.ErrorMessage = ValidationConstants.ErrorMessage.ZipCode;
        }

        private void PrepareInitialView()
        {
            BuildDropDownList();

            txtBankAccountNo.Text = String.Empty;
            txtBankName.Text = String.Empty;
            txtBankAddress.Text = String.Empty;
            txtZipCode.Text = String.Empty;
            txtSwipeCode.Text = String.Empty;
            txtRoutingNo.Text = String.Empty;
            chkIsSalaryAccotunt.Checked = false;
            chkIsDefault.Checked = false;

            btnSubmit.Text = "Add";
            btnAddNew.Visible = false;
        }

        private void PrepareEditView()
        {
            HREmployeeBankAccountInformationEntity hREmployeeBankAccountInformationEntity = CurrentHREmployeeBankAccountInformationEntity;


            if (!hREmployeeBankAccountInformationEntity.IsNew)
            {
                txtBankAccountNo.Text = hREmployeeBankAccountInformationEntity.BankAccountNo.ToString();
                txtBankName.Text = hREmployeeBankAccountInformationEntity.BankName.ToString();
                txtBankAddress.Text = hREmployeeBankAccountInformationEntity.BankAddress.ToString();
                if (ddlCityID.Items.Count > 0 && hREmployeeBankAccountInformationEntity.CityID != null)
                {
                    ddlCityID.SelectedValue = hREmployeeBankAccountInformationEntity.CityID.ToString();
                }

                txtZipCode.Text = hREmployeeBankAccountInformationEntity.ZipCode.ToString();
                if (ddlBankAccountCategoryID.Items.Count > 0 && hREmployeeBankAccountInformationEntity.BankAccountCategoryID != null)
                {
                    ddlBankAccountCategoryID.SelectedValue = hREmployeeBankAccountInformationEntity.BankAccountCategoryID.ToString();
                }

                txtSwipeCode.Text = hREmployeeBankAccountInformationEntity.SwipeCode.ToString();
                txtRoutingNo.Text = hREmployeeBankAccountInformationEntity.RoutingNo.ToString();
                chkIsSalaryAccotunt.Checked = hREmployeeBankAccountInformationEntity.IsSalaryAccotunt;
                chkIsDefault.Checked = hREmployeeBankAccountInformationEntity.IsDefault;

                btnSubmit.Text = "Update";
                btnAddNew.Visible = true;
            }
        }

        private void BindList()
        {
            BindHREmployeeBankAccountInformationList();
        }

        private void BindHREmployeeBankAccountInformationList()
        {
            lvHREmployeeBankAccountInformation.DataBind();
        }

        private HREmployeeBankAccountInformationEntity BuildHREmployeeBankAccountInformationEntity()
        {
            HREmployeeBankAccountInformationEntity hREmployeeBankAccountInformationEntity = CurrentHREmployeeBankAccountInformationEntity;


            hREmployeeBankAccountInformationEntity.EmployeeID = OverviewEmployeeID;

            hREmployeeBankAccountInformationEntity.BankAccountNo = txtBankAccountNo.Text.Trim();
            hREmployeeBankAccountInformationEntity.BankName = txtBankName.Text.Trim();
            hREmployeeBankAccountInformationEntity.BankAddress = txtBankAddress.Text.Trim();
            if (ddlCityID.Items.Count > 0)
            {
                if (ddlCityID.SelectedValue == "0")
                {
                }
                else
                {
                    hREmployeeBankAccountInformationEntity.CityID = Int64.Parse(ddlCityID.SelectedValue);
                }
            }

            hREmployeeBankAccountInformationEntity.ZipCode = txtZipCode.Text.Trim();
            if (ddlBankAccountCategoryID.Items.Count > 0)
            {
                if (ddlBankAccountCategoryID.SelectedValue == "0")
                {
                }
                else
                {
                    hREmployeeBankAccountInformationEntity.BankAccountCategoryID = Int64.Parse(ddlBankAccountCategoryID.SelectedValue);
                }
            }

            hREmployeeBankAccountInformationEntity.SwipeCode = txtSwipeCode.Text.Trim();
            hREmployeeBankAccountInformationEntity.RoutingNo = txtRoutingNo.Text.Trim();
            hREmployeeBankAccountInformationEntity.IsSalaryAccotunt = chkIsSalaryAccotunt.Checked;

            hREmployeeBankAccountInformationEntity.IsDefault = chkIsDefault.Checked;


            return hREmployeeBankAccountInformationEntity;
        }

        private void SaveHREmployeeBankAccountInformationEntity()
        {
            if (IsValid)
            {
                try
                {
                    HREmployeeBankAccountInformationEntity hREmployeeBankAccountInformationEntity = BuildHREmployeeBankAccountInformationEntity();

                    Int64 result = -1;

                    if (hREmployeeBankAccountInformationEntity.IsNew)
                    {
                        result = FCCHREmployeeBankAccountInformation.GetFacadeCreate().Add(hREmployeeBankAccountInformationEntity, DatabaseOperationType.Add, TransactionRequired.No);
                    }
                    else
                    {
                        String filterExpression = SqlExpressionBuilder.PrepareFilterExpression(HREmployeeBankAccountInformationEntity.FLD_NAME_EmployeeBankAccountInformationID, hREmployeeBankAccountInformationEntity.EmployeeBankAccountInformationID.ToString(), SQLMatchType.Equal);
                        result = FCCHREmployeeBankAccountInformation.GetFacadeCreate().Update(hREmployeeBankAccountInformationEntity, filterExpression, DatabaseOperationType.Update, TransactionRequired.No);
                    }

                    if (result > 0)
                    {
                        _EmployeeBankAccountInformationID = 0;
                        _HREmployeeBankAccountInformationEntity = new HREmployeeBankAccountInformationEntity();
                        PrepareInitialView();
                        BindHREmployeeBankAccountInformationList();

                        if (hREmployeeBankAccountInformationEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Employee Bank Account Information Information has been added successfully.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Employee Bank Account Information Information has been updated successfully.", false);
                        }
                    }
                    else
                    {
                        if (hREmployeeBankAccountInformationEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to add Employee Bank Account Information Information.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to update Employee Bank Account Information Information.", false);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MiscUtil.ShowMessage(lblMessage, ex.Message, true);
                }
            }
        }

        private void GetBankInfo()
        {
            ACBankAccountEntity entity = FCCACBankAccount.GetFacadeCreate().GetByID(Int64.Parse(ddlBankList.SelectedValue));
            txtBankName.Text = entity.BankAccountName;
            txtBankAddress.Text = entity.BankAddress;
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
                GetBankInfo();
            }
        }

        #endregion

        #region List View Event

        protected void lvHREmployeeBankAccountInformation_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            Int64 EmployeeBankAccountInformationID;

            Int64.TryParse(e.CommandArgument.ToString(), out EmployeeBankAccountInformationID);

            if (EmployeeBankAccountInformationID > 0)
            {
                if (string.Equals(e.CommandName, "EditItem"))
                {
                    _EmployeeBankAccountInformationID = EmployeeBankAccountInformationID;

                    PrepareEditView();

                    cpeEditor.Collapsed = false;
                    cpeEditor.ClientState = "false";
                }
                else if (string.Equals(e.CommandName, "DeleteItem"))
                {
                    try
                    {
                        Int64 result = -1;

                        String fe = SqlExpressionBuilder.PrepareFilterExpression(HREmployeeBankAccountInformationEntity.FLD_NAME_EmployeeBankAccountInformationID, EmployeeBankAccountInformationID.ToString(), SQLMatchType.Equal);

                        HREmployeeBankAccountInformationEntity hREmployeeBankAccountInformationEntity = new HREmployeeBankAccountInformationEntity();


                        result = FCCHREmployeeBankAccountInformation.GetFacadeCreate().Delete(hREmployeeBankAccountInformationEntity, fe, DatabaseOperationType.Delete, TransactionRequired.No);

                        if (result == 0)
                        {
                            _EmployeeBankAccountInformationID = 0;
                            _HREmployeeBankAccountInformationEntity = new HREmployeeBankAccountInformationEntity();
                            PrepareInitialView();
                            BindHREmployeeBankAccountInformationList();

                            MiscUtil.ShowMessage(lblMessage, "Employee Bank Account Information has been successfully deleted.", true);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to delete Employee Bank Account Information.", true);
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

        protected void odsHREmployeeBankAccountInformation_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {
            String fe = SqlExpressionBuilder.PrepareFilterExpression("HREmployeeBankAccountInformation." + HREmployeeBankAccountInformationEntity.FLD_NAME_EmployeeID, OverviewEmployeeID.ToString(), SQLMatchType.Equal);
            e.InputParameters["filterExpression"] = fe;
        }

        #endregion

        #region Button Event

        protected void btnSave_Click(object sender, EventArgs e)
        {
            SaveHREmployeeBankAccountInformationEntity();
        }

        protected void btnAddNew_Click(object sender, EventArgs e)
        {
            _EmployeeBankAccountInformationID = 0;
            _HREmployeeBankAccountInformationEntity = new HREmployeeBankAccountInformationEntity();
            PrepareInitialView();
        }

        protected void btnClear_Click(object sender, EventArgs e)
        {
            PrepareInitialView();
            PrepareEditView();
        }

        #endregion

        #region Dropdwon Event

        protected void ddlBankList_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetBankInfo();
        }

        #endregion

        #endregion Event
    }
}
