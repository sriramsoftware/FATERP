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
using System.Linq;

using Bay.ERP.Web.UI.Helper;
using Bay.ERP.Common.BusinessEntities;
using Bay.ERP.BusinessFacade;
using Bay.ERP.FacadeCreator.FacadeContext;
using Bay.ERP.Common.Helper;
using Bay.ERP.Common.Shared;
using System.IO;

namespace Bay.ERP.Web.UI
{
    public partial class HREmployeeEvaluationMigrationControl : BaseControl
    {       
        #region Properties

        public String Action
        {
            get
            {
                String action = "Add";

                if (ViewState["do"] != null)
                {
                    action = ViewState["do"].ToString();
                }
                else if (!StringHelper.IsBlank(Helper.Url.SecureUrl["do"].ToString()))
                {
                    action = Helper.Url.SecureUrl["do"].ToString();

                    ViewState["do"] = action;
                }

                return action;
            }
            set
            {
                ViewState["do"] = value;
            }
        }

        public String SubmittedAction
        {
            get
            {
                String action = "UnLocked";

                if (ViewState["SubmittedAction"] != null)
                {
                    action = ViewState["SubmittedAction"].ToString();
                }
              

                return action;
            }
            set
            {
                ViewState["SubmittedAction"] = value;
            }
        }

        public Int64 _CurrentEmployeeEvaluatedID
        {
            get
            {
                Int64 CurrentEmployeeEvaluatedID = 0;

                if (!StringHelper.IsBlank(Helper.Url.SecureUrl[UrlConstants.OVERVIEW_EMPLOYEE_ID]))
                {
                    Int64.TryParse(Helper.Url.SecureUrl[UrlConstants.OVERVIEW_EMPLOYEE_ID], out CurrentEmployeeEvaluatedID);
                }

                return CurrentEmployeeEvaluatedID;
            }
        }

        public Int64 _SupervisorEmployeeID
        {
            get
            {
                Int64 SupervisorEmployeeID = 0;

                if (!StringHelper.IsBlank(Helper.Url.SecureUrl[UrlConstants.OVERVIEW_SUEPRVISOR_EMPLOYEE_ID]))
                {
                    Int64.TryParse(Helper.Url.SecureUrl[UrlConstants.OVERVIEW_SUEPRVISOR_EMPLOYEE_ID], out SupervisorEmployeeID);
                }

                return SupervisorEmployeeID;
            }
        }

        public Int64 _CurrentSessionID
        {
            get
            {
                Int64 SessionID = 0;

                if (!StringHelper.IsBlank(Helper.Url.SecureUrl[UrlConstants.OVERVIEW_EVALUATION_SESSION_ID]))
                {
                    Int64.TryParse(Helper.Url.SecureUrl[UrlConstants.OVERVIEW_EVALUATION_SESSION_ID], out SessionID);
                }

                return SessionID;
            }
        }

        public Int64 _EmployeeEvaluationID
        {
            get
            {
                Int64 id = 0;

                if (ViewState["EmployeeEvaluationID"] != null)
                {
                    Int64.TryParse(ViewState["EmployeeEvaluationID"].ToString(), out id);
                }

                return id;
            }
            set
            {
                ViewState["EmployeeEvaluationID"] = value;
            }
        }

        public Int64 _EvaluationCriteriaID
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

        public MDEvaluationCriteriaEntity _MDEvaluationCriteriaEntity
        {
            get
            {
                MDEvaluationCriteriaEntity entity = new MDEvaluationCriteriaEntity();

                if (ViewState["CurrentEntity"] != null)
                {
                    entity = (MDEvaluationCriteriaEntity)ViewState["CurrentEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["CurrentEntity"] = value;
            }
        }

        private MDEvaluationCriteriaEntity CurrentMDEvaluationCriteriaEntity
        {
            get
            {
                if (_EvaluationCriteriaID > 0)
                {
                    if (_MDEvaluationCriteriaEntity.EvaluationCriteriaID != _EvaluationCriteriaID)
                    {
                        _MDEvaluationCriteriaEntity = FCCMDEvaluationCriteria.GetFacadeCreate().GetByID(_EvaluationCriteriaID);
                    }
                }

                return _MDEvaluationCriteriaEntity;
            }
            set
            {
                _MDEvaluationCriteriaEntity = value;
            }
        }

        #endregion

        #region Methods

        private void BuildDropDownList()
        {
            
        }

        private void SubmitButtonEnable()
        {
            if (Action == "Supervisor")
            {
                String fe1 = SqlExpressionBuilder.PrepareFilterExpression(HREmployeeEvaluationEntity.FLD_NAME_SessionID, _CurrentSessionID.ToString(), SQLMatchType.Equal);
                String fe2 = SqlExpressionBuilder.PrepareFilterExpression(HREmployeeEvaluationEntity.FLD_NAME_SupervisorEmployeeID, _SupervisorEmployeeID.ToString(), SQLMatchType.Equal);
                String fe3 = SqlExpressionBuilder.PrepareFilterExpression(HREmployeeEvaluationEntity.FLD_NAME_EmployeeID,_CurrentEmployeeEvaluatedID.ToString(), SQLMatchType.Equal);
                String fe = SqlExpressionBuilder.PrepareFilterExpression(fe1, SQLJoinType.AND, fe2);
                fe = SqlExpressionBuilder.PrepareFilterExpression(fe, SQLJoinType.AND, fe3);

                IList<HREmployeeEvaluationEntity> lst = FCCHREmployeeEvaluation.GetFacadeCreate().GetIL(null, null, String.Empty, fe, DatabaseOperationType.LoadWithFilterExpression);

                if (lst != null && lst.Count > 0)
                {
                    if (lst[0].SupervisorSubmitDate.HasValue)
                    {
                        btnSubmit.Visible = false;
                        lblFormLock.Visible = true;
                        SubmittedAction = "Locked";
                    }
                    else
                    {
                       // btnSubmit.Visible = true;
                        lblFormLock.Visible = false;
                        SubmittedAction = "UnLocked";
                    }
                }
            }
            else if(Action =="Employee")
            {
                String fe1=SqlExpressionBuilder.PrepareFilterExpression(HREmployeeEvaluationEntity.FLD_NAME_SessionID,_CurrentSessionID.ToString(),SQLMatchType.Equal);
                String fe2=SqlExpressionBuilder.PrepareFilterExpression(HREmployeeEvaluationEntity.FLD_NAME_EmployeeID,_CurrentEmployeeEvaluatedID.ToString(),SQLMatchType.Equal);
                String fe=SqlExpressionBuilder.PrepareFilterExpression(fe1,SQLJoinType.AND,fe2);

                IList<HREmployeeEvaluationEntity> lst = FCCHREmployeeEvaluation.GetFacadeCreate().GetIL(null, null, String.Empty, fe, DatabaseOperationType.LoadWithFilterExpression);

                if (lst != null && lst.Count > 0)
                {
                    if (lst[0].EmployeeSubmitDate.HasValue)
                    {
                        btnSubmit.Visible = false;
                        lblFormLock.Visible = true;
                        SubmittedAction = "Locked";
                    }
                    else
                    {
                       // btnSubmit.Visible = true;
                        lblFormLock.Visible = false;
                        SubmittedAction = "UnLocked";
                    }

                }
            }

        }

        private void PrepareValidator()
        {
        }

        private void PrepareInitialView()
        {
            BuildDropDownList();
            BindLabel();
            SubmitButtonEnable();

            Int64 employeeID=_CurrentEmployeeEvaluatedID;

            if(employeeID>0)
            {
                String fe=SqlExpressionBuilder.PrepareFilterExpression(ResourceEmployee_CustomEntity.FLD_NAME_EmployeeID,employeeID.ToString(),SQLMatchType.Equal);

                IList<ResourceEmployee_CustomEntity> lst = FCCResourceEmployee_Custom.GetFacadeCreate().GetIL(10000, 1, String.Empty, fe);

                if (lst != null && lst.Count > 0)
                {
                    lblEmployeeName.Text = lst[0].MemberFullName.ToString();
                    lblEmployeeCode.Text = lst[0].EmployeeCode;
                    lblDepartment.Text = lst[0].DepartmentName;
                    lblDesignation.Text = lst[0].DesignationName;
                    lblConfirmDate.Text = lst[0].ConfirmDate.ToStringDefault();
                    lblJoinDate.Text = lst[0].JoinDate.ToStringDefault();

                    lblSessionEvaluatedBy.Text = CurrentMember.FirstName+" "+CurrentMember.MiddleName+" "+CurrentMember.LastName;

                    if (lst[0].EmployeeID == MiscUtil.GetCurrentEmployeeByMemberID(CurrentMember))
                    {
                        lblSessionEvaluatedBy.Text += " (Self)";
                    }
                    else
                    {
                        lblSessionEvaluatedBy.Text += " (Supervisor)";
                    }
                }
            }

            String fe_session=SqlExpressionBuilder.PrepareFilterExpression(HRSessionEntity.FLD_NAME_SessionID,_CurrentSessionID.ToString(),SQLMatchType.Equal);
            HRSessionEntity hRSessionEntity = FCCHRSession.GetFacadeCreate().GetByID(_CurrentSessionID);

            if (hRSessionEntity != null && hRSessionEntity.SessionID > 0)
            {
                lblSessionName.Text = hRSessionEntity.SessionName;
                lblSessionStartDate.Text = hRSessionEntity.StartDate.ToStringDefault();
                lblSessionEndDate.Text = hRSessionEntity.EndDate.ToStringDefault();
                lblSessionEvaluationType.Text = "N/A";
            } 
        }

        private void PrepareEditView()
        {
            MDEvaluationCriteriaEntity mDEvaluationCriteriaEntity = CurrentMDEvaluationCriteriaEntity;


            if (!mDEvaluationCriteriaEntity.IsNew)
            { 
            }
        }

        private void BindList()
        {
            BindMDEvaluationCriteriaList();
        }

        private void BindLabel()
        {
            String fe1 = SqlExpressionBuilder.PrepareFilterExpression("HREmployeeEvaluation.EmployeeID", _CurrentEmployeeEvaluatedID.ToString(), SQLMatchType.Equal);
            String fe2 = SqlExpressionBuilder.PrepareFilterExpression("HRSession.SessionID", _CurrentSessionID.ToString(), SQLMatchType.Equal);
            String fe3 = "HREmployeeEvaluationResult.EmployeeResult is not null";

            String fe = SqlExpressionBuilder.PrepareFilterExpression(fe1, SQLJoinType.AND, fe2);

            //fe=SqlExpressionBuilder.PrepareFilterExpression(fe,SQLJoinType.AND,fe3);

            IList<HREmployeeEvaluationSession_CustomEntity> lst=FCCHREmployeeEvaluationSession_Custom.GetFacadeCreate().GetIL(10000,1,String.Empty,fe);

            if (lst != null && lst.Count > 0)
            {

                var resultMyScore = (from s in lst
                                     select s.EmployeeResult).Sum(val => val);

                var resultSupervisor = (from s in lst
                                        select s.Result).Sum(val => val);

                lblMyMarks.Text = resultMyScore.ToString();
                lblSupervisorMarks.Text = resultSupervisor.ToString();
            }
            else
            {
                lblMyMarks.Text = "0";
                lblSupervisorMarks.Text = "0";
            }
        }

        private void BindMDEvaluationCriteriaList()
        {
            lvMDEvaluationCriteria.DataBind();
        }

        private void UpdateEvaluationInfo()
        {
            if (SubmittedAction == "UnLocked")
            {
                try
                {
                    IList<ListViewDataItem> list = lvMDEvaluationCriteria.Items;

                    if (list != null && list.Count > 0)
                    {
                        Int32 tempDataItemIndex = 0;

                        foreach (ListViewDataItem lvdi in list)
                        {
                            //DataKey currentDataKey = lvPRMBOQDetail.DataKeys[tempDataItemIndex++];
                            //Int64 intPreBOQDetailID = (Int64)currentDataKey["BOQDetailID"];
                            //    
                            TextBox txtRemarksLV = (TextBox)lvdi.FindControl("txtRemarksLV");
                            TextBox txtEmployeeResultLV = (TextBox)lvdi.FindControl("txtEmployeeResultLV");
                            TextBox txtSupervisorResultLV = (TextBox)lvdi.FindControl("txtSupervisorResultLV");
                            Label lblQuestionLV = (Label)lvdi.FindControl("lblQuestionLV");
                            Label lblDescriptionLV = (Label)lvdi.FindControl("lblDescriptionLV");
                            DropDownList ddlAnswerScaleID = (DropDownList)lvdi.FindControl("ddlAnswerScaleID");

                            Label lblPointInThisQuestionLV = (Label)lvdi.FindControl("lblPointInThisQuestionLV");
                            Label lblEvaluationCriteriaCategoryIDLV = (Label)lvdi.FindControl("lblEvaluationCriteriaCategoryIDLV");
                            Label lblEmployeeEvaluationResultIDLV = (Label)lvdi.FindControl("lblEmployeeEvaluationResultIDLV");
                            Label lblEmployeeEvaluationIDLV = (Label)lvdi.FindControl("lblEmployeeEvaluationIDLV");
                            Label lblEvaluationCriteriaIDLV = (Label)lvdi.FindControl("lblEvaluationCriteriaIDLV");

                            Int64 resultID = 0;
                            Int64.TryParse(lblEmployeeEvaluationResultIDLV.Text.ToString(), out resultID);

                            HREmployeeEvaluationResultEntity hREmployeeEvaluationResultEntity = new HREmployeeEvaluationResultEntity();

                            if (resultID > 0)
                            {
                                hREmployeeEvaluationResultEntity = FCCHREmployeeEvaluationResult.GetFacadeCreate().GetByID(resultID);
                            }
                            
                            hREmployeeEvaluationResultEntity.EvaluationCriteriaCategoryID = Int64.Parse(lblEvaluationCriteriaCategoryIDLV.Text); // should come from Session
                            hREmployeeEvaluationResultEntity.Question = lblQuestionLV.Text.Trim();
                            hREmployeeEvaluationResultEntity.Description = lblDescriptionLV.Text.Trim();
                            hREmployeeEvaluationResultEntity.EmployeeEvaluationID = Int64.Parse(lblEmployeeEvaluationIDLV.Text);
                            _EmployeeEvaluationID = Int64.Parse(hREmployeeEvaluationResultEntity.EmployeeEvaluationID.ToString());
                            hREmployeeEvaluationResultEntity.EmployeeEvaluationCriteriaID = Int64.Parse(lblEvaluationCriteriaCategoryIDLV.Text);

                            hREmployeeEvaluationResultEntity.AnswerGivenByEmployeeDepartmentName = "";
                            hREmployeeEvaluationResultEntity.EmployeeFullName = "";
                            hREmployeeEvaluationResultEntity.EmployeeCode = "";
                            hREmployeeEvaluationResultEntity.EmployeeEvaluationCriteriaID = Int64.Parse(lblEvaluationCriteriaIDLV.Text);
                            //hREmployeeEvaluationResultEntity.SupervisorEvaluationCriteriaID = Int64.Parse(ddlSupervisorEvaluationCriteriaID.SelectedValue);

                            //hREmployeeEvaluationResultEntity.SupervisorDepartmentName = txtSupervisorDepartmentName.Text.Trim();
                            //hREmployeeEvaluationResultEntity.AnswerGivenBySupervisorEmployeeFullName = txtAnswerGivenBySupervisorEmployeeFullName.Text.Trim();
                            //hREmployeeEvaluationResultEntity.SupervisorEmployeeCode = txtSupervisorEmployeeCode.Text.Trim();
                            //if (!txtEmployeeResultLV.Text.Trim().IsNullOrEmpty())
                            //{
                            //    hREmployeeEvaluationResultEntity.EmployeeResult = Int32.Parse(txtEmployeeResultLV.Text.Trim());
                            //}
                            //else
                            //{
                            //    hREmployeeEvaluationResultEntity.EmployeeResult = null;
                            //}

                            if (Action == "Employee")
                            {
                                if (ddlAnswerScaleID != null && ddlAnswerScaleID.Items.Count > 0)
                                {
                                    hREmployeeEvaluationResultEntity.EmployeeResult = Int32.Parse(ddlAnswerScaleID.SelectedValue.Trim());
                                }
                                else
                                {
                                    hREmployeeEvaluationResultEntity.EmployeeResult = null;
                                }
                                hREmployeeEvaluationResultEntity.Remarks = txtRemarksLV.Text.Trim().ToString();
                            }

                            if (Action == "Supervisor")
                            {
                                if (ddlAnswerScaleID != null && ddlAnswerScaleID.Items.Count > 0)
                                {
                                    hREmployeeEvaluationResultEntity.Result = Int32.Parse(ddlAnswerScaleID.SelectedValue.Trim());
                                 
                                }
                                else
                                {
                                    hREmployeeEvaluationResultEntity.Result = null;
                                }
                                hREmployeeEvaluationResultEntity.Extra1 = txtRemarksLV.Text.Trim().ToString();
                            }

                            

                            //if (!lblPointInThisQuestionLV.Text.Trim().IsNullOrEmpty())
                            //{
                            //    hREmployeeEvaluationResultEntity.PointInThisQuestion = Int32.Parse(lblPointInThisQuestionLV.Text.Trim());
                            //}
                            //else
                            //{
                            //    hREmployeeEvaluationResultEntity.PointInThisQuestion = null;
                            //}

                            
                            
                            hREmployeeEvaluationResultEntity.Extra2 = "";

                           

                            if (resultID > 0)
                            {
                                
                                String fe = SqlExpressionBuilder.PrepareFilterExpression(HREmployeeEvaluationResultEntity.FLD_NAME_EmployeeEvaluationResultID, resultID.ToString(), SQLMatchType.Equal);

                                FCCHREmployeeEvaluationResult.GetFacadeCreate().Update(hREmployeeEvaluationResultEntity, fe, DatabaseOperationType.Update, TransactionRequired.No);
                            }

                            else
                            {
                                FCCHREmployeeEvaluationResult.GetFacadeCreate().Add(hREmployeeEvaluationResultEntity, DatabaseOperationType.Add, TransactionRequired.No);
                            }

                            MiscUtil.ShowMessage(lblMessage, "Evaluation Information has been saved successfully.", false);


                        }
                        BindMDEvaluationCriteriaList();
                        BindLabel();

                    }
                }
                catch (Exception ex)
                {
                    MiscUtil.ShowMessage(lblMessage, "Failed to Save Evaluation Information.", true);
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

        protected void lvMDEvaluationCriteria_ItemDataBound(object sender, ListViewItemEventArgs e)
        {
            if (e.Item.ItemType == ListViewItemType.DataItem)
            {
                ListViewDataItem dataItem = (ListViewDataItem)e.Item;

                HREmployeeEvaluationSession_CustomEntity ent = (HREmployeeEvaluationSession_CustomEntity)dataItem.DataItem;

                DropDownList ddlAnswerScaleID = (DropDownList)e.Item.FindControl("ddlAnswerScaleID");
                Label lblEvaluationCriteriaCategoryIDLV = (Label)e.Item.FindControl("lblEvaluationCriteriaCategoryIDLV");
                Panel pnlDropdownAnswer = (Panel)e.Item.FindControl("pnlDropdownAnswer");


                switch (Int64.Parse(lblEvaluationCriteriaCategoryIDLV.Text))
                {
                    case MasterDataConstants.MDEvaluationCriteriaCategory.YES_NO:

                        #region Yes-No
                        pnlDropdownAnswer.Visible = true;

                        ddlAnswerScaleID.Items.Add(new ListItem("Yes", "1"));
                        ddlAnswerScaleID.Items.Add(new ListItem("No", "2"));

                        #endregion

                        break;

                    case MasterDataConstants.MDEvaluationCriteriaCategory.SELECTION:

                        #region Selection Process

                        pnlDropdownAnswer.Visible = true;

                        ddlAnswerScaleID.Items.Add(new ListItem("Excellent(5)", "5"));
                        ddlAnswerScaleID.Items.Add(new ListItem("Good(4)", "4"));
                        ddlAnswerScaleID.Items.Add(new ListItem("Satisfactory(3)", "3"));
                        ddlAnswerScaleID.Items.Add(new ListItem("Needs Improvement(2)", "2"));
                        ddlAnswerScaleID.Items.Add(new ListItem("Lacking(1)", "1"));

                        #endregion

                        break;

                    case MasterDataConstants.MDEvaluationCriteriaCategory.WRITTEN:
                        pnlDropdownAnswer.Visible = false;
                        break;

                    case MasterDataConstants.MDEvaluationCriteriaCategory.VERBAL:
                        break;
                }

                
                    
                TextBox txtRemarksLV = (TextBox)e.Item.FindControl("txtRemarksLV");
                Label lblEmployeeAnswer = (Label)e.Item.FindControl("lblEmployeeAnswer");
                Label lblEmployeeRemarks = (Label)e.Item.FindControl("lblEmployeeRemarks");
                Panel pnlEmployeeAnswer = (Panel)e.Item.FindControl("pnlEmployeeAnswer");

                if(Action=="Supervisor")
                {
                    if (ent.Result.HasValue)
                    {
                        if (ent.Result > 0)
                        {
                            ddlAnswerScaleID.SelectedValue = ent.Result.ToString();
                        }
                    }

                    else
                    {
                        ddlAnswerScaleID.SelectedValue = "3";
                    }

                    txtRemarksLV.Text = ent.SupervisorRemarks;

                    String EmployeeRemarks = "";

                    if (ent.EmployeeResult > 0)
                        {
                            pnlEmployeeAnswer.Visible= true;

                            switch (Int64.Parse(lblEvaluationCriteriaCategoryIDLV.Text))
                            {
                                case MasterDataConstants.MDEvaluationCriteriaCategory.YES_NO:

                                    #region Yes-No

                                    switch (ent.EmployeeResult)
                                    {
                                        case 1:
                                            EmployeeRemarks = "Yes";
                                            break;
                                        case 2:
                                            EmployeeRemarks = "No";
                                            break;
                                    }

                                    #endregion

                                    break;

                                case MasterDataConstants.MDEvaluationCriteriaCategory.SELECTION:

                                    #region Selection Process

                                    switch (ent.EmployeeResult)
                                    {
                                        case 1:
                                            EmployeeRemarks = "Lacking(1)";
                                            break;
                                        case 2:
                                            EmployeeRemarks = "Needs Improvement(2)";
                                            break;
                                        case 3:
                                            EmployeeRemarks = "Satisfactory(3)";
                                            break;
                                        case 4:
                                            EmployeeRemarks = "Good(4)";
                                            break;
                                        case 5:
                                            EmployeeRemarks = "Excellent(5)";
                                            break;

                                    }

                                    #endregion

                                    break;

                                case MasterDataConstants.MDEvaluationCriteriaCategory.WRITTEN:
                                    pnlDropdownAnswer.Visible = false;
                                    break;

                                case MasterDataConstants.MDEvaluationCriteriaCategory.VERBAL:
                                    break;
                            }

                      
                        lblEmployeeAnswer.Text = EmployeeRemarks;
                        lblEmployeeRemarks.Text = ent.Remarks;
                    }

                }

                if(Action=="Employee")
                {
                    if (ent.EmployeeResult.HasValue)
                    {
                        if (ent.EmployeeResult > 0)
                        {
                            ddlAnswerScaleID.SelectedValue = ent.EmployeeResult.ToString();
                        }
                    }

                    else
                    {
                        ddlAnswerScaleID.SelectedValue = "3";
                    }
                    txtRemarksLV.Text = ent.Remarks;
                }
            }
        }

        protected void lvMDEvaluationCriteria_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            Int64 EvaluationCriteriaID;

            Int64.TryParse(e.CommandArgument.ToString(), out EvaluationCriteriaID);

            if (EvaluationCriteriaID > 0)
            {
                if (string.Equals(e.CommandName, "EditItem"))
                {
                    _EvaluationCriteriaID = EvaluationCriteriaID;

                    PrepareEditView();
                }
                else if (string.Equals(e.CommandName, "DeleteItem"))
                {
                    try
                    {
                        Int64 result = -1;

                        String fe = SqlExpressionBuilder.PrepareFilterExpression(MDEvaluationCriteriaEntity.FLD_NAME_EvaluationCriteriaID, EvaluationCriteriaID.ToString(), SQLMatchType.Equal);

                        MDEvaluationCriteriaEntity mDEvaluationCriteriaEntity = new MDEvaluationCriteriaEntity();


                        result = FCCMDEvaluationCriteria.GetFacadeCreate().Delete(mDEvaluationCriteriaEntity, fe, DatabaseOperationType.Delete, TransactionRequired.No);

                        if (result == 0)
                        {
                            _EvaluationCriteriaID = 0;
                            _MDEvaluationCriteriaEntity = new MDEvaluationCriteriaEntity();
                            PrepareInitialView();
                            BindMDEvaluationCriteriaList();

                            MiscUtil.ShowMessage(lblMessage, "Evaluation Criteria has been successfully deleted.", true);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to delete Evaluation Criteria.", true);
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

        protected void odsMDEvaluationCriteria_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {
            if (e.ExecutingSelectCount == false && e.Arguments.SortExpression == String.Empty)
            {
                UpdateEvaluationInfo();
            }

            String fe = String.Empty;

            String fe1 = SqlExpressionBuilder.PrepareFilterExpression("HREmployeeEvaluation.EmployeeID", _CurrentEmployeeEvaluatedID.ToString(), SQLMatchType.Equal);
            String fe2 = SqlExpressionBuilder.PrepareFilterExpression("HRSession.SessionID", _CurrentSessionID.ToString(), SQLMatchType.Equal);
            

            #region Submit Button

            if (Action == "Employee")
            {

                String fe11 = SqlExpressionBuilder.PrepareFilterExpression("HREmployeeEvaluation.EmployeeID", _CurrentEmployeeEvaluatedID.ToString(), SQLMatchType.Equal);
                String fe22 = SqlExpressionBuilder.PrepareFilterExpression("HRSession.SessionID", _CurrentSessionID.ToString(), SQLMatchType.Equal);
                String fe33 = "HREmployeeEvaluationResult.EmployeeResult is not null";
                String fe_employeenew = SqlExpressionBuilder.PrepareFilterExpression("MDEvaluationCriteria.SupervisorWillAnswer", "0".ToString(), SQLMatchType.Equal);

                String fefe = SqlExpressionBuilder.PrepareFilterExpression(fe11, SQLJoinType.AND, fe22);
                String fe4 = SqlExpressionBuilder.PrepareFilterExpression(fe_employeenew, SQLJoinType.AND, fe33);

                fefe = SqlExpressionBuilder.PrepareFilterExpression(fefe, SQLJoinType.AND, fe4);
                fe = fe_employeenew;
                IList<HREmployeeEvaluationSession_CustomEntity> lst = FCCHREmployeeEvaluationSession_Custom.GetFacadeCreate().GetIL(10000, 1, String.Empty, fefe);

                if (lst != null && lst.Count > 0)
                {

                    if (lst[0].SessionCategoryID == MasterDataConstants.MDEvaluationSessionCategory.QUARTERLY_EVALUATIONS)
                    {
                        if (lst != null && lst.Count == 6)
                        {
                            btnSubmit.Visible = true;
                        }
                        if (lblFormLock.Visible == true)
                        {
                            btnSubmit.Visible = false;
                        }
                    }
                    else if (lst[0].SessionCategoryID == MasterDataConstants.MDEvaluationSessionCategory.HEALTH_CHECKUP)
                    {
                        if (lst != null && lst.Count == 32)
                        {
                            btnSubmit.Visible = true;
                        }
                        if (lblFormLock.Visible == true)
                        {
                            btnSubmit.Visible = false;
                        }
                    }
                    else if (lst[0].SessionCategoryID == MasterDataConstants.MDEvaluationSessionCategory.PBR)
                    {
                        if (lst != null && lst.Count == 5)
                        {
                            btnSubmit.Visible = true;
                        }
                        if (lblFormLock.Visible == true)
                        {
                            btnSubmit.Visible = false;
                        }
                    }
                }
            }

            if (Action == "Supervisor")
            {

                String fe11 = SqlExpressionBuilder.PrepareFilterExpression("HREmployeeEvaluation.SupervisorEmployeeID", _SupervisorEmployeeID.ToString(), SQLMatchType.Equal);
                String fe22 = SqlExpressionBuilder.PrepareFilterExpression("HRSession.SessionID", _CurrentSessionID.ToString(), SQLMatchType.Equal);
                String fe_employee = SqlExpressionBuilder.PrepareFilterExpression("HREmployeeEvaluation.EmployeeID", _CurrentEmployeeEvaluatedID.ToString(), SQLMatchType.Equal);
                String fe33 = "HREmployeeEvaluationResult.Result is not null";

                String fefe = SqlExpressionBuilder.PrepareFilterExpression(fe11, SQLJoinType.AND, fe22);
                String fe4 = SqlExpressionBuilder.PrepareFilterExpression(fe33, SQLJoinType.AND, fe_employee);
                fefe = SqlExpressionBuilder.PrepareFilterExpression(fefe, SQLJoinType.AND, fe4);

                IList<HREmployeeEvaluationSession_CustomEntity> lst = FCCHREmployeeEvaluationSession_Custom.GetFacadeCreate().GetIL(10000, 1, String.Empty, fefe);

                if (lst != null && lst.Count > 0)
                {
                    if (lst[0].SessionCategoryID == MasterDataConstants.MDEvaluationSessionCategory.QUARTERLY_EVALUATIONS)
                    {
                        if (lst.Count == 6)
                        {

                            btnSubmit.Visible = true;
                        }

                        if (lblFormLock.Visible == true)
                        {
                            btnSubmit.Visible = false;
                        }
                    }
                    else if (lst[0].SessionCategoryID == MasterDataConstants.MDEvaluationSessionCategory.HEALTH_CHECKUP)
                    {
                        if (lst != null && lst.Count < 32)
                        {
                            btnSubmit.Visible = true;
                        }
                        if (lblFormLock.Visible == true)
                        {
                            btnSubmit.Visible = false;
                        }
                    }
                    else if (lst[0].SessionCategoryID == MasterDataConstants.MDEvaluationSessionCategory.PBR)
                    {
                        if (lst != null && lst.Count == 5)
                        {
                            btnSubmit.Visible = true;
                        }
                        if (lblFormLock.Visible == true)
                        {
                            btnSubmit.Visible = false;
                        }
                    }
                }
            }

            #endregion

            fe = SqlExpressionBuilder.PrepareFilterExpression(fe1, SQLJoinType.AND, fe2);

            if (Action == "Employee")
            {
                String fe_employeenew = SqlExpressionBuilder.PrepareFilterExpression("MDEvaluationCriteria.SupervisorWillAnswer", "0".ToString(), SQLMatchType.Equal);
                fe = SqlExpressionBuilder.PrepareFilterExpression(fe, SQLJoinType.AND, fe_employeenew);
            }

            e.InputParameters["filterExpression"] = fe;
        }

        #endregion

        #region Button Event

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            //String fe1 = SqlExpressionBuilder.PrepareFilterExpression("HREmployeeEvaluation.EmployeeID", MiscUtil.GetCurrentEmployeeByMemberID(CurrentMember).ToString(), SQLMatchType.Equal);
            //String fe2 = SqlExpressionBuilder.PrepareFilterExpression("HRSession.SessionID", "1", SQLMatchType.Equal);
            //String fe3 = "HREmployeeEvaluationResult.EmployeeResult is not null";

            //String fe = SqlExpressionBuilder.PrepareFilterExpression(fe1, SQLJoinType.AND, fe2);

            //fe = SqlExpressionBuilder.PrepareFilterExpression(fe, SQLJoinType.AND, fe3);

            //IList<HREmployeeEvaluationSession_CustomEntity> lst = FCCHREmployeeEvaluationSession_Custom.GetFacadeCreate().GetIL(10000, 1, String.Empty, fe);

            //if(lst!=null && lst.cou


           // UpdateEvaluationInfo();

            if (_EmployeeEvaluationID > 0)
            {
                HREmployeeEvaluationEntity hREmployeeEvaluationEntity = FCCHREmployeeEvaluation.GetFacadeCreate().GetByID(_EmployeeEvaluationID);

                if (Action == "Supervisor")
                {
                    hREmployeeEvaluationEntity.SupervisorSubmitDate = System.DateTime.Now;
                }
                if (Action == "Employee")
                {
                    hREmployeeEvaluationEntity.EmployeeSubmitDate = System.DateTime.Now;
                }

                Int64 result = -1;

                String fe_update = SqlExpressionBuilder.PrepareFilterExpression(HREmployeeEvaluationEntity.FLD_NAME_EmployeeEvaluationID, _EmployeeEvaluationID.ToString(), SQLMatchType.Equal);
                result = FCCHREmployeeEvaluation.GetFacadeCreate().Update(hREmployeeEvaluationEntity, fe_update, DatabaseOperationType.Update, TransactionRequired.No);

                if (result > 0)
                {
                    MiscUtil.ShowMessage(lblMessage, "Submitted Successfully.", false);
                    SubmitButtonEnable();
                }

                else
                {
                    MiscUtil.ShowMessage(lblMessage, "Some Error Occoured.", false);
                }
            }
        }

        #endregion

        #endregion Event
    }
}
