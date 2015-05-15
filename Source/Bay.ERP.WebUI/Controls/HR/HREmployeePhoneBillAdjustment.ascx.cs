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

using Bay.ERP.Web.UI.Helper;
using Bay.ERP.Common.BusinessEntities;
using Bay.ERP.BusinessFacade;
using Bay.ERP.FacadeCreator.FacadeContext;
using Bay.ERP.Common.Helper;
using Bay.ERP.Common.Shared;

namespace Bay.ERP.Web.UI
{
    public partial class HREmployeePhoneBillAdjustmentControl : BaseControl
    {
        #region Properties

        public Int64 _PhoneBillAdjustmentID
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

        public HREmployeePhoneBillAdjustmentEntity _HREmployeePhoneBillAdjustmentEntity
        {
            get
            {
                HREmployeePhoneBillAdjustmentEntity entity = new HREmployeePhoneBillAdjustmentEntity();

                if (ViewState["CurrentEntity"] != null)
                {
                    entity = (HREmployeePhoneBillAdjustmentEntity)ViewState["CurrentEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["CurrentEntity"] = value;
            }
        }

        private HREmployeePhoneBillAdjustmentEntity CurrentHREmployeePhoneBillAdjustmentEntity
        {
            get
            {
                if (_PhoneBillAdjustmentID > 0)
                {
                    if (_HREmployeePhoneBillAdjustmentEntity.PhoneBillAdjustmentID != _PhoneBillAdjustmentID)
                    {
                        _HREmployeePhoneBillAdjustmentEntity = FCCHREmployeePhoneBillAdjustment.GetFacadeCreate().GetByID(_PhoneBillAdjustmentID);
                    }
                }

                return _HREmployeePhoneBillAdjustmentEntity;
            }
            set
            {
                _HREmployeePhoneBillAdjustmentEntity = value;
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
            IList<HREmployee_DetailedEntity> list = FCCHREmployee_Detailed.GetFacadeCreate().GetIL(1000, 1, String.Empty, String.Empty);

            HREmployee_DetailedEntity ent = list.Single(x => x.EmployeeID == employeeID);


            return ent;
        }

        private void PrepareInitialView()
        {
            BuildDropDownList();

        }

        private void BuildHREmployeePhoneBillAdjustment()
        {
            try
            {
                IList<ListViewDataItem> list = lvHREmployeeAllowanceCustom_Detailed.Items;

                if (list != null && list.Count > 0)
                {

                    foreach (ListViewDataItem lvdi in list)
                    {

                        TextBox txtEmployeeName = (TextBox)lvdi.FindControl("txtEmployeeName");
                        TextBox txtDesignation = (TextBox)lvdi.FindControl("txtDesignation");
                        TextBox txtEmployeeJobTypeID = (TextBox)lvdi.FindControl("txtEmployeeJobTypeID");
                        TextBox txtSalaryLevel = (TextBox)lvdi.FindControl("txtSalaryLevel");
                        TextBox txtPhoneBillAmount = (TextBox)lvdi.FindControl("txtPhoneBillAmount");
                        TextBox txtPhoneBillNote = (TextBox)lvdi.FindControl("txtPhoneBillNote");
                        Label employeeIDlv = (Label)lvdi.FindControl("employeeIDlv");
                        String remarks = String.Empty;
                        Int64 employeeID = (Int64.Parse(employeeIDlv.Text));

                        txtPhoneBillNote.Text = String.Empty;
                        txtPhoneBillAmount.Text = String.Empty;

                        btnSubmit.Text = "Save";

                        #region CurrentEmployeeMonthlyTimeSheetSummaryInfo
                        String fe4 = SqlExpressionBuilder.PrepareFilterExpression(HREmployeePhoneBillAdjustmentEntity.FLD_NAME_EmployeeID, employeeID.ToString(), SQLMatchType.Equal);
                        String fe5 = SqlExpressionBuilder.PrepareFilterExpression(HREmployeePhoneBillAdjustmentEntity.FLD_NAME_SalarySessionID, (Int64.Parse(ddlSalarySessionID.SelectedValue)).ToString(), SQLMatchType.Equal);
                        String fe6 = SqlExpressionBuilder.PrepareFilterExpression(fe4, SQLJoinType.AND, fe5);
                        IList<HREmployeePhoneBillAdjustmentEntity> hREmployeePhoneBillAdjustmentEntitylist = FCCHREmployeePhoneBillAdjustment.GetFacadeCreate().GetIL(null, null, String.Empty, fe6, DatabaseOperationType.LoadWithFilterExpression);
                        if (hREmployeePhoneBillAdjustmentEntitylist != null && hREmployeePhoneBillAdjustmentEntitylist.Count > 0)
                        {
                            txtPhoneBillAmount.Text = hREmployeePhoneBillAdjustmentEntitylist[0].PhoneBillAmount.ToString().Trim();
                            txtPhoneBillNote.Text = hREmployeePhoneBillAdjustmentEntitylist[0].PhoneBillNote.ToString().Trim();

                            btnSubmit.Text = "Update";
                        }

                        #endregion
                    }
                }
            }
            catch (Exception ex)
            {
                MiscUtil.ShowMessage(lblMessage, "Failed to Employee Monthly Time Sheet Summary Information.", true);
            }

        }



        private void UpdateHREmployeePhoneBillAdjustment()
        {
            try
            {
                IList<ListViewDataItem> list = lvHREmployeeAllowanceCustom_Detailed.Items;

                if (list != null && list.Count > 0)
                {
                    Int32 tempDataItemIndex = 0;

                    foreach (ListViewDataItem lvdi in list)
                    {
                        DataKey currentDataKey = lvHREmployeeAllowanceCustom_Detailed.DataKeys[tempDataItemIndex++];
                        Int64 _employeeID = (Int64)currentDataKey["EmployeeID"];

                        Boolean isSaveFlag = true;

                        String fe1 = SqlExpressionBuilder.PrepareFilterExpression(HREmployeePhoneBillAdjustmentEntity.FLD_NAME_EmployeeID, _employeeID.ToString(), SQLMatchType.Equal);
                        String fe2 = SqlExpressionBuilder.PrepareFilterExpression(HREmployeePhoneBillAdjustmentEntity.FLD_NAME_SalarySessionID, ddlSalarySessionID.SelectedValue.ToString(), SQLMatchType.Equal);
                        String fe = SqlExpressionBuilder.PrepareFilterExpression(fe1, SQLJoinType.AND, fe2);

                        IList<HREmployeePhoneBillAdjustmentEntity> lstHREmployeePhoneBillAdjustment = FCCHREmployeePhoneBillAdjustment.GetFacadeCreate().GetIL(null, null, String.Empty, fe, DatabaseOperationType.LoadWithFilterExpression);

                        if (lstHREmployeePhoneBillAdjustment != null && lstHREmployeePhoneBillAdjustment.Count > 0)
                        {
                            isSaveFlag = false;
                        }


                        //String fe = SqlExpressionBuilder.PrepareFilterExpression(HREmployeeMonthlyTimeSheetSummaryEntity.em)
                        HREmployee_DetailedEntity employeeEntity = GetHREmployeeInfo(_employeeID);

                        TextBox txtEmployeeName = (TextBox)lvdi.FindControl("txtEmployeeName");
                        TextBox txtDesignation = (TextBox)lvdi.FindControl("txtDesignation");
                        TextBox txtEmployeeJobTypeID = (TextBox)lvdi.FindControl("txtEmployeeJobTypeID");
                        TextBox txtSalaryLevel = (TextBox)lvdi.FindControl("txtSalaryLevel");
                        TextBox txtPhoneBillAmount = (TextBox)lvdi.FindControl("txtPhoneBillAmount");
                        TextBox txtPhoneBillNote = (TextBox)lvdi.FindControl("txtPhoneBillNote");
                        TextBox txtPhoneAllowance = (TextBox)lvdi.FindControl("txtPhoneAllowance");
                        String remarks= String.Empty;

                        Decimal a = 0;
                        a = Decimal.Parse(txtPhoneBillAmount.Text) - Decimal.Parse(txtPhoneAllowance.Text);
                        if (a <= 0) a = 0;

                        txtPhoneBillNote.Text = "Actual Bill - Phone Ceiling: " + txtPhoneBillAmount.Text + "-" + txtPhoneAllowance.Text + " = " + a + " TK Deducted.";
                        

                        HREmployeePhoneBillAdjustmentEntity hREmployeePhoneBillAdjustmentEntity = new HREmployeePhoneBillAdjustmentEntity();

                        hREmployeePhoneBillAdjustmentEntity.EmployeeID = employeeEntity.EmployeeID;
                        hREmployeePhoneBillAdjustmentEntity.SalarySessionID = Int64.Parse(ddlSalarySessionID.SelectedValue);
                        hREmployeePhoneBillAdjustmentEntity.PhoneBillAmount = Decimal.Parse(txtPhoneBillAmount.Text);
                        hREmployeePhoneBillAdjustmentEntity.PhoneBillNote = txtPhoneBillNote.Text;
                        hREmployeePhoneBillAdjustmentEntity.IsRemoved = false;


                        if (isSaveFlag)
                        {
                            FCCHREmployeePhoneBillAdjustment.GetFacadeCreate().Add(hREmployeePhoneBillAdjustmentEntity, DatabaseOperationType.Add, TransactionRequired.No);
                            MiscUtil.ShowMessage(lblMessage, "Employee phone adjustment Information has been saved successfully.", false);
                        }
                        else
                        {
                            String filterExpression = SqlExpressionBuilder.PrepareFilterExpression(HREmployeePhoneBillAdjustmentEntity.FLD_NAME_PhoneBillAdjustmentID, lstHREmployeePhoneBillAdjustment[0].PhoneBillAdjustmentID.ToString(), SQLMatchType.Equal);
                            FCCHREmployeePhoneBillAdjustment.GetFacadeCreate().Update(hREmployeePhoneBillAdjustmentEntity, filterExpression, DatabaseOperationType.Update, TransactionRequired.No);
                            MiscUtil.ShowMessage(lblMessage, "Employee phone adjustment Information has been updated successfully.", false);
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

       

        private void BindList()
        {
            BindHREmployeeMonthlyTimeSheetSummaryList();
        }

        private void BindHREmployeeMonthlyTimeSheetSummaryList()
        {
            lvHREmployeeAllowanceCustom_Detailed.DataBind();
        }


        private void DeleteAllCurrentData()
        {
            try
            {
                Int64 result = -1;

                String fe = SqlExpressionBuilder.PrepareFilterExpression(HREmployeeMonthlyTimeSheetSummaryEntity.FLD_NAME_SalarySessionID, (Int64.Parse(ddlSalarySessionID.SelectedValue)).ToString(), SQLMatchType.Equal);

                HREmployeePhoneBillAdjustmentEntity hREmployeePhoneBillAdjustmentEntity = new HREmployeePhoneBillAdjustmentEntity();


                result = FCCHREmployeePhoneBillAdjustment.GetFacadeCreate().Delete(hREmployeePhoneBillAdjustmentEntity, fe, DatabaseOperationType.Delete, TransactionRequired.No);

                if (result == 0)
                {
                    _PhoneBillAdjustmentID= 0;
                    _HREmployeePhoneBillAdjustmentEntity = new HREmployeePhoneBillAdjustmentEntity();
                    PrepareInitialView();

                    MiscUtil.ShowMessage(lblMessage, "Phone Bill Adjustment has been successfully deleted.", true);
                }
                else
                {
                    MiscUtil.ShowMessage(lblMessage, "Failed to delete Phone Bill Adjustment.", true);
                }
            }
            catch (Exception ex)
            {
                MiscUtil.ShowMessage(lblMessage, ex.Message, true);
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
                
                GetSalarySessionStartDateAndEndDate(Int64.Parse(ddlSalarySessionID.SelectedValue));
            }
        }

        #endregion

        #region List View Event

        protected void lvHREmployeeAllowanceCustom_Detailed_ItemDataBound(object sender, ListViewItemEventArgs e)
        {
            if (e.Item.ItemType == ListViewItemType.DataItem)
            {
                ListViewDataItem dataItem = (ListViewDataItem)e.Item;

                HREmployee_DetailedEntity ent = new HREmployee_DetailedEntity();

                TextBox txtEmployeeName = (TextBox)e.Item.FindControl("txtEmployeeName");
                TextBox txtDesignation = (TextBox)e.Item.FindControl("txtDesignation");
                TextBox txtEmployeeJobTypeID = (TextBox)e.Item.FindControl("txtEmployeeJobTypeID");
                TextBox txtSalaryLevel = (TextBox)e.Item.FindControl("txtSalaryLevel");
                TextBox txtPhoneBillAmount = (TextBox)e.Item.FindControl("txtPhoneBillAmount");
                TextBox txtPhoneBillNote = (TextBox)e.Item.FindControl("txtPhoneBillNote");
                Label employeeIDlv = (Label)e.Item.FindControl("employeeIDlv");
                String remarks = String.Empty;
                Int64 employeeID = (Int64.Parse(employeeIDlv.Text));

                

                btnSubmit.Text = "Save";

                #region CurrentEmployeeMonthlyTimeSheetSummaryInfo
                String fe4 = SqlExpressionBuilder.PrepareFilterExpression(HREmployeePhoneBillAdjustmentEntity.FLD_NAME_EmployeeID, employeeID.ToString(), SQLMatchType.Equal);
                String fe5 = SqlExpressionBuilder.PrepareFilterExpression(HREmployeePhoneBillAdjustmentEntity.FLD_NAME_SalarySessionID, (Int64.Parse(ddlSalarySessionID.SelectedValue)).ToString(), SQLMatchType.Equal);
                String fe6 = SqlExpressionBuilder.PrepareFilterExpression(fe4, SQLJoinType.AND, fe5);
                IList<HREmployeePhoneBillAdjustmentEntity> hREmployeePhoneBillAdjustmentEntitylist = FCCHREmployeePhoneBillAdjustment.GetFacadeCreate().GetIL(null, null, String.Empty, fe6, DatabaseOperationType.LoadWithFilterExpression);
                if (hREmployeePhoneBillAdjustmentEntitylist != null && hREmployeePhoneBillAdjustmentEntitylist.Count > 0)
                {
                    txtPhoneBillAmount.Text = hREmployeePhoneBillAdjustmentEntitylist[0].PhoneBillAmount.ToString().Trim();
                    txtPhoneBillNote.Text = hREmployeePhoneBillAdjustmentEntitylist[0].PhoneBillNote.ToString().Trim();

                    btnSubmit.Text = "Update";
                }

                #endregion
               

            }

        }

        protected void lvHREmployeeAllowanceCustom_Detailed_ItemCommand(object sender, ListViewCommandEventArgs e)
        {

        }

        #endregion List View Event

        #region ObjectDataSource Event

        protected void odsHREmployeeAllowanceCustom_DetailedDataSource_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {
            Int64 fiscalYearID = MiscUtil.GetActiveFiscalYear();
            //String fe = SqlExpressionBuilder.PrepareFilterExpression("HREmployee." + HREmployee_DetailedEntity.FLD_NAME_EmploymentStatusID, employmentStatusID.ToString(), SQLMatchType.Equal);
            String fe = "HREmployeeAllowance.AllowanceCategoryID = 1 and HREmployeeAllowance.FiscalYearID = " + fiscalYearID + "";

            Boolean isExecutingSelectCount = false;
            if (chbxFilter.Checked)
            {
                fe = SqlExpressionBuilder.PrepareFilterExpression(HREmployee_DetailedEntity.FLD_NAME_EmployeeCode, txtSearchText.Text.ToString(), SQLMatchType.Equal);
                isExecutingSelectCount = false;
            }
            if (e.ExecutingSelectCount == isExecutingSelectCount)
            {
                UpdateHREmployeePhoneBillAdjustment();
            }

            e.InputParameters["filterExpression"] = fe;
        }

        #endregion

        #region Button Event

        protected void btnSave_Click(object sender, EventArgs e)
        {
            //SaveHREmployeeMonthlyTimeSheetSummaryEntity();
            UpdateHREmployeePhoneBillAdjustment();
        }

        protected void btnAddNew_Click(object sender, EventArgs e)
        {
            //_EmployeeMonthlyTimeSheetID = 0;
            //_HREmployeeMonthlyTimeSheetSummaryEntity = new HREmployeeMonthlyTimeSheetSummaryEntity();
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

        #endregion

        #region Dropdwon Event

        protected void ddlSalarySessionID_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetSalarySessionStartDateAndEndDate(Int64.Parse(ddlSalarySessionID.SelectedValue));
            BuildHREmployeePhoneBillAdjustment();
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
