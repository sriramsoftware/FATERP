// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 02-Sep-2013, 03:21:45




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
    public partial class MDEvaluationSessionStatusControl : BaseControl
    {       
        #region Properties

        public Int64 _EvaluationSessionStatusID
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

        public MDEvaluationSessionStatusEntity _MDEvaluationSessionStatusEntity
        {
            get
            {
                MDEvaluationSessionStatusEntity entity = new MDEvaluationSessionStatusEntity();

                if (ViewState["CurrentEntity"] != null)
                {
                    entity = (MDEvaluationSessionStatusEntity)ViewState["CurrentEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["CurrentEntity"] = value;
            }
        }

        private MDEvaluationSessionStatusEntity CurrentMDEvaluationSessionStatusEntity
        {
            get
            {
                if (_EvaluationSessionStatusID > 0)
                {
                    if (_MDEvaluationSessionStatusEntity.EvaluationSessionStatusID != _EvaluationSessionStatusID)
                    {
                        _MDEvaluationSessionStatusEntity = FCCMDEvaluationSessionStatus.GetFacadeCreate().GetByID(_EvaluationSessionStatusID);
                    }
                }

                return _MDEvaluationSessionStatusEntity;
            }
            set
            {
                _MDEvaluationSessionStatusEntity = value;
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
            MDEvaluationSessionStatusEntity mDEvaluationSessionStatusEntity = CurrentMDEvaluationSessionStatusEntity;


            if (!mDEvaluationSessionStatusEntity.IsNew)
            {
                txtName.Text = mDEvaluationSessionStatusEntity.Name.ToString();
                txtDescription.Text = mDEvaluationSessionStatusEntity.Description.ToString();
                chkIsRemoved.Checked = mDEvaluationSessionStatusEntity.IsRemoved;

                btnSubmit.Text = "Update";
                btnAddNew.Visible = true;
            }
        }

        private void BindList()
        {
            BindMDEvaluationSessionStatusList();
        }

        private void BindMDEvaluationSessionStatusList()
        {
            lvMDEvaluationSessionStatus.DataBind();
        }

        private MDEvaluationSessionStatusEntity BuildMDEvaluationSessionStatusEntity()
        {
            MDEvaluationSessionStatusEntity mDEvaluationSessionStatusEntity = CurrentMDEvaluationSessionStatusEntity;

            mDEvaluationSessionStatusEntity.Name = txtName.Text.Trim();
            mDEvaluationSessionStatusEntity.Description = txtDescription.Text.Trim();
            mDEvaluationSessionStatusEntity.IsRemoved = chkIsRemoved.Checked;


            return mDEvaluationSessionStatusEntity;
        }

        private void SaveMDEvaluationSessionStatusEntity()
        {
            if (IsValid)
            {
                try
                {
                    MDEvaluationSessionStatusEntity mDEvaluationSessionStatusEntity = BuildMDEvaluationSessionStatusEntity();

                    Int64 result = -1;

                    if (mDEvaluationSessionStatusEntity.IsNew)
                    {
                        result = FCCMDEvaluationSessionStatus.GetFacadeCreate().Add(mDEvaluationSessionStatusEntity, DatabaseOperationType.Add, TransactionRequired.No);
                    }
                    else
                    {
                        String filterExpression = SqlExpressionBuilder.PrepareFilterExpression(MDEvaluationSessionStatusEntity.FLD_NAME_EvaluationSessionStatusID, mDEvaluationSessionStatusEntity.EvaluationSessionStatusID.ToString(), SQLMatchType.Equal);
                        result = FCCMDEvaluationSessionStatus.GetFacadeCreate().Update(mDEvaluationSessionStatusEntity, filterExpression, DatabaseOperationType.Update, TransactionRequired.No);
                    }

                    if (result > 0)
                    {
                        _EvaluationSessionStatusID = 0;
                        _MDEvaluationSessionStatusEntity = new MDEvaluationSessionStatusEntity();
                        PrepareInitialView();
                        BindMDEvaluationSessionStatusList();

                        if (mDEvaluationSessionStatusEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Evaluation Session Status Information has been added successfully.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Evaluation Session Status Information has been updated successfully.", false);
                        }
                    }
                    else
                    {
                        if (mDEvaluationSessionStatusEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to add Evaluation Session Status Information.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to update Evaluation Session Status Information.", false);
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

        protected void lvMDEvaluationSessionStatus_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            Int64 EvaluationSessionStatusID;

            Int64.TryParse(e.CommandArgument.ToString(), out EvaluationSessionStatusID);

            if (EvaluationSessionStatusID > 0)
            {
                if (string.Equals(e.CommandName, "EditItem"))
                {
                    _EvaluationSessionStatusID = EvaluationSessionStatusID;

                    PrepareEditView();

                    cpeEditor.Collapsed = false;
                    cpeEditor.ClientState = "false";
                }
                else if (string.Equals(e.CommandName, "DeleteItem"))
                {
                    try
                    {
                        Int64 result = -1;

                        String fe = SqlExpressionBuilder.PrepareFilterExpression(MDEvaluationSessionStatusEntity.FLD_NAME_EvaluationSessionStatusID, EvaluationSessionStatusID.ToString(), SQLMatchType.Equal);

                        MDEvaluationSessionStatusEntity mDEvaluationSessionStatusEntity = new MDEvaluationSessionStatusEntity();


                        result = FCCMDEvaluationSessionStatus.GetFacadeCreate().Delete(mDEvaluationSessionStatusEntity, fe, DatabaseOperationType.Delete, TransactionRequired.No);

                        if (result == 0)
                        {
                            _EvaluationSessionStatusID = 0;
                            _MDEvaluationSessionStatusEntity = new MDEvaluationSessionStatusEntity();
                            PrepareInitialView();
                            BindMDEvaluationSessionStatusList();

                            MiscUtil.ShowMessage(lblMessage, "Evaluation Session Status has been successfully deleted.", true);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to delete Evaluation Session Status.", true);
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

        protected void odsMDEvaluationSessionStatus_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {
            e.InputParameters["filterExpression"] = String.Empty;
        }

        #endregion

        #region Button Event

        protected void btnSave_Click(object sender, EventArgs e)
        {
            SaveMDEvaluationSessionStatusEntity();
        }

        protected void btnAddNew_Click(object sender, EventArgs e)
        {
            _EvaluationSessionStatusID = 0;
            _MDEvaluationSessionStatusEntity = new MDEvaluationSessionStatusEntity();
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
