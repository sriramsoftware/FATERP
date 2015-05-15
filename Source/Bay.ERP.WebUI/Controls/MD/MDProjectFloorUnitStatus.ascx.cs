// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 01-Apr-2013, 03:04:35




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
    public partial class MDProjectFloorUnitStatusControl : BaseControl
    {       
        #region Properties

        public Int64 _ProjectFloorUnitStatusID
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

        public MDProjectFloorUnitStatusEntity _MDProjectFloorUnitStatusEntity
        {
            get
            {
                MDProjectFloorUnitStatusEntity entity = new MDProjectFloorUnitStatusEntity();

                if (ViewState["CurrentEntity"] != null)
                {
                    entity = (MDProjectFloorUnitStatusEntity)ViewState["CurrentEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["CurrentEntity"] = value;
            }
        }

        private MDProjectFloorUnitStatusEntity CurrentMDProjectFloorUnitStatusEntity
        {
            get
            {
                if (_ProjectFloorUnitStatusID > 0)
                {
                    if (_MDProjectFloorUnitStatusEntity.ProjectFloorUnitStatusID != _ProjectFloorUnitStatusID)
                    {
                        _MDProjectFloorUnitStatusEntity = FCCMDProjectFloorUnitStatus.GetFacadeCreate().GetByID(_ProjectFloorUnitStatusID);
                    }
                }

                return _MDProjectFloorUnitStatusEntity;
            }
            set
            {
                _MDProjectFloorUnitStatusEntity = value;
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
            MDProjectFloorUnitStatusEntity mDProjectFloorUnitStatusEntity = CurrentMDProjectFloorUnitStatusEntity;


            if (!mDProjectFloorUnitStatusEntity.IsNew)
            {
                txtName.Text = mDProjectFloorUnitStatusEntity.Name.ToString();
                txtDescription.Text = mDProjectFloorUnitStatusEntity.Description.ToString();
                chkIsRemoved.Checked = mDProjectFloorUnitStatusEntity.IsRemoved;

                btnSubmit.Text = "Update";
                btnAddNew.Visible = true;
            }
        }

        private void BindList()
        {
            BindMDProjectFloorUnitStatusList();
        }

        private void BindMDProjectFloorUnitStatusList()
        {
            lvMDProjectFloorUnitStatus.DataBind();
        }

        private MDProjectFloorUnitStatusEntity BuildMDProjectFloorUnitStatusEntity()
        {
            MDProjectFloorUnitStatusEntity mDProjectFloorUnitStatusEntity = CurrentMDProjectFloorUnitStatusEntity;

            mDProjectFloorUnitStatusEntity.Name = txtName.Text.Trim();
            mDProjectFloorUnitStatusEntity.Description = txtDescription.Text.Trim();
            mDProjectFloorUnitStatusEntity.IsRemoved = chkIsRemoved.Checked;


            return mDProjectFloorUnitStatusEntity;
        }

        private void SaveMDProjectFloorUnitStatusEntity()
        {
            if (IsValid)
            {
                try
                {
                    MDProjectFloorUnitStatusEntity mDProjectFloorUnitStatusEntity = BuildMDProjectFloorUnitStatusEntity();

                    Int64 result = -1;

                    if (mDProjectFloorUnitStatusEntity.IsNew)
                    {
                        result = FCCMDProjectFloorUnitStatus.GetFacadeCreate().Add(mDProjectFloorUnitStatusEntity, DatabaseOperationType.Add, TransactionRequired.No);
                    }
                    else
                    {
                        String filterExpression = SqlExpressionBuilder.PrepareFilterExpression(MDProjectFloorUnitStatusEntity.FLD_NAME_ProjectFloorUnitStatusID, mDProjectFloorUnitStatusEntity.ProjectFloorUnitStatusID.ToString(), SQLMatchType.Equal);
                        result = FCCMDProjectFloorUnitStatus.GetFacadeCreate().Update(mDProjectFloorUnitStatusEntity, filterExpression, DatabaseOperationType.Update, TransactionRequired.No);
                    }

                    if (result > 0)
                    {
                        _ProjectFloorUnitStatusID = 0;
                        _MDProjectFloorUnitStatusEntity = new MDProjectFloorUnitStatusEntity();
                        PrepareInitialView();
                        BindMDProjectFloorUnitStatusList();

                        if (mDProjectFloorUnitStatusEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Project Floor Unit Status Information has been added successfully.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Project Floor Unit Status Information has been updated successfully.", false);
                        }
                    }
                    else
                    {
                        if (mDProjectFloorUnitStatusEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to add Project Floor Unit Status Information.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to update Project Floor Unit Status Information.", false);
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

        protected void lvMDProjectFloorUnitStatus_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            Int64 ProjectFloorUnitStatusID;

            Int64.TryParse(e.CommandArgument.ToString(), out ProjectFloorUnitStatusID);

            if (ProjectFloorUnitStatusID > 0)
            {
                if (string.Equals(e.CommandName, "EditItem"))
                {
                    _ProjectFloorUnitStatusID = ProjectFloorUnitStatusID;

                    PrepareEditView();

                    cpeEditor.Collapsed = false;
                    cpeEditor.ClientState = "false";
                }
                else if (string.Equals(e.CommandName, "DeleteItem"))
                {
                    try
                    {
                        Int64 result = -1;

                        String fe = SqlExpressionBuilder.PrepareFilterExpression(MDProjectFloorUnitStatusEntity.FLD_NAME_ProjectFloorUnitStatusID, ProjectFloorUnitStatusID.ToString(), SQLMatchType.Equal);

                        MDProjectFloorUnitStatusEntity mDProjectFloorUnitStatusEntity = new MDProjectFloorUnitStatusEntity();


                        result = FCCMDProjectFloorUnitStatus.GetFacadeCreate().Delete(mDProjectFloorUnitStatusEntity, fe, DatabaseOperationType.Delete, TransactionRequired.No);

                        if (result == 0)
                        {
                            _ProjectFloorUnitStatusID = 0;
                            _MDProjectFloorUnitStatusEntity = new MDProjectFloorUnitStatusEntity();
                            PrepareInitialView();
                            BindMDProjectFloorUnitStatusList();

                            MiscUtil.ShowMessage(lblMessage, "Project Floor Unit Status has been successfully deleted.", true);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to delete Project Floor Unit Status.", true);
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

        protected void odsMDProjectFloorUnitStatus_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {
            e.InputParameters["filterExpression"] = String.Empty;
        }

        #endregion

        #region Button Event

        protected void btnSave_Click(object sender, EventArgs e)
        {
            SaveMDProjectFloorUnitStatusEntity();
        }

        protected void btnAddNew_Click(object sender, EventArgs e)
        {
            _ProjectFloorUnitStatusID = 0;
            _MDProjectFloorUnitStatusEntity = new MDProjectFloorUnitStatusEntity();
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
