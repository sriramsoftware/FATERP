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
    public partial class MDProjectFloorUnitTypeControl : BaseControl
    {       
        #region Properties

        public Int64 _ProjectFloorUnitTypeID
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

        public MDProjectFloorUnitTypeEntity _MDProjectFloorUnitTypeEntity
        {
            get
            {
                MDProjectFloorUnitTypeEntity entity = new MDProjectFloorUnitTypeEntity();

                if (ViewState["CurrentEntity"] != null)
                {
                    entity = (MDProjectFloorUnitTypeEntity)ViewState["CurrentEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["CurrentEntity"] = value;
            }
        }

        private MDProjectFloorUnitTypeEntity CurrentMDProjectFloorUnitTypeEntity
        {
            get
            {
                if (_ProjectFloorUnitTypeID > 0)
                {
                    if (_MDProjectFloorUnitTypeEntity.ProjectFloorUnitTypeID != _ProjectFloorUnitTypeID)
                    {
                        _MDProjectFloorUnitTypeEntity = FCCMDProjectFloorUnitType.GetFacadeCreate().GetByID(_ProjectFloorUnitTypeID);
                    }
                }

                return _MDProjectFloorUnitTypeEntity;
            }
            set
            {
                _MDProjectFloorUnitTypeEntity = value;
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
            MDProjectFloorUnitTypeEntity mDProjectFloorUnitTypeEntity = CurrentMDProjectFloorUnitTypeEntity;


            if (!mDProjectFloorUnitTypeEntity.IsNew)
            {
                txtName.Text = mDProjectFloorUnitTypeEntity.Name.ToString();
                txtDescription.Text = mDProjectFloorUnitTypeEntity.Description.ToString();
                chkIsRemoved.Checked = mDProjectFloorUnitTypeEntity.IsRemoved;

                btnSubmit.Text = "Update";
                btnAddNew.Visible = true;
            }
        }

        private void BindList()
        {
            BindMDProjectFloorUnitTypeList();
        }

        private void BindMDProjectFloorUnitTypeList()
        {
            lvMDProjectFloorUnitType.DataBind();
        }

        private MDProjectFloorUnitTypeEntity BuildMDProjectFloorUnitTypeEntity()
        {
            MDProjectFloorUnitTypeEntity mDProjectFloorUnitTypeEntity = CurrentMDProjectFloorUnitTypeEntity;

            mDProjectFloorUnitTypeEntity.Name = txtName.Text.Trim();
            mDProjectFloorUnitTypeEntity.Description = txtDescription.Text.Trim();
            mDProjectFloorUnitTypeEntity.IsRemoved = chkIsRemoved.Checked;


            return mDProjectFloorUnitTypeEntity;
        }

        private void SaveMDProjectFloorUnitTypeEntity()
        {
            if (IsValid)
            {
                try
                {
                    MDProjectFloorUnitTypeEntity mDProjectFloorUnitTypeEntity = BuildMDProjectFloorUnitTypeEntity();

                    Int64 result = -1;

                    if (mDProjectFloorUnitTypeEntity.IsNew)
                    {
                        result = FCCMDProjectFloorUnitType.GetFacadeCreate().Add(mDProjectFloorUnitTypeEntity, DatabaseOperationType.Add, TransactionRequired.No);
                    }
                    else
                    {
                        String filterExpression = SqlExpressionBuilder.PrepareFilterExpression(MDProjectFloorUnitTypeEntity.FLD_NAME_ProjectFloorUnitTypeID, mDProjectFloorUnitTypeEntity.ProjectFloorUnitTypeID.ToString(), SQLMatchType.Equal);
                        result = FCCMDProjectFloorUnitType.GetFacadeCreate().Update(mDProjectFloorUnitTypeEntity, filterExpression, DatabaseOperationType.Update, TransactionRequired.No);
                    }

                    if (result > 0)
                    {
                        _ProjectFloorUnitTypeID = 0;
                        _MDProjectFloorUnitTypeEntity = new MDProjectFloorUnitTypeEntity();
                        PrepareInitialView();
                        BindMDProjectFloorUnitTypeList();

                        if (mDProjectFloorUnitTypeEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Project Floor Unit Type Information has been added successfully.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Project Floor Unit Type Information has been updated successfully.", false);
                        }
                    }
                    else
                    {
                        if (mDProjectFloorUnitTypeEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to add Project Floor Unit Type Information.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to update Project Floor Unit Type Information.", false);
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

        protected void lvMDProjectFloorUnitType_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            Int64 ProjectFloorUnitTypeID;

            Int64.TryParse(e.CommandArgument.ToString(), out ProjectFloorUnitTypeID);

            if (ProjectFloorUnitTypeID > 0)
            {
                if (string.Equals(e.CommandName, "EditItem"))
                {
                    _ProjectFloorUnitTypeID = ProjectFloorUnitTypeID;

                    PrepareEditView();

                    cpeEditor.Collapsed = false;
                    cpeEditor.ClientState = "false";
                }
                else if (string.Equals(e.CommandName, "DeleteItem"))
                {
                    try
                    {
                        Int64 result = -1;

                        String fe = SqlExpressionBuilder.PrepareFilterExpression(MDProjectFloorUnitTypeEntity.FLD_NAME_ProjectFloorUnitTypeID, ProjectFloorUnitTypeID.ToString(), SQLMatchType.Equal);

                        MDProjectFloorUnitTypeEntity mDProjectFloorUnitTypeEntity = new MDProjectFloorUnitTypeEntity();


                        result = FCCMDProjectFloorUnitType.GetFacadeCreate().Delete(mDProjectFloorUnitTypeEntity, fe, DatabaseOperationType.Delete, TransactionRequired.No);

                        if (result == 0)
                        {
                            _ProjectFloorUnitTypeID = 0;
                            _MDProjectFloorUnitTypeEntity = new MDProjectFloorUnitTypeEntity();
                            PrepareInitialView();
                            BindMDProjectFloorUnitTypeList();

                            MiscUtil.ShowMessage(lblMessage, "Project Floor Unit Type has been successfully deleted.", true);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to delete Project Floor Unit Type.", true);
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

        protected void odsMDProjectFloorUnitType_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {
            e.InputParameters["filterExpression"] = String.Empty;
        }

        #endregion

        #region Button Event

        protected void btnSave_Click(object sender, EventArgs e)
        {
            SaveMDProjectFloorUnitTypeEntity();
        }

        protected void btnAddNew_Click(object sender, EventArgs e)
        {
            _ProjectFloorUnitTypeID = 0;
            _MDProjectFloorUnitTypeEntity = new MDProjectFloorUnitTypeEntity();
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
