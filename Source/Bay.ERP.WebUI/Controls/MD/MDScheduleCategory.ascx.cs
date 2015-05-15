// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 28-Dec-2011, 07:18:54




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
    public partial class MDScheduleCategoryControl : BaseControl
    {       
        #region Properties

        public Int64 _ScheduleCategoryID
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

        public MDScheduleCategoryEntity _MDScheduleCategoryEntity
        {
            get
            {
                MDScheduleCategoryEntity entity = new MDScheduleCategoryEntity();

                if (ViewState["CurrentEntity"] != null)
                {
                    entity = (MDScheduleCategoryEntity)ViewState["CurrentEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["CurrentEntity"] = value;
            }
        }

        private MDScheduleCategoryEntity CurrentMDScheduleCategoryEntity
        {
            get
            {
                if (_ScheduleCategoryID > 0)
                {
                    if (_MDScheduleCategoryEntity.ScheduleCategoryID != _ScheduleCategoryID)
                    {
                        _MDScheduleCategoryEntity = FCCMDScheduleCategory.GetFacadeCreate().GetByID(_ScheduleCategoryID);
                    }
                }

                return _MDScheduleCategoryEntity;
            }
            set
            {
                _MDScheduleCategoryEntity = value;
            }
        }

        #endregion

        #region Methods

        private void BuildDropDownList()
        {
            MiscUtil.PopulateMDScheduleIdentityCategory(ddlScheduleIdentityCategoryID, false);
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
            MDScheduleCategoryEntity mDScheduleCategoryEntity = CurrentMDScheduleCategoryEntity;


            if (!mDScheduleCategoryEntity.IsNew)
            {
                if (ddlScheduleIdentityCategoryID.Items.Count > 0 && mDScheduleCategoryEntity.ScheduleIdentityCategoryID != null)
                {
                    ddlScheduleIdentityCategoryID.SelectedValue = mDScheduleCategoryEntity.ScheduleIdentityCategoryID.ToString();
                }

                txtName.Text = mDScheduleCategoryEntity.Name.ToString();
                txtDescription.Text = mDScheduleCategoryEntity.Description.ToString();
                chkIsRemoved.Checked = mDScheduleCategoryEntity.IsRemoved;

                btnSubmit.Text = "Update";
                btnAddNew.Visible = true;
            }
        }

        private void BindList()
        {
            BindMDScheduleCategoryList();
        }

        private void BindMDScheduleCategoryList()
        {
            lvMDScheduleCategory.DataBind();
        }

        private MDScheduleCategoryEntity BuildMDScheduleCategoryEntity()
        {
            MDScheduleCategoryEntity mDScheduleCategoryEntity = CurrentMDScheduleCategoryEntity;

            if (ddlScheduleIdentityCategoryID.Items.Count > 0)
            {
                if (ddlScheduleIdentityCategoryID.SelectedValue == "0")
                {
                }
                else
                {
                    mDScheduleCategoryEntity.ScheduleIdentityCategoryID = Int64.Parse(ddlScheduleIdentityCategoryID.SelectedValue);
                }
            }

            mDScheduleCategoryEntity.Name = txtName.Text.Trim();
            mDScheduleCategoryEntity.Description = txtDescription.Text.Trim();
            mDScheduleCategoryEntity.IsRemoved = chkIsRemoved.Checked;


            return mDScheduleCategoryEntity;
        }

        private void SaveMDScheduleCategoryEntity()
        {
            if (IsValid)
            {
                try
                {
                    MDScheduleCategoryEntity mDScheduleCategoryEntity = BuildMDScheduleCategoryEntity();

                    Int64 result = -1;

                    if (mDScheduleCategoryEntity.IsNew)
                    {
                        result = FCCMDScheduleCategory.GetFacadeCreate().Add(mDScheduleCategoryEntity, DatabaseOperationType.Add, TransactionRequired.No);
                    }
                    else
                    {
                        String filterExpression = SqlExpressionBuilder.PrepareFilterExpression(MDScheduleCategoryEntity.FLD_NAME_ScheduleCategoryID, mDScheduleCategoryEntity.ScheduleCategoryID.ToString(), SQLMatchType.Equal);
                        result = FCCMDScheduleCategory.GetFacadeCreate().Update(mDScheduleCategoryEntity, filterExpression, DatabaseOperationType.Update, TransactionRequired.No);
                    }

                    if (result > 0)
                    {
                        _ScheduleCategoryID = 0;
                        _MDScheduleCategoryEntity = new MDScheduleCategoryEntity();
                        PrepareInitialView();
                        BindMDScheduleCategoryList();

                        if (mDScheduleCategoryEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Schedule Category Information has been added successfully.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Schedule Category Information has been updated successfully.", false);
                        }
                    }
                    else
                    {
                        if (mDScheduleCategoryEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to add Schedule Category Information.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to update Schedule Category Information.", false);
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

        protected void lvMDScheduleCategory_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            Int64 ScheduleCategoryID;

            Int64.TryParse(e.CommandArgument.ToString(), out ScheduleCategoryID);

            if (ScheduleCategoryID > 0)
            {
                if (string.Equals(e.CommandName, "EditItem"))
                {
                    _ScheduleCategoryID = ScheduleCategoryID;

                    PrepareEditView();

                    cpeEditor.Collapsed = false;
                    cpeEditor.ClientState = "false";
                }
                else if (string.Equals(e.CommandName, "DeleteItem"))
                {
                    try
                    {
                        Int64 result = -1;

                        String fe = SqlExpressionBuilder.PrepareFilterExpression(MDScheduleCategoryEntity.FLD_NAME_ScheduleCategoryID, ScheduleCategoryID.ToString(), SQLMatchType.Equal);

                        MDScheduleCategoryEntity mDScheduleCategoryEntity = new MDScheduleCategoryEntity();


                        result = FCCMDScheduleCategory.GetFacadeCreate().Delete(mDScheduleCategoryEntity, fe, DatabaseOperationType.Delete, TransactionRequired.No);

                        if (result == 0)
                        {
                            _ScheduleCategoryID = 0;
                            _MDScheduleCategoryEntity = new MDScheduleCategoryEntity();
                            PrepareInitialView();
                            BindMDScheduleCategoryList();

                            MiscUtil.ShowMessage(lblMessage, "Schedule Category has been successfully deleted.", true);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to delete Schedule Category.", true);
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

        protected void odsMDScheduleCategory_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {
            e.InputParameters["filterExpression"] = String.Empty;
        }

        #endregion

        #region Button Event

        protected void btnSave_Click(object sender, EventArgs e)
        {
            SaveMDScheduleCategoryEntity();
        }

        protected void btnAddNew_Click(object sender, EventArgs e)
        {
            _ScheduleCategoryID = 0;
            _MDScheduleCategoryEntity = new MDScheduleCategoryEntity();
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
