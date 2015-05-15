// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 08-Sep-2013, 03:37:27




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
    public partial class HREmployeeSupervisorMapControl : BaseControl
    {       
        #region Properties

        public Int64 _EmployeeSupervisorMapID
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

        public HREmployeeSupervisorMapEntity _HREmployeeSupervisorMapEntity
        {
            get
            {
                HREmployeeSupervisorMapEntity entity = new HREmployeeSupervisorMapEntity();

                if (ViewState["CurrentEntity"] != null)
                {
                    entity = (HREmployeeSupervisorMapEntity)ViewState["CurrentEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["CurrentEntity"] = value;
            }
        }

        private HREmployeeSupervisorMapEntity CurrentHREmployeeSupervisorMapEntity
        {
            get
            {
                if (_EmployeeSupervisorMapID > 0)
                {
                    if (_HREmployeeSupervisorMapEntity.EmployeeSupervisorMapID != _EmployeeSupervisorMapID)
                    {
                        _HREmployeeSupervisorMapEntity = FCCHREmployeeSupervisorMap.GetFacadeCreate().GetByID(_EmployeeSupervisorMapID);
                    }
                }

                return _HREmployeeSupervisorMapEntity;
            }
            set
            {
                _HREmployeeSupervisorMapEntity = value;
            }
        }

        #endregion

        #region Methods

        private void BuildDropDownList()
        {
            MiscUtil.PopulateMDEvaluationSessionCategory(ddlSessionCategoryID, false);
            MiscUtil.PopulateHREmployee(ddlEmployeeID, false);
            MiscUtil.PopulateMDSupervisorType(ddlSupervisorTypeID, false);
            MiscUtil.PopulateHREmployee(ddlSupervisorEmployeeID, false);
        }

        private void PrepareValidator()
        {
        }

        private void PrepareInitialView()
        {
            BuildDropDownList();

            txtRemarks.Text = String.Empty;
            btnSubmit.Text = "Add";
            btnAddNew.Visible = false;
        }

        private void PrepareEditView()
        {
            HREmployeeSupervisorMapEntity hREmployeeSupervisorMapEntity = CurrentHREmployeeSupervisorMapEntity;


            if (!hREmployeeSupervisorMapEntity.IsNew)
            {
                if (ddlSessionCategoryID.Items.Count > 0 && hREmployeeSupervisorMapEntity.SessionCategoryID != null)
                {
                    ddlSessionCategoryID.SelectedValue = hREmployeeSupervisorMapEntity.SessionCategoryID.ToString();
                }

                if (ddlEmployeeID.Items.Count > 0 && hREmployeeSupervisorMapEntity.EmployeeID != null)
                {
                    ddlEmployeeID.SelectedValue = hREmployeeSupervisorMapEntity.EmployeeID.ToString();
                }

                if (ddlSupervisorTypeID.Items.Count > 0 && hREmployeeSupervisorMapEntity.SupervisorTypeID != null)
                {
                    ddlSupervisorTypeID.SelectedValue = hREmployeeSupervisorMapEntity.SupervisorTypeID.ToString();
                }

                if (ddlSupervisorEmployeeID.Items.Count > 0 && hREmployeeSupervisorMapEntity.SupervisorEmployeeID != null)
                {
                    ddlSupervisorEmployeeID.SelectedValue = hREmployeeSupervisorMapEntity.SupervisorEmployeeID.ToString();
                }

                txtRemarks.Text = hREmployeeSupervisorMapEntity.Remarks.ToString();

                btnSubmit.Text = "Update";
                btnAddNew.Visible = true;
            }
        }

        private void BindList()
        {
            BindHREmployeeSupervisorMapList();
        }

        private void BindHREmployeeSupervisorMapList()
        {
            lvHREmployeeSupervisorMap.DataBind();
        }

        private HREmployeeSupervisorMapEntity BuildHREmployeeSupervisorMapEntity()
        {
            HREmployeeSupervisorMapEntity hREmployeeSupervisorMapEntity = CurrentHREmployeeSupervisorMapEntity;

            if (ddlSessionCategoryID.Items.Count > 0)
            {
                if (ddlSessionCategoryID.SelectedValue == "0")
                {
                }
                else
                {
                    hREmployeeSupervisorMapEntity.SessionCategoryID = Int64.Parse(ddlSessionCategoryID.SelectedValue);
                }
            }

            if (ddlEmployeeID.Items.Count > 0)
            {
                if (ddlEmployeeID.SelectedValue == "0")
                {
                }
                else
                {
                    hREmployeeSupervisorMapEntity.EmployeeID = Int64.Parse(ddlEmployeeID.SelectedValue);

                    HREmployeeEntity hREmployeeEntity = FCCHREmployee.GetFacadeCreate().GetByID(hREmployeeSupervisorMapEntity.EmployeeID);
                    if (hREmployeeEntity != null && hREmployeeEntity.EmployeeID > 0)
                    {
                        hREmployeeSupervisorMapEntity.EmployeeCode = hREmployeeEntity.EmployeeCode;
                    }
                }
            }

            
            if (ddlSupervisorTypeID.Items.Count > 0)
            {
                if (ddlSupervisorTypeID.SelectedValue == "0")
                {
                }
                else
                {
                    hREmployeeSupervisorMapEntity.SupervisorTypeID = Int64.Parse(ddlSupervisorTypeID.SelectedValue);
                }
            }

            if (ddlSupervisorEmployeeID.Items.Count > 0)
            {
                if (ddlSupervisorEmployeeID.SelectedValue == "0")
                {
                }
                else
                {
                    hREmployeeSupervisorMapEntity.SupervisorEmployeeID = Int64.Parse(ddlSupervisorEmployeeID.SelectedValue);
                    HREmployeeEntity hREmployeeEntity = FCCHREmployee.GetFacadeCreate().GetByID(hREmployeeSupervisorMapEntity.SupervisorEmployeeID);
                    if (hREmployeeEntity != null && hREmployeeEntity.EmployeeID > 0)
                    {
                        hREmployeeSupervisorMapEntity.SupervisorEmployeeCode = hREmployeeEntity.EmployeeCode;
                    }
                }
            }

            hREmployeeSupervisorMapEntity.Remarks = txtRemarks.Text.Trim();
            hREmployeeSupervisorMapEntity.CreateDate = System.DateTime.Now;

            return hREmployeeSupervisorMapEntity;
        }

        private void SaveHREmployeeSupervisorMapEntity()
        {
            if (IsValid)
            {
                try
                {
                    HREmployeeSupervisorMapEntity hREmployeeSupervisorMapEntity = BuildHREmployeeSupervisorMapEntity();

                    Int64 result = -1;

                    if (hREmployeeSupervisorMapEntity.IsNew)
                    {
                        result = FCCHREmployeeSupervisorMap.GetFacadeCreate().Add(hREmployeeSupervisorMapEntity, DatabaseOperationType.Add, TransactionRequired.No);
                    }
                    else
                    {
                        String filterExpression = SqlExpressionBuilder.PrepareFilterExpression(HREmployeeSupervisorMapEntity.FLD_NAME_EmployeeSupervisorMapID, hREmployeeSupervisorMapEntity.EmployeeSupervisorMapID.ToString(), SQLMatchType.Equal);
                        result = FCCHREmployeeSupervisorMap.GetFacadeCreate().Update(hREmployeeSupervisorMapEntity, filterExpression, DatabaseOperationType.Update, TransactionRequired.No);
                    }

                    if (result > 0)
                    {
                        _EmployeeSupervisorMapID = 0;
                        _HREmployeeSupervisorMapEntity = new HREmployeeSupervisorMapEntity();
                        PrepareInitialView();
                        BindHREmployeeSupervisorMapList();

                        if (hREmployeeSupervisorMapEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Employee Supervisor Map Information has been added successfully.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Employee Supervisor Map Information has been updated successfully.", false);
                        }
                    }
                    else
                    {
                        if (hREmployeeSupervisorMapEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to add Employee Supervisor Map Information.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to update Employee Supervisor Map Information.", false);
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

        protected void lvHREmployeeSupervisorMap_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            Int64 EmployeeSupervisorMapID;

            Int64.TryParse(e.CommandArgument.ToString(), out EmployeeSupervisorMapID);

            if (EmployeeSupervisorMapID > 0)
            {
                if (string.Equals(e.CommandName, "EditItem"))
                {
                    _EmployeeSupervisorMapID = EmployeeSupervisorMapID;

                    PrepareEditView();

                    cpeEditor.Collapsed = false;
                    cpeEditor.ClientState = "false";
                }
                else if (string.Equals(e.CommandName, "DeleteItem"))
                {
                    try
                    {
                        Int64 result = -1;

                        String fe = SqlExpressionBuilder.PrepareFilterExpression(HREmployeeSupervisorMapEntity.FLD_NAME_EmployeeSupervisorMapID, EmployeeSupervisorMapID.ToString(), SQLMatchType.Equal);

                        HREmployeeSupervisorMapEntity hREmployeeSupervisorMapEntity = new HREmployeeSupervisorMapEntity();


                        result = FCCHREmployeeSupervisorMap.GetFacadeCreate().Delete(hREmployeeSupervisorMapEntity, fe, DatabaseOperationType.Delete, TransactionRequired.No);

                        if (result == 0)
                        {
                            _EmployeeSupervisorMapID = 0;
                            _HREmployeeSupervisorMapEntity = new HREmployeeSupervisorMapEntity();
                            PrepareInitialView();
                            BindHREmployeeSupervisorMapList();

                            MiscUtil.ShowMessage(lblMessage, "Employee Supervisor Map has been successfully deleted.", true);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to delete Employee Supervisor Map.", true);
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

        protected void odsHREmployeeSupervisorMap_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {
            String fe = String.Empty;
            if (chbxFilter.Checked)
            {
                fe = SqlExpressionBuilder.PrepareFilterExpression("HREmployeeSupervisorMap."+HREmployeeSupervisorMapEntity.FLD_NAME_EmployeeCode, txtSearchText.Text.ToString(), SQLMatchType.LikeWithBothMath);
                String fe2 = "M2.FirstName + CASE WHEN M2.MiddleName != '' THEN ' ' + M2.MiddleName ELSE '' END + CASE WHEN M2.MiddleName != NULL THEN ' ' + M2.MiddleName ELSE '' END + ' ' + M2.LastName like '%" + txtSearchText.Text.ToString() + "%'";

                fe = SqlExpressionBuilder.PrepareFilterExpression(fe, SQLJoinType.OR, fe2);
            }
            e.InputParameters["filterExpression"] = fe;
        }

        #endregion

        #region Button Event

        protected void btnSave_Click(object sender, EventArgs e)
        {
            SaveHREmployeeSupervisorMapEntity();
        }

        protected void btnAddNew_Click(object sender, EventArgs e)
        {
            _EmployeeSupervisorMapID = 0;
            _HREmployeeSupervisorMapEntity = new HREmployeeSupervisorMapEntity();
            PrepareInitialView();
        }

        protected void btnClear_Click(object sender, EventArgs e)
        {
            PrepareInitialView();
            PrepareEditView();
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
