// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 03-Oct-2012, 05:32:03




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
    public partial class APMemberFeedbackControl : BaseControl
    {       
        #region Properties

        public Int64 _APMemberFeedbackID
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

        public APMemberFeedbackEntity _APMemberFeedbackEntity
        {
            get
            {
                APMemberFeedbackEntity entity = new APMemberFeedbackEntity();

                if (ViewState["CurrentEntity"] != null)
                {
                    entity = (APMemberFeedbackEntity)ViewState["CurrentEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["CurrentEntity"] = value;
            }
        }

        private APMemberFeedbackEntity CurrentAPMemberFeedbackEntity
        {
            get
            {
                if (_APMemberFeedbackID > 0)
                {
                    if (_APMemberFeedbackEntity.APMemberFeedbackID != _APMemberFeedbackID)
                    {
                        _APMemberFeedbackEntity = FCCAPMemberFeedback.GetFacadeCreate().GetByID(_APMemberFeedbackID);
                    }
                }

                return _APMemberFeedbackEntity;
            }
            set
            {
                _APMemberFeedbackEntity = value;
            }
        }

        #endregion

        #region Methods

        private void BuildDropDownList()
        {
            MiscUtil.PopulateAPApprovalProcess(ddlAPApprovalProcessID, false);
            MiscUtil.PopulateMDDepartment(ddlDepartmentID, false);
            MiscUtil.PopulateHREmployee(ddlEmployeeID, false);
            MiscUtil.PopulateAPFeedback(ddlAPFeedbackID, false);
        }

        private void PrepareValidator()
        {
        }

        private void PrepareInitialView()
        {
            BuildDropDownList();

            txtSequenceNo.Text = String.Empty;
            txtFeedbackRequestDate.Text = String.Empty;
            txtFeedbackLastResponseDate.Text = String.Empty;
            txtFeedbackSubmitDate.Text = String.Empty;

            btnSubmit.Text = "Add";
            btnAddNew.Visible = false;
        }

        private void PrepareEditView()
        {
            APMemberFeedbackEntity aPMemberFeedbackEntity = CurrentAPMemberFeedbackEntity;


            if (!aPMemberFeedbackEntity.IsNew)
            {
                if (ddlAPApprovalProcessID.Items.Count > 0 && aPMemberFeedbackEntity.APApprovalProcessID != null)
                {
                    ddlAPApprovalProcessID.SelectedValue = aPMemberFeedbackEntity.APApprovalProcessID.ToString();
                }

                if (ddlDepartmentID.Items.Count > 0 && aPMemberFeedbackEntity.DepartmentID != null)
                {
                    ddlDepartmentID.SelectedValue = aPMemberFeedbackEntity.DepartmentID.ToString();
                }

                if (ddlEmployeeID.Items.Count > 0 && aPMemberFeedbackEntity.EmployeeID != null)
                {
                    ddlEmployeeID.SelectedValue = aPMemberFeedbackEntity.EmployeeID.ToString();
                }

                txtSequenceNo.Text = aPMemberFeedbackEntity.SequenceNo.ToString();
                if (ddlAPFeedbackID.Items.Count > 0 && aPMemberFeedbackEntity.APFeedbackID != null)
                {
                    ddlAPFeedbackID.SelectedValue = aPMemberFeedbackEntity.APFeedbackID.ToString();
                }

                txtFeedbackRequestDate.Text = aPMemberFeedbackEntity.FeedbackRequestDate.ToStringDefault();
                txtFeedbackLastResponseDate.Text = aPMemberFeedbackEntity.FeedbackLastResponseDate.ToStringDefault();
                txtFeedbackSubmitDate.Text = aPMemberFeedbackEntity.FeedbackSubmitDate.ToStringDefault();

                btnSubmit.Text = "Update";
                btnAddNew.Visible = true;
            }
        }

        private void BindList()
        {
            BindAPMemberFeedbackList();
        }

        private void BindAPMemberFeedbackList()
        {
            lvAPMemberFeedback.DataBind();
        }

        private APMemberFeedbackEntity BuildAPMemberFeedbackEntity()
        {
            APMemberFeedbackEntity aPMemberFeedbackEntity = CurrentAPMemberFeedbackEntity;

            if (ddlAPApprovalProcessID.Items.Count > 0)
            {
                if (ddlAPApprovalProcessID.SelectedValue == "0")
                {
                }
                else
                {
                    aPMemberFeedbackEntity.APApprovalProcessID = Int64.Parse(ddlAPApprovalProcessID.SelectedValue);
                }
            }

            if (ddlDepartmentID.Items.Count > 0)
            {
                if (ddlDepartmentID.SelectedValue == "0")
                {
                }
                else
                {
                    aPMemberFeedbackEntity.DepartmentID = Int64.Parse(ddlDepartmentID.SelectedValue);
                }
            }

            if (ddlEmployeeID.Items.Count > 0)
            {
                if (ddlEmployeeID.SelectedValue == "0")
                {
                }
                else
                {
                    aPMemberFeedbackEntity.EmployeeID = Int64.Parse(ddlEmployeeID.SelectedValue);
                }
            }

            if (!txtSequenceNo.Text.Trim().IsNullOrEmpty())
            {
                aPMemberFeedbackEntity.SequenceNo = Int32.Parse(txtSequenceNo.Text.Trim());
            }

            if (ddlAPFeedbackID.Items.Count > 0)
            {
                if (ddlAPFeedbackID.SelectedValue == "0")
                {
                }
                else
                {
                    aPMemberFeedbackEntity.APFeedbackID = Int64.Parse(ddlAPFeedbackID.SelectedValue);
                }
            }

            if (txtFeedbackRequestDate.Text.Trim().IsNotNullOrEmpty())
            {
                aPMemberFeedbackEntity.FeedbackRequestDate = MiscUtil.ParseToDateTime(txtFeedbackRequestDate.Text);
            }
            else
            {
                aPMemberFeedbackEntity.FeedbackRequestDate = null;
            }

            if (txtFeedbackLastResponseDate.Text.Trim().IsNotNullOrEmpty())
            {
                aPMemberFeedbackEntity.FeedbackLastResponseDate = MiscUtil.ParseToDateTime(txtFeedbackLastResponseDate.Text);
            }
            else
            {
                aPMemberFeedbackEntity.FeedbackLastResponseDate = null;
            }

            if (txtFeedbackSubmitDate.Text.Trim().IsNotNullOrEmpty())
            {
                aPMemberFeedbackEntity.FeedbackSubmitDate = MiscUtil.ParseToDateTime(txtFeedbackSubmitDate.Text);
            }
            else
            {
                aPMemberFeedbackEntity.FeedbackSubmitDate = null;
            }


            return aPMemberFeedbackEntity;
        }

        private void SaveAPMemberFeedbackEntity()
        {
            if (IsValid)
            {
                try
                {
                    APMemberFeedbackEntity aPMemberFeedbackEntity = BuildAPMemberFeedbackEntity();

                    Int64 result = -1;

                    if (aPMemberFeedbackEntity.IsNew)
                    {
                        result = FCCAPMemberFeedback.GetFacadeCreate().Add(aPMemberFeedbackEntity, DatabaseOperationType.Add, TransactionRequired.No);
                    }
                    else
                    {
                        String filterExpression = SqlExpressionBuilder.PrepareFilterExpression(APMemberFeedbackEntity.FLD_NAME_APMemberFeedbackID, aPMemberFeedbackEntity.APMemberFeedbackID.ToString(), SQLMatchType.Equal);
                        result = FCCAPMemberFeedback.GetFacadeCreate().Update(aPMemberFeedbackEntity, filterExpression, DatabaseOperationType.Update, TransactionRequired.No);
                    }

                    if (result > 0)
                    {
                        _APMemberFeedbackID = 0;
                        _APMemberFeedbackEntity = new APMemberFeedbackEntity();
                        PrepareInitialView();
                        BindAPMemberFeedbackList();

                        if (aPMemberFeedbackEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Approval Process Member Feedback Information has been added successfully.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Approval Process Member Feedback Information has been updated successfully.", false);
                        }
                    }
                    else
                    {
                        if (aPMemberFeedbackEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to add Approval Process Member Feedback Information.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to update Approval Process Member Feedback Information.", false);
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

        protected void lvAPMemberFeedback_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            Int64 APMemberFeedbackID;

            Int64.TryParse(e.CommandArgument.ToString(), out APMemberFeedbackID);

            if (APMemberFeedbackID > 0)
            {
                if (string.Equals(e.CommandName, "EditItem"))
                {
                    _APMemberFeedbackID = APMemberFeedbackID;

                    PrepareEditView();

                    cpeEditor.Collapsed = false;
                    cpeEditor.ClientState = "false";
                }
                else if (string.Equals(e.CommandName, "DeleteItem"))
                {
                    try
                    {
                        Int64 result = -1;

                        String fe = SqlExpressionBuilder.PrepareFilterExpression(APMemberFeedbackEntity.FLD_NAME_APMemberFeedbackID, APMemberFeedbackID.ToString(), SQLMatchType.Equal);

                        APMemberFeedbackEntity aPMemberFeedbackEntity = new APMemberFeedbackEntity();


                        result = FCCAPMemberFeedback.GetFacadeCreate().Delete(aPMemberFeedbackEntity, fe, DatabaseOperationType.Delete, TransactionRequired.No);

                        if (result == 0)
                        {
                            _APMemberFeedbackID = 0;
                            _APMemberFeedbackEntity = new APMemberFeedbackEntity();
                            PrepareInitialView();
                            BindAPMemberFeedbackList();

                            MiscUtil.ShowMessage(lblMessage, "Approval Process Member Feedback has been successfully deleted.", true);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to delete Approval Process Member Feedback.", true);
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

        protected void odsAPMemberFeedback_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {
            e.InputParameters["filterExpression"] = String.Empty;
        }

        #endregion

        #region Button Event

        protected void btnSave_Click(object sender, EventArgs e)
        {
            SaveAPMemberFeedbackEntity();
        }

        protected void btnAddNew_Click(object sender, EventArgs e)
        {
            _APMemberFeedbackID = 0;
            _APMemberFeedbackEntity = new APMemberFeedbackEntity();
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
