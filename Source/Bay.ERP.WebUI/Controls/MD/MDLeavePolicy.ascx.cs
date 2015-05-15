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
    public partial class MDLeavePolicyControl : BaseControl
    {       
        #region Properties

        public Int64 _LeavePolicyID
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

        public MDLeavePolicyEntity _MDLeavePolicyEntity
        {
            get
            {
                MDLeavePolicyEntity entity = new MDLeavePolicyEntity();

                if (ViewState["CurrentEntity"] != null)
                {
                    entity = (MDLeavePolicyEntity)ViewState["CurrentEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["CurrentEntity"] = value;
            }
        }

        private MDLeavePolicyEntity CurrentMDLeavePolicyEntity
        {
            get
            {
                if (_LeavePolicyID > 0)
                {
                    if (_MDLeavePolicyEntity.LeavePolicyID != _LeavePolicyID)
                    {
                        _MDLeavePolicyEntity = FCCMDLeavePolicy.GetFacadeCreate().GetByID(_LeavePolicyID);
                    }
                }

                return _MDLeavePolicyEntity;
            }
            set
            {
                _MDLeavePolicyEntity = value;
            }
        }

        #endregion

        #region Methods

        private void BuildDropDownList()
        {
            MiscUtil.PopulateACFiscalYear(ddlFiscalYearID, false);
            MiscUtil.PopulateMDEmployeeJobType(ddlEmployeeJobTypeID, false);
            MiscUtil.PopulateMDLeaveCategory(ddlLeaveCategoryID, false);
        }

        private void PrepareValidator()
        {
        }

        private void PrepareInitialView()
        {
            BuildDropDownList();

            txtLeaveInDays.Text = String.Empty;
            txtRemarks.Text = String.Empty;
            chkIsRemoved.Checked = false;

            btnSubmit.Text = "Add";
            btnAddNew.Visible = false;
        }

        private void PrepareEditView()
        {
            MDLeavePolicyEntity mDLeavePolicyEntity = CurrentMDLeavePolicyEntity;


            if (!mDLeavePolicyEntity.IsNew)
            {
                if (ddlFiscalYearID.Items.Count > 0 && mDLeavePolicyEntity.FiscalYearID != null)
                {
                    ddlFiscalYearID.SelectedValue = mDLeavePolicyEntity.FiscalYearID.ToString();
                }

                if (ddlEmployeeJobTypeID.Items.Count > 0 && mDLeavePolicyEntity.EmployeeJobTypeID != null)
                {
                    ddlEmployeeJobTypeID.SelectedValue = mDLeavePolicyEntity.EmployeeJobTypeID.ToString();
                }

                if (ddlLeaveCategoryID.Items.Count > 0 && mDLeavePolicyEntity.LeaveCategoryID != null)
                {
                    ddlLeaveCategoryID.SelectedValue = mDLeavePolicyEntity.LeaveCategoryID.ToString();
                }

                txtLeaveInDays.Text = mDLeavePolicyEntity.LeaveInDays.ToString().Trim();
                txtRemarks.Text = mDLeavePolicyEntity.Remarks.ToString().Trim();

                chkIsRemoved.Checked = mDLeavePolicyEntity.IsNew;

                btnSubmit.Text = "Update";
                btnAddNew.Visible = true;
            }
        }

        private void BindList()
        {
            BindMDLeavePolicyList();
        }

        private void BindMDLeavePolicyList()
        {
            lvMDLeavePolicy.DataBind();
        }

        private MDLeavePolicyEntity BuildMDLeavePolicyEntity()
        {
            MDLeavePolicyEntity mDLeavePolicyEntity = CurrentMDLeavePolicyEntity;

            if (ddlFiscalYearID.Items.Count > 0)
            {
                if (ddlFiscalYearID.SelectedValue == "0")
                {
                }
                else
                {
                    mDLeavePolicyEntity.FiscalYearID = Int64.Parse(ddlFiscalYearID.SelectedValue);
                }
            }

            if (ddlEmployeeJobTypeID.Items.Count > 0)
            {
                if (ddlEmployeeJobTypeID.SelectedValue == "0")
                {
                }
                else
                {
                    mDLeavePolicyEntity.EmployeeJobTypeID = Int64.Parse(ddlEmployeeJobTypeID.SelectedValue);
                }
            }

            if (ddlLeaveCategoryID.Items.Count > 0)
            {
                if (ddlLeaveCategoryID.SelectedValue == "0")
                {
                }
                else
                {
                    mDLeavePolicyEntity.LeaveCategoryID = Int64.Parse(ddlLeaveCategoryID.SelectedValue);
                }
            }

            mDLeavePolicyEntity.LeaveInDays= Decimal.Parse(txtLeaveInDays.Text);
            mDLeavePolicyEntity.Remarks = txtRemarks.Text.Trim().ToString();
            mDLeavePolicyEntity.IsRemoved = chkIsRemoved.Checked;

            

            return mDLeavePolicyEntity;
        }

        private void SaveMDLeavePolicyEntity()
        {
            if (IsValid)
            {
                try
                {
                    MDLeavePolicyEntity mDLeavePolicyEntity = BuildMDLeavePolicyEntity();

                    Int64 result = -1;

                    if (mDLeavePolicyEntity.IsNew)
                    {
                        result = FCCMDLeavePolicy.GetFacadeCreate().Add(mDLeavePolicyEntity, DatabaseOperationType.Add, TransactionRequired.No);
                    }
                    else
                    {
                        String filterExpression = SqlExpressionBuilder.PrepareFilterExpression(MDLeavePolicyEntity.FLD_NAME_LeavePolicyID, mDLeavePolicyEntity.LeavePolicyID.ToString(), SQLMatchType.Equal);
                        result = FCCMDLeavePolicy.GetFacadeCreate().Update(mDLeavePolicyEntity, filterExpression, DatabaseOperationType.Update, TransactionRequired.No);
                    }

                    if (result > 0)
                    {
                        _LeavePolicyID = 0;
                        _MDLeavePolicyEntity = new MDLeavePolicyEntity();
                        PrepareInitialView();
                        BindMDLeavePolicyList();

                        if (mDLeavePolicyEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Loan Category Information has been added successfully.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Loan Category Information has been updated successfully.", false);
                        }
                    }
                    else
                    {
                        if (mDLeavePolicyEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to add Loan Category Information.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to update Loan Category Information.", false);
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

        protected void lvMDLeavePolicy_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            Int64 LeavePolicyID;

            Int64.TryParse(e.CommandArgument.ToString(), out LeavePolicyID);

            if (LeavePolicyID > 0)
            {
                if (string.Equals(e.CommandName, "EditItem"))
                {
                    _LeavePolicyID = LeavePolicyID;

                    PrepareEditView();

                    cpeEditor.Collapsed = false;
                    cpeEditor.ClientState = "false";
                }
                else if (string.Equals(e.CommandName, "DeleteItem"))
                {
                    try
                    {
                        Int64 result = -1;

                        String fe = SqlExpressionBuilder.PrepareFilterExpression(MDLeavePolicyEntity.FLD_NAME_LeavePolicyID, LeavePolicyID.ToString(), SQLMatchType.Equal);

                        MDLeavePolicyEntity mDLeavePolicyEntity = new MDLeavePolicyEntity();


                        result = FCCMDLeavePolicy.GetFacadeCreate().Delete(mDLeavePolicyEntity, fe, DatabaseOperationType.Delete, TransactionRequired.No);

                        if (result == 0)
                        {
                            _LeavePolicyID = 0;
                            _MDLeavePolicyEntity = new MDLeavePolicyEntity();
                            PrepareInitialView();
                            BindMDLeavePolicyList();

                            MiscUtil.ShowMessage(lblMessage, "Leave Policy has been successfully deleted.", true);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to delete Leave Policy.", true);
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

        protected void odsMDLeavePolicy_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {
            e.InputParameters["filterExpression"] = String.Empty;
        }

        #endregion

        #region Button Event

        protected void btnSave_Click(object sender, EventArgs e)
        {
            SaveMDLeavePolicyEntity();
        }

        protected void btnAddNew_Click(object sender, EventArgs e)
        {
            _LeavePolicyID = 0;
            _MDLeavePolicyEntity = new MDLeavePolicyEntity();
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
