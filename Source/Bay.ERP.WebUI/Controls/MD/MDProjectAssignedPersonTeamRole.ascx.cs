// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 15-Jul-2012, 05:23:43




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
    public partial class MDProjectAssignedPersonTeamRoleControl : BaseControl
    {       
        #region Properties

        public Int64 _ProjectAssignedPersonTeamRoleID
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

        public MDProjectAssignedPersonTeamRoleEntity _MDProjectAssignedPersonTeamRoleEntity
        {
            get
            {
                MDProjectAssignedPersonTeamRoleEntity entity = new MDProjectAssignedPersonTeamRoleEntity();

                if (ViewState["CurrentEntity"] != null)
                {
                    entity = (MDProjectAssignedPersonTeamRoleEntity)ViewState["CurrentEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["CurrentEntity"] = value;
            }
        }

        private MDProjectAssignedPersonTeamRoleEntity CurrentMDProjectAssignedPersonTeamRoleEntity
        {
            get
            {
                if (_ProjectAssignedPersonTeamRoleID > 0)
                {
                    if (_MDProjectAssignedPersonTeamRoleEntity.ProjectAssignedPersonTeamRoleID != _ProjectAssignedPersonTeamRoleID)
                    {
                        _MDProjectAssignedPersonTeamRoleEntity = FCCMDProjectAssignedPersonTeamRole.GetFacadeCreate().GetByID(_ProjectAssignedPersonTeamRoleID);
                    }
                }

                return _MDProjectAssignedPersonTeamRoleEntity;
            }
            set
            {
                _MDProjectAssignedPersonTeamRoleEntity = value;
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
            MDProjectAssignedPersonTeamRoleEntity mDProjectAssignedPersonTeamRoleEntity = CurrentMDProjectAssignedPersonTeamRoleEntity;


            if (!mDProjectAssignedPersonTeamRoleEntity.IsNew)
            {
                txtName.Text = mDProjectAssignedPersonTeamRoleEntity.Name.ToString();
                txtDescription.Text = mDProjectAssignedPersonTeamRoleEntity.Description.ToString();
                chkIsRemoved.Checked = mDProjectAssignedPersonTeamRoleEntity.IsRemoved;

                btnSubmit.Text = "Update";
                btnAddNew.Visible = true;
            }
        }

        private void BindList()
        {
            BindMDProjectAssignedPersonTeamRoleList();
        }

        private void BindMDProjectAssignedPersonTeamRoleList()
        {
            lvMDProjectAssignedPersonTeamRole.DataBind();
        }

        private MDProjectAssignedPersonTeamRoleEntity BuildMDProjectAssignedPersonTeamRoleEntity()
        {
            MDProjectAssignedPersonTeamRoleEntity mDProjectAssignedPersonTeamRoleEntity = CurrentMDProjectAssignedPersonTeamRoleEntity;

            mDProjectAssignedPersonTeamRoleEntity.Name = txtName.Text.Trim();
            mDProjectAssignedPersonTeamRoleEntity.Description = txtDescription.Text.Trim();
            mDProjectAssignedPersonTeamRoleEntity.IsRemoved = chkIsRemoved.Checked;


            return mDProjectAssignedPersonTeamRoleEntity;
        }

        private void SaveMDProjectAssignedPersonTeamRoleEntity()
        {
            if (IsValid)
            {
                try
                {
                    MDProjectAssignedPersonTeamRoleEntity mDProjectAssignedPersonTeamRoleEntity = BuildMDProjectAssignedPersonTeamRoleEntity();

                    Int64 result = -1;

                    if (mDProjectAssignedPersonTeamRoleEntity.IsNew)
                    {
                        result = FCCMDProjectAssignedPersonTeamRole.GetFacadeCreate().Add(mDProjectAssignedPersonTeamRoleEntity, DatabaseOperationType.Add, TransactionRequired.No);
                    }
                    else
                    {
                        String filterExpression = SqlExpressionBuilder.PrepareFilterExpression(MDProjectAssignedPersonTeamRoleEntity.FLD_NAME_ProjectAssignedPersonTeamRoleID, mDProjectAssignedPersonTeamRoleEntity.ProjectAssignedPersonTeamRoleID.ToString(), SQLMatchType.Equal);
                        result = FCCMDProjectAssignedPersonTeamRole.GetFacadeCreate().Update(mDProjectAssignedPersonTeamRoleEntity, filterExpression, DatabaseOperationType.Update, TransactionRequired.No);
                    }

                    if (result > 0)
                    {
                        _ProjectAssignedPersonTeamRoleID = 0;
                        _MDProjectAssignedPersonTeamRoleEntity = new MDProjectAssignedPersonTeamRoleEntity();
                        PrepareInitialView();
                        BindMDProjectAssignedPersonTeamRoleList();

                        if (mDProjectAssignedPersonTeamRoleEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Project Assigned Person Team Role Information has been added successfully.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Project Assigned Person Team Role Information has been updated successfully.", false);
                        }
                    }
                    else
                    {
                        if (mDProjectAssignedPersonTeamRoleEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to add Project Assigned Person Team Role Information.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to update Project Assigned Person Team Role Information.", false);
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

        protected void lvMDProjectAssignedPersonTeamRole_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            Int64 ProjectAssignedPersonTeamRoleID;

            Int64.TryParse(e.CommandArgument.ToString(), out ProjectAssignedPersonTeamRoleID);

            if (ProjectAssignedPersonTeamRoleID > 0)
            {
                if (string.Equals(e.CommandName, "EditItem"))
                {
                    _ProjectAssignedPersonTeamRoleID = ProjectAssignedPersonTeamRoleID;

                    PrepareEditView();

                    cpeEditor.Collapsed = false;
                    cpeEditor.ClientState = "false";
                }
                else if (string.Equals(e.CommandName, "DeleteItem"))
                {
                    try
                    {
                        Int64 result = -1;

                        String fe = SqlExpressionBuilder.PrepareFilterExpression(MDProjectAssignedPersonTeamRoleEntity.FLD_NAME_ProjectAssignedPersonTeamRoleID, ProjectAssignedPersonTeamRoleID.ToString(), SQLMatchType.Equal);

                        MDProjectAssignedPersonTeamRoleEntity mDProjectAssignedPersonTeamRoleEntity = new MDProjectAssignedPersonTeamRoleEntity();


                        result = FCCMDProjectAssignedPersonTeamRole.GetFacadeCreate().Delete(mDProjectAssignedPersonTeamRoleEntity, fe, DatabaseOperationType.Delete, TransactionRequired.No);

                        if (result == 0)
                        {
                            _ProjectAssignedPersonTeamRoleID = 0;
                            _MDProjectAssignedPersonTeamRoleEntity = new MDProjectAssignedPersonTeamRoleEntity();
                            PrepareInitialView();
                            BindMDProjectAssignedPersonTeamRoleList();

                            MiscUtil.ShowMessage(lblMessage, "Project Assigned Person Team Role has been successfully deleted.", true);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to delete Project Assigned Person Team Role.", true);
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

        protected void odsMDProjectAssignedPersonTeamRole_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {
            e.InputParameters["filterExpression"] = String.Empty;
        }

        #endregion

        #region Button Event

        protected void btnSave_Click(object sender, EventArgs e)
        {
            SaveMDProjectAssignedPersonTeamRoleEntity();
        }

        protected void btnAddNew_Click(object sender, EventArgs e)
        {
            _ProjectAssignedPersonTeamRoleID = 0;
            _MDProjectAssignedPersonTeamRoleEntity = new MDProjectAssignedPersonTeamRoleEntity();
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
