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
    public partial class MDEvaluationCriteriaCategoryControl : BaseControl
    {       
        #region Properties

        public Int64 _EvaluationCriteriaCategoryID
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

        public MDEvaluationCriteriaCategoryEntity _MDEvaluationCriteriaCategoryEntity
        {
            get
            {
                MDEvaluationCriteriaCategoryEntity entity = new MDEvaluationCriteriaCategoryEntity();

                if (ViewState["CurrentEntity"] != null)
                {
                    entity = (MDEvaluationCriteriaCategoryEntity)ViewState["CurrentEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["CurrentEntity"] = value;
            }
        }

        private MDEvaluationCriteriaCategoryEntity CurrentMDEvaluationCriteriaCategoryEntity
        {
            get
            {
                if (_EvaluationCriteriaCategoryID > 0)
                {
                    if (_MDEvaluationCriteriaCategoryEntity.EvaluationCriteriaCategoryID != _EvaluationCriteriaCategoryID)
                    {
                        _MDEvaluationCriteriaCategoryEntity = FCCMDEvaluationCriteriaCategory.GetFacadeCreate().GetByID(_EvaluationCriteriaCategoryID);
                    }
                }

                return _MDEvaluationCriteriaCategoryEntity;
            }
            set
            {
                _MDEvaluationCriteriaCategoryEntity = value;
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

            txtName.Text = String.Empty;
            txtDescription.Text = String.Empty;
            chkIsRemoved.Checked = false;

            btnSubmit.Text = "Add";
            btnAddNew.Visible = false;
        }

        private void PrepareEditView()
        {
            MDEvaluationCriteriaCategoryEntity mDEvaluationCriteriaCategoryEntity = CurrentMDEvaluationCriteriaCategoryEntity;


            if (!mDEvaluationCriteriaCategoryEntity.IsNew)
            {
                txtName.Text = mDEvaluationCriteriaCategoryEntity.Name.ToString();
                txtDescription.Text = mDEvaluationCriteriaCategoryEntity.Description.ToString();
                chkIsRemoved.Checked = mDEvaluationCriteriaCategoryEntity.IsRemoved;

                btnSubmit.Text = "Update";
                btnAddNew.Visible = true;
            }
        }

        private void BindList()
        {
            BindMDEvaluationCriteriaCategoryList();
        }

        private void BindMDEvaluationCriteriaCategoryList()
        {
            lvMDEvaluationCriteriaCategory.DataBind();
        }

        private MDEvaluationCriteriaCategoryEntity BuildMDEvaluationCriteriaCategoryEntity()
        {
            MDEvaluationCriteriaCategoryEntity mDEvaluationCriteriaCategoryEntity = CurrentMDEvaluationCriteriaCategoryEntity;

            mDEvaluationCriteriaCategoryEntity.Name = txtName.Text.Trim();
            mDEvaluationCriteriaCategoryEntity.Description = txtDescription.Text.Trim();
            mDEvaluationCriteriaCategoryEntity.IsRemoved = chkIsRemoved.Checked;


            return mDEvaluationCriteriaCategoryEntity;
        }

        private void SaveMDEvaluationCriteriaCategoryEntity()
        {
            if (IsValid)
            {
                try
                {
                    MDEvaluationCriteriaCategoryEntity mDEvaluationCriteriaCategoryEntity = BuildMDEvaluationCriteriaCategoryEntity();

                    Int64 result = -1;

                    if (mDEvaluationCriteriaCategoryEntity.IsNew)
                    {
                        result = FCCMDEvaluationCriteriaCategory.GetFacadeCreate().Add(mDEvaluationCriteriaCategoryEntity, DatabaseOperationType.Add, TransactionRequired.No);
                    }
                    else
                    {
                        String filterExpression = SqlExpressionBuilder.PrepareFilterExpression(MDEvaluationCriteriaCategoryEntity.FLD_NAME_EvaluationCriteriaCategoryID, mDEvaluationCriteriaCategoryEntity.EvaluationCriteriaCategoryID.ToString(), SQLMatchType.Equal);
                        result = FCCMDEvaluationCriteriaCategory.GetFacadeCreate().Update(mDEvaluationCriteriaCategoryEntity, filterExpression, DatabaseOperationType.Update, TransactionRequired.No);
                    }

                    if (result > 0)
                    {
                        _EvaluationCriteriaCategoryID = 0;
                        _MDEvaluationCriteriaCategoryEntity = new MDEvaluationCriteriaCategoryEntity();
                        PrepareInitialView();
                        BindMDEvaluationCriteriaCategoryList();

                        if (mDEvaluationCriteriaCategoryEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Evaluation Criteria Category Information has been added successfully.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Evaluation Criteria Category Information has been updated successfully.", false);
                        }
                    }
                    else
                    {
                        if (mDEvaluationCriteriaCategoryEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to add Evaluation Criteria Category Information.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to update Evaluation Criteria Category Information.", false);
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

        protected void lvMDEvaluationCriteriaCategory_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            Int64 EvaluationCriteriaCategoryID;

            Int64.TryParse(e.CommandArgument.ToString(), out EvaluationCriteriaCategoryID);

            if (EvaluationCriteriaCategoryID > 0)
            {
                if (string.Equals(e.CommandName, "EditItem"))
                {
                    _EvaluationCriteriaCategoryID = EvaluationCriteriaCategoryID;

                    PrepareEditView();

                    cpeEditor.Collapsed = false;
                    cpeEditor.ClientState = "false";
                }
                else if (string.Equals(e.CommandName, "DeleteItem"))
                {
                    try
                    {
                        Int64 result = -1;

                        String fe = SqlExpressionBuilder.PrepareFilterExpression(MDEvaluationCriteriaCategoryEntity.FLD_NAME_EvaluationCriteriaCategoryID, EvaluationCriteriaCategoryID.ToString(), SQLMatchType.Equal);

                        MDEvaluationCriteriaCategoryEntity mDEvaluationCriteriaCategoryEntity = new MDEvaluationCriteriaCategoryEntity();


                        result = FCCMDEvaluationCriteriaCategory.GetFacadeCreate().Delete(mDEvaluationCriteriaCategoryEntity, fe, DatabaseOperationType.Delete, TransactionRequired.No);

                        if (result == 0)
                        {
                            _EvaluationCriteriaCategoryID = 0;
                            _MDEvaluationCriteriaCategoryEntity = new MDEvaluationCriteriaCategoryEntity();
                            PrepareInitialView();
                            BindMDEvaluationCriteriaCategoryList();

                            MiscUtil.ShowMessage(lblMessage, "Evaluation Criteria Category has been successfully deleted.", true);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to delete Evaluation Criteria Category.", true);
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

        protected void odsMDEvaluationCriteriaCategory_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {
            e.InputParameters["filterExpression"] = String.Empty;
        }

        #endregion

        #region Button Event

        protected void btnSave_Click(object sender, EventArgs e)
        {
            SaveMDEvaluationCriteriaCategoryEntity();
        }

        protected void btnAddNew_Click(object sender, EventArgs e)
        {
            _EvaluationCriteriaCategoryID = 0;
            _MDEvaluationCriteriaCategoryEntity = new MDEvaluationCriteriaCategoryEntity();
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
