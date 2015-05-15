// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 30-Nov-2011, 02:49:46




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
    public partial class MDProjectCollectedDocumentStatusControl : BaseControl
    {       
        #region Properties

        public Int64 _ProjectCollectedDocumentStatusID
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

        public MDProjectCollectedDocumentStatusEntity _MDProjectCollectedDocumentStatusEntity
        {
            get
            {
                MDProjectCollectedDocumentStatusEntity entity = new MDProjectCollectedDocumentStatusEntity();

                if (ViewState["CurrentEntity"] != null)
                {
                    entity = (MDProjectCollectedDocumentStatusEntity)ViewState["CurrentEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["CurrentEntity"] = value;
            }
        }

        private MDProjectCollectedDocumentStatusEntity CurrentMDProjectCollectedDocumentStatusEntity
        {
            get
            {
                if (_ProjectCollectedDocumentStatusID > 0)
                {
                    if (_MDProjectCollectedDocumentStatusEntity.ProjectCollectedDocumentStatusID != _ProjectCollectedDocumentStatusID)
                    {
                        _MDProjectCollectedDocumentStatusEntity = FCCMDProjectCollectedDocumentStatus.GetFacadeCreate().GetByID(_ProjectCollectedDocumentStatusID);
                    }
                }

                return _MDProjectCollectedDocumentStatusEntity;
            }
            set
            {
                _MDProjectCollectedDocumentStatusEntity = value;
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
            MDProjectCollectedDocumentStatusEntity mDProjectCollectedDocumentStatusEntity = CurrentMDProjectCollectedDocumentStatusEntity;


            if (!mDProjectCollectedDocumentStatusEntity.IsNew)
            {
                txtName.Text = mDProjectCollectedDocumentStatusEntity.Name.ToString();
                txtDescription.Text = mDProjectCollectedDocumentStatusEntity.Description.ToString();
                chkIsRemoved.Checked = mDProjectCollectedDocumentStatusEntity.IsRemoved;

                btnSubmit.Text = "Update";
                btnAddNew.Visible = true;
            }
        }

        private void BindList()
        {
            BindMDProjectCollectedDocumentStatusList();
        }

        private void BindMDProjectCollectedDocumentStatusList()
        {
            lvMDProjectCollectedDocumentStatus.DataBind();
        }

        private MDProjectCollectedDocumentStatusEntity BuildMDProjectCollectedDocumentStatusEntity()
        {
            MDProjectCollectedDocumentStatusEntity mDProjectCollectedDocumentStatusEntity = CurrentMDProjectCollectedDocumentStatusEntity;

            mDProjectCollectedDocumentStatusEntity.Name = txtName.Text.Trim();
            mDProjectCollectedDocumentStatusEntity.Description = txtDescription.Text.Trim();
            mDProjectCollectedDocumentStatusEntity.IsRemoved = chkIsRemoved.Checked;


            return mDProjectCollectedDocumentStatusEntity;
        }

        private void SaveMDProjectCollectedDocumentStatusEntity()
        {
            if (IsValid)
            {
                try
                {
                    MDProjectCollectedDocumentStatusEntity mDProjectCollectedDocumentStatusEntity = BuildMDProjectCollectedDocumentStatusEntity();

                    Int64 result = -1;

                    if (mDProjectCollectedDocumentStatusEntity.IsNew)
                    {
                        result = FCCMDProjectCollectedDocumentStatus.GetFacadeCreate().Add(mDProjectCollectedDocumentStatusEntity, DatabaseOperationType.Add, TransactionRequired.No);
                    }
                    else
                    {
                        String filterExpression = SqlExpressionBuilder.PrepareFilterExpression(MDProjectCollectedDocumentStatusEntity.FLD_NAME_ProjectCollectedDocumentStatusID, mDProjectCollectedDocumentStatusEntity.ProjectCollectedDocumentStatusID.ToString(), SQLMatchType.Equal);
                        result = FCCMDProjectCollectedDocumentStatus.GetFacadeCreate().Update(mDProjectCollectedDocumentStatusEntity, filterExpression, DatabaseOperationType.Update, TransactionRequired.No);
                    }

                    if (result > 0)
                    {
                        _ProjectCollectedDocumentStatusID = 0;
                        _MDProjectCollectedDocumentStatusEntity = new MDProjectCollectedDocumentStatusEntity();
                        PrepareInitialView();
                        BindMDProjectCollectedDocumentStatusList();

                        if (mDProjectCollectedDocumentStatusEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Project Collected Document Status Information has been added successfully.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Project Collected Document Status Information has been updated successfully.", false);
                        }
                    }
                    else
                    {
                        if (mDProjectCollectedDocumentStatusEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to add Project Collected Document Status Information.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to update Project Collected Document Status Information.", false);
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

        protected void lvMDProjectCollectedDocumentStatus_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            Int64 ProjectCollectedDocumentStatusID;

            Int64.TryParse(e.CommandArgument.ToString(), out ProjectCollectedDocumentStatusID);

            if (ProjectCollectedDocumentStatusID > 0)
            {
                if (string.Equals(e.CommandName, "EditItem"))
                {
                    _ProjectCollectedDocumentStatusID = ProjectCollectedDocumentStatusID;

                    PrepareEditView();

                    cpeEditor.Collapsed = false;
                    cpeEditor.ClientState = "false";
                }
                else if (string.Equals(e.CommandName, "DeleteItem"))
                {
                    try
                    {
                        Int64 result = -1;

                        String fe = SqlExpressionBuilder.PrepareFilterExpression(MDProjectCollectedDocumentStatusEntity.FLD_NAME_ProjectCollectedDocumentStatusID, ProjectCollectedDocumentStatusID.ToString(), SQLMatchType.Equal);

                        MDProjectCollectedDocumentStatusEntity mDProjectCollectedDocumentStatusEntity = new MDProjectCollectedDocumentStatusEntity();


                        result = FCCMDProjectCollectedDocumentStatus.GetFacadeCreate().Delete(mDProjectCollectedDocumentStatusEntity, fe, DatabaseOperationType.Delete, TransactionRequired.No);

                        if (result == 0)
                        {
                            _ProjectCollectedDocumentStatusID = 0;
                            _MDProjectCollectedDocumentStatusEntity = new MDProjectCollectedDocumentStatusEntity();
                            PrepareInitialView();
                            BindMDProjectCollectedDocumentStatusList();

                            MiscUtil.ShowMessage(lblMessage, "Project Collected Document Status has been successfully deleted.", true);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to delete Project Collected Document Status.", true);
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

        protected void odsMDProjectCollectedDocumentStatus_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {
            e.InputParameters["filterExpression"] = String.Empty;
        }

        #endregion

        #region Button Event

        protected void btnSave_Click(object sender, EventArgs e)
        {
            SaveMDProjectCollectedDocumentStatusEntity();
        }

        protected void btnAddNew_Click(object sender, EventArgs e)
        {
            _ProjectCollectedDocumentStatusID = 0;
            _MDProjectCollectedDocumentStatusEntity = new MDProjectCollectedDocumentStatusEntity();
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
