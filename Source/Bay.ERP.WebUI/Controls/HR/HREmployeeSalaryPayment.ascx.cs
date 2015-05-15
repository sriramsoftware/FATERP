// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 19-Jan-2014, 04:39:37




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
    public partial class HREmployeeSalaryPaymentControl : BaseControl
    {       
        #region Properties

        public Int64 _EmployeeSalaryPaymentID
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

        public HREmployeeSalaryPaymentEntity _HREmployeeSalaryPaymentEntity
        {
            get
            {
                HREmployeeSalaryPaymentEntity entity = new HREmployeeSalaryPaymentEntity();

                if (ViewState["CurrentEntity"] != null)
                {
                    entity = (HREmployeeSalaryPaymentEntity)ViewState["CurrentEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["CurrentEntity"] = value;
            }
        }

        private HREmployeeSalaryPaymentEntity CurrentHREmployeeSalaryPaymentEntity
        {
            get
            {
                if (_EmployeeSalaryPaymentID > 0)
                {
                    if (_HREmployeeSalaryPaymentEntity.EmployeeSalaryPaymentID != _EmployeeSalaryPaymentID)
                    {
                        _HREmployeeSalaryPaymentEntity = FCCHREmployeeSalaryPayment.GetFacadeCreate().GetByID(_EmployeeSalaryPaymentID);
                    }
                }

                return _HREmployeeSalaryPaymentEntity;
            }
            set
            {
                _HREmployeeSalaryPaymentEntity = value;
            }
        }

        public Int64 OverviewEmployeeSalarySessionID
        {
            get
            {
                Int64 hrEmployeeSalarySessionID = 0;

                if (!StringHelper.IsBlank(Helper.Url.SecureUrl[UrlConstants.OVERVIEW_HR_SALARY_SESSION_ID]))
                {
                    Int64.TryParse(Helper.Url.SecureUrl[UrlConstants.OVERVIEW_HR_SALARY_SESSION_ID], out hrEmployeeSalarySessionID);
                }

                return hrEmployeeSalarySessionID;
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
            chbxAdvanceFilter.Checked = true;
            chbxFineFilter.Checked = true;
            chbxMealFilter.Checked = true;
            chbxAdjustmentFilter.Checked = true;
            chbxAllowanceFilter.Checked = true;
            chbxTBRFilter.Checked = true;
            chbxTAXFilter.Checked = true;

            txtBonusPercent.Text = "0.5";
        }

        private void PrepareEditView()
        {
            HREmployeeSalaryPaymentEntity hREmployeeSalaryPaymentEntity = CurrentHREmployeeSalaryPaymentEntity;


            if (!hREmployeeSalaryPaymentEntity.IsNew)
            {
            }
        }

        private void BindList()
        {
            BindHREmployeeSalaryPaymentList();
        }

        private void BindHREmployeeSalaryPaymentList()
        {
            lvHREmployeeSalaryPayment.DataBind();
        }

        private HREmployee_DetailedEntity GetHREmployeeInfo(Int64 employeeID)
        {
            IList<HREmployee_DetailedEntity> list = FCCHREmployee_Detailed.GetFacadeCreate().GetIL(1000, 1, String.Empty, String.Empty);

            HREmployee_DetailedEntity ent = list.Single(x => x.EmployeeID == employeeID);


            return ent;
        }

        private HREmployeeSalaryPaymentEntity BuildHREmployeeSalaryPaymentEntity()
        {
            HREmployeeSalaryPaymentEntity hREmployeeSalaryPaymentEntity = CurrentHREmployeeSalaryPaymentEntity;

           

            return hREmployeeSalaryPaymentEntity;
        }

        private void UpdateHREmployeeSalaryPayment()
        {
            try
            {
                IList<ListViewDataItem> list = lvHREmployeeSalaryPayment.Items;

                if (list != null && list.Count > 0)
                {
                    //Int32 tempDataItemIndex = 0;

                    foreach (ListViewDataItem lvdi in list)
                    {

                        Label employeeIDlv = (Label)lvdi.FindControl("employeeIDlv");
                        Label departmentIDlv = (Label)lvdi.FindControl("departmentIDlv");
                        Label projectIDlv = (Label)lvdi.FindControl("projectIDlv");
                        Label employeeJobTypeIDlv = (Label)lvdi.FindControl("employeeJobTypeIDlv");
                        Label designationIDlv = (Label)lvdi.FindControl("designationIDlv");
                        Label employeeCodeLv = (Label)lvdi.FindControl("employeeCodeLv");
                        Label lblSalaryLevel = (Label)lvdi.FindControl("lblSalaryLevel");
                        TextBox txtConsolidateSalaryAmount = (TextBox)lvdi.FindControl("txtConsolidateSalaryAmount");
                        TextBox txtWorkdays = (TextBox)lvdi.FindControl("txtWorkdays");
                        TextBox txtAdvance = (TextBox)lvdi.FindControl("txtAdvance");
                        TextBox txtFine = (TextBox)lvdi.FindControl("txtFine");
                        TextBox txtMeals = (TextBox)lvdi.FindControl("txtMeals");
                        TextBox txtAIT = (TextBox)lvdi.FindControl("txtAIT");
                        TextBox txtAdjustment = (TextBox)lvdi.FindControl("txtAdjustment");
                        TextBox txtNetPayable = (TextBox)lvdi.FindControl("txtNetPayable");
                        TextBox txtNote = (TextBox)lvdi.FindControl("txtNote");
                        TextBox txtCash = (TextBox)lvdi.FindControl("txtCash");
                        TextBox txtBankAmount = (TextBox)lvdi.FindControl("txtBankAmount");
                        TextBox txtSalaryPayable = (TextBox)lvdi.FindControl("txtSalaryPayable");
                        TextBox txtAllowance = (TextBox)lvdi.FindControl("txtAllowance");
                        TextBox txtProjectActual = (TextBox)lvdi.FindControl("txtProjectActual");
                        TextBox txtBonus = (TextBox)lvdi.FindControl("txtBonus");
                        TextBox txtPhoneCeiling = (TextBox)lvdi.FindControl("txtPhoneCeiling");
                        TextBox txtPhoneActualBill = (TextBox)lvdi.FindControl("txtPhoneActualBill");
                        TextBox txtPhoneBillAdjustment = (TextBox)lvdi.FindControl("txtPhoneBillAdjustment");
                        TextBox txtProvidentFundDeductedAmount = (TextBox)lvdi.FindControl("txtProvidentFundDeductedAmount");
                        TextBox txtPBR = (TextBox)lvdi.FindControl("txtPBR");
                        TextBox txtEBR = (TextBox)lvdi.FindControl("txtEBR");
                        TextBox txtPhoneBill = (TextBox)lvdi.FindControl("txtPhoneBill");
                        DropDownList ddlEmployeeSalaryPaymentStatusID = (DropDownList)lvdi.FindControl("ddlEmployeeSalaryPaymentStatusID");
                        TextBox txtREMARKS = (TextBox)lvdi.FindControl("txtREMARKS");
                        TextBox txtTBR = (TextBox)lvdi.FindControl("txtTBR");
                        TextBox txtTAX = (TextBox)lvdi.FindControl("txtTAX");
                        
                        

                        Int64 _employeeID = (Int64.Parse(employeeIDlv.Text));
                        
                        String _employeeCode = employeeCodeLv.Text.ToString().Trim();

                        MDSalarySessionEntity salarySessionEntity = FCCMDSalarySession.GetFacadeCreate().GetByID(OverviewEmployeeSalarySessionID);
                        

                        Boolean isSaveFlag = true;

                        String fe1 = SqlExpressionBuilder.PrepareFilterExpression(HREmployeeSalaryPaymentEntity.FLD_NAME_EmployeeID, _employeeID.ToString(), SQLMatchType.Equal);
                        String fe2 = SqlExpressionBuilder.PrepareFilterExpression(HREmployeeSalaryPaymentEntity.FLD_NAME_SalarySessionID, OverviewEmployeeSalarySessionID.ToString(), SQLMatchType.Equal);
                        String fe = SqlExpressionBuilder.PrepareFilterExpression(fe1, SQLJoinType.AND, fe2);

                        IList<HREmployeeSalaryPaymentEntity> lstHREmployeeSalaryPayment = FCCHREmployeeSalaryPayment.GetFacadeCreate().GetIL(null, null, String.Empty, fe, DatabaseOperationType.LoadWithFilterExpression);

                        if (lstHREmployeeSalaryPayment != null && lstHREmployeeSalaryPayment.Count > 0)
                        {
                            isSaveFlag = false;
                        }


                        //String fe = SqlExpressionBuilder.PrepareFilterExpression(HREmployeeMonthlyTimeSheetSummaryEntity.em)
                        HREmployee_DetailedEntity employeeEntity = GetHREmployeeInfo(_employeeID);

                        HREmployeeSalaryPaymentEntity hREmployeeSalaryPaymentEntity = new HREmployeeSalaryPaymentEntity();

                        hREmployeeSalaryPaymentEntity.EmployeeID = _employeeID;
                        if (departmentIDlv.Text.IsNotNullOrEmpty())
                        {
                            hREmployeeSalaryPaymentEntity.DepartmentID = (Int64.Parse(departmentIDlv.Text));
                        }
                        else
                        {
                            hREmployeeSalaryPaymentEntity.DepartmentID = null;
                        }

                        if (projectIDlv.Text.IsNotNullOrEmpty())
                        {
                            hREmployeeSalaryPaymentEntity.ProjectID = (Int64.Parse(projectIDlv.Text));
                        }
                        else
                        {
                            hREmployeeSalaryPaymentEntity.ProjectID = null;
                        }

                        if (lblSalaryLevel.Text.IsNotNullOrEmpty())
                        {
                            hREmployeeSalaryPaymentEntity.SalaryLevel = (Int64.Parse(lblSalaryLevel.Text));
                        }
                        else
                        {
                            hREmployeeSalaryPaymentEntity.SalaryLevel = null;
                        }

                        if (txtREMARKS.Text.IsNotNullOrEmpty())
                        {
                            hREmployeeSalaryPaymentEntity.Field2 = txtREMARKS.Text.ToString();
                        }
                        else
                        {
                            hREmployeeSalaryPaymentEntity.Field2 = null;
                        }

                        hREmployeeSalaryPaymentEntity.EmployeeJobTypeID = (Int64.Parse(employeeJobTypeIDlv.Text)); ;
                        hREmployeeSalaryPaymentEntity.EmployeeCode = _employeeCode;
                        hREmployeeSalaryPaymentEntity.SalarySessionID = salarySessionEntity.SalarySessionID;
                        hREmployeeSalaryPaymentEntity.SalarySessionStartDate = salarySessionEntity.SessionEndDate;
                        hREmployeeSalaryPaymentEntity.SalarySessionEndDate = salarySessionEntity.SessionEndDate;
                        hREmployeeSalaryPaymentEntity.ConsolidateSalaryAmount = Decimal.Parse(txtConsolidateSalaryAmount.Text);
                        hREmployeeSalaryPaymentEntity.Workdays = Decimal.Parse(txtWorkdays.Text);
                        hREmployeeSalaryPaymentEntity.Advance = Decimal.Parse(txtAdvance.Text);
                        hREmployeeSalaryPaymentEntity.Fine = Decimal.Parse(txtFine.Text);
                        hREmployeeSalaryPaymentEntity.Meals = Decimal.Parse(txtMeals.Text);
                        hREmployeeSalaryPaymentEntity.AIT = Decimal.Parse(txtAIT.Text);
                        hREmployeeSalaryPaymentEntity.Adjustment = Decimal.Parse(txtAdjustment.Text);
                        hREmployeeSalaryPaymentEntity.NetPayable = Decimal.Parse(txtNetPayable.Text);
                        hREmployeeSalaryPaymentEntity.Note = Decimal.Parse(txtNote.Text);
                        hREmployeeSalaryPaymentEntity.Cash = Decimal.Parse(txtCash.Text);
                        hREmployeeSalaryPaymentEntity.BankAmount = Decimal.Parse(txtBankAmount.Text);
                        hREmployeeSalaryPaymentEntity.SalaryPayable = Decimal.Parse(txtSalaryPayable.Text);
                        hREmployeeSalaryPaymentEntity.Allowance = Decimal.Parse(txtAllowance.Text);
                        hREmployeeSalaryPaymentEntity.ProjectActual = Decimal.Parse(txtProjectActual.Text);
                        hREmployeeSalaryPaymentEntity.Bonus = Decimal.Parse(txtBonus.Text);
                        hREmployeeSalaryPaymentEntity.PhoneCeiling = Decimal.Parse(txtPhoneCeiling.Text);
                        hREmployeeSalaryPaymentEntity.PhoneActualBill = Decimal.Parse(txtPhoneActualBill.Text);
                        hREmployeeSalaryPaymentEntity.PhoneBillAdjustment = Decimal.Parse(txtPhoneBillAdjustment.Text);
                        hREmployeeSalaryPaymentEntity.ProvidentFundDeductedAmount = Decimal.Parse(txtProvidentFundDeductedAmount.Text);
                        hREmployeeSalaryPaymentEntity.PBR = Decimal.Parse(txtPBR.Text);
                        hREmployeeSalaryPaymentEntity.EBR = Decimal.Parse(txtEBR.Text);
                        hREmployeeSalaryPaymentEntity.PhoneBill = Decimal.Parse(txtPhoneBill.Text);
                        hREmployeeSalaryPaymentEntity.EmployeeSalaryPaymentStatusID = Int64.Parse(ddlEmployeeSalaryPaymentStatusID.SelectedValue);
                        hREmployeeSalaryPaymentEntity.TBR = Decimal.Parse(txtTBR.Text);
                        hREmployeeSalaryPaymentEntity.TAX = Decimal.Parse(txtTAX.Text);

                        //btnSubmit.Text = "Save";

                        if (isSaveFlag)
                        {
                            FCCHREmployeeSalaryPayment.GetFacadeCreate().Add(hREmployeeSalaryPaymentEntity, DatabaseOperationType.Add, TransactionRequired.No);

                            String fee1 = "NextInstallMent <= NumberOfPayments";
                            String fee2 = SqlExpressionBuilder.PrepareFilterExpression(HREmployeeSalaryDeducationInfoEntity.FLD_NAME_EmployeeID, _employeeID.ToString(), SQLMatchType.Equal);

                            String fee = SqlExpressionBuilder.PrepareFilterExpression(fee1, SQLJoinType.AND, fee2);
                            IList<HREmployeeSalaryDeducationInfoEntity> lst = FCCHREmployeeSalaryDeducationInfo.GetFacadeCreate().GetIL(null, null, String.Empty, fee, DatabaseOperationType.LoadWithFilterExpression);

                            if (lst != null && lst.Count > 0)
                            {
                                List<HREmployeeSalaryDeducationInfoEntity> addToList = new List<HREmployeeSalaryDeducationInfoEntity>();
                                foreach (HREmployeeSalaryDeducationInfoEntity en in lst)
                                {
                                    if ((en.SalaryDeducationCategoryID == MasterDataConstants.MDSalaryDeducationCategory.ADVANCE && chbxAdvanceFilter.Checked) || (en.SalaryDeducationCategoryID == MasterDataConstants.MDSalaryDeducationCategory.FINE && chbxFineFilter.Checked) || (en.SalaryDeducationCategoryID == MasterDataConstants.MDSalaryDeducationCategory.AIT && chbxAITFilter.Checked) || (en.SalaryDeducationCategoryID == MasterDataConstants.MDSalaryDeducationCategory.TAX && chbxTAXFilter.Checked))
                                    {
                                        String filter = "EmployeeSalaryDeducationInfoID =" + en.EmployeeSalaryDeducationInfoID + "";
                                        en.NextInstallMent = en.NextInstallMent + 1;
                                        FCCHREmployeeSalaryDeducationInfo.GetFacadeCreate().Update(en, filter, DatabaseOperationType.Update, TransactionRequired.No);
                                    }
                                }
                            }

                            MiscUtil.ShowMessage(lblMessage, "Employee Salary Payment Information has been saved successfully.", false);
                        }
                        else
                        {
                            String filterExpression = SqlExpressionBuilder.PrepareFilterExpression(HREmployeeSalaryPaymentEntity.FLD_NAME_EmployeeSalaryPaymentID, lstHREmployeeSalaryPayment[0].EmployeeSalaryPaymentID.ToString(), SQLMatchType.Equal);
                            FCCHREmployeeSalaryPayment.GetFacadeCreate().Update(hREmployeeSalaryPaymentEntity, filterExpression, DatabaseOperationType.Update, TransactionRequired.No);
                            MiscUtil.ShowMessage(lblMessage, "Employee Salary Payment Information has been updated successfully.", false);
                        }


                        BindList();
                        //PrepareInitialView();
                    }
                }
            }
            catch (Exception ex)
            {
                MiscUtil.ShowMessage(lblMessage, "Failed to Employee Salary Payment Information.", true);
            }

        }

        private Decimal CalculateEBRTextBox()
        {
            Decimal i = 0;
            try
            {
                IList<ListViewDataItem> list = lvHREmployeeSalaryPayment.Items;

                if (list != null && list.Count > 0)
                {
                    //Int32 tempDataItemIndex = 0;

                    foreach (ListViewDataItem lvdi in list)
                    {
                        Label lblSalaryLevel = (Label)lvdi.FindControl("lblSalaryLevel");
                        TextBox txtConsolidateSalaryAmount = (TextBox)lvdi.FindControl("txtConsolidateSalaryAmount");
                        TextBox txtEBR = (TextBox)lvdi.FindControl("txtEBR");
                        //CheckBox chbxAddEBR = (CheckBox)lvdi.FindControl("chbxAddEBR");
                        

                        #region Calculate EBR 5%

                        if (Int64.Parse(lblSalaryLevel.Text) > 3)
                        {
                            if (chbxAddEBR.Checked)
                            {
                                txtEBR.Text = (Decimal.Truncate(Decimal.Parse(txtConsolidateSalaryAmount.Text) * MasterDataConstants.HREvaluationCategoryPercent.EBR) / 100).ToString().Trim();
                            }
                            else
                            {
                                txtEBR.Text = "0";
                            }
                        }

                        i = Decimal.Parse(txtEBR.Text);
                        #endregion
                    }
                }
            }
            catch (Exception ex)
            {
                MiscUtil.ShowMessage(lblMessage, "Failed to Employee Salary Payment Information.", true);
            }

            return i;
        }

        private void DeleteAllCurrentData()
        {
            try
            {
                Int64 result = -1;

                String f = SqlExpressionBuilder.PrepareFilterExpression(HREmployeeSalaryPaymentEntity.FLD_NAME_SalarySessionID, OverviewEmployeeSalarySessionID.ToString(), SQLMatchType.Equal);

                IList<HREmployeeSalaryPaymentEntity> list =  FCCHREmployeeSalaryPayment.GetFacadeCreate().GetIL(null, null, String.Empty, f, DatabaseOperationType.LoadWithFilterExpression);

                if (list != null && list.Count > 0)
                {
                    #region Update past data in Salary Deducation


                    foreach (HREmployeeSalaryPaymentEntity en in list)
                    {
                        //List<HREmployeeSalaryDeducationInfoEntity> addToList = new List<HREmployeeSalaryDeducationInfoEntity>();
                        String fe1 = "NextInstallMent <= NumberOfPayments";
                        String fe2 = SqlExpressionBuilder.PrepareFilterExpression(HREmployeeSalaryDeducationInfoEntity.FLD_NAME_EmployeeID, en.EmployeeID.ToString(), SQLMatchType.Equal);

                        String fe = SqlExpressionBuilder.PrepareFilterExpression(fe1, SQLJoinType.AND, fe2);
                        IList<HREmployeeSalaryDeducationInfoEntity> lst = FCCHREmployeeSalaryDeducationInfo.GetFacadeCreate().GetIL(null, null, String.Empty, fe, DatabaseOperationType.LoadWithFilterExpression);
                        if (lst != null && lst.Count > 0)
                        {
                            foreach (HREmployeeSalaryDeducationInfoEntity e in lst)
                            {
                                if ((e.SalaryDeducationCategoryID == MasterDataConstants.MDSalaryDeducationCategory.ADVANCE && en.Advance > 0) || (e.SalaryDeducationCategoryID == MasterDataConstants.MDSalaryDeducationCategory.FINE && en.Fine > 0) || (e.SalaryDeducationCategoryID == MasterDataConstants.MDSalaryDeducationCategory.AIT && en.AIT > 0) || (e.SalaryDeducationCategoryID == MasterDataConstants.MDSalaryDeducationCategory.TAX && en.TAX > 0) || (e.SalaryDeducationCategoryID == MasterDataConstants.MDSalaryDeducationCategory.MEALS && en.Meals > 0))
                                {
                                    String filter = "EmployeeSalaryDeducationInfoID =" + e.EmployeeSalaryDeducationInfoID + "";
                                    e.NextInstallMent = e.NextInstallMent - 1;
                                    FCCHREmployeeSalaryDeducationInfo.GetFacadeCreate().Update(e, filter, DatabaseOperationType.Update, TransactionRequired.No);
                                }
                            }

                        }
                    }
                    #endregion
                    HREmployeeSalaryPaymentEntity hREmployeeSalaryPaymentEntity = new HREmployeeSalaryPaymentEntity();

                    result = FCCHREmployeeSalaryPayment.GetFacadeCreate().Delete(hREmployeeSalaryPaymentEntity, f, DatabaseOperationType.Delete, TransactionRequired.No);
                }
                if (result == 0)
                {
                    _EmployeeSalaryPaymentID = 0;
                    _HREmployeeSalaryPaymentEntity = new HREmployeeSalaryPaymentEntity();
                    PrepareInitialView();
                    
                    MiscUtil.ShowMessage(lblMessage, "Employee Salary Payment has been successfully deleted.", true);
                }
                else
                {
                    MiscUtil.ShowMessage(lblMessage, "Sorry There is no Data in Employee Salary Payment.", true);
                }
            }
            catch (Exception ex)
            {
                MiscUtil.ShowMessage(lblMessage, ex.Message, true);
            }
        }

        private void CalculateNetPayableBankAndCash()
        {
            try
            {
                IList<ListViewDataItem> list = lvHREmployeeSalaryPayment.Items;

                if (list != null && list.Count > 0)
                {
                    //Int32 tempDataItemIndex = 0;

                    foreach (ListViewDataItem lvdi in list)
                    {

                        Label employeeIDlv = (Label)lvdi.FindControl("employeeIDlv");
                        Label departmentIDlv = (Label)lvdi.FindControl("departmentIDlv");
                        Label projectIDlv = (Label)lvdi.FindControl("projectIDlv");
                        Label employeeJobTypeIDlv = (Label)lvdi.FindControl("employeeJobTypeIDlv");
                        Label designationIDlv = (Label)lvdi.FindControl("designationIDlv");
                        Label employeeCodeLv = (Label)lvdi.FindControl("employeeCodeLv");
                        Label lblSalaryLevel = (Label)lvdi.FindControl("lblSalaryLevel");
                        TextBox txtConsolidateSalaryAmount = (TextBox)lvdi.FindControl("txtConsolidateSalaryAmount");
                        TextBox txtWorkdays = (TextBox)lvdi.FindControl("txtWorkdays");
                        TextBox txtAdvance = (TextBox)lvdi.FindControl("txtAdvance");
                        TextBox txtFine = (TextBox)lvdi.FindControl("txtFine");
                        TextBox txtMeals = (TextBox)lvdi.FindControl("txtMeals");
                        TextBox txtAIT = (TextBox)lvdi.FindControl("txtAIT");
                        TextBox txtAdjustment = (TextBox)lvdi.FindControl("txtAdjustment");
                        TextBox txtNetPayable = (TextBox)lvdi.FindControl("txtNetPayable");
                        TextBox txtNote = (TextBox)lvdi.FindControl("txtNote");
                        TextBox txtCash = (TextBox)lvdi.FindControl("txtCash");
                        TextBox txtBankAmount = (TextBox)lvdi.FindControl("txtBankAmount");
                        TextBox txtSalaryPayable = (TextBox)lvdi.FindControl("txtSalaryPayable");
                        TextBox txtAllowance = (TextBox)lvdi.FindControl("txtAllowance");
                        TextBox txtProjectActual = (TextBox)lvdi.FindControl("txtProjectActual");
                        TextBox txtBonus = (TextBox)lvdi.FindControl("txtBonus");
                        TextBox txtPhoneCeiling = (TextBox)lvdi.FindControl("txtPhoneCeiling");
                        TextBox txtPhoneActualBill = (TextBox)lvdi.FindControl("txtPhoneActualBill");
                        TextBox txtPhoneBillAdjustment = (TextBox)lvdi.FindControl("txtPhoneBillAdjustment");
                        TextBox txtProvidentFundDeductedAmount = (TextBox)lvdi.FindControl("txtProvidentFundDeductedAmount");
                        TextBox txtPBR = (TextBox)lvdi.FindControl("txtPBR");
                        TextBox txtEBR = (TextBox)lvdi.FindControl("txtEBR");
                        TextBox txtPhoneBill = (TextBox)lvdi.FindControl("txtPhoneBill");
                        DropDownList ddlEmployeeSalaryPaymentStatusID = (DropDownList)lvdi.FindControl("ddlEmployeeSalaryPaymentStatusID");
                        TextBox txtREMARKS = (TextBox)lvdi.FindControl("txtREMARKS");
                        TextBox txtTBR = (TextBox)lvdi.FindControl("txtTBR");
                        TextBox txtTAX = (TextBox)lvdi.FindControl("txtTAX");
                        txtSalaryPayable.Text = (Decimal.Parse(txtConsolidateSalaryAmount.Text) * Decimal.Parse(txtSalaryPayablePercent.Text)).ToString();
                        Decimal netPayable = 0;

                        if (chbxBounusFilter.Checked)
                        {
                            netPayable = (Decimal.Parse(txtSalaryPayable.Text) - (Decimal.Parse(txtAdvance.Text) + Decimal.Parse(txtFine.Text) + Decimal.Parse(txtMeals.Text) + Decimal.Parse(txtAIT.Text) + Decimal.Parse(txtProvidentFundDeductedAmount.Text) + Decimal.Parse(txtTAX.Text)) - Decimal.Parse(txtAdjustment.Text) + Decimal.Parse(txtAllowance.Text) - Decimal.Parse(txtPhoneBillAdjustment.Text) + Decimal.Parse(txtBonus.Text));
                            txtNetPayable.Text =netPayable.ToString().Trim();

                            //txtCash.Text = (Decimal.Parse(txtNetPayable.Text) - Decimal.Parse(txtSalaryPayable.Text)).ToString().Trim();
                            //txtBankAmount.Text = (Decimal.Parse(txtNetPayable.Text) - Decimal.Parse(txtCash.Text)).ToString().Trim();

                            #region Calculate Cash and Bank

                            if (txtBankAmount.Text.IsNullOrEmpty() || Decimal.Parse(txtBankAmount.Text) == 0)
                            {
                                txtBankAmount.Text = txtNetPayable.Text;
                            }
                            else
                            {
                                if (Decimal.Parse(txtBankAmount.Text) == Decimal.Parse(txtNetPayable.Text))
                                {
                                    txtCash.Text = "0";
                                }
                                else if (Decimal.Parse(txtBankAmount.Text) > Decimal.Parse(txtNetPayable.Text))
                                {
                                    txtCash.Text = "0";
                                    txtBankAmount.Text = txtNetPayable.Text;
                                }
                                else if (Decimal.Parse(txtBankAmount.Text) < Decimal.Parse(txtNetPayable.Text) && Decimal.Parse(txtConsolidateSalaryAmount.Text) < 40000)
                                {
                                    txtBankAmount.Text = (Decimal.Parse(txtNetPayable.Text) - Decimal.Parse(txtCash.Text)).ToString().Trim();
                                }
                                else if (Decimal.Parse(txtBankAmount.Text) < Decimal.Parse(txtNetPayable.Text) && Decimal.Parse(txtConsolidateSalaryAmount.Text) >= 40000)
                                {
                                    txtCash.Text = (Decimal.Parse(txtNetPayable.Text) - Decimal.Parse(txtBankAmount.Text)).ToString().Trim();
                                }
                            }

                            txtCash.Text = (Decimal.Parse(txtNetPayable.Text) - Decimal.Parse(txtBankAmount.Text)).ToString().Trim();

                            #endregion
                        }
                        else
                        {
                            txtNetPayable.Text = (Decimal.Parse(txtSalaryPayable.Text) - (Decimal.Parse(txtAdvance.Text) + Decimal.Parse(txtFine.Text) + Decimal.Parse(txtMeals.Text) + Decimal.Parse(txtAIT.Text) + Decimal.Parse(txtProvidentFundDeductedAmount.Text) + Decimal.Parse(txtTAX.Text)) + Decimal.Parse(txtAdjustment.Text) + Decimal.Parse(txtAllowance.Text) - Decimal.Parse(txtPhoneBillAdjustment.Text) + Decimal.Parse(txtTBR.Text) + Decimal.Parse(txtEBR.Text)).ToString().Trim();

                            #region Calculate Cash and Bank

                            if (txtBankAmount.Text.IsNullOrEmpty() || Decimal.Parse(txtBankAmount.Text) == 0)
                            {
                                txtBankAmount.Text = txtNetPayable.Text;
                            }
                            else
                            {
                                if (Decimal.Parse(txtBankAmount.Text) == Decimal.Parse(txtNetPayable.Text))
                                {
                                    txtCash.Text = "0";
                                }
                                else if (Decimal.Parse(txtBankAmount.Text) > Decimal.Parse(txtNetPayable.Text))
                                {
                                    txtCash.Text = "0";
                                    txtBankAmount.Text = txtNetPayable.Text;
                                }
                                else if (Decimal.Parse(txtBankAmount.Text) < Decimal.Parse(txtNetPayable.Text))
                                {
                                    txtCash.Text = (Decimal.Parse(txtNetPayable.Text) - Decimal.Parse(txtBankAmount.Text)).ToString().Trim();
                                }
                            }

                            txtCash.Text = (Decimal.Parse(txtNetPayable.Text) - Decimal.Parse(txtBankAmount.Text)).ToString().Trim();
                        }

                        #endregion

                        //BindList();
                        //PrepareInitialView();
                    }
                }
            }
            catch (Exception ex)
            {
                MiscUtil.ShowMessage(lblMessage, "Failed to Employee Salary Payment Information.", true);
            }

        }

        private void GenerateAll()
        {
            try
            {
                StringBuilder xmlStr = new StringBuilder();

                #region Department Dropdown Filtering
                String f = SqlExpressionBuilder.PrepareFilterExpression("MDSalarySession.SalarySessionID", OverviewEmployeeSalarySessionID.ToString(), SQLMatchType.Equal);

                if (ddlDepartmentID.SelectedValue == "1")
                {
                    String fe2 = "(HREmployee.DepartmentID is null or HREmployee.DepartmentID <> 25)";
                    f = SqlExpressionBuilder.PrepareFilterExpression(f, SQLJoinType.AND, fe2);
                }
                else
                {
                    String fe3 = "(HREmployee.DepartmentID = 25)";
                    f = SqlExpressionBuilder.PrepareFilterExpression(f, SQLJoinType.AND, fe3);
                }

                #endregion 

                IList<HRMonthlySalaryPayment_CustomEntity> list = FCCHRMonthlySalaryPayment_Custom.GetFacadeCreate().GetIL(1000, 1, String.Empty, f);


                xmlStr.Append("<m>");
                if (list != null && list.Count > 0)
                {

                    foreach (HRMonthlySalaryPayment_CustomEntity hRMonthlySalaryPayment_CustomEntity in list)
                    {
                        HREmployeeSalaryPaymentEntity hREmployeeSalaryPaymentEntity = new HREmployeeSalaryPaymentEntity();

                        String remarks = String.Empty;
                        Decimal phoneActualBill = 0;
                        Decimal phoneCeiling = 0;
                        Decimal phoneAdjustment = 0;
                        Int64 fiscalYearID = MiscUtil.GetActiveFiscalYear();
                        Int64 _employeeID = (hRMonthlySalaryPayment_CustomEntity.EmployeeID);

                        

                        #region Salary Session

                        MDSalarySessionEntity entity = FCCMDSalarySession.GetFacadeCreate().GetByID(OverviewEmployeeSalarySessionID);
                        hREmployeeSalaryPaymentEntity.SalarySessionStartDate = entity.SessionStartDate;
                        hREmployeeSalaryPaymentEntity.SalarySessionEndDate = entity.SessionEndDate;

                        #endregion

                        #region Text Field Default Value

                        hREmployeeSalaryPaymentEntity.Adjustment = 0;

                        hREmployeeSalaryPaymentEntity.Allowance= 0;
                        hREmployeeSalaryPaymentEntity.BankAmount = 0;
                        hREmployeeSalaryPaymentEntity.Bonus = 0;
                        hREmployeeSalaryPaymentEntity.Cash = 0;
                        hREmployeeSalaryPaymentEntity.EBR= 0;
                        hREmployeeSalaryPaymentEntity.NetPayable = 0;
                        hREmployeeSalaryPaymentEntity.Note = 0;
                        hREmployeeSalaryPaymentEntity.PBR = 0;
                        hREmployeeSalaryPaymentEntity.PhoneActualBill = 0;
                        hREmployeeSalaryPaymentEntity.PhoneBill = 0;
                        hREmployeeSalaryPaymentEntity.PhoneBillAdjustment = 0;
                        hREmployeeSalaryPaymentEntity.PhoneCeiling = 0;
                        hREmployeeSalaryPaymentEntity.ProjectActual = 0;
                        hREmployeeSalaryPaymentEntity.Bonus =0;
                        hREmployeeSalaryPaymentEntity.ProvidentFundDeductedAmount = 0;
                        hREmployeeSalaryPaymentEntity.Field2 = String.Empty;
                        hREmployeeSalaryPaymentEntity.ProvidentFundDeductedAmount = 0;
                        hREmployeeSalaryPaymentEntity.Advance = 0;
                        hREmployeeSalaryPaymentEntity.Fine = 0;
                        hREmployeeSalaryPaymentEntity.AIT = 0;
                        hREmployeeSalaryPaymentEntity.Meals = 0;
                        hREmployeeSalaryPaymentEntity.TBR = 0;
                        hREmployeeSalaryPaymentEntity.TAX = 0;

                        #endregion

                        #region PhoneBill

                        String phoneBillAdjustmentFiltering = "EmployeeID = " + _employeeID + " and SalarySessionID = " + entity.SalarySessionID + "";
                        IList<HREmployeePhoneBillAdjustmentEntity> hREmployeePhoneBillAdjustmentList = FCCHREmployeePhoneBillAdjustment.GetFacadeCreate().GetIL(null, null, String.Empty, phoneBillAdjustmentFiltering, DatabaseOperationType.LoadWithFilterExpression);

                        if (hREmployeePhoneBillAdjustmentList != null && hREmployeePhoneBillAdjustmentList.Count > 0)
                        {
                            remarks += hREmployeePhoneBillAdjustmentList[0].PhoneBillNote;
                            phoneActualBill = hREmployeePhoneBillAdjustmentList[0].PhoneBillAmount;
                        }

                        String allowanceFilter = "EmployeeID = " + _employeeID + " and FiscalYearID = " + fiscalYearID + " and AllowanceCategoryID = " + MasterDataConstants.MDAllowanceCategory.PHONE_BILL + "";
                        IList<HREmployeeAllowanceEntity> hREmployeeAllowanceList = FCCHREmployeeAllowance.GetFacadeCreate().GetIL(null, null, String.Empty, allowanceFilter, DatabaseOperationType.LoadWithFilterExpression);

                        if (hREmployeeAllowanceList != null && hREmployeeAllowanceList.Count > 0)
                        {
                            phoneCeiling = hREmployeeAllowanceList[0].Amount;
                        }

                        #endregion

                        #region Set Payment Status

                        hREmployeeSalaryPaymentEntity.EmployeeSalaryPaymentStatusID = 2;

                        #endregion

                        #region Deduction

                        String fe1 = "NextInstallMent <= NumberOfPayments";
                        String fe2 = SqlExpressionBuilder.PrepareFilterExpression(HREmployeeSalaryDeducationInfoEntity.FLD_NAME_EmployeeID, _employeeID.ToString(), SQLMatchType.Equal);

                        String fe = SqlExpressionBuilder.PrepareFilterExpression(fe1, SQLJoinType.AND, fe2);

                        IList<HREmployeeSalaryDeducationInfoEntity> lst = FCCHREmployeeSalaryDeducationInfo.GetFacadeCreate().GetIL(null, null, String.Empty, fe, DatabaseOperationType.LoadWithFilterExpression);

                        if (lst != null && lst.Count > 0)
                        {
                            if (chbxAdvanceFilter.Checked)
                            {
                                hREmployeeSalaryPaymentEntity.Advance = (from s in lst
                                                                         where s.SalaryDeducationCategoryID == MasterDataConstants.MDSalaryDeducationCategory.ADVANCE
                                                                         select s.DeductionAmount / s.NumberOfPayments).Sum();
                                foreach (HREmployeeSalaryDeducationInfoEntity en in lst)
                                {
                                    if (en.SalaryDeducationCategoryID == MasterDataConstants.MDSalaryDeducationCategory.ADVANCE)
                                    {
                                        remarks += ("- " + Math.Truncate((Decimal)en.NextInstallMent) + " /" + Math.Truncate(en.NumberOfPayments) + " Installment of " + Math.Truncate(en.DeductionAmount) + ". ");
                                    }
                                }
                            }

                            if (chbxFineFilter.Checked)
                            {
                                hREmployeeSalaryPaymentEntity.Fine = (from s in lst
                                                                      where s.SalaryDeducationCategoryID == MasterDataConstants.MDSalaryDeducationCategory.FINE
                                                                      select s.DeductionAmount / s.NumberOfPayments).Sum();
                                foreach (HREmployeeSalaryDeducationInfoEntity en in lst)
                                {
                                    if (en.SalaryDeducationCategoryID == MasterDataConstants.MDSalaryDeducationCategory.FINE)
                                    {
                                        remarks += ("- " + Math.Truncate((Decimal)en.NextInstallMent) + " /" + Math.Truncate(en.NumberOfPayments) + " Installment of " + Math.Truncate(en.DeductionAmount) + ". ");
                                    }
                                }
                            }

                            if (chbxAITFilter.Checked)
                            {
                                hREmployeeSalaryPaymentEntity.AIT = (from s in lst
                                                                     where s.SalaryDeducationCategoryID == MasterDataConstants.MDSalaryDeducationCategory.AIT
                                                                     select s.DeductionAmount / s.NumberOfPayments).Sum();
                                foreach (HREmployeeSalaryDeducationInfoEntity en in lst)
                                {
                                    if (en.SalaryDeducationCategoryID == MasterDataConstants.MDSalaryDeducationCategory.AIT)
                                    {
                                        remarks += ("- " + Math.Truncate((Decimal)en.NextInstallMent) + " /" + Math.Truncate(en.NumberOfPayments) + " Installment of " + Math.Truncate(en.DeductionAmount) + ". ");
                                    }
                                }
                            }

                            if (chbxTAXFilter.Checked)
                            {
                                hREmployeeSalaryPaymentEntity.TAX = (from s in lst
                                                                     where s.SalaryDeducationCategoryID == MasterDataConstants.MDSalaryDeducationCategory.TAX
                                                                     select s.DeductionAmount / s.NumberOfPayments).Sum();
                                foreach (HREmployeeSalaryDeducationInfoEntity en in lst)
                                {
                                    if (en.SalaryDeducationCategoryID == MasterDataConstants.MDSalaryDeducationCategory.TAX)
                                    {
                                        remarks += ("- " + Math.Truncate((Decimal)en.NextInstallMent) + " /" + Math.Truncate(en.NumberOfPayments) + " Installment of " + Math.Truncate(en.DeductionAmount) + ". ");
                                    }
                                }
                            }

                            if (chbxMealFilter.Checked)
                            {
                                hREmployeeSalaryPaymentEntity.Meals = (from s in lst
                                                                     where s.SalaryDeducationCategoryID == MasterDataConstants.MDSalaryDeducationCategory.MEALS
                                                                     select s.DeductionAmount / s.NumberOfPayments).Sum();
                                foreach (HREmployeeSalaryDeducationInfoEntity en in lst)
                                {
                                    if (en.SalaryDeducationCategoryID == MasterDataConstants.MDSalaryDeducationCategory.MEALS)
                                    {
                                        remarks += ("- " + Math.Truncate((Decimal)en.NextInstallMent) + " /" + Math.Truncate(en.NumberOfPayments) + " Installment of " + Math.Truncate(en.DeductionAmount) + ". ");
                                    }
                                }
                            }
                        }


                        #endregion

                        #region Adjustment

                        String fe_adjustment1 = SqlExpressionBuilder.PrepareFilterExpression(HRSalaryAdjustmentEntity.FLD_NAME_SalarySessionID, OverviewEmployeeSalarySessionID.ToString(), SQLMatchType.Equal);
                        String fe_adjustment2 = SqlExpressionBuilder.PrepareFilterExpression(HRSalaryAdjustmentEntity.FLD_NAME_EmployeeID, _employeeID.ToString(), SQLMatchType.Equal);

                        String fe_adjustment = SqlExpressionBuilder.PrepareFilterExpression(fe_adjustment1, SQLJoinType.AND, fe_adjustment2);

                        IList<HRSalaryAdjustmentEntity> lstadjustment = FCCHRSalaryAdjustment.GetFacadeCreate().GetIL(null, null, String.Empty, fe_adjustment, DatabaseOperationType.LoadWithFilterExpression);

                        if (lstadjustment != null && lstadjustment.Count > 0)
                        {
                            if (chbxAdjustmentFilter.Checked)
                            {
                                hREmployeeSalaryPaymentEntity.Adjustment = (from s in lstadjustment select s.AdjustmentAmount).Sum();

                                foreach (HRSalaryAdjustmentEntity e in lstadjustment)
                                {
                                    remarks += e.Remarks + " ";
                                }
                            }
                        }
                        

                        #endregion

                        #region Allowance

                        String allowance = "EmployeeID = " + _employeeID + " and FiscalYearID = " + fiscalYearID + " and AllowanceCategoryID = " + MasterDataConstants.MDAllowanceCategory.OTHER + "";
                        IList<HREmployeeAllowanceEntity> allowanceList = FCCHREmployeeAllowance.GetFacadeCreate().GetIL(null, null, String.Empty, allowance, DatabaseOperationType.LoadWithFilterExpression);

                        if (allowanceList != null && allowanceList.Count > 0)
                        {
                            if (chbxAllowanceFilter.Checked)
                            {
                                hREmployeeSalaryPaymentEntity.Allowance = (from s in allowanceList
                                                     select s.Amount).Sum();

                                foreach (HREmployeeAllowanceEntity e in allowanceList)
                                {
                                    remarks += e.Remarks + " ";
                                }
                            }
                        }

                        #endregion

                        #region Time Sheet Remarks

                        String remarksFilter = "SalarySessionID = " + OverviewEmployeeSalarySessionID + " and EmployeeID=" + _employeeID + "";
                        IList<HREmployeeMonthlyTimeSheetSummaryEntity> listHREmployeeMonthlyTimeSheetSummary = FCCHREmployeeMonthlyTimeSheetSummary.GetFacadeCreate().GetIL(null, null, String.Empty, remarksFilter, DatabaseOperationType.LoadWithFilterExpression);
                        if (listHREmployeeMonthlyTimeSheetSummary != null && listHREmployeeMonthlyTimeSheetSummary.Count > 0)
                        {
                            remarks += " " + listHREmployeeMonthlyTimeSheetSummary[0].REMARKS;
                        }

                        #endregion

                        #region Calculate EBR 5%

                        if (hRMonthlySalaryPayment_CustomEntity.SalaryLevel > 3)
                        {
                            if (chbxAddEBR.Checked)
                            {
                                hREmployeeSalaryPaymentEntity.EBR = (hRMonthlySalaryPayment_CustomEntity.SalaryAmount * MasterDataConstants.HREvaluationCategoryPercent.EBR) / 100;
                            }
                        }

                        #endregion

                        phoneAdjustment = phoneCeiling - phoneActualBill;
                        if (phoneAdjustment > 0)
                            phoneAdjustment = 0;

                        hREmployeeSalaryPaymentEntity.Field2 = remarks;
                        hREmployeeSalaryPaymentEntity.PhoneActualBill = phoneActualBill;
                        hREmployeeSalaryPaymentEntity.PhoneCeiling = phoneCeiling;
                        hREmployeeSalaryPaymentEntity.PhoneBillAdjustment = -phoneAdjustment;
                        hREmployeeSalaryPaymentEntity.SalaryPayable = hRMonthlySalaryPayment_CustomEntity.SalaryAmount * Decimal.Parse(txtSalaryPayablePercent.Text);
                        

                        #region Calculate TBR

                        if (hRMonthlySalaryPayment_CustomEntity.SalaryLevel > 3)
                        {
                            if (chbxTBRFilter.Checked)
                            {
                                hREmployeeSalaryPaymentEntity.TBR = (((hRMonthlySalaryPayment_CustomEntity.SalaryAmount) * MasterDataConstants.HREvaluationCategoryPercent.TBR) / 100);
                            }
                        }
                        

                        #endregion

                        if (chbxBounusFilter.Checked)
                        {

                            if (hRMonthlySalaryPayment_CustomEntity.ServiceDays != null)
                            {
                                if (hRMonthlySalaryPayment_CustomEntity.ServiceDays >= 181)
                                {
                                    hREmployeeSalaryPaymentEntity.Bonus = Decimal.Floor(hRMonthlySalaryPayment_CustomEntity.SalaryAmount * Decimal.Parse(txtBonusPercent.Text));
                                    remarks += " Eid bonus " + Math.Truncate(hREmployeeSalaryPaymentEntity.Bonus) + " taka.";
                                }
                                else
                                {
                                    hREmployeeSalaryPaymentEntity.Bonus = Decimal.Floor(hRMonthlySalaryPayment_CustomEntity.SalaryAmount * Decimal.Parse(txtBonusPercent.Text) / 181 * (Decimal)hRMonthlySalaryPayment_CustomEntity.ServiceDays);
                                    remarks += " Eid bonus " + Math.Truncate(hREmployeeSalaryPaymentEntity.Bonus) + " taka.";
                                }
                            }

                            #region Calculate Netpayble, Cash, Bank

                            hREmployeeSalaryPaymentEntity.NetPayable = (Decimal)((hREmployeeSalaryPaymentEntity.SalaryPayable) - (hREmployeeSalaryPaymentEntity.TAX +hREmployeeSalaryPaymentEntity.Advance + hREmployeeSalaryPaymentEntity.Fine + hREmployeeSalaryPaymentEntity.Meals + hREmployeeSalaryPaymentEntity.AIT) + hREmployeeSalaryPaymentEntity.Adjustment + hREmployeeSalaryPaymentEntity.Allowance - hREmployeeSalaryPaymentEntity.PhoneBillAdjustment + hREmployeeSalaryPaymentEntity.Bonus);

                            hREmployeeSalaryPaymentEntity.Cash = hREmployeeSalaryPaymentEntity.NetPayable - hREmployeeSalaryPaymentEntity.SalaryPayable;
                            hREmployeeSalaryPaymentEntity.BankAmount = hREmployeeSalaryPaymentEntity.NetPayable - hREmployeeSalaryPaymentEntity.Cash;

                            #endregion

                            #region Calclate Bank and Cash if Bonus

                            if (hREmployeeSalaryPaymentEntity.BankAmount.IsZero())
                            {
                                hREmployeeSalaryPaymentEntity.BankAmount = hREmployeeSalaryPaymentEntity.NetPayable;
                            }
                            else
                            {
                                if (hREmployeeSalaryPaymentEntity.BankAmount == hREmployeeSalaryPaymentEntity.NetPayable)
                                {
                                    hREmployeeSalaryPaymentEntity.Cash = 0;
                                }
                                else if (hREmployeeSalaryPaymentEntity.BankAmount > hREmployeeSalaryPaymentEntity.NetPayable)
                                {
                                    hREmployeeSalaryPaymentEntity.Cash = 0;
                                    hREmployeeSalaryPaymentEntity.BankAmount = hREmployeeSalaryPaymentEntity.NetPayable;
                                }
                                else if (hREmployeeSalaryPaymentEntity.BankAmount < hREmployeeSalaryPaymentEntity.NetPayable && hREmployeeSalaryPaymentEntity.ConsolidateSalaryAmount < 4000)
                                {
                                    hREmployeeSalaryPaymentEntity.BankAmount = hREmployeeSalaryPaymentEntity.NetPayable - hREmployeeSalaryPaymentEntity.Cash;
                                }
                                else if (hREmployeeSalaryPaymentEntity.BankAmount < hREmployeeSalaryPaymentEntity.NetPayable && hREmployeeSalaryPaymentEntity.ConsolidateSalaryAmount >= 4000)
                                {
                                    hREmployeeSalaryPaymentEntity.Cash = hREmployeeSalaryPaymentEntity.NetPayable - hREmployeeSalaryPaymentEntity.BankAmount;
                                }
                            }

                            hREmployeeSalaryPaymentEntity.Cash = hREmployeeSalaryPaymentEntity.NetPayable - hREmployeeSalaryPaymentEntity.BankAmount;

                            #endregion
                        }
                        else
                        {

                            #region Calculate Netpayble, Cash, Bank

                            hREmployeeSalaryPaymentEntity.NetPayable = (Decimal)((hREmployeeSalaryPaymentEntity.SalaryPayable) - (hREmployeeSalaryPaymentEntity.TAX + hREmployeeSalaryPaymentEntity.Advance + hREmployeeSalaryPaymentEntity.Fine + hREmployeeSalaryPaymentEntity.Meals + hREmployeeSalaryPaymentEntity.AIT) + hREmployeeSalaryPaymentEntity.Adjustment + hREmployeeSalaryPaymentEntity.Allowance + hREmployeeSalaryPaymentEntity.PhoneBillAdjustment + hREmployeeSalaryPaymentEntity.TBR + hREmployeeSalaryPaymentEntity.EBR);

                            hREmployeeSalaryPaymentEntity.Cash = hREmployeeSalaryPaymentEntity.NetPayable - hREmployeeSalaryPaymentEntity.SalaryPayable;
                            hREmployeeSalaryPaymentEntity.BankAmount = hREmployeeSalaryPaymentEntity.NetPayable - hREmployeeSalaryPaymentEntity.Cash;

                            #endregion

                            #region Calculate Cash and Bank

                            if (hREmployeeSalaryPaymentEntity.BankAmount.IsZero())
                            {
                                hREmployeeSalaryPaymentEntity.BankAmount = hREmployeeSalaryPaymentEntity.NetPayable;
                            }
                            else
                            {
                                if (hREmployeeSalaryPaymentEntity.BankAmount == hREmployeeSalaryPaymentEntity.NetPayable)
                                {
                                    hREmployeeSalaryPaymentEntity.Cash = 0;
                                }
                                else if (hREmployeeSalaryPaymentEntity.BankAmount > hREmployeeSalaryPaymentEntity.NetPayable)
                                {
                                    hREmployeeSalaryPaymentEntity.Cash = 0;
                                    hREmployeeSalaryPaymentEntity.BankAmount = hREmployeeSalaryPaymentEntity.NetPayable;
                                }
                                else if (hREmployeeSalaryPaymentEntity.BankAmount < hREmployeeSalaryPaymentEntity.NetPayable)
                                {
                                    hREmployeeSalaryPaymentEntity.Cash = hREmployeeSalaryPaymentEntity.NetPayable - hREmployeeSalaryPaymentEntity.BankAmount;
                                }
                            }

                            hREmployeeSalaryPaymentEntity.Cash = hREmployeeSalaryPaymentEntity.NetPayable - hREmployeeSalaryPaymentEntity.BankAmount;
                            #endregion
                        }

                        

                        #region Already Has this employee
                        Boolean isTrue = true;

                        String fe4 = SqlExpressionBuilder.PrepareFilterExpression(HREmployeeSalaryPaymentEntity.FLD_NAME_EmployeeID, _employeeID.ToString(), SQLMatchType.Equal);
                        String fe5 = SqlExpressionBuilder.PrepareFilterExpression(HREmployeeMonthlyTimeSheetSummaryEntity.FLD_NAME_SalarySessionID, OverviewEmployeeSalarySessionID.ToString(), SQLMatchType.Equal);
                        String fe6 = SqlExpressionBuilder.PrepareFilterExpression(fe4, SQLJoinType.AND, fe5);
                        IList<HREmployeeSalaryPaymentEntity> hREmployeeSalaryPaymentList = FCCHREmployeeSalaryPayment.GetFacadeCreate().GetIL(null, null, String.Empty, fe6, DatabaseOperationType.LoadWithFilterExpression);

                        if (hREmployeeSalaryPaymentList != null && hREmployeeSalaryPaymentList.Count > 0)
                        {
                            isTrue = false;
                        }

                        #endregion

                        if (isTrue)
                        {
                            String subXmlStr = null;
                            subXmlStr = subXmlStr + "<i><a>" + hRMonthlySalaryPayment_CustomEntity.EmployeeID + "</a><b>" + hRMonthlySalaryPayment_CustomEntity.EmployeeJobTypeID + "</b><c>" + hRMonthlySalaryPayment_CustomEntity.ProjectID + "</c><d>" + hRMonthlySalaryPayment_CustomEntity.DepartmentID + "</d><e>" + hRMonthlySalaryPayment_CustomEntity.DesignationID + "</e><f>" + hRMonthlySalaryPayment_CustomEntity.EmployeeCode + "</f><g>" + hRMonthlySalaryPayment_CustomEntity.SalarySessionID + "</g><h>" + hREmployeeSalaryPaymentEntity.SalarySessionStartDate + "</h><i1>" + hREmployeeSalaryPaymentEntity.SalarySessionEndDate + "</i1><j>" + hRMonthlySalaryPayment_CustomEntity.SalaryAmount + "</j><k>" + hRMonthlySalaryPayment_CustomEntity.ACTUALWORKDAYS + "</k><l>" + hREmployeeSalaryPaymentEntity.Advance + "</l><m>" + hREmployeeSalaryPaymentEntity.Fine + "</m><n>" + hREmployeeSalaryPaymentEntity.Meals + "</n><o>" + hREmployeeSalaryPaymentEntity.AIT + "</o><p>" + hREmployeeSalaryPaymentEntity.Adjustment + "</p><q>" + hREmployeeSalaryPaymentEntity.NetPayable + "</q><r>" + hREmployeeSalaryPaymentEntity.Note + "</r><s>" + hREmployeeSalaryPaymentEntity.Cash + "</s><t>" + hREmployeeSalaryPaymentEntity.BankAmount + "</t><u>" + hREmployeeSalaryPaymentEntity.SalaryPayable + "</u><v>" + hREmployeeSalaryPaymentEntity.Allowance + "</v><w>" + hREmployeeSalaryPaymentEntity.ProjectActual + "</w><x>" + hREmployeeSalaryPaymentEntity.Bonus + "</x><y>" + hREmployeeSalaryPaymentEntity.PhoneCeiling + "</y><z>" + hREmployeeSalaryPaymentEntity.PhoneActualBill + "</z><a1>" + hREmployeeSalaryPaymentEntity.PhoneBillAdjustment + "</a1><b1>" + hREmployeeSalaryPaymentEntity.ProvidentFundDeductedAmount + "</b1><c1>" + hREmployeeSalaryPaymentEntity.PBR + "</c1><d1>" + hREmployeeSalaryPaymentEntity.EBR + "</d1><e1>" + hREmployeeSalaryPaymentEntity.PhoneBill + "</e1><f1>" + hREmployeeSalaryPaymentEntity.EmployeeSalaryPaymentStatusID + "</f1><g1>" + hRMonthlySalaryPayment_CustomEntity.SalaryLevel + "</g1><h1>" + hREmployeeSalaryPaymentEntity.Field2 + "</h1><j1>" + hREmployeeSalaryPaymentEntity.TBR + "</j1><k1>" + hREmployeeSalaryPaymentEntity.TAX + "</k1></i>";
                            xmlStr.Append(subXmlStr.ToString());

                            if (lst != null && lst.Count > 0)
                            {
                                List<HREmployeeSalaryDeducationInfoEntity> addToList = new List<HREmployeeSalaryDeducationInfoEntity>();
                                foreach (HREmployeeSalaryDeducationInfoEntity en in lst)
                                {
                                    if ((en.SalaryDeducationCategoryID == MasterDataConstants.MDSalaryDeducationCategory.ADVANCE && chbxAdvanceFilter.Checked) || (en.SalaryDeducationCategoryID == MasterDataConstants.MDSalaryDeducationCategory.FINE && chbxFineFilter.Checked) || (en.SalaryDeducationCategoryID == MasterDataConstants.MDSalaryDeducationCategory.AIT && chbxAITFilter.Checked) || (en.SalaryDeducationCategoryID == MasterDataConstants.MDSalaryDeducationCategory.TAX && chbxTAXFilter.Checked) || (en.SalaryDeducationCategoryID == MasterDataConstants.MDSalaryDeducationCategory.MEALS && chbxMealFilter.Checked))
                                    {
                                        String filter = "EmployeeSalaryDeducationInfoID =" + en.EmployeeSalaryDeducationInfoID + "";
                                        en.NextInstallMent = en.NextInstallMent + 1;
                                        FCCHREmployeeSalaryDeducationInfo.GetFacadeCreate().Update(en, filter, DatabaseOperationType.Update, TransactionRequired.No);
                                    }
                                }
                                
                            }
                        }
                    }
                }
                xmlStr.Append("</m>");

                FCCBulkInsertXML.GetFacadeCreate().GetIL(xmlStr.ToString(), CommonConstants.HREmployeeSalaryPayment);

                MiscUtil.ShowMessage(lblMessage, "Time Sheet Has been Generated Successfully.", false);
            }
            catch (Exception ex)
            {
                MiscUtil.ShowMessage(lblMessage, "An Error Occoured.", true);
            }
        }

        private void ProvidentFundDeduct()
        {
            try
            {
                IList<ListViewDataItem> list = lvHREmployeeSalaryPayment.Items;

                if (list != null && list.Count > 0)
                {
                    //Int32 tempDataItemIndex = 0;

                    foreach (ListViewDataItem lvdi in list)
                    {
                        TextBox txtConsolidateSalaryAmount = (TextBox)lvdi.FindControl("txtConsolidateSalaryAmount");
                        TextBox txtProvidentFundDeductedAmount = (TextBox)lvdi.FindControl("txtProvidentFundDeductedAmount");
                        Decimal pfdeduct = 0;

                        if (chbxPFDeduct.Checked)
                        {
                            pfdeduct = Decimal.Parse(txtConsolidateSalaryAmount.Text) * (Decimal).05;
                            txtProvidentFundDeductedAmount.Text = (pfdeduct).ToString();
                        }
                        else
                        {
                            txtProvidentFundDeductedAmount.Text = "0";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MiscUtil.ShowMessage(lblMessage, "Failed to Employee Salary Payment Information.", true);
            }
        }

        private void CalculateBonus()
        {
            try
            {
                IList<ListViewDataItem> list = lvHREmployeeSalaryPayment.Items;

                if (list != null && list.Count > 0)
                {
                    //Int32 tempDataItemIndex = 0;

                    foreach (ListViewDataItem lvdi in list)
                    {
                        TextBox txtConsolidateSalaryAmount = (TextBox)lvdi.FindControl("txtConsolidateSalaryAmount");
                        TextBox txtProvidentFundDeductedAmount = (TextBox)lvdi.FindControl("txtProvidentFundDeductedAmount");
                        TextBox txtREMARKS = (TextBox)lvdi.FindControl("txtREMARKS");
                        Label lblServiceDays = (Label)lvdi.FindControl("lblServiceDays");
                        TextBox txtBonus = (TextBox)lvdi.FindControl("txtBonus");
                        String remarks = String.Empty;

                        if (chbxBounusFilter.Checked)
                        {
                            if (lblServiceDays.Text.IsNotNullOrEmpty())
                            {
                                if (Decimal.Parse(lblServiceDays.Text) >= 181)
                                {
                                    txtBonus.Text = (Decimal.Floor(Decimal.Parse(txtConsolidateSalaryAmount.Text) * Decimal.Parse(txtBonusPercent.Text))).ToString();
                                    remarks += " Eid bonus " + txtBonus.Text + " taka.";
                                    txtREMARKS.Text = remarks;
                                }
                                else
                                {
                                    txtBonus.Text = (Decimal.Floor(Decimal.Parse(txtConsolidateSalaryAmount.Text) * Decimal.Parse(txtBonusPercent.Text) / 181 * Decimal.Parse(lblServiceDays.Text))).ToString();
                                    remarks += " Eid bonus " + txtBonus.Text + " taka.";
                                    txtREMARKS.Text = remarks;
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MiscUtil.ShowMessage(lblMessage, "Failed to Employee Salary Payment Information.", true);
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

        protected void lvHREmployeeSalaryPayment_ItemDataBound(object sender, ListViewItemEventArgs e)
        {
            if (e.Item.ItemType == ListViewItemType.DataItem)
            {
                ListViewDataItem dataItem = (ListViewDataItem)e.Item;

                #region List View Item

                HRMonthlySalaryPayment_CustomEntity ent = (HRMonthlySalaryPayment_CustomEntity)dataItem.DataItem;
                DropDownList ddlEmployeeSalaryPaymentStatusID = (DropDownList)e.Item.FindControl("ddlEmployeeSalaryPaymentStatusID");
                TextBox txtAdvance = (TextBox)e.Item.FindControl("txtAdvance");
                TextBox txtFine = (TextBox)e.Item.FindControl("txtFine");
                TextBox txtMeals = (TextBox)e.Item.FindControl("txtMeals");
                TextBox txtAIT = (TextBox)e.Item.FindControl("txtAIT");
                TextBox txtAdjustment = (TextBox)e.Item.FindControl("txtAdjustment");
                Label employeeFirstNamelv = (Label)e.Item.FindControl("employeeFirstNamelv");
                Label employeeMiddleNamelv = (Label)e.Item.FindControl("employeeMiddleNamelv");
                Label employeeLastNamelv = (Label)e.Item.FindControl("employeeLastNamelv");
                Label employeeNamelv = (Label)e.Item.FindControl("employeeNamelv");
                Label employeeIDlv = (Label)e.Item.FindControl("employeeIDlv");
                Label departmentIDlv = (Label)e.Item.FindControl("departmentIDlv");
                Label projectIDlv = (Label)e.Item.FindControl("projectIDlv");
                Label employeeJobTypeIDlv = (Label)e.Item.FindControl("employeeJobTypeIDlv");
                Label designationIDlv = (Label)e.Item.FindControl("designationIDlv");
                Label employeeCodeLv = (Label)e.Item.FindControl("employeeCodeLv");
                Label lblSalaryLevel = (Label)e.Item.FindControl("lblSalaryLevel");
                TextBox txtConsolidateSalaryAmount = (TextBox)e.Item.FindControl("txtConsolidateSalaryAmount");
                TextBox txtWorkdays = (TextBox)e.Item.FindControl("txtWorkdays");
                TextBox txtNetPayable = (TextBox)e.Item.FindControl("txtNetPayable");
                TextBox txtNote = (TextBox)e.Item.FindControl("txtNote");
                TextBox txtCash = (TextBox)e.Item.FindControl("txtCash");
                TextBox txtBankAmount = (TextBox)e.Item.FindControl("txtBankAmount");
                TextBox txtSalaryPayable = (TextBox)e.Item.FindControl("txtSalaryPayable");
                TextBox txtAllowance = (TextBox)e.Item.FindControl("txtAllowance");
                TextBox txtProjectActual = (TextBox)e.Item.FindControl("txtProjectActual");
                TextBox txtBonus = (TextBox)e.Item.FindControl("txtBonus");
                TextBox txtPhoneCeiling = (TextBox)e.Item.FindControl("txtPhoneCeiling");
                TextBox txtPhoneActualBill = (TextBox)e.Item.FindControl("txtPhoneActualBill");
                TextBox txtPhoneBillAdjustment = (TextBox)e.Item.FindControl("txtPhoneBillAdjustment");
                TextBox txtProvidentFundDeductedAmount = (TextBox)e.Item.FindControl("txtProvidentFundDeductedAmount");
                TextBox txtPBR = (TextBox)e.Item.FindControl("txtPBR");
                TextBox txtEBR = (TextBox)e.Item.FindControl("txtEBR");
                TextBox txtPhoneBill = (TextBox)e.Item.FindControl("txtPhoneBill");
                TextBox txtREMARKS = (TextBox)e.Item.FindControl("txtREMARKS");
                Label lblStartDate = (Label)e.Item.FindControl("lblStartDate");
                Label lblEndDate = (Label)e.Item.FindControl("lblEndDate");
                TextBox txtTBR = (TextBox)e.Item.FindControl("txtTBR");
                Label lblServiceDays = (Label)e.Item.FindControl("lblServiceDays");
                TextBox txtTAX = (TextBox)e.Item.FindControl("txtTAX");
                //CheckBox chbxAddEBR = (CheckBox)e.Item.FindControl("chbxAddEBR");
                //chbxAddEBR.Checked = false;

                #endregion

                String remarks = String.Empty;
                Decimal phoneActualBill = 0;
                Decimal phoneCeiling = 0;
                Decimal phoneAdjustment = 0;
                Int64 fiscalYearID = MiscUtil.GetActiveFiscalYear();

                #region Salary Session

                MDSalarySessionEntity entity = FCCMDSalarySession.GetFacadeCreate().GetByID(OverviewEmployeeSalarySessionID);
                lblStartDate.Text = entity.SessionStartDate.ToString().Trim();
                lblEndDate.Text = entity.SessionEndDate.ToString().Trim();

                #endregion

                Int64 _employeeID = (Int64.Parse(employeeIDlv.Text));
                
                employeeNamelv.Text = employeeFirstNamelv.Text + " " + employeeMiddleNamelv.Text + " " + employeeLastNamelv.Text;

                #region Text Field Default Value

                txtAdjustment.Text = "0";
                txtAdvance.Text = "0";
                txtAIT.Text = "0";
                txtAllowance.Text = "0";
                txtBankAmount.Text = "0";
                txtBonus.Text = "0";
                txtCash.Text = "0";
               
                txtEBR.Text = "0";
                txtFine.Text = "0";
                txtMeals.Text ="0";
                txtNetPayable.Text = "0";
                txtNote.Text = "0";
                txtPBR.Text = "0";
                txtPhoneActualBill.Text = "0";
                txtPhoneBill.Text = "0";
                txtPhoneBillAdjustment.Text = "0";
                txtPhoneCeiling.Text = "0";
                txtProjectActual.Text = "0";
                txtProvidentFundDeductedAmount.Text = "0";
                //txtSalaryPayable.Text = "0";
                txtREMARKS.Text = String.Empty;
                txtTBR.Text = "0";
                txtTAX.Text = "0";
                //Decimal pfdeduct = 0;


                //if (chbxPFDeduct.Checked)
                //{
                //    pfdeduct = Decimal.Parse(txtConsolidateSalaryAmount.Text) * (Decimal).05;
                //    txtProvidentFundDeductedAmount.Text = (pfdeduct).ToString();
                //}

                txtSalaryPayable.Text = (Decimal.Parse(txtConsolidateSalaryAmount.Text) * Decimal.Parse(txtSalaryPayablePercent.Text)).ToString();

                
                #endregion

                #region PhoneBill

                String phoneBillAdjustmentFiltering = "EmployeeID = "+_employeeID+" and SalarySessionID = "+entity.SalarySessionID+"";
                IList<HREmployeePhoneBillAdjustmentEntity> hREmployeePhoneBillAdjustmentList = FCCHREmployeePhoneBillAdjustment.GetFacadeCreate().GetIL(null, null, String.Empty, phoneBillAdjustmentFiltering, DatabaseOperationType.LoadWithFilterExpression);

                if (hREmployeePhoneBillAdjustmentList != null && hREmployeePhoneBillAdjustmentList.Count > 0)
                {
                    remarks += hREmployeePhoneBillAdjustmentList[0].PhoneBillNote;
                    phoneActualBill = hREmployeePhoneBillAdjustmentList[0].PhoneBillAmount;
                }

                String allowanceFilter = "EmployeeID = " + _employeeID + " and FiscalYearID = "+fiscalYearID+" and AllowanceCategoryID = "+MasterDataConstants.MDAllowanceCategory.PHONE_BILL+"";
                IList<HREmployeeAllowanceEntity> hREmployeeAllowanceList = FCCHREmployeeAllowance.GetFacadeCreate().GetIL(null, null, String.Empty, allowanceFilter, DatabaseOperationType.LoadWithFilterExpression);

                if (hREmployeeAllowanceList != null && hREmployeeAllowanceList.Count > 0)
                {
                    phoneCeiling = hREmployeeAllowanceList[0].Amount;
                }

                #endregion

                #region Payment Status Dropdown

                MiscUtil.PopulateMDEmployeeSalaryPaymentStatus(ddlEmployeeSalaryPaymentStatusID, false);

                if (ddlEmployeeSalaryPaymentStatusID != null && ddlEmployeeSalaryPaymentStatusID.Items.Count > 0)
                {
                    ddlEmployeeSalaryPaymentStatusID.SelectedValue = "1";
                }

                #endregion

                #region Deduction

                String fe1 = "NextInstallMent <= NumberOfPayments";
                String fe2 = SqlExpressionBuilder.PrepareFilterExpression(HREmployeeSalaryDeducationInfoEntity.FLD_NAME_EmployeeID, _employeeID.ToString(), SQLMatchType.Equal);

                String fe = SqlExpressionBuilder.PrepareFilterExpression(fe1, SQLJoinType.AND, fe2);

                IList<HREmployeeSalaryDeducationInfoEntity> lst = FCCHREmployeeSalaryDeducationInfo.GetFacadeCreate().GetIL(null, null, String.Empty, fe, DatabaseOperationType.LoadWithFilterExpression);

                if (lst != null && lst.Count > 0)
                {
                    if (chbxAdvanceFilter.Checked)
                    {
                        txtAdvance.Text = (from s in lst
                                           where s.SalaryDeducationCategoryID == MasterDataConstants.MDSalaryDeducationCategory.ADVANCE
                                           select s.DeductionAmount / s.NumberOfPayments).Sum().ToString();
                        foreach (HREmployeeSalaryDeducationInfoEntity en in lst)
                        {
                            if (en.SalaryDeducationCategoryID == MasterDataConstants.MDSalaryDeducationCategory.ADVANCE)
                            {
                                remarks += ("- " + Math.Truncate((Decimal)en.NextInstallMent) + " /" +Math.Truncate(en.NumberOfPayments) + " Installment of " + Math.Truncate(en.DeductionAmount) + ". ");
                            }
                        }
                    }
                    
                    if (chbxFineFilter.Checked)
                    {
                        txtFine.Text = (from s in lst
                                        where s.SalaryDeducationCategoryID == MasterDataConstants.MDSalaryDeducationCategory.FINE
                                        select s.DeductionAmount / s.NumberOfPayments).Sum().ToString();
                        foreach (HREmployeeSalaryDeducationInfoEntity en in lst)
                        {
                            if (en.SalaryDeducationCategoryID == MasterDataConstants.MDSalaryDeducationCategory.FINE)
                            {
                                remarks += ("- " + Math.Truncate((Decimal)en.NextInstallMent) + " /" + Math.Truncate(en.NumberOfPayments) + " Installment of " + Math.Truncate(en.DeductionAmount) + ". ");
                            }
                        }
                    }

                    if (chbxAITFilter.Checked)
                    {
                        txtAIT.Text = (from s in lst
                                       where s.SalaryDeducationCategoryID == MasterDataConstants.MDSalaryDeducationCategory.AIT
                                       select s.DeductionAmount / s.NumberOfPayments).Sum().ToString();
                        foreach (HREmployeeSalaryDeducationInfoEntity en in lst)
                        {
                            if (en.SalaryDeducationCategoryID == MasterDataConstants.MDSalaryDeducationCategory.AIT)
                            {
                                remarks += ("- " + Math.Truncate((Decimal)en.NextInstallMent) + " /" + Math.Truncate(en.NumberOfPayments) + " Installment of " + Math.Truncate(en.DeductionAmount) + ". ");
                            }
                        }
                    }

                    if (chbxTAXFilter.Checked)
                    {
                        txtTAX.Text = (from s in lst
                                       where s.SalaryDeducationCategoryID == MasterDataConstants.MDSalaryDeducationCategory.TAX
                                       select s.DeductionAmount / s.NumberOfPayments).Sum().ToString();
                        foreach (HREmployeeSalaryDeducationInfoEntity en in lst)
                        {
                            if (en.SalaryDeducationCategoryID == MasterDataConstants.MDSalaryDeducationCategory.TAX)
                            {
                                remarks += ("- " + Math.Truncate((Decimal)en.NextInstallMent) + " /" + Math.Truncate(en.NumberOfPayments) + " Installment of " + Math.Truncate(en.DeductionAmount) + ". ");
                            }
                        }
                    }

                    if (chbxMealFilter.Checked)
                    {
                        txtMeals.Text = (from s in lst
                                       where s.SalaryDeducationCategoryID == MasterDataConstants.MDSalaryDeducationCategory.MEALS
                                       select s.DeductionAmount / s.NumberOfPayments).Sum().ToString();
                        foreach (HREmployeeSalaryDeducationInfoEntity en in lst)
                        {
                            if (en.SalaryDeducationCategoryID == MasterDataConstants.MDSalaryDeducationCategory.MEALS)
                            {
                                remarks += ("- " + Math.Truncate((Decimal)en.NextInstallMent) + " /" + Math.Truncate(en.NumberOfPayments) + " Installment of " + Math.Truncate(en.DeductionAmount) + ". ");
                            }
                        }
                    }
                }
                

                #endregion

                #region Adjustment

                String fe_adjustment1 = SqlExpressionBuilder.PrepareFilterExpression(HRSalaryAdjustmentEntity.FLD_NAME_SalarySessionID, OverviewEmployeeSalarySessionID.ToString(), SQLMatchType.Equal);
                String fe_adjustment2 = SqlExpressionBuilder.PrepareFilterExpression(HRSalaryAdjustmentEntity.FLD_NAME_EmployeeID, _employeeID.ToString(), SQLMatchType.Equal);

                String fe_adjustment = SqlExpressionBuilder.PrepareFilterExpression(fe_adjustment1, SQLJoinType.AND, fe_adjustment2);

                IList<HRSalaryAdjustmentEntity> lstadjustment = FCCHRSalaryAdjustment.GetFacadeCreate().GetIL(null, null, String.Empty, fe_adjustment, DatabaseOperationType.LoadWithFilterExpression);

                if (lstadjustment != null && lstadjustment.Count > 0)
                {
                    if (chbxAdjustmentFilter.Checked)
                    {
                        txtAdjustment.Text = (from s in lstadjustment
                                              select s.AdjustmentAmount).Sum().ToString();

                        foreach (HRSalaryAdjustmentEntity a in lstadjustment)
                        {
                            remarks += a.Remarks + " ";
                        }
                    }
                }
                

                #endregion

                #region Allowance 

                String allowance = "EmployeeID = " + _employeeID + " and FiscalYearID = " + fiscalYearID + " and AllowanceCategoryID = " + MasterDataConstants.MDAllowanceCategory.OTHER + "";
                IList<HREmployeeAllowanceEntity> allowanceList = FCCHREmployeeAllowance.GetFacadeCreate().GetIL(null, null, String.Empty, allowance, DatabaseOperationType.LoadWithFilterExpression);

                if (allowanceList != null && allowanceList.Count > 0)
                {
                    if (chbxAllowanceFilter.Checked)
                    {
                        txtAllowance.Text = (from s in allowanceList
                                             select s.Amount).Sum().ToString();

                        foreach (HREmployeeAllowanceEntity hreae in allowanceList)
                        {
                            remarks += hreae.Remarks + " ";
                        }
                    }
                }

                #endregion

                #region Time Sheet Remarks

                String remarksFilter = "SalarySessionID = " + OverviewEmployeeSalarySessionID + " and EmployeeID=" + _employeeID + "";
                IList<HREmployeeMonthlyTimeSheetSummaryEntity> listHREmployeeMonthlyTimeSheetSummary = FCCHREmployeeMonthlyTimeSheetSummary.GetFacadeCreate().GetIL(null, null, String.Empty, remarksFilter, DatabaseOperationType.LoadWithFilterExpression);
                if(listHREmployeeMonthlyTimeSheetSummary != null && listHREmployeeMonthlyTimeSheetSummary.Count > 0)
                {
                     remarks+= " "+listHREmployeeMonthlyTimeSheetSummary[0].REMARKS;
                }

                #endregion

                #region Phone Bill Adjustment

                phoneAdjustment = phoneCeiling - phoneActualBill;
                if (phoneAdjustment > 0)
                    phoneAdjustment = 0;
                txtREMARKS.Text = remarks;
                txtPhoneActualBill.Text = phoneActualBill.ToString().Trim();
                txtPhoneCeiling.Text = phoneCeiling.ToString().Trim();
                txtPhoneBillAdjustment.Text = (-phoneAdjustment).ToString().Trim();

                #endregion

                #region Calculate TBR

                if (Int64.Parse(lblSalaryLevel.Text) > 3)
                {
                    if (chbxTBRFilter.Checked)
                    {
                        txtTBR.Text = ((Decimal.Parse(txtConsolidateSalaryAmount.Text) * MasterDataConstants.HREvaluationCategoryPercent.TBR) / 100).ToString().Trim();
                    }
                }
                
                #endregion

                if (chbxBounusFilter.Checked)
                {
                    if (lblServiceDays.Text.IsNotNullOrEmpty())
                    {
                        if (Decimal.Parse(lblServiceDays.Text) >= 181)
                        {
                            txtBonus.Text = (Decimal.Floor(Decimal.Parse(txtConsolidateSalaryAmount.Text) * Decimal.Parse(txtBonusPercent.Text))).ToString();
                            remarks += " Eid bonus " + txtBonus.Text + " taka.";
                            txtREMARKS.Text = remarks;
                        }
                        else
                        {
                            txtBonus.Text = (Decimal.Floor(Decimal.Parse(txtConsolidateSalaryAmount.Text) * Decimal.Parse(txtBonusPercent.Text) / 181 * Decimal.Parse(lblServiceDays.Text))).ToString();
                            remarks += " Eid bonus " + txtBonus.Text + " taka.";
                            txtREMARKS.Text = remarks;
                        }
                    }

                    Decimal netPayable = 0;

                    netPayable = (Decimal.Parse(txtSalaryPayable.Text) - (Decimal.Parse(txtAdvance.Text) + Decimal.Parse(txtFine.Text) + Decimal.Parse(txtMeals.Text) + Decimal.Parse(txtAIT.Text) + Decimal.Parse(txtProvidentFundDeductedAmount.Text) + Decimal.Parse(txtTAX.Text)) - Decimal.Parse(txtAdjustment.Text) + Decimal.Parse(txtAllowance.Text) - Decimal.Parse(txtPhoneBillAdjustment.Text) + Decimal.Parse(txtBonus.Text));
                    txtNetPayable.Text =netPayable.ToString().Trim();

                    txtCash.Text = (Decimal.Parse(txtNetPayable.Text) - Decimal.Parse(txtSalaryPayable.Text)).ToString().Trim();
                    txtBankAmount.Text = (Decimal.Parse(txtNetPayable.Text) - Decimal.Parse(txtCash.Text)).ToString().Trim();

                    #region Calculate Cash and Bank

                    if (txtBankAmount.Text.IsNullOrEmpty() || Decimal.Parse(txtBankAmount.Text) == 0)
                    {
                        txtBankAmount.Text = txtNetPayable.Text;
                    }
                    else
                    {
                        if (Decimal.Parse(txtBankAmount.Text) == Decimal.Parse(txtNetPayable.Text))
                        {
                            txtCash.Text = "0";
                        }
                        else if (Decimal.Parse(txtBankAmount.Text) > Decimal.Parse(txtNetPayable.Text))
                        {
                            txtCash.Text = "0";
                            txtBankAmount.Text = txtNetPayable.Text;
                        }
                        else if (Decimal.Parse(txtBankAmount.Text) < Decimal.Parse(txtNetPayable.Text) && Decimal.Parse(txtConsolidateSalaryAmount.Text) < 40000)
                        {
                            txtBankAmount.Text = (Decimal.Parse(txtNetPayable.Text) - Decimal.Parse(txtCash.Text)).ToString().Trim();
                        }
                        else if (Decimal.Parse(txtBankAmount.Text) < Decimal.Parse(txtNetPayable.Text) && Decimal.Parse(txtConsolidateSalaryAmount.Text) >= 40000)
                        {
                            txtCash.Text = (Decimal.Parse(txtNetPayable.Text) - Decimal.Parse(txtBankAmount.Text)).ToString().Trim();
                        }
                    }

                    txtCash.Text = (Decimal.Parse(txtNetPayable.Text) - Decimal.Parse(txtBankAmount.Text)).ToString().Trim();

                    #endregion
                }
                else
                {
                    txtNetPayable.Text = (Decimal.Parse(txtSalaryPayable.Text) - (Decimal.Parse(txtAdvance.Text) + Decimal.Parse(txtFine.Text) + Decimal.Parse(txtMeals.Text) + Decimal.Parse(txtAIT.Text) + Decimal.Parse(txtProvidentFundDeductedAmount.Text) + Decimal.Parse(txtTAX.Text)) + Decimal.Parse(txtAdjustment.Text) + Decimal.Parse(txtAllowance.Text) - Decimal.Parse(txtPhoneBillAdjustment.Text) + Decimal.Parse(txtTBR.Text) + Decimal.Parse(txtEBR.Text)).ToString().Trim();

                    txtCash.Text = (Decimal.Parse(txtNetPayable.Text) - Decimal.Parse(txtSalaryPayable.Text)).ToString().Trim();
                    txtBankAmount.Text = (Decimal.Parse(txtNetPayable.Text) - Decimal.Parse(txtCash.Text)).ToString().Trim();

                    #region Calculate Cash and Bank

                    if (txtBankAmount.Text.IsNullOrEmpty() || Decimal.Parse(txtBankAmount.Text) == 0)
                    {
                        txtBankAmount.Text = txtNetPayable.Text;
                    }
                    else
                    {
                        if (Decimal.Parse(txtBankAmount.Text) == Decimal.Parse(txtNetPayable.Text))
                        {
                            txtCash.Text = "0";
                        }
                        else if (Decimal.Parse(txtBankAmount.Text) > Decimal.Parse(txtNetPayable.Text))
                        {
                            txtCash.Text = "0";
                            txtBankAmount.Text = txtNetPayable.Text;
                        }
                        else if (Decimal.Parse(txtBankAmount.Text) < Decimal.Parse(txtNetPayable.Text))
                        {
                            txtCash.Text = (Decimal.Parse(txtNetPayable.Text) - Decimal.Parse(txtBankAmount.Text)).ToString().Trim();
                        }
                    }

                    txtCash.Text = (Decimal.Parse(txtNetPayable.Text) - Decimal.Parse(txtBankAmount.Text)).ToString().Trim();

                    #endregion
                }
                

                btnSubmit.Text = "Save";
                //btnSubmit.Enabled = true;
                if (chbxRegenerate.Checked == false)
                {
                    #region CurrentHREmployeeSalaryPayment

                    String fe4 = SqlExpressionBuilder.PrepareFilterExpression(HREmployeeSalaryPaymentEntity.FLD_NAME_EmployeeID, _employeeID.ToString(), SQLMatchType.Equal);
                    String fe5 = SqlExpressionBuilder.PrepareFilterExpression(HREmployeeMonthlyTimeSheetSummaryEntity.FLD_NAME_SalarySessionID, OverviewEmployeeSalarySessionID.ToString(), SQLMatchType.Equal);
                    String fe6 = SqlExpressionBuilder.PrepareFilterExpression(fe4, SQLJoinType.AND, fe5);
                    IList<HREmployeeSalaryPaymentEntity> hREmployeeSalaryPaymentList = FCCHREmployeeSalaryPayment.GetFacadeCreate().GetIL(null, null, String.Empty, fe6, DatabaseOperationType.LoadWithFilterExpression);

                    if (hREmployeeSalaryPaymentList != null && hREmployeeSalaryPaymentList.Count > 0)
                    {
                        txtAdjustment.Text = hREmployeeSalaryPaymentList[0].Adjustment.ToString().Trim();
                        txtAdvance.Text = hREmployeeSalaryPaymentList[0].Advance.ToString().Trim();
                        txtAIT.Text = hREmployeeSalaryPaymentList[0].AIT.ToString().Trim();
                        txtAllowance.Text = hREmployeeSalaryPaymentList[0].Allowance.ToString().Trim();
                        txtBankAmount.Text = hREmployeeSalaryPaymentList[0].BankAmount.ToString().Trim();
                        txtBonus.Text = hREmployeeSalaryPaymentList[0].Bonus.ToString().Trim();
                        txtCash.Text = hREmployeeSalaryPaymentList[0].Cash.ToString().Trim();
                        txtConsolidateSalaryAmount.Text = hREmployeeSalaryPaymentList[0].ConsolidateSalaryAmount.ToString().Trim();
                        txtEBR.Text = hREmployeeSalaryPaymentList[0].EBR.ToString().Trim();
                        txtFine.Text = hREmployeeSalaryPaymentList[0].Fine.ToString().Trim();
                        txtMeals.Text = hREmployeeSalaryPaymentList[0].Meals.ToString().Trim();
                        txtNetPayable.Text = hREmployeeSalaryPaymentList[0].NetPayable.ToString().Trim();
                        txtNote.Text = hREmployeeSalaryPaymentList[0].Note.ToString().Trim();
                        txtPBR.Text = hREmployeeSalaryPaymentList[0].PBR.ToString().Trim();
                        txtPhoneActualBill.Text = hREmployeeSalaryPaymentList[0].PhoneActualBill.ToString().Trim();
                        txtPhoneBill.Text = hREmployeeSalaryPaymentList[0].PhoneBill.ToString().Trim();
                        txtPhoneBillAdjustment.Text = hREmployeeSalaryPaymentList[0].PhoneBillAdjustment.ToString().Trim();
                        txtPhoneCeiling.Text = hREmployeeSalaryPaymentList[0].PhoneCeiling.ToString().Trim();
                        txtProjectActual.Text = hREmployeeSalaryPaymentList[0].ProjectActual.ToString().Trim();
                        txtProvidentFundDeductedAmount.Text = hREmployeeSalaryPaymentList[0].ProvidentFundDeductedAmount.ToString().Trim();
                        txtSalaryPayable.Text = hREmployeeSalaryPaymentList[0].SalaryPayable.ToString().Trim();
                        txtWorkdays.Text = hREmployeeSalaryPaymentList[0].Workdays.ToString().Trim();
                        txtREMARKS.Text = hREmployeeSalaryPaymentList[0].Field2.ToString().Trim();
                        txtTBR.Text = hREmployeeSalaryPaymentList[0].TBR.ToString().Trim();
                        txtTAX.Text = hREmployeeSalaryPaymentList[0].TAX.ToString().Trim();

                        if (hREmployeeSalaryPaymentList[0].EBR > 0)
                        {
                            chbxAddEBR.Checked = true;
                        }
                        else
                        {
                            chbxAddEBR.Checked = false;
                        }

                        if (hREmployeeSalaryPaymentList[0].Advance > 0)
                        {
                            chbxAdvanceFilter.Checked = true;
                        }
                        else
                        {
                            chbxAdvanceFilter.Checked = false;
                        }

                        if (hREmployeeSalaryPaymentList[0].Fine > 0)
                        {
                            chbxFineFilter.Checked = true;
                        }
                        else
                        {
                            chbxFineFilter.Checked = false;
                        }

                        if (hREmployeeSalaryPaymentList[0].AIT > 0)
                        {
                            chbxAITFilter.Checked = true;
                        }
                        else
                        {
                            chbxAITFilter.Checked = false;
                        }

                        if (hREmployeeSalaryPaymentList[0].Meals > 0)
                        {
                            chbxMealFilter.Checked = true;
                        }
                        else
                        {
                            chbxMealFilter.Checked = false;
                        }

                        if (hREmployeeSalaryPaymentList[0].Adjustment > 0)
                        {
                            chbxAdjustmentFilter.Checked = true;
                        }
                        else
                        {
                            chbxAdjustmentFilter.Checked = false;
                        }

                        if (hREmployeeSalaryPaymentList[0].Allowance > 0)
                        {
                            chbxAllowanceFilter.Checked = true;
                        }
                        else
                        {
                            chbxAllowanceFilter.Checked = false;
                        }

                        if (hREmployeeSalaryPaymentList[0].EBR > 0)
                        {
                            chbxAddEBR.Checked = true;
                        }
                        else
                        {
                            chbxAddEBR.Checked = false;
                        }

                        if (hREmployeeSalaryPaymentList[0].TBR > 0)
                        {
                            chbxTBRFilter.Checked = true;
                        }
                        else
                        {
                            chbxTBRFilter.Checked = false;
                        }

                        if (hREmployeeSalaryPaymentList[0].ProvidentFundDeductedAmount > 0)
                        {
                            chbxPFDeduct.Checked = true;
                        }
                        else
                        {
                            chbxPFDeduct.Checked = false;
                        }

                        if (hREmployeeSalaryPaymentList[0].Bonus > 0)
                        {
                            chbxBounusFilter.Checked = true;
                        }
                        else
                        {
                            chbxBounusFilter.Checked = false;
                        }

                        if (hREmployeeSalaryPaymentList[0].TAX > 0)
                        {
                            chbxTAXFilter.Checked = true;
                        }
                        else
                        {
                            chbxTAXFilter.Checked = false;
                        }

                        if (hREmployeeSalaryPaymentList[0].EmployeeSalaryPaymentStatusID != null && ddlEmployeeSalaryPaymentStatusID.Items.Count > 0)
                        {
                            ddlEmployeeSalaryPaymentStatusID.SelectedValue = hREmployeeSalaryPaymentList[0].EmployeeSalaryPaymentStatusID.ToString();
                        }

                        btnSubmit.Text = "Update";
                        //btnSubmit.Enabled = true;
                    }

                    #endregion
                }
            }
        }

        protected void lvHREmployeeSalaryPayment_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            Int64 EmployeeSalaryPaymentID;

            Int64.TryParse(e.CommandArgument.ToString(), out EmployeeSalaryPaymentID);

            if (EmployeeSalaryPaymentID > 0)
            {
                if (string.Equals(e.CommandName, "EditItem"))
                {
                    _EmployeeSalaryPaymentID = EmployeeSalaryPaymentID;

                    PrepareEditView();

                    //cpeEditor.Collapsed = false;
                    //cpeEditor.ClientState = "false";
                }
                else if (string.Equals(e.CommandName, "DeleteItem"))
                {
                    try
                    {
                        Int64 result = -1;

                        String fe = SqlExpressionBuilder.PrepareFilterExpression(HREmployeeSalaryPaymentEntity.FLD_NAME_EmployeeSalaryPaymentID, EmployeeSalaryPaymentID.ToString(), SQLMatchType.Equal);
                        IList<HREmployeeSalaryPaymentEntity> list = FCCHREmployeeSalaryPayment.GetFacadeCreate().GetIL(null, null, String.Empty, fe, DatabaseOperationType.LoadWithFilterExpression);


                        String fe1 = "NextInstallMent <= NumberOfPayments";
                        String fe2 = SqlExpressionBuilder.PrepareFilterExpression(HREmployeeSalaryDeducationInfoEntity.FLD_NAME_EmployeeID, list[0].EmployeeID.ToString(), SQLMatchType.Equal);

                        String fe3 = SqlExpressionBuilder.PrepareFilterExpression(fe1, SQLJoinType.AND, fe2);
                        IList<HREmployeeSalaryDeducationInfoEntity> lst = FCCHREmployeeSalaryDeducationInfo.GetFacadeCreate().GetIL(null, null, String.Empty, fe3, DatabaseOperationType.LoadWithFilterExpression);
                        if (lst != null && lst.Count > 0)
                        {
                            foreach (HREmployeeSalaryDeducationInfoEntity entity in lst)
                            {
                                if ((entity.SalaryDeducationCategoryID == MasterDataConstants.MDSalaryDeducationCategory.ADVANCE && list[0].Advance > 0) || (entity.SalaryDeducationCategoryID == MasterDataConstants.MDSalaryDeducationCategory.FINE && list[0].Fine > 0) || (entity.SalaryDeducationCategoryID == MasterDataConstants.MDSalaryDeducationCategory.AIT && list[0].AIT > 0))
                                {
                                    String filter = "EmployeeSalaryDeducationInfoID =" + entity.EmployeeSalaryDeducationInfoID + "";
                                    entity.NextInstallMent = entity.NextInstallMent - 1;
                                    FCCHREmployeeSalaryDeducationInfo.GetFacadeCreate().Update(entity, filter, DatabaseOperationType.Update, TransactionRequired.No);
                                }
                            }

                        }

                        HREmployeeSalaryPaymentEntity hREmployeeSalaryPaymentEntity = new HREmployeeSalaryPaymentEntity();


                        result = FCCHREmployeeSalaryPayment.GetFacadeCreate().Delete(hREmployeeSalaryPaymentEntity, fe, DatabaseOperationType.Delete, TransactionRequired.No);

                        if (result == 0)
                        {
                            _EmployeeSalaryPaymentID = 0;
                            _HREmployeeSalaryPaymentEntity = new HREmployeeSalaryPaymentEntity();
                            PrepareInitialView();
                            BindHREmployeeSalaryPaymentList();

                            MiscUtil.ShowMessage(lblMessage, "Employee Salary Payment has been successfully deleted.", true);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to delete Employee Salary Payment.", true);
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

        protected void odsHREmployeeSalaryPayment_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {
            //if (e.ExecutingSelectCount == true )
            //{
            //    UpdateHREmployeeSalaryPayment();
            //}
            String fe = SqlExpressionBuilder.PrepareFilterExpression("MDSalarySession.SalarySessionID", OverviewEmployeeSalarySessionID.ToString(), SQLMatchType.Equal);

            if (ddlDepartmentID.SelectedValue == "1")
            {
                String fe2 = "(HREmployee.DepartmentID is null or HREmployee.DepartmentID <> "+MasterDataConstants.MDDepartment.SECURITY_DEPARTMENTID+")";
                fe = SqlExpressionBuilder.PrepareFilterExpression(fe, SQLJoinType.AND, fe2);
            }
            else
            {
                String fe3 = "(HREmployee.DepartmentID = " + MasterDataConstants.MDDepartment.SECURITY_DEPARTMENTID + ")";
                fe = SqlExpressionBuilder.PrepareFilterExpression(fe, SQLJoinType.AND, fe3);
            }

            if (chbxFilter.Checked)
            {
                String fe4 = SqlExpressionBuilder.PrepareFilterExpression("HREmployee."+HRMonthlySalaryPayment_CustomEntity.FLD_NAME_EmployeeCode, txtSearchText.Text.ToString(), SQLMatchType.LikeWithBothMath);
                fe = SqlExpressionBuilder.PrepareFilterExpression(fe, SQLJoinType.AND, fe4);
            }
            e.InputParameters["filterExpression"] = fe;
        }

        #endregion

        #region Button Event

        protected void btnSave_Click(object sender, EventArgs e)
         {
            //SaveHREmployeeSalaryPaymentEntity();
            UpdateHREmployeeSalaryPayment();
        }

        protected void btnAddNew_Click(object sender, EventArgs e)
        {
            _EmployeeSalaryPaymentID = 0;
            _HREmployeeSalaryPaymentEntity = new HREmployeeSalaryPaymentEntity();
            PrepareInitialView();
        }

        protected void btnClear_Click(object sender, EventArgs e)
        {
            PrepareInitialView();
            PrepareEditView();
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            DeleteAllCurrentData();
        }

        protected void btnCalculate_Click(object sender, EventArgs e)
        {
            CalculateNetPayableBankAndCash();
        }

        protected void btnGenerate_Click(object sender, EventArgs e)
        {
            GenerateAll();
            BindList();
        }

        #endregion

        #region Check Filter Event

        protected void chbxFilter_CheckedChanged(object sender, EventArgs e)
        {
            BindList();
        }

        protected void chbxAddEBR_CheckedChanged(object sender, EventArgs e)
        {
            Decimal i = CalculateEBRTextBox();
            //BindList();
        }

        protected void chbxAdvanceFilter_CheckedChanged(object sender, EventArgs e)
        {
            BindList();
        }

        protected void chbxBounusFilter_CheckedChanged(object sender, EventArgs e)
        {
            CalculateBonus();
            CalculateNetPayableBankAndCash();
        }

        protected void chbxTBRFilter_CheckedChanged(object sender, EventArgs e)
        {
            BindList();
        }

        protected void chbxFineFilter_CheckedChanged(object sender, EventArgs e)
        {
            BindList();
        }

        protected void chbxMealFilter_CheckedChanged(object sender, EventArgs e)
        {
            BindList();
        }

        protected void chbxAITFilter_CheckedChanged(object sender, EventArgs e)
        {
            BindList();
        }

        protected void chbxAdjustmentFilter_CheckedChanged(object sender, EventArgs e)
        {
            BindList();
        }

        protected void chbxAllowanceFilter_CheckedChanged(object sender, EventArgs e)
        {
            BindList();
        }

        protected void chbxRegenerate_CheckedChanged(object sender, EventArgs e)
        {
            BindList();
        }

        protected void chbxPFDeduct_CheckedChanged(object sender, EventArgs e)
        {
            ProvidentFundDeduct();
        }

        protected void chbxTAXFilter_CheckedChanged(object sender, EventArgs e)
        {
            BindList();
        }

        #endregion

        #region Dropdwon Event

        protected void ddlDepartmentID_SelectedIndexChanged(object sender, EventArgs e)
        {
            BindList();
        }

        #endregion

        #endregion Event
    }
}
