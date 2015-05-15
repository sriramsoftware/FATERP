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
using System.IO;

namespace Bay.ERP.Web.UI
{
    public partial class MDEvaluationCriteriaControl : BaseControl
    {       
        #region Properties

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
            MiscUtil.PopulateMDEvaluationCriteriaCategory(ddlEvaluationCriteriaCategoryID, false);
            MiscUtil.PopulateMDSupervisorType(ddlSupervisorTypeID, false);
            MiscUtil.PopulateMDEvaluationSessionCategory(ddlEvaluationSessionCategoryID, false);
        }

        private void PrepareValidator()
        {
        }

        private void PrepareInitialView()
        {
            BuildDropDownList();

            txtQuestion.Text = String.Empty;
            txtDescription.Text = String.Empty;
            txtCorrectAnswerIfAny.Text = String.Empty;
            txtCorrectAnswerMarkOrPoint.Text = String.Empty;
            //txtImageUrl.Text = String.Empty;
            txtQuestionOrderInDisplay.Text = String.Empty;
            chkSupervisorWillAnswer.Checked = false;
            chkIsRemoved.Checked = false;

            btnSubmit.Text = "Add";
            btnAddNew.Visible = false;
        }

        private void PrepareEditView()
        {
            MDEvaluationCriteriaEntity mDEvaluationCriteriaEntity = CurrentMDEvaluationCriteriaEntity;


            if (!mDEvaluationCriteriaEntity.IsNew)
            {
                if (ddlEvaluationCriteriaCategoryID.Items.Count > 0 && mDEvaluationCriteriaEntity.EvaluationCriteriaCategoryID != null)
                {
                    ddlEvaluationCriteriaCategoryID.SelectedValue = mDEvaluationCriteriaEntity.EvaluationCriteriaCategoryID.ToString();
                }

                if (ddlSupervisorTypeID.Items.Count > 0 && mDEvaluationCriteriaEntity.SupervisorTypeID != null)
                {
                    ddlSupervisorTypeID.SelectedValue = mDEvaluationCriteriaEntity.SupervisorTypeID.ToString();
                }

                if (ddlEvaluationSessionCategoryID.Items.Count > 0 && mDEvaluationCriteriaEntity.EvaluationSessionCategoryID != null)
                {
                    ddlEvaluationSessionCategoryID.SelectedValue = mDEvaluationCriteriaEntity.EvaluationSessionCategoryID.ToString();
                }

                txtQuestion.Text = mDEvaluationCriteriaEntity.Question.ToString();
                txtDescription.Text = mDEvaluationCriteriaEntity.Description.ToString();
                txtCorrectAnswerIfAny.Text = mDEvaluationCriteriaEntity.CorrectAnswerIfAny.ToString();
                txtCorrectAnswerMarkOrPoint.Text = mDEvaluationCriteriaEntity.CorrectAnswerMarkOrPoint.ToString();
                txtQuestionOrderInDisplay.Text = mDEvaluationCriteriaEntity.QuestionOrderInDisplay.ToString();
                chkSupervisorWillAnswer.Checked = mDEvaluationCriteriaEntity.SupervisorWillAnswer;
                chkIsRemoved.Checked = mDEvaluationCriteriaEntity.IsRemoved;

                btnSubmit.Text = "Update";
                btnAddNew.Visible = true;
            }
        }

        private void BindList()
        {
            BindMDEvaluationCriteriaList();
        }

        private void BindMDEvaluationCriteriaList()
        {
            lvMDEvaluationCriteria.DataBind();
        }

        private MDEvaluationCriteriaEntity BuildMDEvaluationCriteriaEntity()
        {
            MDEvaluationCriteriaEntity mDEvaluationCriteriaEntity = CurrentMDEvaluationCriteriaEntity;

            if (ddlEvaluationCriteriaCategoryID.Items.Count > 0)
            {
                if (ddlEvaluationCriteriaCategoryID.SelectedValue == "0")
                {
                }
                else
                {
                    mDEvaluationCriteriaEntity.EvaluationCriteriaCategoryID = Int64.Parse(ddlEvaluationCriteriaCategoryID.SelectedValue);
                }
            }

            if (ddlSupervisorTypeID.Items.Count > 0)
            {
                if (ddlSupervisorTypeID.SelectedValue == "0")
                {
                }
                else
                {
                    mDEvaluationCriteriaEntity.SupervisorTypeID = Int64.Parse(ddlSupervisorTypeID.SelectedValue);
                }
            }

            if (ddlEvaluationSessionCategoryID.Items.Count > 0)
            {
                if (ddlEvaluationSessionCategoryID.SelectedValue == "0")
                {
                }
                else
                {
                    mDEvaluationCriteriaEntity.EvaluationSessionCategoryID = Int64.Parse(ddlEvaluationSessionCategoryID.SelectedValue);
                }
            }

            mDEvaluationCriteriaEntity.Question = txtQuestion.Text.Trim();
            mDEvaluationCriteriaEntity.Description = txtDescription.Text.Trim();
            mDEvaluationCriteriaEntity.CorrectAnswerIfAny = txtCorrectAnswerIfAny.Text.Trim();
            if (!txtCorrectAnswerMarkOrPoint.Text.Trim().IsNullOrEmpty())
            {
                mDEvaluationCriteriaEntity.CorrectAnswerMarkOrPoint = Int32.Parse(txtCorrectAnswerMarkOrPoint.Text.Trim());
            }
            else
            {
                mDEvaluationCriteriaEntity.CorrectAnswerMarkOrPoint = null;
            }

            String HoverImageUrlpath;

            if (fuImageUrl.HasFile == true && mDEvaluationCriteriaEntity.ImageUrl.IsNotNullOrEmpty())
            {
                if (File.Exists(Server.MapPath(mDEvaluationCriteriaEntity.ImageUrl)))
                {
                    File.Delete(Server.MapPath(mDEvaluationCriteriaEntity.ImageUrl));
                }

                HoverImageUrlpath = FileUploadConstants.HR.HREvaluation+ Guid.NewGuid() + fuImageUrl.FileName;
                fuImageUrl.SaveAs(Server.MapPath(HoverImageUrlpath));
                mDEvaluationCriteriaEntity.ImageUrl = HoverImageUrlpath;
            }

            if (mDEvaluationCriteriaEntity.ImageUrl.IsNotNullOrEmpty() && fuImageUrl.HasFile == false)
            {
                mDEvaluationCriteriaEntity.ImageUrl = mDEvaluationCriteriaEntity.ImageUrl;
            }

            if (fuImageUrl.HasFile == false && mDEvaluationCriteriaEntity.ImageUrl.IsNullOrEmpty())
            {
                mDEvaluationCriteriaEntity.ImageUrl = null;
            }

            if (fuImageUrl.HasFile == true && mDEvaluationCriteriaEntity.ImageUrl.IsNullOrEmpty())
            {
                HoverImageUrlpath = FileUploadConstants.DashboardItem.DashboardItemHoverImageUrl + Guid.NewGuid() + fuImageUrl.FileName;
                fuImageUrl.SaveAs(Server.MapPath(HoverImageUrlpath));
                mDEvaluationCriteriaEntity.ImageUrl = HoverImageUrlpath;
            }

            if (!txtQuestionOrderInDisplay.Text.Trim().IsNullOrEmpty())
            {
                mDEvaluationCriteriaEntity.QuestionOrderInDisplay = Int32.Parse(txtQuestionOrderInDisplay.Text.Trim());
            }
            else
            {
                mDEvaluationCriteriaEntity.QuestionOrderInDisplay = null;
            }

            mDEvaluationCriteriaEntity.SupervisorWillAnswer = chkSupervisorWillAnswer.Checked;
            mDEvaluationCriteriaEntity.IsRemoved = chkIsRemoved.Checked;

            mDEvaluationCriteriaEntity.CreatedByEmployeeID = MiscUtil.GetCurrentEmployeeByMemberID(CurrentMember);
            mDEvaluationCriteriaEntity.CreateDate = System.DateTime.Now;

            return mDEvaluationCriteriaEntity;
        }

        private void SaveMDEvaluationCriteriaEntity()
        {
            if (IsValid)
            {
                try
                {
                    MDEvaluationCriteriaEntity mDEvaluationCriteriaEntity = BuildMDEvaluationCriteriaEntity();

                    Int64 result = -1;

                    if (mDEvaluationCriteriaEntity.IsNew)
                    {
                        result = FCCMDEvaluationCriteria.GetFacadeCreate().Add(mDEvaluationCriteriaEntity, DatabaseOperationType.Add, TransactionRequired.No);
                    }
                    else
                    {
                        String filterExpression = SqlExpressionBuilder.PrepareFilterExpression(MDEvaluationCriteriaEntity.FLD_NAME_EvaluationCriteriaID, mDEvaluationCriteriaEntity.EvaluationCriteriaID.ToString(), SQLMatchType.Equal);
                        result = FCCMDEvaluationCriteria.GetFacadeCreate().Update(mDEvaluationCriteriaEntity, filterExpression, DatabaseOperationType.Update, TransactionRequired.No);
                    }

                    if (result > 0)
                    {
                        _EvaluationCriteriaID = 0;
                        _MDEvaluationCriteriaEntity = new MDEvaluationCriteriaEntity();
                        PrepareInitialView();
                        BindMDEvaluationCriteriaList();

                        if (mDEvaluationCriteriaEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Evaluation Criteria Information has been added successfully.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Evaluation Criteria Information has been updated successfully.", false);
                        }
                    }
                    else
                    {
                        if (mDEvaluationCriteriaEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to add Evaluation Criteria Information.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to update Evaluation Criteria Information.", false);
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

                    cpeEditor.Collapsed = false;
                    cpeEditor.ClientState = "false";
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
            e.InputParameters["filterExpression"] = String.Empty;
        }

        #endregion

        #region Button Event

        protected void btnSave_Click(object sender, EventArgs e)
        {
            SaveMDEvaluationCriteriaEntity();
        }

        protected void btnAddNew_Click(object sender, EventArgs e)
        {
            _EvaluationCriteriaID = 0;
            _MDEvaluationCriteriaEntity = new MDEvaluationCriteriaEntity();
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
