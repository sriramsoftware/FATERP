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
    public partial class MDScheduleIdentityCategoryControl : BaseControl
    {       
        #region Properties

        public Int64 _ScheduleIdentityCategoryID
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

        public MDScheduleIdentityCategoryEntity _MDScheduleIdentityCategoryEntity
        {
            get
            {
                MDScheduleIdentityCategoryEntity entity = new MDScheduleIdentityCategoryEntity();

                if (ViewState["CurrentEntity"] != null)
                {
                    entity = (MDScheduleIdentityCategoryEntity)ViewState["CurrentEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["CurrentEntity"] = value;
            }
        }

        private MDScheduleIdentityCategoryEntity CurrentMDScheduleIdentityCategoryEntity
        {
            get
            {
                if (_ScheduleIdentityCategoryID > 0)
                {
                    if (_MDScheduleIdentityCategoryEntity.ScheduleIdentityCategoryID != _ScheduleIdentityCategoryID)
                    {
                        _MDScheduleIdentityCategoryEntity = FCCMDScheduleIdentityCategory.GetFacadeCreate().GetByID(_ScheduleIdentityCategoryID);
                    }
                }

                return _MDScheduleIdentityCategoryEntity;
            }
            set
            {
                _MDScheduleIdentityCategoryEntity = value;
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
            MDScheduleIdentityCategoryEntity mDScheduleIdentityCategoryEntity = CurrentMDScheduleIdentityCategoryEntity;


            if (!mDScheduleIdentityCategoryEntity.IsNew)
            {
                txtName.Text = mDScheduleIdentityCategoryEntity.Name.ToString();
                txtDescription.Text = mDScheduleIdentityCategoryEntity.Description.ToString();
                chkIsRemoved.Checked = mDScheduleIdentityCategoryEntity.IsRemoved;

                btnSubmit.Text = "Update";
                btnAddNew.Visible = true;
            }
        }

        private void BindList()
        {
            BindMDScheduleIdentityCategoryList();
        }

        private void BindMDScheduleIdentityCategoryList()
        {
            lvMDScheduleIdentityCategory.DataBind();
        }

        private MDScheduleIdentityCategoryEntity BuildMDScheduleIdentityCategoryEntity()
        {
            MDScheduleIdentityCategoryEntity mDScheduleIdentityCategoryEntity = CurrentMDScheduleIdentityCategoryEntity;

            mDScheduleIdentityCategoryEntity.Name = txtName.Text.Trim();
            mDScheduleIdentityCategoryEntity.Description = txtDescription.Text.Trim();
            mDScheduleIdentityCategoryEntity.IsRemoved = chkIsRemoved.Checked;


            return mDScheduleIdentityCategoryEntity;
        }

        private void SaveMDScheduleIdentityCategoryEntity()
        {
            if (IsValid)
            {
                try
                {
                    MDScheduleIdentityCategoryEntity mDScheduleIdentityCategoryEntity = BuildMDScheduleIdentityCategoryEntity();

                    Int64 result = -1;

                    if (mDScheduleIdentityCategoryEntity.IsNew)
                    {
                        result = FCCMDScheduleIdentityCategory.GetFacadeCreate().Add(mDScheduleIdentityCategoryEntity, DatabaseOperationType.Add, TransactionRequired.No);
                    }
                    else
                    {
                        String filterExpression = SqlExpressionBuilder.PrepareFilterExpression(MDScheduleIdentityCategoryEntity.FLD_NAME_ScheduleIdentityCategoryID, mDScheduleIdentityCategoryEntity.ScheduleIdentityCategoryID.ToString(), SQLMatchType.Equal);
                        result = FCCMDScheduleIdentityCategory.GetFacadeCreate().Update(mDScheduleIdentityCategoryEntity, filterExpression, DatabaseOperationType.Update, TransactionRequired.No);
                    }

                    if (result > 0)
                    {
                        _ScheduleIdentityCategoryID = 0;
                        _MDScheduleIdentityCategoryEntity = new MDScheduleIdentityCategoryEntity();
                        PrepareInitialView();
                        BindMDScheduleIdentityCategoryList();

                        if (mDScheduleIdentityCategoryEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Schedule Identity Category Information has been added successfully.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Schedule Identity Category Information has been updated successfully.", false);
                        }
                    }
                    else
                    {
                        if (mDScheduleIdentityCategoryEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to add Schedule Identity Category Information.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to update Schedule Identity Category Information.", false);
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

        protected void lvMDScheduleIdentityCategory_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            Int64 ScheduleIdentityCategoryID;

            Int64.TryParse(e.CommandArgument.ToString(), out ScheduleIdentityCategoryID);

            if (ScheduleIdentityCategoryID > 0)
            {
                if (string.Equals(e.CommandName, "EditItem"))
                {
                    _ScheduleIdentityCategoryID = ScheduleIdentityCategoryID;

                    PrepareEditView();

                    cpeEditor.Collapsed = false;
                    cpeEditor.ClientState = "false";
                }
                else if (string.Equals(e.CommandName, "DeleteItem"))
                {
                    try
                    {
                        Int64 result = -1;

                        String fe = SqlExpressionBuilder.PrepareFilterExpression(MDScheduleIdentityCategoryEntity.FLD_NAME_ScheduleIdentityCategoryID, ScheduleIdentityCategoryID.ToString(), SQLMatchType.Equal);

                        MDScheduleIdentityCategoryEntity mDScheduleIdentityCategoryEntity = new MDScheduleIdentityCategoryEntity();


                        result = FCCMDScheduleIdentityCategory.GetFacadeCreate().Delete(mDScheduleIdentityCategoryEntity, fe, DatabaseOperationType.Delete, TransactionRequired.No);

                        if (result == 0)
                        {
                            _ScheduleIdentityCategoryID = 0;
                            _MDScheduleIdentityCategoryEntity = new MDScheduleIdentityCategoryEntity();
                            PrepareInitialView();
                            BindMDScheduleIdentityCategoryList();

                            MiscUtil.ShowMessage(lblMessage, "Schedule Identity Category has been successfully deleted.", true);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to delete Schedule Identity Category.", true);
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

        protected void odsMDScheduleIdentityCategory_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {
            e.InputParameters["filterExpression"] = String.Empty;
        }

        #endregion

        #region Button Event

        protected void btnSave_Click(object sender, EventArgs e)
        {
            SaveMDScheduleIdentityCategoryEntity();
        }

        protected void btnAddNew_Click(object sender, EventArgs e)
        {
            _ScheduleIdentityCategoryID = 0;
            _MDScheduleIdentityCategoryEntity = new MDScheduleIdentityCategoryEntity();
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
