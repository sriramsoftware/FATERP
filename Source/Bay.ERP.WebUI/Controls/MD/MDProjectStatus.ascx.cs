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
    public partial class MDProjectStatusControl : BaseControl
    {       
        #region Properties

        public Int64 _ProjectStatusID
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

        public MDProjectStatusEntity _MDProjectStatusEntity
        {
            get
            {
                MDProjectStatusEntity entity = new MDProjectStatusEntity();

                if (ViewState["CurrentEntity"] != null)
                {
                    entity = (MDProjectStatusEntity)ViewState["CurrentEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["CurrentEntity"] = value;
            }
        }

        private MDProjectStatusEntity CurrentMDProjectStatusEntity
        {
            get
            {
                if (_ProjectStatusID > 0)
                {
                    if (_MDProjectStatusEntity.ProjectStatusID != _ProjectStatusID)
                    {
                        _MDProjectStatusEntity = FCCMDProjectStatus.GetFacadeCreate().GetByID(_ProjectStatusID);
                    }
                }

                return _MDProjectStatusEntity;
            }
            set
            {
                _MDProjectStatusEntity = value;
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
            MDProjectStatusEntity mDProjectStatusEntity = CurrentMDProjectStatusEntity;


            if (!mDProjectStatusEntity.IsNew)
            {
                txtName.Text = mDProjectStatusEntity.Name.ToString();
                txtDescription.Text = mDProjectStatusEntity.Description.ToString();
                chkIsRemoved.Checked = mDProjectStatusEntity.IsRemoved;

                btnSubmit.Text = "Update";
                btnAddNew.Visible = true;
            }
        }

        private void BindList()
        {
            BindMDProjectStatusList();
        }

        private void BindMDProjectStatusList()
        {
            lvMDProjectStatus.DataBind();
        }

        private MDProjectStatusEntity BuildMDProjectStatusEntity()
        {
            MDProjectStatusEntity mDProjectStatusEntity = CurrentMDProjectStatusEntity;

            mDProjectStatusEntity.Name = txtName.Text.Trim();
            mDProjectStatusEntity.Description = txtDescription.Text.Trim();
            mDProjectStatusEntity.IsRemoved = chkIsRemoved.Checked;


            return mDProjectStatusEntity;
        }

        private void SaveMDProjectStatusEntity()
        {
            if (IsValid)
            {
                try
                {
                    MDProjectStatusEntity mDProjectStatusEntity = BuildMDProjectStatusEntity();

                    Int64 result = -1;

                    if (mDProjectStatusEntity.IsNew)
                    {
                        result = FCCMDProjectStatus.GetFacadeCreate().Add(mDProjectStatusEntity, DatabaseOperationType.Add, TransactionRequired.No);
                    }
                    else
                    {
                        String filterExpression = SqlExpressionBuilder.PrepareFilterExpression(MDProjectStatusEntity.FLD_NAME_ProjectStatusID, mDProjectStatusEntity.ProjectStatusID.ToString(), SQLMatchType.Equal);
                        result = FCCMDProjectStatus.GetFacadeCreate().Update(mDProjectStatusEntity, filterExpression, DatabaseOperationType.Update, TransactionRequired.No);
                    }

                    if (result > 0)
                    {
                        _ProjectStatusID = 0;
                        _MDProjectStatusEntity = new MDProjectStatusEntity();
                        PrepareInitialView();
                        BindMDProjectStatusList();

                        if (mDProjectStatusEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Project Status Information has been added successfully.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Project Status Information has been updated successfully.", false);
                        }
                    }
                    else
                    {
                        if (mDProjectStatusEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to add Project Status Information.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to update Project Status Information.", false);
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

        protected void lvMDProjectStatus_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            Int64 ProjectStatusID;

            Int64.TryParse(e.CommandArgument.ToString(), out ProjectStatusID);

            if (ProjectStatusID > 0)
            {
                if (string.Equals(e.CommandName, "EditItem"))
                {
                    _ProjectStatusID = ProjectStatusID;

                    PrepareEditView();

                    cpeEditor.Collapsed = false;
                    cpeEditor.ClientState = "false";
                }
                else if (string.Equals(e.CommandName, "DeleteItem"))
                {
                    try
                    {
                        Int64 result = -1;

                        String fe = SqlExpressionBuilder.PrepareFilterExpression(MDProjectStatusEntity.FLD_NAME_ProjectStatusID, ProjectStatusID.ToString(), SQLMatchType.Equal);

                        MDProjectStatusEntity mDProjectStatusEntity = new MDProjectStatusEntity();


                        result = FCCMDProjectStatus.GetFacadeCreate().Delete(mDProjectStatusEntity, fe, DatabaseOperationType.Delete, TransactionRequired.No);

                        if (result == 0)
                        {
                            _ProjectStatusID = 0;
                            _MDProjectStatusEntity = new MDProjectStatusEntity();
                            PrepareInitialView();
                            BindMDProjectStatusList();

                            MiscUtil.ShowMessage(lblMessage, "Project Status has been successfully deleted.", true);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to delete Project Status.", true);
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

        protected void odsMDProjectStatus_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {
            e.InputParameters["filterExpression"] = String.Empty;
        }

        #endregion

        #region Button Event

        protected void btnSave_Click(object sender, EventArgs e)
        {
            SaveMDProjectStatusEntity();
        }

        protected void btnAddNew_Click(object sender, EventArgs e)
        {
            _ProjectStatusID = 0;
            _MDProjectStatusEntity = new MDProjectStatusEntity();
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
