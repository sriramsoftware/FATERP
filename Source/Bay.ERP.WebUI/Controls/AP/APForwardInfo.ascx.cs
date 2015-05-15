// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 22-Oct-2012, 04:39:52




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
    public partial class APForwardInfoControl : BaseControl
    {       
        #region Properties

        public Int64 _APForwardInfoID
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

        public APForwardInfoEntity _APForwardInfoEntity
        {
            get
            {
                APForwardInfoEntity entity = new APForwardInfoEntity();

                if (ViewState["CurrentEntity"] != null)
                {
                    entity = (APForwardInfoEntity)ViewState["CurrentEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["CurrentEntity"] = value;
            }
        }

        private APForwardInfoEntity CurrentAPForwardInfoEntity
        {
            get
            {
                if (_APForwardInfoID > 0)
                {
                    if (_APForwardInfoEntity.APForwardInfoID != _APForwardInfoID)
                    {
                        _APForwardInfoEntity = FCCAPForwardInfo.GetFacadeCreate().GetByID(_APForwardInfoID);
                    }
                }

                return _APForwardInfoEntity;
            }
            set
            {
                _APForwardInfoEntity = value;
            }
        }

        #endregion

        #region Methods

        private void BuildDropDownList()
        {
            //MiscUtil.PopulateAPMemberFeedback(ddlAPMemberFeedbackID, false);
            MiscUtil.PopulateAPApprovalProcess(ddlAPApprovalProcessID, false);
            //MiscUtil.PopulateAPMemberFeedbackRemarks(ddlAPMemberFeedbackRemarksID, false);
            MiscUtil.PopulateMDDepartment(ddlDepartmentID, false);
            MiscUtil.PopulateHREmployee(ddlEmployeeID, false);
        }

        private void PrepareValidator()
        {
        }

        private void PrepareInitialView()
        {
            BuildDropDownList();

            txtCommentRequestDate.Text = String.Empty;
            txtCommentSubmitDate.Text = String.Empty;
            txtAPMemberComment.Text = String.Empty;
            txtAPForwardMemberComment.Text = String.Empty;

            btnSubmit.Text = "Add";
            btnAddNew.Visible = false;
        }

        private void PrepareEditView()
        {
            APForwardInfoEntity aPForwardInfoEntity = CurrentAPForwardInfoEntity;


            if (!aPForwardInfoEntity.IsNew)
            {
                if (ddlAPMemberFeedbackID.Items.Count > 0 && aPForwardInfoEntity.APMemberFeedbackID != null)
                {
                    ddlAPMemberFeedbackID.SelectedValue = aPForwardInfoEntity.APMemberFeedbackID.ToString();
                }

                if (ddlAPApprovalProcessID.Items.Count > 0 && aPForwardInfoEntity.APApprovalProcessID != null)
                {
                    ddlAPApprovalProcessID.SelectedValue = aPForwardInfoEntity.APApprovalProcessID.ToString();
                }

                if (ddlAPMemberFeedbackRemarksID.Items.Count > 0 && aPForwardInfoEntity.APMemberFeedbackRemarksID != null)
                {
                    ddlAPMemberFeedbackRemarksID.SelectedValue = aPForwardInfoEntity.APMemberFeedbackRemarksID.ToString();
                }

                if (ddlDepartmentID.Items.Count > 0 && aPForwardInfoEntity.DepartmentID != null)
                {
                    ddlDepartmentID.SelectedValue = aPForwardInfoEntity.DepartmentID.ToString();
                }

                if (ddlEmployeeID.Items.Count > 0 && aPForwardInfoEntity.EmployeeID != null)
                {
                    ddlEmployeeID.SelectedValue = aPForwardInfoEntity.EmployeeID.ToString();
                }

                txtCommentRequestDate.Text = aPForwardInfoEntity.CommentRequestDate.ToStringDefault();
                txtCommentSubmitDate.Text = aPForwardInfoEntity.CommentSubmitDate.ToStringDefault();
                txtAPMemberComment.Text = aPForwardInfoEntity.APMemberComment.ToString();
                txtAPForwardMemberComment.Text = aPForwardInfoEntity.APForwardMemberComment.ToString();

                btnSubmit.Text = "Update";
                btnAddNew.Visible = true;
            }
        }

        private void BindList()
        {
            BindAPForwardInfoList();
        }

        private void BindAPForwardInfoList()
        {
            lvAPForwardInfo.DataBind();
        }

        private APForwardInfoEntity BuildAPForwardInfoEntity()
        {
            APForwardInfoEntity aPForwardInfoEntity = CurrentAPForwardInfoEntity;

            if (ddlAPMemberFeedbackID.Items.Count > 0)
            {
                if (ddlAPMemberFeedbackID.SelectedValue == "0")
                {
                }
                else
                {
                    aPForwardInfoEntity.APMemberFeedbackID = Int64.Parse(ddlAPMemberFeedbackID.SelectedValue);
                }
            }

            if (ddlAPApprovalProcessID.Items.Count > 0)
            {
                if (ddlAPApprovalProcessID.SelectedValue == "0")
                {
                }
                else
                {
                    aPForwardInfoEntity.APApprovalProcessID = Int64.Parse(ddlAPApprovalProcessID.SelectedValue);
                }
            }

            if (ddlAPMemberFeedbackRemarksID.Items.Count > 0)
            {
                if (ddlAPMemberFeedbackRemarksID.SelectedValue == "0")
                {
                }
                else
                {
                    aPForwardInfoEntity.APMemberFeedbackRemarksID = Int64.Parse(ddlAPMemberFeedbackRemarksID.SelectedValue);
                }
            }

            if (ddlDepartmentID.Items.Count > 0)
            {
                if (ddlDepartmentID.SelectedValue == "0")
                {
                }
                else
                {
                    aPForwardInfoEntity.DepartmentID = Int64.Parse(ddlDepartmentID.SelectedValue);
                }
            }

            if (ddlEmployeeID.Items.Count > 0)
            {
                if (ddlEmployeeID.SelectedValue == "0")
                {
                }
                else
                {
                    aPForwardInfoEntity.EmployeeID = Int64.Parse(ddlEmployeeID.SelectedValue);
                }
            }

            if (txtCommentRequestDate.Text.Trim().IsNotNullOrEmpty())
            {
                aPForwardInfoEntity.CommentRequestDate = MiscUtil.ParseToDateTime(txtCommentRequestDate.Text);
            }

            if (txtCommentSubmitDate.Text.Trim().IsNotNullOrEmpty())
            {
                aPForwardInfoEntity.CommentSubmitDate = MiscUtil.ParseToDateTime(txtCommentSubmitDate.Text);
            }
            else
            {
                aPForwardInfoEntity.CommentSubmitDate = null;
            }

            aPForwardInfoEntity.APMemberComment = txtAPMemberComment.Text.Trim();
            aPForwardInfoEntity.APForwardMemberComment = txtAPForwardMemberComment.Text.Trim();

            return aPForwardInfoEntity;
        }

        private void SaveAPForwardInfoEntity()
        {
            if (IsValid)
            {
                try
                {
                    APForwardInfoEntity aPForwardInfoEntity = BuildAPForwardInfoEntity();

                    Int64 result = -1;

                    if (aPForwardInfoEntity.IsNew)
                    {
                        result = FCCAPForwardInfo.GetFacadeCreate().Add(aPForwardInfoEntity, DatabaseOperationType.Add, TransactionRequired.No);
                    }
                    else
                    {
                        String filterExpression = SqlExpressionBuilder.PrepareFilterExpression(APForwardInfoEntity.FLD_NAME_APForwardInfoID, aPForwardInfoEntity.APForwardInfoID.ToString(), SQLMatchType.Equal);
                        result = FCCAPForwardInfo.GetFacadeCreate().Update(aPForwardInfoEntity, filterExpression, DatabaseOperationType.Update, TransactionRequired.No);
                    }

                    if (result > 0)
                    {
                        _APForwardInfoID = 0;
                        _APForwardInfoEntity = new APForwardInfoEntity();
                        PrepareInitialView();
                        BindAPForwardInfoList();

                        if (aPForwardInfoEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "A PForward Info Information has been added successfully.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "A PForward Info Information has been updated successfully.", false);
                        }
                    }
                    else
                    {
                        if (aPForwardInfoEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to add A PForward Info Information.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to update A PForward Info Information.", false);
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

        protected void lvAPForwardInfo_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            Int64 APForwardInfoID;

            Int64.TryParse(e.CommandArgument.ToString(), out APForwardInfoID);

            if (APForwardInfoID > 0)
            {
                if (string.Equals(e.CommandName, "EditItem"))
                {
                    _APForwardInfoID = APForwardInfoID;

                    PrepareEditView();

                    cpeEditor.Collapsed = false;
                    cpeEditor.ClientState = "false";
                }
                else if (string.Equals(e.CommandName, "DeleteItem"))
                {
                    try
                    {
                        Int64 result = -1;

                        String fe = SqlExpressionBuilder.PrepareFilterExpression(APForwardInfoEntity.FLD_NAME_APForwardInfoID, APForwardInfoID.ToString(), SQLMatchType.Equal);

                        APForwardInfoEntity aPForwardInfoEntity = new APForwardInfoEntity();


                        result = FCCAPForwardInfo.GetFacadeCreate().Delete(aPForwardInfoEntity, fe, DatabaseOperationType.Delete, TransactionRequired.No);

                        if (result == 0)
                        {
                            _APForwardInfoID = 0;
                            _APForwardInfoEntity = new APForwardInfoEntity();
                            PrepareInitialView();
                            BindAPForwardInfoList();

                            MiscUtil.ShowMessage(lblMessage, "A PForward Info has been successfully deleted.", true);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to delete A PForward Info.", true);
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

        protected void odsAPForwardInfo_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {
            e.InputParameters["filterExpression"] = String.Empty;
        }

        #endregion

        #region Button Event

        protected void btnSave_Click(object sender, EventArgs e)
        {
            SaveAPForwardInfoEntity();
        }

        protected void btnAddNew_Click(object sender, EventArgs e)
        {
            _APForwardInfoID = 0;
            _APForwardInfoEntity = new APForwardInfoEntity();
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
