// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 12-Jan-2014, 03:42:17




using System;
using System.Web.UI.WebControls;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Bay.ERP.Web.UI.Helper;
using Bay.ERP.Common.BusinessEntities;
using Bay.ERP.BusinessFacade;
using Bay.ERP.FacadeCreator.FacadeContext;
using Bay.ERP.Common.Helper;
using Bay.ERP.Common.Shared;

namespace Bay.ERP.Web.UI
{
    public partial class HREmployeeMonthlyTimeSheetSummaryControl : BaseControl
    {
        #region Properties

        public Int64 _EmployeeMonthlyTimeSheetID
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

        public HREmployeeMonthlyTimeSheetSummaryEntity _HREmployeeMonthlyTimeSheetSummaryEntity
        {
            get
            {
                HREmployeeMonthlyTimeSheetSummaryEntity entity = new HREmployeeMonthlyTimeSheetSummaryEntity();

                if (ViewState["CurrentEntity"] != null)
                {
                    entity = (HREmployeeMonthlyTimeSheetSummaryEntity)ViewState["CurrentEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["CurrentEntity"] = value;
            }
        }

        private HREmployeeMonthlyTimeSheetSummaryEntity CurrentHREmployeeMonthlyTimeSheetSummaryEntity
        {
            get
            {
                if (_EmployeeMonthlyTimeSheetID > 0)
                {
                    if (_HREmployeeMonthlyTimeSheetSummaryEntity.EmployeeMonthlyTimeSheetID != _EmployeeMonthlyTimeSheetID)
                    {
                        _HREmployeeMonthlyTimeSheetSummaryEntity = FCCHREmployeeMonthlyTimeSheetSummary.GetFacadeCreate().GetByID(_EmployeeMonthlyTimeSheetID);
                    }
                }

                return _HREmployeeMonthlyTimeSheetSummaryEntity;
            }
            set
            {
                _HREmployeeMonthlyTimeSheetSummaryEntity = value;
            }
        }

        #endregion

        #region Methods

        private void BuildDropDownList()
        {
            //MiscUtil.PopulateHREmployeeByActive(ddlEmployeeID, false);
            //MiscUtil.PopulateMDDesignation(ddlDesignationID, true);
            MiscUtil.PopulateMDSalarySession(ddlSalarySessionID, false);
        }

        private void PrepareValidator()
        {
        }

        private HREmployee_DetailedEntity GetHREmployeeInfo(Int64 employeeID)
        {
            IList<HREmployee_DetailedEntity> list = FCCHREmployeeMonthlyTimeSheet_Detailed.GetFacadeCreate().GetIL(1000, 1, String.Empty, String.Empty);

            HREmployee_DetailedEntity ent = list.Single(x => x.EmployeeID == employeeID);


            return ent;
        }

        private void PrepareInitialView()
        {
            BuildDropDownList();

            //txtEmployeeJobTypeID.Text = String.Empty;
            //txtSalaryLevel.Text = String.Empty;
            //txtOnJob.Text = String.Empty;
            //txtHoliday.Text = String.Empty;
            //txtLCASUAL.Text = String.Empty;
            //txtLMEDICAL.Text = String.Empty;
            //txtEARNLEAVE.Text = String.Empty;
            //txtLWP.Text = String.Empty;
            //txtACTUALWORKDAYS.Text = String.Empty;
            //txtREMARKS.Text = String.Empty;
            //txtNUMBEROFMEALS.Text = String.Empty;
            //txtPROJECTACTUAL.Text = String.Empty;
            //txtOTHERLEAVE.Text = String.Empty;
            //txtField1.Text = String.Empty;
            //txtField11.Text = String.Empty;
            //txtField12.Text = String.Empty;
            //txtField13.Text = String.Empty;
            //txtField14.Text = String.Empty;
            //txtField15.Text = String.Empty;

            //btnSubmit.Text = "Add";
            //btnAddNew.Visible = false;
        }
                        
        private void UpdateHREmployeeDetailsForMonthlyTimeSheetSummary()
        {
            try
            {
                IList<ListViewDataItem> list = lvHREmployeeDetailsForMonthlyTimeSheetSummary.Items;

                if (list != null && list.Count > 0)
                {
                    Int32 tempDataItemIndex = 0;

                    foreach (ListViewDataItem lvdi in list)
                    {
                        DataKey currentDataKey = lvHREmployeeDetailsForMonthlyTimeSheetSummary.DataKeys[tempDataItemIndex++];
                        Int64 _employeeID = (Int64)currentDataKey["EmployeeID"];

                        Boolean isSaveFlag = true;

                        String fe1 = SqlExpressionBuilder.PrepareFilterExpression(HREmployeeMonthlyTimeSheetSummaryEntity.FLD_NAME_EmployeeID, _employeeID.ToString(), SQLMatchType.Equal);
                        String fe2 = SqlExpressionBuilder.PrepareFilterExpression(HREmployeeMonthlyTimeSheetSummaryEntity.FLD_NAME_SalarySessionID, ddlSalarySessionID.SelectedValue.ToString(), SQLMatchType.Equal);
                        String fe = SqlExpressionBuilder.PrepareFilterExpression(fe1, SQLJoinType.AND, fe2);

                        IList<HREmployeeMonthlyTimeSheetSummaryEntity> lstHREmployeeMonthlyTimeSheetSummary = FCCHREmployeeMonthlyTimeSheetSummary.GetFacadeCreate().GetIL(null, null, String.Empty, fe, DatabaseOperationType.LoadWithFilterExpression);

                        if (lstHREmployeeMonthlyTimeSheetSummary != null && lstHREmployeeMonthlyTimeSheetSummary.Count > 0)
                        {
                            isSaveFlag = false;
                        }


                        //String fe = SqlExpressionBuilder.PrepareFilterExpression(HREmployeeMonthlyTimeSheetSummaryEntity.em)
                        HREmployee_DetailedEntity employeeEntity = GetHREmployeeInfo(_employeeID);

                        TextBox txtEmployeeName = (TextBox)lvdi.FindControl("txtEmployeeName");
                        TextBox txtDesignation = (TextBox)lvdi.FindControl("txtDesignation");
                        TextBox txtEmployeeJobTypeID = (TextBox)lvdi.FindControl("txtEmployeeJobTypeID");
                        TextBox txtSalaryLevel = (TextBox)lvdi.FindControl("txtSalaryLevel");
                        TextBox txtOnJob = (TextBox)lvdi.FindControl("txtOnJob");
                        TextBox txtHoliday = (TextBox)lvdi.FindControl("txtHoliday");
                        TextBox txtLCASUAL = (TextBox)lvdi.FindControl("txtLCASUAL");
                        TextBox txtLMEDICAL = (TextBox)lvdi.FindControl("txtLMEDICAL");
                        TextBox txtEARNLEAVE = (TextBox)lvdi.FindControl("txtEARNLEAVE");
                        TextBox txtLWP = (TextBox)lvdi.FindControl("txtLWP");
                        TextBox txtACTUALWORKDAYS = (TextBox)lvdi.FindControl("txtACTUALWORKDAYS");
                        TextBox txtREMARKS = (TextBox)lvdi.FindControl("txtREMARKS");
                        TextBox txtNUMBEROFMEALS = (TextBox)lvdi.FindControl("txtNUMBEROFMEALS");
                        TextBox txtPROJECTACTUAL = (TextBox)lvdi.FindControl("txtPROJECTACTUAL");
                        TextBox txtOTHERLEAVE = (TextBox)lvdi.FindControl("txtEARNLEAVE");
                        Label lbldepartmentID = (Label)lvdi.FindControl("lbldepartmentID");
                        String remarks= String.Empty;
                        
                        Decimal totalLeave = Decimal.Parse(txtLCASUAL.Text) + Decimal.Parse(txtLMEDICAL.Text) + Decimal.Parse(txtEARNLEAVE.Text);
                        Decimal actualWorkingdays = (Decimal.Parse(txtOnJob.Text) + Decimal.Parse(txtHoliday.Text)) - Decimal.Parse(txtLWP.Text);

                        if(txtLWP.Text.IsNotNullOrEmpty() && Decimal.Parse(txtLWP.Text) > 0)
                        {
                            remarks+=txtLWP.Text + " LWP for " + (Decimal.Parse(txtLWP.Text) * 6) + " Late. ";
                        }

                        if (totalLeave > 0)
                        {
                            remarks+= totalLeave+" Leave";
                        }
                        txtREMARKS.Text = remarks;

                        HREmployeeMonthlyTimeSheetSummaryEntity hREmployeeMonthlyTimeSheetSummaryEntity = new HREmployeeMonthlyTimeSheetSummaryEntity();

                        hREmployeeMonthlyTimeSheetSummaryEntity.EmployeeID = employeeEntity.EmployeeID;
                        hREmployeeMonthlyTimeSheetSummaryEntity.DesignationID = employeeEntity.DesignationID;
                        hREmployeeMonthlyTimeSheetSummaryEntity.EmployeeJobTypeID = employeeEntity.EmployeeJobTypeID;
                        hREmployeeMonthlyTimeSheetSummaryEntity.OnJob = Decimal.Parse(txtOnJob.Text);
                        hREmployeeMonthlyTimeSheetSummaryEntity.Holiday = Decimal.Parse(txtHoliday.Text);
                        hREmployeeMonthlyTimeSheetSummaryEntity.LCASUAL = Decimal.Parse(txtLCASUAL.Text);
                        hREmployeeMonthlyTimeSheetSummaryEntity.LMEDICAL = Decimal.Parse(txtLMEDICAL.Text);
                        hREmployeeMonthlyTimeSheetSummaryEntity.LWP = Decimal.Parse(txtLWP.Text);
                        hREmployeeMonthlyTimeSheetSummaryEntity.EARNLEAVE = Decimal.Parse(txtEARNLEAVE.Text);
                        hREmployeeMonthlyTimeSheetSummaryEntity.ACTUALWORKDAYS = actualWorkingdays;
                        hREmployeeMonthlyTimeSheetSummaryEntity.REMARKS = txtREMARKS.Text.ToString().Trim();
                        hREmployeeMonthlyTimeSheetSummaryEntity.NUMBEROFMEALS = Decimal.Parse(txtNUMBEROFMEALS.Text);
                        hREmployeeMonthlyTimeSheetSummaryEntity.PROJECTACTUAL = Decimal.Parse(txtPROJECTACTUAL.Text);
                        hREmployeeMonthlyTimeSheetSummaryEntity.OTHERLEAVE = Decimal.Parse(txtOTHERLEAVE.Text);
                        hREmployeeMonthlyTimeSheetSummaryEntity.SalarySessionID = Int64.Parse(ddlSalarySessionID.SelectedValue);
                        hREmployeeMonthlyTimeSheetSummaryEntity.DepartmentID = Int64.Parse(lbldepartmentID.Text);

                        if (txtSalaryLevel.Text.IsNotNullOrEmpty())
                        {
                            hREmployeeMonthlyTimeSheetSummaryEntity.SalaryLevel = Int32.Parse(txtSalaryLevel.Text);
                        }
                        else
                        {
                            hREmployeeMonthlyTimeSheetSummaryEntity.SalaryLevel = null;
                        }


                        if (isSaveFlag)
                        {
                            FCCHREmployeeMonthlyTimeSheetSummary.GetFacadeCreate().Add(hREmployeeMonthlyTimeSheetSummaryEntity, DatabaseOperationType.Add, TransactionRequired.No);
                            MiscUtil.ShowMessage(lblMessage, "Employee Monthly Time Sheet Summary Information has been saved successfully.", false);
                        }
                        else
                        {
                            String filterExpression = SqlExpressionBuilder.PrepareFilterExpression(HREmployeeMonthlyTimeSheetSummaryEntity.FLD_NAME_EmployeeMonthlyTimeSheetID, lstHREmployeeMonthlyTimeSheetSummary[0].EmployeeMonthlyTimeSheetID.ToString(), SQLMatchType.Equal);
                            FCCHREmployeeMonthlyTimeSheetSummary.GetFacadeCreate().Update(hREmployeeMonthlyTimeSheetSummaryEntity, filterExpression, DatabaseOperationType.Update, TransactionRequired.No);
                            MiscUtil.ShowMessage(lblMessage, "Employee Monthly Time Sheet Summary Information has been updated successfully.", false);
                        }

                        
                        BindList();
                        //PrepareInitialView();
                    }
                }
            }
            catch (Exception ex)
            {
                MiscUtil.ShowMessage(lblMessage, "Failed to Employee Monthly Time Sheet Summary Information.", true);
            }

        }

        private void GetSalarySessionStartDateAndEndDate(Int64 salarySessionID)
        {
            MDSalarySessionEntity entity = FCCMDSalarySession.GetFacadeCreate().GetByID(salarySessionID);
            lblStartDate.Text = entity.SessionStartDate.ToString().Trim();
            lblEndDate.Text = entity.SessionEndDate.ToString().Trim();
        }

        private void BuildSalarySession()
        {
            IList<ListViewDataItem> list = lvHREmployeeDetailsForMonthlyTimeSheetSummary.Items;
            if (list != null && list.Count > 0)
            {
                foreach (ListViewDataItem lvdi in list)
                {
                    TextBox txtOnJob = (TextBox)lvdi.FindControl("txtOnJob");
                    TextBox txtHoliday = (TextBox)lvdi.FindControl("txtHoliday");
                    TextBox txtACTUALWORKDAYS = (TextBox)lvdi.FindControl("txtACTUALWORKDAYS");
                    TextBox txtLCASUAL = (TextBox)lvdi.FindControl("txtLCASUAL");
                    TextBox txtLMEDICAL = (TextBox)lvdi.FindControl("txtLMEDICAL");
                    TextBox txtEARNLEAVE = (TextBox)lvdi.FindControl("txtEARNLEAVE");
                    TextBox txtLWP = (TextBox)lvdi.FindControl("txtLWP");
                    TextBox txtREMARKS = (TextBox)lvdi.FindControl("txtREMARKS");
                    TextBox txtNUMBEROFMEALS = (TextBox)lvdi.FindControl("txtNUMBEROFMEALS");
                    TextBox txtPROJECTACTUAL = (TextBox)lvdi.FindControl("txtPROJECTACTUAL");
                    TextBox txtOTHERLEAVE = (TextBox)lvdi.FindControl("txtOTHERLEAVE");
                    Label employeeIDlv = (Label)lvdi.FindControl("employeeIDlv");
                    String remarks = String.Empty;
                    Decimal totalLeaveDays = 0;
                    Decimal casual = 0;
                    Decimal medical = 0;
                    Decimal earn = 0;
                    Decimal lwp = 0;

                    txtLCASUAL.Text = "0";
                    txtLMEDICAL.Text = "0";
                    txtEARNLEAVE.Text = "0";
                    txtLWP.Text = "0";
                    txtREMARKS.Text = String.Empty;
                    txtNUMBEROFMEALS.Text = "0";
                    txtPROJECTACTUAL.Text = "0";
                    txtOTHERLEAVE.Text = "0";

                    IList<HREmployeeDetailsForMonthlyTimeSheetSummary_CustomEntity> entList = FCCHREmployeeDetailsForMonthlyTimeSheetSummary_Custom.GetFacadeCreate().GetIL(Int64.Parse(ddlSalarySessionID.SelectedValue));
                    txtOnJob.Text = entList[0].OnJob.ToString().Trim();
                    txtHoliday.Text = (entList[0].Holiday - entList[0].LeaveDay).ToString().Trim();
                    txtACTUALWORKDAYS.Text = ((Decimal.Parse(txtOnJob.Text) + Decimal.Parse(txtHoliday.Text)) - Decimal.Parse(txtLWP.Text)).ToString().Trim();

                    
                    Int64 employeeID = (Int64.Parse(employeeIDlv.Text));
                    

                    String fe1 = SqlExpressionBuilder.PrepareFilterExpression("HREmployee." + HREmployee_DetailedEntity.FLD_NAME_EmployeeID, employeeID.ToString(), SQLMatchType.Equal);
                    String fe2 = SqlExpressionBuilder.PrepareFilterExpression(MDSalarySessionEntity.FLD_NAME_SalarySessionID, (Int64.Parse(ddlSalarySessionID.SelectedValue)).ToString(), SQLMatchType.Equal);
                    String fe3 = SqlExpressionBuilder.PrepareFilterExpression("HREmployeeLeaveApplication." + HREmployeeLeaveApplicationEntity.FLD_NAME_LeaveApplicationApplicationStatusID, MasterDataConstants.MDLeaveApplicatoinStatus.APPROVED.ToString(), SQLMatchType.Equal);
                    String fe = SqlExpressionBuilder.PrepareFilterExpression(fe1, SQLJoinType.AND, fe2);
                    fe = SqlExpressionBuilder.PrepareFilterExpression(fe, SQLJoinType.AND, fe3);

                    IList<HREmployeeLeaveApplication_DetailedEntity> leaveList = FCCHREmployeeLeaveApplication_Detailed.GetFacadeCreate().GetIL(1000, 1, String.Empty, fe);
                    if (leaveList != null && leaveList.Count > 0)
                    {
                        foreach (HREmployeeLeaveApplication_DetailedEntity entity in leaveList)
                        {
                            if (entity.LeaveCategoryID == MasterDataConstants.MDLeaveCategory.CASUAL)
                            {
                                casual += leaveList[0].TotalLeaveDays;
                            }
                            else if (entity.LeaveCategoryID == MasterDataConstants.MDLeaveCategory.MEDICAL)
                            {
                                medical += leaveList[0].TotalLeaveDays;
                            }
                            else if (entity.LeaveCategoryID == MasterDataConstants.MDLeaveCategory.EARN)
                            {
                                earn += leaveList[0].TotalLeaveDays;
                            }
                            else if (entity.LeaveCategoryID == MasterDataConstants.MDLeaveCategory.LWP)
                            {
                                lwp += leaveList[0].TotalLeaveDays;
                            }
                        }
                    }

                    if (lwp > 0)
                    {
                        remarks += lwp + " LWP " + (lwp * 6) + " Late. ";
                    }

                    totalLeaveDays = casual + medical + earn;

                    if (totalLeaveDays > 0)
                    {
                        remarks += totalLeaveDays.ToString().Trim() + " Leave.";
                    }
                    else
                    {
                        remarks += String.Empty;
                    }
                    txtLCASUAL.Text = casual.ToString();
                    txtLMEDICAL.Text = medical.ToString();
                    txtEARNLEAVE.Text = earn.ToString();
                    txtLWP.Text = lwp.ToString();
                    txtACTUALWORKDAYS.Text = (entList[0].ActualWorkingDay - lwp).ToString().Trim();
                    txtREMARKS.Text = remarks;

                    btnSubmit.Text = "Save";

                    if (chbxRegenerate.Checked == false)
                    {
                        #region CurrentEmployeeMonthlyTimeSheetSummaryInfo

                        String fe4 = SqlExpressionBuilder.PrepareFilterExpression(HREmployeeMonthlyTimeSheetSummaryEntity.FLD_NAME_EmployeeID, employeeID.ToString(), SQLMatchType.Equal);
                        String fe5 = SqlExpressionBuilder.PrepareFilterExpression(HREmployeeMonthlyTimeSheetSummaryEntity.FLD_NAME_SalarySessionID, (Int64.Parse(ddlSalarySessionID.SelectedValue)).ToString(), SQLMatchType.Equal);
                        String fe6 = SqlExpressionBuilder.PrepareFilterExpression(fe4, SQLJoinType.AND, fe5);
                        IList<HREmployeeMonthlyTimeSheetSummaryEntity> hREmployeeMonthlyTimeSheetSummarylist = FCCHREmployeeMonthlyTimeSheetSummary.GetFacadeCreate().GetIL(null, null, String.Empty, fe6, DatabaseOperationType.LoadWithFilterExpression);
                        if (hREmployeeMonthlyTimeSheetSummarylist != null && hREmployeeMonthlyTimeSheetSummarylist.Count > 0)
                        {
                            txtOnJob.Text = hREmployeeMonthlyTimeSheetSummarylist[0].OnJob.ToString().Trim();
                            txtHoliday.Text = hREmployeeMonthlyTimeSheetSummarylist[0].Holiday.ToString().Trim();
                            txtACTUALWORKDAYS.Text = hREmployeeMonthlyTimeSheetSummarylist[0].ACTUALWORKDAYS.ToString().Trim();
                            txtLCASUAL.Text = hREmployeeMonthlyTimeSheetSummarylist[0].LCASUAL.ToString().Trim();
                            txtLMEDICAL.Text = hREmployeeMonthlyTimeSheetSummarylist[0].LMEDICAL.ToString().Trim();
                            txtLWP.Text = hREmployeeMonthlyTimeSheetSummarylist[0].LWP.ToString().Trim();
                            txtEARNLEAVE.Text = hREmployeeMonthlyTimeSheetSummarylist[0].EARNLEAVE.ToString().Trim();
                            txtREMARKS.Text = hREmployeeMonthlyTimeSheetSummarylist[0].REMARKS.ToString().Trim();
                            txtNUMBEROFMEALS.Text = hREmployeeMonthlyTimeSheetSummarylist[0].NUMBEROFMEALS.ToString().Trim();
                            txtPROJECTACTUAL.Text = hREmployeeMonthlyTimeSheetSummarylist[0].PROJECTACTUAL.ToString().Trim();
                            txtOTHERLEAVE.Text = hREmployeeMonthlyTimeSheetSummarylist[0].OTHERLEAVE.ToString().Trim();

                            btnSubmit.Text = "Update";
                        }

                        #endregion
                    }
                }
            }
        }

        private void BindList()
        {
            BindHREmployeeMonthlyTimeSheetSummaryList();
        }

        private void BindHREmployeeMonthlyTimeSheetSummaryList()
        {
            lvHREmployeeDetailsForMonthlyTimeSheetSummary.DataBind();
        }

        private void GetReport()
        {
            #region Report

            hypReport.NavigateUrl = UrlHelper.BuildSecureUrl("~/Reports/ReportViewer.aspx", string.Empty, "do", "HREmployeeMonthlyTimeSheetSummaryReport", UrlConstants.OVERVIEW_HR_SALARY_SESSION_ID, ddlSalarySessionID.SelectedValue.ToString()).ToString();
            hypReport.Target = "_blank";
            #endregion
        }

        private void SaveHREmployeeMonthlyTimeSheetSummaryEntity()
        {
            if (IsValid)
            {
                try
                {
                    HREmployeeMonthlyTimeSheetSummaryEntity hREmployeeMonthlyTimeSheetSummaryEntity = new HREmployeeMonthlyTimeSheetSummaryEntity();//BuildHREmployeeMonthlyTimeSheetSummaryEntity();

                    Int64 result = -1;

                    if (hREmployeeMonthlyTimeSheetSummaryEntity.IsNew)
                    {
                        result = FCCHREmployeeMonthlyTimeSheetSummary.GetFacadeCreate().Add(hREmployeeMonthlyTimeSheetSummaryEntity, DatabaseOperationType.Add, TransactionRequired.No);
                    }
                    else
                    {
                        String filterExpression = SqlExpressionBuilder.PrepareFilterExpression(HREmployeeMonthlyTimeSheetSummaryEntity.FLD_NAME_EmployeeMonthlyTimeSheetID, hREmployeeMonthlyTimeSheetSummaryEntity.EmployeeMonthlyTimeSheetID.ToString(), SQLMatchType.Equal);
                        result = FCCHREmployeeMonthlyTimeSheetSummary.GetFacadeCreate().Update(hREmployeeMonthlyTimeSheetSummaryEntity, filterExpression, DatabaseOperationType.Update, TransactionRequired.No);
                    }

                    if (result > 0)
                    {
                        _EmployeeMonthlyTimeSheetID = 0;
                        _HREmployeeMonthlyTimeSheetSummaryEntity = new HREmployeeMonthlyTimeSheetSummaryEntity();
                        PrepareInitialView();
                        BindHREmployeeMonthlyTimeSheetSummaryList();

                        if (hREmployeeMonthlyTimeSheetSummaryEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Employee Monthly Time Sheet Summary Information has been added successfully.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Employee Monthly Time Sheet Summary Information has been updated successfully.", false);
                        }
                    }
                    else
                    {
                        if (hREmployeeMonthlyTimeSheetSummaryEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to add Employee Monthly Time Sheet Summary Information.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to update Employee Monthly Time Sheet Summary Information.", false);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MiscUtil.ShowMessage(lblMessage, ex.Message, true);
                }
            }
        }

        private void DeleteAllCurrentData()
        {
            try
            {
                Int64 result = -1;

                String fe = SqlExpressionBuilder.PrepareFilterExpression(HREmployeeMonthlyTimeSheetSummaryEntity.FLD_NAME_SalarySessionID, (Int64.Parse(ddlSalarySessionID.SelectedValue)).ToString(), SQLMatchType.Equal);

                HREmployeeMonthlyTimeSheetSummaryEntity HhEmployeeMonthlyTimeSheetSummaryEntity = new HREmployeeMonthlyTimeSheetSummaryEntity();


                result = FCCHREmployeeMonthlyTimeSheetSummary.GetFacadeCreate().Delete(HhEmployeeMonthlyTimeSheetSummaryEntity, fe, DatabaseOperationType.Delete, TransactionRequired.No);

                if (result == 0)
                {
                    _EmployeeMonthlyTimeSheetID = 0;
                    _HREmployeeMonthlyTimeSheetSummaryEntity = new HREmployeeMonthlyTimeSheetSummaryEntity();
                    PrepareInitialView();

                    MiscUtil.ShowMessage(lblMessage, "Time Sheet has been successfully deleted.", true);
                }
                else
                {
                    MiscUtil.ShowMessage(lblMessage, "Failed to delete Time Sheet.", true);
                }
            }
            catch (Exception ex)
            {
                MiscUtil.ShowMessage(lblMessage, ex.Message, true);
            }
        }

        private void GenerateAll()
        {
            try
            {
                StringBuilder xmlStr = new StringBuilder();
                Int64 employmentStatusID = 1;
                String fe = SqlExpressionBuilder.PrepareFilterExpression("(HREmployeeSalaryInfo.SalaryAmount is not null and HREmployeeSalaryInfo.FiscalYearID = (Select FiscalYearID from ACFiscalYear where IsClosed = 0)) and HREmployee." + HREmployee_DetailedEntity.FLD_NAME_EmploymentStatusID, employmentStatusID.ToString(), SQLMatchType.Equal);

                if (ddlDepartmentID.SelectedValue == "1")
                {
                    String fe2 = "( HREmployee.DepartmentID is null or HREmployee.DepartmentID <> 20)";
                    fe = SqlExpressionBuilder.PrepareFilterExpression(fe, SQLJoinType.AND, fe2);
                }
                else
                {
                    String fe3 = "(HREmployee.DepartmentID = 20)";
                    fe = SqlExpressionBuilder.PrepareFilterExpression(fe, SQLJoinType.AND, fe3);
                }

                IList<HREmployee_DetailedEntity> list = FCCHREmployeeMonthlyTimeSheet_Detailed.GetFacadeCreate().GetIL(1000, 1, String.Empty, fe);
                xmlStr.Append("<m>");
                if (list != null && list.Count > 0)
                {

                    foreach (HREmployee_DetailedEntity hREmployee_DetailedEntity in list)
                    {
                        HREmployeeMonthlyTimeSheetSummaryEntity hREmployeeMonthlyTimeSheetSummaryEntity = new HREmployeeMonthlyTimeSheetSummaryEntity();

                        hREmployeeMonthlyTimeSheetSummaryEntity.LCASUAL = 0;
                        hREmployeeMonthlyTimeSheetSummaryEntity.LMEDICAL = 0;
                        hREmployeeMonthlyTimeSheetSummaryEntity.EARNLEAVE = 0;
                        hREmployeeMonthlyTimeSheetSummaryEntity.LWP = 0;
                        hREmployeeMonthlyTimeSheetSummaryEntity.REMARKS = String.Empty;
                        hREmployeeMonthlyTimeSheetSummaryEntity.NUMBEROFMEALS = 0;
                        hREmployeeMonthlyTimeSheetSummaryEntity.PROJECTACTUAL = 0;
                        hREmployeeMonthlyTimeSheetSummaryEntity.OTHERLEAVE = 0;
                        String remarks = String.Empty;

                        IList<HREmployeeDetailsForMonthlyTimeSheetSummary_CustomEntity> entList = FCCHREmployeeDetailsForMonthlyTimeSheetSummary_Custom.GetFacadeCreate().GetIL(Int64.Parse(ddlSalarySessionID.SelectedValue));
                        hREmployeeMonthlyTimeSheetSummaryEntity.OnJob = entList[0].OnJob;
                        hREmployeeMonthlyTimeSheetSummaryEntity.Holiday = (entList[0].Holiday - entList[0].LeaveDay);
                        hREmployeeMonthlyTimeSheetSummaryEntity.ACTUALWORKDAYS = ((hREmployeeMonthlyTimeSheetSummaryEntity.OnJob + hREmployeeMonthlyTimeSheetSummaryEntity.Holiday) - hREmployeeMonthlyTimeSheetSummaryEntity.LWP);

                        Int64 employeeID = hREmployee_DetailedEntity.EmployeeID;
                        Decimal totalLeaveDays = 0;
                        Decimal casual = 0;
                        Decimal medical = 0;
                        Decimal earn = 0;
                        Decimal lwp = 0;

                        String fe1 = SqlExpressionBuilder.PrepareFilterExpression(" HREmployee." + HREmployee_DetailedEntity.FLD_NAME_EmployeeID, employeeID.ToString(), SQLMatchType.Equal);
                        String fe2 = SqlExpressionBuilder.PrepareFilterExpression(MDSalarySessionEntity.FLD_NAME_SalarySessionID, (Int64.Parse(ddlSalarySessionID.SelectedValue)).ToString(), SQLMatchType.Equal);
                        String fe3 = SqlExpressionBuilder.PrepareFilterExpression("HREmployeeLeaveApplication." + HREmployeeLeaveApplicationEntity.FLD_NAME_LeaveApplicationApplicationStatusID, MasterDataConstants.MDLeaveApplicatoinStatus.APPROVED.ToString(), SQLMatchType.Equal);
                        String f = SqlExpressionBuilder.PrepareFilterExpression(fe1, SQLJoinType.AND, fe2);
                        f = SqlExpressionBuilder.PrepareFilterExpression(f, SQLJoinType.AND, fe3);

                        IList<HREmployeeLeaveApplication_DetailedEntity> leaveList = FCCHREmployeeLeaveApplication_Detailed.GetFacadeCreate().GetIL(1000, 1, String.Empty, f);
                        if (leaveList != null && leaveList.Count > 0)
                        {
                            foreach (HREmployeeLeaveApplication_DetailedEntity entity in leaveList)
                            {
                                if (entity.LeaveCategoryID == MasterDataConstants.MDLeaveCategory.CASUAL)
                                {
                                    casual += leaveList[0].TotalLeaveDays;
                                }
                                else if (entity.LeaveCategoryID == MasterDataConstants.MDLeaveCategory.MEDICAL)
                                {
                                    medical += leaveList[0].TotalLeaveDays;
                                }
                                else if (entity.LeaveCategoryID == MasterDataConstants.MDLeaveCategory.EARN)
                                {
                                    earn += leaveList[0].TotalLeaveDays;
                                }
                                else if (entity.LeaveCategoryID == MasterDataConstants.MDLeaveCategory.LWP)
                                {
                                    lwp += leaveList[0].TotalLeaveDays;
                                }
                            }
                        }
                        if (lwp > 0)
                        {
                            remarks += lwp + " LWP " + (lwp * 6) + " Late. ";
                        }

                        totalLeaveDays = casual + medical + earn;

                        if (totalLeaveDays > 0)
                        {
                            remarks += totalLeaveDays.ToString().Trim() + " Leave.";
                        }
                        else
                        {
                            remarks += String.Empty;
                        }

                        hREmployeeMonthlyTimeSheetSummaryEntity.LCASUAL = casual;
                        hREmployeeMonthlyTimeSheetSummaryEntity.LMEDICAL = medical;
                        hREmployeeMonthlyTimeSheetSummaryEntity.EARNLEAVE = earn;
                        hREmployeeMonthlyTimeSheetSummaryEntity.LWP = lwp;
                        hREmployeeMonthlyTimeSheetSummaryEntity.ACTUALWORKDAYS = (entList[0].ActualWorkingDay - lwp);
                        hREmployeeMonthlyTimeSheetSummaryEntity.REMARKS = remarks;
                        hREmployeeMonthlyTimeSheetSummaryEntity.SalarySessionID = Int64.Parse(ddlSalarySessionID.SelectedValue);

                        #region Already Has this employee
                        Boolean isTrue = true;

                        String fe4 = SqlExpressionBuilder.PrepareFilterExpression(HREmployeeMonthlyTimeSheetSummaryEntity.FLD_NAME_EmployeeID, employeeID.ToString(), SQLMatchType.Equal);
                        String fe5 = SqlExpressionBuilder.PrepareFilterExpression(HREmployeeMonthlyTimeSheetSummaryEntity.FLD_NAME_SalarySessionID, (Int64.Parse(ddlSalarySessionID.SelectedValue)).ToString(), SQLMatchType.Equal);
                        String fe6 = SqlExpressionBuilder.PrepareFilterExpression(fe4, SQLJoinType.AND, fe5);
                        IList<HREmployeeMonthlyTimeSheetSummaryEntity> hREmployeeMonthlyTimeSheetSummarylist = FCCHREmployeeMonthlyTimeSheetSummary.GetFacadeCreate().GetIL(null, null, String.Empty, fe6, DatabaseOperationType.LoadWithFilterExpression);

                        if (hREmployeeMonthlyTimeSheetSummarylist != null && hREmployeeMonthlyTimeSheetSummarylist.Count > 0)
                        {
                            isTrue = false;
                        }

                        #endregion

                        if (isTrue)
                        {
                            String subXmlStr = null;
                            subXmlStr = subXmlStr + "<i><a>" + hREmployee_DetailedEntity.EmployeeID + "</a><b>" + hREmployee_DetailedEntity.DesignationID + "</b><c>" + hREmployee_DetailedEntity.EmployeeJobTypeID + "</c><d>" + hREmployee_DetailedEntity.SalaryLevel + "</d><e>" + hREmployeeMonthlyTimeSheetSummaryEntity.SalarySessionID + "</e><f>" + hREmployeeMonthlyTimeSheetSummaryEntity.OnJob + "</f><g>" + hREmployeeMonthlyTimeSheetSummaryEntity.Holiday + "</g><h>" + hREmployeeMonthlyTimeSheetSummaryEntity.LCASUAL + "</h><i1>" + hREmployeeMonthlyTimeSheetSummaryEntity.LMEDICAL + "</i1><j>" + hREmployeeMonthlyTimeSheetSummaryEntity.EARNLEAVE + "</j><k>" + hREmployeeMonthlyTimeSheetSummaryEntity.LWP + "</k><l>" + hREmployeeMonthlyTimeSheetSummaryEntity.ACTUALWORKDAYS + "</l><m>" + hREmployeeMonthlyTimeSheetSummaryEntity.REMARKS + "</m><n>" + hREmployeeMonthlyTimeSheetSummaryEntity.NUMBEROFMEALS + "</n><o>" + hREmployeeMonthlyTimeSheetSummaryEntity.PROJECTACTUAL + "</o><p>" + hREmployeeMonthlyTimeSheetSummaryEntity.OTHERLEAVE + "</p><q>"+hREmployee_DetailedEntity.DepartmentID+"</q></i>";
                            xmlStr.Append(subXmlStr.ToString());
                        }
                    }
                }
                xmlStr.Append("</m>");

                FCCBulkInsertXML.GetFacadeCreate().GetIL(xmlStr.ToString(), CommonConstants.HREmployeeMonthlyTimeSheetSummary);

                MiscUtil.ShowMessage(lblMessage, "Time Sheet Has been Generated Successfully.", false);
            }
            catch (Exception ex)
            {
                MiscUtil.ShowMessage(lblMessage, "An Error Occoured.", true);
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
                BuildSalarySession();
                GetSalarySessionStartDateAndEndDate(Int64.Parse(ddlSalarySessionID.SelectedValue));
                GetReport();
            }
        }

        #endregion

        #region List View Event

        protected void lvHREmployeeDetailsForMonthlyTimeSheetSummary_ItemDataBound(object sender, ListViewItemEventArgs e)
        {
            if (e.Item.ItemType == ListViewItemType.DataItem)
            {
                ListViewDataItem dataItem = (ListViewDataItem)e.Item;

                HREmployee_DetailedEntity ent = new HREmployee_DetailedEntity();

                TextBox txtEmployeeName = (TextBox)e.Item.FindControl("txtEmployeeName");
                TextBox txtDesignation = (TextBox)e.Item.FindControl("txtDesignation");
                TextBox txtEmployeeJobTypeID = (TextBox)e.Item.FindControl("txtEmployeeJobTypeID");
                TextBox txtSalaryLevel = (TextBox)e.Item.FindControl("txtSalaryLevel");
                TextBox txtOnJob = (TextBox)e.Item.FindControl("txtOnJob");
                TextBox txtHoliday = (TextBox)e.Item.FindControl("txtHoliday");
                TextBox txtLCASUAL = (TextBox)e.Item.FindControl("txtLCASUAL");
                TextBox txtLMEDICAL = (TextBox)e.Item.FindControl("txtLMEDICAL");
                TextBox txtEARNLEAVE = (TextBox)e.Item.FindControl("txtEARNLEAVE");
                TextBox txtLWP = (TextBox)e.Item.FindControl("txtLWP");
                TextBox txtACTUALWORKDAYS = (TextBox)e.Item.FindControl("txtACTUALWORKDAYS");
                TextBox txtREMARKS = (TextBox)e.Item.FindControl("txtREMARKS");
                TextBox txtNUMBEROFMEALS = (TextBox)e.Item.FindControl("txtNUMBEROFMEALS");
                TextBox txtPROJECTACTUAL = (TextBox)e.Item.FindControl("txtPROJECTACTUAL");
                TextBox txtOTHERLEAVE = (TextBox)e.Item.FindControl("txtOTHERLEAVE");
                Label employeeIDlv = (Label)e.Item.FindControl("employeeIDlv");
                String remarks = String.Empty;

                txtLCASUAL.Text = "0";
                txtLMEDICAL.Text = "0";
                txtEARNLEAVE.Text = "0";
                txtLWP.Text = "0";
                txtREMARKS.Text = String.Empty;
                txtNUMBEROFMEALS.Text = "0";
                txtPROJECTACTUAL.Text = "0";
                txtOTHERLEAVE.Text = "0";



                IList<HREmployeeDetailsForMonthlyTimeSheetSummary_CustomEntity> entList = FCCHREmployeeDetailsForMonthlyTimeSheetSummary_Custom.GetFacadeCreate().GetIL(Int64.Parse(ddlSalarySessionID.SelectedValue));
                txtOnJob.Text = entList[0].OnJob.ToString().Trim();
                txtHoliday.Text = (entList[0].Holiday - entList[0].LeaveDay).ToString().Trim();
                txtACTUALWORKDAYS.Text = ((Decimal.Parse(txtOnJob.Text) + Decimal.Parse(txtHoliday.Text)) - Decimal.Parse(txtLWP.Text)).ToString().Trim();

                //Int64 leaveApplicationApplicationStatusID = 2;
                Int64 employeeID = (Int64.Parse(employeeIDlv.Text));
                Decimal totalLeaveDays = 0;
                Decimal casual = 0;
                Decimal medical = 0;
                Decimal earn = 0;
                Decimal lwp = 0;


                String fe1 = SqlExpressionBuilder.PrepareFilterExpression("HREmployee." + HREmployee_DetailedEntity.FLD_NAME_EmployeeID, employeeID.ToString(), SQLMatchType.Equal);
                String fe2 = SqlExpressionBuilder.PrepareFilterExpression(MDSalarySessionEntity.FLD_NAME_SalarySessionID, (Int64.Parse(ddlSalarySessionID.SelectedValue)).ToString(), SQLMatchType.Equal);
                String fe3 = SqlExpressionBuilder.PrepareFilterExpression("HREmployeeLeaveApplication." + HREmployeeLeaveApplicationEntity.FLD_NAME_LeaveApplicationApplicationStatusID, MasterDataConstants.MDLeaveApplicatoinStatus.APPROVED.ToString(), SQLMatchType.Equal);
                String fe = SqlExpressionBuilder.PrepareFilterExpression(fe1, SQLJoinType.AND, fe2);
                fe = SqlExpressionBuilder.PrepareFilterExpression(fe, SQLJoinType.AND, fe3);

                IList<HREmployeeLeaveApplication_DetailedEntity> leaveList = FCCHREmployeeLeaveApplication_Detailed.GetFacadeCreate().GetIL(1000, 1, String.Empty, fe);
                if (leaveList != null && leaveList.Count > 0)
                {
                    foreach (HREmployeeLeaveApplication_DetailedEntity entity in leaveList)
                    {
                        if (entity.LeaveCategoryID == MasterDataConstants.MDLeaveCategory.CASUAL)
                        {
                            casual += leaveList[0].TotalLeaveDays;
                        }
                        else if (entity.LeaveCategoryID == MasterDataConstants.MDLeaveCategory.MEDICAL)
                        {
                            medical += leaveList[0].TotalLeaveDays;
                        }
                        else if (entity.LeaveCategoryID == MasterDataConstants.MDLeaveCategory.EARN)
                        {
                            earn += leaveList[0].TotalLeaveDays; 
                        }
                        else if (entity.LeaveCategoryID == MasterDataConstants.MDLeaveCategory.LWP)
                        {
                            lwp += leaveList[0].TotalLeaveDays;
                        }
                    }
                }
                if (lwp > 0)
                {
                    remarks += lwp + " LWP " + (lwp * 6) + " Late. ";
                }

                totalLeaveDays = casual + medical + earn;

                if (totalLeaveDays > 0)
                {
                    remarks += Decimal.Truncate(totalLeaveDays).ToString().Trim() + " Leave.";
                }
                else
                {
                    remarks += String.Empty;
                }
                txtLCASUAL.Text = casual.ToString();
                txtLMEDICAL.Text = medical.ToString();
                txtEARNLEAVE.Text = earn.ToString();
                txtLWP.Text = lwp.ToString();
                txtACTUALWORKDAYS.Text = (entList[0].ActualWorkingDay - lwp).ToString().Trim();
                txtREMARKS.Text = remarks;

                btnSubmit.Text = "Save";

                #region CurrentEmployeeMonthlyTimeSheetSummaryInfo
                String fe4 = SqlExpressionBuilder.PrepareFilterExpression(HREmployeeMonthlyTimeSheetSummaryEntity.FLD_NAME_EmployeeID, employeeID.ToString(), SQLMatchType.Equal);
                String fe5 = SqlExpressionBuilder.PrepareFilterExpression(HREmployeeMonthlyTimeSheetSummaryEntity.FLD_NAME_SalarySessionID, (Int64.Parse(ddlSalarySessionID.SelectedValue)).ToString(), SQLMatchType.Equal);
                String fe6 = SqlExpressionBuilder.PrepareFilterExpression(fe4, SQLJoinType.AND, fe5);
                IList<HREmployeeMonthlyTimeSheetSummaryEntity> hREmployeeMonthlyTimeSheetSummarylist = FCCHREmployeeMonthlyTimeSheetSummary.GetFacadeCreate().GetIL(null, null, String.Empty, fe6, DatabaseOperationType.LoadWithFilterExpression);
                if (hREmployeeMonthlyTimeSheetSummarylist != null && hREmployeeMonthlyTimeSheetSummarylist.Count > 0)
                {
                    txtOnJob.Text = hREmployeeMonthlyTimeSheetSummarylist[0].OnJob.ToString().Trim();
                    txtHoliday.Text = hREmployeeMonthlyTimeSheetSummarylist[0].Holiday.ToString().Trim();
                    txtACTUALWORKDAYS.Text = hREmployeeMonthlyTimeSheetSummarylist[0].ACTUALWORKDAYS.ToString().Trim();
                    txtLCASUAL.Text = hREmployeeMonthlyTimeSheetSummarylist[0].LCASUAL.ToString().Trim();
                    txtLMEDICAL.Text = hREmployeeMonthlyTimeSheetSummarylist[0].LMEDICAL.ToString().Trim();
                    txtLWP.Text = hREmployeeMonthlyTimeSheetSummarylist[0].LWP.ToString().Trim();
                    txtEARNLEAVE.Text = hREmployeeMonthlyTimeSheetSummarylist[0].EARNLEAVE.ToString().Trim();
                    txtREMARKS.Text = hREmployeeMonthlyTimeSheetSummarylist[0].REMARKS.ToString().Trim();
                    txtNUMBEROFMEALS.Text = hREmployeeMonthlyTimeSheetSummarylist[0].NUMBEROFMEALS.ToString().Trim();
                    txtPROJECTACTUAL.Text = hREmployeeMonthlyTimeSheetSummarylist[0].PROJECTACTUAL.ToString().Trim();
                    txtOTHERLEAVE.Text = hREmployeeMonthlyTimeSheetSummarylist[0].OTHERLEAVE.ToString().Trim();

                    btnSubmit.Text = "Update";
                }

                #endregion
               

            }

        }

        protected void lvHREmployeeDetailsForMonthlyTimeSheetSummary_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            
        }

        #endregion List View Event

        #region ObjectDataSource Event

        protected void odsHREmployeeDetailsForMonthlyTimeSheetSummary_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {
            Int64 employmentStatusID = 1;
            String fe = SqlExpressionBuilder.PrepareFilterExpression("(HREmployeeSalaryInfo.SalaryAmount is not null and HREmployeeSalaryInfo.FiscalYearID = (Select FiscalYearID from ACFiscalYear where IsClosed = 0)) and HREmployee." + HREmployee_DetailedEntity.FLD_NAME_EmploymentStatusID, employmentStatusID.ToString(), SQLMatchType.Equal);
            Boolean isExecutingSelectCount = false;
            if (ddlDepartmentID.SelectedValue == "1")
            {
                String fe2 = "(HREmployee.DepartmentID is null or HREmployee.DepartmentID <> " + MasterDataConstants.MDDepartment.SECURITY_DEPARTMENTID + ")";
                fe = SqlExpressionBuilder.PrepareFilterExpression(fe, SQLJoinType.AND, fe2);
            }
            else
            {
                String fe3 = "(HREmployee.DepartmentID = " + MasterDataConstants.MDDepartment.SECURITY_DEPARTMENTID + ")";
                fe = SqlExpressionBuilder.PrepareFilterExpression(fe, SQLJoinType.AND, fe3);
            }

            if (chbxFilter.Checked)
            {
                String fe4 = SqlExpressionBuilder.PrepareFilterExpression("HREmployee."+HREmployee_DetailedEntity.FLD_NAME_EmployeeCode, txtSearchText.Text.ToString(), SQLMatchType.LikeWithBothMath);
                fe = SqlExpressionBuilder.PrepareFilterExpression(fe, SQLJoinType.AND, fe4);
                isExecutingSelectCount = false;
            }
            if (e.ExecutingSelectCount == isExecutingSelectCount)
            {
                UpdateHREmployeeDetailsForMonthlyTimeSheetSummary();
            }

            e.InputParameters["filterExpression"] = fe;
        }

        #endregion

        #region Button Event

        protected void btnSave_Click(object sender, EventArgs e)
        {
            //SaveHREmployeeMonthlyTimeSheetSummaryEntity();
            UpdateHREmployeeDetailsForMonthlyTimeSheetSummary();
        }

        protected void btnAddNew_Click(object sender, EventArgs e)
        {
            _EmployeeMonthlyTimeSheetID = 0;
            _HREmployeeMonthlyTimeSheetSummaryEntity = new HREmployeeMonthlyTimeSheetSummaryEntity();
            PrepareInitialView();
        }

        protected void btnClear_Click(object sender, EventArgs e)
        {
            PrepareInitialView();
            //PrepareEditView();
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            DeleteAllCurrentData();
        }

        protected void btnGenerate_Click(object sender, EventArgs e)
        {
            GenerateAll();
        }

        #endregion

        #region Dropdwon Event

        protected void ddlSalarySessionID_SelectedIndexChanged(object sender, EventArgs e)
        {
            BuildSalarySession();
            GetSalarySessionStartDateAndEndDate(Int64.Parse(ddlSalarySessionID.SelectedValue));
            GetReport();
            
        }

        protected void ddlDepartmentID_SelectedIndexChanged(object sender, EventArgs e)
        {
            BindList();
        }

        protected void chbxRegenerate_CheckedChanged(object sender, EventArgs e)
        {
            BindList();
        }


        #endregion

        #region Check Filter Event
        
        protected void chbxFilter_CheckedChanged(object sender, EventArgs e)
        {
            BindList();
        }

        #endregion

        #endregion Event
    }
}
