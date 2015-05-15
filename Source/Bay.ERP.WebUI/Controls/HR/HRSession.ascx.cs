// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 05-Sep-2013, 01:19:45




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
    public partial class HRSessionControl : BaseControl
    {       
        #region Properties

        public Int64 _SessionID
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

        public HRSessionEntity _HRSessionEntity
        {
            get
            {
                HRSessionEntity entity = new HRSessionEntity();

                if (ViewState["CurrentEntity"] != null)
                {
                    entity = (HRSessionEntity)ViewState["CurrentEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["CurrentEntity"] = value;
            }
        }

        private HRSessionEntity CurrentHRSessionEntity
        {
            get
            {
                if (_SessionID > 0)
                {
                    if (_HRSessionEntity.SessionID != _SessionID)
                    {
                        _HRSessionEntity = FCCHRSession.GetFacadeCreate().GetByID(_SessionID);
                    }
                }

                return _HRSessionEntity;
            }
            set
            {
                _HRSessionEntity = value;
            }
        }

        #endregion

        #region Methods

        private void BuildDropDownList()
        {
            MiscUtil.PopulateMDEvaluationSessionCategory(ddlSessionCategoryID, false);
            MiscUtil.PopulateMDEvaluationSessionStatus(ddlEvaluationSessionStatusID, false);
            MiscUtil.PopulateMDEvaluatedBy(ddlEvaluatedByID, false);

            for (Int32 i = 1; i <= 20; i++)
            {
                ddlSalaryLevelFrom.Items.Add(new ListItem(i.ToString(),i.ToString()));
                ddlSalaryLevelTo.Items.Add(new ListItem(i.ToString(), i.ToString()));
            }
        }

        private void PrepareValidator()
        {
        }

        private void PrepareInitialView()
        {
            BuildDropDownList();

            txtSessionName.Text = String.Empty;
            txtStartDate.Text = String.Empty;
            txtEndDate.Text = String.Empty;
            txtDeadlineDate.Text = String.Empty;
            txtRemarks.Text = String.Empty;

            btnSubmit.Text = "Add";
            btnAddNew.Visible = false;
        }

        private void PrepareEditView()
        {
            HRSessionEntity hRSessionEntity = CurrentHRSessionEntity;


            if (!hRSessionEntity.IsNew)
            {
                if (ddlSessionCategoryID.Items.Count > 0 && hRSessionEntity.SessionCategoryID != null)
                {
                    ddlSessionCategoryID.SelectedValue = hRSessionEntity.SessionCategoryID.ToString();
                }

                txtSessionName.Text = hRSessionEntity.SessionName.ToString();
                txtStartDate.Text = hRSessionEntity.StartDate.ToStringDefault();
                txtEndDate.Text = hRSessionEntity.EndDate.ToStringDefault();
                txtDeadlineDate.Text = hRSessionEntity.DeadlineDate.ToStringDefault();
                if (ddlEvaluationSessionStatusID.Items.Count > 0 && hRSessionEntity.EvaluationSessionStatusID != null)
                {
                    ddlEvaluationSessionStatusID.SelectedValue = hRSessionEntity.EvaluationSessionStatusID.ToString();
                }

                txtRemarks.Text = hRSessionEntity.Remarks.ToString();

                btnSubmit.Text = "Update";
                btnAddNew.Visible = true;
            }
        }

        private void BindList()
        {
            BindHRSessionList();
        }

        private void BindHRSessionList()
        {
            lvHRSession.DataBind();
        }

        private HRSessionEntity BuildHRSessionEntity()
        {
            HRSessionEntity hRSessionEntity = CurrentHRSessionEntity;

            if (ddlSessionCategoryID.Items.Count > 0)
            {
                if (ddlSessionCategoryID.SelectedValue == "0")
                {
                }
                else
                {
                    hRSessionEntity.SessionCategoryID = Int64.Parse(ddlSessionCategoryID.SelectedValue);
                }
            }

            hRSessionEntity.SessionName = txtSessionName.Text.Trim();
            if (txtStartDate.Text.Trim().IsNotNullOrEmpty())
            {
                hRSessionEntity.StartDate = MiscUtil.ParseToDateTime(txtStartDate.Text);
            }

            if (txtEndDate.Text.Trim().IsNotNullOrEmpty())
            {
                hRSessionEntity.EndDate = MiscUtil.ParseToDateTime(txtEndDate.Text);
            }

            if (txtDeadlineDate.Text.Trim().IsNotNullOrEmpty())
            {
                hRSessionEntity.DeadlineDate = MiscUtil.ParseToDateTime(txtDeadlineDate.Text);
            }

            if (ddlEvaluationSessionStatusID.Items.Count > 0)
            {
                if (ddlEvaluationSessionStatusID.SelectedValue == "0")
                {
                }
                else
                {
                    hRSessionEntity.EvaluationSessionStatusID = Int64.Parse(ddlEvaluationSessionStatusID.SelectedValue);
                }
            }

            hRSessionEntity.Remarks = txtRemarks.Text.Trim();
            hRSessionEntity.CreatedByEmployeeID = MiscUtil.GetCurrentEmployeeByMemberID(CurrentMember);
            hRSessionEntity.CreateDate = System.DateTime.Now;
            hRSessionEntity.IP = MiscUtil.GetLocalIP();

            return hRSessionEntity;
        }

        private void SaveHRSessionEntity()
        {
            if (IsValid)
            {
                try
                {
                    HRSessionEntity hRSessionEntity = BuildHRSessionEntity();

                    Int64 result = -1;

                    if (hRSessionEntity.IsNew)
                    {
                        result = FCCHRSession.GetFacadeCreate().Add(hRSessionEntity, DatabaseOperationType.Add, TransactionRequired.No);
                    }
                    else
                    {
                        String filterExpression = SqlExpressionBuilder.PrepareFilterExpression(HRSessionEntity.FLD_NAME_SessionID, hRSessionEntity.SessionID.ToString(), SQLMatchType.Equal);
                        result = FCCHRSession.GetFacadeCreate().Update(hRSessionEntity, filterExpression, DatabaseOperationType.Update, TransactionRequired.No);
                    }

                    if (result > 0)
                    {
                        _SessionID = 0;
                        _HRSessionEntity = new HRSessionEntity();
                        PrepareInitialView();
                        BindHRSessionList();

                        if (hRSessionEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Session Information has been added successfully.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Session Information has been updated successfully.", false);
                        }
                    }
                    else
                    {
                        if (hRSessionEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to add Session Information.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to update Session Information.", false);
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

        protected void lvHRSession_ItemDataBound(object sender, ListViewItemEventArgs e)
        {
            if (e.Item.ItemType == ListViewItemType.DataItem)
            {
                ListViewDataItem dataItem = (ListViewDataItem)e.Item;

                HRSession_DetailedEntity ent = (HRSession_DetailedEntity)dataItem.DataItem;

                String fe = SqlExpressionBuilder.PrepareFilterExpression(HREmployeeEvaluationEntity.FLD_NAME_SessionID, ent.SessionID.ToString(), SQLMatchType.Equal);
                IList<HREmployeeEvaluationEntity> lst = FCCHREmployeeEvaluation.GetFacadeCreate().GetIL(null, null, String.Empty, fe, DatabaseOperationType.LoadWithFilterExpression);

                LinkButton lnkbtnGenerateSession = (LinkButton)e.Item.FindControl("lnkbtnGenerateSession");
                HyperLink hypHRReport = (HyperLink)e.Item.FindControl("hypHRReport");

                hypHRReport.Visible = false;
                if (lst != null && lst.Count > 0)
                {
                    lnkbtnGenerateSession.Visible = false;
                }

                if (ent.EvaluationSessionStatusID != MasterDataConstants.MDEvaluationSessionStatus.OPEN)
                {
                    lnkbtnGenerateSession.Visible = false;
                }

                #region SupervisorSubmited or not

                if (ent.SessionCategoryID == MasterDataConstants.MDEvaluationSessionCategory.PBR && (CurrentMember.MemberID == 25 || CurrentMember.MemberID == 182 || CurrentMember.MemberID == 317 || CurrentMember.MemberID == 20520 || CurrentMember.MemberID == 27 || CurrentMember.MemberID == 181))
                {
                    hypHRReport.NavigateUrl = UrlHelper.BuildSecureUrl("~/Reports/ReportViewer.aspx", string.Empty, "do", ReportConstants.HR_EMPLOYEE_EVALUATIONREPORT_REPORT_FOR_ALL_EMPLOYEE, UrlConstants.OVERVIEW_EVALUATION_SESSION_ID, ent.SessionID.ToString()).ToString();
                    hypHRReport.Visible = true;
                    hypHRReport.Target = "_blank";
                }

                #endregion

            }
        }

        protected void lvHRSession_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            Int64 SessionID;

            Int64.TryParse(e.CommandArgument.ToString(), out SessionID);

            if (SessionID > 0)
            {
                if (string.Equals(e.CommandName, "EditItem"))
                {
                    _SessionID = SessionID;

                    PrepareEditView();

                    cpeEditor.Collapsed = false;
                    cpeEditor.ClientState = "false";
                }
                else if (string.Equals(e.CommandName, "DeleteItem"))
                {
                    try
                    {
                        Int64 result = -1;

                        String fe = SqlExpressionBuilder.PrepareFilterExpression(HRSessionEntity.FLD_NAME_SessionID, SessionID.ToString(), SQLMatchType.Equal);

                        HRSessionEntity hRSessionEntity = new HRSessionEntity();


                        result = FCCHRSession.GetFacadeCreate().Delete(hRSessionEntity, fe, DatabaseOperationType.Delete, TransactionRequired.No);

                        if (result == 0)
                        {
                            _SessionID = 0;
                            _HRSessionEntity = new HRSessionEntity();
                            PrepareInitialView();
                            BindHRSessionList();

                            MiscUtil.ShowMessage(lblMessage, "Session has been successfully deleted.", true);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to delete Session.", true);
                        }
                    }
                    catch (Exception ex)
                    {
                        MiscUtil.ShowMessage(lblMessage, ex.Message, true);
                    }
                }

                else if (e.CommandName == "GenerateSession")
                {
                    _SessionID = SessionID;
                    this.ModalPopupExtender2.Show();
                }
            }
        }

        #endregion List View Event

        #region ObjectDataSource Event

        protected void odsHRSession_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {
            e.InputParameters["filterExpression"] = String.Empty;
        }

        #endregion

        #region Button Event

        protected void btnFloorPopupSave_Click(object sender, EventArgs e)
        {
            try
            {
                Int64 sessionID = _SessionID;
                Int64 evaluatedByID = Int64.Parse(ddlEvaluatedByID.SelectedValue);
                Int64 salaryLevelFrom = Int64.Parse(ddlSalaryLevelFrom.SelectedValue);
                Int64 salaryLevelTo = Int64.Parse(ddlSalaryLevelTo.SelectedValue);

                Int64 sessionCategoryID = Int64.Parse(ddlSessionCategoryID.SelectedValue);

                IList<HRGenerateEvaluation_CustomEntity> lst = FCCHRGenerateEvaluation_Custom.GetFacadeCreate().GetIL(sessionID, evaluatedByID, salaryLevelFrom, salaryLevelTo);

                if (lst != null && lst.Count > 0)
                {
                    MiscUtil.ShowMessage(lblMessage, "Successfully Generated", false);
                    this.ModalPopupExtender2.Hide();
                    BindHRSessionList();
                }
                else
                {
                    MiscUtil.ShowMessage(lblMessage, "Some Error Occured.", true);
                }
            }
            catch (Exception ex)
            {
                MiscUtil.ShowMessage(lblMessage, "Some Error Occured "+ex.Message, true);
            }
            
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            SaveHRSessionEntity();
        }

        protected void btnAddNew_Click(object sender, EventArgs e)
        {
            _SessionID = 0;
            _HRSessionEntity = new HRSessionEntity();
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
