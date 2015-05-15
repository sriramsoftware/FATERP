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
    public partial class MDEvaluationSessionCategoryControl : BaseControl
    {       
        #region Properties

        public Int64 _SessionCategoryID
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

        public MDEvaluationSessionCategoryEntity _MDEvaluationSessionCategoryEntity
        {
            get
            {
                MDEvaluationSessionCategoryEntity entity = new MDEvaluationSessionCategoryEntity();

                if (ViewState["CurrentEntity"] != null)
                {
                    entity = (MDEvaluationSessionCategoryEntity)ViewState["CurrentEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["CurrentEntity"] = value;
            }
        }

        private MDEvaluationSessionCategoryEntity CurrentMDEvaluationSessionCategoryEntity
        {
            get
            {
                if (_SessionCategoryID > 0)
                {
                    if (_MDEvaluationSessionCategoryEntity.SessionCategoryID != _SessionCategoryID)
                    {
                        _MDEvaluationSessionCategoryEntity = FCCMDEvaluationSessionCategory.GetFacadeCreate().GetByID(_SessionCategoryID);
                    }
                }

                return _MDEvaluationSessionCategoryEntity;
            }
            set
            {
                _MDEvaluationSessionCategoryEntity = value;
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
            MDEvaluationSessionCategoryEntity mDEvaluationSessionCategoryEntity = CurrentMDEvaluationSessionCategoryEntity;


            if (!mDEvaluationSessionCategoryEntity.IsNew)
            {
                txtName.Text = mDEvaluationSessionCategoryEntity.Name.ToString();
                txtDescription.Text = mDEvaluationSessionCategoryEntity.Description.ToString();
                chkIsRemoved.Checked = mDEvaluationSessionCategoryEntity.IsRemoved;

                btnSubmit.Text = "Update";
                btnAddNew.Visible = true;
            }
        }

        private void BindList()
        {
            BindMDEvaluationSessionCategoryList();
        }

        private void BindMDEvaluationSessionCategoryList()
        {
            lvMDEvaluationSessionCategory.DataBind();
        }

        private MDEvaluationSessionCategoryEntity BuildMDEvaluationSessionCategoryEntity()
        {
            MDEvaluationSessionCategoryEntity mDEvaluationSessionCategoryEntity = CurrentMDEvaluationSessionCategoryEntity;

            mDEvaluationSessionCategoryEntity.Name = txtName.Text.Trim();
            mDEvaluationSessionCategoryEntity.Description = txtDescription.Text.Trim();
            mDEvaluationSessionCategoryEntity.IsRemoved = chkIsRemoved.Checked;


            return mDEvaluationSessionCategoryEntity;
        }

        private void SaveMDEvaluationSessionCategoryEntity()
        {
            if (IsValid)
            {
                try
                {
                    MDEvaluationSessionCategoryEntity mDEvaluationSessionCategoryEntity = BuildMDEvaluationSessionCategoryEntity();

                    Int64 result = -1;

                    if (mDEvaluationSessionCategoryEntity.IsNew)
                    {
                        result = FCCMDEvaluationSessionCategory.GetFacadeCreate().Add(mDEvaluationSessionCategoryEntity, DatabaseOperationType.Add, TransactionRequired.No);
                    }
                    else
                    {
                        String filterExpression = SqlExpressionBuilder.PrepareFilterExpression(MDEvaluationSessionCategoryEntity.FLD_NAME_SessionCategoryID, mDEvaluationSessionCategoryEntity.SessionCategoryID.ToString(), SQLMatchType.Equal);
                        result = FCCMDEvaluationSessionCategory.GetFacadeCreate().Update(mDEvaluationSessionCategoryEntity, filterExpression, DatabaseOperationType.Update, TransactionRequired.No);
                    }

                    if (result > 0)
                    {
                        _SessionCategoryID = 0;
                        _MDEvaluationSessionCategoryEntity = new MDEvaluationSessionCategoryEntity();
                        PrepareInitialView();
                        BindMDEvaluationSessionCategoryList();

                        if (mDEvaluationSessionCategoryEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Evaluation Session Category Information has been added successfully.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Evaluation Session Category Information has been updated successfully.", false);
                        }
                    }
                    else
                    {
                        if (mDEvaluationSessionCategoryEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to add Evaluation Session Category Information.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to update Evaluation Session Category Information.", false);
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

        protected void lvMDEvaluationSessionCategory_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            Int64 SessionCategoryID;

            Int64.TryParse(e.CommandArgument.ToString(), out SessionCategoryID);

            if (SessionCategoryID > 0)
            {
                if (string.Equals(e.CommandName, "EditItem"))
                {
                    _SessionCategoryID = SessionCategoryID;

                    PrepareEditView();

                    cpeEditor.Collapsed = false;
                    cpeEditor.ClientState = "false";
                }
                else if (string.Equals(e.CommandName, "DeleteItem"))
                {
                    try
                    {
                        Int64 result = -1;

                        String fe = SqlExpressionBuilder.PrepareFilterExpression(MDEvaluationSessionCategoryEntity.FLD_NAME_SessionCategoryID, SessionCategoryID.ToString(), SQLMatchType.Equal);

                        MDEvaluationSessionCategoryEntity mDEvaluationSessionCategoryEntity = new MDEvaluationSessionCategoryEntity();


                        result = FCCMDEvaluationSessionCategory.GetFacadeCreate().Delete(mDEvaluationSessionCategoryEntity, fe, DatabaseOperationType.Delete, TransactionRequired.No);

                        if (result == 0)
                        {
                            _SessionCategoryID = 0;
                            _MDEvaluationSessionCategoryEntity = new MDEvaluationSessionCategoryEntity();
                            PrepareInitialView();
                            BindMDEvaluationSessionCategoryList();

                            MiscUtil.ShowMessage(lblMessage, "Evaluation Session Category has been successfully deleted.", true);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to delete Evaluation Session Category.", true);
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

        protected void odsMDEvaluationSessionCategory_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {
            e.InputParameters["filterExpression"] = String.Empty;
        }

        #endregion

        #region Button Event

        protected void btnSave_Click(object sender, EventArgs e)
        {
            SaveMDEvaluationSessionCategoryEntity();
        }

        protected void btnAddNew_Click(object sender, EventArgs e)
        {
            _SessionCategoryID = 0;
            _MDEvaluationSessionCategoryEntity = new MDEvaluationSessionCategoryEntity();
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
