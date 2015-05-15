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
    public partial class HRSalaryAdjustmentOperationControl : BaseControl
    {       
        #region Properties

        public Int64 _SalaryAdjustmentID
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

        public HRSalaryAdjustmentEntity _HRSalaryAdjustmentEntity
        {
            get
            {
                HRSalaryAdjustmentEntity entity = new HRSalaryAdjustmentEntity();

                if (ViewState["CurrentEntity"] != null)
                {
                    entity = (HRSalaryAdjustmentEntity)ViewState["CurrentEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["CurrentEntity"] = value;
            }
        }

        private HRSalaryAdjustmentEntity CurrentHRSalaryAdjustmentEntity
        {
            get
            {
                if (_SalaryAdjustmentID > 0)
                {
                    if (_HRSalaryAdjustmentEntity.SalaryAdjustmentID != _SalaryAdjustmentID)
                    {
                        _HRSalaryAdjustmentEntity = FCCHRSalaryAdjustment.GetFacadeCreate().GetByID(_SalaryAdjustmentID);
                    }
                }

                return _HRSalaryAdjustmentEntity;
            }
            set
            {
                _HRSalaryAdjustmentEntity = value;
            }
        }

        #endregion

        #region Methods

        private void BuildDropDownList()
        {
            MiscUtil.PopulateACFiscalYear(ddlFiscalYearID, false);
            MiscUtil.PopulateMDSalarySession(ddlSalarySessionID, false);
            MiscUtil.PopulateHREmployee(ddlEmployeeID, false);
            MiscUtil.PopulateMDDesignation(ddlDesignationID, true);
        }

        private HREmployee_DetailedEntity GetHREmployeeInfo(Int64 employeeID)
        {
            HREmployee_DetailedEntity ent = null;
            String fe = "HREmployee.EmployeeID =" + employeeID + ""; 
            IList<HREmployee_DetailedEntity> list = FCCHREmployee_Detailed.GetFacadeCreate().GetIL(1000, 1, String.Empty, fe);

            if (list != null && list.Count > 0)
            {
                ent = list.Single(x => x.EmployeeID == employeeID);
            }

            return ent;
        }

        private void PrepareValidator()
        {
        }

        private void PrepareInitialView()
        {
            BuildDropDownList();

            txtSalaryLevel.Text = String.Empty;
            txtEmployeeCode.Text = String.Empty;
            txtEmployeeJobTypeID.Text = String.Empty;
            txtAdjustmentAmount.Text = String.Empty;
            txtRemarks.Text = String.Empty;

            btnSubmit.Text = "Add";
            btnAddNew.Visible = false;
        }

        private void BuildEmployeeInformation(Int64 employeeID)
        {
            HREmployee_DetailedEntity ent = GetHREmployeeInfo(employeeID);
            txtEmployeeCode.Text = ent.EmployeeCode.ToString();
            txtSalaryLevel.Text = ent.SalaryLevel.ToString();
            txtEmployeeJobTypeID.Text = ent.EmployeeJobTypeID.ToString();
            MiscUtil.PopulateMDDesignationByEmployeeID(ddlDesignationID, false, employeeID);
        }

        private void PrepareEditView()
        {
            HRSalaryAdjustmentEntity hRSalaryAdjustmentEntity = CurrentHRSalaryAdjustmentEntity;


            if (!hRSalaryAdjustmentEntity.IsNew)
            {
                //txtSalaryAdjustmentID.Text = hRSalaryAdjustmentEntity.SalaryAdjustmentID.ToString();
                if (ddlFiscalYearID.Items.Count > 0 && hRSalaryAdjustmentEntity.FiscalYearID != null)
                {
                    ddlFiscalYearID.SelectedValue = hRSalaryAdjustmentEntity.FiscalYearID.ToString();
                }

                if (ddlSalarySessionID.Items.Count > 0 && hRSalaryAdjustmentEntity.SalarySessionID != null)
                {
                    ddlSalarySessionID.SelectedValue = hRSalaryAdjustmentEntity.SalarySessionID.ToString();
                }

                if (ddlEmployeeID.Items.Count > 0 && hRSalaryAdjustmentEntity.EmployeeID != null)
                {
                    ddlEmployeeID.SelectedValue = hRSalaryAdjustmentEntity.EmployeeID.ToString();
                }

                txtSalaryLevel.Text = hRSalaryAdjustmentEntity.SalaryLevel.ToString();
                if (hRSalaryAdjustmentEntity.DesignationID != null && ddlDesignationID.Items.Count > 0 )
                {
                    ddlDesignationID.SelectedValue = hRSalaryAdjustmentEntity.DesignationID.ToString();
                }

                txtEmployeeCode.Text = hRSalaryAdjustmentEntity.EmployeeCode.ToString();
                txtEmployeeJobTypeID.Text = hRSalaryAdjustmentEntity.EmployeeJobTypeID.ToString();
                txtAdjustmentAmount.Text = hRSalaryAdjustmentEntity.AdjustmentAmount.ToString();
                txtRemarks.Text = hRSalaryAdjustmentEntity.Remarks.ToString();

                btnSubmit.Text = "Update";
                btnAddNew.Visible = true;
            }
        }

        private void BindList()
        {
            BindHRSalaryAdjustmentList();
        }

        private void BindHRSalaryAdjustmentList()
        {
            lvHRSalaryAdjustment.DataBind();
        }

        private HRSalaryAdjustmentEntity BuildHRSalaryAdjustmentEntity()
        {
            HRSalaryAdjustmentEntity hRSalaryAdjustmentEntity = CurrentHRSalaryAdjustmentEntity;

            //if (!txtSalaryAdjustmentID.Text.Trim().IsNullOrEmpty())
            //{
            //    hRSalaryAdjustmentEntity.SalaryAdjustmentID = Int64.Parse(txtSalaryAdjustmentID.Text.Trim());
            //}

            if (ddlFiscalYearID.Items.Count > 0)
            {
                if (ddlFiscalYearID.SelectedValue == "0")
                {
                }
                else
                {
                    hRSalaryAdjustmentEntity.FiscalYearID = Int64.Parse(ddlFiscalYearID.SelectedValue);
                }
            }

            if (ddlSalarySessionID.Items.Count > 0)
            {
                if (ddlSalarySessionID.SelectedValue == "0")
                {
                }
                else
                {
                    hRSalaryAdjustmentEntity.SalarySessionID = Int64.Parse(ddlSalarySessionID.SelectedValue);
                }
            }

            if (ddlEmployeeID.Items.Count > 0)
            {
                if (ddlEmployeeID.SelectedValue == "0")
                {
                }
                else
                {
                    hRSalaryAdjustmentEntity.EmployeeID = Int64.Parse(ddlEmployeeID.SelectedValue);
                }
            }

            if (!txtSalaryLevel.Text.Trim().IsNullOrEmpty())
            {
                hRSalaryAdjustmentEntity.SalaryLevel = Int32.Parse(txtSalaryLevel.Text.Trim());
            }
            else
            {
                hRSalaryAdjustmentEntity.SalaryLevel = null;
            }

            if (ddlDesignationID.Items.Count > 0)
            {
                if (ddlDesignationID.SelectedValue == "0")
                {
                    hRSalaryAdjustmentEntity.DesignationID = null;
                }
                else
                {
                    hRSalaryAdjustmentEntity.DesignationID = Int64.Parse(ddlDesignationID.SelectedValue);
                }
            }

            hRSalaryAdjustmentEntity.EmployeeCode = txtEmployeeCode.Text.Trim();
            if (!txtEmployeeJobTypeID.Text.Trim().IsNullOrEmpty())
            {
                hRSalaryAdjustmentEntity.EmployeeJobTypeID = Int64.Parse(txtEmployeeJobTypeID.Text.Trim());
            }

            if (!txtAdjustmentAmount.Text.Trim().IsNullOrEmpty())
            {
                hRSalaryAdjustmentEntity.AdjustmentAmount = Decimal.Parse(txtAdjustmentAmount.Text.Trim());
            }

            hRSalaryAdjustmentEntity.Remarks = txtRemarks.Text;

            return hRSalaryAdjustmentEntity;
        }

        private void SaveHRSalaryAdjustmentEntity()
        {
            if (IsValid)
            {
                try
                {
                    HRSalaryAdjustmentEntity hRSalaryAdjustmentEntity = BuildHRSalaryAdjustmentEntity();

                    Int64 result = -1;

                    if (hRSalaryAdjustmentEntity.IsNew)
                    {
                        result = FCCHRSalaryAdjustment.GetFacadeCreate().Add(hRSalaryAdjustmentEntity, DatabaseOperationType.Add, TransactionRequired.No);
                    }
                    else
                    {
                        String filterExpression = SqlExpressionBuilder.PrepareFilterExpression(HRSalaryAdjustmentEntity.FLD_NAME_SalaryAdjustmentID, hRSalaryAdjustmentEntity.SalaryAdjustmentID.ToString(), SQLMatchType.Equal);
                        result = FCCHRSalaryAdjustment.GetFacadeCreate().Update(hRSalaryAdjustmentEntity, filterExpression, DatabaseOperationType.Update, TransactionRequired.No);
                    }

                    if (result > 0)
                    {
                        _SalaryAdjustmentID = 0;
                        _HRSalaryAdjustmentEntity = new HRSalaryAdjustmentEntity();
                        PrepareInitialView();
                        BindHRSalaryAdjustmentList();

                        if (hRSalaryAdjustmentEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Salary Adjustment Information has been added successfully.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Salary Adjustment Information has been updated successfully.", false);
                        }
                    }
                    else
                    {
                        if (hRSalaryAdjustmentEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to add Salary Adjustment Information.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to update Salary Adjustment Information.", false);
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
                BuildEmployeeInformation(Int64.Parse(ddlEmployeeID.SelectedValue));
            }
        }

        #endregion

        #region List View Event

        protected void lvHRSalaryAdjustment_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            Int64 SalaryAdjustmentID;

            Int64.TryParse(e.CommandArgument.ToString(), out SalaryAdjustmentID);

            if (SalaryAdjustmentID > 0)
            {
                if (string.Equals(e.CommandName, "EditItem"))
                {
                    _SalaryAdjustmentID = SalaryAdjustmentID;

                    PrepareEditView();

                    cpeEditor.Collapsed = false;
                    cpeEditor.ClientState = "false";
                }
                else if (string.Equals(e.CommandName, "DeleteItem"))
                {
                    try
                    {
                        Int64 result = -1;

                        String fe = SqlExpressionBuilder.PrepareFilterExpression(HRSalaryAdjustmentEntity.FLD_NAME_SalaryAdjustmentID, SalaryAdjustmentID.ToString(), SQLMatchType.Equal);

                        HRSalaryAdjustmentEntity hRSalaryAdjustmentEntity = new HRSalaryAdjustmentEntity();


                        result = FCCHRSalaryAdjustment.GetFacadeCreate().Delete(hRSalaryAdjustmentEntity, fe, DatabaseOperationType.Delete, TransactionRequired.No);

                        if (result == 0)
                        {
                            _SalaryAdjustmentID = 0;
                            _HRSalaryAdjustmentEntity = new HRSalaryAdjustmentEntity();
                            PrepareInitialView();
                            BindHRSalaryAdjustmentList();

                            MiscUtil.ShowMessage(lblMessage, "Salary Adjustment has been successfully deleted.", true);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to delete Salary Adjustment.", true);
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

        protected void odsHRSalaryAdjustment_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {
            String fe = String.Empty;
            if (chbxFilter.Checked)
            {
                fe = SqlExpressionBuilder.PrepareFilterExpression("HRSalaryAdjustment."+HRSalaryAdjustmentEntity.FLD_NAME_EmployeeCode, txtSearchText.Text.ToString(), SQLMatchType.LikeWithBothMath);
                String fe2 = "M2.FirstName + CASE WHEN M2.MiddleName != '' THEN ' ' + M2.MiddleName ELSE '' END + CASE WHEN M2.MiddleName != NULL THEN ' ' + M2.MiddleName ELSE '' END + ' ' + M2.LastName like '%" + txtSearchText.Text.ToString() + "%'";

                fe = SqlExpressionBuilder.PrepareFilterExpression(fe, SQLJoinType.OR, fe2);
            }
            e.InputParameters["filterExpression"] = fe;
        }

        #endregion

        #region Button Event

        protected void btnSave_Click(object sender, EventArgs e)
        {
            SaveHRSalaryAdjustmentEntity();
        }

        protected void btnAddNew_Click(object sender, EventArgs e)
        {
            _SalaryAdjustmentID = 0;
            _HRSalaryAdjustmentEntity = new HRSalaryAdjustmentEntity();
            PrepareInitialView();
        }

        protected void btnClear_Click(object sender, EventArgs e)
        {
            PrepareInitialView();
            PrepareEditView();
        }

        #endregion

        #region Dropdwon Event

        protected void ddlEmployeeID_SelectedIndexChanged(object sender, EventArgs e)
        {
            BuildEmployeeInformation(Int64.Parse(ddlEmployeeID.SelectedValue));
        }

        #endregion

        #region CheckBox Event

        protected void chbxFilter_CheckedChanged(object sender, EventArgs e)
        {
            BindList();
        }

        #endregion

        #endregion Event
    }
}
