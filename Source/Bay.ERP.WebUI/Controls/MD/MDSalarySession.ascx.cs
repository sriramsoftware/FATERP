// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 19-Dec-2013, 12:42:28




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
    public partial class MDSalarySessionControl : BaseControl
    {       
        #region Properties

        public Int64 _SalarySessionID
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

        public MDSalarySessionEntity _MDSalarySessionEntity
        {
            get
            {
                MDSalarySessionEntity entity = new MDSalarySessionEntity();

                if (ViewState["CurrentEntity"] != null)
                {
                    entity = (MDSalarySessionEntity)ViewState["CurrentEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["CurrentEntity"] = value;
            }
        }

        private MDSalarySessionEntity CurrentMDSalarySessionEntity
        {
            get
            {
                if (_SalarySessionID > 0)
                {
                    if (_MDSalarySessionEntity.SalarySessionID != _SalarySessionID)
                    {
                        _MDSalarySessionEntity = FCCMDSalarySession.GetFacadeCreate().GetByID(_SalarySessionID);
                    }
                }

                return _MDSalarySessionEntity;
            }
            set
            {
                _MDSalarySessionEntity = value;
            }
        }

        #endregion

        #region Methods

        private void BuildDropDownList()
        {
            MiscUtil.PopulateACFiscalYear(ddlFiscalYearID, false);
            MiscUtil.PopulateMDSalarySessionStatus(ddlSalarySessionStatusID, false);
        }

        private void PrepareValidator()
        {
        }

        private void PrepareInitialView()
        {
            BuildDropDownList();

            txtName.Text = String.Empty;
            txtSessionStartDate.Text = System.DateTime.Now.ToString(UIConstants.SHORT_DATE_FORMAT);
            txtSessionEndDate.Text = System.DateTime.Now.ToString(UIConstants.SHORT_DATE_FORMAT);
            txtRemarks.Text = String.Empty;
            chkIsCurrentSession.Checked = false;

            btnSubmit.Text = "Add";
            btnAddNew.Visible = false;
        }

        private void PrepareEditView()
        {
            MDSalarySessionEntity mDSalarySessionEntity = CurrentMDSalarySessionEntity;


            if (!mDSalarySessionEntity.IsNew)
            {
                if (ddlFiscalYearID.Items.Count > 0 && mDSalarySessionEntity.FiscalYearID != null)
                {
                    ddlFiscalYearID.SelectedValue = mDSalarySessionEntity.FiscalYearID.ToString();
                }

                txtName.Text = mDSalarySessionEntity.Name.ToString();
                txtSessionStartDate.Text = mDSalarySessionEntity.SessionStartDate.ToStringDefault();
                txtSessionEndDate.Text = mDSalarySessionEntity.SessionEndDate.ToStringDefault();
                txtRemarks.Text = mDSalarySessionEntity.Remarks.ToString();
                if (ddlSalarySessionStatusID.Items.Count > 0 && mDSalarySessionEntity.SalarySessionStatusID != null)
                {
                    ddlSalarySessionStatusID.SelectedValue = mDSalarySessionEntity.SalarySessionStatusID.ToString();
                }

                chkIsCurrentSession.Checked = mDSalarySessionEntity.IsCurrentSession;

                btnSubmit.Text = "Update";
                btnAddNew.Visible = true;
            }
        }

        private void BindList()
        {
            BindMDSalarySessionList();
        }

        private void BindMDSalarySessionList()
        {
            lvMDSalarySession.DataBind();
        }

        private MDSalarySessionEntity BuildMDSalarySessionEntity()
        {
            MDSalarySessionEntity mDSalarySessionEntity = CurrentMDSalarySessionEntity;

            if (ddlFiscalYearID.Items.Count > 0)
            {
                if (ddlFiscalYearID.SelectedValue == "0")
                {
                }
                else
                {
                    mDSalarySessionEntity.FiscalYearID = Int64.Parse(ddlFiscalYearID.SelectedValue);
                }
            }

            mDSalarySessionEntity.Name = txtName.Text.Trim();
            if (txtSessionStartDate.Text.Trim().IsNotNullOrEmpty())
            {
                mDSalarySessionEntity.SessionStartDate = MiscUtil.ParseToDateTime(txtSessionStartDate.Text);
            }

            if (txtSessionEndDate.Text.Trim().IsNotNullOrEmpty())
            {
                mDSalarySessionEntity.SessionEndDate = MiscUtil.ParseToDateTime(txtSessionEndDate.Text);
            }

            mDSalarySessionEntity.Remarks = txtRemarks.Text.Trim();
            if (ddlSalarySessionStatusID.Items.Count > 0)
            {
                if (ddlSalarySessionStatusID.SelectedValue == "0")
                {
                }
                else
                {
                    mDSalarySessionEntity.SalarySessionStatusID = Int64.Parse(ddlSalarySessionStatusID.SelectedValue);
                }
            }

            mDSalarySessionEntity.IsCurrentSession = chkIsCurrentSession.Checked;


            return mDSalarySessionEntity;
        }

        private void SaveMDSalarySessionEntity()
        {
            if (IsValid)
            {
                try
                {
                    MDSalarySessionEntity mDSalarySessionEntity = BuildMDSalarySessionEntity();

                    Int64 result = -1;

                    if (mDSalarySessionEntity.IsNew)
                    {
                        result = FCCMDSalarySession.GetFacadeCreate().Add(mDSalarySessionEntity, DatabaseOperationType.Add, TransactionRequired.No);
                    }
                    else
                    {
                        String filterExpression = SqlExpressionBuilder.PrepareFilterExpression(MDSalarySessionEntity.FLD_NAME_SalarySessionID, mDSalarySessionEntity.SalarySessionID.ToString(), SQLMatchType.Equal);
                        result = FCCMDSalarySession.GetFacadeCreate().Update(mDSalarySessionEntity, filterExpression, DatabaseOperationType.Update, TransactionRequired.No);
                    }

                    if (result > 0)
                    {
                        _SalarySessionID = 0;
                        _MDSalarySessionEntity = new MDSalarySessionEntity();
                        PrepareInitialView();
                        BindMDSalarySessionList();

                        if (mDSalarySessionEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Salary Session Information has been added successfully.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Salary Session Information has been updated successfully.", false);
                        }

                        Response.Redirect("~/HR/HRWorkingDay.aspx");
                    }
                    else
                    {
                        if (mDSalarySessionEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to add Salary Session Information.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to update Salary Session Information.", false);
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

        protected void lvMDSalarySession_ItemDataBound(object sender, ListViewItemEventArgs e)
        {
            if (e.Item.ItemType == ListViewItemType.DataItem)
            {

                ListViewDataItem dataItem = (ListViewDataItem)e.Item;

                MDSalarySession_DetailedEntity ent = (MDSalarySession_DetailedEntity)dataItem.DataItem;
                HyperLink hypReport = (HyperLink)e.Item.FindControl("hypReport");
                HyperLink hypSalaryPayment = (HyperLink)e.Item.FindControl("hypSalaryPayment");

                HyperLink hypEmployeeSalaryPaymentReport = (HyperLink)e.Item.FindControl("hypEmployeeSalaryPaymentReport");
                HyperLink hypSecurityGaurdSalaryPaymentReport = (HyperLink)e.Item.FindControl("hypSecurityGaurdSalaryPaymentReport");

                HyperLink hypEmployeeSalaryStatementReport = (HyperLink)e.Item.FindControl("hypEmployeeSalaryStatementReport");
                HyperLink hypSecurityGaurdSalaryStatementReport = (HyperLink)e.Item.FindControl("hypSecurityGaurdSalaryStatementReport");

                HyperLink hypBankDisbursementLevel4Plus = (HyperLink)e.Item.FindControl("hypBankDisbursementLevel4Plus");
                HyperLink hypBankDisbursementLevel1To3 = (HyperLink)e.Item.FindControl("hypBankDisbursementLevel1To3");
                HyperLink hypLeaveApplications = (HyperLink)e.Item.FindControl("hypLeaveApplications");
                
                String NavigationUrl = String.Empty;

                NavigationUrl = UrlHelper.BuildSecureUrl("~/Reports/ReportViewer.aspx", string.Empty, "do", ReportConstants.HR_TIME_SHEET, UrlConstants.OVERVIEW_HR_SALARY_SESSION_ID, ent.SalarySessionID.ToString()).ToString();

                hypSalaryPayment.NavigateUrl = UrlHelper.BuildSecureUrl("~/HR/HREmployeeSalaryPayment.aspx", string.Empty, UrlConstants.OVERVIEW_HR_SALARY_SESSION_ID, ent.SalarySessionID.ToString()).ToString();
                hypSalaryPayment.Target = "_blank";

                hypEmployeeSalaryPaymentReport.NavigateUrl = UrlHelper.BuildSecureUrl("~/Reports/ReportViewer.aspx", string.Empty, "do", ReportConstants.HR_EMPLOYEE_SALARY_PAYMENT_REPORT, UrlConstants.OVERVIEW_HR_SALARY_SESSION_ID, ent.SalarySessionID.ToString(), UrlConstants.OVERVIEW_MDDEPARTMENT_FROMID, MasterDataConstants.MDDepartment.MIS_DEPARTMENTID.ToString(), UrlConstants.OVERVIEW_MDDEPARTMENT_TOID, MasterDataConstants.MDDepartment.IS_DEPARTMENTID.ToString(), UrlConstants.OVERVIEW_MDDEPARTMENT_OTHERID, MasterDataConstants.MDDepartment.SECURITY_DEPARTMENTID.ToString()).ToString();
                hypEmployeeSalaryPaymentReport.Target = "_blank";

                hypSecurityGaurdSalaryPaymentReport.NavigateUrl = UrlHelper.BuildSecureUrl("~/Reports/ReportViewer.aspx", string.Empty, "do", ReportConstants.HR_EMPLOYEE_SALARY_PAYMENT_REPORT, UrlConstants.OVERVIEW_HR_SALARY_SESSION_ID, ent.SalarySessionID.ToString(), UrlConstants.OVERVIEW_MDDEPARTMENT_FROMID, MasterDataConstants.MDDepartment.SECURITY_DEPARTMENTID.ToString(), UrlConstants.OVERVIEW_MDDEPARTMENT_TOID, MasterDataConstants.MDDepartment.SECURITY_DEPARTMENTID.ToString(), UrlConstants.OVERVIEW_MDDEPARTMENT_OTHERID, MasterDataConstants.MDDepartment.NO_DEPARTMENTID.ToString()).ToString();
                hypSecurityGaurdSalaryPaymentReport.Target = "_blank";

                hypEmployeeSalaryStatementReport.NavigateUrl = UrlHelper.BuildSecureUrl("~/Reports/ReportViewer.aspx", string.Empty, "do", ReportConstants.HR_EMPLOYEE_SALARY_STATEMENT_REPORT, UrlConstants.OVERVIEW_HR_SALARY_SESSION_ID, ent.SalarySessionID.ToString(), UrlConstants.OVERVIEW_MDDEPARTMENT_FROMID, MasterDataConstants.MDDepartment.MIS_DEPARTMENTID.ToString(), UrlConstants.OVERVIEW_MDDEPARTMENT_TOID, MasterDataConstants.MDDepartment.IS_DEPARTMENTID.ToString(), UrlConstants.OVERVIEW_MDDEPARTMENT_OTHERID, MasterDataConstants.MDDepartment.SECURITY_DEPARTMENTID.ToString()).ToString();
                hypEmployeeSalaryStatementReport.Target = "_blank";

                hypSecurityGaurdSalaryStatementReport.NavigateUrl = UrlHelper.BuildSecureUrl("~/Reports/ReportViewer.aspx", string.Empty, "do", ReportConstants.HR_EMPLOYEE_SALARY_STATEMENT_REPORT, UrlConstants.OVERVIEW_HR_SALARY_SESSION_ID, ent.SalarySessionID.ToString(), UrlConstants.OVERVIEW_MDDEPARTMENT_FROMID, MasterDataConstants.MDDepartment.SECURITY_DEPARTMENTID.ToString(), UrlConstants.OVERVIEW_MDDEPARTMENT_TOID, MasterDataConstants.MDDepartment.SECURITY_DEPARTMENTID.ToString(), UrlConstants.OVERVIEW_MDDEPARTMENT_OTHERID, MasterDataConstants.MDDepartment.NO_DEPARTMENTID.ToString()).ToString();
                hypSecurityGaurdSalaryStatementReport.Target = "_blank";


                hypBankDisbursementLevel4Plus.NavigateUrl = UrlHelper.BuildSecureUrl("~/Reports/ReportViewer.aspx", string.Empty, "do", ReportConstants.HR_EMPLOYEE_SALARY_DISBURSEMENT_BANK, UrlConstants.OVERVIEW_HR_SALARY_SESSION_ID, ent.SalarySessionID.ToString(), UrlConstants.OVERVIEW_FROM_LEVEL, MasterDataConstants.HREmployeeSalaryLevel.Level4.ToString(), UrlConstants.OVERVIEW_TO_LEVEL, MasterDataConstants.HREmployeeSalaryLevel.Level20.ToString()).ToString();
                hypBankDisbursementLevel4Plus.Target = "_blank";

                hypBankDisbursementLevel1To3.NavigateUrl = UrlHelper.BuildSecureUrl("~/Reports/ReportViewer.aspx", string.Empty, "do", ReportConstants.HR_EMPLOYEE_SALARY_DISBURSEMENT_BANK, UrlConstants.OVERVIEW_HR_SALARY_SESSION_ID, ent.SalarySessionID.ToString(), UrlConstants.OVERVIEW_FROM_LEVEL, MasterDataConstants.HREmployeeSalaryLevel.Level1.ToString(), UrlConstants.OVERVIEW_TO_LEVEL, MasterDataConstants.HREmployeeSalaryLevel.Level3.ToString()).ToString();
                hypBankDisbursementLevel1To3.Target = "_blank";

                hypLeaveApplications.NavigateUrl = UrlHelper.BuildSecureUrl("~/Reports/ReportViewer.aspx", string.Empty, "do", ReportConstants.HR_EMPLOYEE_LEAVE_APPLICATIONS_REPORT, UrlConstants.OVERVIEW_HR_SALARY_SESSION_ID, ent.SalarySessionID.ToString()).ToString();
                hypLeaveApplications.Target = "_blank";

                hypReport.NavigateUrl = NavigationUrl;
                hypReport.Target = "_blank";
            }
        }

        protected void lvMDSalarySession_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            Int64 SalarySessionID;

            Int64.TryParse(e.CommandArgument.ToString(), out SalarySessionID);

            if (SalarySessionID > 0)
            {
                if (string.Equals(e.CommandName, "EditItem"))
                {
                    _SalarySessionID = SalarySessionID;

                    PrepareEditView();

                    cpeEditor.Collapsed = false;
                    cpeEditor.ClientState = "false";
                }
                else if (string.Equals(e.CommandName, "DeleteItem"))
                {
                    try
                    {
                        Int64 result = -1;

                        String fe = SqlExpressionBuilder.PrepareFilterExpression(MDSalarySessionEntity.FLD_NAME_SalarySessionID, SalarySessionID.ToString(), SQLMatchType.Equal);

                        MDSalarySessionEntity mDSalarySessionEntity = new MDSalarySessionEntity();


                        result = FCCMDSalarySession.GetFacadeCreate().Delete(mDSalarySessionEntity, fe, DatabaseOperationType.Delete, TransactionRequired.No);

                        if (result == 0)
                        {
                            _SalarySessionID = 0;
                            _MDSalarySessionEntity = new MDSalarySessionEntity();
                            PrepareInitialView();
                            BindMDSalarySessionList();

                            MiscUtil.ShowMessage(lblMessage, "Salary Session has been successfully deleted.", true);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to delete Salary Session.", true);
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

        protected void odsMDSalarySession_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {
            e.InputParameters["filterExpression"] = String.Empty;
        }

        #endregion

        #region Button Event

        protected void btnSave_Click(object sender, EventArgs e)
        {
            SaveMDSalarySessionEntity();
        }

        protected void btnAddNew_Click(object sender, EventArgs e)
        {
            _SalarySessionID = 0;
            _MDSalarySessionEntity = new MDSalarySessionEntity();
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
