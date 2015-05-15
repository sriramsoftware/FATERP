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
using Bay.ERP.Web.UI.Manager;

namespace Bay.ERP.Web.UI
{
    public partial class HREmployeeLoanApplicationControl : EmployeeBaseControl
    {       
        #region Properties

        public Int64 _EmployeeLoanApplicationID
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

        public HREmployeeLoanApplicationEntity _HREmployeeLoanApplicationEntity
        {
            get
            {
                HREmployeeLoanApplicationEntity entity = new HREmployeeLoanApplicationEntity();

                if (ViewState["CurrentEntity"] != null)
                {
                    entity = (HREmployeeLoanApplicationEntity)ViewState["CurrentEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["CurrentEntity"] = value;
            }
        }

        private HREmployeeLoanApplicationEntity CurrentHREmployeeLoanApplicationEntity
        {
            get
            {
                if (_EmployeeLoanApplicationID > 0)
                {
                    if (_HREmployeeLoanApplicationEntity.EmployeeLoanApplicationID != _EmployeeLoanApplicationID)
                    {
                        _HREmployeeLoanApplicationEntity = FCCHREmployeeLoanApplication.GetFacadeCreate().GetByID(_EmployeeLoanApplicationID);
                    }
                }

                return _HREmployeeLoanApplicationEntity;
            }
            set
            {
                _HREmployeeLoanApplicationEntity = value;
            }
        }

        #endregion

        #region Methods

        private void BuildDropDownList()
        {
            MiscUtil.PopulateMDLoanCategory(ddlLoanCategoryID, false);
            MiscUtil.PopulateMDCurrency(ddlCurrencyID, false);
            MiscUtil.PopulateMDEmployeeLoanApprovalStatus(ddlEmployeeLoanApprovalStatusID, false);

            if (ddlEmployeeLoanApprovalStatusID != null && ddlEmployeeLoanApprovalStatusID.Items.Count > 0)
            {
                ddlEmployeeLoanApprovalStatusID.SelectedValue = MasterDataConstants.MDLoanApplicatoinStatus.PENDING.ToString();
            }

            MiscUtil.PopulateAPPanel(ddlAPPanelID, false);//, Mas
        }

        private void PrepareValidator()
        {
        }

        private void PrepareInitialView()
        {
            BuildDropDownList();

            txtAppliedLoanAmount.Text = String.Empty;
            txtLoanPaymentStartDate.Text = String.Empty;
            txtLoanPaymentEndDate.Text = String.Empty;
            txtNumberOfInstallment.Text = String.Empty;
            txtDescription.Text = String.Empty;
            txtRemarks.Text = String.Empty;

            btnAddNew.Visible = false;
        }

        private void PrepareEditView()
        {
            HREmployeeLoanApplicationEntity hREmployeeLoanApplicationEntity = CurrentHREmployeeLoanApplicationEntity;


            if (!hREmployeeLoanApplicationEntity.IsNew)
            {
               
                if (ddlLoanCategoryID.Items.Count > 0 && hREmployeeLoanApplicationEntity.LoanCategoryID != null)
                {
                    ddlLoanCategoryID.SelectedValue = hREmployeeLoanApplicationEntity.LoanCategoryID.ToString();
                }

                txtAppliedLoanAmount.Text = hREmployeeLoanApplicationEntity.AppliedLoanAmount.ToString();
                if (ddlCurrencyID.Items.Count > 0 && hREmployeeLoanApplicationEntity.CurrencyID != null)
                {
                    ddlCurrencyID.SelectedValue = hREmployeeLoanApplicationEntity.CurrencyID.ToString();
                }

                txtLoanPaymentStartDate.Text = hREmployeeLoanApplicationEntity.LoanPaymentStartDate.ToStringDefault();
                txtLoanPaymentEndDate.Text = hREmployeeLoanApplicationEntity.LoanPaymentEndDate.ToStringDefault();
                txtNumberOfInstallment.Text = hREmployeeLoanApplicationEntity.NumberOfInstallment.ToString();
                txtDescription.Text = hREmployeeLoanApplicationEntity.Description.ToString();
                if (ddlEmployeeLoanApprovalStatusID.Items.Count > 0 && hREmployeeLoanApplicationEntity.EmployeeLoanApprovalStatusID != null)
                {
                    ddlEmployeeLoanApprovalStatusID.SelectedValue = hREmployeeLoanApplicationEntity.EmployeeLoanApprovalStatusID.ToString();
                }

                txtRemarks.Text = hREmployeeLoanApplicationEntity.Remarks.ToString();

                btnSubmit.Text = "Update";
                btnAddNew.Visible = true;
            }
        }

        private void BindList()
        {
            BindHREmployeeLoanApplicationList();
        }

        private void BindHREmployeeLoanApplicationList()
        {
            lvHREmployeeLoanApplication.DataBind();
        }

        private HREmployeeLoanApplicationEntity BuildHREmployeeLoanApplicationEntity()
        {
            HREmployeeLoanApplicationEntity hREmployeeLoanApplicationEntity = CurrentHREmployeeLoanApplicationEntity;


            hREmployeeLoanApplicationEntity.EmployeeID = OverviewEmployeeID;

            if (ddlLoanCategoryID.Items.Count > 0)
            {
                if (ddlLoanCategoryID.SelectedValue == "0")
                {
                }
                else
                {
                    hREmployeeLoanApplicationEntity.LoanCategoryID = Int64.Parse(ddlLoanCategoryID.SelectedValue);
                }
            }

            if (!txtAppliedLoanAmount.Text.Trim().IsNullOrEmpty())
            {
                hREmployeeLoanApplicationEntity.AppliedLoanAmount = Decimal.Parse(txtAppliedLoanAmount.Text.Trim());
            }

            if (ddlCurrencyID.Items.Count > 0)
            {
                if (ddlCurrencyID.SelectedValue == "0")
                {
                }
                else
                {
                    hREmployeeLoanApplicationEntity.CurrencyID = Int64.Parse(ddlCurrencyID.SelectedValue);
                }
            }

            if (txtLoanPaymentStartDate.Text.Trim().IsNotNullOrEmpty())
            {
                hREmployeeLoanApplicationEntity.LoanPaymentStartDate = MiscUtil.ParseToDateTime(txtLoanPaymentStartDate.Text);
            }
            else
            {
                hREmployeeLoanApplicationEntity.LoanPaymentStartDate = null;
            }

            if (txtLoanPaymentEndDate.Text.Trim().IsNotNullOrEmpty())
            {
                hREmployeeLoanApplicationEntity.LoanPaymentEndDate = MiscUtil.ParseToDateTime(txtLoanPaymentEndDate.Text);
            }
            else
            {
                hREmployeeLoanApplicationEntity.LoanPaymentEndDate = null;
            }

            if (!txtNumberOfInstallment.Text.Trim().IsNullOrEmpty())
            {
                hREmployeeLoanApplicationEntity.NumberOfInstallment = Decimal.Parse(txtNumberOfInstallment.Text.Trim());
            }
            else
            {
                hREmployeeLoanApplicationEntity.NumberOfInstallment = null;
            }

            hREmployeeLoanApplicationEntity.Description = txtDescription.Text.Trim();
            if (ddlEmployeeLoanApprovalStatusID.Items.Count > 0)
            {
                if (ddlEmployeeLoanApprovalStatusID.SelectedValue == "0")
                {
                }
                else
                {
                    hREmployeeLoanApplicationEntity.EmployeeLoanApprovalStatusID = Int64.Parse(ddlEmployeeLoanApprovalStatusID.SelectedValue);
                }
            }

            hREmployeeLoanApplicationEntity.Remarks = txtRemarks.Text.Trim();

            return hREmployeeLoanApplicationEntity;
        }

        private void SaveHREmployeeLoanApplicationEntity()
        {
            if (IsValid)
            {
                try
                {
                    HREmployeeLoanApplicationEntity hREmployeeLoanApplicationEntity = BuildHREmployeeLoanApplicationEntity();

                    Int64 result = -1;

                    if (hREmployeeLoanApplicationEntity.IsNew)
                    {
                        result = FCCHREmployeeLoanApplication.GetFacadeCreate().Add(hREmployeeLoanApplicationEntity, DatabaseOperationType.Add, TransactionRequired.No);
                    }
                    else
                    {
                        String filterExpression = SqlExpressionBuilder.PrepareFilterExpression(HREmployeeLoanApplicationEntity.FLD_NAME_EmployeeLoanApplicationID, hREmployeeLoanApplicationEntity.EmployeeLoanApplicationID.ToString(), SQLMatchType.Equal);
                        result = FCCHREmployeeLoanApplication.GetFacadeCreate().Update(hREmployeeLoanApplicationEntity, filterExpression, DatabaseOperationType.Update, TransactionRequired.No);
                    }

                    if (result > 0)
                    {
                        if (hREmployeeLoanApplicationEntity.IsNew)
                        {
                            #region Approval Process

                            if (ddlAPPanelID != null && ddlAPPanelID.SelectedValue != "0")
                            {

                                Boolean apResult = APRobot.CreateApprovalProcessForNewLoanApplication(result, Int64.Parse(ddlAPPanelID.SelectedValue.ToString()));

                                if (apResult == true)
                                {
                                    MiscUtil.ShowMessage(lblMessage, "Approval Process Submited successfully.", UIConstants.MessageType.GREEN);
                                }
                                else
                                {
                                    MiscUtil.ShowMessage(lblMessage, "Failed to Submit Approval Process.", UIConstants.MessageType.RED);
                                }
                            }
                        }

                            #endregion

                        _EmployeeLoanApplicationID = 0;
                        _HREmployeeLoanApplicationEntity = new HREmployeeLoanApplicationEntity();
                        PrepareInitialView();
                        BindHREmployeeLoanApplicationList();

                        if (hREmployeeLoanApplicationEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Employee Loan Application Information has been added successfully.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Employee Loan Application Information has been updated successfully.", false);
                        }
                    }
                    else
                    {
                        if (hREmployeeLoanApplicationEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to add Employee Loan Application Information.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to update Employee Loan Application Information.", false);
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

        protected void lvHREmployeeLoanApplication_ItemDataBound(object sender, ListViewItemEventArgs e)
        {
            if (e.Item.ItemType == ListViewItemType.DataItem)
            {

                ListViewDataItem dataItem = (ListViewDataItem)e.Item;

                HREmployeeLoanApplication_DetailedEntity ent = (HREmployeeLoanApplication_DetailedEntity)dataItem.DataItem;
                HyperLink lnkShowApprovalStatus = (HyperLink)e.Item.FindControl("lnkShowApprovalStatus");

                APApprovalProcessEntity aPApprovalProcessEntity = APRobot.GetApprovalProcessByTypeAndReference(MasterDataConstants.APType.LOAN_APPLICATION, ent.EmployeeLoanApplicationID);
                if (aPApprovalProcessEntity.APApprovalProcessID > 0)
                {
                    lnkShowApprovalStatus.NavigateUrl = UrlHelper.BuildSecureUrl(
                               "~/AP/APView.aspx",
                               string.Empty,
                               APApprovalProcessEntity.FLD_NAME_APApprovalProcessID,
                               aPApprovalProcessEntity.APApprovalProcessID.ToString()
                               ).ToString();

                    lnkShowApprovalStatus.Target = "_blank";
                }
                else
                {
                    lnkShowApprovalStatus.NavigateUrl = String.Empty;
                    lnkShowApprovalStatus.Enabled = false;
                }
            }
        }

        protected void lvHREmployeeLoanApplication_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            Int64 EmployeeLoanApplicationID;

            Int64.TryParse(e.CommandArgument.ToString(), out EmployeeLoanApplicationID);

            if (EmployeeLoanApplicationID > 0)
            {
                if (string.Equals(e.CommandName, "EditItem"))
                {
                    _EmployeeLoanApplicationID = EmployeeLoanApplicationID;

                    PrepareEditView();

                    cpeEditor.Collapsed = false;
                    cpeEditor.ClientState = "false";
                }
                else if (string.Equals(e.CommandName, "DeleteItem"))
                {
                    try
                    {
                        Int64 result = -1;

                        String fe = SqlExpressionBuilder.PrepareFilterExpression(HREmployeeLoanApplicationEntity.FLD_NAME_EmployeeLoanApplicationID, EmployeeLoanApplicationID.ToString(), SQLMatchType.Equal);

                        HREmployeeLoanApplicationEntity hREmployeeLoanApplicationEntity = new HREmployeeLoanApplicationEntity();


                        result = FCCHREmployeeLoanApplication.GetFacadeCreate().Delete(hREmployeeLoanApplicationEntity, fe, DatabaseOperationType.Delete, TransactionRequired.No);

                        if (result == 0)
                        {
                            _EmployeeLoanApplicationID = 0;
                            _HREmployeeLoanApplicationEntity = new HREmployeeLoanApplicationEntity();
                            PrepareInitialView();
                            BindHREmployeeLoanApplicationList();

                            MiscUtil.ShowMessage(lblMessage, "Employee Loan Application has been successfully deleted.", true);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to delete Employee Loan Application.", true);
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

        protected void odsHREmployeeLoanApplication_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {
            e.InputParameters["filterExpression"] = String.Empty;
        }

        #endregion

        #region Button Event

        protected void btnSave_Click(object sender, EventArgs e)
        {
            SaveHREmployeeLoanApplicationEntity();
        }

        protected void btnAddNew_Click(object sender, EventArgs e)
        {
            _EmployeeLoanApplicationID = 0;
            _HREmployeeLoanApplicationEntity = new HREmployeeLoanApplicationEntity();
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
